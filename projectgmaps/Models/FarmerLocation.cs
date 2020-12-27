using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectgmaps.Models
{
    public class FarmerLocation
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Address { get; set; }
        public bool IsFlagged { get; set; }



    }
}
