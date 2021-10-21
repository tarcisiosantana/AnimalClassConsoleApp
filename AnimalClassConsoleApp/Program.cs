using System;

namespace AnimalClassConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramAnimal programAnimal = new ProgramAnimal();
            bool validate = true;
            int option;
            do
            {
                Console.WriteLine("Seja Bem Vindo!");
                Console.WriteLine("MENU!");
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("(1) Classe animal");
                Console.WriteLine("(2) Sair do programa");

                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        programAnimal.Start();
                        break;
                    case 2:
                        validate = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (validate);
        }
    }
}