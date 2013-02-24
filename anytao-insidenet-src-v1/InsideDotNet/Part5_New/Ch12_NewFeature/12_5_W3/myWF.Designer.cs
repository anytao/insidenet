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
using System.Reflection;
using System.Workflow.ComponentModel.Compiler;
using System.Workflow.ComponentModel.Serialization;
using System.Workflow.ComponentModel;
using System.Workflow.ComponentModel.Design;
using System.Workflow.Runtime;
using System.Workflow.Activities;
using System.Workflow.Activities.Rules;

namespace InsideDotNet.NewFeature.W3
{
	partial class myWF
	{
        #region Designer generated code

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        private void InitializeComponent()
        {
            this.CanModifyActivities = true;
            System.Workflow.Activities.CodeCondition codecondition1 = new System.Workflow.Activities.CodeCondition();
            this.CheckUser = new System.Workflow.Activities.CodeActivity();
            this.OKActivity = new System.Workflow.Activities.CodeActivity();
            this.whileActivity = new System.Workflow.Activities.WhileActivity();
            this.UserLogin = new System.Workflow.Activities.CodeActivity();
            // 
            // CheckUser
            // 
            this.CheckUser.Name = "CheckUser";
            this.CheckUser.ExecuteCode += new System.EventHandler(this.codeActivity2_ExecuteCode);
            // 
            // OKActivity
            // 
            this.OKActivity.Name = "OKActivity";
            this.OKActivity.ExecuteCode += new System.EventHandler(this.codeActivity1_ExecuteCode);
            // 
            // whileActivity
            // 
            this.whileActivity.Activities.Add(this.CheckUser);
            codecondition1.Condition += new System.EventHandler<System.Workflow.Activities.ConditionalEventArgs>(this.CheckValidation);
            this.whileActivity.Condition = codecondition1;
            this.whileActivity.Name = "whileActivity";
            // 
            // UserLogin
            // 
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.ExecuteCode += new System.EventHandler(this.UserLogin_ExecuteCode);
            // 
            // myWF
            // 
            this.Activities.Add(this.UserLogin);
            this.Activities.Add(this.whileActivity);
            this.Activities.Add(this.OKActivity);
            this.Name = "myWF";
            this.CanModifyActivities = false;

        }

        #endregion

        private WhileActivity whileActivity;
        private CodeActivity UserLogin;
        private CodeActivity CheckUser;
        private CodeActivity OKActivity;
	}
}
