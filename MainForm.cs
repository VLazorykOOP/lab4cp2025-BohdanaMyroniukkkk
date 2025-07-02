using System;
using System.Windows.Forms;

namespace CarSalesApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void LoadCars()
        {
            dataGridViewCars.DataSource = DBHelper.GetAllCars();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            dataGridViewCars.DataSource = DBHelper.SearchCars(search);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Відкриття форми додавання авто.");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть автомобіль для редагування.");
                return;
            }
            MessageBox.Show("Відкриття форми редагування авто.");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridViewCars.Rows)
            {
                if (row.Cells["price"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["price"].Value);
                }
            }
            lblTotal.Text = $"Загальна сума: {total:C}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть автомобіль для видалення.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dataGridViewCars.SelectedRows[0].Cells["id"].Value);

            var confirmResult = MessageBox.Show("Ви впевнені, що хочете видалити обраний автомобіль?",
                                                "Підтвердження видалення",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    DBHelper.DeleteCar(id);
                    MessageBox.Show("Автомобіль успішно видалено.");
                    LoadCars();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Сталася помилка при видаленні:\n" + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
