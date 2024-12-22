<?php
class Customer
{
    //ตัวแปรที่ใช้เพื่อการติดต่อฐานข้อมูล
    private $connectDB;

    //ตัวแปรสารพัดประโยชน์
    public $message;

    //ตัวแปรที่ล้อกับคอลัมน์/ฟิวล์ในตารางในฐานข้อมูลที่จะทำงานด้วย
    public $custId;
    public $custName;
    public $custEmail;
    public $custPhonenum;
    public $custPassword;
    public $createAt;

    //คอนสตรักเตอร์
    public function __construct($connectDB)
    {   //เพื่อกำหนดค่าให้กับตัวแปรที่จะใช้งานฐานข้อมูล
        $this->connectDB = $connectDB;
    }

    //-----------------------------------
    //   ฟังก์ชันที่ทำงานกับตารางในฐานข้อมูลที่ล้อกับ API ที่ Client/User เรียกใช้
    //-----------------------------------

    //ฟังก์ชันที่ใช้ร่วมกับ API ที่จะเอาข้อมูลลูกค้า(ใหม่)มาเพิ่มเข้าไปในตารางในฐานข้อมูล
    public function insertCustomer()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "INSERT INTO 
                customer_tb 
                (custName, custEmail, custPhonenum, custPassword) 
                VALUES
                (:custName, :custEmail, :custPhonenum, :custPassword)";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter
        $this->custName  = htmlspecialchars(strip_tags($this->custName));
        $this->custEmail  = htmlspecialchars(strip_tags($this->custEmail));
        $this->custPhonenum  = htmlspecialchars(strip_tags($this->custPhonenum));
        $this->custPassword  = htmlspecialchars(strip_tags($this->custPassword));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":custName", $this->custName);
        $stmt->bindParam(":custEmail", $this->custEmail);
        $stmt->bindParam(":custPhonenum", $this->custPhonenum);
        $stmt->bindParam(":custPassword", $this->custPassword);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }

    //ฟังก์ชันลบ เงื่อนไขคือ รหัสประเภทลูกค้า
    public function deleteCustomer()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "DELETE FROM
                    customer_tb
                    WHERE
                    custId = :custId
                    ";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter  
        $this->custId = intval(htmlspecialchars(strip_tags($this->custId)));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":custId", $this->custId);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }

    //ฟังก์ชันแก้ไข เงื่อนไขคือ รหัสประเภทลูกค้า
    public function updateCustomer()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "UPDATE customer_tb SET
                        custName = :custName,
                        custEmail = :custEmail,
                        custPhonenum = :custPhonenum,
                        custPassword = :custPassword
                   WHERE 
                        custId = :custId
                   ";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter
        $this->custId  = intval(htmlspecialchars(strip_tags($this->custId)));
        $this->custName  = htmlspecialchars(strip_tags($this->custName));
        $this->custEmail  = htmlspecialchars(strip_tags($this->custEmail));
        $this->custPhonenum  = htmlspecialchars(strip_tags($this->custPhonenum));
        $this->custPassword  = htmlspecialchars(strip_tags($this->custPassword));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":custId", $this->custId);
        $stmt->bindParam(":custName", $this->custName);
        $stmt->bindParam(":custEmail", $this->custEmail);
        $stmt->bindParam(":custPhonenum", $this->custPhonenum);
        $stmt->bindParam(":custPassword", $this->custPassword);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }

    //ฟังก์ตรวจสอบการเข้าใช้งานของลูกค้า
    public function checkCustomerLogin()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "SELECT 
                        custId, custName, custEmail, custPhonenum, custPassword
                    FROM
                        customer_tb
                    WHERE 
                        custPhonenum = :custPhonenum AND custPassword = :custPassword";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter
        $this->custPhonenum  = htmlspecialchars(strip_tags($this->custPhonenum));
        $this->custPassword  = htmlspecialchars(strip_tags($this->custPassword));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter      
        $stmt->bindParam(":custPhonenum", $this->custPhonenum);
        $stmt->bindParam(":custPassword", $this->custPassword);

        //สั่งให้คำสั่ง sql ทำงาน
        $stmt->execute();

        return $stmt;
    }
}
