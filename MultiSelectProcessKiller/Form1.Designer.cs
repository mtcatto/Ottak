namespace ProcessKiller
{
    partial class frmMainnnnnn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.dgProcs = new System.Windows.Forms.DataGridView();
            this.Kill = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Threads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Handles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagedMem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NonPageMem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.ckSafeMode = new System.Windows.Forms.CheckBox();
            this.btnEditConfig = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcs)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 594);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kill Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgProcs
            // 
            this.dgProcs.AllowUserToAddRows = false;
            this.dgProcs.AllowUserToDeleteRows = false;
            this.dgProcs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            this.dgProcs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProcs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProcs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kill,
            this.Name,
            this.PID,
            this.Responding,
            this.Threads,
            this.Handles,
            this.TotalTime,
            this.PagedMem,
            this.NonPageMem});
            this.dgProcs.Location = new System.Drawing.Point(2, -1);
            this.dgProcs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgProcs.Name = "dgProcs";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Cornsilk;
            this.dgProcs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProcs.Size = new System.Drawing.Size(768, 585);
            this.dgProcs.TabIndex = 1;
            // 
            // Kill
            // 
            this.Kill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kill.HeaderText = "Kill";
            this.Kill.Name = "Kill";
            this.Kill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Kill.Width = 63;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Name.HeaderText = "Exe";
            this.Name.Name = "Name";
            // 
            // PID
            // 
            this.PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.Width = 69;
            // 
            // Responding
            // 
            this.Responding.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Responding.HeaderText = "Alive";
            this.Responding.Name = "Responding";
            this.Responding.Width = 5;
            // 
            // Threads
            // 
            this.Threads.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Threads.HeaderText = "Threads";
            this.Threads.Name = "Threads";
            this.Threads.Width = 110;
            // 
            // Handles
            // 
            this.Handles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Handles.HeaderText = "Handles";
            this.Handles.Name = "Handles";
            this.Handles.Width = 109;
            // 
            // TotalTime
            // 
            this.TotalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalTime.HeaderText = "TotalTime";
            this.TotalTime.Name = "TotalTime";
            this.TotalTime.Width = 125;
            // 
            // PagedMem
            // 
            this.PagedMem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PagedMem.HeaderText = "PagedMem";
            this.PagedMem.Name = "PagedMem";
            this.PagedMem.Width = 138;
            // 
            // NonPageMem
            // 
            this.NonPageMem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NonPageMem.HeaderText = "NonPageMem";
            this.NonPageMem.Name = "NonPageMem";
            this.NonPageMem.Width = 163;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(485, 594);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ckSafeMode
            // 
            this.ckSafeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckSafeMode.AutoSize = true;
            this.ckSafeMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSafeMode.Location = new System.Drawing.Point(156, 601);
            this.ckSafeMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckSafeMode.Name = "ckSafeMode";
            this.ckSafeMode.Size = new System.Drawing.Size(158, 24);
            this.ckSafeMode.TabIndex = 3;
            this.ckSafeMode.Text = "Prompt Yes/No? ";
            this.ckSafeMode.UseVisualStyleBackColor = true;
            // 
            // btnEditConfig
            // 
            this.btnEditConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditConfig.Location = new System.Drawing.Point(327, 594);
            this.btnEditConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditConfig.Name = "btnEditConfig";
            this.btnEditConfig.Size = new System.Drawing.Size(150, 31);
            this.btnEditConfig.TabIndex = 4;
            this.btnEditConfig.Text = "Edit Config";
            this.btnEditConfig.UseVisualStyleBackColor = true;
            this.btnEditConfig.Click += new System.EventHandler(this.btnEditConfig_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(605, 594);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 31);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMainnnnnn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 633);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditConfig);
            this.Controls.Add(this.ckSafeMode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgProcs);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.Name = "frmMainnnnnn";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.Text = "Multi  Select  Process  Killer";
            ((System.ComponentModel.ISupportInitialize)(this.dgProcs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgProcs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ckSafeMode;
        private System.Windows.Forms.Button btnEditConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Kill;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responding;
        private System.Windows.Forms.DataGridViewTextBoxColumn Threads;
        private System.Windows.Forms.DataGridViewTextBoxColumn Handles;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PagedMem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NonPageMem;
        private System.Windows.Forms.Button btnExit;
    }
}

