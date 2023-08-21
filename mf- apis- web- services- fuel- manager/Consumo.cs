using mf__apis__web__services__fuel__manager.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf__apis__web__services__fuel__manager
{
    [Table("Consumos")]

    public class Consumo
    {
        [Key]

        public int Id { get; set; }
        [Required]

        public string Descricao { get; set; }
        [Required]

        public DateTime Data { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]

        public decimal Valor { get; set; }
        [Required]

        public TipoCombustivel Tipo { get; set; }
        
        
        [Required]

        public int VeiculoId { get; set; }


        public Veiculo Veiculo { get; set; }
    }

    public enum TipoCombustivel 
    { 
        Diesel,
        Etanol,
        Gasolina
    }
}
