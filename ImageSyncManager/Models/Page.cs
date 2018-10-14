using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSyncManager.Models
{
    public class Page
    {
        public int PageID { get; set; }
        public string PageName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate{get;set;}
    }
}
