using System;
using System.Collections.Generic;
using System.Text;

namespace PaternFabrika
{
    class Glock18 : Arms
    {
        public void Shooting()
        {
            Console.WriteLine("Ваше оружие Glock18, вы можете стрелять в полуавтоматическом режиме и очередью по 3 выстрела");
        }
    }
}
