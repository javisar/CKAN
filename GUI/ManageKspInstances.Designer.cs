﻿namespace CKAN
{
    partial class ManageKspInstances
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "dsadsa",
            "",
            ""}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageKspInstances));
            this.KSPInstancesListView = new System.Windows.Forms.ListView();
            this.KSPInstallName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KSPInstallVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KSPInstallPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectButton = new System.Windows.Forms.Button();
            this.AddNewButton = new CKAN.DropdownMenuButton();
            this.AddNewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToCKANMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloneFakeInstanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameButton = new System.Windows.Forms.Button();
            this.SetAsDefaultCheckbox = new System.Windows.Forms.CheckBox();
            this.ForgetButton = new System.Windows.Forms.Button();
            this.AddNewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // KSPInstancesListView
            // 
            this.KSPInstancesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KSPInstancesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KSPInstancesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KSPInstallName,
            this.KSPInstallVersion,
            this.KSPInstallPath});
            this.KSPInstancesListView.FullRowSelect = true;
            this.KSPInstancesListView.HideSelection = false;
            this.KSPInstancesListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.KSPInstancesListView.Location = new System.Drawing.Point(12, 13);
            this.KSPInstancesListView.MultiSelect = false;
            this.KSPInstancesListView.Name = "KSPInstancesListView";
            this.KSPInstancesListView.Size = new System.Drawing.Size(462, 301);
            this.KSPInstancesListView.TabIndex = 0;
            this.KSPInstancesListView.UseCompatibleStateImageBehavior = false;
            this.KSPInstancesListView.View = System.Windows.Forms.View.Details;
            this.KSPInstancesListView.SelectedIndexChanged += new System.EventHandler(this.KSPInstancesListView_SelectedIndexChanged);
            this.KSPInstancesListView.DoubleClick += new System.EventHandler(this.KSPInstancesListView_DoubleClick);
            // 
            // KSPInstallName
            // 
            this.KSPInstallName.Text = "Name";
            this.KSPInstallName.Width = 161;
            // 
            // KSPInstallVersion
            // 
            this.KSPInstallVersion.Text = "Version";
            this.KSPInstallVersion.Width = 100;
            // 
            // KSPInstallPath
            // 
            this.KSPInstallPath.Text = "Path";
            this.KSPInstallPath.Width = 400;
            // 
            // SelectButton
            // 
            this.SelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectButton.Enabled = false;
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Location = new System.Drawing.Point(399, 320);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 1;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewButton.Location = new System.Drawing.Point(267, 320);
            this.AddNewButton.Menu = this.AddNewMenu;
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(126, 23);
            this.AddNewButton.TabIndex = 2;
            this.AddNewButton.Text = "New "+GameConfig.Constants.GameNameShort+" instance";
            this.AddNewButton.UseVisualStyleBackColor = true;
            // 
            // AddNewMenu
            // 
            this.AddNewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToCKANMenuItem,
            this.CloneFakeInstanceMenuItem});
            this.AddNewMenu.Name = "AddNewMenu";
            this.AddNewMenu.Size = new System.Drawing.Size(217, 48);
            // 
            // AddToCKANMenuItem
            // 
            this.AddToCKANMenuItem.Name = "AddToCKANMenuItem";
            this.AddToCKANMenuItem.Size = new System.Drawing.Size(216, 22);
            this.AddToCKANMenuItem.Text = "Add instance to CKAN";
            this.AddToCKANMenuItem.Click += new System.EventHandler(this.AddToCKANMenuItem_Click);
            // 
            // CloneFakeInstanceMenuItem
            // 
            this.CloneFakeInstanceMenuItem.Name = "CloneFakeInstanceMenuItem";
            this.CloneFakeInstanceMenuItem.Size = new System.Drawing.Size(216, 22);
            this.CloneFakeInstanceMenuItem.Text = "Clone or fake new instance";
            this.CloneFakeInstanceMenuItem.Click += new System.EventHandler(this.CloneFakeInstanceMenuItem_Click);
            // 
            // RenameButton
            // 
            this.RenameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RenameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RenameButton.Location = new System.Drawing.Point(196, 320);
            this.RenameButton.Name = "RenameButton";
            this.RenameButton.Size = new System.Drawing.Size(65, 23);
            this.RenameButton.TabIndex = 3;
            this.RenameButton.Text = "Rename";
            this.RenameButton.UseVisualStyleBackColor = true;
            this.RenameButton.Click += new System.EventHandler(this.RenameButton_Click);
            // 
            // SetAsDefaultCheckbox
            // 
            this.SetAsDefaultCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SetAsDefaultCheckbox.AutoSize = true;
            this.SetAsDefaultCheckbox.Location = new System.Drawing.Point(12, 324);
            this.SetAsDefaultCheckbox.Name = "SetAsDefaultCheckbox";
            this.SetAsDefaultCheckbox.Size = new System.Drawing.Size(91, 17);
            this.SetAsDefaultCheckbox.TabIndex = 4;
            this.SetAsDefaultCheckbox.Text = "Set as default";
            this.SetAsDefaultCheckbox.UseVisualStyleBackColor = true;
            // 
            // ForgetButton
            // 
            this.ForgetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ForgetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgetButton.Location = new System.Drawing.Point(125, 320);
            this.ForgetButton.Name = "ForgetButton";
            this.ForgetButton.Size = new System.Drawing.Size(65, 23);
            this.ForgetButton.TabIndex = 5;
            this.ForgetButton.Text = "Forget";
            this.ForgetButton.UseVisualStyleBackColor = true;
            this.ForgetButton.Click += new System.EventHandler(this.Forget_Click);
            // 
            // ManageKspInstances
            // 
            this.AcceptButton = this.SelectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 355);
            this.Controls.Add(this.ForgetButton);
            this.Controls.Add(this.SetAsDefaultCheckbox);
            this.Controls.Add(this.RenameButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.KSPInstancesListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 200);
            this.Name = "ManageKspInstances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage "+GameConfig.Constants.GameNameShort+" Instances";
            this.AddNewMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView KSPInstancesListView;
        private System.Windows.Forms.ColumnHeader KSPInstallName;
        private System.Windows.Forms.ColumnHeader KSPInstallPath;
        private System.Windows.Forms.ColumnHeader KSPInstallVersion;
        private System.Windows.Forms.Button SelectButton;
        private DropdownMenuButton AddNewButton;
        private System.Windows.Forms.ContextMenuStrip AddNewMenu;
        private System.Windows.Forms.ToolStripMenuItem AddToCKANMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloneFakeInstanceMenuItem;
        private System.Windows.Forms.Button RenameButton;
        private System.Windows.Forms.CheckBox SetAsDefaultCheckbox;
        private System.Windows.Forms.Button ForgetButton;
    }
}
