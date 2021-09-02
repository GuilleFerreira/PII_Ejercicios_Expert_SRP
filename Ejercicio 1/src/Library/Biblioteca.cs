using System;

namespace SRP   
{
    public class Biblioteca
    {
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public void AlmacenarLibro(Libro libro,String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
            Console.WriteLine($"{libro} almacenado en {sector} {estante}");
        }


    }


}