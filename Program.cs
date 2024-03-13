namespace HW7PracticeSolution;
internal class Program
{
    static void Main(string[] args)
    {
        Dog muki = new Dog();
        muki.MakeSound();
        muki.SetName("Mingi pikk nimi"); //invalid
        muki.SetName("Muki");
        muki.PrintInfo();


        Cat whiskers = new Cat();
        whiskers.Jump();
        whiskers.Jump();
        whiskers.Jump();
        whiskers.Jump(); //cat is tired
        whiskers.SetName("whiskers"); //too long
        whiskers.SetName("purr");
        whiskers.MakeSound();

        Chiaua chi = new Chiaua();
        chi.MakeSound();
    }
}
