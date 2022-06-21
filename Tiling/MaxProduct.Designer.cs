namespace Tiling
{
    partial class MaxProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.startbtn = new System.Windows.Forms.Button();
            this.numBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dobtn = new System.Windows.Forms.Button();
            this.ansBox = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aqua;
            this.panel1.Controls.Add(this.startbtn);
            this.panel1.Controls.Add(this.numBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(264, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 180);
            this.panel1.TabIndex = 0;
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbtn.Location = new System.Drawing.Point(25, 109);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 2;
            this.startbtn.Text = "شروع";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(124, 56);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(100, 20);
            this.numBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "تعداد خانه های آرایه را وارد نمایید";
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(23, 26);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(35, 13);
            this.txt.TabIndex = 1;
            this.txt.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dobtn);
            this.panel2.Controls.Add(this.ansBox);
            this.panel2.Controls.Add(this.txt);
            this.panel2.Location = new System.Drawing.Point(26, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 139);
            this.panel2.TabIndex = 2;
            // 
            // dobtn
            // 
            this.dobtn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.dobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dobtn.Location = new System.Drawing.Point(136, 113);
            this.dobtn.Name = "dobtn";
            this.dobtn.Size = new System.Drawing.Size(75, 23);
            this.dobtn.TabIndex = 4;
            this.dobtn.Text = "اعمال";
            this.dobtn.UseVisualStyleBackColor = false;
            this.dobtn.Click += new System.EventHandler(this.dobtn_Click);
            // 
            // ansBox
            // 
            this.ansBox.AutoSize = true;
            this.ansBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ansBox.Location = new System.Drawing.Point(62, 83);
            this.ansBox.Name = "ansBox";
            this.ansBox.Size = new System.Drawing.Size(0, 24);
            this.ansBox.TabIndex = 2;
            // 
            // MaxProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(530, 345);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MaxProduct";
            this.Text = "MaxProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ansBox;
        private System.Windows.Forms.Button dobtn;
    }
}