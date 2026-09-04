// Conforme avaliamos anteriormente as classes são abstrações da vida real
// Ou seja, elas descrevem de uma forma computacional quais os atores e processos existentes no mundo real
// Até aqui sabemos que as classes têm propriedades e métodos
// Porém não sabemos como o computador ou compilador da linguagem vai entender e processar essas informações
// É aqui que os objetos têm um papel fundamental
// O objeto nada mais é que a compilação deste código escrito por nós
// sendo colocado na memória do computador para que ele seja interpretado e executado
// Esse processo de criar o objeto e colocá-lo na memória é denominado instanciamento de classe

namespace SistemaBancario{

    public class InstanciaObjeto {

      public static void Main(){

          var objetoGerente = new Gerente(); 

          
      }
    }
}

// A utilização da palavra reservada new no C# é responsável por analisar o código feito na classe
// e então, disponibilizar na memória do computador para utilização