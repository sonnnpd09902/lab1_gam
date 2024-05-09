using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{

    public static class UserData

    {
        public static string ID;
        public static string UserName;
        public static int Gold;
        public static int Point;

        static UserData()
        {
            ID = "2024";
            UserName = "Nguyen Ngoc Son";
            Gold = 0;
            Point = 0;
        }

        public static void ShowData()
        {
            Console.WriteLine("ID: " + UserData.ID);
            Console.WriteLine("UserName: " + UserData.UserName);
            Console.WriteLine("Gold: " + UserData.Gold);
            Console.WriteLine("Point: " + UserData.Point);
            Console.ReadLine();
        }
        public class Program
        {
            public static int Main(string[] args)
            {
                UserData.ShowData();
                return 0;
            }

        }
    }

}
