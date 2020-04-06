using System;
using System.Data;

namespace RacingBattleground
{
    public interface IDriverInformation
    {
        DataTable GetTopDriversDetails();
        DataTable GetAllDriverDetails();
    }
}
