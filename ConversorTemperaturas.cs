namespace conversorTemperatura
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao conversor de temperatura.\n");
            Console.WriteLine("1 - Fahrenheit para Celsius\n2 - Fahrenheit para Kelvin\n3 - Celsius para Fahrenheit\n4 - Celsius para Kelvin\n5 - Kelvin para Fahrenheit\n6 - Kelvin para Celsius\n0 - Para sair");
            Console.WriteLine("\n___________________________");

            Console.Write("Digite a opção desejada:");
            var result = short.Parse(Console.ReadLine());

            switch (result)
            {
                case 0: Exit(); break;
                case 1: FahrenheitParaCelsius(); break;
                case 2: FahrenheitParaKelvin(); break;
                case 3: CelsiusParaFahrenheit(); break;
                case 4: CelsiusParaKelvin(); break;
                case 5: KelvinParaFahrenheit(); break;
                case 6: KelvinParaCelsius(); break;
                default: Console.WriteLine("Escolha uma opção válida, pressione qualquer tecla e tente novamente."); break;
            }

            //Caso a opção escolhida não seja válida
            TenteNovamente();
        }

        static void FahrenheitParaCelsius()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Fahrenheit para conversão em Celsius:");
            var value = int.Parse(Console.ReadLine());
            var result = (value - 32) * 5 / 9;
            Console.WriteLine($"\nA temperatura {value}Fº, equivale a temperatura de {result}Cº.");
            Console.ReadLine();
            Menu();
        }

        static void FahrenheitParaKelvin()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Fahrenheit para conversão em Kelvin:");
            var value = decimal.Parse(Console.ReadLine());
            decimal result = (value - 32) * 5 / 9 + 273.15M;
            Console.WriteLine($"\nA temperatura {value}Fº, equivale a temperatura de {result}Kº.");
            Console.ReadLine();
            Menu();
        }

        static void CelsiusParaFahrenheit()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Celsius para conversão em Fahrenheit:");
            var value = decimal.Parse(Console.ReadLine());
            decimal result = value * 1.8M + 32;
            Console.WriteLine($"\nA temperatura {value}C°, equivale a temperatura de {result}Fº.");
            Console.ReadLine();
            Menu();
        }

        static void CelsiusParaKelvin()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Celsius para conversão em Kelvin:");
            var value = decimal.Parse(Console.ReadLine());
            decimal result = value + 273.15M;
            Console.WriteLine($"\nA temperatura {value}C°, equivale a temperatura de {result}Kº.");
            Console.ReadLine();
            Menu();
        }

        static void KelvinParaFahrenheit()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Kelvin para conversão em Fahrenheit:");
            var value = decimal.Parse(Console.ReadLine());
            decimal result = (value - 273.15M) * 9 / 5 + 32;
            Console.WriteLine($"\nA temperatura {value}K°, equivale a temperatura de {result}Fº.");
            Console.ReadLine();
            Menu();
        }

        static void KelvinParaCelsius()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor em Kelvin para conversão em Celsius:");
            var value = decimal.Parse(Console.ReadLine());
            decimal result = value - 273.15M;
            Console.WriteLine($"\nA temperatura {value}Kº, equivale a temperatura de {result}Fº.");
            Console.ReadLine();
            Menu();
        }

        static void TenteNovamente()
        {
            Console.ReadLine();
            Console.Clear();
            Menu();
        }

        static void Exit() /*saida aplicação*/
        {
            Console.WriteLine("Feito por Gabriel Lemes de Oliveira");
            System.Environment.Exit(0);
        }
    }
}
