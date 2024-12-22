<?php
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Methods: GET");  //GET, PUT, DELETE
header("Access-Control-Allow-Headers: Content-Type");
header("Content-Type: application/json; charset=UTF-8");

//เรียกใช้งานไฟล์ที่จะทำงานด้วย
require_once "./../connectDB.php";
require_once "./../models/menu_item.php";

//สร้าง object ที่จะทำงานกับการเชื่อมต่อฐานข้อมูล 
$connectDB = new ConnectDB();

//และ object ที่ทำงานกับไฟล์โมเดลที่ทำงานกับตารางในฐานข้อมูล
$menu_item = new MenuItem($connectDB->getConnectionDB());

//เรียกใช้ฟังก์ชันให้ทำงาน
$result = $menu_item->getAllMenuItem();

//ตรวจสอบค่าที่อยู่ใน $result มีไหม โดยการนับแถว
if( $result->rowCount() > 0 ){
    //มีข้อมูล
    $responseDataArray = array();

    while($data = $result->fetch(PDO::FETCH_ASSOC)){
        extract($data);

        $resultArray = array(
            "message" => "1",
            "itemId" => strval($itemId) ,
            "itemName" => $itemName,
            "itemImage" => $itemImage,
            "itemSize" => $itemSize,
            "itemPrice" => strval( $itemPrice ), 
            "catId" => strval( $catId )
        );

        array_push($responseDataArray, $resultArray);
    }
    
    echo json_encode($responseDataArray, JSON_UNESCAPED_UNICODE);
}else{
    //ไม่มีข้อมูล
    $responseDataArray = array();
    $resultArray = array(
        "message" => "0",
    );
    array_push($responseDataArray, $resultArray);
    echo json_encode($responseDataArray, JSON_UNESCAPED_UNICODE);   
}