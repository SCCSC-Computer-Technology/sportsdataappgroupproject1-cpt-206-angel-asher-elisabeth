namespace AngelAsherElisabeth_Project1
{
    partial class Schedule
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
            this.LblTeamName = new System.Windows.Forms.Label();
            this.LbLTeamNameTxt = new System.Windows.Forms.Label();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.scheduleBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.sportsDBDataSet = new AngelAsherElisabeth_Project1.SportsDBDataSet();
            this.sportsDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleTableAdapter = new AngelAsherElisabeth_Project1.SportsDBDataSetTableAdapters.scheduleTableAdapter();
            this.tableAdapterManager = new AngelAsherElisabeth_Project1.SportsDBDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTeamName
            // 
            this.LblTeamName.AutoSize = true;
            this.LblTeamName.Location = new System.Drawing.Point(48, 25);
            this.LblTeamName.Name = "LblTeamName";
            this.LblTeamName.Size = new System.Drawing.Size(37, 13);
            this.LblTeamName.TabIndex = 0;
            this.LblTeamName.Text = "Team:";
            // 
            // LbLTeamNameTxt
            // 
            this.LbLTeamNameTxt.AutoSize = true;
            this.LbLTeamNameTxt.Location = new System.Drawing.Point(118, 25);
            this.LbLTeamNameTxt.Name = "LbLTeamNameTxt";
            this.LbLTeamNameTxt.Size = new System.Drawing.Size(0, 13);
            this.LbLTeamNameTxt.TabIndex = 1;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataMember = "schedule";
            this.scheduleBindingSource.DataSource = this.sportsDBDataSetBindingSource;
            // 
            // scheduleBindingSource2
            // 
            this.scheduleBindingSource2.DataMember = "schedule";
            this.scheduleBindingSource2.DataSource = this.sportsDBDataSetBindingSource;
            // 
            // scheduleBindingSource1
            // 
            this.scheduleBindingSource1.DataMember = "schedule";
            this.scheduleBindingSource1.DataSource = this.sportsDBDataSetBindingSource;
            // 
            // scheduleBindingSource3
            // 
            this.scheduleBindingSource3.DataMember = "schedule";
            this.scheduleBindingSource3.DataSource = this.sportsDBDataSetBindingSource;
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.AutoGenerateColumns = false;
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.scheduleDataGridView.DataSource = this.scheduleBindingSource4;
            this.scheduleDataGridView.Location = new System.Drawing.Point(51, 54);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.Size = new System.Drawing.Size(863, 325);
            this.scheduleDataGridView.TabIndex = 2;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(782, 385);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(132, 51);
            this.BtnClose.TabIndex = 15;
            this.BtnClose.Text = "&Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // scheduleBindingSource4
            // 
            this.scheduleBindingSource4.DataMember = "schedule";
            this.scheduleBindingSource4.DataSource = this.sportsDBDataSet;
            // 
            // sportsDBDataSet
            // 
            this.sportsDBDataSet.DataSetName = "SportsDBDataSet";
            this.sportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sportsDBDataSetBindingSource
            // 
            this.sportsDBDataSetBindingSource.DataSource = this.sportsDBDataSet;
            this.sportsDBDataSetBindingSource.Position = 0;
            // 
            // scheduleTableAdapter
            // 
            this.scheduleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.nba_teamsTableAdapter = null;
            this.tableAdapterManager.scheduleTableAdapter = null;
            this.tableAdapterManager.sportsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AngelAsherElisabeth_Project1.SportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_teamsTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn2.FillWeight = 59.08629F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn3.FillWeight = 59.08629F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "home";
            this.dataGridViewTextBoxColumn4.FillWeight = 59.08629F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Home Team";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "away";
            this.dataGridViewTextBoxColumn5.FillWeight = 59.08629F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Away Team";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "score";
            this.dataGridViewTextBoxColumn6.FillWeight = 304.5685F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Score";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "venue";
            this.dataGridViewTextBoxColumn7.FillWeight = 59.08629F;
            this.dataGridViewTextBoxColumn7.HeaderText = "venue";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.scheduleDataGridView);
            this.Controls.Add(this.LbLTeamNameTxt);
            this.Controls.Add(this.LblTeamName);
            this.Name = "Schedule";
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTeamName;
        private System.Windows.Forms.Label LbLTeamNameTxt;
        private System.Windows.Forms.BindingSource sportsDBDataSetBindingSource;
        private SportsDBDataSet sportsDBDataSet;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private SportsDBDataSetTableAdapters.scheduleTableAdapter scheduleTableAdapter;
        private System.Windows.Forms.BindingSource scheduleBindingSource1;
        private System.Windows.Forms.BindingSource scheduleBindingSource2;
        private System.Windows.Forms.BindingSource scheduleBindingSource3;
        private System.Windows.Forms.BindingSource scheduleBindingSource4;
        private SportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}