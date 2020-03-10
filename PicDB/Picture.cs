using System;
using System.Collections.Generic;
using System.Text;

namespace PicDB
{
    public class Picture
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public Photographer Photographer { get; set; }
    }
}
