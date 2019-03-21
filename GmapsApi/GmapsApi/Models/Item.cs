using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GmapsApi.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public double Lng { get; set; }
        public double Lat { get; set; }
        public int Size { get; set; }
        public string Address { get; set; }

    }
}
