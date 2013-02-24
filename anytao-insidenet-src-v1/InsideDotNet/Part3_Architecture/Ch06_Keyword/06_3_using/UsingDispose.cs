// Copyright   : �����֪����.NET
// Author      : Anytao��http://www.anytao.com
// FileName    : InsideDotNet.Keyword.Using
// Release     : 2007/09/30 1.0
// Description : 6.3 using�Ķ������

using System;
using System.Drawing;
using InsideDotNet.Keyword.Using.Anytao.NestedNamespace;

namespace InsideDotNet.Keyword.Using
{
    class UsingDispose
    {
        public static void Main_6_3_2()  //Main_6_3_2
        {
            NestedCls myCls = new NestedCls();
            myCls.MyMethod();

            using (Font f = new Font("Verdana", 12, FontStyle.Regular))
            {
                //ִ���ı����Ʋ���
                //Graphics g = e.Graphics;
                //Rectangle rect = new Rectangle(10, 10, 200, 200);
                //g.DrawString("Try finally dispose font.", f, Brushes.Black, rect);   
            }

            Font f2 = new Font("Arial", 10, FontStyle.Bold);
            try
            {
                //Graphics g = new Graphics();
                //Rectangle rect = new Rectangle(10, 10, 200, 200);
                //g.DrawString("Try finally dispose font.", f2, Brushes.Black, rect);   

                //ִ���ı����Ʋ���
            }
            finally
            {
                if (f2 != null)
                    ((IDisposable)f2).Dispose();
            }


            //ͬʱ��ʼ���������
            using (Pen p1 = new Pen(Brushes.Black), p2 = new Pen(Brushes.Blue))
            {
                //
            }

            using (IDisposable font = new Font("Verdana", 12, FontStyle.Regular), pen = new Pen(Brushes.Black))
            {
                float size = (font as Font).Size;
                Brush brush = (pen as Pen).Brush;
            }

            //��using���֮ǰ��������
            Font f3 = new Font("Verdana", 9, FontStyle.Regular);
            using (f3)
            {
                //ִ���ı����Ʋ���
                //Graphics g = e.Graphics;
                //Rectangle rect = new Rectangle(10, 10, 200, 200);
                //g.DrawString("Try finally dispose font.", f, Brushes.Black, rect);   
            }
        }
    }
}
