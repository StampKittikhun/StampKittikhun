<?php
class ConnectDB{
    //ตัวแปรสําหรับเก็บค่าการเชื่อมต่อฐานข้อมูล
    public $connectDB;

    private $host = "localhost"; //ใช้ 127.0.0.1 หรือ IP Address หรือชื่อ Domain แทนได้
    private $user = "root";
    private $password = "";
    private $dbName = "saucoffeecafe_db";

    //ฟังก์ชันในการเชื่อมต่อฐานข้อมูล
    public function getConnectionDB(){
        $this->connectDB = null;

        try{
            $this->connectDB = new PDO("mysql:host=" . $this->host . ";dbname=" . $this->dbName, 
                                        $this->user, 
                                        $this->password
                                      );
            $this->connectDB->exec("set names utf8");
        }catch(PDOException $exception){
            echo "Connection error: " . $exception->getMessage();
        }

        return $this->connectDB;
    }
}


