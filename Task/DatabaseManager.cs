using Npgsql;
using System;
using System.Data;

public class DatabaseManager
{
    private string connectionString;

    public DatabaseManager()
    {
        connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["TaskManagementDB"].ConnectionString;
    }

    public DataTable GetUsers()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM users";
            using (var command = new NpgsqlCommand(query, connection))
            {
                DataTable dt = new DataTable();
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
                return dt;
            }
        }
    }

    public DataTable GetTasks()
    {
        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM tasks";
            using (var command = new NpgsqlCommand(query, connection))
            {
                DataTable dt = new DataTable();
                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
                return dt;
            }
        }
    }

    public void AddTask(string projectName, string description, string priority, string assignee, string status, DateTime creationDate)
    {
        string query = @"
        INSERT INTO tasks (project_name, description, priority, assignee, status, creation_date)
        VALUES (@ProjectName, @Description, @Priority, @Assignee, @Status, @CreationDate);";

        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ProjectName", projectName);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Priority", priority);
                command.Parameters.AddWithValue("@Assignee", assignee);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@CreationDate", creationDate);

                command.ExecuteNonQuery();
            }
        }
    }

    public void UpdateTask(int taskId, string description, string priority, string assignee, string status)
    {
        string query = @"
        UPDATE tasks
        SET description = @Description,
            priority = @Priority,
            assignee = @Assignee,
            status = @Status
        WHERE task_id = @TaskId;";

        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Priority", priority);
                command.Parameters.AddWithValue("@Assignee", assignee);
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@TaskId", taskId);

                command.ExecuteNonQuery();
            }
        }
    }


    public void DeleteTask(int taskId)
    {
        string query = "DELETE FROM tasks WHERE task_id = @TaskId;";

        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TaskId", taskId);
                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable GetFilteredTasks(string status, string assignee, string priority)
    {
        string query = "SELECT * FROM tasks WHERE 1=1";

        if (!string.IsNullOrEmpty(status))
            query += " AND status = @Status";
        if (!string.IsNullOrEmpty(assignee))
            query += " AND assignee = @Assignee";
        if (!string.IsNullOrEmpty(priority))
            query += " AND priority = @Priority";

        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                if (!string.IsNullOrEmpty(status))
                    command.Parameters.AddWithValue("@Status", status);
                if (!string.IsNullOrEmpty(assignee))
                    command.Parameters.AddWithValue("@Assignee", assignee);
                if (!string.IsNullOrEmpty(priority))
                    command.Parameters.AddWithValue("@Priority", priority);

                using (var adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }

    public int GetCompletedTasksCount(DateTime startDate, DateTime endDate)
    {
        string query = @"
        SELECT COUNT(*)
        FROM tasks
        WHERE status = 'выполнено' AND creation_date BETWEEN @StartDate AND @EndDate;";

        using (var connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();
            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
    }


}
