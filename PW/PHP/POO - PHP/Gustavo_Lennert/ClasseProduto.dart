class Produto{
  int codigo;
  String descricao;
  double precoVenda;
  int saldo;
  
  
  Produto(this.codigo, this.descricao, this.precoVenda, this.saldo);
  
  String toString()
  {
    return "Código do produto: " + this.codigo.toString() + "Descrição: " + this.descricao 
    + "Preço:  " + this.precoVenda.toString() +"Saldo: " + this.saldo.toString();
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

class Funcionario extends Pessoa {
  double salario;
  Funcionario(cpf,nome,this.salario):super(cpf,nome);
  
  String toString()
  {
    return super.toString() + " Salário: " + this.salario.toString();
  }
  
  bool Equals(Funcionario funcionario)
  {
    bool retorno = false;
    if (super.equals(funcionario) == true && this.salario == funcionario.salario)
    {
      retorno = true;
    }
    return retorno;
  }
}
  
class Aluno extends Pessoa {
  int ra;
  
  Aluno(cpf,nome,this.ra):super(cpf,nome);
  String toString()
  {
    return super.toString() + " RA: " + this.ra.toString();
  }
  
  bool Equals(Aluno aluno){
    bool retorno = false;
    if (super.equals(aluno) == true && 
        this.ra == aluno.ra )
    {
      retorno = true;
    }
    return retorno;
  }
}


class Professor extends Funcionario {
  String formacao;
  
  Professor(cpf,nome,salario,this.formacao):super(cpf,nome,salario);
  
  String ToString(){
    return super.toString() + " Formação: " 
       + this.formacao;
  }
  
  bool EQuals(Professor professor)
  {
    bool retorno = false;
    
    if (super.equals(professor) == true && 
        this.formacao == professor.formacao){
      retorno = true;
    }
   return retorno;
  }
  
}


void main() 
{
  Pessoa pes = new Pessoa("145.876.798-13","Mariana Ferrante");
  print(pes.toString());
  Funcionario func = new Funcionario("123.345.789-98","Juanita de Paula",12000);
  print(func.toString());
  Aluno alu = new Aluno("138.086.798-68",'Jão',20201);
  print(alu.toString());
  Professor prof = new 
    Professor("123.764.756-12","Maria da Silva", 14500,"Pedagogia exp Inglês.");
    print(prof.ToString());
}