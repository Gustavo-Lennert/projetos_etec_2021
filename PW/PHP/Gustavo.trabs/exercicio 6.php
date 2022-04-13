<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercício 6</title>

    <style>
       h1{
            font-size: 15px;
            font-family: verdana;
        }
    </style>

</head>
<body>
    <h1>
        Insirá as notas para calculo de média de aprovação final
    </h1>
    <form action="" name="exerc6" id="exerc6" method="post">
        <input type="number"  name="nota1" id="nota1"> 
        <br>
        <br>
        <input type="number"  name="nota2" id="nota2"> 
        <br>
        <br>
        <input type="number"  name="nota3" id="nota3"> 
        <br>
        <br>
        <input type="number"  name="nota4" id="nota4"> 
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
        $A = ($_POST['nota1']);
        $B = ($_POST['nota2']);
        $C = ($_POST['nota3']);
        $D = ($_POST['nota4']);

        $media = (($A + $B + $C + $D)/4);
       if($media > 7){
           echo "Aprovado !"; 
        }
        else{
            echo "Reprovado !"; 
         }
    }
?>