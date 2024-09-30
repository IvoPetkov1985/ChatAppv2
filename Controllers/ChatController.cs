using ChatAppv2.Models.Messages;
using Microsoft.AspNetCore.Mvc;

namespace ChatAppv2.Controllers
{
    public class ChatController : Controller
    {
        private readonly ILogger _logger;
        private static IList<KeyValuePair<string, string>> messages
            = new List<KeyValuePair<string, string>>();

        public ChatController(ILogger<ChatController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (messages.Count == 0)
            {
                return View(new ChatViewModel());
            }

            var chatModel = new ChatViewModel()
            {
                Messages = messages
                .Select(m => new MessageViewModel()
                {
                    Sender = m.Key,
                    MessageText = m.Value
                })
                .ToList()
            };

            return View(chatModel);
        }

        [HttpPost]
        public IActionResult Send(ChatViewModel model)
        {
            var messageTosend = model.CurrentMessage;

            KeyValuePair<string, string> messageInfo =
                new(messageTosend.Sender, messageTosend.MessageText);
            messages.Add(messageInfo);

            return RedirectToAction(nameof(Index));
        }
    }
}
