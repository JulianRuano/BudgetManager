using System;
using AppBudGetManager.Domain.System;
using System.Windows.Forms;

namespace AppBudgetManager.Presentation
{
    public partial class GuiMain : Form
    {
        private Form FormSecundarios = new Form();
        private ClsSystem objSystem;
        public GuiMain()
        {
            InitializeComponent();
            objSystem = new ClsSystem();
            objSystem.CreateBudGet();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
             AbrirForm(new GuiHome(objSystem,pnlMain));                              
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
    }
}
