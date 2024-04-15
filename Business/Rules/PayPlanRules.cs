using OdemePlanı_11.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OdemePlanı_11.Business.Rules
{
    public class PayPlanRules : IPayPlanRules
    {
        private readonly string userNumberWar = "Lütfen yüzde değerlerini sayı olarak giriniz.";
        private readonly string userPaymentMethod = "Lütfen ödeme şeklini giriniz.";
        private readonly string PaymentPercentLimit = "Toplam yüzde değeri 100' ü aşamaz";
        private readonly string PayPercentSumLimit = "Tüm ödemelerin toplamı %100 olmalı";
        private readonly string ConfirmTheUserForDelete = "Plan silmek istediğinize emin misiniz?";

        public bool PayPlanDelete_rl()
        {
            var reslut = MessageBox.Show(ConfirmTheUserForDelete, "Uyarı", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (reslut == MessageBoxResult.No) { return true; }

            return false;

        }

        public bool PayPlanPercent_rl(List<PayPlanAddUI> list)
        {
            double number, sumNumber = 0; ;
            foreach (var item in list)
            {

                if (!double.TryParse(item.yuzde, out number))
                {
                    MessageBox.Show(userNumberWar, "Uyarı", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return true;
                }
                sumNumber = number + sumNumber;


                if (item.odemesekli == null)
                {
                    MessageBox.Show(userPaymentMethod, "Uyarı", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return true;
                }
            }

            foreach (var item in list)
            {
                if (sumNumber > 100)
                {
                    {
                        MessageBox.Show(PaymentPercentLimit, "Uyarı", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return true;
                    }
                }
                if (sumNumber != 100)
                {
                    {
                        MessageBox.Show(PayPercentSumLimit, "Uyarı", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return true;
                    }
                }
            }



            return false;
        }
    }
}
