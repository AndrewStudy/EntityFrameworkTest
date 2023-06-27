using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkTest.Models
{
    [Table("Clients")]
    internal class Client
    {
        [Key, Column("id_client")]
        public int IdClient { get; set; }

        [Required, Column("full_name")]
        public string FullName { get; set; }

        [Required, Column("kind_activity")]
        public string KindActivity { get; set; }

        [Required, Column("adress")]
        public string Adress { get; set; }

        [Required, Column("phone")]
        public string Phone { get; set; }

        public ICollection<Deal> Deals { get; set;}

    }
}
