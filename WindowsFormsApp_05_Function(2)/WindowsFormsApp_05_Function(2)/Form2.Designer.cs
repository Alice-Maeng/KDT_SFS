namespace WindowsFormsApp_05_Function_2_
{
    partial class Form2
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
            this.textBox1_result = new System.Windows.Forms.TextBox();
            this.scissors = new System.Windows.Forms.Button();
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.score_J = new System.Windows.Forms.TextBox();
            this.Alice = new System.Windows.Forms.TextBox();
            this.Jack = new System.Windows.Forms.TextBox();
            this.score_A = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1_result
            // 
            this.textBox1_result.Font = new System.Drawing.Font("Dotum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1_result.Location = new System.Drawing.Point(34, 12);
            this.textBox1_result.Multiline = true;
            this.textBox1_result.Name = "textBox1_result";
            this.textBox1_result.Size = new System.Drawing.Size(428, 213);
            this.textBox1_result.TabIndex = 0;
            this.textBox1_result.Text = "게임을 시작해보세요 >_<";
            // 
            // scissors
            // 
            this.scissors.Font = new System.Drawing.Font("Dotum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scissors.Location = new System.Drawing.Point(34, 333);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(114, 76);
            this.scissors.TabIndex = 1;
            this.scissors.Text = "가위";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // rock
            // 
            this.rock.Font = new System.Drawing.Font("Dotum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rock.Location = new System.Drawing.Point(192, 333);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(114, 76);
            this.rock.TabIndex = 2;
            this.rock.Text = "바위";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // paper
            // 
            this.paper.Font = new System.Drawing.Font("Dotum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.paper.Location = new System.Drawing.Point(348, 333);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(114, 76);
            this.paper.TabIndex = 3;
            this.paper.Text = "보";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // score_J
            // 
            this.score_J.Location = new System.Drawing.Point(299, 288);
            this.score_J.Multiline = true;
            this.score_J.Name = "score_J";
            this.score_J.Size = new System.Drawing.Size(150, 30);
            this.score_J.TabIndex = 5;
            // 
            // Alice
            // 
            this.Alice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Alice.Font = new System.Drawing.Font("Dotum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Alice.Location = new System.Drawing.Point(48, 244);
            this.Alice.Multiline = true;
            this.Alice.Name = "Alice";
            this.Alice.Size = new System.Drawing.Size(115, 38);
            this.Alice.TabIndex = 6;
            this.Alice.Text = "Alice";
            this.Alice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Jack
            // 
            this.Jack.BackColor = System.Drawing.SystemColors.Control;
            this.Jack.Font = new System.Drawing.Font("Dotum", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Jack.Location = new System.Drawing.Point(308, 244);
            this.Jack.Multiline = true;
            this.Jack.Name = "Jack";
            this.Jack.Size = new System.Drawing.Size(125, 38);
            this.Jack.TabIndex = 7;
            this.Jack.Text = "Jack";
            this.Jack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // score_A
            // 
            this.score_A.Location = new System.Drawing.Point(34, 288);
            this.score_A.Multiline = true;
            this.score_A.Name = "score_A";
            this.score_A.Size = new System.Drawing.Size(150, 30);
            this.score_A.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 225);
            this.textBox1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.score_A);
            this.Controls.Add(this.Jack);
            this.Controls.Add(this.Alice);
            this.Controls.Add(this.score_J);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.textBox1_result);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_result;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.TextBox score_J;
        private System.Windows.Forms.TextBox Alice;
        private System.Windows.Forms.TextBox Jack;
        private System.Windows.Forms.TextBox score_A;
        private System.Windows.Forms.TextBox textBox1;
    }
}