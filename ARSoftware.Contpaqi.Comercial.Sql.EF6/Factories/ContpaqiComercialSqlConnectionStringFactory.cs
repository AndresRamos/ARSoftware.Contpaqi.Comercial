using System.Data.SqlClient;

namespace ARSoftware.Contpaqi.Comercial.Sql.EF6.Factories
{
    public class ContpaqiComercialSqlConnectionStringFactory
    {
        public static string CreateContpaqiComercialGeneralesConnectionString(string contpaqiConnectionString)
        {
            var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString) { InitialCatalog = "CompacWAdmin" };
            return sqlConnectionStringBuilder.ConnectionString;
        }

        public static string CreateContpaqiComercialEmpresaConnectionString(string contpaqiConnectionString, string empresaDatabaseName)
        {
            var sqlConnectionStringBuilder =
                new SqlConnectionStringBuilder(contpaqiConnectionString) { InitialCatalog = empresaDatabaseName };
            return sqlConnectionStringBuilder.ConnectionString;
        }
    }
}
