using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentPlanner.Models
{
    public class Meeting
    {
        public int MeetingID { get; set; }

        [DataType(DataType.Date)]
        public DateTime MeetingDate { get; set; }
        public string ConductingLeader { get; set; }
        public string OpeningSong { get; set; }
        public string SacramentSong { get; set; }
        public string ClosingSong { get; set; }

        public string IntermediateSong { get; set; }

        public string OpeningPrayer { get; set; }
        public string ClosingPrayer { get; set; }

        public ICollection<Speaker> Speakers { get; set; }
    }
}
