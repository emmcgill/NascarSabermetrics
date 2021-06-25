using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Driver
    {   
        [Key]
        public int DriverId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string HomeTownCity { get; set; }

        [Required]
        public State HomeTownState { get; set; }

        public enum State
        {
            Alabama, Alaska, Arizona, Arkansas, California, Colorado, Connecticut, Delaware, Florida, Georgia,
            Hawaii, Idaho, Illinois, Indiana, Iowa, Kansas, Kentucky, Louisiana, Maine, Maryland,
            Massachusetts, Mexico, Michigan, Minnesota, Mississippi, Missouri, Montana, Nebraska, Nevada, NewHampshire,
            NewJersey, NewMexico, NewYork, NorthCarolina, NorthDakota, Ohio, Oklahoma, Oregon, Pennsylvania, RhodeIsland, 
            SouthCarolina, SouthDakota, Tennessee, Texas, Utah, Vermont, Virginia, Washington, WestVirginia, Wisconsin, Wyoming

        }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public int YearsExperience { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }

        public virtual Car CurrentCar { get; set; }


        // Top 5 ICollection
        // Top 10  ICollection
        // Wins ICollection
        // Championships ICollection
        // Final 4 Appearances ICollection
        //Sponsors

    }
}
