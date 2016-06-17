namespace Form1
{
    partial class FormChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1Set = new System.Windows.Forms.TextBox();
            this.textBox2Set = new System.Windows.Forms.TextBox();
            this.textBox3Set = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4Set = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabelSetPass = new System.Windows.Forms.LinkLabel();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Old Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ulangi Password";
            // 
            // textBox1Set
            // 
            this.textBox1Set.Location = new System.Drawing.Point(146, 11);
            this.textBox1Set.Name = "textBox1Set";
            this.textBox1Set.PasswordChar = '*';
            this.textBox1Set.Size = new System.Drawing.Size(176, 20);
            this.textBox1Set.TabIndex = 1;
            // 
            // textBox2Set
            // 
            this.textBox2Set.Location = new System.Drawing.Point(146, 37);
            this.textBox2Set.Name = "textBox2Set";
            this.textBox2Set.PasswordChar = '*';
            this.textBox2Set.Size = new System.Drawing.Size(176, 20);
            this.textBox2Set.TabIndex = 2;
            // 
            // textBox3Set
            // 
            this.textBox3Set.Location = new System.Drawing.Point(146, 63);
            this.textBox3Set.Name = "textBox3Set";
            this.textBox3Set.PasswordChar = '*';
            this.textBox3Set.Size = new System.Drawing.Size(176, 20);
            this.textBox3Set.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "No Handphone";
            // 
            // textBox4Set
            // 
            this.textBox4Set.Location = new System.Drawing.Point(146, 90);
            this.textBox4Set.Name = "textBox4Set";
            this.textBox4Set.Size = new System.Drawing.Size(176, 20);
            this.textBox4Set.TabIndex = 4;
            this.textBox4Set.TextChanged += new System.EventHandler(this.textBox4Set_TextChanged);
            this.textBox4Set.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4Set_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Change ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabelSetPass
            // 
            this.linkLabelSetPass.AutoSize = true;
            this.linkLabelSetPass.Location = new System.Drawing.Point(151, 154);
            this.linkLabelSetPass.Name = "linkLabelSetPass";
            this.linkLabelSetPass.Size = new System.Drawing.Size(33, 13);
            this.linkLabelSetPass.TabIndex = 9;
            this.linkLabelSetPass.TabStop = true;
            this.linkLabelSetPass.Text = "Login";
            this.linkLabelSetPass.Visible = false;
            this.linkLabelSetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSetPass_LinkClicked);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(349, 178);
            this.Controls.Add(this.linkLabelSetPass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4Set);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3Set);
            this.Controls.Add(this.textBox2Set);
            this.Controls.Add(this.textBox1Set);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganti Password";
            this.Load += new System.EventHandler(this.FormChangePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1Set;
        private System.Windows.Forms.TextBox textBox2Set;
        private System.Windows.Forms.TextBox textBox3Set;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4Set;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabelSetPass;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}