using System;
using System.Data;

namespace RacingBattleground
{
    public class RacingBattle: IRacingBattle
    {
        IDriverInformation _serviceDriver;
        public RacingBattle(IDriverInformation serviceDriver)
        {
            _serviceDriver = serviceDriver;
        }

        public void Run(RaceInformation raceInformation)
        {
            var dt = new DataTable();
            switch (raceInformation)
            {
                case RaceInformation.GetTopDriversDetails:
                    dt = _serviceDriver.GetTopDriversDetails();
                    break;
                case RaceInformation.GetAllDriverDetails:
                    dt = _serviceDriver.GetAllDriverDetails();
                    break;
                default:
                    break;
            }
            dt.Print();


        }
    }
}
