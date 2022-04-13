<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercício 4</title>

    <style>
       h1{
            font-size: 15px;
            font-family: verdana;
        }
    </style>

</head>
<body>
    <h1>
        Insirá os números nos respectivos campos (Sabendo que : A + B e C x D)
    </h1>
    <form action="" name="exerc4" id="exerc4" method="post">
        <input type="number"  name="A" id="A"> 
        <br>
        <br>
        <input type="number"  name="B" id="B"> 
        <br>
        <br>
        <input type="number"  name="C" id="C"> 
        <br>
        <br>
        <input type="number"  name="D" id="D"> 
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
        $soma = ($_POST ['A'] + $_POST ['C']);
        $multi = ($_POST ['B'] * $_POST ['D']);

        if ($soma > $multi){
            echo "A+C é maior que B*D";
        }
        else if ($soma == $multi){
            echo "A+C é igual a B*D";
        }
        else {
            echo "B*D é maior que A+C";
        }
    }
?>