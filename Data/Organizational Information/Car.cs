using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }

        [Required]
        public int CarNumber { get; set; }

        [ForeignKey("Organization")]
        public int OrganizationId { get; set; }

        [Required]
        public virtual Organization CarOrganization { get; set; }


        [ForeignKey("Driver")]
        public int DriverId { get; set; }

        [Required]
        public Driver Driver { get; set; }

        //Wins
        //Top 5 Finishes
        //Top 10 Finishes
        //Sponsors




    }
}
