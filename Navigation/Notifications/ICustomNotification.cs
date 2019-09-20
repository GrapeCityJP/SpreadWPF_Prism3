using Prism.Interactivity.InteractionRequest;

namespace Navigation.Notifications
{
    public interface ICustomNotification : IConfirmation
    {
        string ClassName { get; set; }
    }
}
