using System;
using System.Data;

namespace RacingBattleground
{
    public class DriverInformation : IDriverInformation
    {
        IDriverModel _data;
        public DriverInformation(IDriverModel data)
        {
            _data = data;
        }
        public DataTable GetAllDriverDetails()
        {
            return _data.GetAllDriverDetails();
        }

        public DataTable GetTopDriversDetails()
        {
            return _data.GetTopDriversDetails();
        }
    }
}
