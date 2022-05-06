using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReleApp
{
    public class Rele
    {
        private StatusConnect statConnect = StatusConnect.Desconnected;

        public StatusConnect StatConnect { get => statConnect; private set => statConnect = value; }

        public bool InitRele()
        {

            StatConnect = StatusConnect.Connected;

            return false;
        }

        public bool SetRele(StatusRele statusFirst, StatusRele statusSecond)
        {



            return false;
        }
    }
}
