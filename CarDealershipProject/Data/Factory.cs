using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class Factory
    {
        public static IVehicleRepository CreateVehicleRepository()
        {
            switch (ConfigurationManager.AppSettings["mode"].ToLower())
            {
                case "test":
                    return new MockVehicleRepository();
                case "prod":
                    return new VehicalRepository();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
