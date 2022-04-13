<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Atividade5</title>

    <style>
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
    <form action="" method="post" name="5" id="5"> 
        <h2>Digite suas informações</h2>
        Idade: <input type="number" name="idade" id="idade"> 
        <br>
        <br>
        <select name="sexo" id="sexo">
            <option value="f">feminino</option>
            <option value="m">masculino</option>
        </select>
        <br>
        <br>
        <input type="submit" value="Confirmar" name="boton" id="boton"> 
        <br>
        <br>
    </form>
</body>
</html>
<?php 
    if (isset($_POST['boton'])){

        if($_POST['sexo'] == "f"){
            if($_POST['idade'] <= 25){
                echo "Aceita !";
            }
            else{
                echo "Não aceita !";
            }
        }
    }