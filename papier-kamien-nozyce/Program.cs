static void cw(string tekst)
{
    foreach (char litera in tekst)
    {
        Console.Write(litera);
        Thread.Sleep(25);
    }
}
for (int i = 0; i < 21; i++)
{
    Console.Write("#");
    Thread.Sleep(25);
}
Console.WriteLine();
cw("papier kamien nozyce!");
Console.WriteLine();
for (int i = 0; i < 21; i++)
{
    Console.Write("#");
    Thread.Sleep(25);
}
Thread.Sleep(2500);
Console.Clear();
Console.WriteLine();
cw("witaj w grze! chcesz grac z komputerem czy z druga osoba? ");
string wybor = Console.ReadLine().ToLower();
Console.Clear();
if (wybor == "z komputerem")
{
    cw("wybrano gre z komputerem.");
    Thread.Sleep(1000);
    Console.Clear();
    int doIlu = int.Parse(Console.ReadLine());
    cw("jaki ruch chcesz wykonac (papier kamien nozyce)? ");
    string ruchGracza = Console.ReadLine().ToLower();
    Console.Clear();
    Random rand = new Random();
    int ruchKomputera = rand.Next(1, 4);
    if (ruchKomputera == 1)
    {
            cw("komputer wybral papier.");
            Thread.Sleep(750);
            Console.Clear();
    }
    else if (ruchKomputera == 2)
    {
        cw("komputer wybral kamien.");
        Thread.Sleep(750);
        Console.Clear();
    }
    else if (ruchKomputera == 3)
    {
        cw("komputer wybral nozyce.");
        Thread.Sleep(750);
        Console.Clear();
    }

    switch (ruchKomputera)
    {
        case 1:
        {
            switch (ruchGracza)
            {
                case "papier":
                    cw("walka!");
                    Thread.Sleep(750);
                    Console.Clear();
                    cw("remis!");
                    Thread.Sleep(1000);
                    break;
                case "kamien" or "kamień":
                    cw("walka!");
                    Thread.Sleep(750);
                    Console.Clear();
                    cw("przegrales...");
                    Thread.Sleep(1000);
                    break;
                case "nozyce" or "nożyce":
                    cw("walka!");
                    Thread.Sleep(750);
                    Console.Clear();
                    cw("wygrales!");
                    Thread.Sleep(1000);
                    break;
            }

            break;
        }
        case 2:
            switch (ruchGracza)
            {
                case "papier":
                    cw("walka!");
                    Thread.Sleep(750);
                    Console.Clear();
                    cw("wygrales!");
                    Thread.Sleep(1000);
                    break;
                case "kamien" or "kamień":
                    cw("walka!");
                    Thread.Sleep(750);
                    Console.Clear();
                    cw("remis!");
                    Thread.Sleep(1000);
                    break;
                case "nozyce" or "nożyce":
                    cw("walka!");
                    Thread.Sleep(750);
                    Console.Clear();
                    cw("przegrales...");
                    Thread.Sleep(1000);
                    break;
            }

            break;
        case 3:
            switch (ruchGracza)
            {
                case "papier":
                    cw("walka!");
                    Thread.Sleep(750);
                    Console.Clear();
                    cw("przegrales...");
                    Thread.Sleep(1000);
                    break;
                case "kamien" or "kamień":
                    cw("walka!");
                    Thread.Sleep(750);
                    Console.Clear();
                    cw("wygrales!");
                    Thread.Sleep(1000);
                    break;
                case "nozyce" or "nożyce":
                    cw("walka!");
                    Thread.Sleep(750);
                    Console.Clear();
                    cw("remis!");
                    Thread.Sleep(1000);
                    break;
            }

            break;
    }
}
else if (wybor == "z druga osoba" || wybor == "z drugą osobą")
{
        cw("wybrano gre z druga osoba.");
        Thread.Sleep(750);
        Console.Clear();
        cw("graczu nr 1, zakryj ekran tak, aby gracz nr 2 go nie widzial.");
        Console.ReadKey(intercept: true);
        Console.Clear();
        cw("jaki ruch chcesz wykonac (papier kamien nozyce)? ");
        string ruchGracza1 = Console.ReadLine().ToLower();
        Console.Clear();
        cw("czas na ruch gracza nr 2.");
        Console.ReadKey(intercept: true);
        Console.Clear();
        cw("graczu nr 2, zakryj ekran tak, aby gracz nr 1 go nie widzial.");
        Console.ReadKey(intercept: true);
        Console.Clear();
        cw("jaki ruch chcesz wykonac (papier kamien nozyce)? ");
        string ruchGracza2 = Console.ReadLine().ToLower();
        Console.Clear();
        cw("graczu nr 2, odkryj ekran, abyscie oboje go widzieli.");
        Console.ReadKey(intercept: true);
        Console.Clear();
        cw("gracz nr 1 wybral " + ruchGracza1 + ", a gracz nr 2 wybral " + ruchGracza2 + ".");
        Thread.Sleep(1500);
        Console.Clear();
        switch (ruchGracza1)
        {
            case "papier":
                switch (ruchGracza2)
                {
                    case "papier":
                        cw("walka!");
                        Thread.Sleep(750);
                        Console.Clear();
                        cw("remis!");
                        Thread.Sleep(1000);
                        break;
                    case "kamien" or "kamień":
                        cw("walka!");
                        Thread.Sleep(750);
                        Console.Clear();
                        cw("gracz nr 1 wygrywa!");
                        Thread.Sleep(1000);
                        break;
                    case "nozyce" or "nożyce":
                        cw("walka!");
                        Thread.Sleep(750);
                        Console.Clear();
                        cw("gracz nr 2 wygrywa!");
                        Thread.Sleep(1000);
                        break;
                }

                break;
            case "kamien" or "kamień":
                switch (ruchGracza2)
                {
                    case "papier":
                        cw("walka!");
                        Thread.Sleep(750);
                        Console.Clear();
                        cw("gracz nr 2 wygrywa!");
                        Thread.Sleep(1000);
                        break;
                    case "kamien" or "kamień":
                        cw("walka!");
                        Thread.Sleep(750);
                        Console.Clear();
                        cw("remis!");
                        Thread.Sleep(1000);
                        break;
                    case "nozyce" or "nożyce":
                        cw("walka!");
                        Thread.Sleep(750);
                        Console.Clear();
                        cw("gracz nr 1 wygrywa!");
                        Thread.Sleep(1000);
                        break;
                }

                break;
            case "nozyce" or "nożyce":
                switch (ruchGracza2)
                {
                    case "papier":
                        cw("walka!");
                        Thread.Sleep(750);
                        Console.Clear();
                        cw("gracz nr 1 wygrywa!");
                        Thread.Sleep(1000);
                        break;
                    case "kamien" or "kamień":
                        cw("walka!");
                        Thread.Sleep(750);
                        Console.Clear();
                        cw("gracz nr 2 wygrywa!");
                        Thread.Sleep(1000);
                        break;
                    case "nozyce" or "nożyce":
                        cw("walka!");
                        Thread.Sleep(750);
                        Console.Clear();
                        cw("remis!");
                        Thread.Sleep(1000);
                        break;
                }

                break;
        }
}
else
{
        cw("nieprawidlowy wybor!");
        Thread.Sleep(750);
        Console.Clear(); 
}
