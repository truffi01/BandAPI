using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BandAPI.Models
{
    public class BandForCreatingDto
    {
        //Dto Data transfer objects is just to retrieve data so we dont need the attributes in our Dto class

        public string Name { get; set; }
        //will be the concatinated property we return different from the class Band.cs. Change DateTime to string
        public DateTime Founded { get; set; }

        public string MainGenre { get; set; }
    }
}
