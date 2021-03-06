using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class MovieEditModel
    {
        public int mov_Id { get; set; }
        public string mov_title_1 { get; set; }
        public string mov_title_2 { get; set; }
        public DateTime mov_premiere{ get; set; }
        public int gen_Id { get; set; }

    }
}
