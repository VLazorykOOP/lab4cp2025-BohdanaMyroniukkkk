using System.Windows.Forms;

namespace CarSalesApp
{
    partial class MainForm
    {
        private DataGridView dataGridViewCars;
        private TextBox txtSearch;
        private Label lblTotal;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnSearch;
        private Button btnTotal;
        private Button btnDelete;  

        private void InitializeComponent()
        {
            this.dataGridViewCars = new DataGridView();
            this.txtSearch = new TextBox();
            this.lblTotal = new Label();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnSearch = new Button();
            this.btnTotal = new Button();
            this.btnDelete = new Button();  

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();

            // dataGridViewCars
            this.dataGridViewCars.AllowUserToAddRows = false;
            this.dataGridViewCars.AllowUserToDeleteRows = false;
            this.dataGridViewCars.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewCars.MultiSelect = false;
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.ReadOnly = true;
            this.dataGridViewCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCars.Size = new System.Drawing.Size(760, 300);

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Size = new System.Drawing.Size(150, 22);
            this.txtSearch.Name = "txtSearch";

            // btnSearch
            this.btnSearch.Text = "Пошук";
            this.btnSearch.Location = new System.Drawing.Point(170, 10);
            this.btnSearch.Size = new System.Drawing.Size(75, 25);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.Name = "btnSearch";

            // btnAdd
            this.btnAdd.Text = "Додати";
            this.btnAdd.Location = new System.Drawing.Point(260, 10);
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.Name = "btnAdd";

            // btnEdit
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.Location = new System.Drawing.Point(350, 10);
            this.btnEdit.Size = new System.Drawing.Size(90, 25);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.Name = "btnEdit";

            // btnTotal
            this.btnTotal.Text = "Звіт: Сума цін";
            this.btnTotal.Location = new System.Drawing.Point(460, 10);
            this.btnTotal.Size = new System.Drawing.Size(110, 25);
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            this.btnTotal.Name = "btnTotal";

            // btnDelete 
            this.btnDelete.Text = "Видалити";
            this.btnDelete.Location = new System.Drawing.Point(580, 10);
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.Name = "btnDelete";

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(670, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 17);

            // MainForm
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.dataGridViewCars);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnDelete);  
            this.Controls.Add(this.lblTotal);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Продаж автомашин";

            this.Load += new System.EventHandler(this.MainForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
