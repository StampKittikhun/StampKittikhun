<?php
class MenuItem
{
    //ตัวแปรที่ใช้เพื่อการติดต่อฐานข้อมูล
    private $connectDB;

    //ตัวแปรสารพัดประโยชน์
    public $message;

    //ตัวแปรที่ล้อกับคอลัมน์/ฟิวล์ในตารางในฐานข้อมูลที่จะทำงานด้วย
    public $itemId;
    public $itemName;
    public $catId;
    public $itemImage;
    public $itemSize;
    public $itemPrice;

    //คอนสตรักเตอร์
    public function __construct($connectDB)
    {   //เพื่อกำหนดค่าให้กับตัวแปรที่จะใช้งานฐานข้อมูล
        $this->connectDB = $connectDB;
    }

    //-----------------------------------
    //   ฟังก์ชันที่ทำงานกับตารางในฐานข้อมูลที่ล้อกับ API ที่ Client/User เรียกใช้
    //-----------------------------------

    //ฟังก์ชันที่ใช้ร่วมกับ API ที่จะเอาข้อมูลเมนู(ใหม่)มาเพิ่มเข้าไปในตารางในฐานข้อมูล
    public function insertMenuItem()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "INSERT INTO
                    menu_item_tb
                    (itemName, catId, itemImage, itemSize, itemPrice)
                    VALUES
                    (:itemName, :catId, :itemImage, :itemSize, :itemPrice)
                    ";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter
        $this->itemName = htmlspecialchars(strip_tags($this->itemName));
        $this->catId = intval(htmlspecialchars(strip_tags($this->catId)));
        $this->itemImage = htmlspecialchars(strip_tags($this->itemImage));
        $this->itemSize = htmlspecialchars(strip_tags($this->itemSize));
        $this->itemPrice = doubleval(htmlspecialchars(strip_tags($this->itemPrice)));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":itemName", $this->itemName);
        $stmt->bindParam(":catId", $this->catId);
        $stmt->bindParam(":itemImage", $this->itemImage);
        $stmt->bindParam(":itemSize", $this->itemSize);
        $stmt->bindParam(":itemPrice", $this->itemPrice);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }

    //ฟังก์ชันลบ เงื่อนไขคือ รหัสเมนู
    public function deleteMenuItem()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "DELETE FROM
                    menu_item_tb
                    WHERE
                    itemId = :itemId
                    ";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter  
        $this->itemId = intval(htmlspecialchars(strip_tags($this->itemId)));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":itemId", $this->itemId);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }

    //ฟังก์ชันแก้ไข เงื่อนไขคือ รหัสเมนู
    public function UpdateMenuItem()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "";
        if (isset($this->itemImage)) {
            //แก้ไขรูป
            $strSQL = "UPDATE menu_item_tb SET
                            itemName = :itemName,
                            catId = :catId,
                            itemImage = :itemImage,
                            itemSize = :itemSize,
                            itemPrice = :itemPrice
                        WHERE
                            itemId = :itemId
                        ";
        } else {
            //ไม่แก้ไขรูป
            $strSQL = "UPDATE menu_item_tb SET
                            itemName = :itemName,
                            catId = :catId,
                            itemSize = :itemSize,
                            itemPrice = :itemPrice
                        WHERE
                            itemId = :itemId
                        ";
        }

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter
        $this->itemId = intval(htmlspecialchars(strip_tags($this->itemId)));
        $this->itemName = htmlspecialchars(strip_tags($this->itemName));
        $this->catId = intval(htmlspecialchars(strip_tags($this->catId)));
        if (isset($this->itemImage)) {
            $this->itemImage = htmlspecialchars(strip_tags($this->itemImage));
        }
        $this->itemSize = htmlspecialchars(strip_tags($this->itemSize));
        $this->itemPrice = doubleval(htmlspecialchars(strip_tags($this->itemPrice)));

        //เมื่อตรวจสอบเสร็จแล้วให้กำหนดค่าให้กับ sql parameter
        $stmt->bindParam(":itemId", $this->itemId);
        $stmt->bindParam(":itemName", $this->itemName);
        $stmt->bindParam(":catId", $this->catId);
        if (isset($this->itemImage)) {
            $stmt->bindParam(":itemImage", $this->itemImage);
        }
        $stmt->bindParam(":itemSize", $this->itemSize);
        $stmt->bindParam(":itemPrice", $this->itemPrice);

        //สั่งให้คำสั่ง sql ทำงาน
        if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    }

    //ฟังชันดึงข้อมูลเมนูทั้งหมด
    public function getAllMenuItem()
    {
        $strSQL = "SELECT itemId, itemName, itemImage, itemSize, itemPrice, catId 
                    FROM menu_item_tb
                    ORDER BY catId";

        $stmt = $this->connectDB->prepare($strSQL);

        $stmt->execute();

        return $stmt;
    }
}
