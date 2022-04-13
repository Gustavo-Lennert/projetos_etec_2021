abstract class Pessoa {
  String nome;
  String sexo;
  String habto;
  
  Pessoa(this.nome,this.sexo,this.habto);
  
  void correr()
  {
    print("$nome correu");
  }
  void emitirSom();
}

class Homem extends Pessoa {
  
  Homem(nome,sexo,habto):super(nome,sexo,habto);
  
  void emitirSom()
  {
    print("$nome cantou.");
  }
  
  void tocar()
  {
    print("$nome tocou violão.");
  }
  void habtual()
  {
    print("$nome gosta muito de $habto");
  }
}

class Mulher extends Pessoa {
  
  Mulher(nome,sexo,habto):super(nome,sexo,habto);
  
  void emitirSom()
  {
    print("$nome Latiu.");
  }
  
  void rosnar()
  {
    print("$nome Rosnou.");
  }
  void habtual()
  {
    print("$nome curte muito $habto");
  }
}
class Crianca extends Pessoa {
  
  Crianca(nome,sexo,habto):super(nome,sexo,habto);
  
  void emitirSom()
  {
    print("$nome Latiu.");
  }
  
  void rosnar()
  {
    print("$nome Rosnou.");
  }
  void habtual()
  {
    print("$nome curte muito $habto");
  }
}


void main() {
  Homem h = new Homem("Gustavo","Masculino","tocar");
  Mulher m = new Mulher("Mayara","Feminino","assistir naruto");
  h.correr();
  h.tocar();
  h.emitirSom();
  h.habtual();
  m.habtual();
  
}
