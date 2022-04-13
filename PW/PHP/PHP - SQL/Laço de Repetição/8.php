<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Atividade8</title>

    <style>
        h1{
            font-family: arial;
        }
        h2{
            font-size: 16px;
            font-family: arial;
        }
        body{
            padding: 40px;
            text-align: center;
            font-size: 20px;
        }
    </style>
</head>
<body>  
		<h1>Tabuada</h1>
		<form action="" name="8" id="8" method="post">
			<h2> Digite um número qualquer <h2>
			 <input type="text" name="numero" id="numero">
			<input type="submit" value="Calcular" name="boton" id="boton">
			<br>
			<br>
		</form>
</body>
</html>

<?php

    if (isset($_POST['boton'])){
        $num = 	($_POST['numero']);
        if(!is_numeric($num)){
            echo "<br>O valor informado não é um número.<br>";
        }
        if($num == 5){
            for($i=0; $i<11; $i++){
                    echo "$num * $i = ".$num * $i."<br>";
            }
        }

        else{
            for($i=0; $i<5; $i++){
                echo "$num * $i = ".$num * $i."<br>";
            }
            for($i=6; $i<11; $i++){
                echo "$num * $i = ".$num * $i."<br>";
            }
        }

    }