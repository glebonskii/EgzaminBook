using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminBook.Data.Entities
{
    public class Reservation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        //public int Id { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public ICollection<Book> Books { get; set; }
        //public virtual Book Books { get; set; }
        public int CountBook { get; set; }
    }
}
