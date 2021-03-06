﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DragUpload.Model
{
    public class ImgRecord
    {
        public int id { get; set; }

        public string name { get; set; }

        public string url { get; set; }

        public string deleteUrl { get; set; }


        public ImgType type { get; set; }
    }


    public enum ImgType
    {
        SMMS = 1,

        IMGUR = 2
    }

}
