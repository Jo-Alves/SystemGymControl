using System;
using System.Data;
using System.Data.SqlClient;


namespace Database
{
    public class Plan
    {
        private int id;
        private int numberPortions;
        private string datePurchasePlan;
        private string timePurchasePlan;
        private string dateTerminalPlan;
        private string dateTerminalPlanLast;
        private int itemsPackageID;
        private int studentID;

        string _sql;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public int _numberPortions
        {
            get { return numberPortions; }
            set { numberPortions = value; }
        }
        public string _datePurchasePlan
        {
            get { return datePurchasePlan; }
            set { datePurchasePlan = value; }
        }

        public string _dateTerminalPlan
        {
            get { return dateTerminalPlan; }
            set { dateTerminalPlan = value; }
        }
        public string _dateTerminalPlanLast
        {
            get { return dateTerminalPlanLast; }
            set { dateTerminalPlanLast = value; }
        }
        public string _timePurchasePlan
        {
            get { return timePurchasePlan; }
            set { timePurchasePlan = value; }
        }
        public int _itemsPackageID
        {
            get { return itemsPackageID; }
            set { itemsPackageID = value; }
        }
        public int _studentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public void Save(Modality modality, SituationsPlan situationsPlan, DataTable dataCardPayment, CashPayment cashPayment, string formPayment, string period)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                connection.Open();
                if (_id == 0)
                    _sql = "INSERT INTO plans (date_purchase_plan ,time_purchase_plan ,date_terminal_plan ,items_package_id ,student_id) VALUES (@datePurchasePlan, @timePurchasePlan, @dateTerminalPlan, @itemsPackageID, @studentID); SELECT @@identity";
                else
                    _sql = "UPDATE plans SET date_purchase_plan = @datePurchasePlan, date_terminal_plan = @dateTerminalPlan, time_purchase_plan = @timePurchasePlan, items_package_id = @itemsPackageID, student_id = @studentID WHERE id = @id";

                SqlTransaction sqlTransaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand(_sql, connection, sqlTransaction);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@datePurchasePlan", _datePurchasePlan);
                command.Parameters.AddWithValue("@dateTerminalPlan", _dateTerminalPlan);
                command.Parameters.AddWithValue("@timePurchasePlan", _timePurchasePlan);
                command.Parameters.AddWithValue("@itemsPackageID", _itemsPackageID);
                command.Parameters.AddWithValue("@studentID", _studentID);
                try
                {
                    int planId = 0;
                    if (_id == 0)
                    {
                        planId = Convert.ToInt32(command.ExecuteScalar());
                    }
                    else
                        planId = _id;

                    if (!string.IsNullOrEmpty(modality._description))
                    {
                        modality._planID = planId;
                        modality.Save(sqlTransaction);
                    }

                    situationsPlan._planID = planId;
                    situationsPlan.Save(sqlTransaction);

                    if (formPayment == "dinheiro")
                    {
                        if (period != "mensal")
                        {
                            cashPayment._duedate = DateTime.Now.ToShortDateString();
                            cashPayment._planID = planId;
                            cashPayment.Save(sqlTransaction);
                        }
                        else
                        {
                            // Insere os dados do pagamento

                            cashPayment._duedate = DateTime.Now.ToShortDateString();
                            cashPayment._planID = planId;
                            cashPayment.Save(sqlTransaction);

                            // Insere os dados para o próximo pagamento com a data a vencer

                            cashPayment._id = 0;
                            cashPayment._payday = "";
                            cashPayment._paymentTime = "";
                            cashPayment._valueTotal += cashPayment._valueDiscount;
                            cashPayment._valueDiscount = 0.00m;
                            cashPayment._duedate = DateTime.Now.AddMonths(1).ToShortDateString();
                            cashPayment.Save(sqlTransaction);
                        }
                    }
                    else
                    {
                        foreach (DataRow dr in dataCardPayment.Rows)
                        {
                            int numberPortion = int.Parse(dr["portion"].ToString());
                            string dueDate = dr["dueDate"].ToString();
                            decimal valuePortion = decimal.Parse(FormatValueDecimal.RemoveDollarSignGetValue(dr["value"].ToString()));
                            string payday = "";
                            string paymentTime = "";

                            CardPayment cardPayment = new CardPayment() { _dueDate = dueDate, _numberPortion = numberPortion, _payday = payday, _paymentTime = paymentTime, _valuePortion = valuePortion, _planID = planId };
                            cardPayment.Save(sqlTransaction);
                        }
                    }
                    if (_id > 0)
                        command.ExecuteNonQuery();

                    sqlTransaction.Commit();
                }
                catch
                {
                    sqlTransaction.Rollback();
                    throw;
                }
            }
        }

        public void UpdateTerminalPlanLast(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                _sql = "UPDATE plans SET date_terminal_plan_last = @dateTerminalPlanLast WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@dateTerminalPlanLast", _dateTerminalPlanLast);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        public void UpdateTerminalPlan(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                _sql = "UPDATE plans SET date_terminal_plan = @dateTerminalPlan WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@dateTerminalPlan", _dateTerminalPlan);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
        }

        public DataTable SearchID(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    connection.Open();
                    _sql = "SELECT plans.id as idPlan, plans.date_purchase_plan, plans.date_terminal_plan, plans.date_terminal_plan_last, " +
                        "plans.time_purchase_plan, students.id as idStudent, students.name, modalities.id as " +
                        "idModality, modalities.description as descriptionModality, items_package.id as idItemsPackage, " +
                        "items_package.value as valueItemsPackage, forms_of_payment.Id as idFormOfPayment, " +
                        "forms_of_payment.description as descriptionFormOfPayment, packages.id as " +
                        "IdPackage, packages.description as descriptionPackage, packages.duration, packages.period, situations_plan.id as " +
                        "idSituationPlan, situations_plan.situation, situations_plan.observation, situations_plan.deactivation_date, situations_plan.time_inactivated FROM " +
                        "plans INNER JOIN modalities ON plans.id = modalities.plan_id INNER JOIN " +
                        "students ON students.id = plans.student_id INNER JOIN situations_plan ON " +
                        "situations_plan.plan_id = plans.id INNER JOIN items_package " +
                        "ON items_package.id = plans.items_package_id" +
                        " INNER JOIN forms_of_payment ON forms_of_payment.items_package_id = items_package.id " +
                        "INNER JOIN packages ON packages.id = items_package.package_id WHERE plans.id = @id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@id", id);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    return table;
                }
                catch
                {
                    throw;
                }
            }
        }

        public bool ModalitiesBeforePlanTerminalCurrentEqual(int id, string description)
        {
            bool planTerminal = false;
            try
            {
                using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    connection.Open();
                    _sql = "SELECT * FROM plans INNER JOIN students ON students.id = plans.student_id INNER JOIN modalities ON modalities.plan_id = plans.id WHERE students.id = @id AND CONVERT(DATE, @dateCurrent, 103) <= CONVERT(DATE, date_terminal_plan, 103) AND modalities.description = @description";
                    SqlCommand command = new SqlCommand(_sql, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@dateCurrent", DateTime.Now.ToShortDateString());
                    command.Parameters.AddWithValue("@description", description);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        planTerminal = true;
                    }
                }
            }
            catch
            {
                throw;
            }

            return planTerminal;
        }

        public DataTable SearchAll()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    _sql = "SELECT plans.id as idPlan, plans.date_purchase_plan, plans.date_terminal_plan, plans.date_terminal_plan_last, " +
                        "plans.time_purchase_plan, students.id as idStudent, students.name, modalities.id as " +
                        "idModality, modalities.description as descriptionModality, items_package.id as idItemsPackage, " +
                        "items_package.value as valueItemsPackage, forms_of_payment.Id as idFormOfPayment, " +
                        "forms_of_payment.description as descriptionFormOfPayment, packages.id as " +
                        "IdPackage, packages.description as descriptionPackage, situations_plan.id as " +
                        "idSituationPlan, situations_plan.situation, situations_plan.observation, situations_plan.deactivation_date, situations_plan.time_inactivated FROM " +
                        "plans INNER JOIN modalities ON plans.id = modalities.plan_id INNER JOIN " +
                        "students ON students.id = plans.student_id INNER JOIN situations_plan ON " +
                        "situations_plan.plan_id = plans.id INNER JOIN items_package " +
                        "ON items_package.id = plans.items_package_id" +
                        " INNER JOIN forms_of_payment ON forms_of_payment.items_package_id = items_package.id " +
                        "INNER JOIN packages ON packages.id = items_package.package_id " +
                        "WHERE situations_plan.situation <> 'Cancelado' ORDER BY plans.id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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

        public DataTable SearchAllWhereMoney()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    _sql = "SELECT plans.id as idPlan, plans.date_purchase_plan, plans.date_terminal_plan, plans.date_terminal_plan_last, " +
                        "plans.time_purchase_plan, students.id as idStudent, students.name, modalities.id as " +
                        "idModality, modalities.description as descriptionModality, items_package.id as idItemsPackage, " +
                        "items_package.value as valueItemsPackage, forms_of_payment.Id as idFormOfPayment, " +
                        "forms_of_payment.description as descriptionFormOfPayment, packages.id as " +
                        "IdPackage, packages.description as descriptionPackage, situations_plan.id as " +
                        "idSituationPlan, situations_plan.situation, situations_plan.observation, situations_plan.deactivation_date, situations_plan.time_inactivated FROM " +
                        "plans INNER JOIN modalities ON plans.id = modalities.plan_id INNER JOIN " +
                        "students ON students.id = plans.student_id INNER JOIN situations_plan ON " +
                        "situations_plan.plan_id = plans.id INNER JOIN items_package " +
                        "ON items_package.id = plans.items_package_id" +
                        " INNER JOIN forms_of_payment ON forms_of_payment.items_package_id = items_package.id " +
                        "INNER JOIN packages ON packages.id = items_package.package_id " +
                        "WHERE situations_plan.situation <> 'Cancelado' AND forms_of_payment.description = 'Dinheiro' AND packages.period = 'Mensal' ORDER BY plans.id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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
        
        public DataTable SearchPlanStudentWhereMoney(string name)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    _sql = "SELECT plans.id as idPlan, plans.date_purchase_plan, plans.date_terminal_plan, plans.date_terminal_plan_last, " +
                        "plans.time_purchase_plan, students.id as idStudent, students.name, modalities.id as " +
                        "idModality, modalities.description as descriptionModality, items_package.id as idItemsPackage, " +
                        "items_package.value as valueItemsPackage, forms_of_payment.Id as idFormOfPayment, " +
                        "forms_of_payment.description as descriptionFormOfPayment, packages.id as " +
                        "IdPackage, packages.description as descriptionPackage, situations_plan.id as " +
                        "idSituationPlan, situations_plan.situation, situations_plan.observation, situations_plan.deactivation_date, situations_plan.time_inactivated FROM " +
                        "plans INNER JOIN modalities ON plans.id = modalities.plan_id INNER JOIN " +
                        "students ON students.id = plans.student_id INNER JOIN situations_plan ON " +
                        "situations_plan.plan_id = plans.id INNER JOIN items_package " +
                        "ON items_package.id = plans.items_package_id" +
                        " INNER JOIN forms_of_payment ON forms_of_payment.items_package_id = items_package.id " +
                        "INNER JOIN packages ON packages.id = items_package.package_id " +
                        $"WHERE students.name LIKE '%{name}%' AND situations_plan.situation <> 'Cancelado' AND forms_of_payment.description = 'Dinheiro' AND packages.period = 'Mensal' ORDER BY plans.id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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

        public DataTable SearchPlanNameStudent(string name)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    _sql = "SELECT plans.id as idPlan, plans.date_purchase_plan, plans.date_terminal_plan, plans.date_terminal_plan_last, " +
                        "plans.time_purchase_plan, students.id as idStudent, students.name, modalities.id as " +
                        "idModality, modalities.description as descriptionModality, items_package.id as idItemsPackage, " +
                        "items_package.value as valueItemsPackage, forms_of_payment.Id as idFormOfPayment, " +
                        "forms_of_payment.description as descriptionFormOfPayment, packages.id as " +
                        "IdPackage, packages.description as descriptionPackage, situations_plan.id as " +
                        "idSituationPlan, situations_plan.situation, situations_plan.observation, situations_plan.deactivation_date, situations_plan.time_inactivated FROM " +
                        "plans INNER JOIN modalities ON plans.id = modalities.plan_id INNER JOIN " +
                        "students ON students.id = plans.student_id INNER JOIN situations_plan ON " +
                        "situations_plan.plan_id = plans.id INNER JOIN items_package " +
                        "ON items_package.id = plans.items_package_id" +
                        " INNER JOIN forms_of_payment ON forms_of_payment.items_package_id = items_package.id " +
                        $"INNER JOIN packages ON packages.id = items_package.package_id WHERE students.name LIKE '%{name}%' AND situations_plan.situation <> 'Cancelado' ORDER BY plans.id";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
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

        public int GetMaxId()
        {
            int maxId = 0;
            using (var connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                try
                {
                    _sql = "SELECT MAX(id) as maxID FROM plans";
                    var command = new SqlCommand(_sql, connection);
                    connection.Open();
                    var dr = command.ExecuteReader();
                    if (dr.Read())
                        maxId = int.Parse(dr["maxID"].ToString());
                }
                catch
                {
                    throw;
                }
            }

            return maxId;
        }

        public DataTable GetDatePlanExpired()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
                {
                    _sql = "SELECT date_terminal_plan, id FROM Plans WHERE CONVERT(DATE, date_Terminal_plan, 103) < CONVERT(DATE, @dateNow, 103);";
                    SqlDataAdapter adapter = new SqlDataAdapter(_sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@dateNow", DateTime.Now.ToShortDateString());
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
