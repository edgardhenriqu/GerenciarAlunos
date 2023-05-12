namespace Aula_3;
class Program
{
    static void Main(string[] args)
    {
        
        Aluno[] alunos = new Aluno[5];

        int posicao = 0;
        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("\n\nEscolha a opção que deseja:");
            Console.WriteLine("1. Novo Aluno");
            Console.WriteLine("2. Listar Alunos");
            Console.WriteLine("3. Alterar Nome");
            Console.WriteLine("4. Remover Aluno");
            Console.WriteLine("0. Sair");
            opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você escolhe a opcao " + opcao);

            if (opcao == 1)
            {
                Aluno aluno = new Aluno();

                Console.WriteLine("\n\nInforme o Nome:");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("\n\nInforme o Curso:");
                aluno.Curso = Console.ReadLine();

                Console.WriteLine("\n\nInforme a Matrícula:");
                aluno.Matricula = Console.ReadLine();

                Console.WriteLine("\n\nInforme a Idade:");
                aluno.idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n>>Aluno registrado!!!");

                alunos[posicao] = aluno;
                posicao++;

            }
            else if (opcao == 2)
            {
                for (int cont = 0; cont < posicao; cont++)
                {
                    Console.WriteLine(alunos[cont].Nome + ", Curso " + alunos[cont].Curso + ", Matricula: " + alunos[cont].Matricula);
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("\n\nInforme a Matrícula:");
                string Matricula = Console.ReadLine();

                for (int cont = 0; cont < posicao; cont++)
                {
                    if (alunos[cont].Matricula == Matricula)
                    {
                        Console.WriteLine("\nAchamos a Matrícula");
                        Console.WriteLine("Informe o novo nome:");
                        string novoNome = Console.ReadLine();

                        alunos[cont].Nome = novoNome;
                    }
                }
            }
            else if (opcao == 4)
            {
                Console.WriteLine("\n\nInforme a Matrícula:");
                string Matricula = Console.ReadLine();

                int posicaoRemover = -1;

                for (int pos = 0; pos < posicao; pos++)
                {
                    if (alunos[pos].Matricula == Matricula)
                    {
                        posicaoRemover = pos;
                        break;
                    }
                }

                if (posicaoRemover == (posicao-1))
                {
                    alunos[posicao - 1] = null;
                    posicao--;
                }
                else
                {
                    for (int pos = posicaoRemover + 1; pos < posicao; pos++)
                    {
                        alunos[pos - 1] = alunos[pos];
                    }
                    alunos[posicao - 1] = null;
                    posicao--;
                }
            }
         }
    }
}
