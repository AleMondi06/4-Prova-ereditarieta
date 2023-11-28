using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _4____Prova_ereditarietà
{
    class Quadrato
    {
        protected double _lato;
        public Quadrato(double lato)
        {
            this._lato = lato;
        }
        public void perimetro()
        {
            Console.WriteLine("Il perimetro è di: " + _lato * 4);
        }
        public void area()
        {
            Console.WriteLine("L'area è di: " + _lato * _lato);
        }
    }
    class Cubo : Quadrato
    {
        public Cubo(double lato) : base(lato)
        {
            _lato = lato;
        }
        public void superficie()
        {
            Console.WriteLine("La superficie è di: " + _lato * _lato * 6);
        }
        public void volume()
        {
            Console.WriteLine("Il volume è di: " + _lato * _lato * _lato);
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci la lunghezza del lato");
            double latoo = double.Parse(Console.ReadLine());
            Quadrato quadrato = new Quadrato(latoo);
            Cubo cubo = new Cubo(latoo);
            quadrato.perimetro();
            quadrato.area();
            cubo.superficie();
            cubo.volume();

        }
    }
}
