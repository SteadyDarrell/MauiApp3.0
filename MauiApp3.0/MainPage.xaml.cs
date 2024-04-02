using Microsoft.Maui.Controls;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SendMessage_Clicked(object sender, EventArgs e)
        {
            string message = MessageEntry.Text;
            if (!string.IsNullOrEmpty(message))
            {
                var messageBubble = new MessageBubble
                {
                    BindingContext = new MessageViewModel { MessageText = message, BubbleColor = Colors.Blue, HorizontalAlignment = LayoutOptions.End }
                };

                MessageContainer.Children.Add(messageBubble);

                MessageEntry.Text = "";
            }
        }
    }
}
