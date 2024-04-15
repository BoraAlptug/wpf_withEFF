using OdemePlanı_11.Business;
using OdemePlanı_11.Entities.UI;
using OdemePlanı_11.Presentation.ListOrganizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OdemePlanı_11.Presentation
{
    public class PayPlanPresentation : IPayPlanPresentatrion
    {
        IPayPlanGetList payPlanGetList;
        IPayPlanBusiness payPlanBusiness;

        public PayPlanPresentation()
        {
            payPlanGetList =new PayPlanGetList();
            payPlanBusiness =  new PayPlanBusiness();
        }

        public void EmptypayPlanDetailList_pr(DataGrid payPlanDetail_dgw)
        {
            payPlanBusiness.EmptyPayPlan_bs(payPlanDetail_dgw);
        }

        public void GetPayPlanPreviewList_pr(ListBox payPlanPreviewList_lstbox)
        {
            List<PayPlansListUI> list = payPlanBusiness.PayPlanPreviewList_bs();
            if(payPlanPreviewList_lstbox.Items.Count > 0) { payPlanPreviewList_lstbox.Items.Clear(); }
            payPlanGetList.PayPlanPreviewListLoad(list, payPlanPreviewList_lstbox);


        }

        public void LoadPayPlanDetail_pr(DataGrid payPlanDetail_dgw, string groupName)
        {
            var payPlanDetailList=payPlanBusiness.GetPayPlanDetailList_bs(groupName);
            payPlanDetail_dgw.ItemsSource = payPlanDetailList;
        }

        public void PayPlanAdd_pr(DataGrid payPlanDetail_dgw, string text, string UserName  )
        {
            List<PayPlanAddUI> list = payPlanGetList.GetPayPlanAdd_prList(payPlanDetail_dgw);
            payPlanBusiness.PayPlanAdd_bs(list,text, UserName);


        }

        public void PayPlanDelete_pr(string groupName, string userName)
        {
            payPlanBusiness.PayPlanDelete_bs(groupName, userName);
        }
    }
}
