using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using SystemGymControl.Properties;

namespace SystemGymControl
{
    class ParametersReport
    {
        public static ReportParameterCollection SetParametersReport(DataTable dataPayment)
        {
            DateTime duedate = Convert.ToDateTime(dataPayment.Rows[0]["duedate"].ToString()).AddMonths(1);
            int portion = int.Parse(dataPayment.Rows[0]["portion"].ToString());

            decimal valueTotal = Convert.ToDecimal(dataPayment.Rows[0]["value_total"]);
            decimal valueDiscount = Convert.ToDecimal(dataPayment.Rows[0]["value_discount"]);
            decimal valueInterest = string.IsNullOrEmpty(dataPayment.Rows[0]["value_interest"].ToString()) ? 0.00M : Convert.ToDecimal(dataPayment.Rows[0]["value_interest"]);
            decimal valuePenalty = string.IsNullOrEmpty(dataPayment.Rows[0]["value_penalty"].ToString()) ? 0.00M : Convert.ToDecimal(dataPayment.Rows[0]["value_penalty"]);
          
            if (portion > 1)
            {
                valueTotal *= portion;
            }

            decimal valuePackage = valueTotal + valueDiscount - (valueInterest + valuePenalty);

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("name", dataPayment.Rows[0]["name"].ToString()));
            reportParameters.Add(new ReportParameter("date", dataPayment.Rows[0]["payday"].ToString()));
            reportParameters.Add(new ReportParameter("time", dataPayment.Rows[0]["payment_time"].ToString()));
            reportParameters.Add(new ReportParameter("package", dataPayment.Rows[0]["descriptionPackage"].ToString()));
            reportParameters.Add(new ReportParameter("modality", dataPayment.Rows[0]["descriptionModality"].ToString()));
            reportParameters.Add(new ReportParameter("value", $"R$ {valuePackage}"));
            reportParameters.Add(new ReportParameter("interest", string.IsNullOrEmpty(dataPayment.Rows[0]["value_interest"].ToString()) ? "R$ 0,00" : $"R$ {dataPayment.Rows[0]["value_interest"]}"));
            reportParameters.Add(new ReportParameter("penalty", string.IsNullOrEmpty(dataPayment.Rows[0]["value_penalty"].ToString()) ? "R$ 0,00" : $"R$ {dataPayment.Rows[0]["value_penalty"]}"));
            reportParameters.Add(new ReportParameter("total", $"R$ {dataPayment.Rows[0]["value_total"]}"));
            reportParameters.Add(new ReportParameter("nPortions", dataPayment.Rows[0]["portion"].ToString()));
            reportParameters.Add(new ReportParameter("formPayment", dataPayment.Rows[0]["form_payment"].ToString()));
            reportParameters.Add(new ReportParameter("duedate", dataPayment.Rows[0]["period"].ToString().ToLower() == "mensal" ? duedate.ToShortDateString() : " --- "));
            reportParameters.Add(new ReportParameter("nameFantasy", Settings.Default["nameFantasy"].ToString()));
            reportParameters.Add(new ReportParameter("cnpj", Settings.Default["CNPJ"].ToString()));
            reportParameters.Add(new ReportParameter("phone", Settings.Default["phone"].ToString()));
            reportParameters.Add(new ReportParameter("discount", $"R$ {dataPayment.Rows[0]["value_discount"].ToString().ToLower()}"));

            return reportParameters;
        }
    }
}
