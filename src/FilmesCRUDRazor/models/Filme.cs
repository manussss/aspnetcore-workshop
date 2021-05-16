using System;

namespace FilmesCRUDRazor.models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        public int Titulo { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
        public decimal Preco {get; set;}

    }
}