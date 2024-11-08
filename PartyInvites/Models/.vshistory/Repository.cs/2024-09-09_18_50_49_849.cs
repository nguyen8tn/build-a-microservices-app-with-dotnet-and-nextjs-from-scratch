using static System.Formats.Asn1.AsnWriter;

namespace PartyInvites.Models
{
    /// <summary>
    /// The Repository class and its members are static, which will make it easy
    /// for me to store and retrieve data from different places in the application
    /// </summary>
    public class Repository
    {

        private static List<GuestResponse> responses = new();
        public static IEnumerable<GuestResponse> Responses => responses;
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
