using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkTest.Models
{
    [Table("Deals")]
    internal class Deal
    {
        [Key, Column("id_deal")]
        public int Id { get; set; }

        // код конвенция
        [ForeignKey(nameof(Client)), Column("id_client")]
        public int IdClient { get; set; }
        public Client Client { get; set; }

        [ForeignKey(nameof(Service)), Column("id_service")]
        public int IdService { get; set; }
        public Service Service { get; set; } // навигационное свойство

        [Required, Column("sum")]
        public string Sum { get; set; }

        [Required, Column("commission")]
        public string Commission { get; set; }

        [Required, Column("description")]
        public string Description { get; set; }


    }
}
