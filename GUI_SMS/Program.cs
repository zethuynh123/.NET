﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_SMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI_Menu());
        }
    }
    class mySave
    {
        static Boolean kt = true;
        public static Boolean KT
        {
            get
            {
                return kt;
            }
            set
            {
                kt = value;
            }
        }
    }
}
