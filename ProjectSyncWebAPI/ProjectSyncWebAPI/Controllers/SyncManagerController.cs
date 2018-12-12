using ProjectSyncWebAPI.Models;
using ProjectSyncWebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProjectSyncWebAPI.Controllers
{
    
    public class SyncManagerController : ApiController
    {
        SyncManagerRepository repo = new SyncManagerRepository();

        [HttpGet]
        [Route("api/GetPages")]
        public List<PageViewModel> GetPages()
        {
            return repo.GetPages();
        }

        [HttpGet]
        [Route("api/GetPages/pageId")]
        public async Task<ProjectContentViewModel> GetPageContent(int pageId)
        {
            return await repo.GetPageContent(pageId);
        }

        [HttpGet]
        [Route("api/GetImages/pageId")]
        public async Task<List<Image>> GetImages(int pageId)
        {
            return await repo.GetImagesTest(pageId);
        }
    }
}
