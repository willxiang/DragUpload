using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragUpload.Model
{
    public class SMMS
    {
        public string code { get; set; }

        public SmmsData data { get; set; }
    }

    public class SmmsData
    {
        public int width { get; set; }
        public int height { get; set; }
        public string filename { get; set; }

        public string storename { get; set; }

        public int size { get; set; }

        public string path { get; set; }

        public string hash { get; set; }

        public long timestamp { get; set; }

        public string ip { get; set; }

        public string url { get; set; }

        public string delete { get; set; }
    }
}
