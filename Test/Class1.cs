using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public abstract class Base
    {
        public abstract string Say();

    }
    public class Student : Base
    {
        public override string Say()
        {
            return "我是学生";
        }
        public string nihao()
        {
            return "";
        }
    }
    public class worker : Base
    {
        public override string Say()
        {
            worker worker = new worker();
            
            return "我是工人";
        }
        public string nihao()
        {
            return "";
        }
    }
}
