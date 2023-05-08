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
using System.Security;
// uncomment when somehting added
using KIT206_RAP.DataBase;
using KIT206_RAP.Controll;
using KIT206_RAP.Researchers;
using KIT206_RAP.View;
//using KIT206_RAP.DataBase;

namespace GROUP_07_RAP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //ResearcherControl.DisplayResearchers();
        }
    }
}
