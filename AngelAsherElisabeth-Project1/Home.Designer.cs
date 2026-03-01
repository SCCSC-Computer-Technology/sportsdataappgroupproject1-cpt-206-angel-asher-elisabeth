namespace AngelAsherElisabeth_Project1
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.ListSelectSport = new System.Windows.Forms.ListBox();
            this.LblSelectSport = new System.Windows.Forms.Label();
            this.sportsDBDataSet = new AngelAsherElisabeth_Project1.SportsDBDataSet();
            this.sportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsTableAdapter = new AngelAsherElisabeth_Project1.SportsDBDataSetTableAdapters.sportsTableAdapter();
            this.BtnView = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ListSelectSport
            // 
            this.ListSelectSport.DataSource = this.sportsBindingSource;
            this.ListSelectSport.DisplayMember = "sport";
            this.ListSelectSport.FormattingEnabled = true;
            this.ListSelectSport.ItemHeight = 20;
            this.ListSelectSport.Location = new System.Drawing.Point(13, 176);
            this.ListSelectSport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListSelectSport.Name = "ListSelectSport";
            this.ListSelectSport.Size = new System.Drawing.Size(210, 84);
            this.ListSelectSport.TabIndex = 0;
            // 
            // LblSelectSport
            // 
            this.LblSelectSport.AutoSize = true;
            this.LblSelectSport.Location = new System.Drawing.Point(65, 117);
            this.LblSelectSport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSelectSport.Name = "LblSelectSport";
            this.LblSelectSport.Size = new System.Drawing.Size(107, 20);
            this.LblSelectSport.TabIndex = 1;
            this.LblSelectSport.Text = "Select a sport";
            // 
            // sportsDBDataSet
            // 
            this.sportsDBDataSet.DataSetName = "SportsDBDataSet";
            this.sportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sportsBindingSource
            // 
            this.sportsBindingSource.DataMember = "sports";
            this.sportsBindingSource.DataSource = this.sportsDBDataSet;
            // 
            // sportsTableAdapter
            // 
            this.sportsTableAdapter.ClearBeforeFill = true;
            // 
            // BtnView
            // 
            this.BtnView.Location = new System.Drawing.Point(69, 316);
            this.BtnView.Name = "BtnView";
            this.BtnView.Size = new System.Drawing.Size(103, 50);
            this.BtnView.TabIndex = 2;
            this.BtnView.Text = "View";
            this.BtnView.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(150, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(79, 30);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 430);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnView);
            this.Controls.Add(this.LblSelectSport);
            this.Controls.Add(this.ListSelectSport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Sports Application - Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListSelectSport;
        private System.Windows.Forms.Label LblSelectSport;
        private SportsDBDataSet sportsDBDataSet;
        private System.Windows.Forms.BindingSource sportsBindingSource;
        private SportsDBDataSetTableAdapters.sportsTableAdapter sportsTableAdapter;
        private System.Windows.Forms.Button BtnView;
        private System.Windows.Forms.Button BtnExit;
    }
}