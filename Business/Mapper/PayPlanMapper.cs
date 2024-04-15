using AutoMapper;
using OdemePlanı_11.Entities.Db;
using OdemePlanı_11.Entities.Table;
using OdemePlanı_11.Entities.UI;

namespace OdemePlanı_11.Business.Mapper
{
    public class PayPlanMapper : IPayPlanMapper
    {
        private readonly string activeDb = "A";
        private readonly string passiveDb = "P";
        private readonly string companyCode = "RAFEX";
        public List<musteriteklifleriozet_odemesekli> PayPlanAdd_mp(List<PayPlanAddUI> newList, string text, string UserName,int ozetBimno)
        {
            List<musteriteklifleriozet_odemesekli> addList= new List<musteriteklifleriozet_odemesekli>();
            foreach (var item in newList)
            {
                var payPlanAddDb = new musteriteklifleriozet_odemesekli
                {
                    aktifpasif = activeDb,
                    kaydeden = UserName,
                    bilgisayaradi_k = Environment.MachineName,
                    kayittarihi_d = DateTime.Now,
                    odemesekli = item.odemesekli,
                    grupadi=text,
                    ozet_bimno = ozetBimno,
                    yuzde = item.yuzde,
                    sirketkodu = companyCode
                };

                addList.Add(payPlanAddDb);
            }
            return addList;
        }

        public PayPlanDeleteDb PayPlanDelete_mp(string groupName, string userName)
        {
            PayPlanDeleteDb payPlanDeleteDb = new PayPlanDeleteDb();
            payPlanDeleteDb.aktifpasif = passiveDb;
            payPlanDeleteDb.iptaleden=userName;
            payPlanDeleteDb.iptaltarihi_d=DateTime.Now;
            payPlanDeleteDb.bilgisayaradi_i = Environment.MachineName;
            payPlanDeleteDb.grupadi=groupName;

            return payPlanDeleteDb;
        }

        public List<PayPlanDetailUI> PayPlanDetail_mp(List<PayPlanDetailDb> payPlanDetailList)
        {
            List<PayPlanDetailUI>  List = new List<PayPlanDetailUI>();
            foreach (var item in payPlanDetailList)
            {
                List.Add( new PayPlanDetailUI
                {
                    odemesekli = item.odemesekli,
                    yuzde = item.yuzde,
                });
            }
            return List;
        }
    }
}
