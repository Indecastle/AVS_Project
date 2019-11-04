namespace AVS
{
    partial class page_monitoring
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.MyGridView1 = new System.Windows.Forms.DataGridView();
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_cpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monitoring";
            // 
            // MyGridView1
            // 
            this.MyGridView1.AllowUserToAddRows = false;
            this.MyGridView1.AllowUserToDeleteRows = false;
            this.MyGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MyGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.MyGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MyGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_id,
            this.column_name,
            this.column_cpu,
            this.column_ram});
            this.MyGridView1.Location = new System.Drawing.Point(116, 0);
            this.MyGridView1.Name = "MyGridView1";
            this.MyGridView1.ReadOnly = true;
            this.MyGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MyGridView1.RowHeadersVisible = false;
            this.MyGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray;
            this.MyGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.MyGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MyGridView1.Size = new System.Drawing.Size(638, 378);
            this.MyGridView1.TabIndex = 10;
            // 
            // column_id
            // 
            this.column_id.HeaderText = "Id";
            this.column_id.Name = "column_id";
            this.column_id.ReadOnly = true;
            // 
            // column_name
            // 
            this.column_name.HeaderText = "Name";
            this.column_name.Name = "column_name";
            this.column_name.ReadOnly = true;
            // 
            // column_cpu
            // 
            this.column_cpu.HeaderText = "cpu";
            this.column_cpu.Name = "column_cpu";
            this.column_cpu.ReadOnly = true;
            // 
            // column_ram
            // 
            this.column_ram.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_ram.HeaderText = "ram";
            this.column_ram.Name = "column_ram";
            this.column_ram.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AVS.Properties.Resources.icons8_windows8_52px;
            this.pictureBox1.Location = new System.Drawing.Point(38, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // page_monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.MyGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "page_monitoring";
            this.Size = new System.Drawing.Size(896, 528);
            this.SizeChanged += new System.EventHandler(this.page_monitoring_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MyGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView MyGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_cpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ram;
        public System.Windows.Forms.Timer timer1;
    }
}
