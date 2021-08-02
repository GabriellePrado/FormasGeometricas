using FormasGeometricas.Model;
using System;
using System.Globalization;

namespace FormasGeometricas
{
    class Program
    {
         static void Main(string[] args)
        {
            bool EncerrarPrograma = true;
            do
            {
                Console.Clear();
                Console.WriteLine(" Bem vindo ao Formas Geométricas ! ");
                Console.WriteLine(" Digite sua escolha: ");
                Console.WriteLine(" 1 - Triangulo \n 2- Retangulo \n 3- Quadrado \n \n Digite 0 a qualquer momento para Sair");
                Console.WriteLine("------------------------------------------------");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Triangulo();
                        break;
                    case 2:
                        Retangulo();
                        break;
                    case 3:
                        Quadrado();
                        break;
                    case 0:
                        EncerrarPrograma = false;
                        break;


                    default:EncerrarPrograma= true;
                        break;
                }
            } while (EncerrarPrograma != false);
        }
        public static void Triangulo()
        {
            Console.Clear();
            Triangulo triangulo = new Triangulo();
            Console.WriteLine(" Vamos calcular a area de um Triangulo \n Digite o valor da Base: ");
            triangulo.Base = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o valor da Altura: ");
            triangulo.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(" O valor total da area é: {0} ", triangulo.AreaDoTriangulo().ToString("F2"), CultureInfo.InvariantCulture);
            Espera();
        }
        public static void Retangulo()
        {
            Retangulo ret = new Retangulo();
            Retangulo retangulo = new Retangulo();
            Console.Clear();
            Console.WriteLine(" Você escolheu RETANGULO ! \n Digite o valor da Base do Retangulo: ");
            retangulo.Base = double.Parse(Console.ReadLine());
            Console.WriteLine(" Digite o valor da Altura do Retangulo: ");
            retangulo.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("\n Escolha a sua opção: ");
            Console.WriteLine(" 1 - Calcular a Area do Retangulo");
            Console.WriteLine(" 2 - Calcular o Perímetro do Retangulo");
            Console.WriteLine(" 3 - Calcular o Diagonal do Retangulo \n -------------------------------------------- ");
            Console.Write(" Digite sua escolha:  ");
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Valor da area é: {0}  m²", retangulo.AreaRetangulo().ToString("F2"), CultureInfo.InvariantCulture);
                    Espera();
                    break;
                case 2:
                    Console.WriteLine("Valor do perimetro é: {0} m²", retangulo.PerimetroRetangulo().ToString("F2"), CultureInfo.InvariantCulture);
                    Espera();
                    break;
                case 3:
                    Console.WriteLine("Valor da diagonal é: {0} m²", retangulo.DiagonalRetangulo().ToString("F2"), CultureInfo.InvariantCulture);
                    Espera();
                    break;
                case 0:
                    escolha = 0;
                    break;
                default:
                    Console.WriteLine("Escolha Incorreta !");
                    break;
            }
        }
        public static void Quadrado()
        {
            Quadrado quadrado = new Quadrado();
            Console.Clear();
            Console.WriteLine("Digite o valor do Lado: ");
            quadrado.Lado = double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha uma opção de calculo: \n 1- Area do Quadrado \n 2- Diagonal \n--------------------------------------");
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                   Console.WriteLine("O valor da area do quadrado é {0}m²", quadrado.AreaQuadrado().ToString("F2"), CultureInfo.InvariantCulture);
                    Espera();
                    break;
                case 2:
                    Console.WriteLine("O valor da Diagonal é {0}cm ", quadrado.Diagonal().ToString("F2"), CultureInfo.InvariantCulture);
                    Espera();
                    break;

                default:
                    break;
            }



        }

        public static void Espera()
        {
            System.Threading.Thread.Sleep(1500);
        }
    }
}
