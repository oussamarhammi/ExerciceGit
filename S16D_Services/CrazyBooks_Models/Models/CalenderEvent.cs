using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
   public class CalenderEvent
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Event { get; set; }
        public string Commentaire { get; set; }

        [ForeignKey("Booking")]
        public int Booking_Id { get; set; }
        //Propriété de navigation 1 à plusieurs, côté 1
        public Booking Booking { get; set; }

    }

}
