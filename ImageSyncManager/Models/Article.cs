using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSyncManager.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleDescription { get; set; }
        public Page PageObj { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
