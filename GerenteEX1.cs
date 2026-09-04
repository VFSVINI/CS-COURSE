// A classe é uma abstração do mundo real em programação
// Ela vai modelar no sistema quais atores ou processos existirão e como eles se comportam
// Esses atores possuem características comuns tais como nome, idade e certamente um número de CPF
// Dessa forma, a classe também precisará refletir essas propriedades

namespace SistemaBancario {

    public class Gerente {

        public string Nome {get; set;}
        public int Idade {get; set;}
        public int Cpf {get; set;}

      
    }
}

// Basicamente o que fizemos aqui foi identificar quais atributos o gerente possui
// São relevantes para o sistema e quais propriedades criaríamos na classe para que fosse utilizado em nosso sistema

