// Apesar dessa forma funcionar, existe uma forma mais amigável e prática de obtermos a visibilidade do outro namespace 
// Para isso podemos usar a palavra-chave using

using ProgramaPrincipal;

namespace MyProgram
{

    public class ClasseUm
    {

        public static void Main()
        {
            ClasseDois ClasseDois = new ClasseDois();
        }
    }
}

// Veja na figura anterior que removemos o nome do namespace antes da classe ClasseDois
// Adicionamos no topo do programa a palavra-chave using, indicando onde ir buscar a referência do objeto
// Não existe um padrão ou melhor forma de utilizar, ambos funcionam
// Porém, é muito comum ver no mercado a utilização do using no topo do programa
// A principal funcionalidade do namespace é de fato organizar o projeto
// A medida que ele vai ficando maior e com mais arquivos é extremamente importante que saibamos como segregar o projeto 
// visando sobre a responsabilidade de cada componente e determinando suas ações de forma isolada

