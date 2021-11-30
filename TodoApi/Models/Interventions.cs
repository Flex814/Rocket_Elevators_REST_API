using System;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public partial class Interventions
    {
        public long id { get; set; }
        public string employee_id { get; set; }
        public string battery_id { get; set; }
        public string column_id { get; set; }
        public string elevator_id { get; set; }
        public DateTime intervention_start_time { get; set; }
        public DateTime intervention_end_time { get; set; }
        public string result { get; set; }
        public string report { get; set; }
        public string status { get; set; }
    }
}