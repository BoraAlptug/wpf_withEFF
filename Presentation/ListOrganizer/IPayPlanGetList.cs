using OdemePlanı_11.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OdemePlanı_11.Presentation.ListOrganizer
{
    public interface IPayPlanGetList
    {
        List<PayPlanAddUI> GetPayPlanAdd_prList(DataGrid payPlanDetail_dgw);
        void PayPlanPreviewListLoad(List<PayPlansListUI> list, ListBox payPlanPreviewList_lstbox);
    }
}
