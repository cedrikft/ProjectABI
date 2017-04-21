using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectABI
{
    class Tools
    {
        internal static  Int32 getMaxIDClient()
        {
            Int32 maxIdClient = 0;
            foreach (Table_Client unautreClient in Donnees.Db.Table_Client.ToList())
            {
                if (maxIdClient < unautreClient.idClient)
                {
                    maxIdClient = unautreClient.idClient;
                }
            }

            return maxIdClient;
        }
    }
}
