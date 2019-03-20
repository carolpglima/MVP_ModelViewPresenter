namespace WindowsForms_MVP_ModelViewPresenter
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lArea = new System.Windows.Forms.Label();
            this.textLength = new System.Windows.Forms.TextBox();
            this.textBreadth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Breadth";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lArea
            // 
            this.lArea.AutoSize = true;
            this.lArea.Location = new System.Drawing.Point(357, 327);
            this.lArea.Name = "lArea";
            this.lArea.Size = new System.Drawing.Size(0, 20);
            this.lArea.TabIndex = 3;
            // 
            // textLength
            // 
            this.textLength.Location = new System.Drawing.Point(172, 60);
            this.textLength.Name = "textLength";
            this.textLength.Size = new System.Drawing.Size(185, 26);
            this.textLength.TabIndex = 4;
            // 
            // textBreadth
            // 
            this.textBreadth.Location = new System.Drawing.Point(172, 134);
            this.textBreadth.Name = "textBreadth";
            this.textBreadth.Size = new System.Drawing.Size(185, 26);
            this.textBreadth.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBreadth);
            this.Controls.Add(this.textLength);
            this.Controls.Add(this.lArea);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lArea;
        private System.Windows.Forms.TextBox textLength;
        private System.Windows.Forms.TextBox textBreadth;
    }
}

