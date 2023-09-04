using System;
using System.Collections.Generic;
using System.IO;

namespace Lab5.Lab_5_Class
{
    public static class CustomerDB
    {
        private const string dir = @"C:\MyDB\";
        private const string path = dir + "Customers.txt";

        public static void SaveCustomers(List<Customer> customers)
        {
            StreamWriter textOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            foreach (Customer customer in customers)
            {
                textOut.Write(customer.FirstName + "|");
                textOut.Write(customer.LastName + "|");
                textOut.WriteLine(customer.Email);
            }
            textOut.Close();
        }

        public static List<Customer> GetCustomers()
        {
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            List<Customer> list = new List<Customer>();

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');

                if (columns.Length >= 3)
                {
                    Customer customer = new Customer(columns[0], columns[1], columns[2]);
                    list.Add(customer);
                }
            }

            textIn.Close();
            return list;
        }
    }
}
