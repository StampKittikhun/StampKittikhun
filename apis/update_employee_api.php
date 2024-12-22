<?php //insert_employee_api.php      
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: PUT");  //GET, PUT, DELETE
header("Access-Control-Allow-Headers: Content-Type");
header("Content-Type: application/json; charset=UTF-8");
 
//เรียกใช้งานไฟล์ที่จะทำงานด้วย
require_once "./../connectDB.php";
require_once "./../models/employee.php";

//สร้าง object ที่จะทำงานกับการเชื่อมต่อฐานข้อมูล 
$connectDB = new ConnectDB();

//และ object ที่ทำงานกับไฟล์โมเดลที่ทำงานกับตารางในฐานข้อมูล
$employee = new Employee($connectDB->getConnectionDB());

//กรณีที่การเรียกใช้ API มีการส่งข้อมูลใดๆ มาด้วย เราจะกำหนดค่าให้กับตัวแปรที่โมเดล
//แปลงข้อมูลที่ส่งมาซึ่งเป็น JSON มาเป็นข้อมูลที่จะใช้งานในฝั่ง Server
$data = json_decode(file_get_contents("php://input"));

//เอาข้อมูลใส่ในตัวแปร
$employee->empId = $data->empId;
$employee->empName = $data->empName;
$employee->empPhonenum = $data->empPhonenum;
$employee->empPassword = $data->empPassword;

if(isset($data->empImage)){
    //--------- ว่าด้วยเรื่องของการอัปโหลดรูป ------------------------------
    //ของเดิมไม่เอา $employee->empImage = $data->empImage; ****-
    //เอารูปที่ส่งมาซึ่งเป็น Base64 แปลงเป็นตัวรูป แล้วเก็บใน โฟล์เดอร์ที่กำหนด
    //โดยเราจะตั้งชื่อไฟล์ให้มันต่างกัน ไม่เช่นนั้นมันจะไปทำกัน
    $new_filename = 'emp_'. uniqid() . '.jpg';
    file_put_contents('./../images/employee/' . $new_filename , base64_decode($data->empImage));
    $employee->empImage = $new_filename;
    //---------------------------------------------------------------
}

//เรียกใช้ฟังก์ชันให้ทำงาน
$result = $employee->updateEmployee();

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








