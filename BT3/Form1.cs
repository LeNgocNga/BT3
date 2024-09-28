using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BT3
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

       
        private void Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (products.Any(p => p.MaSP == textBox1.Text))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product product = new Product
            {
                MaSP = textBox1.Text,
                TenSP = textBox4.Text,
                SoLuong = int.Parse(textBox2.Text),
                DonGia = decimal.Parse(textBox3.Text),
                XuatXu = textBox5.Text,
                NgayHetHan = dateTimePicker1.Value
            };
            products.Add(product);
            RefreshProductList();
        }


        private void DSSP_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem item = e.Item;                
                textBox1.Text = item.SubItems[0].Text; 
                textBox4.Text = item.SubItems[1].Text; 
                textBox2.Text = item.SubItems[2].Text; 
                textBox3.Text = item.SubItems[3].Text; 
                textBox5.Text = item.SubItems[4].Text;
                dateTimePicker1.Value = DateTime.Parse(item.SubItems[5].Text); 
            }
        }


        private void Xoa_Click(object sender, EventArgs e)
        {
            string maSP = textBox1.Text;
            products.RemoveAll(p => p.MaSP == maSP);
            RefreshProductList();
        }

       
        private void XoaXX_Click(object sender, EventArgs e)
        {
            string xuatXu = NoiXX.Text;
            products.RemoveAll(p => p.XuatXu.ToLower() == xuatXu.ToLower());
            RefreshProductList();
        }

       
        private void KTSPQH_Click(object sender, EventArgs e)
        {
            bool hasExpiredProducts = products.Exists(p => p.NgayHetHan < DateTime.Now);
            MessageBox.Show(hasExpiredProducts ? "Có sản phẩm quá hạn." : "Không có sản phẩm quá hạn.");
        }

        
        private void XoaTB_Click(object sender, EventArgs e)
        {
            products.Clear();
            RefreshProductList();
        }

       
        private void XoaSPQH_Click(object sender, EventArgs e)
        {
            products.RemoveAll(p => p.NgayHetHan < DateTime.Now);
            RefreshProductList();
        }


        private void SPCN_Click(object sender, EventArgs e)
        {
          
            var sanPhamCaoNhat = products.OrderByDescending(p => p.DonGia).FirstOrDefault();

           
            if (sanPhamCaoNhat != null)
            {
                ListTimKiem.Items.Clear();
                ListViewItem item = new ListViewItem(new[] {
                sanPhamCaoNhat.MaSP, sanPhamCaoNhat.TenSP, sanPhamCaoNhat.SoLuong.ToString(),
                sanPhamCaoNhat.DonGia.ToString(), sanPhamCaoNhat.XuatXu, sanPhamCaoNhat.NgayHetHan.ToShortDateString()});
                ListTimKiem.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void SPQH_Click(object sender, EventArgs e)
        {
            var expiredProducts = products.Where(p => p.NgayHetHan < DateTime.Now).ToList();
            if (expiredProducts.Any())
            {
                ListTimKiem.Items.Clear();
                foreach (var product in expiredProducts)
                {
                    ListViewItem item = new ListViewItem(new[] {
                        product.MaSP, product.TenSP, product.SoLuong.ToString(),
                        product.DonGia.ToString(), product.XuatXu, product.NgayHetHan.ToShortDateString()
                    });
                    ListTimKiem.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào quá hạn.");
            }
        }

        
        private void TimKiemTheoDonGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ĐG1.Text) || string.IsNullOrWhiteSpace(ĐG2.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ giá trị cho cả ĐG1 và ĐG2.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {

                decimal minPrice = decimal.Parse(ĐG1.Text);
                decimal maxPrice = decimal.Parse(ĐG2.Text);
                var filteredProducts = products.Where(p => p.DonGia >= minPrice && p.DonGia <= maxPrice).ToList();

                ListTimKiem.Items.Clear();
                foreach (var product in filteredProducts)
                {
                    ListViewItem item = new ListViewItem(new[] {
                    product.MaSP, product.TenSP, product.SoLuong.ToString(),
                    product.DonGia.ToString(), product.XuatXu, product.NgayHetHan.ToShortDateString()
                });
                    ListTimKiem.Items.Add(item);
                }
            }
        }

        
        private void RefreshProductList()
        {
            DSSP.Items.Clear();
            foreach (var product in products)
            {
                ListViewItem item = new ListViewItem(new[] {
                    product.MaSP, product.TenSP, product.SoLuong.ToString(),
                    product.DonGia.ToString(), product.XuatXu, product.NgayHetHan.ToShortDateString()
                });
                DSSP.Items.Add(item);
            }
        }

        private void SPNB_Click(object sender, EventArgs e)
        {
           
            var sanPhamNhatBan = products.FirstOrDefault(p => p.XuatXu.ToLower() == "nhật bản");

            
            if (sanPhamNhatBan != null)
            {
                ListTimKiem.Items.Clear();
                ListViewItem item = new ListViewItem(new[] { 
                    sanPhamNhatBan.MaSP, sanPhamNhatBan.TenSP, sanPhamNhatBan.SoLuong.ToString(),
                    sanPhamNhatBan.DonGia.ToString(), sanPhamNhatBan.XuatXu, sanPhamNhatBan.NgayHetHan.ToShortDateString()
                });
                ListTimKiem.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào có xuất xứ từ Nhật Bản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





    }


    public class Product
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public string XuatXu { get; set; }
        public DateTime NgayHetHan { get; set; }
    }
}
