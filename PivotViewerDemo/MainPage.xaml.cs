using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Pivot;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PivotViewerDemo
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.pivotViewer.ItemsSource = Factory.GetData();
        }
    }
}
