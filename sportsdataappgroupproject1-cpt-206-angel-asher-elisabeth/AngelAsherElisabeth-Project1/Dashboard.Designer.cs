namespace AngelAsherElisabeth_Project1
{
    partial class Dashboard
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
            this.btnSport1 = new System.Windows.Forms.Button();
            this.btnSport2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSport1
            // 
            this.btnSport1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSport1.Location = new System.Drawing.Point(119, 132);
            this.btnSport1.Name = "btnSport1";
            this.btnSport1.Size = new System.Drawing.Size(186, 152);
            this.btnSport1.TabIndex = 0;
            this.btnSport1.Text = "Sport 1";
            this.btnSport1.UseVisualStyleBackColor = true;
            this.btnSport1.Click += new System.EventHandler(this.btnSport1_Click);
            // 
            // btnSport2
            // 
            this.btnSport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSport2.Location = new System.Drawing.Point(446, 132);
            this.btnSport2.Name = "btnSport2";
            this.btnSport2.Size = new System.Drawing.Size(186, 152);
            this.btnSport2.TabIndex = 1;
            this.btnSport2.Text = "Sport 2";
            this.btnSport2.UseVisualStyleBackColor = true;
            this.btnSport2.Click += new System.EventHandler(this.btnSport2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "E&xit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSport2);
            this.Controls.Add(this.btnSport1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSport1;
        private System.Windows.Forms.Button btnSport2;
        private System.Windows.Forms.Button button3;
    }
}