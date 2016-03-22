namespace WindowsFormsApplication2
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
            this.instructionBox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.displayArea = new System.Windows.Forms.Panel();
            this.keypadArea = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.option1 = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.Label();
            this.option3 = new System.Windows.Forms.Label();
=======
            this.textBox1 = new System.Windows.Forms.TextBox();
>>>>>>> origin/master
            this.displayArea.SuspendLayout();
            this.keypadArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // instructionBox
            // 
            this.instructionBox.AutoSize = true;
            this.instructionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionBox.Location = new System.Drawing.Point(10, 17);
            this.instructionBox.Name = "instructionBox";
            this.instructionBox.Size = new System.Drawing.Size(102, 20);
            this.instructionBox.TabIndex = 0;
            this.instructionBox.Text = "instructions";
            this.instructionBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayArea
            // 
<<<<<<< HEAD
            this.displayArea.Controls.Add(this.option3);
            this.displayArea.Controls.Add(this.option2);
            this.displayArea.Controls.Add(this.option1);
            this.displayArea.Controls.Add(this.instructionBox);
=======
            this.displayArea.Controls.Add(this.textBox1);
            this.displayArea.Controls.Add(this.button1);
            this.displayArea.Controls.Add(this.label1);
>>>>>>> origin/master
            this.displayArea.Location = new System.Drawing.Point(2, 3);
            this.displayArea.Name = "displayArea";
            this.displayArea.Size = new System.Drawing.Size(322, 195);
            this.displayArea.TabIndex = 2;
            // 
            // keypadArea
            // 
            this.keypadArea.Controls.Add(this.button1);
            this.keypadArea.Location = new System.Drawing.Point(3, 204);
            this.keypadArea.Name = "keypadArea";
            this.keypadArea.Size = new System.Drawing.Size(321, 138);
            this.keypadArea.TabIndex = 3;
            // 
<<<<<<< HEAD
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(11, 60);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(110, 16);
            this.option1.TabIndex = 1;
            this.option1.Text = "1. Withdraw Cash";
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.Location = new System.Drawing.Point(11, 89);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(103, 16);
            this.option2.TabIndex = 2;
            this.option2.Text = "2. View Balance";
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.Location = new System.Drawing.Point(11, 120);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(92, 16);
            this.option3.TabIndex = 3;
            this.option3.Text = "3. Return Card";
=======
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
>>>>>>> origin/master
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 344);
            this.Controls.Add(this.keypadArea);
            this.Controls.Add(this.displayArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.displayArea.ResumeLayout(false);
            this.displayArea.PerformLayout();
            this.keypadArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel displayArea;
        private System.Windows.Forms.Panel keypadArea;
<<<<<<< HEAD
        private System.Windows.Forms.Label option1;
        private System.Windows.Forms.Label option2;
        private System.Windows.Forms.Label option3;
=======
        private System.Windows.Forms.TextBox textBox1;
>>>>>>> origin/master
    }
}

