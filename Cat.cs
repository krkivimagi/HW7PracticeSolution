namespace HW7PracticeSolution;
internal class Cat : Dog
{
    public Cat()
    {
        _maxNameLength = 4;
        _animalType = "Cat";
    }
    public override void MakeSound()
    {
        Console.WriteLine("Cat is meowing");
    }
    public override void Jump()
    {
        if (_jumpCount < 3)
        {
            base.Jump();
        }
        else
        {
            Console.WriteLine("Cat is tired");
        }
    }
}