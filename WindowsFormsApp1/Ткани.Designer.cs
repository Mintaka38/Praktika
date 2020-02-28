namespace WindowsFormsApp1
{
    partial class Ткани
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.складтканиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рулонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артикултканиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.длинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тканьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.складтканиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.рулонDataGridViewTextBoxColumn,
            this.артикултканиDataGridViewTextBoxColumn,
            this.длинаDataGridViewTextBoxColumn,
            this.тканьDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.складтканиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(101, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // складтканиBindingSource
            // 
            this.складтканиBindingSource.DataSource = typeof(WindowsFormsApp1.Склад_ткани);
            // 
            // рулонDataGridViewTextBoxColumn
            // 
            this.рулонDataGridViewTextBoxColumn.DataPropertyName = "Рулон";
            this.рулонDataGridViewTextBoxColumn.HeaderText = "Рулон";
            this.рулонDataGridViewTextBoxColumn.Name = "рулонDataGridViewTextBoxColumn";
            // 
            // артикултканиDataGridViewTextBoxColumn
            // 
            this.артикултканиDataGridViewTextBoxColumn.DataPropertyName = "Артикул_ткани";
            this.артикултканиDataGridViewTextBoxColumn.HeaderText = "Артикул_ткани";
            this.артикултканиDataGridViewTextBoxColumn.Name = "артикултканиDataGridViewTextBoxColumn";
            // 
            // длинаDataGridViewTextBoxColumn
            // 
            this.длинаDataGridViewTextBoxColumn.DataPropertyName = "Длина";
            this.длинаDataGridViewTextBoxColumn.HeaderText = "Длина";
            this.длинаDataGridViewTextBoxColumn.Name = "длинаDataGridViewTextBoxColumn";
            // 
            // тканьDataGridViewTextBoxColumn
            // 
            this.тканьDataGridViewTextBoxColumn.DataPropertyName = "Ткань";
            this.тканьDataGridViewTextBoxColumn.HeaderText = "Ткань";
            this.тканьDataGridViewTextBoxColumn.Name = "тканьDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Ткани
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ткани";
            this.Text = "Ткани";
            this.Load += new System.EventHandler(this.Ткани_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.складтканиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn рулонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артикултканиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn длинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тканьDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource складтканиBindingSource;
        private System.Windows.Forms.Button button1;
    }
}