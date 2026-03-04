namespace AngelAsherElisabeth_Project1
{
    partial class StatsForm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSport = new System.Windows.Forms.ComboBox();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.nba_teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportsDBDataSet = new AngelAsherElisabeth_Project1.SportsDBDataSet();
            this.nba_teamsTableAdapter = new AngelAsherElisabeth_Project1.SportsDBDataSetTableAdapters.nba_teamsTableAdapter();
            this.tableAdapterManager = new AngelAsherElisabeth_Project1.SportsDBDataSetTableAdapters.TableAdapterManager();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.LblUserGreeting = new System.Windows.Forms.Label();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.losesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsforDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointsagainstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nba_teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(430, 557);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 51);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(766, 557);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 51);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sport:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Team:";
            // 
            // cbSport
            // 
            this.cbSport.FormattingEnabled = true;
            this.cbSport.Items.AddRange(new object[] {
            "National Basketball Association(NBA)",
            "English Premier League(EPL)"});
            this.cbSport.Location = new System.Drawing.Point(121, 17);
            this.cbSport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSport.Name = "cbSport";
            this.cbSport.Size = new System.Drawing.Size(180, 28);
            this.cbSport.TabIndex = 8;
            this.cbSport.SelectedIndexChanged += new System.EventHandler(this.cbSport_SelectedIndexChanged);
            // 
            // cbTeam
            // 
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(121, 64);
            this.cbTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(180, 28);
            this.cbTeam.TabIndex = 9;
            // 
            // dgvTable
            // 
            this.dgvTable.AutoGenerateColumns = false;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.winsDataGridViewTextBoxColumn,
            this.drawsDataGridViewTextBoxColumn,
            this.losesDataGridViewTextBoxColumn,
            this.pointsforDataGridViewTextBoxColumn,
            this.pointsagainstDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.dgvTable.DataSource = this.nba_teamsBindingSource;
            this.dgvTable.Location = new System.Drawing.Point(45, 115);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(905, 423);
            this.dgvTable.TabIndex = 13;
            // 
            // nba_teamsBindingSource
            // 
            this.nba_teamsBindingSource.DataMember = "nba_teams";
            this.nba_teamsBindingSource.DataSource = this.sportsDBDataSet;
            // 
            // sportsDBDataSet
            // 
            this.sportsDBDataSet.DataSetName = "SportsDBDataSet";
            this.sportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nba_teamsTableAdapter
            // 
            this.nba_teamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.nba_teamsTableAdapter = this.nba_teamsTableAdapter;
            this.tableAdapterManager.scheduleTableAdapter = null;
            this.tableAdapterManager.sportsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AngelAsherElisabeth_Project1.SportsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user_teamsTableAdapter = null;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(85, 557);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(132, 51);
            this.btnSchedule.TabIndex = 14;
            this.btnSchedule.Text = "&View Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(822, 17);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(161, 54);
            this.btnSettings.TabIndex = 15;
            this.btnSettings.Text = "&Account";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // LblUserGreeting
            // 
            this.LblUserGreeting.AutoSize = true;
            this.LblUserGreeting.Location = new System.Drawing.Point(388, 17);
            this.LblUserGreeting.Name = "LblUserGreeting";
            this.LblUserGreeting.Size = new System.Drawing.Size(51, 20);
            this.LblUserGreeting.TabIndex = 16;
            this.LblUserGreeting.Text = "label1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Team Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // winsDataGridViewTextBoxColumn
            // 
            this.winsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.winsDataGridViewTextBoxColumn.DataPropertyName = "wins";
            this.winsDataGridViewTextBoxColumn.HeaderText = "Wins";
            this.winsDataGridViewTextBoxColumn.Name = "winsDataGridViewTextBoxColumn";
            // 
            // drawsDataGridViewTextBoxColumn
            // 
            this.drawsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.drawsDataGridViewTextBoxColumn.DataPropertyName = "draws";
            this.drawsDataGridViewTextBoxColumn.HeaderText = "Draws";
            this.drawsDataGridViewTextBoxColumn.Name = "drawsDataGridViewTextBoxColumn";
            // 
            // losesDataGridViewTextBoxColumn
            // 
            this.losesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.losesDataGridViewTextBoxColumn.DataPropertyName = "loses";
            this.losesDataGridViewTextBoxColumn.HeaderText = "Losses";
            this.losesDataGridViewTextBoxColumn.Name = "losesDataGridViewTextBoxColumn";
            // 
            // pointsforDataGridViewTextBoxColumn
            // 
            this.pointsforDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pointsforDataGridViewTextBoxColumn.DataPropertyName = "points_for";
            this.pointsforDataGridViewTextBoxColumn.HeaderText = "Points Scored";
            this.pointsforDataGridViewTextBoxColumn.Name = "pointsforDataGridViewTextBoxColumn";
            // 
            // pointsagainstDataGridViewTextBoxColumn
            // 
            this.pointsagainstDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pointsagainstDataGridViewTextBoxColumn.DataPropertyName = "points_against";
            this.pointsagainstDataGridViewTextBoxColumn.HeaderText = "Points Against";
            this.pointsagainstDataGridViewTextBoxColumn.Name = "pointsagainstDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 643);
            this.Controls.Add(this.LblUserGreeting);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.cbTeam);
            this.Controls.Add(this.cbSport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.Load += new System.EventHandler(this.StatsForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nba_teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportsDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSport;
        private System.Windows.Forms.ComboBox cbTeam;
        private System.Windows.Forms.DataGridView dgvTable;
        private SportsDBDataSet sportsDBDataSet;
        private System.Windows.Forms.BindingSource nba_teamsBindingSource;
        private SportsDBDataSetTableAdapters.nba_teamsTableAdapter nba_teamsTableAdapter;
        private SportsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label LblUserGreeting;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn losesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsforDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointsagainstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
    }
}