using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Organization
    {
        [Key]
        public int OrganizationId { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string PrimaryOwner { get; set; }
        public string SecondOwner { get; set; }
        public string ThirdOwner { get; set; }

        [Required]
        public string HeadquartersCity { get; set; }

        [Required]
        public State HeadquartersState { get; set; }

        public enum State
        {
            Alabama, Alaska, Arizona, Arkansas, California, Colorado, Connecticut, Delaware, Florida, Georgia,
            Hawaii, Idaho, Illinois, Indiana, Iowa, Kansas, Kentucky, Louisiana, Maine, Maryland,
            Massachusetts, Michigan, Minnesota, Mississippi, Missouri, Montana, Nebraska, Nevada, NewHampshire,
            NewJersey, NewMexico, NewYork, NorthCarolina, NorthDakota, Ohio, Oklahoma, Oregon, Pennsylvania, RhodeIsland,
            SouthCarolina, SouthDakota, Tennessee, Texas, Utah, Vermont, Virginia, Washington, WestVirginia, Wisconsin, Wyoming

        }

        [Required]
        public DateTime DateEstablished { get; set; }

        [Required]
        public Manufacturer CarManufacturer { get; set; }

        public enum Manufacturer
        {
            Chevrolet,
            Ford,
            Toyota
        }

        public ICollection<Car> CarsOwned { get; set; }

        public ICollection<Driver> DriversEmployed { get; set; }

        //Wins
        //Top 5s
        //Top 10s



    }
}
