using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeamApp.Models
{
    public class Player
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public int Number { get; set; }

        public string Position { get; set; }

        public string College { get; set; }

        public int Weight { get; set; }

        public int HeightFt { get; set; }

        public int HeightInches { get; set; }

        [DisplayName("Height")]
        public string PlayerHeight
        {
            get
            {
                return HeightFt + "'" + HeightInches;
            }
        }

        [DisplayName("Years Active")]
        public int YearsActive { get; set; }

        [DisplayName("Birthday")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

    }
}
