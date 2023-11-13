using Microsoft.Data.SqlClient;

namespace testApi41P.BaseConnection
{
    public class Constans
    { 
        // Проверка подлинности SQL сервером
        public static string SqlConnection
        { 
            get
            {
                var sc = new SqlConnectionStringBuilder
                {
                    DataSource = "sql.ngknn.local",
                    IntegratedSecurity = false,
                    InitialCatalog = "testApi",
                    UserID = "21P",
                    Password = "12357",
                    TrustServerCertificate = true
                };
            return sc.ToString();
            }
        }
    }
}
