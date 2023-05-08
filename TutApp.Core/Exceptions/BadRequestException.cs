namespace TutApp.Core.Exceptions
{
    public class BadRequestException : ApplicationException
    {
        public BadRequestException(string name, object key) :
            base($"{name}({key}) is bad request")
        { }
    }
}
