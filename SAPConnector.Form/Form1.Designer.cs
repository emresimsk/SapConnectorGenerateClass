namespace SAP.Form
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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAppServerHost = new System.Windows.Forms.TextBox();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbSystemNumber = new System.Windows.Forms.TextBox();
            this.tbPoolSize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbIdleTimeout = new System.Windows.Forms.TextBox();
            this.tbPeakConnectionsLimit = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPathOpen = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFunctionName = new System.Windows.Forms.TextBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            resources.ApplyResources(this.tbPath, "tbPath");
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tbName
            // 
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.Name = "tbName";
            // 
            // tbAppServerHost
            // 
            resources.ApplyResources(this.tbAppServerHost, "tbAppServerHost");
            this.tbAppServerHost.Name = "tbAppServerHost";
            // 
            // tbClient
            // 
            resources.ApplyResources(this.tbClient, "tbClient");
            this.tbClient.Name = "tbClient";
            // 
            // tbUser
            // 
            resources.ApplyResources(this.tbUser, "tbUser");
            this.tbUser.Name = "tbUser";
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            // 
            // tbSystemNumber
            // 
            resources.ApplyResources(this.tbSystemNumber, "tbSystemNumber");
            this.tbSystemNumber.Name = "tbSystemNumber";
            // 
            // tbPoolSize
            // 
            resources.ApplyResources(this.tbPoolSize, "tbPoolSize");
            this.tbPoolSize.Name = "tbPoolSize";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // tbIdleTimeout
            // 
            resources.ApplyResources(this.tbIdleTimeout, "tbIdleTimeout");
            this.tbIdleTimeout.Name = "tbIdleTimeout";
            // 
            // tbPeakConnectionsLimit
            // 
            resources.ApplyResources(this.tbPeakConnectionsLimit, "tbPeakConnectionsLimit");
            this.tbPeakConnectionsLimit.Name = "tbPeakConnectionsLimit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPathOpen
            // 
            resources.ApplyResources(this.btnPathOpen, "btnPathOpen");
            this.btnPathOpen.Name = "btnPathOpen";
            this.btnPathOpen.UseVisualStyleBackColor = true;
            this.btnPathOpen.Click += new System.EventHandler(this.btnPathOpen_Click);
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // tbFunctionName
            // 
            resources.ApplyResources(this.tbFunctionName, "tbFunctionName");
            this.tbFunctionName.Name = "tbFunctionName";
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            resources.GetString("cbLanguage.Items"),
            resources.GetString("cbLanguage.Items1")});
            resources.ApplyResources(this.cbLanguage, "cbLanguage");
            this.cbLanguage.Name = "cbLanguage";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.tbFunctionName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnPathOpen);
            this.Controls.Add(this.tbPeakConnectionsLimit);
            this.Controls.Add(this.tbPoolSize);
            this.Controls.Add(this.tbIdleTimeout);
            this.Controls.Add(this.tbSystemNumber);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.tbAppServerHost);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAppServerHost;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbSystemNumber;
        private System.Windows.Forms.TextBox tbPoolSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbIdleTimeout;
        private System.Windows.Forms.TextBox tbPeakConnectionsLimit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPathOpen;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbFunctionName;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.TextBox tbPath;
    }
}

