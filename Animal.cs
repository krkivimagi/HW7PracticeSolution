namespace HW7PracticeSolution
{
    internal class Animal : IAnimal
    {
        protected int _jumpCount;
        protected string _animalType;
        protected string _name;
        public Animal()
        {
            _animalType = "General animal";
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal is making sound");
        }
        public virtual void Jump()
        {
            _jumpCount++;
            Console.WriteLine($"{_animalType} has jumped {_jumpCount} times.");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{_animalType} name is {_name}.");
        }
        public virtual void SetName(string name)
        {
            _name = name;
            Console.WriteLine($"{_animalType} name set to: {_name}");
        }
    }
}
