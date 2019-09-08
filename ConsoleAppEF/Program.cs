using LoPrescription.BLL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var ret = "完成";
            try
            {
                var list = ServiceFactory.studentService.LoadEntites().ToList();
                Console.WriteLine(JsonConvert.SerializeObject(list));

                //Task.Run(() =>{
                //    var list2 = ServiceFactory.studentService.Page();
                //    Console.WriteLine(JsonConvert.SerializeObject(list2));
                //});

                var list2 = ServiceFactory.studentService.Page();
                Console.WriteLine(JsonConvert.SerializeObject(list2));

            }
            catch (Exception ex)
            {
                ret = ex.Message;
            }
            

            Console.WriteLine(ret);
            Console.ReadKey();
        }
    }



        public static class ServiceFactory
        {
            private static object _lock_StudentService = new object();
            private volatile static StudentService _studentService;
            public static StudentService studentService
            {
                get
                {
                    if (_studentService == null)
                    {
                        lock (_lock_StudentService)
                        {
                            if(_studentService == null)
                            {
                                _studentService = new StudentService();
                            }
                        }
                    }
                    return _studentService;
                }


        }


    }
}
