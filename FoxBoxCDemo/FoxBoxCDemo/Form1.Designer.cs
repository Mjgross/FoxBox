namespace FoxBoxCDemo
{
    partial class Form1
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
            this.Profiles = new System.Windows.Forms.Label();
            this.Applications = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.ProfileBox = new System.Windows.Forms.ListBox();
            this.ApplicationBox = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.Button();
            this.removeApp = new System.Windows.Forms.Button();
            this.createProf = new System.Windows.Forms.Button();
            this.profileNameCreate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Profiles
            // 
            this.Profiles.AutoSize = true;
            this.Profiles.Location = new System.Drawing.Point(12, 74);
            this.Profiles.Name = "Profiles";
            this.Profiles.Size = new System.Drawing.Size(44, 13);
            this.Profiles.TabIndex = 1;
            this.Profiles.Text = "Profiles:";
            this.Profiles.Click += new System.EventHandler(this.label1_Click);
            // 
            // Applications
            // 
            this.Applications.AutoSize = true;
            this.Applications.Location = new System.Drawing.Point(247, 74);
            this.Applications.Name = "Applications";
            this.Applications.Size = new System.Drawing.Size(67, 13);
            this.Applications.TabIndex = 2;
            this.Applications.Text = "Applications:";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(150, 250);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ProfileBox
            // 
            this.ProfileBox.FormattingEnabled = true;
            this.ProfileBox.Location = new System.Drawing.Point(12, 90);
            this.ProfileBox.Name = "ProfileBox";
            this.ProfileBox.Size = new System.Drawing.Size(120, 147);
            this.ProfileBox.TabIndex = 4;
            this.ProfileBox.SelectedIndexChanged += new System.EventHandler(this.ProfileBox_SelectedIndexChanged);
            // 
            // ApplicationBox
            // 
            this.ApplicationBox.FormattingEnabled = true;
            this.ApplicationBox.Items.AddRange(new object[] {
            " "});
            this.ApplicationBox.Location = new System.Drawing.Point(250, 90);
            this.ApplicationBox.Name = "ApplicationBox";
            this.ApplicationBox.Size = new System.Drawing.Size(120, 147);
            this.ApplicationBox.TabIndex = 5;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(150, 64);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(75, 23);
            this.openFile.TabIndex = 6;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click_1);
            // 
            // removeApp
            // 
            this.removeApp.Location = new System.Drawing.Point(276, 250);
            this.removeApp.Name = "removeApp";
            this.removeApp.Size = new System.Drawing.Size(75, 23);
            this.removeApp.TabIndex = 7;
            this.removeApp.Text = "Remove File";
            this.removeApp.UseVisualStyleBackColor = true;
            this.removeApp.Click += new System.EventHandler(this.removeApp_Click);
            // 
            // createProf
            // 
            this.createProf.Location = new System.Drawing.Point(150, 23);
            this.createProf.Name = "createProf";
            this.createProf.Size = new System.Drawing.Size(75, 23);
            this.createProf.TabIndex = 8;
            this.createProf.Text = "Create Profile";
            this.createProf.UseVisualStyleBackColor = true;
            this.createProf.Click += new System.EventHandler(this.createProf_Click);
            // 
            // profileNameCreate
            // 
            this.profileNameCreate.Location = new System.Drawing.Point(15, 23);
            this.profileNameCreate.Name = "profileNameCreate";
            this.profileNameCreate.Size = new System.Drawing.Size(117, 20);
            this.profileNameCreate.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Remove Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.profileNameCreate);
            this.Controls.Add(this.createProf);
            this.Controls.Add(this.removeApp);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.ApplicationBox);
            this.Controls.Add(this.ProfileBox);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Applications);
            this.Controls.Add(this.Profiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Profiles;
        private System.Windows.Forms.Label Applications;
        private System.Windows.Forms.Button Save;
        public System.Windows.Forms.ListBox ProfileBox;
        public System.Windows.Forms.ListBox ApplicationBox;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button removeApp;
        private System.Windows.Forms.Button createProf;
        public System.Windows.Forms.TextBox profileNameCreate;
        private System.Windows.Forms.Button button1;
    }
}

