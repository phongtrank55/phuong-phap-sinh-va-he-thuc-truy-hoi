using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ppsinh
{
    
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        private Nghiem Tinh(float b, float c, float a=1)
        {
            float Delta = b * b - 4 * a * c;
            if (Delta < 0) return null;
            if (Delta == 0) return new Nghiem(-b / (2 * a), -b / (2 * a));
            return new Nghiem((-b + (float)Math.Sqrt(Delta)) / (2 * a),(-b - (float)Math.Sqrt(Delta)) / (2 * a));
        }
        
        private void btnHethuc_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtC1.Text);
            float b = float.Parse(txtC2.Text);
            float f0 = float.Parse(txtF0.Text);
            float f1 = float.Parse(txtF1.Text);
            Nghiem sol = Tinh(-a, -b);
            if(sol==null)
            {
                txtHethuc.Text = "Không giải được!";
            }
            else if (sol.x1 == sol.x2)
            {
                //pt a1*r^n + n*a2*r^n
                HePt Hept = new HePt(1, 0, f0, sol.x1, sol.x1, f1);
                Nghiem s = Hept.Cal();
                //Xử lý hiển thị
                string vt, vp, sa1, sa2, sr1, sr2;
                //vế trái
                if (sol.x1 == 0 || s.x1 == 0) vt = "";
                else
                {
                    sa1 = ((s.x1 < 0) || ((int)s.x1 != s.x1)) ? "(" + s.x1.ToString() + ")" : s.x1.ToString();
                    sr1 = ((sol.x1 < 0) || ((int)sol.x1 != sol.x1)) ? "(" + sol.x1.ToString() + ")" : sol.x1.ToString();
                    sr1 += "^n";
                    if (s.x1 == 1) sa1 = "";
                    if (sa1 != "") sr1 = "*" + sr1;
                    vt = sa1 + sr1;
                }

                //vế phải
                if (sol.x2 == 0 || s.x2 == 0) vp = "";
                else
                {
                    sr2 = ((sol.x1 < 0) || ((int)sol.x1 != sol.x1)) ? "(" + sol.x1.ToString() + ")" : sol.x1.ToString();
                    sr2 += "^n";
                    sa2 = ((s.x2 < 0) || ((int)s.x2 != s.x2)) ? "(" + s.x2.ToString() + ")" : s.x2.ToString();
                    if (s.x2 == 1) sa2 = "";
                    if (sa2 != "") sr2 = "*" + sr2;
                    vp = vt==""? " n*" + sa2 + sr2: " + n*" + sa2 + sr2;
                }
                txtHethuc.Text = vt + vp;
                //txtHethuc.Text = s.x1.ToString() + "*" + sol.x1.ToString() + "^n + n*" + s.x2.ToString() + "*" + sol.x2.ToString() + "^n";
            }
            else
            {
                //pt a1*r1^n + a2*r2^n
                HePt Hept = new HePt(1, 1, f0, sol.x1, sol.x2, f1);
                Nghiem s = Hept.Cal();
                //Xử lý hiển thị
                string vt, vp, sa1, sa2, sr1, sr2;
                //vế trái
                if (sol.x1 == 0 || s.x1 == 0) vt = "";
                else
                {
                    sa1 = ((s.x1 < 0) || ((int)s.x1 != s.x1)) ? "(" + s.x1.ToString() + ")" : s.x1.ToString();
                    sr1 = ((sol.x1 < 0) || ((int)sol.x1 != sol.x1)) ? "(" + sol.x1.ToString() + ")" : sol.x1.ToString();
                    sr1 += "^n";
                    if (s.x1 == 1) sa1 = "";
                    if (sa1 != "") sr1 = "*" + sr1;
                    vt = sa1 + sr1;
                }

                //vế phải
                if (sol.x2 == 0 || s.x2 == 0) vp = "";
                else
                {
                    sr2 = ((sol.x2 < 0) || ((int)sol.x2 != sol.x2)) ? "(" + sol.x2.ToString() + ")" : sol.x2.ToString();
                    sr2 += "^n";
                    sa2 = ((s.x2 < 0) || ((int)s.x2 != s.x2)) ? "(" + s.x2.ToString() + ")" : s.x2.ToString();
                    if (s.x2 == 1) sa2 = "";
                    if (sa2 != "") sr2 = "*" + sr2;
                    vp = vt == "" ? " " + sa2 + sr2 : " + " + sa2 + sr2;
                }
                txtHethuc.Text = vt + vp;
                //txtHethuc.Text = s.x1.ToString() + "*" + sol.x1.ToString() + "^n + " + s.x2.ToString() + "*" + sol.x2.ToString() + "^n";
            }
            //txtHethuc.Text = "x1 = " + sol.x1.ToString() + ", x2 = " + sol.x2.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private bool Nextbit(int[] a, int n)
        {
            int i = n - 1;
            while (i >= 0 && a[i] == 1)
                i--;
            if (i < 0) return false;
            a[i] = 1;
            for (int j = i + 1; j < n; j++)
                a[j] = 0;
            return true;
        }
        private void btnDaynhiphan_Click(object sender, EventArgs e)
        {
            string s = txtDay.Text;
            if (s == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo");
                txtDay.Focus();
                return;
            }
            int len = s.Length;
            int[] a = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (s[i] != '0' && s[i] != '1')
                {
                    MessageBox.Show("Không phải xâu nhị phân!", "Thông báo");
                    txtDay.Focus();
                    txtDay.SelectAll();
                    return;
                }
                a[i] = s[i]-'0';
            }
            txtDayke.Clear();
            if (Nextbit(a, len))
            {
                for (int i = 0; i < len; i++)
                    txtDayke.Text += a[i].ToString();
            }
            else
                txtDayke.Text = "Không sinh được nữa!";
        }
        private void HoanDoi(ref int a, ref int b)
        {
            int temp = a; a=b; b=temp;
        }
        private bool Nexthoanvi(int[] a, int n)
        {
            int i = n - 2;
            while (i >= 0 && a[i] > a[i + 1])
                i--;
            if (i < 0) return false;
            /*do doan sau dang sap xep giam dan nen duyet nguoc lai se tim dc ptu a[j] nho nhat de a[j] > a[i]*/
            int j = n-1;
            //Tim ptu a[j] nho nhat de a[j]>a[i]
            while (a[j] < a[i])
                j--;
            HoanDoi(ref a[i], ref a[j]);
            //Dao doan
            int dau = i + 1, cuoi = n - 1;
            while (dau < cuoi)
                HoanDoi(ref a[dau++], ref a[cuoi--]);
            return true;
        }
        private void btnHoanvi_Click(object sender, EventArgs e)
        {
            string s = txtDay.Text;
            if (s == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu", "Thông báo");
                txtDay.Focus();
                return;
            }
            int len = s.Length;
            int[] a = new int[len];
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++ )
                    if (s[i] == s[j])
                    {
                        MessageBox.Show("Có phần tử bị trùng!", "Thông báo");
                        txtDay.Focus();
                        txtDay.SelectAll();
                        return;
                    }
                a[i] = s[i] - '0';
            }
            txtDayke.Clear();
            if (Nexthoanvi(a, len))
            {
                for (int i = 0; i < len; i++)
                    txtDayke.Text += a[i].ToString();
            }
            else
                txtDayke.Text = "Không sinh được nữa!";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private bool Nexttohop(int[] a, int n, int k)
        {
            int i = k;
            while (a[i] == n - k + i && i > 0)
                i--;
            if (i <= 0) return false;
            a[i]++;
            for (int j = i + 1; j <= k; j++)
                a[j] = a[j - 1] + 1;
            return true;
        }
        private void Sinhtohop_Click(object sender, EventArgs e)
        {
            if(txtN.Text=="")
            {
                MessageBox.Show("Chưa nhập n", "Thông báo");
                txtN.Focus();
                return;
            }
            if(txtDaytohop.Text=="")
            {
                MessageBox.Show("Chưa nhập dãy!", "Thông báo");
                txtDaytohop.Focus();
                return;
            }

            int n = int.Parse(txtN.Text);

            string s = txtDaytohop.Text;
            int len = s.Length;
            if (len >= n)
            {
                MessageBox.Show("Số lượng phần tử của dãy phải nhỏ n!", "Thông báo");
                txtDaytohop.Focus();
                txtDaytohop.SelectAll();
                return;
            }
            int[] a = new int[len+1];
            for (int i = 0; i < len; i++)
            {
                if(s[i]-'0'> n)
                {
                    MessageBox.Show("Có phần tử > n!", "Thông báo");
                    txtDaytohop.Focus();
                    txtDaytohop.SelectAll();
                    return;
                }
                for (int j = i + 1; j < len; j++)
                {
                    if (s[i] == s[j])
                    {
                        MessageBox.Show("Có phần tử bị trùng!", "Thông báo");
                        txtDaytohop.Focus();
                        txtDaytohop.SelectAll();
                        return;
                    }
                    if(s[j]<s[i])
                    {
                        MessageBox.Show("Các phần tử phải đc sắp xếp tăng dần!", "Thông báo");
                        txtDaytohop.Focus();
                        txtDaytohop.SelectAll();
                        return;
                    }
                }
                a[i+1] = s[i] - '0';
            }
            txtSinhtohop.Clear();
            if (Nexttohop(a, n, len))
            {
                for (int i = 1; i <= len; i++)
                    txtSinhtohop.Text += a[i].ToString();
            }
            else
                txtSinhtohop.Text = "Không sinh được nữa!";
        }

        private void txtC1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Nhapsothapphan((TextBox)sender, e);
        }
        private void Nhapsothapphan(TextBox tdg, KeyPressEventArgs e)
        {
            char decimalChar = '.';
            char negChar = '-';
            // Kiểm tra xem phím nhấn có phải là số hoặc phím chức năng ko
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { }

            // Cho phép nhập kí tự '.' để biểu diễn thập phân và chỉ cho
            // nhập kí tự '.' 1 lần
            else if(e.KeyChar==negChar && tdg.Text.IndexOf(negChar.ToString())==-1)
            {
                e.Handled = true;
                tdg.Text = "-" + tdg.Text; tdg.SelectionStart = tdg.TextLength;
            }
            else if (e.KeyChar == decimalChar && tdg.Text.IndexOf(decimalChar.ToString()) == -1) { }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled=true;
            }
        }


        private void tabPage4_Enter(object sender, EventArgs e)
        {
            txtC1.Focus();
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            txtDay.Focus();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            txtN.Focus();
        }
        //private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //}
    }
}
