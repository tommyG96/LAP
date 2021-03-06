using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class MovieDetailsModel
    {
        public int pre_ID { get; set; }
        public string Genre { get; set; }
        public string Titel { get; set; }
        public DateTime Jahr { get; set; }
        public string Regie { get; set; }
    }
}
