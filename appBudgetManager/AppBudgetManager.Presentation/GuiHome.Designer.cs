namespace AppBudgetManager.Presentation
{
    partial class GuiHome
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.addTransaction = new System.Windows.Forms.PictureBox();
            this.btnExpenses = new System.Windows.Forms.PictureBox();
            this.btnIncomes = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdTransaction = new System.Windows.Forms.TextBox();
            this.DGVHome = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTypeBalance = new System.Windows.Forms.Label();
            this.lblAux = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIncomes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(211, 53);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(94, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Total";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(211, 108);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(128, 39);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "10.500";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id transaction";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::AppBudgetManager.Presentation.Properties.Resources.Delete;
            this.btnDelete.InitialImage = null;
            this.btnDelete.Location = new System.Drawing.Point(547, 600);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 49);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 9;
            this.btnDelete.TabStop = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::AppBudgetManager.Presentation.Properties.Resources.Edit;
            this.btnEdit.InitialImage = null;
            this.btnEdit.Location = new System.Drawing.Point(491, 600);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 49);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 8;
            this.btnEdit.TabStop = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // addTransaction
            // 
            this.addTransaction.Image = global::AppBudgetManager.Presentation.Properties.Resources.Frame;
            this.addTransaction.InitialImage = null;
            this.addTransaction.Location = new System.Drawing.Point(314, 543);
            this.addTransaction.Name = "addTransaction";
            this.addTransaction.Size = new System.Drawing.Size(50, 49);
            this.addTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addTransaction.TabIndex = 7;
            this.addTransaction.TabStop = false;
            this.addTransaction.Click += new System.EventHandler(this.addTransaction_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Image = global::AppBudgetManager.Presentation.Properties.Resources.Expenses;
            this.btnExpenses.Location = new System.Drawing.Point(477, 172);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(225, 81);
            this.btnExpenses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExpenses.TabIndex = 4;
            this.btnExpenses.TabStop = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btnIncomes
            // 
            this.btnIncomes.Image = global::AppBudgetManager.Presentation.Properties.Resources.Incomes;
            this.btnIncomes.Location = new System.Drawing.Point(112, 172);
            this.btnIncomes.Name = "btnIncomes";
            this.btnIncomes.Size = new System.Drawing.Size(225, 81);
            this.btnIncomes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIncomes.TabIndex = 3;
            this.btnIncomes.TabStop = false;
            this.btnIncomes.Click += new System.EventHandler(this.btnIncomes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppBudgetManager.Presentation.Properties.Resources.dolar;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(155, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtIdTransaction
            // 
            this.txtIdTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdTransaction.Location = new System.Drawing.Point(274, 611);
            this.txtIdTransaction.Name = "txtIdTransaction";
            this.txtIdTransaction.Size = new System.Drawing.Size(199, 38);
            this.txtIdTransaction.TabIndex = 10;
            this.txtIdTransaction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdTransaction_KeyPress);
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
            this.DGVHome.Location = new System.Drawing.Point(79, 272);
            this.DGVHome.Name = "DGVHome";
            this.DGVHome.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVHome.RowHeadersVisible = false;
            this.DGVHome.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateBlue;
            this.DGVHome.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVHome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVHome.Size = new System.Drawing.Size(677, 243);
            this.DGVHome.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AppBudgetManager.Presentation.Properties.Resources.dolar;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(491, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // lblTypeBalance
            // 
            this.lblTypeBalance.AutoSize = true;
            this.lblTypeBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeBalance.Location = new System.Drawing.Point(547, 53);
            this.lblTypeBalance.Name = "lblTypeBalance";
            this.lblTypeBalance.Size = new System.Drawing.Size(144, 37);
            this.lblTypeBalance.TabIndex = 13;
            this.lblTypeBalance.Text = "Incomes";
            // 
            // lblAux
            // 
            this.lblAux.AutoSize = true;
            this.lblAux.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAux.Location = new System.Drawing.Point(547, 108);
            this.lblAux.Name = "lblAux";
            this.lblAux.Size = new System.Drawing.Size(128, 39);
            this.lblAux.TabIndex = 14;
            this.lblAux.Text = "10.500";
            // 
            // GuiHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 689);
            this.Controls.Add(this.lblAux);
            this.Controls.Add(this.lblTypeBalance);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.DGVHome);
            this.Controls.Add(this.txtIdTransaction);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.addTransaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnIncomes);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GuiHome";
            this.Text = "GuiHomecs";
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIncomes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.PictureBox btnIncomes;
        private System.Windows.Forms.PictureBox btnExpenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox addTransaction;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.TextBox txtIdTransaction;
        private System.Windows.Forms.DataGridView DGVHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTypeBalance;
        private System.Windows.Forms.Label lblAux;
    }
}