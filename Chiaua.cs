namespace HW7PracticeSolution;
internal class Chiaua : Dog
{
    public Chiaua()
    {
        _animalType = "Chiuaua";
    }
    public override void MakeSound()
    {
        base.MakeSound();
        Console.WriteLine("With an irritating voice");
    }
}