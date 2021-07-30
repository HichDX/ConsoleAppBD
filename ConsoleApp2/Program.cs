using System;
using System.Linq;

namespace LoadData
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadDB();
            Console.ReadKey();
        }

        private static void LoadDB()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var usr = from us in dc.users
                      select new
                      {
                          us.nickname
                      };
            foreach (var u in usr)
            {
                Console.WriteLine(u.nickname);
            }
            Console.ReadKey();
        }
    }
}
