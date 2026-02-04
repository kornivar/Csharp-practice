using Abstract_C_.Model.Abstract;

namespace Abstract_C_.Model.Class
{
    internal class Plant : Organism
    {
        public bool HasPhotosynthesis { get; set; }
        public Plant(string name, string dna, bool hasPhotosynthesis) : base(name, dna)
        {
            Name = name;
            DNA = dna;
            HasPhotosynthesis = hasPhotosynthesis;
        }
        public override void Mutate()
        {
            var random = new Random();
            int check = random.Next(0, 2);
            if (check == 0)
            {
                char mutation = (char)random.Next('A', 'Z' + 1);
                DNA += mutation;
            }
            else
            {
                DNA = DNA.Length > 0 ? DNA.Remove(DNA.Length - 1) : DNA;
            }
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Plant Name: {Name}");
            Console.WriteLine($"DNA Sequence: {DNA}");
            Console.WriteLine($"Has Photosynthesis: {HasPhotosynthesis}");
        }
    }
}
