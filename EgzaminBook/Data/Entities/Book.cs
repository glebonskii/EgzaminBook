using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminBook.Data.Entities
{
    public class Book : BaseModel
    {
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Input name book")]
        public string Name { get; set; }    
        [ForeignKey("Authors")]
        public int AuthorsId { get; set; }
        public virtual Authors Authors { get; set; }
        [ForeignKey("NameProdaction")]
        public int NameProdactionId { get; set; }
        public virtual NameProdaction NameProdaction { get; set; }
        [Required(ErrorMessage ="Input number of pages")]
        public int  NumberOfPages { get; set; }
        [ForeignKey("Genre")]
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        [Required(ErrorMessage ="Input year of publishing")]
        public int YearOfPublishing { get; set; }
        [Required(ErrorMessage ="Input cost")]
        public decimal Cost { get; set; }
        [Required(ErrorMessage ="Input price of sale")]
        public decimal PriceOfSale { get; set; }
        [Required(ErrorMessage ="Input whether the book is a sequel: yes or no")]
        [StringLength(3)]
        public string WhetherTheBookIsASequel { get; set; }
        [Required(ErrorMessage ="Input reservation")]
        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }        
        public virtual Reservation Reservation { get; set; }
        
        [Required(ErrorMessage ="Input novetly: yes or no")]
        [StringLength(3)]
        public string Novetly { get; set; }
        [ForeignKey("Sale")]
        public int? SaleId { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
