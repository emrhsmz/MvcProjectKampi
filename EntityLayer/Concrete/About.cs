using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        public string FirstDetails { get; set; }

        [StringLength(1000)]
        public string LastDetails { get; set; }

        [StringLength(100)]
        public string FirstImagePath { get; set; }

        [StringLength(100)]
        public string LastImagePath { get; set; }
    }
}
