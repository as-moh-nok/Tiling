namespace Tiling
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
            this.makebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.powBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maxProbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // makebtn
            // 
            this.makebtn.Location = new System.Drawing.Point(204, 156);
            this.makebtn.Name = "makebtn";
            this.makebtn.Size = new System.Drawing.Size(75, 23);
            this.makebtn.TabIndex = 0;
            this.makebtn.Text = "ساختن";
            this.makebtn.UseVisualStyleBackColor = true;
            this.makebtn.Click += new System.EventHandler(this.makebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "عددی به عنوان توان عدد 2 وارد کنید";
            // 
            // powBox
            // 
            this.powBox.Location = new System.Drawing.Point(254, 84);
            this.powBox.Name = "powBox";
            this.powBox.Size = new System.Drawing.Size(100, 20);
            this.powBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "کاشی کاری";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // maxProbtn
            // 
            this.maxProbtn.Location = new System.Drawing.Point(12, 84);
            this.maxProbtn.Name = "maxProbtn";
            this.maxProbtn.Size = new System.Drawing.Size(114, 32);
            this.maxProbtn.TabIndex = 5;
            this.maxProbtn.Text = "ضرب بیشینه";
            this.maxProbtn.UseVisualStyleBackColor = true;
            this.maxProbtn.Click += new System.EventHandler(this.maxProbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 307);
            this.Controls.Add(this.maxProbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.powBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox powBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button maxProbtn;
    }
}

