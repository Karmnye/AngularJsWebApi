using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

//using Shared;
using Shared;

namespace DataAccess
{
    public class DataManager
    {
        public List<ApprovalRequestModel> GetRequests()
        {
            List<ApprovalRequestModel> lstApprovalRequestModel = new List<ApprovalRequestModel>();
            lstApprovalRequestModel.Add(new ApprovalRequestModel { GrantNumber = "1DUI32432HKHNL3", RequestId= "001"});
            lstApprovalRequestModel.Add(new ApprovalRequestModel { GrantNumber = "2DUI32432HKHNL3", RequestId= "002"});
            return lstApprovalRequestModel;
        }
    }
}
