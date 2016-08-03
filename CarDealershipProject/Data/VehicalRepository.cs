using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Models;

namespace Data
{
    public class VehicalRepository : IVehicleRepository
    {
        private static readonly string Connection = ConfigurationManager.ConnectionStrings["Dealership"].ConnectionString;

        public List<Vehicle> GetAll()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            using (var cn = new SqlConnection(Connection))

            {
                vehicles = cn.Query<Vehicle>(@"SELECT * FROM Vehicles").ToList();
            }

            return vehicles;
        }

        public List<Vehicle> GetTrades()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            using (var cn = new SqlConnection(Connection))
            {
                vehicles = cn.Query<Vehicle>(@"SELECT * FROM Vehicles WHERE Trade = 1").ToList();
            }

            return vehicles;
        }

        public List<Vehicle> GetSale()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            using (var cn = new SqlConnection(Connection))
            {
                vehicles = cn.Query<Vehicle>(@"SELECT * FROM Vehicles WHERE Trade = 0").ToList();
            }

            return vehicles;
        }
    }
}
