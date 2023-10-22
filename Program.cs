namespace brincandogit;
    class program {
        static void Main(string[] args)
    {
        Console.WriteLine("Hello, branch master!");
        Console.WriteLine("Projeto inicial");

        System.Console.WriteLine("digite o primeiro número: ");
        int number1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("digite o segundo número: ");
        int number2 = int.Parse(Console.ReadLine());

        Menu(number1, number2);

        Console.ReadKey();
    }

    private static void Menu(int number1, int number2)
    {
        Console.WriteLine("Somar ou Subtrair?");
        Console.WriteLine("Pressione [s] para somar");
        Console.WriteLine("Pressione [d] para subtrair");
        char opcao = Convert.ToChar(Console.ReadLine().ToLower());

        switch (opcao)
        {
            case 's': Somar(number1, number2); break;
            case 'd': Subtrair(number1, number2); break;
            default: Menu(number1, number2); break;
        }
    }

    static int Somar(int number1, int number2){
            int res = number1 + number2;
            System.Console.WriteLine("resultado: " + res);
            return res;
        }
          static int Subtrair(int number1, int number2){
            int res = number1 - number2;
            System.Console.WriteLine("resultado: " + res);
            return res;
        }
    }


