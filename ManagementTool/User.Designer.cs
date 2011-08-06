namespace ManagementTool
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Editieren");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Erstellen");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControlUsers = new System.Windows.Forms.TabControl();
            this.tabPageUserEdit = new System.Windows.Forms.TabPage();
            this.buttonUserEditSave = new System.Windows.Forms.Button();
            this.checkBoxUserEditDelete = new System.Windows.Forms.CheckBox();
            this.textBoxUserEditNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserEditOldPassword = new System.Windows.Forms.TextBox();
            this.labelUserEditNewPassword = new System.Windows.Forms.Label();
            this.labelUserEditOldPassword = new System.Windows.Forms.Label();
            this.checkBoxUserEditGeneratePassword = new System.Windows.Forms.CheckBox();
            this.comboBoxUserEditRole = new System.Windows.Forms.ComboBox();
            this.textBoxUserEditPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserEditName = new System.Windows.Forms.TextBox();
            this.textBoxUserEditFirstname = new System.Windows.Forms.TextBox();
            this.labelUserEditRole = new System.Windows.Forms.Label();
            this.labelUserEditEmail = new System.Windows.Forms.Label();
            this.labelUserEditFirstname = new System.Windows.Forms.Label();
            this.labelUserEditName = new System.Windows.Forms.Label();
            this.labelUserEditSex = new System.Windows.Forms.Label();
            this.comboBoxUserEditSex = new System.Windows.Forms.ComboBox();
            this.labelUserEditUser = new System.Windows.Forms.Label();
            this.comboBoxUserEditUsers = new System.Windows.Forms.ComboBox();
            this.tabPageUserAdd = new System.Windows.Forms.TabPage();
            this.buttonUserAddSave = new System.Windows.Forms.Button();
            this.checkBoxUserAddGeneratePassword = new System.Windows.Forms.CheckBox();
            this.textBoxUserAddPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserAddEmail = new System.Windows.Forms.TextBox();
            this.textBoxUserAddName = new System.Windows.Forms.TextBox();
            this.textBoxUserAddFirstname = new System.Windows.Forms.TextBox();
            this.comboBoxUserAddSex = new System.Windows.Forms.ComboBox();
            this.labelUserAddSex = new System.Windows.Forms.Label();
            this.labelUserAddPassword = new System.Windows.Forms.Label();
            this.labelUserAddEmail = new System.Windows.Forms.Label();
            this.labelUserAddName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserAddRole = new System.Windows.Forms.Label();
            this.comboBoxUserAddRole = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schliessenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxUserAddSendPasswordEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxUserEditSendPasswordEmail = new System.Windows.Forms.CheckBox();
            this.mtdbDataSet = new ManagementTool.mtdbDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new ManagementTool.mtdbDataSetTableAdapters.usersTableAdapter();
            this.tabControlUsers.SuspendLayout();
            this.tabPageUserEdit.SuspendLayout();
            this.tabPageUserAdd.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeView1.Location = new System.Drawing.Point(14, 41);
            this.treeView1.Name = "treeView1";
            treeNode13.Name = "NodeUserEdit";
            treeNode13.Text = "Editieren";
            treeNode14.Name = "NodeUserAdd";
            treeNode14.Text = "Erstellen";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControlUsers
            // 
            this.tabControlUsers.Controls.Add(this.tabPageUserEdit);
            this.tabControlUsers.Controls.Add(this.tabPageUserAdd);
            this.tabControlUsers.Location = new System.Drawing.Point(155, 41);
            this.tabControlUsers.Name = "tabControlUsers";
            this.tabControlUsers.SelectedIndex = 0;
            this.tabControlUsers.Size = new System.Drawing.Size(507, 336);
            this.tabControlUsers.TabIndex = 1;
            // 
            // tabPageUserEdit
            // 
            this.tabPageUserEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageUserEdit.Controls.Add(this.checkBoxUserEditSendPasswordEmail);
            this.tabPageUserEdit.Controls.Add(this.buttonUserEditSave);
            this.tabPageUserEdit.Controls.Add(this.checkBoxUserEditDelete);
            this.tabPageUserEdit.Controls.Add(this.textBoxUserEditNewPassword);
            this.tabPageUserEdit.Controls.Add(this.textBoxUserEditOldPassword);
            this.tabPageUserEdit.Controls.Add(this.labelUserEditNewPassword);
            this.tabPageUserEdit.Controls.Add(this.labelUserEditOldPassword);
            this.tabPageUserEdit.Controls.Add(this.checkBoxUserEditGeneratePassword);
            this.tabPageUserEdit.Controls.Add(this.comboBoxUserEditRole);
            this.tabPageUserEdit.Controls.Add(this.textBoxUserEditPassword);
            this.tabPageUserEdit.Controls.Add(this.textBoxUserEditName);
            this.tabPageUserEdit.Controls.Add(this.textBoxUserEditFirstname);
            this.tabPageUserEdit.Controls.Add(this.labelUserEditRole);
            this.tabPageUserEdit.Controls.Add(this.labelUserEditEmail);
            this.tabPageUserEdit.Controls.Add(this.labelUserEditFirstname);
            this.tabPageUserEdit.Controls.Add(this.labelUserEditName);
            this.tabPageUserEdit.Controls.Add(this.labelUserEditSex);
            this.tabPageUserEdit.Controls.Add(this.comboBoxUserEditSex);
            this.tabPageUserEdit.Controls.Add(this.labelUserEditUser);
            this.tabPageUserEdit.Controls.Add(this.comboBoxUserEditUsers);
            this.tabPageUserEdit.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserEdit.Name = "tabPageUserEdit";
            this.tabPageUserEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserEdit.Size = new System.Drawing.Size(499, 310);
            this.tabPageUserEdit.TabIndex = 0;
            this.tabPageUserEdit.Text = "Editieren";
            // 
            // buttonUserEditSave
            // 
            this.buttonUserEditSave.Location = new System.Drawing.Point(386, 281);
            this.buttonUserEditSave.Name = "buttonUserEditSave";
            this.buttonUserEditSave.Size = new System.Drawing.Size(107, 23);
            this.buttonUserEditSave.TabIndex = 18;
            this.buttonUserEditSave.Text = "Speichern";
            this.buttonUserEditSave.UseVisualStyleBackColor = true;
            this.buttonUserEditSave.Click += new System.EventHandler(this.buttonUserEditSave_Click);
            // 
            // checkBoxUserEditDelete
            // 
            this.checkBoxUserEditDelete.AutoSize = true;
            this.checkBoxUserEditDelete.Location = new System.Drawing.Point(37, 270);
            this.checkBoxUserEditDelete.Name = "checkBoxUserEditDelete";
            this.checkBoxUserEditDelete.Size = new System.Drawing.Size(88, 17);
            this.checkBoxUserEditDelete.TabIndex = 17;
            this.checkBoxUserEditDelete.Text = "User löschen";
            this.checkBoxUserEditDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxUserEditNewPassword
            // 
            this.textBoxUserEditNewPassword.Location = new System.Drawing.Point(128, 179);
            this.textBoxUserEditNewPassword.Name = "textBoxUserEditNewPassword";
            this.textBoxUserEditNewPassword.Size = new System.Drawing.Size(127, 20);
            this.textBoxUserEditNewPassword.TabIndex = 16;
            this.textBoxUserEditNewPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUserEditOldPassword
            // 
            this.textBoxUserEditOldPassword.Location = new System.Drawing.Point(128, 148);
            this.textBoxUserEditOldPassword.Name = "textBoxUserEditOldPassword";
            this.textBoxUserEditOldPassword.Size = new System.Drawing.Size(127, 20);
            this.textBoxUserEditOldPassword.TabIndex = 15;
            this.textBoxUserEditOldPassword.UseSystemPasswordChar = true;
            // 
            // labelUserEditNewPassword
            // 
            this.labelUserEditNewPassword.AutoSize = true;
            this.labelUserEditNewPassword.Location = new System.Drawing.Point(34, 186);
            this.labelUserEditNewPassword.Name = "labelUserEditNewPassword";
            this.labelUserEditNewPassword.Size = new System.Drawing.Size(84, 13);
            this.labelUserEditNewPassword.TabIndex = 14;
            this.labelUserEditNewPassword.Text = "Neues Passwort";
            // 
            // labelUserEditOldPassword
            // 
            this.labelUserEditOldPassword.AutoSize = true;
            this.labelUserEditOldPassword.Location = new System.Drawing.Point(34, 151);
            this.labelUserEditOldPassword.Name = "labelUserEditOldPassword";
            this.labelUserEditOldPassword.Size = new System.Drawing.Size(76, 13);
            this.labelUserEditOldPassword.TabIndex = 13;
            this.labelUserEditOldPassword.Text = "Altes Passwort";
            // 
            // checkBoxUserEditGeneratePassword
            // 
            this.checkBoxUserEditGeneratePassword.AutoSize = true;
            this.checkBoxUserEditGeneratePassword.Location = new System.Drawing.Point(286, 185);
            this.checkBoxUserEditGeneratePassword.Name = "checkBoxUserEditGeneratePassword";
            this.checkBoxUserEditGeneratePassword.Size = new System.Drawing.Size(116, 17);
            this.checkBoxUserEditGeneratePassword.TabIndex = 12;
            this.checkBoxUserEditGeneratePassword.Text = "generiere Passwort";
            this.checkBoxUserEditGeneratePassword.UseVisualStyleBackColor = true;
            this.checkBoxUserEditGeneratePassword.CheckedChanged += new System.EventHandler(this.checkBoxUserEditGeneratePassword_CheckedChanged);
            // 
            // comboBoxUserEditRole
            // 
            this.comboBoxUserEditRole.FormattingEnabled = true;
            this.comboBoxUserEditRole.Location = new System.Drawing.Point(128, 212);
            this.comboBoxUserEditRole.Name = "comboBoxUserEditRole";
            this.comboBoxUserEditRole.Size = new System.Drawing.Size(127, 21);
            this.comboBoxUserEditRole.TabIndex = 11;
            // 
            // textBoxUserEditPassword
            // 
            this.textBoxUserEditPassword.Location = new System.Drawing.Point(128, 118);
            this.textBoxUserEditPassword.Name = "textBoxUserEditPassword";
            this.textBoxUserEditPassword.Size = new System.Drawing.Size(127, 20);
            this.textBoxUserEditPassword.TabIndex = 10;
            // 
            // textBoxUserEditName
            // 
            this.textBoxUserEditName.Location = new System.Drawing.Point(328, 82);
            this.textBoxUserEditName.Name = "textBoxUserEditName";
            this.textBoxUserEditName.Size = new System.Drawing.Size(127, 20);
            this.textBoxUserEditName.TabIndex = 9;
            // 
            // textBoxUserEditFirstname
            // 
            this.textBoxUserEditFirstname.Location = new System.Drawing.Point(128, 82);
            this.textBoxUserEditFirstname.Name = "textBoxUserEditFirstname";
            this.textBoxUserEditFirstname.Size = new System.Drawing.Size(127, 20);
            this.textBoxUserEditFirstname.TabIndex = 8;
            // 
            // labelUserEditRole
            // 
            this.labelUserEditRole.AutoSize = true;
            this.labelUserEditRole.Location = new System.Drawing.Point(34, 220);
            this.labelUserEditRole.Name = "labelUserEditRole";
            this.labelUserEditRole.Size = new System.Drawing.Size(31, 13);
            this.labelUserEditRole.TabIndex = 7;
            this.labelUserEditRole.Text = "Rolle";
            // 
            // labelUserEditEmail
            // 
            this.labelUserEditEmail.AutoSize = true;
            this.labelUserEditEmail.Location = new System.Drawing.Point(34, 118);
            this.labelUserEditEmail.Name = "labelUserEditEmail";
            this.labelUserEditEmail.Size = new System.Drawing.Size(36, 13);
            this.labelUserEditEmail.TabIndex = 6;
            this.labelUserEditEmail.Text = "E-Mail";
            // 
            // labelUserEditFirstname
            // 
            this.labelUserEditFirstname.AutoSize = true;
            this.labelUserEditFirstname.Location = new System.Drawing.Point(34, 85);
            this.labelUserEditFirstname.Name = "labelUserEditFirstname";
            this.labelUserEditFirstname.Size = new System.Drawing.Size(49, 13);
            this.labelUserEditFirstname.TabIndex = 5;
            this.labelUserEditFirstname.Text = "Vorname";
            // 
            // labelUserEditName
            // 
            this.labelUserEditName.AutoSize = true;
            this.labelUserEditName.Location = new System.Drawing.Point(276, 85);
            this.labelUserEditName.Name = "labelUserEditName";
            this.labelUserEditName.Size = new System.Drawing.Size(35, 13);
            this.labelUserEditName.TabIndex = 4;
            this.labelUserEditName.Text = "Name";
            // 
            // labelUserEditSex
            // 
            this.labelUserEditSex.AutoSize = true;
            this.labelUserEditSex.Location = new System.Drawing.Point(34, 54);
            this.labelUserEditSex.Name = "labelUserEditSex";
            this.labelUserEditSex.Size = new System.Drawing.Size(41, 13);
            this.labelUserEditSex.TabIndex = 3;
            this.labelUserEditSex.Text = "Anrede";
            // 
            // comboBoxUserEditSex
            // 
            this.comboBoxUserEditSex.FormattingEnabled = true;
            this.comboBoxUserEditSex.Location = new System.Drawing.Point(128, 51);
            this.comboBoxUserEditSex.Name = "comboBoxUserEditSex";
            this.comboBoxUserEditSex.Size = new System.Drawing.Size(65, 21);
            this.comboBoxUserEditSex.TabIndex = 2;
            // 
            // labelUserEditUser
            // 
            this.labelUserEditUser.AutoSize = true;
            this.labelUserEditUser.Location = new System.Drawing.Point(34, 18);
            this.labelUserEditUser.Name = "labelUserEditUser";
            this.labelUserEditUser.Size = new System.Drawing.Size(29, 13);
            this.labelUserEditUser.TabIndex = 1;
            this.labelUserEditUser.Text = "User";
            // 
            // comboBoxUserEditUsers
            // 
            this.comboBoxUserEditUsers.FormattingEnabled = true;
            this.comboBoxUserEditUsers.Location = new System.Drawing.Point(128, 15);
            this.comboBoxUserEditUsers.Name = "comboBoxUserEditUsers";
            this.comboBoxUserEditUsers.Size = new System.Drawing.Size(127, 21);
            this.comboBoxUserEditUsers.TabIndex = 0;
            // 
            // tabPageUserAdd
            // 
            this.tabPageUserAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageUserAdd.Controls.Add(this.checkBoxUserAddSendPasswordEmail);
            this.tabPageUserAdd.Controls.Add(this.buttonUserAddSave);
            this.tabPageUserAdd.Controls.Add(this.checkBoxUserAddGeneratePassword);
            this.tabPageUserAdd.Controls.Add(this.textBoxUserAddPassword);
            this.tabPageUserAdd.Controls.Add(this.textBoxUserAddEmail);
            this.tabPageUserAdd.Controls.Add(this.textBoxUserAddName);
            this.tabPageUserAdd.Controls.Add(this.textBoxUserAddFirstname);
            this.tabPageUserAdd.Controls.Add(this.comboBoxUserAddSex);
            this.tabPageUserAdd.Controls.Add(this.labelUserAddSex);
            this.tabPageUserAdd.Controls.Add(this.labelUserAddPassword);
            this.tabPageUserAdd.Controls.Add(this.labelUserAddEmail);
            this.tabPageUserAdd.Controls.Add(this.labelUserAddName);
            this.tabPageUserAdd.Controls.Add(this.label1);
            this.tabPageUserAdd.Controls.Add(this.labelUserAddRole);
            this.tabPageUserAdd.Controls.Add(this.comboBoxUserAddRole);
            this.tabPageUserAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageUserAdd.Name = "tabPageUserAdd";
            this.tabPageUserAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserAdd.Size = new System.Drawing.Size(499, 310);
            this.tabPageUserAdd.TabIndex = 1;
            this.tabPageUserAdd.Text = "Erstellen";
            // 
            // buttonUserAddSave
            // 
            this.buttonUserAddSave.Location = new System.Drawing.Point(386, 281);
            this.buttonUserAddSave.Name = "buttonUserAddSave";
            this.buttonUserAddSave.Size = new System.Drawing.Size(107, 23);
            this.buttonUserAddSave.TabIndex = 14;
            this.buttonUserAddSave.Text = "Speichern";
            this.buttonUserAddSave.UseVisualStyleBackColor = true;
            // 
            // checkBoxUserAddGeneratePassword
            // 
            this.checkBoxUserAddGeneratePassword.AutoSize = true;
            this.checkBoxUserAddGeneratePassword.Location = new System.Drawing.Point(242, 117);
            this.checkBoxUserAddGeneratePassword.Name = "checkBoxUserAddGeneratePassword";
            this.checkBoxUserAddGeneratePassword.Size = new System.Drawing.Size(116, 17);
            this.checkBoxUserAddGeneratePassword.TabIndex = 13;
            this.checkBoxUserAddGeneratePassword.Text = "generiere Passwort";
            this.checkBoxUserAddGeneratePassword.UseVisualStyleBackColor = true;
            this.checkBoxUserAddGeneratePassword.CheckedChanged += new System.EventHandler(this.checkBoxUserAddGeneratePassword_CheckedChanged);
            // 
            // textBoxUserAddPassword
            // 
            this.textBoxUserAddPassword.Location = new System.Drawing.Point(92, 115);
            this.textBoxUserAddPassword.Name = "textBoxUserAddPassword";
            this.textBoxUserAddPassword.Size = new System.Drawing.Size(127, 20);
            this.textBoxUserAddPassword.TabIndex = 12;
            this.textBoxUserAddPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUserAddEmail
            // 
            this.textBoxUserAddEmail.Location = new System.Drawing.Point(92, 84);
            this.textBoxUserAddEmail.Name = "textBoxUserAddEmail";
            this.textBoxUserAddEmail.Size = new System.Drawing.Size(127, 20);
            this.textBoxUserAddEmail.TabIndex = 11;
            // 
            // textBoxUserAddName
            // 
            this.textBoxUserAddName.Location = new System.Drawing.Point(294, 51);
            this.textBoxUserAddName.Name = "textBoxUserAddName";
            this.textBoxUserAddName.Size = new System.Drawing.Size(127, 20);
            this.textBoxUserAddName.TabIndex = 10;
            // 
            // textBoxUserAddFirstname
            // 
            this.textBoxUserAddFirstname.Location = new System.Drawing.Point(92, 51);
            this.textBoxUserAddFirstname.Name = "textBoxUserAddFirstname";
            this.textBoxUserAddFirstname.Size = new System.Drawing.Size(127, 20);
            this.textBoxUserAddFirstname.TabIndex = 9;
            // 
            // comboBoxUserAddSex
            // 
            this.comboBoxUserAddSex.FormattingEnabled = true;
            this.comboBoxUserAddSex.Items.AddRange(new object[] {
            "Frau",
            "Herr"});
            this.comboBoxUserAddSex.Location = new System.Drawing.Point(92, 18);
            this.comboBoxUserAddSex.Name = "comboBoxUserAddSex";
            this.comboBoxUserAddSex.Size = new System.Drawing.Size(65, 21);
            this.comboBoxUserAddSex.TabIndex = 8;
            // 
            // labelUserAddSex
            // 
            this.labelUserAddSex.AutoSize = true;
            this.labelUserAddSex.Location = new System.Drawing.Point(33, 18);
            this.labelUserAddSex.Name = "labelUserAddSex";
            this.labelUserAddSex.Size = new System.Drawing.Size(41, 13);
            this.labelUserAddSex.TabIndex = 7;
            this.labelUserAddSex.Text = "Anrede";
            // 
            // labelUserAddPassword
            // 
            this.labelUserAddPassword.AutoSize = true;
            this.labelUserAddPassword.Location = new System.Drawing.Point(34, 118);
            this.labelUserAddPassword.Name = "labelUserAddPassword";
            this.labelUserAddPassword.Size = new System.Drawing.Size(50, 13);
            this.labelUserAddPassword.TabIndex = 6;
            this.labelUserAddPassword.Text = "Passwort";
            // 
            // labelUserAddEmail
            // 
            this.labelUserAddEmail.AutoSize = true;
            this.labelUserAddEmail.Location = new System.Drawing.Point(33, 84);
            this.labelUserAddEmail.Name = "labelUserAddEmail";
            this.labelUserAddEmail.Size = new System.Drawing.Size(36, 13);
            this.labelUserAddEmail.TabIndex = 4;
            this.labelUserAddEmail.Text = "E-Mail";
            // 
            // labelUserAddName
            // 
            this.labelUserAddName.AutoSize = true;
            this.labelUserAddName.Location = new System.Drawing.Point(239, 51);
            this.labelUserAddName.Name = "labelUserAddName";
            this.labelUserAddName.Size = new System.Drawing.Size(35, 13);
            this.labelUserAddName.TabIndex = 3;
            this.labelUserAddName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vorname";
            // 
            // labelUserAddRole
            // 
            this.labelUserAddRole.AutoSize = true;
            this.labelUserAddRole.Location = new System.Drawing.Point(33, 156);
            this.labelUserAddRole.Name = "labelUserAddRole";
            this.labelUserAddRole.Size = new System.Drawing.Size(31, 13);
            this.labelUserAddRole.TabIndex = 1;
            this.labelUserAddRole.Text = "Rolle";
            // 
            // comboBoxUserAddRole
            // 
            this.comboBoxUserAddRole.FormattingEnabled = true;
            this.comboBoxUserAddRole.Location = new System.Drawing.Point(92, 148);
            this.comboBoxUserAddRole.Name = "comboBoxUserAddRole";
            this.comboBoxUserAddRole.Size = new System.Drawing.Size(127, 21);
            this.comboBoxUserAddRole.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schliessenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // schliessenToolStripMenuItem
            // 
            this.schliessenToolStripMenuItem.Name = "schliessenToolStripMenuItem";
            this.schliessenToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.schliessenToolStripMenuItem.Text = "Schliessen";
            this.schliessenToolStripMenuItem.Click += new System.EventHandler(this.schliessenToolStripMenuItem_Click);
            // 
            // checkBoxUserAddSendPasswordEmail
            // 
            this.checkBoxUserAddSendPasswordEmail.AutoSize = true;
            this.checkBoxUserAddSendPasswordEmail.Location = new System.Drawing.Point(242, 148);
            this.checkBoxUserAddSendPasswordEmail.Name = "checkBoxUserAddSendPasswordEmail";
            this.checkBoxUserAddSendPasswordEmail.Size = new System.Drawing.Size(152, 17);
            this.checkBoxUserAddSendPasswordEmail.TabIndex = 15;
            this.checkBoxUserAddSendPasswordEmail.Text = "sende Password via e-Mail";
            this.checkBoxUserAddSendPasswordEmail.UseVisualStyleBackColor = true;
            // 
            // checkBoxUserEditSendPasswordEmail
            // 
            this.checkBoxUserEditSendPasswordEmail.AutoSize = true;
            this.checkBoxUserEditSendPasswordEmail.Location = new System.Drawing.Point(286, 212);
            this.checkBoxUserEditSendPasswordEmail.Name = "checkBoxUserEditSendPasswordEmail";
            this.checkBoxUserEditSendPasswordEmail.Size = new System.Drawing.Size(152, 17);
            this.checkBoxUserEditSendPasswordEmail.TabIndex = 19;
            this.checkBoxUserEditSendPasswordEmail.Text = "sende Password via e-Mail";
            this.checkBoxUserEditSendPasswordEmail.UseVisualStyleBackColor = true;
            // 
            // mtdbDataSet
            // 
            this.mtdbDataSet.DataSetName = "mtdbDataSet";
            this.mtdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.mtdbDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(674, 407);
            this.Controls.Add(this.tabControlUsers);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.tabControlUsers.ResumeLayout(false);
            this.tabPageUserEdit.ResumeLayout(false);
            this.tabPageUserEdit.PerformLayout();
            this.tabPageUserAdd.ResumeLayout(false);
            this.tabPageUserAdd.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControlUsers;
        private System.Windows.Forms.TabPage tabPageUserEdit;
        private System.Windows.Forms.TabPage tabPageUserAdd;
        private System.Windows.Forms.ComboBox comboBoxUserAddSex;
        private System.Windows.Forms.Label labelUserAddSex;
        private System.Windows.Forms.Label labelUserAddPassword;
        private System.Windows.Forms.Label labelUserAddEmail;
        private System.Windows.Forms.Label labelUserAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserAddRole;
        private System.Windows.Forms.ComboBox comboBoxUserAddRole;
        private System.Windows.Forms.TextBox textBoxUserAddFirstname;
        private System.Windows.Forms.TextBox textBoxUserAddName;
        private System.Windows.Forms.TextBox textBoxUserAddEmail;
        private System.Windows.Forms.CheckBox checkBoxUserAddGeneratePassword;
        private System.Windows.Forms.TextBox textBoxUserAddPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schliessenToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxUserEditGeneratePassword;
        private System.Windows.Forms.ComboBox comboBoxUserEditRole;
        private System.Windows.Forms.TextBox textBoxUserEditPassword;
        private System.Windows.Forms.TextBox textBoxUserEditName;
        private System.Windows.Forms.TextBox textBoxUserEditFirstname;
        private System.Windows.Forms.Label labelUserEditRole;
        private System.Windows.Forms.Label labelUserEditEmail;
        private System.Windows.Forms.Label labelUserEditFirstname;
        private System.Windows.Forms.Label labelUserEditName;
        private System.Windows.Forms.Label labelUserEditSex;
        private System.Windows.Forms.ComboBox comboBoxUserEditSex;
        private System.Windows.Forms.Label labelUserEditUser;
        private System.Windows.Forms.ComboBox comboBoxUserEditUsers;
        private System.Windows.Forms.TextBox textBoxUserEditNewPassword;
        private System.Windows.Forms.TextBox textBoxUserEditOldPassword;
        private System.Windows.Forms.Label labelUserEditNewPassword;
        private System.Windows.Forms.Label labelUserEditOldPassword;
        private System.Windows.Forms.CheckBox checkBoxUserEditDelete;
        private System.Windows.Forms.Button buttonUserEditSave;
        private System.Windows.Forms.Button buttonUserAddSave;
        private System.Windows.Forms.CheckBox checkBoxUserAddSendPasswordEmail;
        private System.Windows.Forms.CheckBox checkBoxUserEditSendPasswordEmail;
        private mtdbDataSet mtdbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private mtdbDataSetTableAdapters.usersTableAdapter usersTableAdapter;
    }
}