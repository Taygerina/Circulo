using System;
using System.Globalization;


namespace circulo
{
    class circulo
    {
        static void Main(string[] args)
        {
            // declrando a classe
            Calculadora calc = new Calculadora();

            // interaçao com usuario
            Console.WriteLine("Entre com o valor do raio: ");
            // montando o calculo
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circuferencia(raio);
            double volume = calc.Volume(raio);

            // mostra o resultado
            Console.WriteLine("Circuferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
