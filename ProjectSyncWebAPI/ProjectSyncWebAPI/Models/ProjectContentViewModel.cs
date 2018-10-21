using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace ProjectSyncWebAPI.Models
{
    public class ProjectContentViewModel
    {
        public ArticleViewModel Article { get; set; }
        public List<ImageViewModel> Images { get; set; }
    }

    public class ArticleViewModel
    {
        public int ArticleID { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleDescription { get; set; }
    }

    public class ImageViewModel
    {
        public int ImageID { get; set; }
        public string ImageName { get; set; }
        //public byte[] Photo { get; set; }
        public Image Photo { get; set; }
    }
}