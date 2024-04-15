using OdemePlanı_11.Entities.Db;
using OdemePlanı_11.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OdemePlanı_11.Business
{
    public interface IPayPlanBusiness
    {
        void EmptyPayPlan_bs(DataGrid payPlanDetail_dgw);
        List<PayPlanDetailUI> GetPayPlanDetailList_bs(string groupName);
        void PayPlanAdd_bs(List<PayPlanAddUI> list, string text,string UserName);
        void PayPlanDelete_bs(string groupName, string userName);
        List<PayPlansListUI> PayPlanPreviewList_bs();
    }
}
