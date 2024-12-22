<?php
class Employee
{
    //ตัวแปรที่ใช้เพื่อการติดต่อฐานข้อมูล
    private $connectDB;

    //ตัวแปรสารพัดประโยชน์
    public $message;

    //ตัวแปรที่ล้อกับคอลัมน์/ฟิวล์ในตารางในฐานข้อมูลที่จะทำงานด้วย
    public $empId;
    public $empName;
    public $empImage;
    public $empPhonenum;
    public $empPassword;
    public $createAt;

    //คอนสตรักเตอร์
    public function __construct($connectDB)
    {   //เพื่อกำหนดค่าให้กับตัวแปรที่จะใช้งานฐานข้อมูล
        $this->connectDB = $connectDB;
    }

    //-----------------------------------
    //   ฟังก์ชันที่ทำงานกับตารางในฐานข้อมูลที่ล้อกับ API ที่ Client/User เรียกใช้
    //-----------------------------------

    //ฟังก์ชันที่ใช้ร่วมกับ API ที่จะเอาข้อมูลพนักงาน(ใหม่)มาเพิ่มเข้าไปในตารางในฐานข้อมูล
    public function insertEmployee()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "INSERT INTO 
                    employee_tb 
                    (empName, empImage, empPhonenum, empPassword) 
                    VALUES
                    (:empName, :empImage, :empPhonenum, :empPassword)";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter
        $this->empName  = htmlspecialchars(strip_tags($this->empName));
        $this->empImage  = htmlspecialchars(strip_tags($this->empImage));
        $this->empPhonenum  = htmlspecialchars(strip_tags($this->empPhonenum));
        $this->empPassword  = htmlspecialchars(strip_tags($this->empPassword));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":empName", $this->empName);
        $stmt->bindParam(":empImage", $this->empImage);
        $stmt->bindParam(":empPhonenum", $this->empPhonenum);
        $stmt->bindParam(":empPassword", $this->empPassword);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }

    //ฟังก์ชันลบ เงื่อนไขคือ รหัสประเภทพนักงาน
    public function deleteEmployee()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "DELETE FROM
                    employee_tb
                    WHERE
                    empId = :empId
                    ";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter  
        $this->empId = intval(htmlspecialchars(strip_tags($this->empId)));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":empId", $this->empId);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }

    //ฟังก์ชันลบ เงื่อนไขคือ รหัสประเภทพนักงาน
    public function updateEmployee()
    {
        //คำสั่ง SQL เก็บในตัวแปร 
        $strSQL = "";
        if (isset($this->empImage)) {
            //อัปเดจรูป
            $strSQL = "UPDATE employee_tb SET
                            empName = :empName,
                            empImage = :empImage,
                            empPhonenum = :empPhonenum,
                            empPassword = :empPassword
                        WHERE
                            empId = :empId
                     ";
        } else {
            //ไม่อัปเดจรูป
            $strSQL = "UPDATE employee_tb SET
                            empName = :empName,
                            empPhonenum = :empPhonenum,
                            empPassword = :empPassword
                        WHERE
                            empId = :empId
                     ";
        }

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter
        $this->empId  = intval(htmlspecialchars(strip_tags($this->empId)));
        $this->empName  = htmlspecialchars(strip_tags($this->empName));
        if (isset($this->empImage)) {
            $this->empImage  = htmlspecialchars(strip_tags($this->empImage));
        }
        $this->empPhonenum  = htmlspecialchars(strip_tags($this->empPhonenum));
        $this->empPassword  = htmlspecialchars(strip_tags($this->empPassword));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":empId", $this->empId);
        $stmt->bindParam(":empName", $this->empName);
        if (isset($this->empImage)) {
            $stmt->bindParam(":empImage", $this->empImage);
        }
        $stmt->bindParam(":empPhonenum", $this->empPhonenum);
        $stmt->bindParam(":empPassword", $this->empPassword);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }

    //ฟังก์ตรวจสอบการเข้าใช้งานของพนักงาน
    public function checkEmployeeLogin()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "SELECT 
                        empId, empName, empImage, empPhonenum, empPassword
                    FROM
                        employee_tb
                    WHERE 
                        empPhonenum = :empPhonenum AND empPassword = :empPassword";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter
        $this->empPhonenum  = htmlspecialchars(strip_tags($this->empPhonenum));
        $this->empPassword  = htmlspecialchars(strip_tags($this->empPassword));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter      
        $stmt->bindParam(":empPhonenum", $this->empPhonenum);
        $stmt->bindParam(":empPassword", $this->empPassword);

        //สั่งให้คำสั่ง sql ทำงาน
        $stmt->execute();

        return $stmt;
    }
}
