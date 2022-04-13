<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Atividade7</title>

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
    <h1>Soma de números positivos e/ou negativos</h1>
    <form action="" method="post" name="7" id="7"> 
        <h2>Digite 10 números em seus respectivos campos</h2>
        1º: <input type="number" name="1" id="1"> 
        <br>
        <br>
        2º: <input type="number" name="2" id="2"> 
        <br>
        <br>
        3º: <input type="number" name="3" id="3"> 
        <br>
        <br>
        4º: <input type="number" name="4" id="4"> 
        <br>
        <br>
        5º: <input type="number" name="5" id="5"> 
        <br>
        <br>
        6º: <input type="number" name="6" id="6"> 
        <br>
        <br>
        7º: <input type="number" name="7" id="7"> 
        <br>
        <br>
        8º: <input type="number" name="8" id="8"> 
        <br>
        <br>
        9º: <input type="number" name="9" id="9"> 
        <br>
        <br>
        10º: <input type="number" name="10" id="10"> 
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
        $soma = 0;
        $somaN =0;

        if(($_POST['1']) > 0){
            $soma += ($_POST['1']);
        }                          
        else{
            $somaN += ($_POST['1']);  
        }
        
        if(($_POST['2']) > 0){
            $soma += ($_POST['2']);
        }
        else{
            $somaN += ($_POST['2']);  
        }

        if(($_POST['3']) > 0){
            $soma += ($_POST['3']);
        }
        else{
            $somaN += ($_POST['3']);
        }

        if(($_POST['4']) > 0){
            $soma += ($_POST['4']);
        }
        else{
            $somaN += ($_POST['4']);  
        }

        if(($_POST['5']) > 0){
            $soma += ($_POST['5']);
        }
        else{
            $somaN += ($_POST['5']);  
        }

        if(($_POST['6']) > 0){
            $soma += ($_POST['6']);
        }
        else{
            $somaN += ($_POST['6']);  
        }

        if(($_POST['7']) > 0){
            $soma += ($_POST['7']);
        }
        else{
            $somaN += ($_POST['7']);  
        }

        if(($_POST['8']) > 0){
            $soma += ($_POST['8']);
        }
        else{
            $somaN += ($_POST['8']); 
        }

        if(($_POST['9']) > 0){
            $soma += ($_POST['9']);
        }
        else{
            $somaN += ($_POST['9']);
        }

        if(($_POST['10']) > 0){
            $soma += ($_POST['10']);
        }
        else{
            $somaN += ($_POST['10']);  
        }

        echo "A soma dos números positivos digitados é: ".$soma.", e a soma dos negativos é: ".$somaN; 
    }