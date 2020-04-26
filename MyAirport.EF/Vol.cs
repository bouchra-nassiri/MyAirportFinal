using System;
using System.Collections.Generic;

namespace MyAirport.EF
{
    public class Vol
    {
        public int VolId { get; set; }
        public string Cie { get; set; }
        public int Jex { get; set; }
        public int? Pax { get; set; }
        public string Lig { get; set; }
        public string? Pkg { get; set; }
        public string? Des { get; set; }
        public string? Imm { get; set; }
        public DateTime? Dhc { get; set; }

        public Vol()
        {
        }

        public IEnumerable<Bagage> Bagages { get; set; } 


    }
}
