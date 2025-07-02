using System.Windows.Forms;

namespace CarSalesApp
{
    partial class AddCarForm
    {
        private Label lblType;
        private Label lblBrand;
        private Label lblManufacturer;
        private Label lblSupplier;
        private Label lblPrice;

        private TextBox txtType;
        private TextBox txtBrand;
        private TextBox txtManufacturer;
        private TextBox txtSupplier;
        private TextBox txtPrice;

        private Button btnSave;

        private void InitializeComponent()
        {
            this.lblType = new Label();
            this.lblBrand = new Label();
            this.lblManufacturer = new Label();
            this.lblSupplier = new Label();
            this.lblPrice = new Label();

            this.txtType = new TextBox();
            this.txtBrand = new TextBox();
            this.txtManufacturer = new TextBox();
            this.txtSupplier = new TextBox();
            this.txtPrice = new TextBox();

            this.btnSave = new Button();

            this.SuspendLayout();

            // lblType
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(20, 20);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(29, 17);
            this.lblType.Text = "Вид:";

            // lblBrand
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(20, 60);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(44, 17);
            this.lblBrand.Text = "Марка:";

            // lblManufacturer
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(20, 100);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(70, 17);
            this.lblManufacturer.Text = "Виробник:";

            // lblSupplier
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(20, 140);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(83, 17);
            this.lblSupplier.Text = "Постачальник:";

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(20, 180);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 17);
            this.lblPrice.Text = "Ціна:";

            // txtType
            this.txtType.Location = new System.Drawing.Point(140, 17);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 22);

            // txtBrand
            this.txtBrand.Location = new System.Drawing.Point(140, 57);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(200, 22);

            // txtManufacturer
            this.txtManufacturer.Location = new System.Drawing.Point(140, 97);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(200, 22);

            // txtSupplier
            this.txtSupplier.Location = new System.Drawing.Point(140, 137);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(200, 22);

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(140, 177);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(200, 22);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(140, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // AddCarForm
            this.ClientSize = new System.Drawing.Size(380, 270);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblPrice);

            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtPrice);

            this.Controls.Add(this.btnSave);

            this.Name = "AddCarForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Додати автомобіль";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
