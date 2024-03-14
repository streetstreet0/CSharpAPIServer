namespace CSharpAPIServer
{
    /**
     * LoginAuthenticator authenticates users
     */
    public class LoginAuthenticator
    {
        public Boolean Authenticated { get; }
        public String Token { get; }
        private const String testUsername = "user";
        private const String testPassword = "password";

        /**
         * Private constructor for a login authenticator.
         * 
         * @param authenticated Whether the login is successfully authenticated or not
         */
        private LoginAuthenticator(Boolean authenticated)
        {
            this.Authenticated = authenticated;
        }

        /**
         * Attempts to authenticate a username/password and generate an appropriate response
         * 
         * @param username The password of the user
         * @param password The username of the user
         */
        public static LoginAuthenticator AuthenticateUser(String username, String password)
        {
            Boolean authenticated = username.Equals(testUsername) && password.Equals(testPassword);

            return new LoginAuthenticator(authenticated);
        }
    }
}