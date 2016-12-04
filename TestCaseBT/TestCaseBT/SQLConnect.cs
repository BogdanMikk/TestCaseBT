using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCaseBT
{
    abstract class SQLConnect
    {
        private static readonly string _path = @"Data Source=Store.db;Version=3";
        public static bool ConTest()
        {
            if (File.Exists(@"Store.db"))
            {
                using (var c = new SQLiteConnection(_path))
                {
                    try
                    {
                        c.Open();
                        if (c.State == System.Data.ConnectionState.Open)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Отсутствует БД!");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Отсутствует БД!");
                return false;
            }
        }
        public static bool FillList(out IList<Product> list ) //Fill list
        {
            list = new List<Product>();
            using (var c = new SQLiteConnection(_path))
            {
                try
                {
                    var cmd = new SQLiteCommand(@"SELECT * FROM Store", c);
                    c.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string count = reader.GetString(2).Replace('.', ',');
                            string price = reader.GetString(3).Replace('.', ',');
                            var p = new Product(reader.GetInt64(0), reader.GetString(1), Convert.ToDouble(count), 
                                Convert.ToDouble(price), reader.GetString(4));
                            list.Add(p);
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        public static bool ExecuteQuery(string q) //ExecuteQuery
        {
            using (var c = new SQLiteConnection(_path))
            {
                try
                {
                    var cmd = new SQLiteCommand(q, c);
                    c.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        public static long GetLatestID(ref string[] p) //GetId
        {
            using (var c = new SQLiteConnection(_path))
            {
                try
                {
                    var cmd = new SQLiteCommand(@"SELECT id FROM Store WHERE name = '" + p[0] + "' AND cnt = '" + p[1] +
                        "' AND price = '" + p[2] + "' AND category = '" + p[3] + "' ORDER BY id DESC LIMIT 1", c);
                    Console.WriteLine(cmd.CommandText);
                    c.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        long x = -1;
                        while (reader.Read())
                        {
                            x = reader.GetInt64(0);
                        }
                        return x;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                }
            }
        }
    }
}
