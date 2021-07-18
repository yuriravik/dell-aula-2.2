using System;

namespace dell_aula_2._2
{
    class Program
    {

        /*
           */
        static void Main(string[] args)
        {
            

            Professor professor1 = new Professor;
            professor1.nome = "joão";
            professor1.carteiraTrab = 12345678;
            professor1.salario = 3000;

            professor1.realizarChamada();
            professor1.postarConteudo("matematica");


            Professor professor2 = new Professor;
            professor2.nome = "arthur";
            professor2.carteiraTrab = 12345678;
            professor2.salario = 3500;

            professor2.realizarChamada();
            professor2.postarConteudo("fisica");


            Aluno aluno1 = new Aluno;
            Aluno aluno2 = new Aluno;

            aluno1.nome = "yuri";
            aluno1.matricula = 0001;
            aluno1.email = "yuri@email.com";

            aluno1.inserirDisciplina("matematica");
            aluno1.inserirDisciplina("português");
            aluno1.inserirDisciplina("fisica");

            aluno1.removerDisciplina("português");

            aluno1.realizarMatricula("matematica");
            aluno1.realizarMatricula("português");

            aluno2.nome = "maria";
            aluno2.matricula = 0002;
            aluno2.email = "maria@email.com";

            aluno2.inserirDisciplina("matematica");
            aluno2.inserirDisciplina("português");
            aluno2.inserirDisciplina("fisica");

            aluno2.removerDisciplina("português");

            aluno2.realizarMatricula("matematica");
            aluno2.realizarMatricula("português");
            
        }
        public class Professor
        {

            public String nome;
            public int carteiraTrab;
            public float salario;

            public void realizarChamada()
            {
                Console.Write("Professor realizando chamada!");
            }
            public void postarConteudo(String conteudo)
            {
                Console.Write("Professor postando o conteúdo: " + conteudo);
            }

        }
        public class Aluno
        {

            public String nome;
            public int matricula;
            public String email;
            
            public void inserirDisciplina(String disciplina)
            {
                Console.Write("Você adicionou a disciplina de : " + disciplina;
            }
            public void removerDisciplina(String disciplina)
            {
                Console.Write("Você removeu a disciplina de : " + disciplina;
            }
            public void realizarMatricula(String disciplina)
            {
                Console.Write("Você realizou a matricula na disciplina de : " + disciplina;
            }
        }

    }
}
