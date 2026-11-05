// Toto je jednořádkový komentář

/* Toto je
víceřádkový
komentář */ 


// Nejprve budeme řešit opakování programu

string again = "a";
Console.Clear();
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání malého "a" tak i velkého "A"
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("************ Výpis řady ***************");
    Console.WriteLine("***************************************");
    Console.WriteLine("********** Sebastian Beneš ************");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");
    Console.WriteLine();

    // Vstup počáteční hodnoty - špatně řešený
    // Console.Write("Zadejte první číslo řady (celé číslo): ");
    // int first =int.Parse(Console.ReadLine()); 

    // Vstup počáteční hodnoty - řešený správně 
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte první číslo řady znovu (celé číslo): ");
    }

    // Vstup konečné hodnoty
    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte poslední číslo řady znovu (celé číslo): ");
    }

    // Vstup pro diferenci s kontrolou na kladnou hodnotu
    Console.Write("Zadejte diferenece (kladné celé číslo): ");
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <= 0 )
    {
        Console.Write("Nezadali jste kladné celé číslo! Zadejte diferenci znovu (kladné celé číslo): ");
    }


    // Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    // Proměnné vypsané pod sebou
    // Console.WriteLine($"První číslo řady: {first}");
    // Console.WriteLine($"Poslední číslo řady: {last}");
    // Console.WriteLine($"Diference (krok): {step}");
    
    // Proměnné vypsané vedle sebe
    Console.WriteLine($"První číslo řady: {first}; Poslední číslo řady: {last}; Diference (krok): {step}");
    
    Console.WriteLine("====================================");
    Console.WriteLine();
    

    // Algoritmus pro výpis řady
    if (first <= last)
    {
        int current = first;
        while(current <= last)
        {
            // Console.WriteLine(current);
            Console.Write($"{current}; ");
            // current = current + step;
            // předchozí řádek lze napsat zkráceně
            current += step;

        }
    }
    else
    {
      Console.WriteLine("Řadu nelze vypsat!");
      Console.WriteLine("První číslo je větš než poslední číslo řady!");
      Console.WriteLine("Tento program umí vypsat pouze vzestupnou řadu (od menšího k většímu).");  
    }




    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}