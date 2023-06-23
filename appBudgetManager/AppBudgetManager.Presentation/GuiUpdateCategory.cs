using appBudgetManager.Domain;
using System;
using System.Windows.Forms;

namespace AppBudgetManager.Presentation
{
    public partial class GuiUpdateCategory : Form
    {
        private ClsSystemServices objSystemServices;
        private int idCategory;
        public GuiUpdateCategory(int prmIdCategory)
        {
            InitializeComponent();
            idCategory = prmIdCategory;
            loadData();          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDescription.Text;

            // Update category
            objSystemServices.UpdateCategory(0, name, description);
            MessageBox.Show("Category updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtName.Text = "";
            txtDescription.Text = "";

        }
        private void loadData()
        {
            objSystemServices = ClsSystemServices.GetInstance();
            txtName.Text = objSystemServices.GetSystem().CategoryExists(idCategory).GetName();
            txtDescription.Text = objSystemServices.GetSystem().CategoryExists(idCategory).GetDescription();
        }   
    }
}
