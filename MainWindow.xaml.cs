using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class MyModules
        {
            public string moduleCode { get; set; }
            public string moduleName { get; set; }
            public string credits { get; set; }
            public string weeklyHours { get; set; }
            public string semesterWeeks { get; set; }
            public string startDate { get; set; }
            public string selfstudy { get; set; }
            public string hoursremaining { get; set; }
            public string recorddate { get; set; }



        }
        // add new module was clicked
        private void btnNew_Clicked(object sender, RoutedEventArgs e)
        {
            MyModules mymodules = new MyModules();
            mymodules.moduleCode = txtModuleCOde.Text;
            mymodules.moduleName = txtModuleName.Text;
            mymodules.credits = txtCredits.Text;
            mymodules.weeklyHours = txtweeklyHours.Text;
            mymodules.semesterWeeks = txtSmesterWeeks.Text;
            mymodules.startDate = dpStartDate.Text;
            mymodules.selfstudy = (string)lblSeflStudy.Content;
            mymodules.hoursremaining = (string)lblHourssRemaining.Content;
            mymodules.recorddate = dpDate.Text;

            txtCredits.Clear();
            txtModuleCOde.Clear();
            txtModuleName.Clear();
            txtSmesterWeeks.Clear();
            txtweeklyHours.Clear();
            lblHourssRemaining.Content = "";
            lblSeflStudy.Content = "";
           
            

            dgv.Items.Add(mymodules);

        }

        private void btnSelfStudy_Clicked(object sender, RoutedEventArgs e)
        {
            int credits = Convert.ToInt32(txtCredits.Text);
            int semesterweeks = Convert.ToInt32(txtSmesterWeeks.Text);
            int weeklyhours = Convert.ToInt32(txtweeklyHours.Text);
            int self_study_weeklyHours = Convert.ToInt32(credits * 10 / semesterweeks - weeklyhours);

            lblSeflStudy.Content = self_study_weeklyHours.ToString();
        }

        private void btnHoursRemaining_Clicked(object sender, RoutedEventArgs e)
        {
            int hoursSpent = Convert.ToInt32(txtHoursSpent.Text);
            int selfstudyHours = Convert.ToInt32(lblSeflStudy.Content);
            int hoursRemaining = Convert.ToInt32(selfstudyHours - hoursSpent);

            lblHourssRemaining.Content = hoursRemaining.ToString();
        }

        private void btnDelete_Clicked(object sender, RoutedEventArgs e)
        {
            if(dgv.SelectedIndex >=0)
                {
                dgv.Items.RemoveAt(dgv.SelectedIndex);
            } 
        }
    }
}
