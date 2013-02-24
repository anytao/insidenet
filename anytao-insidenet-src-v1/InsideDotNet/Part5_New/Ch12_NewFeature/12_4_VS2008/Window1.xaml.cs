// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.VS2008
// Release     : 2007/12/13 1.0
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
using System.Windows.Shapes;

namespace InsideDotNet.NewFeature.VS2008
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Button button1 = new Button();
            //button1.Content = "Hello world";
            //button1.Width = 200;
            //button1.Height = 50;
            button1.Click += delegate
            {
                MessageBox.Show("Hello world.");
            };
        }
    }
}
