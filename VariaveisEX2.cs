// Os tipos básicos são categorizados em:
// Tipos integrais : sbyte, byte, short, ushort, int, uint, long, ulong, and char
// Tipos de ponto flutuante : float and double
// Tipos decimais : decimal
// Tipos booleanos : true or false values, as assigned
// Tipos nulos : Nullable data types

// Existem outros tipos de variáveis também
// como por exemplo Enums e tipos por referência como classes
// A forma que definimos variáveis no C# é:

// <tipo de dados> <nome da variavel> = <valor>;

namespace SistemaBancario{
    
    public class Variaveis{
        
      public static void Main(){
        
        int cpf = 123456789;
        string nome = "Vinícius França";
        decimal salario = 15000;
        bool funcionarioAtivo = true;
      }  
    } 
}

// No código anterior temos alguns exemplos de variáveis e tipos diferentes
// Visualizando o nome das variáveis podemos perceber que cada uma delas tem uma finalidade um tipo e um valor inicial
// Assim que essas variáveis ficam disponíveis na memória é possível acessá-las, exibi-las ou manipulá-las
// De fato, as variáveis são formas como podemos armazenar as informações durante o fluxo a ser feito dentro do sistema