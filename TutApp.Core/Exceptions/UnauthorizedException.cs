namespace TutApp.Core.Exceptions
{
    public class UnauthorizedException : ApplicationException
    {
        public UnauthorizedException(string name, object key) :
            base($"{name}({key}) is Unauthorized")
        { }
    }
}
