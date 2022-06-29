using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBooks_Models.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Event { get; set; }
        public string Commentaire { get; set; }

<<<<<<< HEAD

        public ICollection<CalenderEvent> CalenderEvent { get; set; }
=======
        public CalenderEvent CalenderEvent_Id { get; set; }
        public CalenderEvent CalenderEvent { get; set; }
>>>>>>> KPL_BOOKING
    }
}
