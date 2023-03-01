using System.ComponentModel.DataAnnotations;

namespace CinemaAPI.Models
{
    public class Cinema
    {
        [Key, Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EnderecoId { get; set; } // Faz com que seja obrigatório passar um Endereco
        public virtual Endereco Endereco { get; set; }
        
    }
}
