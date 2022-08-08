
namespace komunikasi_arduino_csharp
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cbxDaftarPort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxBaudRate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDisconnect = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnConnect = new Guna.UI2.WinForms.Guna2Button();
            this.txtSend = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // cbxDaftarPort
            // 
            this.cbxDaftarPort.BackColor = System.Drawing.Color.Transparent;
            this.cbxDaftarPort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDaftarPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDaftarPort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDaftarPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDaftarPort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxDaftarPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxDaftarPort.ItemHeight = 30;
            this.cbxDaftarPort.Location = new System.Drawing.Point(17, 50);
            this.cbxDaftarPort.Name = "cbxDaftarPort";
            this.cbxDaftarPort.Size = new System.Drawing.Size(177, 36);
            this.cbxDaftarPort.TabIndex = 0;
            // 
            // cbxBaudRate
            // 
            this.cbxBaudRate.BackColor = System.Drawing.Color.Transparent;
            this.cbxBaudRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBaudRate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxBaudRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxBaudRate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxBaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxBaudRate.ItemHeight = 30;
            this.cbxBaudRate.Location = new System.Drawing.Point(17, 92);
            this.cbxBaudRate.Name = "cbxBaudRate";
            this.cbxBaudRate.Size = new System.Drawing.Size(177, 36);
            this.cbxBaudRate.TabIndex = 1;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(54)))));
            this.btnDisconnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDisconnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDisconnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDisconnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDisconnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(54)))));
            this.btnDisconnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(17, 212);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(177, 36);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Location = new System.Drawing.Point(17, 134);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.Size = new System.Drawing.Size(177, 30);
            this.guna2ProgressBar1.TabIndex = 4;
            this.guna2ProgressBar1.Text = "guna2ProgressBar1";
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(105)))), ((int)(((byte)(102)))));
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(725, 51);
            this.guna2Panel1.TabIndex = 5;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(668, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(54)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(617, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(17, 170);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(177, 36);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtSend
            // 
            this.txtSend.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSend.DefaultText = "";
            this.txtSend.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSend.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSend.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSend.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSend.Location = new System.Drawing.Point(252, 93);
            this.txtSend.Name = "txtSend";
            this.txtSend.PasswordChar = '\0';
            this.txtSend.PlaceholderText = "";
            this.txtSend.SelectedText = "";
            this.txtSend.Size = new System.Drawing.Size(320, 36);
            this.txtSend.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(54)))));
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(54)))));
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(578, 93);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(125, 36);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "SEND";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(54)))));
            this.guna2GroupBox1.BorderRadius = 2;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.cbxBaudRate);
            this.guna2GroupBox1.Controls.Add(this.cbxDaftarPort);
            this.guna2GroupBox1.Controls.Add(this.btnConnect);
            this.guna2GroupBox1.Controls.Add(this.btnDisconnect);
            this.guna2GroupBox1.Controls.Add(this.guna2ProgressBar1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(57)))), ((int)(((byte)(54)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(191)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(191)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(21, 93);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(207, 259);
            this.guna2GroupBox1.TabIndex = 8;
            this.guna2GroupBox1.Text = "CONTROL";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(252, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(451, 217);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(725, 385);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnDisconnect;
        private Guna.UI2.WinForms.Guna2ComboBox cbxBaudRate;
        private Guna.UI2.WinForms.Guna2ComboBox cbxDaftarPort;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Button btnConnect;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2TextBox txtSend;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

