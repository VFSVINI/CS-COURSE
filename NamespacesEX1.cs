// Na figura acima temos duas classes com o nome de “ClasseUm”.
// Isso não é permitido na estrutura da linguagem e o compilador vai exibir um erro
// Informando que já existe uma classe com o mesmo nome
// Assim como em qualquer sistema operacional
// Dentro de uma mesma estrutura não será possível
// Ter um arquivo com o mesmo nome
// Assim que alterarmos o nome da segunda classe para algo diferente
// O compilador entenderá que não temos mais conflitos de membros dentro do mesmo namespace


namespace ProgramaPrincipal{

    public class ClasseUm
    {

        public int Id {get; set;}

        public string Nome {get; set;}

    }    

    public class ClasseUm  
    {

        public int Id {get; set;}

        public string Nome {get; set;}
        
    }  
    
}




