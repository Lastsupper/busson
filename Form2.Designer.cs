namespace Form1
{
    partial class FormLupa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLupa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noHpF = new System.Windows.Forms.TextBox();
            this.textBoxUsernameF = new System.Windows.Forms.TextBox();
            this.buttonForgot = new System.Windows.Forms.Button();
            this.buttonResetForgot = new System.Windows.Forms.Button();
            this.linkLabelForgot = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "No Handphone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // noHpF
            // 
            this.noHpF.Location = new System.Drawing.Point(122, 43);
            this.noHpF.Name = "noHpF";
            this.noHpF.Size = new System.Drawing.Size(177, 20);
            this.noHpF.TabIndex = 2;
            this.noHpF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noHpF_KeyPress);
            // 
            // textBoxUsernameF
            // 
            this.textBoxUsernameF.Location = new System.Drawing.Point(122, 20);
            this.textBoxUsernameF.Name = "textBoxUsernameF";
            this.textBoxUsernameF.Size = new System.Drawing.Size(177, 20);
            this.textBoxUsernameF.TabIndex = 1;
            // 
            // buttonForgot
            // 
            this.buttonForgot.Location = new System.Drawing.Point(122, 72);
            this.buttonForgot.Name = "buttonForgot";
            this.buttonForgot.Size = new System.Drawing.Size(87, 23);
            this.buttonForgot.TabIndex = 3;
            this.buttonForgot.Text = "Forgot";
            this.buttonForgot.UseVisualStyleBackColor = true;
            this.buttonForgot.Click += new System.EventHandler(this.buttonForgot_Click);
            // 
            // buttonResetForgot
            // 
            this.buttonResetForgot.Location = new System.Drawing.Point(212, 72);
            this.buttonResetForgot.Name = "buttonResetForgot";
            this.buttonResetForgot.Size = new System.Drawing.Size(87, 23);
            this.buttonResetForgot.TabIndex = 4;
            this.buttonResetForgot.Text = "Reset";
            this.buttonResetForgot.UseVisualStyleBackColor = true;
            this.buttonResetForgot.Click += new System.EventHandler(this.buttonResetForgot_Click);
            // 
            // linkLabelForgot
            // 
            this.linkLabelForgot.AutoSize = true;
            this.linkLabelForgot.Location = new System.Drawing.Point(146, 109);
            this.linkLabelForgot.Name = "linkLabelForgot";
            this.linkLabelForgot.Size = new System.Drawing.Size(119, 13);
            this.linkLabelForgot.TabIndex = 8;
            this.linkLabelForgot.TabStop = true;
            this.linkLabelForgot.Text = "Konfirmasikan Kode";
            this.linkLabelForgot.Visible = false;
            this.linkLabelForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelForgot_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.noHpF);
            this.groupBox1.Controls.Add(this.linkLabelForgot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonResetForgot);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonForgot);
            this.groupBox1.Controls.Add(this.textBoxUsernameF);
            this.groupBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 139);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masukkan data yang benar";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FormLupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(345, 167);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FormLupa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox noHpF;
        private System.Windows.Forms.TextBox textBoxUsernameF;
        private System.Windows.Forms.Button buttonForgot;
        private System.Windows.Forms.Button buttonResetForgot;
        private System.Windows.Forms.LinkLabel linkLabelForgot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}