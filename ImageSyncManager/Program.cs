using ImageSyncManager.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSyncManager
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProjectSyncForm());
        }

        ProjectSyncManagerBAL projSyncManagerBAL = new ProjectSyncManagerBAL();

        public string AddNewProjectDetails(string path)
        {
            int numberOfProjects = projSyncManagerBAL.NumberOfProjects(path);

            if(numberOfProjects > 0)
            {
                return projSyncManagerBAL.AddProjectDetails(path);
            }
            else
            {
                return "Operation Failed";
            }
        }
    }
}
