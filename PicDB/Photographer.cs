using System;
using System.Collections.Generic;
using System.Text;

namespace PicDB
{
    public class Photographer
    {
        public int ID { get; private set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthday { get; set; }
        public List<Picture> Pictures { get; }

    }
}
