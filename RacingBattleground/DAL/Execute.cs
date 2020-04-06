//using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
namespace RacingBattleground
{
    public static class Execute
    {
        static string constr = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["ConnectionString"];

        public static DataTable StoredProcedureWithoutParam(string spName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(spName))
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        sda.Fill(dt);

                }
            }
            return dt;
        }
    }
}
