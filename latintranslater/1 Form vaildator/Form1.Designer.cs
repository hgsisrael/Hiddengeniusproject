namespace _1_Form_vaildator
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
            this.btnLatinsisiter = new System.Windows.Forms.Button();
            this.btnLatinMedium = new System.Windows.Forms.Button();
            this.btnLatinDexter = new System.Windows.Forms.Button();
            this.lbloutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLatinsisiter
            // 
            this.btnLatinsisiter.Location = new System.Drawing.Point(12, 276);
            this.btnLatinsisiter.Name = "btnLatinsisiter";
            this.btnLatinsisiter.Size = new System.Drawing.Size(75, 23);
            this.btnLatinsisiter.TabIndex = 0;
            this.btnLatinsisiter.Text = "Sinister";
            this.btnLatinsisiter.UseVisualStyleBackColor = true;
            this.btnLatinsisiter.Click += new System.EventHandler(this.btnLatinsisiter_Click);
            // 
            // btnLatinMedium
            // 
            this.btnLatinMedium.Location = new System.Drawing.Point(151, 276);
            this.btnLatinMedium.Name = "btnLatinMedium";
            this.btnLatinMedium.Size = new System.Drawing.Size(75, 23);
            this.btnLatinMedium.TabIndex = 1;
            this.btnLatinMedium.Text = "Medium";
            this.btnLatinMedium.UseVisualStyleBackColor = true;
            this.btnLatinMedium.Click += new System.EventHandler(this.btnLatinMedium_Click);
            // 
            // btnLatinDexter
            // 
            this.btnLatinDexter.Location = new System.Drawing.Point(286, 276);
            this.btnLatinDexter.Name = "btnLatinDexter";
            this.btnLatinDexter.Size = new System.Drawing.Size(75, 23);
            this.btnLatinDexter.TabIndex = 2;
            this.btnLatinDexter.Text = "Dexter";
            this.btnLatinDexter.UseVisualStyleBackColor = true;
            this.btnLatinDexter.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbloutput
            // 
            this.lbloutput.AutoSize = true;
            this.lbloutput.Location = new System.Drawing.Point(166, 129);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(76, 13);
            this.lbloutput.TabIndex = 3;
            this.lbloutput.Text = "Latin translator";
            this.lbloutput.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 387);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.btnLatinDexter);
            this.Controls.Add(this.btnLatinMedium);
            this.Controls.Add(this.btnLatinsisiter);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLatinsisiter;
        private System.Windows.Forms.Button btnLatinMedium;
        private System.Windows.Forms.Button btnLatinDexter;
        private System.Windows.Forms.Label lbloutput;
    }
}

