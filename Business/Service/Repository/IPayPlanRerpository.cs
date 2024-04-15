using OdemePlanı_11.Entities.Db;
using OdemePlanı_11.Entities.Table;
using OdemePlanı_11.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_11.Business.Service.Repository
{
    public interface IPayPlanRerpository
    {
        int GetLastOzetBimno();
        List<PayPlanDetailDb> GetPayPlanDetail_rp(string groupName);
        List<PayPlansListUI> GetPayPlanPreviewList_rp();
        void PayPlanAdd_rp(List<musteriteklifleriozet_odemesekli> addList);
        void PayPlanDelete_rp(PayPlanDeleteDb payPlanDeleteDb);
    }
}
