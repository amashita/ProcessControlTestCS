namespace ProcessControlTestCSWinForm
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.hideEnableChk = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.procListGridView = new System.Windows.Forms.DataGridView();
            this.systemProcessInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GetProcListBtn = new System.Windows.Forms.Button();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberOfThreadsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basePriorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueProcessIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handleCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peakVirtualSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.virtualSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peakWorkingSetSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingSetSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotaPagedPoolUsageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotaNonPagedPoolUsageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagefileUsageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peakPagefileUsageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privatePageCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.procListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemProcessInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hideEnableChk
            // 
            this.hideEnableChk.AutoSize = true;
            this.hideEnableChk.Location = new System.Drawing.Point(22, 27);
            this.hideEnableChk.Name = "hideEnableChk";
            this.hideEnableChk.Size = new System.Drawing.Size(85, 16);
            this.hideEnableChk.TabIndex = 0;
            this.hideEnableChk.Text = "Hide Enable";
            this.hideEnableChk.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(550, 19);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "ProcessControlTestCSWinForm.exe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.hideEnableChk);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ProcessHide";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "TargetProcessName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.procListGridView);
            this.groupBox2.Controls.Add(this.GetProcListBtn);
            this.groupBox2.Location = new System.Drawing.Point(13, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 278);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ProcessList";
            // 
            // procListGridView
            // 
            this.procListGridView.AllowUserToAddRows = false;
            this.procListGridView.AllowUserToDeleteRows = false;
            this.procListGridView.AllowUserToOrderColumns = true;
            this.procListGridView.AutoGenerateColumns = false;
            this.procListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.procListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOfThreadsDataGridViewTextBoxColumn,
            this.imageNameDataGridViewTextBoxColumn,
            this.basePriorityDataGridViewTextBoxColumn,
            this.uniqueProcessIdDataGridViewTextBoxColumn,
            this.handleCountDataGridViewTextBoxColumn,
            this.sessionIdDataGridViewTextBoxColumn,
            this.peakVirtualSizeDataGridViewTextBoxColumn,
            this.virtualSizeDataGridViewTextBoxColumn,
            this.peakWorkingSetSizeDataGridViewTextBoxColumn,
            this.workingSetSizeDataGridViewTextBoxColumn,
            this.quotaPagedPoolUsageDataGridViewTextBoxColumn,
            this.quotaNonPagedPoolUsageDataGridViewTextBoxColumn,
            this.pagefileUsageDataGridViewTextBoxColumn,
            this.peakPagefileUsageDataGridViewTextBoxColumn,
            this.privatePageCountDataGridViewTextBoxColumn});
            this.procListGridView.DataSource = this.systemProcessInformationBindingSource;
            this.procListGridView.Location = new System.Drawing.Point(7, 48);
            this.procListGridView.Name = "procListGridView";
            this.procListGridView.ReadOnly = true;
            this.procListGridView.RowTemplate.Height = 21;
            this.procListGridView.Size = new System.Drawing.Size(586, 224);
            this.procListGridView.TabIndex = 1;
            // 
            // systemProcessInformationBindingSource
            // 
            this.systemProcessInformationBindingSource.DataSource = typeof(ProcessControlTestCSWinForm.SystemProcessInformation);
            // 
            // GetProcListBtn
            // 
            this.GetProcListBtn.Location = new System.Drawing.Point(7, 19);
            this.GetProcListBtn.Name = "GetProcListBtn";
            this.GetProcListBtn.Size = new System.Drawing.Size(112, 23);
            this.GetProcListBtn.TabIndex = 0;
            this.GetProcListBtn.Text = "GetProcessList";
            this.GetProcListBtn.UseVisualStyleBackColor = true;
            this.GetProcListBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(ProcessControlTestCSWinForm.Form1);
            // 
            // numberOfThreadsDataGridViewTextBoxColumn
            // 
            this.numberOfThreadsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfThreads";
            this.numberOfThreadsDataGridViewTextBoxColumn.HeaderText = "NumberOfThreads";
            this.numberOfThreadsDataGridViewTextBoxColumn.Name = "numberOfThreadsDataGridViewTextBoxColumn";
            this.numberOfThreadsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageNameDataGridViewTextBoxColumn
            // 
            this.imageNameDataGridViewTextBoxColumn.DataPropertyName = "ImageName";
            this.imageNameDataGridViewTextBoxColumn.HeaderText = "ImageName";
            this.imageNameDataGridViewTextBoxColumn.Name = "imageNameDataGridViewTextBoxColumn";
            this.imageNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basePriorityDataGridViewTextBoxColumn
            // 
            this.basePriorityDataGridViewTextBoxColumn.DataPropertyName = "BasePriority";
            this.basePriorityDataGridViewTextBoxColumn.HeaderText = "BasePriority";
            this.basePriorityDataGridViewTextBoxColumn.Name = "basePriorityDataGridViewTextBoxColumn";
            this.basePriorityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uniqueProcessIdDataGridViewTextBoxColumn
            // 
            this.uniqueProcessIdDataGridViewTextBoxColumn.DataPropertyName = "UniqueProcessId";
            this.uniqueProcessIdDataGridViewTextBoxColumn.HeaderText = "UniqueProcessId";
            this.uniqueProcessIdDataGridViewTextBoxColumn.Name = "uniqueProcessIdDataGridViewTextBoxColumn";
            this.uniqueProcessIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // handleCountDataGridViewTextBoxColumn
            // 
            this.handleCountDataGridViewTextBoxColumn.DataPropertyName = "HandleCount";
            this.handleCountDataGridViewTextBoxColumn.HeaderText = "HandleCount";
            this.handleCountDataGridViewTextBoxColumn.Name = "handleCountDataGridViewTextBoxColumn";
            this.handleCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionIdDataGridViewTextBoxColumn
            // 
            this.sessionIdDataGridViewTextBoxColumn.DataPropertyName = "SessionId";
            this.sessionIdDataGridViewTextBoxColumn.HeaderText = "SessionId";
            this.sessionIdDataGridViewTextBoxColumn.Name = "sessionIdDataGridViewTextBoxColumn";
            this.sessionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peakVirtualSizeDataGridViewTextBoxColumn
            // 
            this.peakVirtualSizeDataGridViewTextBoxColumn.DataPropertyName = "PeakVirtualSize";
            this.peakVirtualSizeDataGridViewTextBoxColumn.HeaderText = "PeakVirtualSize";
            this.peakVirtualSizeDataGridViewTextBoxColumn.Name = "peakVirtualSizeDataGridViewTextBoxColumn";
            this.peakVirtualSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // virtualSizeDataGridViewTextBoxColumn
            // 
            this.virtualSizeDataGridViewTextBoxColumn.DataPropertyName = "VirtualSize";
            this.virtualSizeDataGridViewTextBoxColumn.HeaderText = "VirtualSize";
            this.virtualSizeDataGridViewTextBoxColumn.Name = "virtualSizeDataGridViewTextBoxColumn";
            this.virtualSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peakWorkingSetSizeDataGridViewTextBoxColumn
            // 
            this.peakWorkingSetSizeDataGridViewTextBoxColumn.DataPropertyName = "PeakWorkingSetSize";
            this.peakWorkingSetSizeDataGridViewTextBoxColumn.HeaderText = "PeakWorkingSetSize";
            this.peakWorkingSetSizeDataGridViewTextBoxColumn.Name = "peakWorkingSetSizeDataGridViewTextBoxColumn";
            this.peakWorkingSetSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workingSetSizeDataGridViewTextBoxColumn
            // 
            this.workingSetSizeDataGridViewTextBoxColumn.DataPropertyName = "WorkingSetSize";
            this.workingSetSizeDataGridViewTextBoxColumn.HeaderText = "WorkingSetSize";
            this.workingSetSizeDataGridViewTextBoxColumn.Name = "workingSetSizeDataGridViewTextBoxColumn";
            this.workingSetSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quotaPagedPoolUsageDataGridViewTextBoxColumn
            // 
            this.quotaPagedPoolUsageDataGridViewTextBoxColumn.DataPropertyName = "QuotaPagedPoolUsage";
            this.quotaPagedPoolUsageDataGridViewTextBoxColumn.HeaderText = "QuotaPagedPoolUsage";
            this.quotaPagedPoolUsageDataGridViewTextBoxColumn.Name = "quotaPagedPoolUsageDataGridViewTextBoxColumn";
            this.quotaPagedPoolUsageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quotaNonPagedPoolUsageDataGridViewTextBoxColumn
            // 
            this.quotaNonPagedPoolUsageDataGridViewTextBoxColumn.DataPropertyName = "QuotaNonPagedPoolUsage";
            this.quotaNonPagedPoolUsageDataGridViewTextBoxColumn.HeaderText = "QuotaNonPagedPoolUsage";
            this.quotaNonPagedPoolUsageDataGridViewTextBoxColumn.Name = "quotaNonPagedPoolUsageDataGridViewTextBoxColumn";
            this.quotaNonPagedPoolUsageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagefileUsageDataGridViewTextBoxColumn
            // 
            this.pagefileUsageDataGridViewTextBoxColumn.DataPropertyName = "PagefileUsage";
            this.pagefileUsageDataGridViewTextBoxColumn.HeaderText = "PagefileUsage";
            this.pagefileUsageDataGridViewTextBoxColumn.Name = "pagefileUsageDataGridViewTextBoxColumn";
            this.pagefileUsageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // peakPagefileUsageDataGridViewTextBoxColumn
            // 
            this.peakPagefileUsageDataGridViewTextBoxColumn.DataPropertyName = "PeakPagefileUsage";
            this.peakPagefileUsageDataGridViewTextBoxColumn.HeaderText = "PeakPagefileUsage";
            this.peakPagefileUsageDataGridViewTextBoxColumn.Name = "peakPagefileUsageDataGridViewTextBoxColumn";
            this.peakPagefileUsageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // privatePageCountDataGridViewTextBoxColumn
            // 
            this.privatePageCountDataGridViewTextBoxColumn.DataPropertyName = "PrivatePageCount";
            this.privatePageCountDataGridViewTextBoxColumn.HeaderText = "PrivatePageCount";
            this.privatePageCountDataGridViewTextBoxColumn.Name = "privatePageCountDataGridViewTextBoxColumn";
            this.privatePageCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ProcessControlTest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.procListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemProcessInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox hideEnableChk;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GetProcListBtn;
        private System.Windows.Forms.DataGridView procListGridView;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource systemProcessInformationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfThreadsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basePriorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueProcessIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn handleCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peakVirtualSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn virtualSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peakWorkingSetSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingSetSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotaPagedPoolUsageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quotaNonPagedPoolUsageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagefileUsageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peakPagefileUsageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privatePageCountDataGridViewTextBoxColumn;
    }
}

