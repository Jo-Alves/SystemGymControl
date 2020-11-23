using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemGynControl
{
    public partial class FrmOptionsSave : Form
    {
        public FrmOptionsSave()
        {
            InitializeComponent();
        }

        private void ResizeControl()
        {

        }

        private void FrmOptionsSave_ClientSizeChanged(object sender, EventArgs e)
        {
            if(this.Width > 617)
            {
                /* Aluno - Class */
                pnClass.Location = new Point(73, 213);
                pnClass.Size = new Size(272, 245);
                pcClass.Location = new Point(102, 28);
                lblClass.Location = new Point(108, 103);
                btnSaveClass.Location = new Point(9, 159);
                btnSaveClass.Size = new Size(252, 42);

                /* Pacote - Package*/
                pnPackage.Location = new Point(420, 213);
                pnPackage.Size = new Size(272, 245);
                pcPackage.Location = new Point(102, 28);
                lblPackage.Location = new Point(104, 103);
                btnSavePackage.Location = new Point(9, 159);
                btnSavePackage.Size = new Size(252, 42);

                /* Usuário - user */
                pnUser.Location = new Point(785, 213);
                pnUser.Size = new Size(272, 245);
                pcUser.Location = new Point(102, 28);
                lblUser.Location = new Point(104, 103);
                btnSaveUser.Location = new Point(9, 159);
                btnSaveUser.Size = new Size(252, 42);

            }
            else
            {
                /* Aluno - Class */
                pnClass.Location = new Point(17, 221);
                pnClass.Size = new Size(188, 192);
                pcClass.Location = new Point(56, 17);
                lblClass.Location = new Point(62, 88);
                btnSaveClass.Location = new Point(10, 123);
                btnSaveClass.Size = new Size(168, 42);

                /* Pacote - Package*/
                pnPackage.Location = new Point(211, 221);
                pnPackage.Size = new Size(188, 192);
                pcPackage.Location = new Point(56, 17);
                lblPackage.Location = new Point(60, 88);
                btnSavePackage.Location = new Point(10, 123);
                btnSavePackage.Size = new Size(168, 42);

                /* Usuário - user */
                pnUser.Location = new Point(404, 221);
                pnUser.Size = new Size(188, 192);
                pcUser.Location = new Point(56, 17);
                lblUser.Location = new Point(56, 88);
                btnSaveUser.Location = new Point(10, 123);
                btnSaveUser.Size = new Size(168, 42);
            }
        }

        private void btnSaveClass_MouseEnter(object sender, EventArgs e)
        {
            this.btnSaveClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))); 
        }

        private void btnSavePackage_MouseEnter(object sender, EventArgs e)
        {
            this.btnSavePackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
        }

        private void btnSaveUser_MouseEnter(object sender, EventArgs e)
        {
            this.btnSaveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
        }

        private void btnSaveClass_MouseLeave(object sender, EventArgs e)
        {
            this.btnSaveClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
        }

        private void btnSavePackage_MouseLeave(object sender, EventArgs e)
        {
            this.btnSavePackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
        }

        private void btnSaveUser_MouseLeave(object sender, EventArgs e)
        {
            this.btnSaveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(29)))), ((int)(((byte)(52)))));
        }
    }
}
