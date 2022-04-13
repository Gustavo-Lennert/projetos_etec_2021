<?php   
    class vinho{
        private $nome;
        private $tipo;
        private $preco;
        private $safra;

        public function setNome($nome){
            $this->nome = $nome;
        }
        public function getNome(){
            return $this->nome;
        }

        public function setTipo($tipo){
            $this->tipo = $tipo;
        }
        public function getTipo(){
            return $this->tipo;
        }

        public function setPreco($preco){
            $this->preco = $preco;
        }
        public function getPreco(){
            return $this->preco;
        }

        public function setSafra($safra){
            $this->safra = $safra;
        }
        public function getSafra(){
            return $this->safra;
        }

        public function mostrarVinho(){
            return "Nome: ".$this->getNome()."<br>"."Tipo: ".$this->getTipo()."<br>"."Preço: ".
            $this->getPreco."<br>"."Safra: ".$this->getSafra();   
        }

        public function verificarPreco($preco){
            $returno = false;

            if ($preco < 25) {
            $retorno = true;
            }

            return $retorno;
        }
    }
?>