using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Webber_Inventory
{
    public partial class AddInventoryForm : Form
    {
        // Open connection to database
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\josep\Documents\GeneralInventory.mdf;Integrated Security=True;Connect Timeout=30");
        public AddInventoryForm()
        {
            InitializeComponent();
        }

        private void addMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenuForm newMainMenuForm = new MainMenuForm();
            newMainMenuForm.ShowDialog();

            this.Close();
        }

        private void addExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDesktopButton_Click(object sender, EventArgs e)
        {
            addTypeTextBox.Text = "Desktop";
        }

        private void addLaptopButton_Click(object sender, EventArgs e)
        {
            addTypeTextBox.Text = "Laptop";
        }

        private void addChromebookButton_Click(object sender, EventArgs e)
        {
            addTypeTextBox.Text = "Chromebook";
        }

        private void addMonitorButton_Click(object sender, EventArgs e)
        {
            addTypeTextBox.Text = "Monitor";
        }

        private void addPrinterButton_Click(object sender, EventArgs e)
        {
            addTypeTextBox.Text = "Printer";
        }

        private void addSmartboardButton_Click(object sender, EventArgs e)
        {
            addTypeTextBox.Text = "Smartboard";
        }

        private void addProjectorButton_Click(object sender, EventArgs e)
        {
            addTypeTextBox.Text = "Projector";
        }

        private void addTabletButton_Click(object sender, EventArgs e)
        {
            addTypeTextBox.Text = "Tablet";
        }

        private void addWapButton_Click(object sender, EventArgs e)
        {
            addTypeTextBox.Text = "WAP";
        }

        private void addAccessoriesButton_Click(object sender, EventArgs e)
        {
            addTypeTextBox.Text = "Accessories";
        }

        private void addActiveButton_Click(object sender, EventArgs e)
        {
            addStatusTextBox.Text = "Active";
        }

        private void addInactiveButton_Click(object sender, EventArgs e)
        {
            addStatusTextBox.Text = "Inactive";
        }

        private void addSurplusButton_Click(object sender, EventArgs e)
        {
            addStatusTextBox.Text = "Surplus";
        }

        private void addRepairButton_Click(object sender, EventArgs e)
        {
            addStatusTextBox.Text = "Repair";
        }

        private void addUnknownButton_Click(object sender, EventArgs e)
        {
            addStatusTextBox.Text = "Unknown";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Verify user choice
            addVerifyLabel.Visible = true;
            yesButton.Visible = true;
            noButton.Visible = true;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            // Hide label and buttons and notify user add was successful
            addVerifyLabel.Visible = false;
            yesButton.Visible = false;
            noButton.Visible = false;

            // Write the information into the database
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into GeneralInventoryTable values('" + addTypeTextBox.Text + "','" + addMakeTextBox.Text + "','" + addModelTextBox.Text + "','" + addTagTextBox.Text + "','" + addLocationComboBox.Text + "','" + addStatusTextBox.Text + "')";
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Item was successfully added!");
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            // Hide label and buttons and notify user add failed
            addVerifyLabel.Visible = false;
            yesButton.Visible = false;
            noButton.Visible = false;
        }

        private void addClearButton_Click(object sender, EventArgs e)
        {
            // Clear all fields
            addTypeTextBox.Text = "";
            addMakeTextBox.Text = "";
            addModelTextBox.Text = "";
            addTagTextBox.Text = "";
            addLocationComboBox.Text = "";
            addStatusTextBox.Text = "";

            addVerifyLabel.Visible = false;
            yesButton.Visible = false;
            noButton.Visible = false;
        }
    }
}
