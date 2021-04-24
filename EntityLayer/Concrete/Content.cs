using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int Id { get; set; }

        [StringLength(1000)]
        public string Value { get; set; }
        public DateTime Date { get; set; }

        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }

        public int? WritterId { get; set; }
        public virtual Writter Writter { get; set; }
    }
}
