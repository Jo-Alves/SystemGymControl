using System.Data;
using System.Data.SqlClient;

namespace DeposityBillit
{
    class BillyToPay
    {
        public int id { get; set; }
        public string recipient { get; set; }
        public string refering { get; set; }
        public string number { get; set; }
        public string duedate { get; set; }
        public decimal value { get; set; }
        public decimal discount { get; set; }
        public decimal penalty { get; set; }
        public decimal amountPaid { get; set; }

        public void Save()
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    string _sql = "";
                    if (id == 0)
                        _sql = "INSERT INTO billy_to_pay (recipient, refering, document_number, due_date, document_value, discount) VALUES (@recipient, @refering, @number, @duedate, @value, @discount)";
                    else
                        _sql = "UPDATE billy_to_pay SET penalty = @penalty, amount_paid = @amountPaid WHERE id = @id";

                    connection.Open();
                    var command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@recipient", recipient);
                    command.Parameters.AddWithValue("@refering", refering);
                    command.Parameters.AddWithValue("@number", number);
                    command.Parameters.AddWithValue("@duedate", duedate);
                    command.Parameters.AddWithValue("@value", value);
                    command.Parameters.AddWithValue("@discount", discount);
                    command.Parameters.AddWithValue("@penalty", penalty);
                    command.Parameters.AddWithValue("@amountPaid", amountPaid);

                    command.ExecuteNonQuery();


                }
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetDataBillyToPay()
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    string _sql = "SELECT id, recipient, refering, document_number, due_date, document_value, discount FROM billy_to_pay WHERE amount_paid IS NULL";
                    var adapter = new SqlDataAdapter(_sql, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
