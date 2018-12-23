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

namespace Keyper
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
            spDrag.MouseDown += MouseDrag;
            gridDrag.MouseDown += MouseDrag;

            btnClose.MouseDown += BtnClose_MouseDown;
        }

        private void BtnClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MouseDrag(object sender, MouseButtonEventArgs e)
        {
            try
            {
                this.DragMove();
            }
            catch (Exception)
            {
            }
        }
    }
}
