using System.Runtime.Serialization;

namespace UserRegistrationUsingLambda
{
    public class UserRegistrationException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_MOBILENUMBER,
            INVALID_PASSWORD
        }

        public UserRegistrationException()
        {

        }
        public ExceptionType Type;
        public UserRegistrationException(ExceptionType exceptiontype, string message)
        {
            this.Type = exceptiontype;
        }
    }
}