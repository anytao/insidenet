// Copyright   : .NET禅意花园
// Author      : Anytao，http://www.anytao.com
// FileName    : Zen.NewFeature.VS2008
// Release     : 2007/12/15 1.0
// Description : 12.4  抢鲜Visual Studio 2008

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btnSayHello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, Visual Stuido 2008.");
        }
    }
}
