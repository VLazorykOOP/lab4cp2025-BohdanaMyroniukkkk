using System;
using System.Globalization;
using System.Windows.Forms;

namespace CarSalesApp
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtType.Text) ||
                    string.IsNullOrWhiteSpace(txtBrand.Text) ||
                    string.IsNullOrWhiteSpace(txtManufacturer.Text) ||
                    string.IsNullOrWhiteSpace(txtSupplier.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string priceInput = txtPrice.Text.Trim().Replace(',', '.');

                if (!decimal.TryParse(priceInput, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal price))
                {
                    MessageBox.Show("Введіть коректну ціну у форматі числа (наприклад, 25000.00).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DBHelper.AddCar(
                    txtType.Text.Trim(),
                    txtBrand.Text.Trim(),
                    txtManufacturer.Text.Trim(),
                    txtSupplier.Text.Trim(),
                    price
                );

                MessageBox.Show("Автомобіль додано успішно.");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Сталася помилка:\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
