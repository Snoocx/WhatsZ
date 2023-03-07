
internal class Program
{
    private static void Main(string[] args)
    {
        int number = 0;
        Console.WriteLine("Mit 0 Programm beenden.");

        do
        {
            Console.WriteLine("\nWelche Aufgabe? 2/3/4/5/6");

            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                return;

            number = int.Parse(input);
            switch (number)
            {
                case 2:
                    Aufgabe2();
                    break;
                case 3:
                    Aufgabe3();
                    break;
                case 4:
                    Aufgabe4();
                    break;
                case 5:
                    Aufgabe5();
                    break;
                case 6:
                    Aufgabe6();
                    break;
                default:
                    Console.WriteLine("Nicht gefunden..");
                    break;
            }
        } while (number != 0);

    }

    public static void Aufgabe2()
    {
        int z = -2;
        int i = 99;
        
        while(i > 88)
        {
            z = z + 3;
            z = -z;
            i = i - 2;
        }

        Console.WriteLine(z.ToString()); // -2

    }


    public static void Aufgabe3()
    {
        int i = 0;
        int z = 0;

        while(i < 20)
        {
            int j = i;

            while(j < 20)
            {
                z = z + j;
                j = j + 1;
            }

            i = i + 5;
        }

        Console.WriteLine(z.ToString()); // 600

    }

    public static void Aufgabe4()
    {
        int z = 4;
        int i = 4;

        while (i > 0)
        {
            z = z + 4;
            z = z / i;
            i = i - 1;
        }

        Console.WriteLine(z.ToString()); // 7

    }

    public static void Aufgabe5()
    {
        int z = 0;

        while(z != 1 && z != 2) // 1 oder 2 eingeben
        {
            Console.WriteLine("\nZahl eingeben:");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;
            z = int.Parse(input);
        }

        Console.WriteLine("Programm beendet.");
    }

    public static void Aufgabe6()
    {
        int i = 10;
        int z = 100;

        while (i > 0)
        {
            if(i % 2 == 0)
            {
                z = z - 1;
            }
            else
            {
                z = z + 1;
            }

            i = i - 1;
        }

        Console.WriteLine(z.ToString()); //100
    }
}