using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RexHelps
{
    class Class1
    {   //^\s*\n
        //public class Generic
        //{
        //    public String Name;
        //}
        //public class Generic<T>
        //{
        //    public T Name;
        //}
        //public static void Excute()
        //{
        //    Generic<String> gs = new Generic<String>();
        //    gs.Name = "Kiba518";
        //}
        //public static void Excute1()
        //{
        //    Generic<int> gs = new Generic<int>();
        //    gs.Name = 518;
        //}
        //public static void Excute2()
        //{
        //    Generic<int> gs = new Generic<int>();
        //    gs.Name = 518;
        //    Generic<Task> gsTask = new Generic<Task>();
        //    gsTask.Name = new Task(() => {
        //        Console.WriteLine("Kiba518");
        //    });
        //}
        //public class Generic<T>
        //{
        //    public T Name = default(T);
        //}







        public static void Excute3()
        {
            //Generic<FanXing> gFanXing = new Generic<FanXing>();
            //Generic<Base> gFanXingBase = new Generic<Base>();
            ////Generic<string> gs = new Generic<string>(); 这样定义会报错
        }
        public class Generic1<T> where T : Base
        {
            public T Name = default(T);
        }
        public class Base
        {
            public string Name { get; set; }
        }
        public class FanXing : Base
        {
            public new string Name { get; set; }
        }


        public static void Excute4()
        {
            GenericFunc gf = new GenericFunc();
            gf.FanXingFunc(new FanXing() { Name = "Kiba518" });
        }
        public class GenericFunc
        {
            public void FanXingFunc<T>(T obj)
            {
                Console.WriteLine(obj.GetType());
            }
        }
        public class GenericFunc1
        {
            
            public void FanXingFunc1<T>(T obj)
            {
                var name = GetPropertyValue(obj, "Name");
                Console.WriteLine(name);
            }
            public object GetPropertyValue(object obj, string name)
            {
                object drv1 = obj.GetType().GetProperty(name).GetValue(obj, null);
                return drv1;
            }
        }
    }
}
