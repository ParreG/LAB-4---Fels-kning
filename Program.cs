namespace LAB_4___Felsökning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            case1();
            Console.WriteLine();

            case2();
            Console.WriteLine();

            case3();
            Console.WriteLine();

            case4();
            Console.WriteLine();

            case5();
            Console.WriteLine();

            case6();
        }

        static void case1()
        {

            int number = 2;

            if (number > 3)
            {
                Console.WriteLine("Talet är större än tre");//Saknade semikollon
            }
            else if(number < 3); //Saknade semi kollon och elseif var stavad utan mellanslag
{
                Console.WriteLine("Talet är mindre än tre");
            }
        }

        static void case2()
        {
                            // 100 behöver ändras till 101 för att loopen ska gå till 100. Eller om det istället för "<" står "<="
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            //for (int i = 1; i < 101; i++) Denna funkar också!!
            //{
            //    Console.WriteLine(i);
            //}
        }

        static void case3()
        {
            for (int i = 1; i <= 5; i++)//Behöver stå i++ och inte bara i
            {
                for (int j = 1; j <= i; j++) // samma sak här behöver stå j++
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void case4()
        {
            int i = 1;
            while (i <= 5)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j); // Den måste skriva ut något. Det kan inte vara tomt i paranteserna!
                }

                Console.WriteLine();
                i++;
            }
        }

        static void case5()
        {
            int i = 1;

            switch (i)
            {
                case 1:
                    // För att det inte ska bli någon utskrift behöver vi ha en console writeLine under case 1 men att vi
                    // lämna den tom! I det här fallet
                    // skriver jag ut tomt så vi vet att det funkar!
                    Console.WriteLine("tomt"); 
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }

        static void case6()
        {
            int i = 10;

            // Det kan inte vara ett lika med tecken. Lika med tecken betyder att vi tillderar den värdet.
            // Den betyder inte lika med! Däremot två lika med tecken == betyder att det är lika med!
            // Däremot kommer denna kod ändå inte generera något då i är 10 och inte 5! Jag lägger till en else sats så att vi får någon output ändå!
            if (i == 5) 
            {
                Console.WriteLine("i är 5");
            }
            else
            {
                Console.WriteLine("i är större än 5");
            }
        }
    }
}
