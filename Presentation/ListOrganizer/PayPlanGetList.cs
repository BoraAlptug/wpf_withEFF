using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OdemePlanı_11.Entities.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OdemePlanı_11.Presentation.ListOrganizer
{
    public class PayPlanGetList : IPayPlanGetList
    {
        public List<PayPlanAddUI> GetPayPlanAdd_prList(DataGrid payPlanDetail_dgw)
        {
            List<PayPlanAddUI> payPlanAddUIs = new List<PayPlanAddUI>();

            
            foreach (var row in payPlanDetail_dgw.ItemsSource)
            {
                var item=row as PayPlanAddUI;
                payPlanAddUIs.Add(new PayPlanAddUI
                {
                    odemesekli=item.odemesekli,
                    yuzde=item.yuzde,
                });
            }

            return payPlanAddUIs;
        }

        public void PayPlanPreviewListLoad(List<PayPlansListUI> list, ListBox payPlanPreviewList_lstbox)
        {
            foreach (var item in list)
            {
                payPlanPreviewList_lstbox.Items.Add(item.GroupName);
            }
        }
    }
}
