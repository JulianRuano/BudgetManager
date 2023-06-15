using System;
using AppBudGetManager.Domain.System;
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
             AbrirForm(new GuiHome());         
            ClsSystem clsSystem = new ClsSystem();
            clsSystem.CreateBudGet();
            clsSystem.CreateCategory(1, "Food", "Food expenses");
            clsSystem.CreateCategory(2, "Transport", "Transport expenses");
            clsSystem.CreateCategory(3, "Salary", "Salary incomes");
            clsSystem.CreateCategory(4, "Extra", "Extra incomes");

            clsSystem.CreateTransaction(1, 1000, default, "Salary incomes", clsSystem.fldMyCategory[2], "Incomes");
            clsSystem.CreateTransaction(2, 3000, default, "Extra incomes", clsSystem.fldMyCategory[3], "Incomes");
            clsSystem.CreateTransaction(3, 2000, default, "Food expenses", clsSystem.fldMyCategory[0], "Expenses");

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
