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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.displayArea = new System.Windows.Forms.Panel();
            this.keypadArea = new System.Windows.Forms.Panel();
            this.displayArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayArea
            // 
            this.displayArea.Controls.Add(this.button1);
            this.displayArea.Controls.Add(this.label1);
            this.displayArea.Location = new System.Drawing.Point(2, 3);
            this.displayArea.Name = "displayArea";
            this.displayArea.Size = new System.Drawing.Size(322, 195);
            this.displayArea.TabIndex = 2;
            // 
            // keypadArea
            // 
            this.keypadArea.Location = new System.Drawing.Point(3, 204);
            this.keypadArea.Name = "keypadArea";
            this.keypadArea.Size = new System.Drawing.Size(321, 119);
            this.keypadArea.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 324);
            this.Controls.Add(this.keypadArea);
            this.Controls.Add(this.displayArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.displayArea.ResumeLayout(false);
            this.displayArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel displayArea;
        private System.Windows.Forms.Panel keypadArea;
    }
}

