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
        String valueSex;
        String valueName;
        String valueFirstname;
        String valueEmail;
        String valueUsername;
        String valuePassword;

        public User()
        {
            InitializeComponent();
            //comboBoxUserEditUsers.DataSource = usersTableAdapter.GetData();
            //comboBoxUserEditUsers.DisplayMember = "us_name";
            //comboBoxUserEditUsers.ValueMember = "us_name";
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

            //wenn keine Rolle gespeichert, speichern nicht möglich!!
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
            if (checkBoxUserAddGeneratePassword.Checked == true)
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

            return stringbuilder.ToString().ToLower();
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mtdbDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.mtdbDataSet.users);

        }

        private void buttonUserAddSave_Click(object sender, EventArgs e)
        {
            getValues();

            if (valueSex != null && valueName != "" && valueFirstname != "" && valueEmail != "" && valueUsername != "" && valuePassword != "")
            {
                String sqlInsertUser = "INSERT INTO mtdb.users (us_sex, us_name, us_firstname, us_username, us_password, us_deleted, us_date_inserted, us_us_inserted) values ('"+valueSex+"','" + valueName + "', '" + valueFirstname + "','us_username',     '"+valuePassword+"',    0, now(),1),";
                //User speichern, User auf eindeutigkeit prüfen

                String sqlInsertGetUserID = "SELECT us_id from mtdb.users where us_name='"+valueName+"' and us_firstname='"+valueFirstname+"' and us_username='"+valueUsername+"' and us_password='"+valuePassword+"'";
                int userId = 0;//resultat von obiger zeile

                String sqlInserUserEmail = "INSERT INTO  mtdb.www (www_us_id, www_Type, www_value, www_deleted, www_date_inserted, www_us_inserted) values  ("+userId+",4, '" + valueEmail + "',0, now(),1)";

                MessageBox.Show("User erfolgreich gespeichert", "User");
                Close();
            }
            else
            {

                if (comboBoxUserAddSex.SelectedText == null)
                {
                    valueSex = "Anrede";
                }

                if (textBoxUserAddName.Text == "")
                {
                    valueName = "Name";
                }

                if (textBoxUserAddFirstname.Text == "")
                {
                    valueFirstname = "Vorname";
                }

                if (textBoxUserAddEmail.Text == "")
                {
                    valueEmail = "E-Mail";
                }

                if (textBoxUserAddPassword.Text == "")
                {
                    valuePassword = "Passwort";
                }

                MessageBox.Show("Folgende Felder müssen noch ausgefüllt werden: " + valueSex + " " + valueName + " " + valueFirstname + " " + valueEmail + " " + valuePassword, "User hinzufügen nicht möglich");
            }
        }

        private void generateUsername_Click(object sender, EventArgs e)
        {
            getValues();
            valueUsername = valueFirstname.Substring(0,3) + valueName.Substring(0,3);
            textBoxUserAddUsername.Text = valueUsername;
        }

        private void getValues()
        {
            valueSex = comboBoxUserAddSex.SelectedText;
            valueName = textBoxUserAddName.Text.ToString();
            valueFirstname = textBoxUserAddFirstname.Text.ToString();
            valueEmail = textBoxUserAddEmail.Text;
            valueUsername = textBoxUserAddUsername.Text;
            valuePassword = textBoxUserAddPassword.Text;
        }

    }
}
