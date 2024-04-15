using OdemePlanı_11.DataAccess;
using OdemePlanı_11.Entities.Db;
using OdemePlanı_11.Entities.Table;
using OdemePlanı_11.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemePlanı_11.Business.Service.Repository
{
    public class PayPlanRerpository : IPayPlanRerpository
    {
        private readonly string active = "A";
        PayPlanDbContext context;
        public PayPlanRerpository()
        {
            context = new PayPlanDbContext();
        }
        public int GetLastOzetBimno()
        {

            var result = context.musteriteklifleriozet_odemesekli
                                .Where(x => x.aktifpasif == active)
                                .OrderBy(x => x.ozet_bimno)
                                .Select(x => x.ozet_bimno)
                                .FirstOrDefault()
                                ;


            return Convert.ToInt32(result);
        }

        public List<PayPlanDetailDb> GetPayPlanDetail_rp(string groupName)
        {
            var result = context.musteriteklifleriozet_odemesekli
                                .Select(x => new PayPlanDetailDb
                                {
                                    aktifpasif = x.aktifpasif,
                                    grupadi = x.grupadi,
                                    odemesekli = x.odemesekli,
                                    yuzde = x.yuzde,
                                    bimno = x.bimno,
                                    ozet_bimno = x.ozet_bimno,
                                })
                                .Where(x => x.aktifpasif == active)
                                .Where(x => x.grupadi == groupName)
                                .Where(x=>x.ozet_bimno<0)
                                .ToList();
            return result;
                                
        }

        public List<PayPlansListUI> GetPayPlanPreviewList_rp()
        {
            var result=context.musteriteklifleriozet_odemesekli
                                .Where(x=> x.aktifpasif == active)
                                .Where(x=>x.ozet_bimno<0)
                                .OrderBy(x=>x.ozet_bimno)
                                .Select(group => new PayPlansListUI
                                {
                                    GroupName=group.grupadi
                                })
                                .Distinct()
                                .ToList();
            return result;
        }

        public void PayPlanAdd_rp(List<musteriteklifleriozet_odemesekli> addList)
        {

            context.musteriteklifleriozet_odemesekli.AddRange(addList);
            context.SaveChanges();
        }

        public void PayPlanDelete_rp(PayPlanDeleteDb payPlanDeleteDb)
        {
            var result = context.musteriteklifleriozet_odemesekli
                               
                               .Where(x=> x.aktifpasif == active)
                               .Where(x=>x.grupadi==payPlanDeleteDb.grupadi)
                               .ToList();
            foreach (var item in result)
            {
                item.aktifpasif = payPlanDeleteDb.aktifpasif;
                item.iptaleden=payPlanDeleteDb.iptaleden;
                item.bilgisayaradi_i=payPlanDeleteDb.bilgisayaradi_i;
                item.iptaltarihi_d=payPlanDeleteDb.iptaltarihi_d;
            }
            context.SaveChanges ();
        }                      
    }
}
