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

        public void Save()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionDataBase.stringConnection))
            {
                if (_id == 0)
                    _sql = "INSERT INTO plans VALUES (@datePurchasePlan, @timePurchasePlan, @dateTerminalPlan, @itemsPackageID, @studentID)";
                else
                    _sql = "UPDATE plans SET date_purchase_plan = @datePurchasePlan, date_terminal_plan = @dateTerminalPlan, time_purchase_plan = @timePurchasePlan, itemns_package_id = @itemsPackageID, student_id = @studentID WHERE id = @id";

                SqlCommand command = new SqlCommand(_sql, connection);
                command.Parameters.AddWithValue("@id", _id);
                command.Parameters.AddWithValue("@datePurchasePlan", _datePurchasePlan);
                command.Parameters.AddWithValue("@dateTerminalPlan", _dateTerminalPlan);
                command.Parameters.AddWithValue("@timePurchasePlan", _timePurchasePlan);
                command.Parameters.AddWithValue("@itemsPackageID", _itemsPackageID);
                command.Parameters.AddWithValue("@studentID", _studentID);
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
                    _sql = "SELECT plans.id as idPlan, plans.date_purchase_plan, plans.date_terminal_plan, " +
                        "plans.time_purchase_plan, students.id as idStudent, students.name, modalities.id as " +
                        "idModality, modalities.description as descriptionModality, items_package.id as idItemsPackage, " +
                        "items_package.value as valueItemsPackage, forms_of_payment.Id as idFormOfPayment, " +
                        "forms_of_payment.description as descriptionFormOfPayment, packages.id as " +
                        "IdPackage, packages.description as descriptionPackage, situations_plan.id as " +
                        "idSituationPlan, situations_plan.situation, situations_plan.observation FROM " +
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
                    _sql = "SELECT plans.id as idPlan, plans.date_purchase_plan, plans.date_terminal_plan, " +
                        "plans.time_purchase_plan, students.id as idStudent, students.name, modalities.id as " +
                        "idModality, modalities.description as descriptionModality, items_package.id as idItemsPackage, " +
                        "items_package.value as valueItemsPackage, forms_of_payment.Id as idFormOfPayment, " +
                        "forms_of_payment.description as descriptionFormOfPayment, packages.id as " +
                        "IdPackage, packages.description as descriptionPackage, situations_plan.id as " +
                        "idSituationPlan, situations_plan.situation, situations_plan.observation FROM " +
                        "plans INNER JOIN modalities ON plans.id = modalities.plan_id INNER JOIN " +
                        "students ON students.id = plans.student_id INNER JOIN situations_plan ON " +
                        "situations_plan.plan_id = plans.id INNER JOIN items_package " +
                        "ON items_package.id = plans.items_package_id" +
                        " INNER JOIN forms_of_payment ON forms_of_payment.items_package_id = items_package.id " +
                        "INNER JOIN packages ON packages.id = items_package.package_id";
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
                    _sql = "SELECT plans.id as idPlan, plans.date_purchase_plan, plans.date_terminal_plan, " +
                        "plans.time_purchase_plan, students.id as idStudent, students.name, modalities.id as " +
                        "idModality, modalities.description as descriptionModality, items_package.id as idItemsPackage, " +
                        "items_package.value as valueItemsPackage, forms_of_payment.Id as idFormOfPayment, " +
                        "forms_of_payment.description as descriptionFormOfPayment, packages.id as " +
                        "IdPackage, packages.description as descriptionPackage, situations_plan.id as " +
                        "idSituationPlan, situations_plan.situation, situations_plan.observation FROM " +
                        "plans INNER JOIN modalities ON plans.id = modalities.plan_id INNER JOIN " +
                        "students ON students.id = plans.student_id INNER JOIN situations_plan ON " +
                        "situations_plan.plan_id = plans.id INNER JOIN items_package " +
                        "ON items_package.id = plans.items_package_id" +
                        " INNER JOIN forms_of_payment ON forms_of_payment.items_package_id = items_package.id " +
                        $"INNER JOIN packages ON packages.id = items_package.package_id WHERE students.name LIKE '%{name}%'";
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
    }
}
