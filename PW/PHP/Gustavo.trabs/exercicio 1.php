<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercício 1</title>

    <style>
        h1{
            font-size: 15px;
            font-family: verdana;
        }
    </style>

</head>
<body>
    <h1>
        Insirá um número
    </h1>
    <form action="" name="exerc1" id="exerc1" method="post">
        <input type="number"  name="numero" id="numero"> 
        <input type="submit" value="Mostrar" name="boton" id="boton"> 
    </form>    
</body>
</html>
<?php   
    if (isset($_POST['boton'])) {
        if ($_POST ['numero'] >10) { 
            echo "O valor é maior que 10";
        }
        else{
            echo "O valor é menor que 10";
        }
    }
?>
