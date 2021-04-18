using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LateBindingIslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly exec = Assembly.GetExecutingAssembly();
            Type t = exec.GetType("LateBindingIslemleri.musteri");



          object musteriInst =  Activator.CreateInstance(t);
          MethodInfo MI = t.GetMethod("MusteriIsimGetir");

            string[] parametrelerim = new string[2];
            parametrelerim[0] = "alparslan";
            parametrelerim[1] = "yüce";


         string gelendeger = (string)MI.Invoke(musteriInst, parametrelerim);
            Console.WriteLine(gelendeger);




            Console.ReadLine();



        }
    }
}
