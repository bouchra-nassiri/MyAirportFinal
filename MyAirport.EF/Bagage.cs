using System;
namespace MyAirport.EF
{
    public class Bagage
    {

        public int BagageID { get; set; }
        public int? VolID { get; set; }
        public string CodeIata { get; set; }
        public string? Classe { get; set; }
        public string? Sta { get; set; }
        public string? Ssur { get; set; }
        public string? Destination { get; set; }
        public string? Escale { get; set; }
        public bool? Prioritaire { get; set; }
        public DateTime DateCreation { get; set; }
        public Vol Vol { get; set; }

        public Bagage()
        {
        }
    }
}
