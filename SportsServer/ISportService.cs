using System;
using System.CodeDom;
using System.ServiceModel;

namespace SportsServer
{
    [ServiceContract(Name = "MySportService")]
    interface ISportService
    {
        [OperationContract]
        int GetScore(string team);
    }
    class SportService: ISportService
    {
        public int GetScore(string team)
        {
            switch (team)
            {
                case "Dodgers":
                    return 99;
                case "Angels":
                    return 110;
                case "Giants":
                    return 199;
                default: throw new NotImplementedException();
            }
        }
    }
}