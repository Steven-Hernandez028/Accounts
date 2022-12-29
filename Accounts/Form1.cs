using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Accounts
{
    public partial class Mainform : Form
    {
        accountsdbEntities bd = new accountsdbEntities();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();



        public Mainform()
        {
            InitializeComponent();
        }
        public void switchcontrol(bool b)
        {
            txt_app.Text = "";
            txt_id.Text = "";
            txt_password.Text = "";
            txt_user.Text = "";

            txt_app.Enabled = b;
            txt_id.Enabled = b;
            txt_user.Enabled = b;
            txt_password.Enabled = b;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_accounts.DataSource = bd.accounts.ToList();
        }

        private void bttn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_save_Click(object sender, EventArgs e)
        {
            account acc = new account
            {
                app = txt_app.Text,
                names = txt_user.Text,
                pass = txt_password.Text,
                llave_de_recuperacion = txt_llaves.Text
            };
            bd.accounts.Add(acc);
            if (bd.SaveChanges() > 0)
            {
                dgv_accounts.DataSource = bd.accounts.ToList();
                MessageBox.Show("Se ha agregado una nueva cuenta");
            }


        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_accounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_accounts.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dgv_accounts.Rows[e.RowIndex].Cells["Eliminar"];
                chk.Value = !Convert.ToBoolean(chk.Value);


            }

        }

        private void Mainform_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void dgv_accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chk_edit_mode.Checked == true)
            {
                txt_id.Text = dgv_accounts.CurrentRow.Cells[1].Value.ToString();
                txt_password.Text = dgv_accounts.CurrentRow.Cells[2].Value.ToString();
                txt_app.Text = dgv_accounts.CurrentRow.Cells[3].Value.ToString();
                txt_user.Text = dgv_accounts.CurrentRow.Cells[4].Value.ToString();


            }
            else
            {
                switchcontrol(true);
            }

        }

        private void chk_edit_mode_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_edit_mode.Checked == true)
            {
                bttn_update.BackColor = Color.Orange;
                bttn_update.Text = "Save changes";
                bttn_save.Visible = false;
            }
            else
            {
                bttn_save.Visible = true;
                bttn_update.Text = "Eliminate";
                bttn_update.BackColor = Color.Red;
                switchcontrol(true);
            }

        }

        private void bttn_update_Click(object sender, EventArgs e)
        {
            if (bttn_update.Text == "Save changes")
            {

                short ide = Convert.ToInt16(txt_id.Text);
                account acc = bd.accounts.FirstOrDefault(x => x.accountId == ide);

                if (acc == null)
                {
                    MessageBox.Show("Esta cuenta no existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    acc.names = txt_user.Text;
                    acc.app = txt_app.Text;
                    acc.pass = txt_password.Text;
                    bd.Entry(acc).State = EntityState.Modified;
                    bd.SaveChanges();
                    dgv_accounts.DataSource = bd.accounts.ToList();

                }
            }
            else if (bttn_update.Text == "Eliminate")
            {
                try
                {
                    foreach (DataGridViewRow row in dgv_accounts.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            int ide = Convert.ToInt32(row.Cells["accountId"].Value);
                            account acc = bd.accounts.FirstOrDefault(x => x.accountId == ide);
                            if (acc == null)
                            {
                                MessageBox.Show("La cuenta a eliminar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                bd.accounts.Remove(acc);
                                bd.SaveChanges();
                                MessageBox.Show("Cuenta eliminada con exito", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgv_accounts.DataSource = bd.accounts.ToList();

                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }


        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
