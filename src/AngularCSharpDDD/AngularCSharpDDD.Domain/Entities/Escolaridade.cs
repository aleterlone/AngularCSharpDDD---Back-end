using System.ComponentModel.DataAnnotations;

namespace AngularCSharpDDD.Domain.Entities
{
    public class Escolaridade
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }
    }
}
