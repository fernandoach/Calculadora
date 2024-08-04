namespace Calculadora
{
    internal class CalculadoraClass
    {
        public CalculadoraClass() { }

        private float numeroA { get; set; }
        private float numeroB { get; set; }


        private void setNumeros()
        {
            try
            {
                Console.Write("Numero A: ");
                var inpNumeroA = Console.ReadLine();
                float auxNumeroA;
                if (!float.TryParse(inpNumeroA, out auxNumeroA))
                {
                    throw new Exception("Solo puede ingresar números...");
                }
                this.numeroA = auxNumeroA;

                Console.Write("Numero B: ");
                var inpNumeroB = Console.ReadLine();
                float auxNumeroB;
                if (!float.TryParse(inpNumeroB, out auxNumeroB))
                {
                    throw new Exception("Solo puede ingresar números...");
                }
                this.numeroB = auxNumeroB;

                Console.WriteLine($"Numeros ingresados: {this.numeroA}, {this.numeroB}");
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }

        public void Suma()
        {
            try
            {
                this.setNumeros();
                Console.WriteLine($"Suma: {(this.numeroA + this.numeroB)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Resta()
        {
            try
            {
                this.setNumeros();
                Console.WriteLine($"Resta: {(this.numeroA - this.numeroB)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Multiplicacion()
        {
            try
            {
                this.setNumeros();
                Console.WriteLine($"Multiplicación: {(this.numeroA * this.numeroB)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Divicion()
        {
            try
            {
                this.setNumeros();
                if (this.numeroB == 0) throw new Exception("No existe la divición entre 0.");
                Console.WriteLine($"División: {(this.numeroA / this.numeroB)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Potencia()
        {
            try
            {
                this.setNumeros();
                if (this.numeroB < 0) throw new Exception("El exponente no puede ser negativo.");
                Console.WriteLine($"Potencia: {(Math.Pow(this.numeroA, this.numeroB))}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Raiz()
        {
            try
            {
                this.setNumeros();
                if (this.numeroB == 0) throw new Exception("El radical no puede ser 0.");
                else if (this.numeroA < 0) throw new Exception("El radicando no puede ser negativo.");
                Console.WriteLine($"Raíz: {(Math.Pow(this.numeroA, 1 / this.numeroB))}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
