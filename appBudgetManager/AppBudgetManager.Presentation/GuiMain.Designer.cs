namespace AppBudgetManager.Presentation
{
    partial class GuiMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.PictureBox();
            this.btnCategories = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTwitter = new System.Windows.Forms.PictureBox();
            this.btnEmail = new System.Windows.Forms.PictureBox();
            this.btnGit = new System.Windows.Forms.PictureBox();
            this.lblAyuda = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(246, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(856, 728);
            this.pnlMain.TabIndex = 7;
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Image = global::AppBudgetManager.Presentation.Properties.Resources.Report;
            this.btnReport.Location = new System.Drawing.Point(12, 418);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(228, 58);
            this.btnReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnReport.TabIndex = 10;
            this.btnReport.TabStop = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.Image = global::AppBudgetManager.Presentation.Properties.Resources.Category;
            this.btnCategories.Location = new System.Drawing.Point(12, 335);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(228, 58);
            this.btnCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCategories.TabIndex = 9;
            this.btnCategories.TabStop = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = global::AppBudgetManager.Presentation.Properties.Resources.Home;
            this.btnHome.Location = new System.Drawing.Point(12, 251);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(228, 58);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 8;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AppBudgetManager.Presentation.Properties.Resources.Drink_coffee_jdqb;
            this.pictureBox1.Location = new System.Drawing.Point(57, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnTwitter
            // 
            this.btnTwitter.Image = global::AppBudgetManager.Presentation.Properties.Resources.Twitter;
            this.btnTwitter.Location = new System.Drawing.Point(159, 638);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(46, 46);
            this.btnTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnTwitter.TabIndex = 6;
            this.btnTwitter.TabStop = false;
            // 
            // btnEmail
            // 
            this.btnEmail.Image = global::AppBudgetManager.Presentation.Properties.Resources.Gmail;
            this.btnEmail.Location = new System.Drawing.Point(91, 638);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(46, 46);
            this.btnEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEmail.TabIndex = 5;
            this.btnEmail.TabStop = false;
            // 
            // btnGit
            // 
            this.btnGit.Image = global::AppBudgetManager.Presentation.Properties.Resources.Git;
            this.btnGit.Location = new System.Drawing.Point(23, 638);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(46, 46);
            this.btnGit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGit.TabIndex = 4;
            this.btnGit.TabStop = false;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Location = new System.Drawing.Point(100, 700);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(37, 13);
            this.lblAyuda.TabIndex = 11;
            this.lblAyuda.TabStop = true;
            this.lblAyuda.Text = "Ayuda";
            this.lblAyuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAyuda_LinkClicked);
            // 
            // GuiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(1104, 732);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnCategories);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnTwitter);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnGit);
            this.Name = "GuiMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget manager";
            ((System.ComponentModel.ISupportInitialize)(this.btnReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnGit;
        private System.Windows.Forms.PictureBox btnEmail;
        private System.Windows.Forms.PictureBox btnTwitter;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.PictureBox btnCategories;
        private System.Windows.Forms.PictureBox btnReport;
        private System.Windows.Forms.LinkLabel lblAyuda;
    }
}

