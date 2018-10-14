using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSyncManager.Constants
{
    public class DBConstants
    {
        public static string procAddArticle = "procAddArticle";
        public static string procAddImages = "procAddImages";
        public static string procAddPage = "procAddPage";

        public static string ConnString = ConfigurationManager.ConnectionStrings["ProjectsSyncManager"].ConnectionString;
    }
}
