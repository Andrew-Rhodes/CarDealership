using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data
{
    public interface IVehicleRepository
    {
        List<Vehicle> GetAll();
        List<Vehicle> GetTrades();
        List<Vehicle> GetSale();
    }
}
