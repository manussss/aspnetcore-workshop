using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesCRUDRazor.models
{
    public class Filme
    {
        public int FilmeId { get; set; }
        
        [Display(Name = "Título")]
        [Required(ErrorMessage="Este campo é obrigatório.")]
        public string Titulo { get; set; }
        
        [Display(Name = "Data de Lançamento")]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage="Este campo é obrigatório.")]
        public DateTime DataLancamento { get; set; }
        
        [Display(Name = "Gênero")]
        [Required(ErrorMessage="Este campo é obrigatório.")]
        public string Genero { get; set; }
        
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage="Este campo é obrigatório.")]
        public decimal Preco {get; set;}

    }
}