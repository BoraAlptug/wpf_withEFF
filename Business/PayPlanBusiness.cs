using OdemePlanı_11.Business.Mapper;
using OdemePlanı_11.Business.Rules;
using OdemePlanı_11.Business.Service.Repository;
using OdemePlanı_11.Business.Validator;
using OdemePlanı_11.Entities.Db;
using OdemePlanı_11.Entities.Table;
using OdemePlanı_11.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OdemePlanı_11.Business
{
    public class PayPlanBusiness : IPayPlanBusiness
    {
        IPayPlanAddValidator payPlanAddValidator;
        IPayPlanRules payPlanRules;
        IPayPlanRerpository payPlanRerpository;
        IPayPlanMapper payPlanMapper;

        public PayPlanBusiness()
        {
            payPlanAddValidator = new PayPlanAddValidator();
            payPlanRules = new PayPlanRules();
            payPlanRerpository = new PayPlanRerpository();
            payPlanMapper = new PayPlanMapper();
        }

        public void EmptyPayPlan_bs(DataGrid payPlanDetail_dgw)
        {
            List<PayPlanDetailUI> payPlanDetailUIs = new List<PayPlanDetailUI>();
            PayPlanDetailUI pay=new PayPlanDetailUI();
            payPlanDetailUIs.Add(pay);
            payPlanDetail_dgw.ItemsSource = payPlanDetailUIs;
        }

        public List<PayPlanDetailUI> GetPayPlanDetailList_bs(string groupName)
        {
            List<PayPlanDetailUI> payPlanDetailListUIs = new List<PayPlanDetailUI>();
            List<PayPlanDetailDb> payPlanDetailList= payPlanRerpository.GetPayPlanDetail_rp(groupName);
            payPlanDetailListUIs = payPlanMapper.PayPlanDetail_mp(payPlanDetailList);
            payPlanDetailListUIs= payPlanAddValidator.PayPlanDetailValidator_vl(payPlanDetailListUIs);

            return payPlanDetailListUIs;
        }

        public void PayPlanAdd_bs(List<PayPlanAddUI> list, string text, string UserName)
        {
           // if (payPlanRules.PayPlanPercent_rl(list)) return;
            
            list=payPlanAddValidator.PayPlanUpperCase_vl(list);
            int ozetBimno = payPlanRerpository.GetLastOzetBimno()-1;

            List<musteriteklifleriozet_odemesekli> addList = payPlanMapper.PayPlanAdd_mp(list, text, UserName, ozetBimno);
            payPlanRerpository.PayPlanAdd_rp(addList);
        }

        public void PayPlanDelete_bs(string groupName, string userName)
        {
            if(payPlanRules.PayPlanDelete_rl()) return;
            PayPlanDeleteDb payPlanDeleteDb= payPlanMapper.PayPlanDelete_mp(groupName, userName);
            payPlanRerpository.PayPlanDelete_rp(payPlanDeleteDb);

        }

        public List<PayPlansListUI> PayPlanPreviewList_bs()
        {
             return payPlanRerpository.GetPayPlanPreviewList_rp();
        }
    }
}
