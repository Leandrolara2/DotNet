using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indorme a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");    
            Console.WriteLine("3- calcular media geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

           string opcaoUsuario = Console.ReadLine();

           while (opcaoUsuario.ToUpper() !="X")
           {
               switch(opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        break;

                    case "2":
                        //TODO: Listar alunos
                        break;
                    
                    case "3":
                        //TODO: Calcular media geral
                        break;

                    default:
                    throw new ArgumentOutOfRangeException();

                }
                Console.WriteLine("Indorme a opção desejada");
                Console.WriteLine("1- Inserir novo aluno");
                Console.WriteLine("2- Listar alunos");    
                Console.WriteLine("3- calcular media geral");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                opcaoUsuario = Console.ReadLine();

           }
            
        }
    }
}
