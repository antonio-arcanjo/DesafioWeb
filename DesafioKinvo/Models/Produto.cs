using System;
using System.ComponentModel.DataAnnotations;

namespace DesafioKinvo.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Range(1, 10, ErrorMessage = "Valor Fora da Faixa")]
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }
        //adicionei o virtual
        public virtual Categoria Categoria { get; set; }
    }
}