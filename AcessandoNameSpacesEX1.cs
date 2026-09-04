// Os membros de um namespace podem ser acessados atravésde um operador de ponto (.)
// A sintaxe para acessar o membro dentro do namespace é NomeDoNameSpace.NomeDoMembro
// Por exemplo, se temos uma classe chamada ClasseUm e queremosacessá-la,podemos fazer da seguinte maneira:



namespace Myprogram
{

    public class ClasseUm
    {

        public static void Main()
        {
            ProgramaPrincipal.classeDois ClasseDois = new ProgramaPrincipal.classeDois();

        }
    }
}

// Perceba que na figura anterior estamos desenvolvendo nosso código dentro do namespace MyProgram
// Esse namespace não tem visibilidade do namespace ProgramaPrincipal
// Dessa forma, podemos indicar no programa qual é a localidade dele