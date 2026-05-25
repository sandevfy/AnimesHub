using System;
using System.Collections.Generic;
using System.Text;

namespace AnimesHub
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());

        }
    }
}
