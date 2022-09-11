using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Kayit
    {
        public int KayitId { get; set; }
        [Required]
        public string AdiSoyadi { get; set; }
        [Required]
        public string Grubu { get; set; }
        [Required]
        public string Telefon { get; set; }
        public DateTime Tarih { get; set; }

    }
}
