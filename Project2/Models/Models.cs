using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    [Table("Missions")]
    public class Missions
    {
        [Key]
        public int MissionID { get; set; }

        [Required]
        public string MissionName { get; set; }

        [Required]
        public string MissionPresident { get; set; }

        [Required]
        public string MissionAddress { get; set; }

        [Required]
        public string MissionLanguage { get; set; }

        [Required]
        public string MissionClimate { get; set; }

        [Required]
        public string DominantReligion { get; set; }

        [Required]
        public string FlagSource { get; set; }
    }
}