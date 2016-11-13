using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DragUpload.Model
{
    public class ImgurConfig
    {
        public string Authorization { get; set; }


        public ImgurConfig()
        {
            Authorization = readImgurConfig();
        }

        private string readImgurConfig()
        {
            string path = string.Format(@"{0}\imgur.txt", Environment.CurrentDirectory);

            if (File.Exists(path))
            {
                string text = System.IO.File.ReadAllText(path);
                Dictionary<object, object> config = JsonConvert.DeserializeObject<Dictionary<object, object>>(text);

                return config["Authorization"].ToString();
            }
            else
            {
                MessageBox.Show("配置文件不存在！");
            }

            return null;
        }

    }
}
