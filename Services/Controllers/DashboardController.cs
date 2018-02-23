using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
//using System.Web.Script.Serialization;
using System.Web.SessionState;

//using Controller;
//using Shared;
using Shared;
using DataAccess;
namespace Services.Controllers
{
    public class DashboardController : ApiController
    {

        [HttpGet]
        public List<ApprovalRequestModel> GetRequests()
        {
            DataManager oDataManager = new DataManager();
            List<ApprovalRequestModel> lstApprovalRequestModel = oDataManager.GetRequests();
            return lstApprovalRequestModel;
        }

    }
}