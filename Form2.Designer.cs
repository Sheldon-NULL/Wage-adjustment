
namespace Wage_adjustment
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldwageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newwageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wadeadjustDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wade_adjustDataSet = new Wage_adjustment.wade_adjustDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.teacherTableAdapter = new Wage_adjustment.wade_adjustDataSetTableAdapters.teacherTableAdapter();
            this.fillBy2ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillBy2ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wadeadjustDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wade_adjustDataSet)).BeginInit();
            this.fillBy2ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(158, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "welcom to come back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始导入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "退出登录";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tnoDataGridViewTextBoxColumn,
            this.tnameDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.oldwageDataGridViewTextBoxColumn,
            this.newwageDataGridViewTextBoxColumn,
            this.tsexDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.departmentsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teacherBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(778, 291);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            this.dataGridView1.ColumnHeaderCellChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnHeaderCellChanged);
            // 
            // tnoDataGridViewTextBoxColumn
            // 
            this.tnoDataGridViewTextBoxColumn.DataPropertyName = "tno";
            this.tnoDataGridViewTextBoxColumn.HeaderText = "教师号";
            this.tnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tnoDataGridViewTextBoxColumn.Name = "tnoDataGridViewTextBoxColumn";
            this.tnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tnameDataGridViewTextBoxColumn
            // 
            this.tnameDataGridViewTextBoxColumn.DataPropertyName = "tname";
            this.tnameDataGridViewTextBoxColumn.HeaderText = "名字";
            this.tnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tnameDataGridViewTextBoxColumn.Name = "tnameDataGridViewTextBoxColumn";
            this.tnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountDataGridViewTextBoxColumn
            // 
            this.accountDataGridViewTextBoxColumn.DataPropertyName = "account";
            this.accountDataGridViewTextBoxColumn.HeaderText = "账号";
            this.accountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
            this.accountDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "密码";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // oldwageDataGridViewTextBoxColumn
            // 
            this.oldwageDataGridViewTextBoxColumn.DataPropertyName = "oldwage";
            this.oldwageDataGridViewTextBoxColumn.HeaderText = "旧工资";
            this.oldwageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oldwageDataGridViewTextBoxColumn.Name = "oldwageDataGridViewTextBoxColumn";
            this.oldwageDataGridViewTextBoxColumn.Width = 125;
            // 
            // newwageDataGridViewTextBoxColumn
            // 
            this.newwageDataGridViewTextBoxColumn.DataPropertyName = "newwage";
            this.newwageDataGridViewTextBoxColumn.HeaderText = "新工资";
            this.newwageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.newwageDataGridViewTextBoxColumn.Name = "newwageDataGridViewTextBoxColumn";
            this.newwageDataGridViewTextBoxColumn.Width = 125;
            // 
            // tsexDataGridViewTextBoxColumn
            // 
            this.tsexDataGridViewTextBoxColumn.DataPropertyName = "tsex";
            this.tsexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.tsexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tsexDataGridViewTextBoxColumn.Name = "tsexDataGridViewTextBoxColumn";
            this.tsexDataGridViewTextBoxColumn.Width = 125;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "入职时间";
            this.serviceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentsDataGridViewTextBoxColumn
            // 
            this.departmentsDataGridViewTextBoxColumn.DataPropertyName = "departments";
            this.departmentsDataGridViewTextBoxColumn.HeaderText = "赡养人数";
            this.departmentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentsDataGridViewTextBoxColumn.Name = "departmentsDataGridViewTextBoxColumn";
            this.departmentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "teacher";
            this.teacherBindingSource.DataSource = this.wadeadjustDataSetBindingSource;
            // 
            // wadeadjustDataSetBindingSource
            // 
            this.wadeadjustDataSetBindingSource.DataSource = this.wade_adjustDataSet;
            this.wadeadjustDataSetBindingSource.Position = 0;
            // 
            // wade_adjustDataSet
            // 
            this.wade_adjustDataSet.DataSetName = "wade_adjustDataSet";
            this.wade_adjustDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "更新工资";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy2ToolStrip1
            // 
            this.fillBy2ToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillBy2ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy2ToolStripButton1});
            this.fillBy2ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip1.Name = "fillBy2ToolStrip1";
            this.fillBy2ToolStrip1.Size = new System.Drawing.Size(818, 27);
            this.fillBy2ToolStrip1.TabIndex = 8;
            this.fillBy2ToolStrip1.Text = "fillBy2ToolStrip1";
            // 
            // fillBy2ToolStripButton1
            // 
            this.fillBy2ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton1.Name = "fillBy2ToolStripButton1";
            this.fillBy2ToolStripButton1.Size = new System.Drawing.Size(43, 24);
            this.fillBy2ToolStripButton1.Text = "排序";
            this.fillBy2ToolStripButton1.Click += new System.EventHandler(this.fillBy2ToolStripButton1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(263, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 33);
            this.button4.TabIndex = 9;
            this.button4.Text = "导出数据";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 466);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.fillBy2ToolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "管理员";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wadeadjustDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wade_adjustDataSet)).EndInit();
            this.fillBy2ToolStrip1.ResumeLayout(false);
            this.fillBy2ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource wadeadjustDataSetBindingSource;
        private wade_adjustDataSet wade_adjustDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private wade_adjustDataSetTableAdapters.teacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldwageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newwageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip1;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton1;
        private System.Windows.Forms.Button button4;
    }
}