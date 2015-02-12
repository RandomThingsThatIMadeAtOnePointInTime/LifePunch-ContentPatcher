namespace LifePunch_Content_Autopatcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectionBox = new System.Windows.Forms.ComboBox();
            this.actionButton = new System.Windows.Forms.Button();
            this.folder = new System.Windows.Forms.FolderBrowserDialog();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.folderStatus = new System.Windows.Forms.TextBox();
            this.chooseFolder = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // selectionBox
            // 
            this.selectionBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Content (models/hats/etc)",
            "Bunnyhop Maps",
            "Deathrun Maps",
            "Gungame Maps",
            "Jailbreak Maps"});
            this.selectionBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.selectionBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectionBox.Enabled = false;
            this.selectionBox.FormattingEnabled = true;
            this.selectionBox.Items.AddRange(new object[] {
            "Content",
            "Bunnyhop Maps",
            "Deathrun Maps",
            "Gungame Maps",
            "Jailbreak Maps"});
            this.selectionBox.Location = new System.Drawing.Point(340, 12);
            this.selectionBox.Name = "selectionBox";
            this.selectionBox.Size = new System.Drawing.Size(150, 21);
            this.selectionBox.TabIndex = 3;
            this.selectionBox.SelectedIndexChanged += new System.EventHandler(this.selectionBox_SelectedIndexChanged);
            // 
            // actionButton
            // 
            this.actionButton.Enabled = false;
            this.actionButton.Location = new System.Drawing.Point(496, 12);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(73, 21);
            this.actionButton.TabIndex = 4;
            this.actionButton.Text = "<- Choose";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // folder
            // 
            this.folder.Description = "Select the topmost folder of GarrysMod.                               A \"hl2.exe\"" +
    " program should be here.";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(12, 12);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(242, 20);
            this.pathBox.TabIndex = 0;
            this.pathBox.Text = "Select your topmost GarrysMod folder";
            this.pathBox.TextChanged += new System.EventHandler(this.pathBox_TextChanged);
            // 
            // folderStatus
            // 
            this.folderStatus.BackColor = System.Drawing.SystemColors.Control;
            this.folderStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.folderStatus.Location = new System.Drawing.Point(294, 15);
            this.folderStatus.Name = "folderStatus";
            this.folderStatus.ReadOnly = true;
            this.folderStatus.Size = new System.Drawing.Size(40, 13);
            this.folderStatus.TabIndex = 2;
            this.folderStatus.Text = "SELECT";
            // 
            // chooseFolder
            // 
            this.chooseFolder.Location = new System.Drawing.Point(252, 12);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(36, 20);
            this.chooseFolder.TabIndex = 1;
            this.chooseFolder.Text = "...";
            this.chooseFolder.UseVisualStyleBackColor = true;
            this.chooseFolder.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.logBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(12, 39);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(557, 186);
            this.logBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 240);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.chooseFolder);
            this.Controls.Add(this.folderStatus);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.selectionBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 279);
            this.MinimumSize = new System.Drawing.Size(600, 279);
            this.Name = "Form1";
            this.Text = "LifePunch Content Patcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectionBox;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.FolderBrowserDialog folder;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.TextBox folderStatus;
        private System.Windows.Forms.Button chooseFolder;
        private System.Windows.Forms.ListBox logBox;
    }
}

