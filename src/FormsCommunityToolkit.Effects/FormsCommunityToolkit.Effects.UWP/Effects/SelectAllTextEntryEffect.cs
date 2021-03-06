﻿using Windows.UI.Xaml.Controls;
using FormsCommunityToolkit.Effects.UWP.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml;

[assembly: ExportEffect(typeof(SelectAllTextEntryEffect), nameof(SelectAllTextEntryEffect))]

namespace FormsCommunityToolkit.Effects.UWP.Effects
{
    [Preserve]
    public class SelectAllTextEntryEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var textbox = Control as TextBox;
            if (textbox != null)
            {
                textbox.GotFocus -= TextboxOnGotFocus;
                textbox.GotFocus += TextboxOnGotFocus;
            }
        }

        private void TextboxOnGotFocus(object sender, RoutedEventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }

        protected override void OnDetached()
        {
            var textbox = Control as TextBox;
            if (textbox != null)
            {
                textbox.GotFocus -= TextboxOnGotFocus;
            }
        }
    }
}
