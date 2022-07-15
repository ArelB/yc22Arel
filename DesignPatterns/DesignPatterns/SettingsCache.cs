using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /*Singleton
    internal class SettingsCache
    {
        private static SettingsCache Instance;

        public string UserName {get; set;}
        public string Brightness {get; set;}
        public string Contrast {get; set;}
       
        public void printSettingsCache()
        {
            Console.WriteLine("Username is: " + UserName + ", Brightness is: " + Brightness + ", Contrast is: " + Contrast);
        }


        private SettingsCache()
        {

        }

        public static SettingsCache getInstance()
        {
            if (Instance == null)
            {
               Instance = new SettingsCache();
            }
            return Instance;
        }
    } */
}
