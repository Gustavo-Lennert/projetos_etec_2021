<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercício 3</title>

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
    <form action="" name="exerc3" id="exerc3" method="post">
        <input type="number"  name="numero" id="numero"> 
        <input type="submit" value="Mostrar" name="boton" id="boton"> 
    </form>   
</body>
</html>
<?php  
    
    if (isset($_POST['boton'])) {
        if ($_POST ['numero'] > 0){
            echo "Valor positivo";
        }
        else if  ($_POST ['numero'] < 0){
            echo "Valor negativo"; 

        }
        else{
            echo "Valor igual a zero";
        }
    }
?>