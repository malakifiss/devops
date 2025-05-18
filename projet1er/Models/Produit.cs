using System.ComponentModel.DataAnnotations;

namespace controle.Models
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }

        [MaxLength(10)]
        public string marque { get; set; }

        public string specialite { get; set; }
        public string type { get; set; }


    }
}
