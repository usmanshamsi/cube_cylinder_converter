using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CCSConvert
{
    static class Program
    {
        // >>> ABOUT, DISCLAIMER AND REFERENCES



        //public static string disclaimer = "This program has been carefully designed to produce correct results as " +
        //                                            "per the provided references. The program has " +
        //                                            "been tested on design examples from reference books and much effort " +
        //                                            "has been made to make it as correct as possible. However, the " +
        //                                            "user is completely responsible in all respects to judge the " +
        //                                            "accuracy of the results before relying on and taking further " +
        //                                            "decisions based on these results. The programmer, advertiser, " +
        //                                            "distributor or anybody else involved in the production and " +
        //                                            "distribution of the program takes no responsibility, in any " +
        //                                            "form, for any loss or harm to anybody due to any incorrect result " +
        //                                            "or any misinterpretation of the results.";

        //public static string references = "1-\tBook:\tProperties of Concrete\r\n" +
        //                                    "\tAuthor:\tA M Neville\r\n" +
        //                                    "\tEdition:\tSecond Edition\r\n" +
        //                                    "\tChapter:\t8\r\n"+
        //                                    "\tTable:\t8.2\r\n";
        // <<< ABOUT




        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }


    }
}
