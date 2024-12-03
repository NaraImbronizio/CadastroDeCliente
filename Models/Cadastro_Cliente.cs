using System.ComponentModel.DataAnnotations;

namespace CadastroDeCliente.Models
{
    public class Cadastro_Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime? DataNascimento { get; set; }

        [MaxLength(1)]
        public string Sexo { get; set; } // "M" ou "F"

        // Endereço completo (atributo composto)
        [Required]
        [MaxLength(200)]
        public string Logradouro { get; set; }

        [Required]
        public int Numero { get; set; }

        [MaxLength(50)]
        public string Complemento { get; set; }

        [Required]
        [MaxLength(100)]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(2)]
        public string Estado { get; set; }

        [Required]
        [MaxLength(10)]
        public string CEP { get; set; }

        [MaxLength(255)]
        public string Foto { get; set; } // Caminho ou armazenamento da imagem
    }
}
