using System;

namespace Aula18Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador cr7 = new Jogador();
            cr7.Nome = "Edwin van der Sar";
            cr7.Posicao = "Goleiro";
            cr7.Nascimento = DateTime.Parse("29/08/1970");            

            cr7.MostrarDados();
            Console.WriteLine("A idade corresponde a: "+ cr7.CalcularIdade() );
            Console.WriteLine( cr7.CalcularAposentadoria() );

        }
    }
}