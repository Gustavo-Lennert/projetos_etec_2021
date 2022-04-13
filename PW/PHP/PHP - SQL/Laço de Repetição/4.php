<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Atividade4</title>

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
    <h1>Cálculo de desconto de 2 produtos</h1>
    <form action="" method="post" name="4" id="4"> 
        <h2>Digite o preço dos produtos</h2>
        1º (8% de desconto): <input type="text" name="produto1" id="produto1"> 
        <br>
        <br>
        2º (11% de desconto): <input type="text" name="produto2" id="produto2"> 
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
        $PA =  str_replace(",",".",$_POST['produto1']);
        $PB =  str_replace(",",".",$_POST['produto2']);
        $soma = 0;
        
        $PA = ($PA - ((8/100) * $PA));
        $PB = ($PB - ((11/100) * $PB));
        $soma = ($PA + $PB);
       
        echo "O valor do 1º produto será : ". "R$".$PA. ", o valor do 2º será : ". "R$".$PB. ", e o valor total a ser pago será : ". "R$".$soma;

    }
   