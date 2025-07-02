using System;
using System.Management;
using System.Windows.Forms;

namespace CarSalesApp
{
    public partial class EditCarForm : Form
    {
        private int carId;

        public EditCarForm(int id, string type, string brand, string manufacturer, string supplier, decimal price)
        {
            InitializeComponent();
            carId = id;
            txtType.Text = type;
            txtBrand.Text = brand;
            txtManufacturer.Text = manufacturer;
            txtSupplier.Text = supplier;
            txtPrice.Text = price.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string type = txtType.Text.Trim();
                string brand = txtBrand.Text.Trim();
                string manufacturer = txtManufacturer.Text.Trim();
                string supplier = txtSupplier.Text.Trim();
                decimal price = decimal.Parse(txtPrice.Text);

                DBHelper.UpdateCar(carId, type, brand, manufacturer, supplier, price);
                MessageBox.Show("Запис оновлено!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
