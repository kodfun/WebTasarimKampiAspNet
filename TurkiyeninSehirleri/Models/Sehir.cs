using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TurkiyeninSehirleri.Models
{
    public class Sehir
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Identity özelliğini kapattık
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Ad { get; set; }
    }
}
