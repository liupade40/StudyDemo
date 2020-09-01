using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Con = System.Console;

namespace Console.OOPTest
{
    class Program
    {
        static void Main1(string[] args)
        {
            List<OperationBase> operList = new List<OperationBase>()
            {
                //new OperationBase(),
                //new KeyOperation(),
                //new MouseOperation()
            };
            KeyOperation kob = new KeyOperation();
            kob.ChildOperationList = new List<OperationBase>()
            {
                new MouseOperation(),
                new KeyOperation()
            };
            operList.Add(kob);

            foreach (OperationBase oper in operList)
            {
                oper.Operate();
            }
            Con.ReadLine();
        }
        static void Main(string[] args)
        {
            key1 k1 = new key1();
            k1.aaa();
            key2 k2 = new key2();
            k2.aaa();
        }

    }

    public class OperationBase : IOperationBase
    {
        public ICondition PreCondition { get; private set; }

        public void Operate()
        {

            if (PreCondition.Check())
            {
                OperateInner();
            }
            //Con.WriteLine("BaseOperate");

        }
        public void OperateChild()
        {
            if (ChildOperationList != null)
            {
                foreach (OperationBase ob in ChildOperationList)
                {
                    ob.Operate();
                }
            }
        }

        public virtual void OperateInner()
        {
            OperateChild();
        }

        public List<OperationBase> ChildOperationList { get; set; }
    }
    public class KeyOperation : OperationBase
    {
        public override void OperateInner()
        {
            Con.WriteLine("KeyOperation");
            base.OperateInner();
        }
    }

    public class MouseOperation : OperationBase
    {
        public override void OperateInner()
        {
            Con.WriteLine("MouseOperation");
        }
    }

    public interface IOperationBase
    {
        void Operate();
    }

    public class key1
    {
        public void aaa()
        {

        }
    }
    public class key2
    {
        public void aaa()
        {

        }
    }
    public class key3
    {
        void aaa()
        {

        }
    }

    public interface ICondition
    {
        bool Check();
    }

    public class ColorCondition : ICondition
    {
        public bool Check()
        {
            return true;
        }
    }

    public class TimeCondition : ICondition
    {
        public bool Check()
        {
            return DateTime.Now.Day >= 20;
        }
    }
}
