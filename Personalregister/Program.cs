// See https://aka.ms/new-console-template for more information

class Personalregister
{
    //Det primära är att koden fungerar
    public string Namn { get; set; }
    public double Lon { get; set; }
}


class Program
{
    static void Main()
    {

        Personalregister personalregister = new Personalregister();
        Console.WriteLine("Skriv namn:");
        personalregister.Namn = Console.ReadLine();

        Console.WriteLine("Skriv lön:");
        //Conversation till 
        personalregister.Lon = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Personal " + personalregister.Namn + " har lön " + personalregister.Lon + "Kr.");

        Console.ReadLine();

    }
}


