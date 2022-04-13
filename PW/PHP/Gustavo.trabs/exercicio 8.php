<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercício 8</title>

    <style>
       h1{
            font-size: 15px;
            font-family: verdana;
        }
    </style>

</head>
<body>
    <h1>
        Insirá o salário de um funcionário para calcular reajuste
    </h1>
    <form action="" name="exerc8" id="exerc8" method="post">
        <input type="number"  name="salar" id="salar"> 
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
        $reaj = ($_POST['salar']);
    
        if ($reaj <= 300){
            $result = (($reaj * 50) /100);  
            echo "Valor reajustado: $result";
        }
        else {
            $result = (($reaj * 30) /100);  
            echo "Valor reajustado: $result";
        }
    }
?>