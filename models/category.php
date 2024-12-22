<?php
class Category
{
    //ตัวแปรที่ใช้เพื่อการติดต่อฐานข้อมูล
    private $connectDB;

    //ตัวแปรสารพัดประโยชน์
    public $message;

    //ตัวแปรที่ล้อกับคอลัมน์/ฟิวล์ในตารางในฐานข้อมูลที่จะทำงานด้วย
    public $catId;
    public $catName;

    //คอนสตรักเตอร์
    public function __construct($connectDB)
    {   //เพื่อกำหนดค่าให้กับตัวแปรที่จะใช้งานฐานข้อมูล
        $this->connectDB = $connectDB;
    }

    //-----------------------------------
    //   ฟังก์ชันที่ทำงานกับตารางในฐานข้อมูลที่ล้อกับ API ที่ Client/User เรียกใช้
    //-----------------------------------
    public function insertCategory()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "INSERT INTO
                    category_tb
                    (catName)
                    VALUES
                    (:catName)
                    ";
        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter
        $this->catName  = htmlspecialchars(strip_tags($this->catName));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":catName", $this->catName);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }

    //ฟังก์ชันลบ เงื่อนไขคือ รหัสประเภทเมนู
    public function deleteCategory()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "DELETE FROM
                    category_tb
                    WHERE
                    catId = :catId
                    ";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter  
        $this->catId = intval(htmlspecialchars(strip_tags($this->catId)));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":catId", $this->catId);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }

    //ฟังก์ชันแก้ไข เงื่อนไขคือ รหัสประเภทเมนู
    public function updateCategory()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "UPDATE
                    category_tb
                   SET
                    catName = :catName
                   WHERE
                    catId = :catId
                    ";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter  
        $this->catId = intval(htmlspecialchars(strip_tags($this->catId)));
        $this->catName =  htmlspecialchars(strip_tags($this->catName));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":catId", $this->catId);
        $stmt->bindParam(":catName", $this->catName);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }
}
