using System;

namespace Calculadora
{
    internal class MenuClass
    {
        private CalculadoraClass calculadora = new CalculadoraClass();
        public MenuClass() { }

        public int InpOption()
        {
            try
            {
                Console.WriteLine("MENU");
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. SUMA");
                Console.WriteLine("2. RESTA");
                Console.WriteLine("3. MULTIPLICACIÓN");
                Console.WriteLine("4. DIVISIÓN");
                Console.WriteLine("5. POTENCIA");
                Console.WriteLine("6. RAIZ");
                Console.WriteLine("7. SALIR");
                Console.WriteLine("-----------------------");
                Console.Write("Ingresa una opcion: ");
                var optionInput = Console.ReadLine();

                int option = Int32.Parse(optionInput ?? "0");
                return option;
            }
            catch
            {
                return 0;
            }

        }

        public void SelectOption(int opc)
        {
            switch (opc)
            {
                case 1:
                    this.calculadora.Suma();
                    break;
                case 2:
                    this.calculadora.Resta();
                    break;
                case 3:
                    this.calculadora.Multiplicacion();
                    break;
                case 4:
                    this.calculadora.Divicion();
                    break;
                case 5:
                    this.calculadora.Potencia();
                    break;
                case 6:
                    this.calculadora.Raiz();
                    break;
                default:
                    Console.WriteLine("Opción no valida.");
                    break;
            }

            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
