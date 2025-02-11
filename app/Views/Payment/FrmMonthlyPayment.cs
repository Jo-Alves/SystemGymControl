﻿using Bussiness;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SystemGymControl.Properties;

namespace SystemGymControl
{
    public partial class FrmMonthlyPayment : Form
    {
        Payment payment = new Payment();
        string package, modality;

        int idPlan, idPackage;
        public FrmMonthlyPayment()
        {
            InitializeComponent();
        }

        public FrmMonthlyPayment(int idPlan, string package, string modality, int idPackage)
        {
            InitializeComponent();
            LoadDataCashPayment(idPlan);
            CheckedDueDate();
            this.package = package;
            this.modality = modality;
            this.idPackage = idPackage;

        }

        private void CheckedDueDate()
        {
            foreach (DataGridViewRow row in dgvDataPlan.Rows)
            {
                DateTime dueDate = Convert.ToDateTime(row.Cells["duedate"].Value.ToString());

                if (DateTime.Now > dueDate && row.Cells["situation"].Value.ToString().ToLower() == "a receber")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
                    row.DefaultCellStyle.ForeColor = Color.White;
                    row.Cells["receive"].Value = Properties.Resources.icons8_get_revenue_32px_1;
                    row.Cells["receipt"].Value = Properties.Resources.icons8_receipt_32px_1;
                }
            }
        }

        private void LoadDataCashPayment(int idPlan)
        {
            dgvDataPlan.Rows.Clear();

            this.idPlan = idPlan;
            var dataCashPayment = payment.GetDataCashPaymentPlanMounth(idPlan);

            foreach (DataRow dr in dataCashPayment.Rows)
            {
                int countRow = dgvDataPlan.Rows.Add();

                txtName.Text = dr["name"].ToString();
                txtIdStudent.Text = dr["idStudent"].ToString();

                dgvDataPlan.Rows[countRow].Cells["receive"].Value = Properties.Resources.icons8_get_revenue_32px;
                dgvDataPlan.Rows[countRow].Cells["idCash"].Value = dr["plan_id"].ToString();
                dgvDataPlan.Rows[countRow].Cells["receipt"].Value = Properties.Resources.icons8_receipt_32px;
                dgvDataPlan.Rows[countRow].Cells["id"].Value = dr["idPayment"].ToString();
                dgvDataPlan.Rows[countRow].Cells["valueTotal"].Value = $"R$ {dr["value_total"]}";
                dgvDataPlan.Rows[countRow].Cells["valueDiscount"].Value = $"R$ {dr["value_discount"]}";
                dgvDataPlan.Rows[countRow].Cells["valueInterest"].Value = !string.IsNullOrEmpty(dr["value_interest"].ToString()) ? $"R$ {dr["value_interest"]}" : "R$ 0,00";
                dgvDataPlan.Rows[countRow].Cells["valuePenalty"].Value = !string.IsNullOrEmpty(dr["value_penalty"].ToString()) ? $"R$ {dr["value_penalty"]}" : "R$ 0,00";

                if (string.IsNullOrEmpty(dr["payday"].ToString()))
                    dgvDataPlan.Rows[countRow].Cells["situation"].Value = "A RECEBER";
                else
                    dgvDataPlan.Rows[countRow].Cells["situation"].Value = "PAGO";

                dgvDataPlan.Rows[countRow].Cells["duedate"].Value = dr["duedate"].ToString();
                dgvDataPlan.Rows[countRow].Cells["payday"].Value = dr["payday"].ToString();
                dgvDataPlan.Rows[countRow].Cells["paymentTime"].Value = dr["payment_time"].ToString();

                dgvDataPlan.Rows[countRow].MinimumHeight = 45;
            }

            dgvDataPlan.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenForm.ShowForm(new FrmPayments(), this);
        }

        private void dgvDataPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataPlan.ClearSelection();
            }
        }

        private void dgvDataPlan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                dgvDataPlan.ClearSelection();
                int idPayment = int.Parse(dgvDataPlan.CurrentRow.Cells["id"].Value.ToString());

                if (dgvDataPlan.CurrentCell.ColumnIndex == 0 && dgvDataPlan.CurrentRow.Cells["situation"].Value.ToString().ToLower() == "a receber")
                {
                    try
                    {
                        if (!new CashFlow().CheckedBoxClosing(FrmGymControl.Instance._IdCashFlow))
                        {
                            var effectPayment = new FrmEffectPayment(int.Parse(dgvDataPlan.CurrentRow.Cells["id"].Value.ToString()), package, modality, idPackage);
                            effectPayment.ShowDialog();
                            if (effectPayment.paymentEffected)
                            {
                                LoadDataCashPayment(idPlan);
                            }
                        }
                        else
                            MessageBox.Show("Não há como efetuar o pagamento no sistema neste momento. Para efetuar o pagamento fecha o sistema e abra um novo caixa.", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dgvDataPlan.CurrentCell.ColumnIndex == 0 && dgvDataPlan.CurrentRow.Cells["situation"].Value.ToString().ToLower() == "pago")
                {
                    MessageBox.Show("Esta mensalidade já foi paga!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (dgvDataPlan.CurrentCell.ColumnIndex == 1 && !string.IsNullOrEmpty(dgvDataPlan.CurrentRow.Cells["payday"].Value.ToString()))
                {
                    if (bool.Parse(Settings.Default["optionPreviewIsDirecty"].ToString()))
                    {
                        string path = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\Recibo de Pagamento.rdlc";
                        //string path = Path.GetDirectoryName(Application.ExecutablePath);

                        //string fullPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 0) + @"\Views\Report\Recibo de Pagamento.rdlc";
                        //string fullPath = Path.GetDirectoryName(Application.ExecutablePath).Remove(path.Length - 0) + @"\Views\Report\Recibo de Pagamento.rdlc";

                        //CreateReceipt.GenerateReceipt(idPayment, fullPath);
                        CreateReceipt.GenerateReceipt(idPayment, path);
                    }
                    else
                        OpenForm.ShowForm(new FrmReportReceipt(idPayment, idPlan, idPackage), this);
                }
                else if (dgvDataPlan.CurrentCell.ColumnIndex == 1 && string.IsNullOrEmpty(dgvDataPlan.CurrentRow.Cells["payday"].Value.ToString()))
                {
                    MessageBox.Show("Para a impressão do recibo o pagamento tem que ser efetuado!", "System GYM Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
