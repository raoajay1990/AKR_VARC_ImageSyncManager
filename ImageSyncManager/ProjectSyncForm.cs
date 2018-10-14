using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSyncManager
{
    public partial class ProjectSyncForm : Form
    {
        public ProjectSyncForm()
        {
            InitializeComponent();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Program obj = new Program();
            lblResult.Text = obj.AddNewProjectDetails(txtSyncPath.Text);
        }
    }
}
