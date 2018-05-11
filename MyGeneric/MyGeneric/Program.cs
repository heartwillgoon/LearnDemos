using MyGeneric.Extend;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    /// <summary>
    /// 1 引入泛型:延迟声明
    /// 2 如何声明和使用泛型
    /// 3 泛型的好处和原理
    /// 4 泛型类、泛型方法、泛型接口、泛型委托
    /// 5 泛型约束
    /// 6 协变 逆变(选修)
    /// 7 泛型缓存(选修)
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班vip课程，今天是Eleven老师给大家带来的泛型Generic");
                //List<int>
                //List<string>

                //Console.WriteLine(typeof(List<>));//`1
                //Console.WriteLine(typeof(Dictionary<,>));//`2
                //var varValue = 789;
                //object objectValue = 789;
                //int iValue = 123;
                //dynamic dValue = 789;

                ////int result = varValue + iValue;
                ////int result2 = objectValue + iValue;
                //int result3 = dValue + iValue;
                //string sValue = "456";
                //DateTime dtValue = DateTime.Now;
                //object oValue = "MrSorry";

                //Console.WriteLine("**************************");
                //CommonMethod.ShowInt(iValue);
                //CommonMethod.ShowString(sValue);
                //CommonMethod.ShowDateTime(dtValue);
                //CommonMethod.ShowObject(oValue);

                //CommonMethod.ShowObject(iValue);
                //CommonMethod.ShowObject(sValue);
                //CommonMethod.ShowObject(dtValue);

                //Console.WriteLine("************Generic**************");
                //GenericMethod.Show<int>(iValue);//需要指定类型参数
                ////GenericMethod.Show<string>(iValue);//必须吻合
                //GenericMethod.Show(iValue);//能省略，自动推算
                //GenericMethod.Show<string>(sValue);
                //GenericMethod.Show<DateTime>(dtValue);
                //GenericMethod.Show<object>(oValue);


                ////GenericClass<int> genericClass = new GenericClass<int>()
                ////{
                ////    _T = 123
                ////};
                ////GenericClass<string> genericClassString = new GenericClass<string>()
                ////{
                ////    _T = "123"
                ////};

                //Console.WriteLine("************Monitor**************");
                //Monitor.Show();
                ////generic≈≈common>object
                ////泛型：又叫马儿跑，又叫马儿不吃草！ 因为框架的升级

                GenericCacheTest.Show();

                Console.WriteLine("************Constraint*****************");
                {
                    People people = new People()
                    {
                        Id = 123,
                        Name = "走自己的路"
                    };
                    Chinese chinese = new Chinese()
                    {
                        Id = 234,
                        Name = "晴天"
                    };
                    Hubei hubei = new Hubei(123)
                    {
                        Id = 345,
                        Name = "流年"
                    };
                    Japanese japanese = new Japanese()
                    {
                        Id = 7654,
                        Name = "苍老师"//寒露的建议
                    };

                    //CommonMethod.ShowObject(people);
                    //CommonMethod.ShowObject(chinese);
                    //CommonMethod.ShowObject(hubei);
                    //CommonMethod.ShowObject(japanese);

                    //Constraint.Show<People>(people);
                    Constraint.Show<Chinese>(chinese);
                    //Constraint.Show<Hubei>(hubei);
                    //Constraint.Show<Japanese>(japanese);//
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
