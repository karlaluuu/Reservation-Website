using System.Collections.Generic;
namespace KABrucePeninsula.Models
{
    public static class Repository
    {
        private static List<Responses> respond = new List<Responses>();
        public static IEnumerable<Responses> Responses
        {
            get
            {
                return respond;
            }
        }
        public static void AddResponse(Responses responses)
        {
            respond.Add(responses);
        }
    }
}
