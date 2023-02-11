using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace CadastroDeUsuário.Models
{
    [Table("Usuario")]
    public class Usuário
    {
        [Display(Name ="Código")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome { get; set; }

        [Display(Name = "E-Mail")]
        [Column("E-Mail")]
        public string Email { get; set; }

        [Display(Name = "Endereco")]
        [Column("Endereco")]
        public string Endereco { get; set; }

        [Display(Name = "Cidade")]
        [Column("Cidade")]
        public string Cidade { get; set; }

        public Usuário(int id, string nome, string email, string endereco, string cidade)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Endereco = endereco;
            Cidade = cidade;
        }
    }
}
