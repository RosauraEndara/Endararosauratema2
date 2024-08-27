using System.ComponentModel.Design;

namespace ejercico02.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura, radio = 0;
            int interacion = 0;
            double mayorVolumen = 0;
            double sumaSuperficie = 0;
            int cilindros = 0;

            do
            {
                Console.Write("ingrese la altura del cilindro: ");
                if (int.TryParse(Console.ReadLine(), out altura) && altura > 0)
                {
                    break;
                }
                Console.WriteLine("altura mal ingrsada");
            }
            while (true);
            do
            {
                Console.Write("ingrese el radio del cilindro: ");
                if (int.TryParse(Console.ReadLine(), out radio) && radio > 0)
                {
                    break;
                }
                Console.WriteLine("radio mal ingrsado");
            }
            while (true);
            {
                var volumen = Math.PI * Math.Pow(radio, 2) * altura;
                var superficie = 2 * Math.PI * Math.Pow(radio, 2) + 2 * Math.PI * radio * altura;
                Console.WriteLine($"volumen del cilindro: {volumen}");
                Console.WriteLine($"superficie del cilindro: {superficie}");


            }
           
            
             

        }
    }
}
