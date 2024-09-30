namespace ChatAppv2.Models.Messages
{
    public class ChatViewModel
    {
        public MessageViewModel CurrentMessage { get; set; } = null!;

        public IList<MessageViewModel> Messages { get; set; } = new List<MessageViewModel>();
    }
}
