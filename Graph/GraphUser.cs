using System;

namespace ProjectLibri.Graph
{
    public class GraphUser
    {
        public String displayName { get; set; }
        public String givenName { get; set; }
        public String mail { get; set; }
        public String surname { get; set; }
        public String userPrincipalName { get; set; }
        public String id { get; set; }

        public String ToString()
        {
            return $"displayName: {displayName}, givenName: {givenName}, mail: {mail}, surname: {surname}," +
                   $"userPrincipalName: {userPrincipalName}, id: {id}";
        }

    }
}
