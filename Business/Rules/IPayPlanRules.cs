using OdemePlanı_11.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_11.Business.Rules
{
    public interface IPayPlanRules
    {
        bool PayPlanDelete_rl();
        bool PayPlanPercent_rl(List<PayPlanAddUI> list);
    }
}
