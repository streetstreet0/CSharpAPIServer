namespace CSharpAPIServer
{
    /**
     * RandomMessage is a container for a randomly generated string
     */
    public class RandomMessage
    {
        public String Message { get; set; }

        /**
         * Private constructor for a random message.
         * 
         * @param message The message to be stored
         */
        private RandomMessage(String message)
        {
            this.Message = message;
        }

        /**
         * Generates a random message of a random length
         * 
         * @param minLength The minimum length of the message (inclusive)
         * @param maxLength The maximum length of the message (inclusive)
         */
        public static RandomMessage generateRandomMessage(int minLength, int maxLength)
        {
            Random random = new Random();
            int length = random.Next(minLength, maxLength + 1);

            String messageString = "";
            for (int i = 0; i < length; i++)
            {
                messageString += random.Next(10);
            }

            return new RandomMessage(messageString);
        }

        /**
         * Generates a random message of a set length
         * 
         * @param length The length of the message
         */
        public static RandomMessage generateRandomMessage(int length)
        {
            Random random = new Random();

            String messageString = "";
            for (int i = 0; i < length; i++)
            {
                messageString += random.Next(10);
            }

            return new RandomMessage(messageString);
        }
    }
}