<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercício 5</title>

    <style>
       h1{
            font-size: 15px;
            font-family: verdana;
        }
    </style>

</head>
<body>
    <h1>
        Insirá os números para descobri a sequência de maior para o menor 
    </h1>
    <form action="" name="exerc5" id="exerc5" method="post">
        <input type="number"  name="A" id="A"> 
        <br>
        <br>
        <input type="number"  name="B" id="B"> 
        <br>
        <br>
        <input type="submit" value="Calcular" name="boton" id="boton"> 
        <br>
        <br>
    </form>    
</body>
</html> 
<?php   
    if (isset($_POST['boton'])) {
        $A = ($_POST['A']);
        $B = ($_POST['B']);

        if ($A > $B){
            echo $A;
            echo ",";
            echo $B;
        }
        else if ($A < $B){
            echo $B;
            echo ",";
            echo $A;
        }
        else {
            echo $A;
            echo ",";
            echo $B;
        }
    }
?>