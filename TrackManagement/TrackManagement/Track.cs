using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackManagement
{
    public class Track
    {
        public int TrackId { get; set; }
        public string TrackName { get; set; }
        public DateTime TrackDuration { get; set; }
        public string TrackLead { get; set; }
        public int NumberOfCampusMinds { get; set; }

        public Track(int id, string name, DateTime duration, string lead, int count)
        {
            this.TrackId = id;
            this.TrackName = name;
            this.TrackDuration = duration;
            this.TrackLead = lead;
            this.NumberOfCampusMinds = count;
        }

        public Track()
        {
        }
    }
}
