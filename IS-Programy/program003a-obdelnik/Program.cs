string again = "a";
Console.Clear();
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání malého "a" tak i velkého "A"
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("********* Vykreslení obdélníku ********");
    Console.WriteLine("***************************************");
    Console.WriteLine("********** Sebastian Beneš ************");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");
    Console.WriteLine();

    // Vstup pro šířku
    Console.Write("Zadejte šířku obrazce (celé kladné číslo): ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) || width <=0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé kladné číslo! Zadejte šířku znovu (celé číslo): ");
        Console.ResetColor();
    }

    // Vstup pro výšku
    Console.Write("Zadejte výšku obrazce (celé kladné číslo): ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé kladné číslo! Zadejte výšku znovu (celé číslo): ");
        Console.ResetColor();
    }

    
    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    // Proměnné vypsané vedle sebe
    Console.WriteLine($"Šířka: {width}; Výška: {height}");
    
    Console.WriteLine("====================================");
    Console.WriteLine();
    

    // Začátek konkrétního algoritmu
    // Vnější cyklus, který se bude starat o vykreslení spravného počtu řádků
    for(int i = 1; i <= height; i++)
    {
        if(i % 2 == 0)
        {
            //sudý řádek
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
            //lichý řádek
            Console.ForegroundColor = ConsoleColor.Green;
        }

        // Vnitřní cyklus, který se stará o správný počet znaků v i-tém řádku
        for(int j = 1; j <= width; j++)
        {
            Console.Write("* ");
            System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); // Zpoždění
        }
        Console.WriteLine();
    }

    Console.ResetColor();


    // Konec konkrétního algoritmu
    




    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}