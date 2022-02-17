using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminBook.Data.Entities
{
    public class RegisterClient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [ForeignKey("Discount")]
        public int DiscountId { get; set; }
        public virtual Discount Discount { get; set; }

    }
}
