using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Base;

namespace TestApp
{
    class SourseCore
    {
        public static TestAppEntities DB = new TestAppEntities();
        private static TestAppEntities myBase;
        public static TestAppEntities getBase()
        {
            if (myBase == null)
            {
                myBase = new TestAppEntities();
            }
            return myBase;
        }
    }
}
