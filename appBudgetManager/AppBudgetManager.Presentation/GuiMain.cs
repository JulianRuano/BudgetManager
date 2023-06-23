using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace AppBudgetManager.Presentation
{
    public partial class GuiMain : Form
    {
        private Form FormSecundarios = new Form();
        public GuiMain()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
             AbrirForm(new GuiHome(pnlMain));                              
        }

        private void AbrirForm(Form FormHijo)
        {
            if (FormSecundarios != null)
            {
                FormSecundarios.Close();
            }
            FormSecundarios = FormHijo;

            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(FormHijo);
            pnlMain.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            AbrirForm(new GuiCategory(pnlMain));
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            AbrirForm(new GuiReport());
        }

        private void lblAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://www.notion.so/Operations-Diagram-ef21f43350d746718a926263c68a072f";
            Process.Start(url);
        }
    }
}
