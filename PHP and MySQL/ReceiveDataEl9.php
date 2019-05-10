<?php
	$servername = "localhost";
	$username =  "id1014099_easychem";
	$password = "nikolay1499";
	$dbName = "id1014099_easychem";
	
	$id = $_POST["IDPost"];
	//Make Connection
	$conn = new mysqli($servername, $username, $password, $dbName);
	//Check Connection
	if(!$conn)
	{
		die("Connection Failed. ". mysqli_connect_error());
	}
	$sql = "SELECT El9 FROM Users WHERE User_ID='".$id."'";
	$result = mysqli_query($conn ,$sql);
	
			if(mysqli_num_rows($result) > 0)
			{
				//show data for each row
				while($row = mysqli_fetch_assoc($result))
				{
					echo $row['El8'];
				}
			}			
?>