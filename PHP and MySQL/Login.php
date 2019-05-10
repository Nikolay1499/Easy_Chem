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
	$sql = "SELECT * FROM Users WHERE User_ID='".$id."'";
	$result = mysqli_query($conn ,$sql);
	//echo $result;
	if(mysqli_num_rows($result)> 0)
	{
		while($row = mysqli_fetch_assoc($result))
		{
				echo $row['User_ID'];
		}
	}
	else 
	{
		echo "User not found";
		$sql = "INSERT INTO Users (User_ID)
			VALUES ('".$id."')";
			$result = mysqli_query($conn ,$sql);
	}
	
?>