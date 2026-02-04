using Abstract_C_.Model.Abstract;

namespace Abstract_C_.Model.Class
{
    internal class Animal : Organism
    {
        public int Chromosomes { get; set; }

        public Animal(string name, string dna, int chromosomes) : base(name, dna)
        {
            Name = name;
            DNA = dna;
            Chromosomes = chromosomes;
        }

        public override void Mutate()
        {
            var random = new Random();
            int mutationPoint = random.Next(0, DNA.Length);
            DNA = DNA.Remove(mutationPoint, 1).Insert(mutationPoint, ((char)random.Next('A', 'Z' + 1)).ToString());
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Animal Name: {Name}");
            Console.WriteLine($"DNA Sequence: {DNA}");
            Console.WriteLine($"Chromosomes: {Chromosomes}");
        }
    }
}
