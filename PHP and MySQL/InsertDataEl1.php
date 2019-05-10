<?php
//Variables for the connection
	$servername = "localhost";
	$server_username =  "id1014099_easychem";
	$server_password = "nikolay1499";
	$dbName = "id1014099_easychem";
	
	//Variable from the user	
	$id = $_POST["IDPost"];	
	//Make Connection
	$conn = new mysqli($servername, $server_username, $server_password, $dbName);
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}
	$sql = "UPDATE Users SET El1='1' WHERE User_ID='".$id."'";
	$result = mysqli_query($conn ,$sql);
	
	if(!result) echo "there was an error";
	else echo "Everything ok.";

?>