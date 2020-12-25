using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BZoom.Api.Models
{
    public class Survey
    {
        public int SurveyId { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
