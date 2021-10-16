using System.ComponentModel.DataAnnotations;

namespace DesafioKinvo.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatorio")]
        public string Descricao { get; set; }

        // public List<Produto> Produtos { get; set; }

    }
}
