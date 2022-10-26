using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Bank_Lib
{
    public class BankRepository : IBankRepository
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        private static SqlConnection getcon()
        {
            con = new SqlConnection("Data Source = (local); Initial catalog = BankDB; Integrated Security = true");
            con.Open();
            return con;
        }
        public void DepositAmount()
        {
            Console.WriteLine("Enter the Account_Number, Amount, TransactionType : ");
            int AccountNumber = Convert.ToInt32(Console.ReadLine());
            int Amount = Convert.ToInt32(Console.ReadLine());
            string TransactionType = Console.ReadLine();
            con = getcon();
            cmd = new SqlCommand("insert into sbtransaction values(getdate(),@AccountNumber,@Amount,@TranscationType)");
            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.Parameters.AddWithValue("@TransactionType", TransactionType);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con = getcon();
            cmd = new SqlCommand("UPDATE sbaccount SET  CurrentBalance=CurrentBalance+(select sum(Amount) from sbtransaction where AccountNumber=@AccountNumber)where AccountNumber=@AccountNumber ");
            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter the Account Number :");
            int AccountNumber = Convert.ToInt32(Console.ReadLine());
            con = getcon();
            cmd = new SqlCommand("select *from sbaccount where @AccountNumber = AccountNumber");
            cmd.Parameters.AddWithValue("@AccountNumber",AccountNumber);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for(int i = 0; i < dr.FieldCount; i++)
                {
                    Console.WriteLine(dr[i] + " ");
                }
                Console.WriteLine();
            }
            dr.Close();
            cmd.ExecuteNonQuery();
        }

        public void GetAllAccounts()
        {
            con = getcon();
            cmd = new SqlCommand("Select * from sbaccount");
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Console.Write(dr[i] +" ");
                }
                Console.WriteLine();
            }


        }

        public void GetTransactions()
        {
            Console.WriteLine("Enter the Account Number :");
            int AccountNumber = Convert.ToInt32(Console.ReadLine());
            con = getcon();
            cmd = new SqlCommand("select TransactionID, TransactionDate, Amount, TransactionType from sbtransaction where @AccountNumber = AccountNumber");
            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Console.WriteLine(dr[i] + " ");
                }
                Console.WriteLine();
            }
            dr.Close();
            cmd.ExecuteNonQuery();
        }

        public void NewAccount()
        {
            con = getcon();
            Console.WriteLine("Enter the AccountNumber, CustomerName, CustomerAddress");
            int AccountNumber = Convert.ToInt32(Console.ReadLine());
            string CustomerName = Console.ReadLine();
            string CustomerAddress = Console.ReadLine();
            cmd = new SqlCommand("insert into sbaccount values(@AccountNumber, @CustomerName, @CustomerAddress,default)");
            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
            cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Console.WriteLine("New Account Added");
        }

        public void WithdrawAmount()
        {
            Console.WriteLine("Enter the Account_Number, Amount, TransactionType : ");
            int AccountNumber = Convert.ToInt32(Console.ReadLine());
            int Amount = Convert.ToInt32(Console.ReadLine());
            string TransactionType = Console.ReadLine();
            con = getcon();
            cmd = new SqlCommand("insert into sbtransaction values(getdate(),@AccountNumber,@Amount,@TransactionType)");
            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.Parameters.AddWithValue("@TransactionType", TransactionType);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con = getcon();
            cmd = new SqlCommand("UPDATE sbtransaction SET  CurrentBalance=CurrentBalance -  (select Amount from sbtransaction where TransactionID=(select max(CurrentBalance)AS Amount from sbtransaction))" +  "where AccountNumber=@AccountNumber ");
            cmd.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            cmd.Parameters.AddWithValue("@Amount", Amount);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

        }


    }
}
