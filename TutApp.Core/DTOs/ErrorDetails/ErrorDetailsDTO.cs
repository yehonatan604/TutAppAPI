namespace TutApp.Core.DTOs
{
    public class ErrorDetailsDTO
    {
        public string ErrorMessage { get; set; }
        public string ErrorType { get; set; }

        public ErrorDetailsDTO(string errorMessage, string errorType)
        {
            ErrorMessage = errorMessage;
            ErrorType = errorType;
        }
    }
}
