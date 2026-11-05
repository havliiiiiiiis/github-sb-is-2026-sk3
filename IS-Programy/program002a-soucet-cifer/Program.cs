string again = "a";
Console.Clear();
// .ToLower() převede vstup na malá písmena, takže program bude pokračovat při zadávání malého "a" tak i velkého "A"
while(again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("***************************************");
    Console.WriteLine("************* Součet cifer ************");
    Console.WriteLine("***************************************");
    Console.WriteLine("********** Sebastian Beneš ************");
    Console.WriteLine("***************************************");
    Console.WriteLine("***************************************");
    Console.WriteLine();

    // 1. Vstup celočíselné hodnoty
    Console.Write("Zadejte celé číslo: ");
    int number;
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo! Zadejte celé číslo: ");
    }


    
    // 2. Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("====================================");
    Console.WriteLine();
    

    // Začátek konkrétního algoritmu

    // 3. Příprava pomocných proměnných pro vyřešení problému
    int numberBackup = number; // Záloha zadaného čísla pro závěrečný výpis 
    int sum = 0;               // Neutrální hodnota pro sčítání je 0
    int digit;                 // Proměnná pro uložení právě zjištěné číslice


    // 4. Ošetření záporných čísel (znaménko nemá vliv na hodnotu ciferného s)
    if (number < 0)
    {
        number = -number;
    }
    else
    {
        
    }


    // 5. Zvláštní případ pro nulu
    if (number < 0)
    {
        sum = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na jednotlivé číslice (z pr)");

        // 6. Matematický rozklad čísla v cyklu while
        while (number > 0)
        {
            // Operátor % je MODULO (zbytek po celočíselném dělení)
            digit = number % 10;  // MODULO 10 získá poslední číslici
            sum = sum + digit;    // Přičtení číslice k celkovému součtu
            number = number / 10; // Celočíselné dělení 10kou odstraní poslední číslici

            Console.WriteLine($"Aktuální číslice (zbytek): {digit}");
            Console.WriteLine($"Aktuální hodnota součtu: {sum}");
            Console.WriteLine($"Číslo po oříznutí poslední číslice: {number}");
        }
    }

    // 7. Přehledný výpis výsledku
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Součet cifer čísla number {numberBackup} je {sum}.");
    Console.WriteLine("====================================");
    Console.WriteLine();




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