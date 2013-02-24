// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch03.Dependence
// Release     : 2011/02/10 1.0
// Description : 3.2  依赖的哲学

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace Anytao.Inside.Ch03.Dependence
{
    class UnityCreation
    {
        public static void Main()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<Animal, Dog>();

            Animal dog = container.Resolve<Animal>();
            dog.Show();
        }
    }
}
