using ProjectSyncWebAPI.Models;
using ProjectSyncWebAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    }
}
