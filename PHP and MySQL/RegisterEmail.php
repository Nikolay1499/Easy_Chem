<?php
//Variables for the connection
	$servername = "localhost";
	$server_username =  "id1014099_easychem";
	$server_password = "nikolay1499";
	$dbName = "id1014099_easychem";
	
//Variable from the user
	$email = $_POST["NamePost"];
	$password = $_POST["PasswordPost"];
	if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
    echo"Невалиден имейл"; 
	}
	else{
	//Make Connection
	$conn = new mysqli($servername, $server_username, $server_password, $dbName);
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}
	    $sql = "SELECT * FROM Users WHERE User_ID='".$email."'";
	$result = mysqli_query($conn ,$sql);
	//echo $result;
	if(mysqli_num_rows($result)> 0)
	{
		while($row = mysqli_fetch_assoc($result))
		{
		if($row['User_ID']==$email){
			
		        echo "Имейлът вече е регистриран";
				//echo $row['Name']; 
				}
		}
	}
	else{
		echo "User successfully created";
		$sql = "INSERT INTO Users(User_ID, Password)
			VALUES ('".$email."','".$password."')";
		$result = mysqli_query($conn ,$sql);		
	}
	}
?>