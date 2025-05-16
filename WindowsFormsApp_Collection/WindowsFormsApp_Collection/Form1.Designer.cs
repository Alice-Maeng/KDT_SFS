namespace WindowsFormsApp_Collection
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
            this.button1_file = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.textBox2_pw = new System.Windows.Forms.TextBox();
            this.label1_id = new System.Windows.Forms.Label();
            this.label1_pw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_file
            // 
            this.button1_file.Location = new System.Drawing.Point(12, 12);
            this.button1_file.Name = "button1_file";
            this.button1_file.Size = new System.Drawing.Size(116, 44);
            this.button1_file.TabIndex = 0;
            this.button1_file.Text = "파일 열기";
            this.button1_file.UseMnemonic = false;
            this.button1_file.UseVisualStyleBackColor = true;
            this.button1_file.Click += new System.EventHandler(this.button1_file_Click);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_login.Location = new System.Drawing.Point(328, 115);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(113, 103);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(123, 115);
            this.textBox1_id.Multiline = true;
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(170, 41);
            this.textBox1_id.TabIndex = 4;
            // 
            // textBox2_pw
            // 
            this.textBox2_pw.Location = new System.Drawing.Point(123, 179);
            this.textBox2_pw.Multiline = true;
            this.textBox2_pw.Name = "textBox2_pw";
            this.textBox2_pw.Size = new System.Drawing.Size(170, 39);
            this.textBox2_pw.TabIndex = 5;
            // 
            // label1_id
            // 
            this.label1_id.AutoSize = true;
            this.label1_id.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1_id.Location = new System.Drawing.Point(52, 115);
            this.label1_id.Name = "label1_id";
            this.label1_id.Size = new System.Drawing.Size(38, 31);
            this.label1_id.TabIndex = 6;
            this.label1_id.Text = "ID";
            // 
            // label1_pw
            // 
            this.label1_pw.AutoSize = true;
            this.label1_pw.Font = new System.Drawing.Font("Malgun Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1_pw.Location = new System.Drawing.Point(52, 179);
            this.label1_pw.Name = "label1_pw";
            this.label1_pw.Size = new System.Drawing.Size(51, 31);
            this.label1_pw.TabIndex = 7;
            this.label1_pw.Text = "PW";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.label1_pw);
            this.Controls.Add(this.label1_id);
            this.Controls.Add(this.textBox2_pw);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button1_file);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_file;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.TextBox textBox2_pw;
        private System.Windows.Forms.Label label1_id;
        private System.Windows.Forms.Label label1_pw;
    }
}

