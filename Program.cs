﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MultiFaceRec
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmPrincipal());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Startup Issue");
            }
        }
    }
}
