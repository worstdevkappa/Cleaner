using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("C:\\Riot Games\\League of Legends\\Logs\\Game - R3d Logs");

            foreach (System.IO.FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (System.IO.DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
            System.IO.DirectoryInfo di2 = new System.IO.DirectoryInfo("C:\\Riot Games\\League of Legends\\Logs\\LeagueClient Logs");

            foreach (System.IO.FileInfo file in di2.GetFiles())
            {
                file.Delete();
            }
            foreach (System.IO.DirectoryInfo dir in di2.GetDirectories())
            {
                dir.Delete(true);
            }
            System.IO.DirectoryInfo di3 = new System.IO.DirectoryInfo("C:\\Riot Games\\League of Legends\\Logs\\Network Logs");

            foreach (System.IO.FileInfo file in di3.GetFiles())
            {
                file.Delete();
            }
            foreach (System.IO.DirectoryInfo dir in di3.GetDirectories())
            {
                dir.Delete(true);
            }
            System.IO.DirectoryInfo di4 = new System.IO.DirectoryInfo("C:\\Riot Games\\League of Legends\\Logs\\Patcher Logs");

            foreach (System.IO.FileInfo file in di4.GetFiles())
            {
                file.Delete();
            }
            foreach (System.IO.DirectoryInfo dir in di4.GetDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}
