namespace brincandogit;
    class program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, branch master!");
            Console.WriteLine("Projeto inicial");

            System.Console.WriteLine("digite o primeiro número a ser somado: ");
            int number1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("digite o segundo número a ser somado: ");
            int number2 = int.Parse(Console.ReadLine());

            int soma = Soma(number1, number2);
            System.Console.WriteLine("resultado: " + soma);
        }

        static int Soma(int number1, int number2){
            return number1 + number2;
        }
    }


