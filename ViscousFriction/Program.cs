﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ViscousFriction
{ 

    static class Program
    {
        public static bool isPaused = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
