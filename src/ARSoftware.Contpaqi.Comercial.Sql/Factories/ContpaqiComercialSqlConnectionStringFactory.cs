using ARSoftware.Contpaqi.Comercial.Sql.Models.Constants;
using Microsoft.Data.SqlClient;

namespace ARSoftware.Contpaqi.Comercial.Sql.Factories;

public static class ContpaqiComercialSqlConnectionStringFactory
{
    public static string CreateContpaqiComercialGeneralesConnectionString(string contpaqiConnectionString)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
        {
            InitialCatalog = ContpaqiComercialSqlConstants.ContpaqiComercialGeneralesDatabaseName
        };
        return sqlConnectionStringBuilder.ConnectionString;
    }

    public static string CreateContpaqiComercialEmpresaConnectionString(string contpaqiConnectionString, string empresaDatabaseName)
    {
        var sqlConnectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString) { InitialCatalog = empresaDatabaseName };
        return sqlConnectionStringBuilder.ConnectionString;
    }
}
