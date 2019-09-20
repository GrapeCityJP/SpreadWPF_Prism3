using System;
using Prism.Interactivity.InteractionRequest;

namespace Navigation.Notifications
{
    class CustomNotification : Confirmation, ICustomNotification
    {
        // 値受け渡し用のプロパティ
        public string ClassName { get; set; }

    }
}
