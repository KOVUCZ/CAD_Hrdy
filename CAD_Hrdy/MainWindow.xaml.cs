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

namespace CAD_Hrdy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        private List<point> points = new List<point>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ActiveCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                var location = e.GetPosition(ActiveCanvas);
                point point = new point(location.X, location.Y);
                points.Add(point);
                point.AddToCanvas(ActiveCanvas);
            }
        }
    }
}
