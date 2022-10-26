using System;
using EntityFrameworkCore.Model;

namespace EntityFrameworkCore
{
     class Program
    {
        public static WhiteBlueDBContext db = new WhiteBlueDBContext();
        public static Supllier s = new Supllier();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Supplier ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            //SelectData();
            //InsertData();
           // DeleteData(id);
            UpdateData(id);

        }

        private static void SelectData()
        {
            foreach (var item in db.Suplliers)
            {
                Console.WriteLine(item.Sid + " " +item.Sname +" " +item.Location);
            }
        }
        private static void InsertData()
        {
            Console.WriteLine("Enter the name and location :");
            s.Sname = Console.ReadLine();
            s.Location = Console.ReadLine();
            db.Suplliers.Add(s);
            db.SaveChanges();
        }

        private static void DeleteData(int id)
        {
            s = GetSupplyByID(id);
            db.Suplliers.Remove(s);
            db.SaveChanges();
        }

        private static Supllier GetSupplyByID(int id)
        {
            s = db.Suplliers.Find(id);
            return s;
        }

        private static void UpdateData(int id)
        {
            s = GetSupplyByID(id);
            Console.WriteLine(s.Sid + " " +s.Sname +" " +s.Location);
            Console.WriteLine("Enter the name : ");
            s.Sname = Console.ReadLine();
            Console.WriteLine("Enter the location: ");
            s.Location= Console.ReadLine();
            db.Suplliers.Update(s);
            db.SaveChanges();
        }
    }
}
