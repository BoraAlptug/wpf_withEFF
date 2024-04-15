using OdemePlanı_11.Entities.Db;
using OdemePlanı_11.Entities.Table;
using OdemePlanı_11.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_11.Business.Mapper
{
    public interface IPayPlanMapper
    {
        List<musteriteklifleriozet_odemesekli> PayPlanAdd_mp(List<PayPlanAddUI> newList, string text,string UserName, int ozetBimno);
        PayPlanDeleteDb PayPlanDelete_mp(string groupName, string userName);
        List<PayPlanDetailUI> PayPlanDetail_mp(List<PayPlanDetailDb> payPlanDetailList);
    }
}
