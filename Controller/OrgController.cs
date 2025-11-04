using Abstract_C_.Model.Abstract;
using Abstract_C_.Model.Class;
namespace Abstract_C_.Controller
{
    internal class OrgController
    {
        private Organism[] arr = new Organism[0];
        public void AddOrganism(Organism organism)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = organism;
        }

        public void DeleteOraganism(string name)
        {
            int index = -1;
            while (true)
            {
                index = Array.FindIndex(arr, o => o.Name == name);
                if (index != -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Organism not found. Please enter a valid name:");
                }
            }
            for (int i = index; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
        }

        public Organism[] GetAll()
        {
            return arr;
        }
    }
}
