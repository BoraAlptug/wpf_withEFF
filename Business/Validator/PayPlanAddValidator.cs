using OdemePlanı_11.Entities.UI;
using System.Windows;

namespace OdemePlanı_11.Business.Validator
{
    public class PayPlanAddValidator : IPayPlanAddValidator
    {
        public List<PayPlanDetailUI> PayPlanDetailValidator_vl(List<PayPlanDetailUI> payPlanDetailListUIs)
        {
            foreach(var item in payPlanDetailListUIs)
            {
                item.yuzde = item.yuzde.ToString().ToUpper();
                item.odemesekli=item.odemesekli.ToString().ToUpper();
            }
            return payPlanDetailListUIs;
        }

        public List<PayPlanAddUI> PayPlanUpperCase_vl(List<PayPlanAddUI> list)
        {
            foreach (var item in list)
            {
                foreach(var property in item.GetType().GetProperties())
                {
                    object value = property.GetValue(item);

                    if (value is string stringValue && !string.IsNullOrEmpty(stringValue))
                    {
                        // Değeri büyük harfe dönüştürerek yeniden atama
                        property.SetValue(item, stringValue.ToUpper());
                    }
                }
            }

            return list;
        }
    }
}
