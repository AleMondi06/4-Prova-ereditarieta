using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Prova_ereditarietà
{
    using System;

    class Quadrato
    {
        private double lato;

        public Quadrato(double lato)
        {
            this.lato = lato;
            Console.WriteLine($"Creato un quadrato con lato {this.lato}");
        }

        public double GetLato()
        {
            return this.lato;
        }

        public void SetLato(double lato)
        {
            this.lato = lato;
        }

        public double CalcolaArea()
        {
            return Math.Pow(this.lato, 2);
        }

        public double CalcolaPerimetro()
        {
            return 4 * this.lato;
        }
    }

    class Cubo : Quadrato
    {
        public Cubo(double lato) : base(lato)
        {
            Console.WriteLine($"Creato un cubo con lato {this.GetLato()}");
        }

        public double CalcolaSuperficieTotale()
        {
            return 6 * this.CalcolaArea();
        }

        public double CalcolaVolume()
        {
            return Math.Pow(this.GetLato(), 3);
        }
    }

    class Program
    {
        static void Main()
        {
            // Esempio di utilizzo delle classi
            Quadrato quadrato1 = new Quadrato(5);
            Console.WriteLine($"Area del quadrato: {quadrato1.CalcolaArea()}");

            Cubo cubo1 = new Cubo(3);
            Console.WriteLine($"Superficie totale del cubo: {cubo1.CalcolaSuperficieTotale()}");
            Console.WriteLine($"Volume del cubo: {cubo1.CalcolaVolume()}");
        }
    }

}
