using login.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Attempt1.App_Business
{
    public class BusinessWorkStation
    {
        DataWorkStation dataWorkStation;

        public BusinessWorkStation()
        {
            dataWorkStation = new DataWorkStation();
        }
    }
}