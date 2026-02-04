namespace Abstract_C_.Model.Abstract
{
    public abstract class Organism
    {
        public string Name { get; set; }
        public string DNA { get; set; }

        public Organism(string name, string dna) { 
            Name = name;
            DNA = dna;
        }

        public abstract void Mutate();
        public abstract void DisplayInfo();
    }
}
