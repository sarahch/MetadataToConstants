namespace Dynamics_CRM_Metadata_to_Constants
{
	partial class frmMain
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSourceFolder = new System.Windows.Forms.TextBox();
			this.txtTargetFolder = new System.Windows.Forms.TextBox();
			this.txtPluginPrefix = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGo = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblEntitesProcessed = new System.Windows.Forms.Label();
			this.lblCountOfEntities = new System.Windows.Forms.Label();
			this.lblStatusEntity = new System.Windows.Forms.Label();
			this.tcSource = new System.Windows.Forms.TabControl();
			this.tabFile = new System.Windows.Forms.TabPage();
			this.label11 = new System.Windows.Forms.Label();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.tabCRM = new System.Windows.Forms.TabPage();
			this.btnValidateCRM = new System.Windows.Forms.Button();
			this.txtOrg = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCRMPassword = new System.Windows.Forms.TextBox();
			this.txtCRMUserName = new System.Windows.Forms.TextBox();
			this.txtWebApi = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.chkOverwrite = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.tcSource.SuspendLayout();
			this.tabFile.SuspendLayout();
			this.tabCRM.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "XML Source File Path";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(81, 53);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Destination Folder";
			// 
			// txtSourceFolder
			// 
			this.txtSourceFolder.Location = new System.Drawing.Point(121, 8);
			this.txtSourceFolder.Margin = new System.Windows.Forms.Padding(2);
			this.txtSourceFolder.Name = "txtSourceFolder";
			this.txtSourceFolder.Size = new System.Drawing.Size(340, 20);
			this.txtSourceFolder.TabIndex = 2;
			this.txtSourceFolder.Text = "D:\\Temp\\CRM Export\\customizations.xml";
			// 
			// txtTargetFolder
			// 
			this.txtTargetFolder.Location = new System.Drawing.Point(207, 53);
			this.txtTargetFolder.Margin = new System.Windows.Forms.Padding(2);
			this.txtTargetFolder.Name = "txtTargetFolder";
			this.txtTargetFolder.Size = new System.Drawing.Size(323, 20);
			this.txtTargetFolder.TabIndex = 3;
			this.txtTargetFolder.Text = "D:\\Users\\Sarah\\Documents\\Temp\\Constants\\";
			// 
			// txtPluginPrefix
			// 
			this.txtPluginPrefix.Location = new System.Drawing.Point(207, 26);
			this.txtPluginPrefix.Margin = new System.Windows.Forms.Padding(2);
			this.txtPluginPrefix.Name = "txtPluginPrefix";
			this.txtPluginPrefix.Size = new System.Drawing.Size(323, 20);
			this.txtPluginPrefix.TabIndex = 6;
			this.txtPluginPrefix.Text = "IcicleGlow";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(81, 26);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Plugin Prefix";
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(275, 268);
			this.btnGo.Margin = new System.Windows.Forms.Padding(2);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(50, 19);
			this.btnGo.TabIndex = 13;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(479, 400);
			this.btnExit.Margin = new System.Windows.Forms.Padding(2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(50, 19);
			this.btnExit.TabIndex = 14;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.lblEntitesProcessed);
			this.groupBox1.Controls.Add(this.lblCountOfEntities);
			this.groupBox1.Controls.Add(this.lblStatusEntity);
			this.groupBox1.Location = new System.Drawing.Point(167, 328);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(254, 91);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Status";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 69);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Status Entities Processed";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 45);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(117, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "Status Count of Entities";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(19, 20);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "Status Entity";
			// 
			// lblEntitesProcessed
			// 
			this.lblEntitesProcessed.AutoSize = true;
			this.lblEntitesProcessed.Location = new System.Drawing.Point(160, 69);
			this.lblEntitesProcessed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblEntitesProcessed.Name = "lblEntitesProcessed";
			this.lblEntitesProcessed.Size = new System.Drawing.Size(37, 13);
			this.lblEntitesProcessed.TabIndex = 15;
			this.lblEntitesProcessed.Text = "e.g 14";
			// 
			// lblCountOfEntities
			// 
			this.lblCountOfEntities.AutoSize = true;
			this.lblCountOfEntities.Location = new System.Drawing.Point(160, 45);
			this.lblCountOfEntities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCountOfEntities.Name = "lblCountOfEntities";
			this.lblCountOfEntities.Size = new System.Drawing.Size(40, 13);
			this.lblCountOfEntities.TabIndex = 14;
			this.lblCountOfEntities.Text = "e.g. 25";
			// 
			// lblStatusEntity
			// 
			this.lblStatusEntity.AutoSize = true;
			this.lblStatusEntity.Location = new System.Drawing.Point(160, 20);
			this.lblStatusEntity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblStatusEntity.Name = "lblStatusEntity";
			this.lblStatusEntity.Size = new System.Drawing.Size(67, 13);
			this.lblStatusEntity.TabIndex = 13;
			this.lblStatusEntity.Text = "e.g. account";
			// 
			// tcSource
			// 
			this.tcSource.Controls.Add(this.tabFile);
			this.tcSource.Controls.Add(this.tabCRM);
			this.tcSource.Location = new System.Drawing.Point(41, 110);
			this.tcSource.Margin = new System.Windows.Forms.Padding(2);
			this.tcSource.Name = "tcSource";
			this.tcSource.SelectedIndex = 0;
			this.tcSource.Size = new System.Drawing.Size(503, 140);
			this.tcSource.TabIndex = 16;
			// 
			// tabFile
			// 
			this.tabFile.Controls.Add(this.label11);
			this.tabFile.Controls.Add(this.btnBrowse);
			this.tabFile.Controls.Add(this.txtSourceFolder);
			this.tabFile.Controls.Add(this.label1);
			this.tabFile.Location = new System.Drawing.Point(4, 22);
			this.tabFile.Margin = new System.Windows.Forms.Padding(2);
			this.tabFile.Name = "tabFile";
			this.tabFile.Padding = new System.Windows.Forms.Padding(2);
			this.tabFile.Size = new System.Drawing.Size(495, 114);
			this.tabFile.TabIndex = 0;
			this.tabFile.Text = "File";
			this.tabFile.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(7, 36);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(391, 26);
			this.label11.TabIndex = 4;
			this.label11.Text = "Export the customizations from CRM, then Extract the zip file into a temp locatio" +
    "n. \r\nUse the URI to the location of the customizations.xml.";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBrowse.Location = new System.Drawing.Point(465, 8);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(26, 20);
			this.btnBrowse.TabIndex = 3;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// tabCRM
			// 
			this.tabCRM.Controls.Add(this.btnValidateCRM);
			this.tabCRM.Controls.Add(this.txtOrg);
			this.tabCRM.Controls.Add(this.label10);
			this.tabCRM.Controls.Add(this.txtCRMPassword);
			this.tabCRM.Controls.Add(this.txtCRMUserName);
			this.tabCRM.Controls.Add(this.txtWebApi);
			this.tabCRM.Controls.Add(this.label9);
			this.tabCRM.Controls.Add(this.label8);
			this.tabCRM.Controls.Add(this.label4);
			this.tabCRM.Location = new System.Drawing.Point(4, 22);
			this.tabCRM.Margin = new System.Windows.Forms.Padding(2);
			this.tabCRM.Name = "tabCRM";
			this.tabCRM.Padding = new System.Windows.Forms.Padding(2);
			this.tabCRM.Size = new System.Drawing.Size(495, 114);
			this.tabCRM.TabIndex = 1;
			this.tabCRM.Text = "CRM URL";
			this.tabCRM.UseVisualStyleBackColor = true;
			// 
			// btnValidateCRM
			// 
			this.btnValidateCRM.Location = new System.Drawing.Point(232, 88);
			this.btnValidateCRM.Margin = new System.Windows.Forms.Padding(2);
			this.btnValidateCRM.Name = "btnValidateCRM";
			this.btnValidateCRM.Size = new System.Drawing.Size(50, 25);
			this.btnValidateCRM.TabIndex = 8;
			this.btnValidateCRM.Text = "Validate";
			this.btnValidateCRM.UseVisualStyleBackColor = true;
			this.btnValidateCRM.Click += new System.EventHandler(this.btnValidateCRM_Click);
			// 
			// txtOrg
			// 
			this.txtOrg.Location = new System.Drawing.Point(98, 35);
			this.txtOrg.Margin = new System.Windows.Forms.Padding(2);
			this.txtOrg.Name = "txtOrg";
			this.txtOrg.Size = new System.Drawing.Size(389, 20);
			this.txtOrg.TabIndex = 7;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(28, 35);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "Organizaiton";
			// 
			// txtCRMPassword
			// 
			this.txtCRMPassword.Location = new System.Drawing.Point(325, 58);
			this.txtCRMPassword.Margin = new System.Windows.Forms.Padding(2);
			this.txtCRMPassword.Name = "txtCRMPassword";
			this.txtCRMPassword.PasswordChar = '*';
			this.txtCRMPassword.Size = new System.Drawing.Size(161, 20);
			this.txtCRMPassword.TabIndex = 5;
			this.txtCRMPassword.Text = "CodeRefresh$2016";
			// 
			// txtCRMUserName
			// 
			this.txtCRMUserName.Location = new System.Drawing.Point(98, 58);
			this.txtCRMUserName.Margin = new System.Windows.Forms.Padding(2);
			this.txtCRMUserName.Name = "txtCRMUserName";
			this.txtCRMUserName.Size = new System.Drawing.Size(142, 20);
			this.txtCRMUserName.TabIndex = 4;
			this.txtCRMUserName.Text = "sarah@sdkupdate.onmicrosoft.com";
			// 
			// txtWebApi
			// 
			this.txtWebApi.Location = new System.Drawing.Point(98, 11);
			this.txtWebApi.Margin = new System.Windows.Forms.Padding(2);
			this.txtWebApi.Name = "txtWebApi";
			this.txtWebApi.Size = new System.Drawing.Size(389, 20);
			this.txtWebApi.TabIndex = 3;
			this.txtWebApi.Text = "https://sdkupdate.api.crm.dynamics.com/api/data/v8.1/";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(254, 58);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "Password";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(29, 58);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 13);
			this.label8.TabIndex = 1;
			this.label8.Text = "UserName";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 11);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Web API";
			// 
			// chkOverwrite
			// 
			this.chkOverwrite.AutoSize = true;
			this.chkOverwrite.Location = new System.Drawing.Point(207, 80);
			this.chkOverwrite.Margin = new System.Windows.Forms.Padding(2);
			this.chkOverwrite.Name = "chkOverwrite";
			this.chkOverwrite.Size = new System.Drawing.Size(250, 21);
			this.chkOverwrite.TabIndex = 4;
			this.chkOverwrite.Text = "Delete contents of Constants folder before run";
			this.chkOverwrite.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(574, 441);
			this.Controls.Add(this.tcSource);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.txtPluginPrefix);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.chkOverwrite);
			this.Controls.Add(this.txtTargetFolder);
			this.Controls.Add(this.label2);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmMain";
			this.Text = "Metadata to Contants";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tcSource.ResumeLayout(false);
			this.tabFile.ResumeLayout(false);
			this.tabFile.PerformLayout();
			this.tabCRM.ResumeLayout(false);
			this.tabCRM.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSourceFolder;
		private System.Windows.Forms.TextBox txtTargetFolder;
		private System.Windows.Forms.TextBox txtPluginPrefix;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblEntitesProcessed;
		private System.Windows.Forms.Label lblCountOfEntities;
		private System.Windows.Forms.Label lblStatusEntity;
		private System.Windows.Forms.TabControl tcSource;
		private System.Windows.Forms.TabPage tabFile;
		private System.Windows.Forms.TabPage tabCRM;
		private System.Windows.Forms.TextBox txtCRMPassword;
		private System.Windows.Forms.TextBox txtCRMUserName;
		private System.Windows.Forms.TextBox txtWebApi;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtOrg;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnValidateCRM;
		private System.Windows.Forms.CheckBox chkOverwrite;
		private System.Windows.Forms.Label label11;
	}
}

