using OdemePlanı_11.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_11.Business.Validator
{
    public interface IPayPlanAddValidator
    {
        List<PayPlanDetailUI> PayPlanDetailValidator_vl(List<PayPlanDetailUI> payPlanDetailListUIs);
        List<PayPlanAddUI> PayPlanUpperCase_vl(List<PayPlanAddUI> list);
    }
}
