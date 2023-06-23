namespace AppBudgetManager.Presentation
{
    partial class GuiCategory
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
            this.DGVHome = new System.Windows.Forms.DataGridView();
            this.txtIdCategory = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.addTransaction = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVHome
            // 
            this.DGVHome.AllowUserToAddRows = false;
            this.DGVHome.AllowUserToDeleteRows = false;
            this.DGVHome.AllowUserToResizeRows = false;
            this.DGVHome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVHome.BackgroundColor = System.Drawing.Color.White;
            this.DGVHome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVHome.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVHome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVHome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVHome.EnableHeadersVisualStyles = false;
            this.DGVHome.GridColor = System.Drawing.Color.Navy;
            this.DGVHome.Location = new System.Drawing.Point(72, 220);
            this.DGVHome.Name = "DGVHome";
            this.DGVHome.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVHome.RowHeadersVisible = false;
            this.DGVHome.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.DGVHome.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVHome.Size = new System.Drawing.Size(677, 310);
            this.DGVHome.TabIndex = 12;
            // 
            // txtIdCategory
            // 
            this.txtIdCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCategory.Location = new System.Drawing.Point(234, 584);
            this.txtIdCategory.Name = "txtIdCategory";
            this.txtIdCategory.Size = new System.Drawing.Size(199, 38);
            this.txtIdCategory.TabIndex = 15;
            this.txtIdCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCategory_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::AppBudgetManager.Presentation.Properties.Resources.Delete;
            this.btnDelete.InitialImage = null;
            this.btnDelete.Location = new System.Drawing.Point(506, 576);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 49);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 18;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::AppBudgetManager.Presentation.Properties.Resources.Edit;
            this.btnEdit.InitialImage = null;
            this.btnEdit.Location = new System.Drawing.Point(450, 576);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 49);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 17;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // addTransaction
            // 
            this.addTransaction.Image = global::AppBudgetManager.Presentation.Properties.Resources.Frame;
            this.addTransaction.InitialImage = null;
            this.addTransaction.Location = new System.Drawing.Point(383, 76);
            this.addTransaction.Name = "addTransaction";
            this.addTransaction.Size = new System.Drawing.Size(50, 49);
            this.addTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addTransaction.TabIndex = 16;
            this.addTransaction.TabStop = false;
            this.addTransaction.Click += new System.EventHandler(this.addTransaction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Id Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add Category";
            // 
            // GuiCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.addTransaction);
            this.Controls.Add(this.txtIdCategory);
            this.Controls.Add(this.DGVHome);
            this.Name = "GuiCategory";
            this.Text = "GuiAddCategory";
            ((System.ComponentModel.ISupportInitialize)(this.DGVHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVHome;
        private System.Windows.Forms.TextBox txtIdCategory;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox addTransaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}