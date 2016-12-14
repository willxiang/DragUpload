using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragUpload.Model
{
    public class Picture
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public byte[] Bytes { get; set; }

        public SmmsData smms { get; set; }
        public Imgur imgur { get; set; }
    }
}
