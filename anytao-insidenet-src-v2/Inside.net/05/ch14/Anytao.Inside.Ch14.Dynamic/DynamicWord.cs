// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch14.Dynamic
// Release     : 2011/01/27 1.0
// Description : 14.3  动态变革：dynamic

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.Word;

namespace Anytao.Inside.Ch14.Dynamic
{
    public static class DynamicWord
    {
        public static void Create(string file, string author)
        {
            // Create word app and bind to a dynamic variable
            dynamic app = new Application { Visible = true };
            
            // Create document
            var doc = app.Documents.Add();
            string text = "Hello, this is anytao. /" + DateTime.Now.ToString();

            dynamic range = doc.Range(0, 0);
            range.Text = text;

            // Save document
            doc.SaveAs(file);
            app.Quit();
        }
    }
}
