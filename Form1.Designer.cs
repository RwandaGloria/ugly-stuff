
namespace BasicCal
{
    partial class CalculatorG
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

           
            this.addButton.Click += addButton_click;
            this.subtractButton.Click += addButton_click;
            this.equalsButton.Click += equButton_Click;
            this.multiplyButton.Click += multiplyButton_Click;
            this.divButton.Click += divButton_Click;
           


        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.equalsButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(148, 100);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(45, 29);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(199, 100);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(45, 29);
            this.subtractButton.TabIndex = 1;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += textBox1_KeyDown;
            this.textBox1.KeyPress += textBox1_KeyPress;

            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(148, 157);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(96, 27);
            this.equalsButton.TabIndex = 3;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            // 
            // divButton
            // 
            this.divButton.Location = new System.Drawing.Point(199, 130);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(45, 29);
            this.divButton.TabIndex = 5;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(148, 130);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(45, 29);
            this.multiplyButton.TabIndex = 4;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            this.divButton.Click+=new System.EventHandler(this.divButton_Click);
            this.addButton.Click += new System.EventHandler(this.addButton_click);
            this.subtractButton.Click+= new System.EventHandler(this.subButton_click);
            this.equalsButton.Click += new System.EventHandler(this.equButton_Click);
            //


            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 275);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Name = "CalculatorG";
            this.Text = "CalculatorG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button multiplyButton;
    }
}

