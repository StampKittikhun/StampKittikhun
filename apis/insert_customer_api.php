<?php //insert_customer_api.php 
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: POST");  //GET, PUT, DELETE
header("Access-Control-Allow-Headers: Content-Type");
header("Content-Type: application/json; charset=UTF-8");

//เรียกใช้งานไฟล์ที่จะทำงานด้วย
require_once "./../connectDB.php";
require_once "./../models/customer.php";

//สร้าง object ที่จะทำงานกับการเชื่อมต่อฐานข้อมูล 
$connectDB = new ConnectDB();

//และ object ที่ทำงานกับไฟล์โมเดลที่ทำงานกับตารางในฐานข้อมูล
$customer = new Customer($connectDB->getConnectionDB());

//กรณีที่การเรียกใช้ API มีการส่งข้อมูลใดๆ มาด้วย เราจะกำหนดค่าให้กับตัวแปรที่โมเดล
//แปลงข้อมูลที่ส่งมาซึ่งเป็น JSON มาเป็นข้อมูลที่จะใช้งานในฝั่ง Server
$data = json_decode(file_get_contents("php://input"));

//เอาข้อมูลใส่ในตัวแปร
$customer->custName = $data->custName;
$customer->custEmail = $data->custEmail;
$customer->custPhonenum = $data->custPhonenum;
$customer->custPassword = $data->custPassword;

//เรียกใช้ฟังก์ชันให้ทำงาน
$result = $customer->insertCustomer();

//การส่งค่ากลับไปยัง Client/User เมื่อ API ทำงานเสร็จ
if($result == true){
    $resultArray = array(
        "message" => "1"
    );

    echo json_encode($resultArray);
}else{
    $resultArray = array(
        "message" => "0"
    );

    echo json_encode($resultArray);
}







