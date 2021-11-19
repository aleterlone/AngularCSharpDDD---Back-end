using System;
using System.ComponentModel.DataAnnotations;

namespace AngularCSharpDDD.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(50)]
        public string Sobrenome { get; set; }

        [MaxLength(200)]
        public string Email { get; set; }

        public DateTime DataNascimento { get; set; }
        public virtual Escolaridade Escolaridade { get; set; }
    }
}
