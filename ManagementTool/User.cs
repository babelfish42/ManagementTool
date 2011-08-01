using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ManagementTool
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.ToString() == "NodeUserEdit")
            {
                tabControlUsers.SelectedIndex = 0;
            }

            if (e.Node.Name.ToString() == "NodeUserAdd")
            {
                tabControlUsers.SelectedIndex = 1;
            }
        }

        private void schliessenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
