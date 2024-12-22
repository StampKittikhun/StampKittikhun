<?php //insert_employee_api.php      
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: GET");  //GET, PUT, DELETE
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
$employee->empPhonenum = $data->empPhonenum;
$employee->empPassword = $data->empPassword;

//เรียกใช้ฟังก์ชันให้ทำงาน
$result = $employee->checkEmployeeLogin();

//ตรวจสอบค่าที่อยู่ใน $result มีไหม โดยการนับแถว
if( $result->rowCount() > 0 ){
    //มีข้อมูล นั่นคือ เบอร์โทร รหัสผ่านถูกต้อง
    //เอาข้อมูลของมาจาก $result
    $data = $result->fetch(PDO::FETCH_ASSOC);
    //แตกข้อมูลเพื่อจะเอาไปทำเป็น JSON ส่งกลับไปยัง Client/User
    extract($data);

    $resultArray = array(
        "message" => "1",
        "empId" => strval($empId) ,
        "empName" => $empName,
        "empImage" => $empImage,
        "empPhonenum" => $empPhonenum,
        "empPassword" => $empPassword        
    );

    echo json_encode($resultArray, JSON_UNESCAPED_UNICODE);
}else{
    //ไม่มีข้อมูล นั่นคือ เบอร์โทร รหัสผ่านไม่ถูกต้อง
    $resultArray = array(
        "message" => "0"       
    );
    echo json_encode($resultArray, JSON_UNESCAPED_UNICODE);
}