namespace BT5._2
{
    partial class FormTinhTien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblTongTien = new Label();
            label4 = new Label();
            lblThanhTien = new Label();
            cboCategory = new ComboBox();
            txtTongTien = new TextBox();
            txtChietKhau = new TextBox();
            txtThanhTien = new TextBox();
            lstAvailableServices = new ListBox();
            lstSelectedServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 26);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Chọn danh mục:";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(278, 288);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(59, 15);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng Tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 323);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 2;
            label4.Text = "Chiết Khấu (%)";
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.ForeColor = Color.Red;
            lblThanhTien.Location = new Point(274, 360);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(68, 15);
            lblThanhTien.TabIndex = 3;
            lblThanhTien.Text = "Thành Tiền:";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Khám bệnh", "X-quang", "Vắc-xin", "Xét Nghiệm" });
            cboCategory.Location = new Point(189, 26);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(121, 23);
            cboCategory.TabIndex = 4;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(366, 280);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(100, 23);
            txtTongTien.TabIndex = 5;
            txtTongTien.Text = "0 VND";
            // 
            // txtChietKhau
            // 
            txtChietKhau.Location = new Point(366, 323);
            txtChietKhau.Name = "txtChietKhau";
            txtChietKhau.Size = new Size(100, 23);
            txtChietKhau.TabIndex = 6;
            txtChietKhau.TextChanged += textBox2_TextChanged;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(366, 360);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(100, 23);
            txtThanhTien.TabIndex = 7;
            txtThanhTien.Text = "0 VND";
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(126, 63);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(184, 169);
            lstAvailableServices.TabIndex = 8;
            lstAvailableServices.SelectedIndexChanged += lstAvailableServices_SelectedIndexChanged;
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(443, 63);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(183, 169);
            lstSelectedServices.TabIndex = 9;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(336, 63);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 10;
            btnSelect.Text = ">";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(336, 106);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(336, 150);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(75, 23);
            btnClearAll.TabIndex = 12;
            btnClearAll.Text = "<<";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // FormTinhTien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(lstSelectedServices);
            Controls.Add(lstAvailableServices);
            Controls.Add(txtThanhTien);
            Controls.Add(txtChietKhau);
            Controls.Add(txtTongTien);
            Controls.Add(cboCategory);
            Controls.Add(lblThanhTien);
            Controls.Add(label4);
            Controls.Add(lblTongTien);
            Controls.Add(label1);
            Name = "FormTinhTien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Dịch Vụ Khám Bệnh";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTongTien;
        private Label label4;
        private Label lblThanhTien;
        private ComboBox cboCategory;
        private TextBox txtTongTien;
        private TextBox txtChietKhau;
        private TextBox txtThanhTien;
        private ListBox lstAvailableServices;
        private ListBox lstSelectedServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
    }
}
