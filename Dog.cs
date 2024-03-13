namespace HW7PracticeSolution;
internal class Dog : Animal
{
    protected int _maxNameLength; //animal does not have it; cat will need it. define it here
    public Dog()
    {
        _animalType = "Dog";
        _maxNameLength = 8;
    }
    public override void MakeSound()
    {
        Console.WriteLine("Dog is barking");
    }
    public override void SetName(string name)
    {
        if (name.Length <= _maxNameLength){
            base.SetName(name);
        }
        else{
            Console.WriteLine("Too long name");
        }
    }
}