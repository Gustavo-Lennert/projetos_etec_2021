<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercício 7</title>

    <style>
       h1{
            font-size: 15px;
            font-family: verdana;
        }
    </style>

</head>
<body>
    <h1>
        Insirá suas informções para calcular seu peso ideal:
    </h1>
    <form action="" name="exerc7" id="exerc7" method="post">
        <p>Digite sua altura (ex.: 1.80)</p>
        <input type="text"  name="altura" id="altura"> 
        <br>
        <br>
        <p>Digite "M" para sexo maculino e "F" para feminino</p>
        <input type="text"  name="sexo" id="sexo"> 
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
        $altP = ($_POST ['altura']);
        $sexP = ($_POST ['sexo']);
    
        if ($sexP == 'M' || $sexP == 'm'){
            $peso = ((72.7 * $altP) - 58);  
            echo "Peso ideal: $peso";
        }
        else if ($sexP == 'F' || $sexP == 'f'){
            $peso = ((62.1 * $altP) - 44.7);  
            echo "Peso ideal: $peso";  
        }
        else {
            echo "Sexo não definido, repita o procedimento";
        }
    }
?>