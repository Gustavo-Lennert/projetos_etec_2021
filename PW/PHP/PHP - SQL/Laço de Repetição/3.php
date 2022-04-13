<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Atividade3</title>

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
    <h1>Formulário de Alistamento Militar</h1>
    <form action="" method="post" name="3" id="3"> 
        <h2>Digite suas informações</h2>
        Nome: <input type="text" name="nome" id="nome"> 
        <br>
        <br>
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

        if($_POST['sexo'] == "m"){
            if($_POST['idade'] >= 18){
                echo ($_POST['nome'].", você já pode se alistar");
            }
            else{
                echo ($_POST['nome'].", você só pode ser alistar quando completar 18 anos");
            }
        }
        else if($_POST['sexo'] == "f"){
            echo ($_POST['nome'].", não é obrigatório você realizar o alistamento militar");
        }
    }
   