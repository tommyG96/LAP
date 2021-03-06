using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class MovieModel
    {
        public int mov_Id { get; set; }
        public string mov_title_1 { get; set; }
        public string mov_title_2 { get; set; }
        public DateTime Mov_premiere{ get; set; }
        public int Gen_Id { get; set; }
    }
}
