using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClassConsoleApp
{
    class ProgramAnimal
    {
        List<Animal> listAnimals = new List<Animal>();
        int[] amount = new int[3];
        public void Start()
        {
            amount[0] = 0; // QTD Cachoro
            amount[1] = 0; // QTD Gato
            amount[2] = 0; // QTD Peixe

            this.readAnimal();
            this.displayAnimals();
            this.countAnimalTypes();
        }

        public void readAnimal()
        {
            string inputNome;
            string inputTipo;
            Animal animal;

            Console.WriteLine("Você está no programa animal");

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Digite o nome do {0}º animal: ", x + 1);
                inputNome = Console.ReadLine();

                Console.WriteLine("Digite o tipo do {0}º animal: ", x + 1);
                inputTipo = Console.ReadLine();
                animal = new Animal(inputNome, inputTipo);
                listAnimals.Add(animal);
            }
        }

        public void displayAnimals()
        {
            Console.WriteLine("###Lista de animais criados###");
            foreach (Animal animal in listAnimals)
            {
                Console.WriteLine("=============OBJECT(ANIMAL)===============");
                Console.WriteLine("Nome: {0}", animal.getNome());
                Console.WriteLine("Tipo: {0}", animal.getTipo());
            }
        }

        public void countAnimalTypes()
        {
            foreach (Animal animal in listAnimals)
            {
                this.verifyType(animal);
            }

            Console.WriteLine("=============QUANTIDADE================");
            Console.WriteLine("Quantidade de cachorros: {0}", amount[0]);
            Console.WriteLine("Quantidade de gatos: {0}", amount[1]);
            Console.WriteLine("Quantidade de peixes: {0}", amount[2]);
        }

        public void verifyType(Animal animal)
        {
            if (animal.getTipo().ToUpper() == "CACHORRO")
            {
                amount[0]++;
            }
            else if (animal.getTipo().ToUpper() == "GATO")
            {
                amount[1]++;
            }
            else
            {
                amount[2]++;
            }
        }
    }
}
