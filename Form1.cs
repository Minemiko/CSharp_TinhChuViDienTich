using System.Diagnostics.Eventing.Reader;

namespace CSharp_TinhChuViDienTich
{
    public partial class Form1 : Form
    {
        double a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private bool TimThongTin()
        {
            try
            {
                a = Convert.ToDouble(txtCD.Text);
                b = Convert.ToDouble(txtCR.Text);
                return true;
            } catch {
                MessageBox.Show("You stupid", "Bruh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCD.Clear();
                txtCR.Clear();
                txtCD.Focus();
                return false;
            }
        }

        private double TinhChuvi(double a, double b)
        {
            return (a + b) * 2;
        }
        private double TinhDienTich(double a, double b)
        {
            return a * b;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (TimThongTin())
            {
                txtKQ.Text = "- Chu vi: " + TinhChuvi(a, b) + Environment.NewLine + "- Diện tích: " + TinhDienTich(a, b);
            }
            else
            {
                txtKQ.Text = "";
            }
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            if (TimThongTin())
            {
                txtKQ.Text = "- Chu vi: " + TinhChuvi(a, b);
            }
            else
            {
                txtKQ.Text = "";
            }
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            if (TimThongTin())
            {
                txtKQ.Text = "- Diện tích: " + TinhDienTich(a, b);
            }
            else
            {
                txtKQ.Text = "";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtCD.Clear();
            txtCR.Clear();
            txtKQ.Clear();
            txtCD.Focus();
        }
    }
}
