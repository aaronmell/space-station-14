using System;
using Robust.Client.UserInterface.CustomControls;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;

namespace Content.Client.Labels.UI
{
    [GenerateTypedNameReferences]
    public partial class HandLabelerWindow : DefaultWindow
    {
        public event Action<string>? OnLabelEntered;

        public HandLabelerWindow()
        {
            RobustXamlLoader.Load(this);

            LabelLineEdit.OnTextEntered += e => OnLabelEntered?.Invoke(e.Text);
        }

        public void SetCurrentLabel(string label)
        {
            LabelLineEdit.Text = label;
        }
    }
}
