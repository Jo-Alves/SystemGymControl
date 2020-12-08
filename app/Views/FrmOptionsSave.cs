using Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGymControl
{
    public partial class FrmOptionsSave : Form
    {
        public FrmOptionsSave()
        {
            InitializeComponent();
        }

        private void FrmOptionsSave_ClientSizeChanged(object sender, EventArgs e)
        {
            if (this.Width > 617)
            {
                /* Aluno - Student */
                pnStudent.Location = new Point(73, 241);
                pnStudent.Size = new Size(272, 245);
                pcStudent.Location = new Point(102, 28);
                lblStudent.Location = new Point(108, 103);
                btnSaveStudent.Location = new Point(9, 159);
                btnSaveStudent.Size = new Size(252, 42);

                /* Pacote - Package*/
                pnPackage.Location = new Point(420, 241);
                pnPackage.Size = new Size(272, 245);
                pcPackage.Location = new Point(102, 28);
                lblPackage.Location = new Point(104, 103);
                btnSavePackage.Location = new Point(9, 159);
                btnSavePackage.Size = new Size(252, 42);

                /* Usuário - user */
                pnUser.Location = new Point(785, 241);
                pnUser.Size = new Size(272, 245);
                pcUser.Location = new Point(102, 28);
                lblUser.Location = new Point(104, 103);
                btnSaveUser.Location = new Point(9, 159);
                btnSaveUser.Size = new Size(252, 42);

            }
            else
            {
                /* Aluno - Student */
                pnStudent.Location = new Point(17, 192);
                pnStudent.Size = new Size(188, 192);
                pcStudent.Location = new Point(56, 17);
                lblStudent.Location = new Point(62, 88);
                btnSaveStudent.Location = new Point(10, 123);
                btnSaveStudent.Size = new Size(168, 42);

                /* Pacote - Package*/
                pnPackage.Location = new Point(211, 192);
                pnPackage.Size = new Size(188, 192);
                pcPackage.Location = new Point(56, 17);
                lblPackage.Location = new Point(60, 88);
                btnSavePackage.Location = new Point(10, 123);
                btnSavePackage.Size = new Size(168, 42);

                /* Usuário - user */
                pnUser.Location = new Point(404, 192);
                pnUser.Size = new Size(188, 192);
                pcUser.Location = new Point(56, 17);
                lblUser.Location = new Point(56, 88);
                btnSaveUser.Location = new Point(10, 123);
                btnSaveUser.Size = new Size(168, 42);
            }
        }

        private void btnSaveStudent_MouseEnter(object sender, EventArgs e)
        {
            this.btnSaveStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        }

        private void btnSavePackage_MouseEnter(object sender, EventArgs e)
        {
            this.btnSavePackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
        }

        private void btnSaveUser_MouseEnter(object sender, EventArgs e)
        {
            this.btnSaveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
        }

        private void btnSaveStudent_MouseLeave(object sender, EventArgs e)
        {
            this.btnSaveStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
        }

        private void btnSavePackage_MouseLeave(object sender, EventArgs e)
        {
            this.btnSavePackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
        }

        private void btnSaveUser_MouseLeave(object sender, EventArgs e)
        {
            this.btnSaveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {

            try
            {
                if (new Student().SearchAll().Rows.Count > 0)
                    OpenForm.ShowForm(new FrmStudent(), this);
                else
                    OpenForm.ShowForm(new FrmSaveStudent(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePackage_Click(object sender, EventArgs e)
        {
            try
            {
                if (new Package().SearchAll().Rows.Count > 0)
                    OpenForm.ShowForm(new FrmPackage(), this);
                else
                    OpenForm.ShowForm(new FrmSavePackage(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (new User().SearchAll().Rows.Count > 0)
                    OpenForm.ShowForm(new FrmUser(), this);
                else
                    OpenForm.ShowForm(new FrmSaveUser(), this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}