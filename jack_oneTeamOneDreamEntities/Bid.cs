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
    public class Bid 
    {

        [Required]
        public int Id { get; set; }

        [Required,Index]
        public Product Product { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, Min(0)]
        public Decimal Amount { get; set; }

        [Required,EmailAddress]
        public string Email { get; set; }
    }
}
