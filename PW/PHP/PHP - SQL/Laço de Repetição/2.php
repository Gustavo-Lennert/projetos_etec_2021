<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Atividade2</title>

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
            text-align: left;
            font-size: 20px;
        }
    </style>
</head>
<body>  
        <h1>Repetidor de palavra</h1>
        <form action="" name="2" id="2" method="post">
			<h2> Digite uma palavra<h2>
			 <input type="text" name="palavra" id="palavra">
			<input type="submit" value="Calcular" name="boton" id="boton">
			<br>
			<br>
		</form>
</body>
</html>
<?php

	if (isset($_POST['boton'])){
		$repeat = ($_POST ['palavra']);
		
		for ($i=0;$i<5; $i++){
			echo "<p>".str_repeat($repeat." ", $i)."</p>";
		}
	}
	
?>