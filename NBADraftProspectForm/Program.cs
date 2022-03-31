using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NBADraftProspectForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<PlayerReport> players = new List<PlayerReport>();
            PlayerReportController playerReportController = new PlayerReportController(players);
            Application.Run(new frmPlayerInfo(playerReportController));
        }
    }
}
