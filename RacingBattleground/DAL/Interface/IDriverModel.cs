using System;
using System.Data;

namespace RacingBattleground
{
    public interface IDriverModel
    {
        DataTable GetTopDriversDetails();

        DataTable GetAllDriverDetails();
    }
}
