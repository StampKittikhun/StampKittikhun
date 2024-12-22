<?php
class MenuItem
{
    //ตัวแปรที่ใช้เพื่อการติดต่อฐานข้อมูล
    private $connectDB;


    //ตัวแปรสารพัดประโยชน์
    public $message;


    //ตัวแปรที่ล้อกับคอลัมน์/ฟิวล์ในตารางในฐานข้อมูลที่จะทำงานด้วย
    public $itemID;
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
    public function insertMenuItem()
    {
        //คำสั่ง SQL เก็บในตัวแปร
        $strSQL = "INSERT INTO 
                menu_item_tb 
                (itemName, catId, itemImage, itemSize,itemPrice) 
                VALUES
                (:itemName, :catId, :itemImage, :itemSize,:itemPrice)";

        //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter
        $this->itemName  = htmlspecialchars(strip_tags($this->itemName));
        $this->catId  = htmlspecialchars(strip_tags($this->catId));
        $this->itemImage  = htmlspecialchars(strip_tags($this->itemImage));
        $this->itemSize  = htmlspecialchars(strip_tags($this->itemSize));
        $this->itemPrice  = htmlspecialchars(strip_tags($this->itemPrice));


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

        //-----------ฟังค์ฃั่น เงื่อนไข รหัสเมนูและรหัสหมวดหมู่
        public function deletetMenuItem()
        {
            $strSQL = "DELETE FROM menu_item_tb WHERE itemID = :itemID";
             //สร้าง statement เพื่อทำงานกับคำสั่ง sql
        $stmt = $this->connectDB->prepare($strSQL);

        //กรณีที่มี sql parameter (พวก :???????) ต้องมีการตรวจสอบค่าที่จะกำหนดให้กับ sql parameter
        $this->itemID  = intval(htmlspecialchars(strip_tags($this->itemID)) ); 
        
        
        $stmt->bindParam(":itemID", $this->itemID);

         //สั่งให้คำสั่ง sql ทำงาน
         if ($stmt->execute()) {
            return true;
        } else {
            return false;
        }
    
    

       
    

    }
}
