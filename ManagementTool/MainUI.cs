using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ManagementTool
{
    public partial class MainUI : Form
    {        
        public MainUI()
        {
            InitializeComponent();
           
        }

        private void buttonCustomer_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = buttonCustomers.ClientRectangle;
            newRectangle.Inflate(-10, -10);
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            buttonCustomers.Region = new System.Drawing.Region(buttonPath);
        }

        private void buttonFibu_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = buttonFibu.ClientRectangle;//
            newRectangle.Inflate(-10, -10);
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            buttonFibu.Region = new System.Drawing.Region(buttonPath); //
        }

        private void buttonLager_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = buttonLager.ClientRectangle;//
            newRectangle.Inflate(-10, -10);
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            buttonLager.Region = new System.Drawing.Region(buttonPath); //
        }

        private void buttonPartner_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = buttonPartner.ClientRectangle;//
            newRectangle.Inflate(-10, -10);
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            buttonPartner.Region = new System.Drawing.Region(buttonPath); //
        }

        private void buttonToDo_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = buttonToDo.ClientRectangle;//
            newRectangle.Inflate(-10, -10);
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            buttonToDo.Region = new System.Drawing.Region(buttonPath); //
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLager_Click(object sender, EventArgs e)
        {
            Lager lagerUI = new Lager();
            lagerUI.Show();
        }

        private void editierenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Roles roleUI = new Roles();
            roleUI.Show();
        }

        private void hinzufügenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Roles roleUI = new Roles();
            roleUI.Show();
        }

        private void editierenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            User userUI = new User();
            userUI.Show();
            //entsprechendes tab anzeigen lassen 
        }

        private void hinzufügenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            User userUI = new User();
            userUI.Show();
            //entsprechendes tab anzeigen lassen 
        }

        private void buttonPartner_Click(object sender, EventArgs e)
        {
            Partners parnterUI = new Partners();
            parnterUI.Show();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            Customer customerUI = new Customer();
            customerUI.Show();
        }

        private void buttonFibu_Click(object sender, EventArgs e)
        {
            Fibu fibuUI = new Fibu();
            fibuUI.Show();
        }

        private void buttonToDo_Click(object sender, EventArgs e)
        {
            ToDos todosUI = new ToDos();
            todosUI.Show();
        }
    }
}
