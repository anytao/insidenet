// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.Framework.EnumEx
// Release     : 2007/10/30 1.0
// Description : 8.4 简易不简单：枚举和位标记

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InsideDotNet.Framework.EnumEx
{
    public partial class frmEnumBinding : Form
    {
        public frmEnumBinding()
        {
            InitializeComponent();
        }

        private void frmEnumBinding_Load(object sender, EventArgs e)
        {
            ListBox lb = new ListBox();
            lb.DataSource = Enum.GetValues(typeof(Week));
            this.Controls.Add(lb);
        }
    }
}