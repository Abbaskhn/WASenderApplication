using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WASender.Models;

namespace WASender
{
    public  class _Config
    {
      
        public static void KillChromeDriverProcess()
        {
            if (Utils.Driver != null)
            {
                try
                {
                    Utils.Driver.Close();
                    Utils.Driver.Dispose();
                    Utils.Driver.Quit();
                    Utils.Driver = null;
                }
                catch (Exception ex)
                {
                }
            }
            foreach (var process in Process.GetProcessesByName("chromedriver"))
            {
                try
                {
                    process.Kill();
                }
                catch (Exception ex)
                {

                }
            }


        }

    }
}
