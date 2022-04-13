<!DOCTYPE html>
<html lang="pt">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Wines Lennert</title>
</head>
<body>
    <h1>Castro de Vinho</h1>
    <form action="" method="post" name="frmVinho" id="">

        <h2>Insira as informações do vinho</h2>
        Nome: <input type="text" name="nome" id="nome">
        <br>

        Tipo: <input type="text" name="tipo" id="tipo">
        <br>

        Preço: <input type="text" name="preco" id="preco">
        <br>

        Safra: <input type="text" name="safra" id="safra">
        <br>

        <input type="submit"  value="Cadastrar" name="button" id="button">

    </form>
</body>
</html>

<?php   
    
    require_once('Operacao.php');
    if(isset($_POST['Cadastrar'])){

        $vinho = new Vinho();

        echo $vinho->mostrarVinho();
        
    }