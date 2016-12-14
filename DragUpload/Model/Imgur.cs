using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragUpload.Model
{
    public class Imgur
    {
        public ImgurData data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }
    }

    public class ImgurData
    {
        public string id { get; set; }
        public long datetime { get; set; }
        public string link { get; set; }

        public string deletehash { get; set; }
    }
}
