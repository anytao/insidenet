// Copyright   : 你必须知道的.NET，第2版
// Author      : Anytao，http://www.anytao.com
// FileName    : Anytao.Inside.Ch03.Dependence
// Release     : 2011/02/10 1.0
// Description : 3.2  依赖的哲学

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anytao.Inside.Ch03.Dependence
{
    class Program
    {
        static void Main2(string[] args)
        {
            IAnimalFacotry<Animal> factory = FacotryBuilder.Build("Cat");
            Animal dog = factory.Create();
            dog.Show();
        }


    }
}
