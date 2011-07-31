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
    public partial class Lager : Form
    {
        public Lager()
        {
            InitializeComponent();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.ToString() == "NodeLieferantEdit")
            {
                tabControl.SelectedIndex = 0;
            }

            if (e.Node.Name.ToString() == "NodeLieferantAdd")
            {
                tabControl.SelectedIndex = 1;
            }

            if (e.Node.Name.ToString() == "NodeArtikelEdit")
            {
                tabControl.SelectedIndex = 2;
            }

            if (e.Node.Name.ToString() == "NodeArtikelAdd")
            {
                tabControl.SelectedIndex = 3;
            }

            if (e.Node.Name.ToString() == "NodeArtikelGruppeEdit")
            {
                tabControl.SelectedIndex = 4;
            }

            if (e.Node.Name.ToString() == "NodeArtikelGruppeAdd")
            {
                tabControl.SelectedIndex = 5;
            }

            if (e.Node.Name.ToString() == "NodeLagerPositionEdit")
            {
                tabControl.SelectedIndex = 6;
            }

            if (e.Node.Name.ToString() == "NodeLagerPositionAdd")
            {
                tabControl.SelectedIndex = 7;
            }
        }

        private void schliessenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSupplierCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSupplierEditSave_Click(object sender, EventArgs e)
        {
            if (checkBoxSupplierEditDelete.Checked == true)
            {
                MessageBox.Show("Sind Sie sicher, dass Sie den Lieferanten löschen möchten?", "Lieferant Löschen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
        }

    }
}
