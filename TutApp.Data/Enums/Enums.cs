namespace TutApp.Data.Models
{
        public enum UserTypes
        {
            Guest,
            Reader,
            Creator,
            Admin
        }

        public enum CategoryTypes
        {
            Programming,
            Internet,
            IOT,
            Design
        }

        public enum UserStatusTypes
        {
            LoggedIn,
            LoggedOff,
            Freeze
        }
        public enum MessageStatusTypes
        {
            Pending,
            Sent,
            Read
        }
        
        public enum CommentStatusTypes
        {
            Pending,
            Approved,
            Disaprooved
        }
}
