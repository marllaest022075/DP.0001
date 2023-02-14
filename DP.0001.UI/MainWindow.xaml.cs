
using DP0001.WINUI.Controls;
using DP0001.WINUI.Core;
using DPFP.Gui.Enrollment;
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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DP._0001.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //WindowInteropHelper helper;
        //private readonly IAppData data;
        //private readonly EnrollmentForm _enroll;
        //private readonly VerificationForm _verification;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            //data = new AppData();
            //_enroll = new(data);
            //_verification = new(data);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var boton = ((Button)sender).Content.ToString();
            //if (Equals(boton, "Enroll"))
            //    _enroll.ShowDialog();
            //if (Equals(boton, "Verify"))
            //    _verification.ShowDialog();

        }
    }
}
