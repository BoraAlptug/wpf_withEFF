using OdemePlanı_11.Entities.UI;
using OdemePlanı_11.Presentation;
using System.Windows;

namespace OdemePlanı_11.UI
{
    /// <summary>
    /// Interaction logic for UserUI.xaml
    /// </summary>
    public partial class UserUI : Window
    {
        public string UserName { get; set; }
        private string groupName { get; set; }  

        IPayPlanPresentatrion payPlanPresentation;

        public UserUI()
        {
            InitializeComponent();
            payPlanPresentation = new PayPlanPresentation();
            AddPayPlanRow();
            PayPlanPreviewList();
        }

        public void AddPayPlanRow()
        {
            List<PayPlanAddUI> payPlanAddUIs = new List<PayPlanAddUI>();
            PayPlanAddUI payPlanAddUI = new PayPlanAddUI();
            payPlanAddUIs.Add(payPlanAddUI);
            payPlanDetail_dgw.ItemsSource = payPlanAddUIs;
        }

        private void payPlanAdd_btn_Click(object sender, RoutedEventArgs e)
        {
            payPlanPresentation.PayPlanAdd_pr(payPlanDetail_dgw, payPlanName_txt.Text.ToUpper(), UserName);
            PayPlanPreviewList();
        }
        private void PayPlanPreviewList()
        {
            payPlanPresentation.GetPayPlanPreviewList_pr(payPlanPreviewList_lstbox);
        }

        private void payPlanDelete_btn_Click(object sender, RoutedEventArgs e)
        {
            payPlanPresentation.PayPlanDelete_pr(groupName,UserName);
            PayPlanPreviewList();
        }

        private void payPlanPreviewList_lstbox_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (payPlanPreviewList_lstbox.SelectedItem == null) { return; }
            groupName = payPlanPreviewList_lstbox.SelectedItem.ToString();
            if (groupName == null) { return; }
            payPlanPresentation.LoadPayPlanDetail_pr(payPlanDetail_dgw, groupName);
        }

        private void emptyPayPlan_btn_Click(object sender, RoutedEventArgs e)
        {
            payPlanPresentation.EmptypayPlanDetailList_pr(payPlanDetail_dgw);
        }
    }
}
