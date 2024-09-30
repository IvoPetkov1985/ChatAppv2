using System.ComponentModel.DataAnnotations;
using static ChatAppv2.Models.Constants.MessageViewConstants;

namespace ChatAppv2.Models.Messages
{
    public class MessageViewModel
    {
        [Required(ErrorMessage = RequiredAlert)]
        [StringLength(MessageSenderMaxLength, MinimumLength = MessageSenderMinLength, ErrorMessage = LengthAlert)]
        public string Sender { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredAlert)]
        [StringLength(MessageTextMaxLength, MinimumLength = MessageTextMinLength, ErrorMessage = LengthAlert)]
        public string MessageText { get; set; } = string.Empty;
    }
}
