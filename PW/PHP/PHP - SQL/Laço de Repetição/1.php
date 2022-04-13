<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Atividade1</title>

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
    <h1>Insirá seu nome e altura:</h1>
    <form action="" name="1" id="1" method="post"> 
    <h2>Primeira criança</h2>
    Nome: <input type="text"  name="nome" id="nome"> 
    <br>
    <br>
    Altura: <input type="text"  name="altura" id="altura"> 
    <br>
    <br>
    <h2>Segunda criança</h2>
    Nome: <input type="text"  name="nome2" id="nome2"> 
    <br>
    <br>
    Altura: <input type="text"  name="altura2" id="altura2"> 
    <br>
    <br>
    <input type="submit" value="Calcular" name="boton" id="boton"> 
    <br>
    <br>
    </form>
</body>
</html>
<?php 
    if (isset($_POST['boton'])){
        $kid1 = str_replace(",",".",$_POST['altura']);
        $kid2 = str_replace(",",".",$_POST['altura2']);
        $years = 0;
        while($kid1 > $kid2){
            $kid1 += 0.02;
            $kid2 += 0.03;
            $years++;  
        }
        echo($_POST['nome2']. " será maior que ". $_POST['nome']. " em ". $years. " anos");
    }

