namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.lstSensors = new System.Windows.Forms.ListBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.chkUseCallback = new System.Windows.Forms.CheckBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtGloveLocation = new System.Windows.Forms.TextBox();
            this.lblSensors = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtLR = new System.Windows.Forms.TextBox();
            this.lblLR = new System.Windows.Forms.Label();
            this.lblGesture = new System.Windows.Forms.Label();
            this.txtGesture = new System.Windows.Forms.TextBox();
            this.txtPacketRate = new System.Windows.Forms.TextBox();
            this.txtFirmWareVersion = new System.Windows.Forms.TextBox();
            this.lblPacketRate = new System.Windows.Forms.Label();
            this.lblFWVersion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 250;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // lstSensors
            // 
            this.lstSensors.FormattingEnabled = true;
            this.lstSensors.Location = new System.Drawing.Point(286, 58);
            this.lstSensors.Name = "lstSensors";
            this.lstSensors.Size = new System.Drawing.Size(324, 238);
            this.lstSensors.TabIndex = 2;
            this.lstSensors.SelectedIndexChanged += new System.EventHandler(this.lstSensors_SelectedIndexChanged);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(535, 305);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // chkUseCallback
            // 
            this.chkUseCallback.AutoSize = true;
            this.chkUseCallback.Location = new System.Drawing.Point(286, 12);
            this.chkUseCallback.Name = "chkUseCallback";
            this.chkUseCallback.Size = new System.Drawing.Size(197, 17);
            this.chkUseCallback.TabIndex = 4;
            this.chkUseCallback.Text = "Use Callback instead of 250ms timer";
            this.chkUseCallback.UseVisualStyleBackColor = true;
            this.chkUseCallback.CheckedChanged += new System.EventHandler(this.chkUseCallback_CheckedChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(175, 15);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Connect";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtGloveLocation
            // 
            this.txtGloveLocation.Location = new System.Drawing.Point(47, 15);
            this.txtGloveLocation.Name = "txtGloveLocation";
            this.txtGloveLocation.Size = new System.Drawing.Size(101, 20);
            this.txtGloveLocation.TabIndex = 6;
            this.txtGloveLocation.Text = "USB0";
            // 
            // lblSensors
            // 
            this.lblSensors.AutoSize = true;
            this.lblSensors.Location = new System.Drawing.Point(283, 42);
            this.lblSensors.Name = "lblSensors";
            this.lblSensors.Size = new System.Drawing.Size(48, 13);
            this.lblSensors.TabIndex = 7;
            this.lblSensors.Text = "Sensors:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(118, 60);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(132, 20);
            this.txtType.TabIndex = 10;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(44, 67);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // txtLR
            // 
            this.txtLR.Location = new System.Drawing.Point(118, 87);
            this.txtLR.Name = "txtLR";
            this.txtLR.Size = new System.Drawing.Size(132, 20);
            this.txtLR.TabIndex = 12;
            // 
            // lblLR
            // 
            this.lblLR.AutoSize = true;
            this.lblLR.Location = new System.Drawing.Point(43, 94);
            this.lblLR.Name = "lblLR";
            this.lblLR.Size = new System.Drawing.Size(58, 13);
            this.lblLR.TabIndex = 13;
            this.lblLR.Text = "Left/Right:";
            // 
            // lblGesture
            // 
            this.lblGesture.AutoSize = true;
            this.lblGesture.Location = new System.Drawing.Point(284, 314);
            this.lblGesture.Name = "lblGesture";
            this.lblGesture.Size = new System.Drawing.Size(84, 13);
            this.lblGesture.TabIndex = 14;
            this.lblGesture.Text = "Current Gesture:";
            // 
            // txtGesture
            // 
            this.txtGesture.Location = new System.Drawing.Point(374, 308);
            this.txtGesture.Name = "txtGesture";
            this.txtGesture.Size = new System.Drawing.Size(25, 20);
            this.txtGesture.TabIndex = 15;
            // 
            // txtPacketRate
            // 
            this.txtPacketRate.Location = new System.Drawing.Point(118, 113);
            this.txtPacketRate.Name = "txtPacketRate";
            this.txtPacketRate.Size = new System.Drawing.Size(132, 20);
            this.txtPacketRate.TabIndex = 16;
            // 
            // txtFirmWareVersion
            // 
            this.txtFirmWareVersion.Location = new System.Drawing.Point(118, 139);
            this.txtFirmWareVersion.Name = "txtFirmWareVersion";
            this.txtFirmWareVersion.Size = new System.Drawing.Size(132, 20);
            this.txtFirmWareVersion.TabIndex = 17;
            // 
            // lblPacketRate
            // 
            this.lblPacketRate.AutoSize = true;
            this.lblPacketRate.Location = new System.Drawing.Point(44, 120);
            this.lblPacketRate.Name = "lblPacketRate";
            this.lblPacketRate.Size = new System.Drawing.Size(70, 13);
            this.lblPacketRate.TabIndex = 18;
            this.lblPacketRate.Text = "Packet Rate:";
            this.lblPacketRate.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFWVersion
            // 
            this.lblFWVersion.AutoSize = true;
            this.lblFWVersion.Location = new System.Drawing.Point(44, 146);
            this.lblFWVersion.Name = "lblFWVersion";
            this.lblFWVersion.Size = new System.Drawing.Size(65, 13);
            this.lblFWVersion.TabIndex = 19;
            this.lblFWVersion.Text = "FW Version:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 344);
            this.Controls.Add(this.lblFWVersion);
            this.Controls.Add(this.lblPacketRate);
            this.Controls.Add(this.txtFirmWareVersion);
            this.Controls.Add(this.txtPacketRate);
            this.Controls.Add(this.txtGesture);
            this.Controls.Add(this.lblGesture);
            this.Controls.Add(this.lblLR);
            this.Controls.Add(this.txtLR);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSensors);
            this.Controls.Add(this.txtGloveLocation);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.chkUseCallback);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lstSensors);
            this.Name = "frmMain";
            this.Text = "5DT Glove Sample App (C#)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.ListBox lstSensors;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.CheckBox chkUseCallback;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox txtGloveLocation;
        private System.Windows.Forms.Label lblSensors;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtLR;
        private System.Windows.Forms.Label lblLR;
        private System.Windows.Forms.Label lblGesture;
        private System.Windows.Forms.TextBox txtGesture;
        private System.Windows.Forms.TextBox txtPacketRate;
        private System.Windows.Forms.TextBox txtFirmWareVersion;
        private System.Windows.Forms.Label lblPacketRate;
        private System.Windows.Forms.Label lblFWVersion;
        private System.Windows.Forms.Button button1;
    }
}

