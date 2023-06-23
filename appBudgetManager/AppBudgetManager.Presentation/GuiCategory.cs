using appBudgetManager.Domain;
using System;
using System.Data;
using System.Windows.Forms;

namespace AppBudgetManager.Presentation
{
    public partial class GuiCategory : Form
    {
        private ClsSystemServices objSystemServices;
        private Form FormSecundarios = new Form();
        private DataTable dt = new DataTable();
        private Panel pnlMain;

        public GuiCategory(Panel prmPanel)
        {
            InitializeComponent();
            pnlMain = prmPanel;
            objSystemServices = ClsSystemServices.GetInstance();
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Description");
            DGVHome.DataSource = dt;
            loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Edit category
            if(txtIdCategory.Text != "")
            {
                int idCategory = int.Parse(txtIdCategory.Text);
                // verificar si existe la categoria
                if (objSystemServices.GetSystem().CategoryExistsBool(idCategory))
                {
                    AbrirForm(new GuiUpdateCategory(idCategory));
                }
                else
                {
                    MessageBox.Show("Category not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter the Category id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Are you sure you want to delete the data??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {return;}
            // Delete category
            if (txtIdCategory.Text != "")
            {
                int idCategory = int.Parse(txtIdCategory.Text);
                // verificar si existe la categoria
                if (objSystemServices.GetSystem().CategoryExistsBool(idCategory))
                {
                    objSystemServices.DeleteCategory(idCategory);
                    MessageBox.Show("Category deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIdCategory.Text = "";
                    loadData();
                }
                else
                {
                    MessageBox.Show("Category not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please enter the Category id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void addTransaction_Click(object sender, EventArgs e)
        {
            AbrirForm(new GuiAddCategory());
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

        private void loadData()
        {
            // print categories
            dt.Clear();
            for (int i = 0; i < objSystemServices.GetSystem().GetListCategories().Count; i++)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["ID"] = objSystemServices.GetSystem().GetListCategories()[i].GetIdCategory();
                dataRow["Name"] = objSystemServices.GetSystem().GetListCategories()[i].GetName();
                dataRow["Description"] = objSystemServices.GetSystem().GetListCategories()[i].GetDescription();
                dt.Rows.Add(dataRow);
            }
        }

        #region Events
        private void onlyNumbers(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void txtIdCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(e);
        }

        #endregion
    }
}
