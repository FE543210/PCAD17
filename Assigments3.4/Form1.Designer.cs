namespace CoffeShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            coffeBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            decaffDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            hasMilkDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            roastDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hotDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)coffeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // coffeBindingSource
            // 
            coffeBindingSource.DataSource = typeof(Coffe);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { decaffDataGridViewCheckBoxColumn, hasMilkDataGridViewCheckBoxColumn, roastDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, sizeDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, hotDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = coffeBindingSource;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(741, 395);
            dataGridView1.TabIndex = 0;
            // 
            // decaffDataGridViewCheckBoxColumn
            // 
            decaffDataGridViewCheckBoxColumn.DataPropertyName = "Decaff";
            decaffDataGridViewCheckBoxColumn.HeaderText = "Decaff";
            decaffDataGridViewCheckBoxColumn.Name = "decaffDataGridViewCheckBoxColumn";
            // 
            // hasMilkDataGridViewCheckBoxColumn
            // 
            hasMilkDataGridViewCheckBoxColumn.DataPropertyName = "HasMilk";
            hasMilkDataGridViewCheckBoxColumn.HeaderText = "HasMilk";
            hasMilkDataGridViewCheckBoxColumn.Name = "hasMilkDataGridViewCheckBoxColumn";
            // 
            // roastDataGridViewTextBoxColumn
            // 
            roastDataGridViewTextBoxColumn.DataPropertyName = "Roast";
            roastDataGridViewTextBoxColumn.HeaderText = "Roast";
            roastDataGridViewTextBoxColumn.Name = "roastDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // hotDataGridViewCheckBoxColumn
            // 
            hotDataGridViewCheckBoxColumn.DataPropertyName = "Hot";
            hotDataGridViewCheckBoxColumn.HeaderText = "Hot";
            hotDataGridViewCheckBoxColumn.Name = "hotDataGridViewCheckBoxColumn";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 395);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Coffe Shop";
            ((System.ComponentModel.ISupportInitialize)coffeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource coffeBindingSource;
        private DataGridViewTextBoxColumn prizeDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn decaffDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn hasMilkDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn roastDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn hotDataGridViewCheckBoxColumn;
    }
}
