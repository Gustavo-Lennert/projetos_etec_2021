<?php

class Operacao{

    private $valor1;
    private $valor2;
  
    
    public function setValor1($valor1){
        $this->valor1 = $valor1; 
    }

    public function setValor2($valor2){
        $this->valor2 = $valor2;
    }

    public function getValor1(){
        return $this->valor1;
    }

    public function getValor2(){
        return $this->valor2;
    }

    public function somar(){
        return $this->valor1 + $this->valor2;
    }

}