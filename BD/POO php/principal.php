<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>atividadeTeste</title>
</head>
<body>
    <form action="" method="post" name="frmClasse" id="frmClasse">
        Valor 1: <input type="text" name="valor1" id="valor1">
        Valor 2: <input type="text" name="valor2" id="valor2">
        <br>
        <input type="submit" value="Somar" id="btnSomar" name="btnSomar"> 
    </form>
</body>
</html>
<?php

require_once('Operacao.php');

if(isset($_POST[btnSomar])){
    
}