
namespace KiemtraLeQuocHuy
{
    partial class Form1
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
            this.cbbHopdong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Searchbt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Showbt = new System.Windows.Forms.Button();
            this.Addbt = new System.Windows.Forms.Button();
            this.Deletebt = new System.Windows.Forms.Button();
            this.Editbt = new System.Windows.Forms.Button();
            this.Sortbt = new System.Windows.Forms.Button();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbHopdong
            // 
            this.cbbHopdong.FormattingEnabled = true;
            this.cbbHopdong.Location = new System.Drawing.Point(114, 49);
            this.cbbHopdong.Name = "cbbHopdong";
            this.cbbHopdong.Size = new System.Drawing.Size(121, 24);
            this.cbbHopdong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hop Dong";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(460, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // Searchbt
            // 
            this.Searchbt.Location = new System.Drawing.Point(657, 49);
            this.Searchbt.Name = "Searchbt";
            this.Searchbt.Size = new System.Drawing.Size(75, 23);
            this.Searchbt.TabIndex = 3;
            this.Searchbt.Text = "Search";
            this.Searchbt.UseVisualStyleBackColor = true;
            this.Searchbt.Click += new System.EventHandler(this.Searchbt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(64, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 261);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sach hoa don";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(570, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // Showbt
            // 
            this.Showbt.Location = new System.Drawing.Point(100, 405);
            this.Showbt.Name = "Showbt";
            this.Showbt.Size = new System.Drawing.Size(75, 23);
            this.Showbt.TabIndex = 5;
            this.Showbt.Text = "Show";
            this.Showbt.UseVisualStyleBackColor = true;
            this.Showbt.Click += new System.EventHandler(this.Showbt_Click);
            // 
            // Addbt
            // 
            this.Addbt.Location = new System.Drawing.Point(193, 405);
            this.Addbt.Name = "Addbt";
            this.Addbt.Size = new System.Drawing.Size(75, 23);
            this.Addbt.TabIndex = 5;
            this.Addbt.Text = "Add";
            this.Addbt.UseVisualStyleBackColor = true;
            this.Addbt.Click += new System.EventHandler(this.Addbt_Click);
            // 
            // Deletebt
            // 
            this.Deletebt.Location = new System.Drawing.Point(391, 405);
            this.Deletebt.Name = "Deletebt";
            this.Deletebt.Size = new System.Drawing.Size(75, 23);
            this.Deletebt.TabIndex = 5;
            this.Deletebt.Text = "Delete";
            this.Deletebt.UseVisualStyleBackColor = true;
            this.Deletebt.Click += new System.EventHandler(this.Deletebt_Click);
            // 
            // Editbt
            // 
            this.Editbt.Location = new System.Drawing.Point(292, 405);
            this.Editbt.Name = "Editbt";
            this.Editbt.Size = new System.Drawing.Size(75, 23);
            this.Editbt.TabIndex = 5;
            this.Editbt.Text = "Edit";
            this.Editbt.UseVisualStyleBackColor = true;
            this.Editbt.Click += new System.EventHandler(this.Editbt_Click);
            // 
            // Sortbt
            // 
            this.Sortbt.Location = new System.Drawing.Point(490, 405);
            this.Sortbt.Name = "Sortbt";
            this.Sortbt.Size = new System.Drawing.Size(75, 23);
            this.Sortbt.TabIndex = 5;
            this.Sortbt.Text = "Sort";
            this.Sortbt.UseVisualStyleBackColor = true;
            this.Sortbt.Click += new System.EventHandler(this.Sortbt_Click);
            // 
            // cbbSort
            // 
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Items.AddRange(new object[] {
            "MaHoaDon",
            "SoTien",
            "NgayXuat",
            "IdhopDong"});
            this.cbbSort.Location = new System.Drawing.Point(597, 405);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(121, 24);
            this.cbbSort.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.Editbt);
            this.Controls.Add(this.Sortbt);
            this.Controls.Add(this.Deletebt);
            this.Controls.Add(this.Addbt);
            this.Controls.Add(this.Showbt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Searchbt);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbHopdong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbHopdong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button Searchbt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Showbt;
        private System.Windows.Forms.Button Addbt;
        private System.Windows.Forms.Button Deletebt;
        private System.Windows.Forms.Button Editbt;
        private System.Windows.Forms.Button Sortbt;
        private System.Windows.Forms.ComboBox cbbSort;
    }
}

