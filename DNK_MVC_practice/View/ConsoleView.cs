using Abstract_C_.Controller;
using Abstract_C_.Model.Class;

namespace Abstract_C_.View
{
    internal class ConsoleView
    {
        private OrgController controller = new OrgController();
        public void AddOrganism()
        {
            Console.WriteLine("Organism name:");
            string name = Console.ReadLine();
            Console.WriteLine("DNA sequence:");
            string dna = Console.ReadLine();
            Console.WriteLine("Is it an Animal or Plant? (A/P):");
            string type = Console.ReadLine();
            if (type.ToUpper() == "A")
            {
                Console.WriteLine("Number of chromosomes:");
                int chromosomes = int.Parse(Console.ReadLine());
                Animal animal = new Animal(name, dna, chromosomes);
                controller.AddOrganism(animal);
            }
            else if (type.ToUpper() == "P")
            {
                Console.WriteLine("Does it have photosynthesis? (true/false):");
                bool hasPhotosynthesis = bool.Parse(Console.ReadLine());
                Plant plant = new Plant(name, dna, hasPhotosynthesis);
                controller.AddOrganism(plant);
            }
            else
            {
                Console.WriteLine("Invalid type. Organism not added.");
            }
        }

        public void DeleteOraganism()
        {
            Console.WriteLine("Enter the name of the organism to delete:");
            string name = Console.ReadLine();
            controller.DeleteOraganism(name);
        }

        public void DisplayAll()
        {
            foreach (var elem in controller.GetAll())
            {
                elem.DisplayInfo();
                Console.WriteLine("--------------------");
            }
        }
    }
}
