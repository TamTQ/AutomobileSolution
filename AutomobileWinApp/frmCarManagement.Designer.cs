namespace AutomobileWinApp
{
    partial class frmCarManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCarID = new Label();
            txtCarName = new TextBox();
            txtCarID = new TextBox();
            lbCarName = new Label();
            lbPrice = new Label();
            txtReleaseYear = new TextBox();
            txtPrice = new TextBox();
            lbReleaseYear = new Label();
            txtManufacturer = new TextBox();
            lbManufacturer = new Label();
            btnNew = new Button();
            btnLoad = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(41, 39);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 16;
            lbCarID.Text = "Car ID";
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(152, 95);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(206, 27);
            txtCarName.TabIndex = 15;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(152, 36);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(206, 27);
            txtCarID.TabIndex = 14;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(41, 98);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 13;
            lbCarName.Text = "Car Name";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(423, 39);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 20;
            lbPrice.Text = "Price";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(534, 95);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(206, 27);
            txtReleaseYear.TabIndex = 19;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(534, 36);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(206, 27);
            txtPrice.TabIndex = 18;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(423, 98);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(101, 20);
            lbReleaseYear.TabIndex = 17;
            lbReleaseYear.Text = "Released Year";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(152, 152);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(206, 27);
            txtManufacturer.TabIndex = 22;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(41, 155);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(97, 20);
            lbManufacturer.TabIndex = 21;
            lbManufacturer.Text = "Manufacturer";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(354, 196);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 35);
            btnNew.TabIndex = 24;
            btnNew.TabStop = false;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(151, 196);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 35);
            btnLoad.TabIndex = 26;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(556, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 35);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(12, 250);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(776, 188);
            dgvCarList.TabIndex = 28;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(354, 444);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 32);
            btnClose.TabIndex = 29;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(btnNew);
            Controls.Add(txtManufacturer);
            Controls.Add(lbManufacturer);
            Controls.Add(lbPrice);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbCarID);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbCarName);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private TextBox txtCarName;
        private TextBox txtCarID;
        private Label lbCarName;
        private Label lbPrice;
        private TextBox txtReleaseYear;
        private TextBox txtPrice;
        private Label lbReleaseYear;
        private TextBox txtManufacturer;
        private Label lbManufacturer;
        private Button btnNew;
        private Button btnLoad;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}