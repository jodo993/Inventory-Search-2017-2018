using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webber_Inventory
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Open search form
            SearchInventoryForm newSearchInventoryForm = new SearchInventoryForm();
            newSearchInventoryForm.ShowDialog();

            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Open add form
            AddInventoryForm newAddInventoryForm = new AddInventoryForm();
            newAddInventoryForm.ShowDialog();

            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Open edit form
            EditInventoryForm newEditInventoryForm = new EditInventoryForm();
            newEditInventoryForm.ShowDialog();

            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Open remove form
            RemoveInventoryForm newRemoveInventoryForm = new RemoveInventoryForm();
            newRemoveInventoryForm.ShowDialog();

            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
    }
}
