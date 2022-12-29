namespace Accounts
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.dgv_accounts = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bttn_save = new System.Windows.Forms.Button();
            this.bttn_quit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.App = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_app = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.bttn_update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.chk_edit_mode = new System.Windows.Forms.CheckBox();
            this.lbl_llave = new System.Windows.Forms.Label();
            this.txt_llaves = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accounts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_accounts
            // 
            this.dgv_accounts.AllowUserToAddRows = false;
            this.dgv_accounts.AllowUserToDeleteRows = false;
            this.dgv_accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_accounts.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgv_accounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_accounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgv_accounts.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_accounts.Location = new System.Drawing.Point(11, 291);
            this.dgv_accounts.Name = "dgv_accounts";
            this.dgv_accounts.ReadOnly = true;
            this.dgv_accounts.Size = new System.Drawing.Size(645, 217);
            this.dgv_accounts.TabIndex = 0;
            this.dgv_accounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_accounts_CellClick);
            this.dgv_accounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_accounts_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 90F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // bttn_save
            // 
            this.bttn_save.BackColor = System.Drawing.Color.ForestGreen;
            this.bttn_save.FlatAppearance.BorderSize = 0;
            this.bttn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttn_save.ForeColor = System.Drawing.SystemColors.Control;
            this.bttn_save.Location = new System.Drawing.Point(596, 514);
            this.bttn_save.Name = "bttn_save";
            this.bttn_save.Size = new System.Drawing.Size(63, 32);
            this.bttn_save.TabIndex = 1;
            this.bttn_save.Text = "Add";
            this.bttn_save.UseVisualStyleBackColor = false;
            this.bttn_save.Click += new System.EventHandler(this.bttn_save_Click);
            // 
            // bttn_quit
            // 
            this.bttn_quit.BackColor = System.Drawing.Color.Crimson;
            this.bttn_quit.FlatAppearance.BorderSize = 0;
            this.bttn_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttn_quit.ForeColor = System.Drawing.SystemColors.Control;
            this.bttn_quit.Location = new System.Drawing.Point(644, 3);
            this.bttn_quit.Name = "bttn_quit";
            this.bttn_quit.Size = new System.Drawing.Size(24, 26);
            this.bttn_quit.TabIndex = 2;
            this.bttn_quit.Text = "X";
            this.bttn_quit.UseVisualStyleBackColor = false;
            this.bttn_quit.Click += new System.EventHandler(this.bttn_quit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.bttn_quit);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 49);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl.Location = new System.Drawing.Point(278, 10);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(110, 29);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Accounts";
            this.lbl.Click += new System.EventHandler(this.lbl_Click);
            // 
            // App
            // 
            this.App.AutoSize = true;
            this.App.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.App.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.App.Location = new System.Drawing.Point(379, 141);
            this.App.Name = "App";
            this.App.Size = new System.Drawing.Size(50, 24);
            this.App.TabIndex = 4;
            this.App.Text = "App:";
            this.App.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(375, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "User:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_pass.Location = new System.Drawing.Point(12, 141);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(97, 24);
            this.lbl_pass.TabIndex = 8;
            this.lbl_pass.Text = "Password:";
            this.lbl_pass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_password.Location = new System.Drawing.Point(12, 168);
            this.txt_password.Multiline = true;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(223, 22);
            this.txt_password.TabIndex = 3;
            // 
            // txt_app
            // 
            this.txt_app.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_app.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_app.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_app.Location = new System.Drawing.Point(379, 168);
            this.txt_app.Multiline = true;
            this.txt_app.Name = "txt_app";
            this.txt_app.Size = new System.Drawing.Size(277, 22);
            this.txt_app.TabIndex = 1;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txt_user.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_user.Location = new System.Drawing.Point(379, 101);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(277, 22);
            this.txt_user.TabIndex = 2;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // bttn_update
            // 
            this.bttn_update.BackColor = System.Drawing.Color.Red;
            this.bttn_update.FlatAppearance.BorderSize = 0;
            this.bttn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bttn_update.ForeColor = System.Drawing.SystemColors.Control;
            this.bttn_update.Location = new System.Drawing.Point(468, 514);
            this.bttn_update.Name = "bttn_update";
            this.bttn_update.Size = new System.Drawing.Size(122, 32);
            this.bttn_update.TabIndex = 9;
            this.bttn_update.Text = "Eliminate";
            this.bttn_update.UseVisualStyleBackColor = false;
            this.bttn_update.Click += new System.EventHandler(this.bttn_update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_id.Location = new System.Drawing.Point(12, 101);
            this.txt_id.Multiline = true;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(71, 22);
            this.txt_id.TabIndex = 11;
            // 
            // chk_edit_mode
            // 
            this.chk_edit_mode.AutoSize = true;
            this.chk_edit_mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.chk_edit_mode.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.chk_edit_mode.Location = new System.Drawing.Point(12, 257);
            this.chk_edit_mode.Name = "chk_edit_mode";
            this.chk_edit_mode.Size = new System.Drawing.Size(115, 28);
            this.chk_edit_mode.TabIndex = 12;
            this.chk_edit_mode.Text = "Edit Mode";
            this.chk_edit_mode.UseVisualStyleBackColor = true;
            this.chk_edit_mode.CheckedChanged += new System.EventHandler(this.chk_edit_mode_CheckedChanged);
            // 
            // lbl_llave
            // 
            this.lbl_llave.AutoSize = true;
            this.lbl_llave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_llave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_llave.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_llave.Location = new System.Drawing.Point(379, 209);
            this.lbl_llave.Name = "lbl_llave";
            this.lbl_llave.Size = new System.Drawing.Size(68, 24);
            this.lbl_llave.TabIndex = 13;
            this.lbl_llave.Text = "Llaves:";
            this.lbl_llave.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_llaves
            // 
            this.txt_llaves.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_llaves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_llaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_llaves.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_llaves.Location = new System.Drawing.Point(379, 236);
            this.txt_llaves.Multiline = true;
            this.txt_llaves.Name = "txt_llaves";
            this.txt_llaves.Size = new System.Drawing.Size(277, 22);
            this.txt_llaves.TabIndex = 14;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(668, 549);
            this.Controls.Add(this.txt_llaves);
            this.Controls.Add(this.lbl_llave);
            this.Controls.Add(this.chk_edit_mode);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttn_update);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_app);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.App);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bttn_save);
            this.Controls.Add(this.dgv_accounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mainform_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accounts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_accounts;
        private System.Windows.Forms.Button bttn_save;
        private System.Windows.Forms.Button bttn_quit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label App;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_app;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button bttn_update;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.CheckBox chk_edit_mode;
        private System.Windows.Forms.Label lbl_llave;
        private System.Windows.Forms.TextBox txt_llaves;
    }
}

