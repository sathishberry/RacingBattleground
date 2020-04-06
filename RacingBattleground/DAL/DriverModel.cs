using System;
using System.Data;

namespace RacingBattleground
{
    public class DriverModel : IDriverModel
    {
        public DataTable GetTopDriversDetails()
        {
            return Execute.StoredProcedureWithoutParam("GetTopDriverOfEachRace");
        }

        public DataTable GetAllDriverDetails()
        {
            return Execute.StoredProcedureWithoutParam("GetDriverHistory");
        }
    }
}
