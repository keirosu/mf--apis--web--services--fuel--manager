using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf__apis__web__services__fuel__manager.Models
{
    [Table("Veiculos")]
    
    public class Veiculo
    {
        [Key]

        public int id { get; set; }
        [Required]

        public string Marca { get; set; }
        [Required]

        public string Modelo { get; set; }
        [Required]

        public string Placa { get; set; }
        [Required]

        public int AnoFabricacao { get; set; }
        [Required]

        public int AnoModelo { get; set; }

        public ICollection<Consumo> Consumos { get; set; }

    }
}
