using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OdemePlanı_11.Presentation
{
    public interface IPayPlanPresentatrion
    {
        void EmptypayPlanDetailList_pr(DataGrid payPlanDetail_dgw);
        void GetPayPlanPreviewList_pr(ListBox payPlanPreviewList_lstbox);
        void LoadPayPlanDetail_pr(DataGrid payPlanDetail_dgw, string groupName);
        void PayPlanAdd_pr(DataGrid payPlanDetail_dgw, string text,string UserName);
        void PayPlanDelete_pr(string groupName, string userName);
    }
}
