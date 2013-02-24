// Copyright   : 你必须知道的.NET
// Author      : Anytao，http://www.anytao.com
// FileName    : InsideDotNet.NewFeature.W3
// Release     : 2007/12/16 1.0
// Description : 12.5  江湖一统：WPF、WCF、WF

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace InsideDotNet.NewFeature.W3
{
	public sealed partial class myWF: SequentialWorkflowActivity
	{
        //定义while条件
        public string UserName { get; set; }

        public myWF()
        {
            InitializeComponent();
        }

        private void codeActivity1_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("顺序执行结束。");
        }

        private void codeActivity2_ExecuteCode(object sender, EventArgs e)
        {
            Console.WriteLine("我是小王，登陆成功。");
            UserName = "";
        }

        private void CheckValidation(object sender, ConditionalEventArgs e)
        {
            e.Result = UserName == "小王";
        }

        private void UserLogin_ExecuteCode(object sender, EventArgs e)
        {
            //UserName = "小王";
            Console.Write("请输入用户名：");
            UserName = Console.ReadLine();
        }
	}

}
