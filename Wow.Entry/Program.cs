using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wow.Entry.Alliance.Dwarf;

namespace Wow.Entry
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)

        {
            
            //Factory factory = new Factory();
            //Atack dwarfwarrior = factory.atackmethod(FactoryDwarfwarrior.dwarfwarrior);
            //dwarfwarrior.atack();
            //Console.Read();
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginScreen());
        }
        
        
    }
}
