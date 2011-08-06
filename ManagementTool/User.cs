using System;
using System.Text;
using System.Windows.Forms;

namespace ManagementTool
{
    public partial class User : Form
    {
        int sizePassword = 10;
        StringBuilder stringbuilder = new StringBuilder();
        Random random = new Random();
        char ch;

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

        private void buttonUserEditSave_Click(object sender, EventArgs e)
        {
            if (checkBoxUserEditDelete.Checked == true)
            {
                MessageBox.Show("Sind Sie sicher, dass Sie den User löschen möchten?", "User Löschen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }

            //wenn keine Rolle gespeicher, speichern nicht möglich!!
        }

        private void checkBoxUserEditGeneratePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUserEditGeneratePassword.Checked == true)
            {
                generateRandomPassword();
                textBoxUserEditNewPassword.Text = stringbuilder.ToString();
                stringbuilder = new StringBuilder();
            }

            if (checkBoxUserEditGeneratePassword.Checked == false)
            {
                textBoxUserEditNewPassword.Text = null;
            }

         }

        private void checkBoxUserAddGeneratePassword_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxUserAddGeneratePassword.Checked == true)
            {
            generateRandomPassword();
            textBoxUserAddPassword.Text = stringbuilder.ToString();
            stringbuilder = new StringBuilder();
            }

            if (checkBoxUserAddGeneratePassword.Checked == false)
            {
                textBoxUserAddPassword.Text = null;
            }
        }

        private string generateRandomPassword()
        {
            //problem: nicht jedesmal neu berechnet sondern hinten angehängt!
                for (int i = 0; i < sizePassword; i++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    stringbuilder.Append(ch);
                }

                return  stringbuilder.ToString().ToLower();
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mtdbDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mtdbDataSet.users);

        }
    }
}
