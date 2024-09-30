namespace ChatAppv2.Models.Constants
{
    public static class MessageViewConstants
    {
        public const int MessageSenderMinLength = 3;
        public const int MessageSenderMaxLength = 25;

        public const int MessageTextMinLength = 10;
        public const int MessageTextMaxLength = 300;

        public const string RequiredAlert = "Field {0} is required!";
        public const string LengthAlert = "Field {0} must be between {2} and {1} characters long!";
    }
}
