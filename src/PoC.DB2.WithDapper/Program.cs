using System;
using System.Collections.Generic;
using System.IO;
using PoC.DB2.WithDapper.Model;
using PoC.DB2.WithDapper.Repository;

namespace PoC.DB2.WithDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PoC DB2 with Dapper");
            Console.WriteLine("Querying data...");

            try
            {
                var repo = new DummyRepository("connection_string");
                IList<DummyModel> statementData = repo.GetDummyData("param1", "param2");

                foreach (var item in statementData)
                {
                    Console.WriteLine(item.Value);
                }

                Console.WriteLine("Worked like a charm!!!");
            }
            catch (System.Exception ex)
            {
                string folder = Environment.CurrentDirectory;
                File.WriteAllText($@"{folder}\log.txt", $"{ex.Message}{ex.StackTrace}");
                Console.WriteLine("Something went really bad. Visit log on root folder.");
            }

            Console.ReadKey();
        }
    }
}
