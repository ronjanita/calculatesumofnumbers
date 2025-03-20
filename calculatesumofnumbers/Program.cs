class Programm
{
    static void Main()
    {
        Console.WriteLine("enter number:");
        int input = Convert.ToInt32(Console.ReadLine());
        int resultat = 0;
        for (int i = 0; i < input; i++) ;
        {
            int i = 0;
            resultat += i;
        }
        Console.WriteLine($"resultat: {resultat}");
    }
}
