class Produto{
  int codigo;
  String descricao;
  double precoVenda;
  int saldo;
  
  
  Produto(this.codigo, this.descricao, this.precoVenda, this.saldo);
  
  String toString()
  {
    return "Código do produto: " + this.codigo.toString() + "| Descrição: " + this.descricao 
    + "| Preço:  " + this.precoVenda.toString() +"| Saldo: " + this.saldo.toString();
  }
  
  bool equals(Produto produto)
  {
    bool retorno = false;
    if(this.codigo == produto.codigo && this.descricao == produto.descricao && this.precoVenda 
    == produto.precoVenda && this.saldo == produto.saldo)
    {
      retorno = true;
    }
    return retorno;
  }

  bool entrada(int quantidade){
    (this.saldo += quantidade);
    return true;
  }

  bool saida(int quantidade){
    bool retorno = false;
  
    if(this.saldo <= quantidade){
      quantidade - this.saldo;
      retorno = true;
      return retorno; 
    }

    else{
      return retorno;
    }
  }
  double getValorEstoque(){

    return precoVenda * this.saldo;
  }
}

class DVD extends Produto {
  String titulo;
  String faixas;
  String artista;

  DVD(codigo,descricao,precoVenda,saldo, this.titulo, this.faixas, this.artista):super(codigo,descricao, precoVenda,saldo);
  
  String toString(){
    
    return super.toString() + "| título: " + this.titulo.toString() + "| faixas: " + 
    this.faixas.toString() + "| artista: " +this.artista.toString();
  }
  
  bool Equals(DVD dvd)
  {
    bool retorno = false;
    
    if (super.equals(dvd) == true && this.titulo == dvd.titulo && this.faixas == dvd.faixas && this.artista == dvd.artista)
    {
    retorno = true;
    }
    return retorno;
  }
}
  
class Livro extends Produto {
  String titulo;
  String autor;
  String editora;
  
  Livro(codigo,descricao,precoVenda,saldo,this.titulo, this.autor, this.editora):super(codigo,descricao,precoVenda,saldo);
  String toString()
  { 
    return super.toString() + "| título: " + this.titulo.toString() + "| autor: " + this.autor.toString()  + "| editora: " + this.editora.toString();
  }
  
  bool Equals(Livro livro){
    bool retorno = false;
      if (super.equals(livro) == true && this.titulo == livro.titulo && this.autor == livro.autor && this.editora == livro.editora)
    {
      retorno = true;
    }
    return retorno;
  }
}

void main() 
{ 
  DVD dvd = new DVD(2042," Song " ,29.99,25, " Dani Califonrnia "," Stardium Acardium", " Red Hot Chili Peppers ");
  print(dvd.toString());
  print(dvd.entrada(3));
  print(dvd.saida(2));
  print(dvd.getValorEstoque());

  Livro livro = new Livro(1815," Book ",14.99,12," Viagens de Guliver "," Jonathan Swift ", " Benjamin Motte ");
  print(livro.toString());
  print(livro.entrada(5));
  print(livro.saida(7));
  print(livro.getValorEstoque());

}