<?php
//Variables for the connection
	$servername = "localhost";
	$server_username =  "id1014099_easychem";
	$server_password = "nikolay1499";
	$dbName = "id1014099_easychem";
	
//Variable from the user
	$email = $_POST["NamePost"];
	$password = $_POST["PasswordPost"];
	//if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
    //echo"Invalid email"; 
	//}
	//else{
	//Make Connection
	$conn = new mysqli($servername, $server_username, $server_password, $dbName);
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}
        //$sql = "ALTER TABLE testing ADD gender INT DEFAULT 0;";
	//$result = mysqli_query($conn ,$sql);
	
	$sql = "SELECT * FROM Users WHERE User_ID='".$email."'";
	$result = mysqli_query($conn ,$sql);
	//echo $result;
	if(mysqli_num_rows($result)> 0)
	{
		while($row = mysqli_fetch_assoc($result))
		{
			if($password==""){
		//echo "Logged in with Facebook";
		}
		else if($row['Password']==$password){
		        echo "Login successful";
				//echo $row['Name']; 
				}
		else echo "Грешна парола";
		}
	}
	else 
	{
		echo "Потребителят не съществува";
	}
?>