using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace jack_oneTeamOneDreamEntities
{
    public class Product
    {
        public Product()
        {
            
        }
        public Product(string name,string Description,decimal minBid)
        {
            this.Name = name;
            this.Description = Description;
            this.MinBid = minBid;
        }
        [Required]
        [Editable(false)]
        public int Id { get; set; }
        
        [Index(IsUnique = true)]
        [MaxLength(50)]
        [Required]
        public string Name {get; set;}

        [MaxLength(250)]
        public string Description { get; set; }

        [Min(0)]
        public decimal? MinBid { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ExpiryDate { get; set; }

        public ProductImage Image { get; set; }



    }
}
