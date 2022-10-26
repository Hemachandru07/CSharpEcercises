    using System;
    using System.Data.SqlClient;
    using System.Data;

namespace Ado_net
{
    internal class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        static void Main(string[] args)
        {
            //InsertData();
            //DeleteData();
            //SelectData();
            //UpdateData();
            Disconselect();
        }
        private static SqlConnection getcon()
        {
            con = new SqlConnection("Data Source = (local); Initial catalog = WhiteBlueDB; Integrated Security = true");
            con.Open();
            return con;
        }
        private static void SelectData()
        {
            con = getcon();
            cmd = new SqlCommand("Select *from supllier");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                for(int i=0; i<dr.FieldCount; i++)
                {
                    Console.Write(dr[i]);
                }
                Console.WriteLine();
            }
        }
        private static void InsertData()
        {
            Console.WriteLine("Enter your name and location : ");
            string pname = Console.ReadLine();
            string location = Console.ReadLine();
            con = getcon();
            cmd = new SqlCommand("insert into supllier values(@sname,@location)");
            cmd.Parameters.AddWithValue("@sname", pname);
            cmd.Parameters.AddWithValue("@location", location);
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine(i + "number of row(s) affected");

        }
        private static void DeleteData()
        {
            Console.WriteLine("Enter the sid num : ");
            int sid = Convert.ToInt32(Console.ReadLine());
            con = getcon();
            cmd = new SqlCommand("delete from supllier where sid = (@sid)");
            cmd.Parameters.AddWithValue("@sid", sid);
            cmd.Connection=con;
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine(i + "Number of row(s) deleted");
        }

        private static void UpdateData()
        {
            Console.WriteLine("Enter the name and location :");
            string name = Console.ReadLine();
            string location = Console.ReadLine();
            con = getcon();
            cmd = new SqlCommand("Update supllier set sname = @name, location = @location  where sid = 211");
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@location", location);
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine(i + "Number of row(s) updated");

        }
        private static void Disconselect()
        {
            con = getcon();
            cmd = new SqlCommand("select *from supllier");
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
                foreach(DataRow dr in dt.Rows)
            {
                foreach(var item in dr.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
