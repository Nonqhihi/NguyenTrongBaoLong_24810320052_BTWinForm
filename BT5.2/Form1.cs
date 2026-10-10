namespace BT5._2
{
    public partial class FormTinhTien : Form
    {
        public FormTinhTien()
        {
            InitializeComponent();
        }
        private void TinhTien()
        {
            double tongTien = 0;
            foreach (var item in lstSelectedServices.Items)
            {
                string[] parts = item.ToString().Split(new string[] { " - " }, StringSplitOptions.None);
                if (parts.Length >= 2)
                {
                    tongTien += Convert.ToDouble(parts[parts.Length - 1].Trim());
                }
            }

            double chietKhau = 0;
            if (!string.IsNullOrWhiteSpace(txtChietKhau.Text))
            {

                try
                {
                    chietKhau = Convert.ToDouble(txtChietKhau.Text);
                }
                catch
                {
                    chietKhau = 0; 
            }

            if (chietKhau < 0) chietKhau = 0;
            if (chietKhau > 100) chietKhau = 100;

            double thanhTien = tongTien - (tongTien * (chietKhau / 100.0));


            txtTongTien.Text = $"{tongTien:N0} VNĐ";
            txtThanhTien.Text = $"{thanhTien:N0} VNĐ";
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();

  
            string danhMuc = cboCategory.Text;

            if (danhMuc == "Khám bệnh")
            {
                lstAvailableServices.Items.Add("Khám tổng quát - 500000");
                lstAvailableServices.Items.Add("Khám nội khoa - 150000");
                lstAvailableServices.Items.Add("Khám ngoại khoa - 200000");
            }
            else if (danhMuc == "Xét Nghiệm")
            {
                lstAvailableServices.Items.Add("Xét nghiệm máu - 100000");
                lstAvailableServices.Items.Add("Sinh hóa máu - 250000");
                lstAvailableServices.Items.Add("Đường huyết - 80000");
            }
            else if (danhMuc == "X-quang")
            {
                lstAvailableServices.Items.Add("X-Quang phổi - 150000");
                lstAvailableServices.Items.Add("X-Quang xương - 200000");
            }
            else if (danhMuc == "Vắc-xin")
            {
                lstAvailableServices.Items.Add("Vắc-xin Cúm - 350000");
                lstAvailableServices.Items.Add("Vắc-xin HPV - 1200000");
            }
        }
        

        private void lstAvailableServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Add(lstAvailableServices.SelectedItem);
                TinhTien(); 
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(lstSelectedServices.SelectedItem);
                TinhTien();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            TinhTien();
        }

        // SỰ KIỆN: Tính lại tiền ngay lập tức khi người dùng gõ số vào ô Chiết khấu
        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
         
            TinhTien();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         
            TinhTien();
        }
    }
}
