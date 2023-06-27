using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest.Models
{
    [Table("Services")] // атрибуты
    internal class Service
    {
        [Key, Column("id_service")]
        public int IdService { get; set; }

        [Required, Column("name")]
        public string Name { get; set; }

        [Required, Column("description")]
        public string Description { get; set; }

        public ICollection<Deal> Deals { get; set; }
    }
}
