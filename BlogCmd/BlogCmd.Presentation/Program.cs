using BlogCmd.Domain.Entities;
using System;

namespace BlogCmd.Presentation
{
    public class Program
    {
        private Usuario UsuarioLogado { get; set; }
        private bool IsAuthenticated { get { return UsuarioLogado != null; } }

        public static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("************************Sistema loko de Blog**************************");
            Console.WriteLine("*************Utilize o menu para navegação no sistema*****************");
            Console.WriteLine("**********************************************************************");

            while (true)
            {
                Console.WriteLine("Você não está logado no sistema");

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}