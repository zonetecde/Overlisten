// <CSHTML5><XamlHash>EC4425D10B5E7FC9636F96BBC7B01A07</XamlHash><PassNumber>2</PassNumber><CompilationDate>05/07/2023 17:34:08</CompilationDate></CSHTML5>



//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by "C#/XAML for HTML5"
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
public sealed class ǀǀOverlistenǀǀComponentǀǀControlsǀǀConversationcontrolǀǀXamlǀǀFactory : global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.Controls.ConversationControl>, global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.Controls.ConversationControl>
{
    public static object Instantiate()
    {
        return CreateComponentImpl();
    }

    global::Overlisten.Controls.ConversationControl global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.Controls.ConversationControl>.CreateComponent()
    {
        return CreateComponentImpl();
    }

    object global::OpenSilver.Internal.Xaml.IXamlComponentFactory.CreateComponent()
    {
        return CreateComponentImpl();
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.Controls.ConversationControl>.LoadComponent(global::Overlisten.Controls.ConversationControl component)
    {
        LoadComponentImpl(component);
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader.LoadComponent(object component)
    {
        LoadComponentImpl((global::Overlisten.Controls.ConversationControl)component);
    }

    private static void LoadComponentImpl(global::Overlisten.Controls.ConversationControl UserControl_93c97f13a8264c64a2682d363d440bc1)
    {
#pragma warning disable 0184 // Prevents warning CS0184 ('The given expression is never of the provided ('type') type')
        if (UserControl_93c97f13a8264c64a2682d363d440bc1 is global::System.Windows.UIElement)
        {
            ((global::System.Windows.UIElement)(object)UserControl_93c97f13a8264c64a2682d363d440bc1).XamlSourcePath = @"Overlisten\Controls\ConversationControl.xaml";
        }
#pragma warning restore 0184

        var xamlContext_5ca47ca0652842acbe52291d80f6818c = global::OpenSilver.Internal.Xaml.RuntimeHelpers.Create_XamlContext();
_ = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_5ca47ca0652842acbe52291d80f6818c, UserControl_93c97f13a8264c64a2682d363d440bc1);
var StackPanel_2693d2c287dc4369bed0b5984992dd07 = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_5ca47ca0652842acbe52291d80f6818c, new global::System.Windows.Controls.StackPanel());
var StackPanel_906bc414d25b4d8e8cb4e9479a02bdc1 = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_5ca47ca0652842acbe52291d80f6818c, new global::System.Windows.Controls.StackPanel());
StackPanel_906bc414d25b4d8e8cb4e9479a02bdc1.Orientation = global::System.Windows.Controls.Orientation.Horizontal;
var Image_694666f2914a4fc792e33ad83e4734ba = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_5ca47ca0652842acbe52291d80f6818c, new global::System.Windows.Controls.Image());
global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_SetConnectionId(xamlContext_5ca47ca0652842acbe52291d80f6818c, 0, Image_694666f2914a4fc792e33ad83e4734ba);
Image_694666f2914a4fc792e33ad83e4734ba.Cursor = global::OpenSilver.Internal.Xaml.RuntimeHelpers.GetPropertyValue<global::System.Windows.Input.Cursor>(typeof(global::System.Windows.Controls.Image), @"Cursor", @"Hand", () => global::System.Windows.Input.Cursors.Hand);
Image_694666f2914a4fc792e33ad83e4734ba.Source = global::OpenSilver.Internal.Xaml.RuntimeHelpers.GetPropertyValue<global::System.Windows.Media.ImageSource>(typeof(global::System.Windows.Controls.Image), @"Source", @"/Overlisten;component/Controls/../assets/dropdown.png", () => new global::System.Windows.Media.Imaging.BitmapImage(new global::System.Uri(@"/Overlisten;component/Controls/../assets/dropdown.png", global::System.UriKind.Relative)));
Image_694666f2914a4fc792e33ad83e4734ba.Width = global::OpenSilver.Internal.Xaml.RuntimeHelpers.GetPropertyValue<global::System.Double>(typeof(global::System.Windows.Controls.Image), @"Width", @"50", () => 50D);
Image_694666f2914a4fc792e33ad83e4734ba.Height = global::OpenSilver.Internal.Xaml.RuntimeHelpers.GetPropertyValue<global::System.Double>(typeof(global::System.Windows.Controls.Image), @"Height", @"50", () => 50D);
Image_694666f2914a4fc792e33ad83e4734ba.Margin = global::OpenSilver.Internal.Xaml.RuntimeHelpers.GetPropertyValue<global::System.Windows.Thickness>(typeof(global::System.Windows.Controls.Image), @"Margin", @"40,10,0,0", () => new global::System.Windows.Thickness(40, 10, 0, 0));
global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_5ca47ca0652842acbe52291d80f6818c);
((global::System.Collections.IList)StackPanel_906bc414d25b4d8e8cb4e9479a02bdc1.Children).Add(Image_694666f2914a4fc792e33ad83e4734ba);
var TextBlock_dc99babd8ed8405c98ae77187d4d7d77 = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_5ca47ca0652842acbe52291d80f6818c, new global::System.Windows.Controls.TextBlock());
TextBlock_dc99babd8ed8405c98ae77187d4d7d77.Foreground = global::OpenSilver.Internal.Xaml.RuntimeHelpers.GetPropertyValue<global::System.Windows.Media.Brush>(typeof(global::System.Windows.Controls.TextBlock), @"Foreground", @"white", () => new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Color.FromArgb((byte)255, (byte)255, (byte)255, (byte)255)));
TextBlock_dc99babd8ed8405c98ae77187d4d7d77.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Left;
TextBlock_dc99babd8ed8405c98ae77187d4d7d77.FontSize = global::OpenSilver.Internal.Xaml.RuntimeHelpers.GetPropertyValue<global::System.Double>(typeof(global::System.Windows.Controls.TextBlock), @"FontSize", @"40", () => 40D);
TextBlock_dc99babd8ed8405c98ae77187d4d7d77.Height = global::OpenSilver.Internal.Xaml.RuntimeHelpers.GetPropertyValue<global::System.Double>(typeof(global::System.Windows.Controls.TextBlock), @"Height", @"50", () => 50D);
TextBlock_dc99babd8ed8405c98ae77187d4d7d77.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
TextBlock_dc99babd8ed8405c98ae77187d4d7d77.Margin = global::OpenSilver.Internal.Xaml.RuntimeHelpers.GetPropertyValue<global::System.Windows.Thickness>(typeof(global::System.Windows.Controls.TextBlock), @"Margin", @"10,0,0,0", () => new global::System.Windows.Thickness(10, 0, 0, 0));
TextBlock_dc99babd8ed8405c98ae77187d4d7d77.Text = @"Héros dans la conv";
TextBlock_dc99babd8ed8405c98ae77187d4d7d77.Name = "TextBlock_Conversation";
global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_5ca47ca0652842acbe52291d80f6818c);
((global::System.Collections.IList)StackPanel_906bc414d25b4d8e8cb4e9479a02bdc1.Children).Add(TextBlock_dc99babd8ed8405c98ae77187d4d7d77);
global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_5ca47ca0652842acbe52291d80f6818c);
((global::System.Collections.IList)StackPanel_2693d2c287dc4369bed0b5984992dd07.Children).Add(StackPanel_906bc414d25b4d8e8cb4e9479a02bdc1);
var StackPanel_5576d87b0e9f443887641025fd6e0fc6 = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_5ca47ca0652842acbe52291d80f6818c, new global::System.Windows.Controls.StackPanel());
StackPanel_5576d87b0e9f443887641025fd6e0fc6.Name = "StackPanel_sounds";
StackPanel_5576d87b0e9f443887641025fd6e0fc6.Margin = global::OpenSilver.Internal.Xaml.RuntimeHelpers.GetPropertyValue<global::System.Windows.Thickness>(typeof(global::System.Windows.Controls.StackPanel), @"Margin", @"0,10,0,0", () => new global::System.Windows.Thickness(0, 10, 0, 0));
global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_5ca47ca0652842acbe52291d80f6818c);
((global::System.Collections.IList)StackPanel_2693d2c287dc4369bed0b5984992dd07.Children).Add(StackPanel_5576d87b0e9f443887641025fd6e0fc6);
global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_5ca47ca0652842acbe52291d80f6818c);
UserControl_93c97f13a8264c64a2682d363d440bc1.Content = StackPanel_2693d2c287dc4369bed0b5984992dd07;
global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_5ca47ca0652842acbe52291d80f6818c);
global::OpenSilver.Internal.Xaml.RuntimeHelpers.InitializeNameScope(UserControl_93c97f13a8264c64a2682d363d440bc1);
global::OpenSilver.Internal.Xaml.RuntimeHelpers.RegisterName(UserControl_93c97f13a8264c64a2682d363d440bc1, @"TextBlock_Conversation", TextBlock_dc99babd8ed8405c98ae77187d4d7d77);
global::OpenSilver.Internal.Xaml.RuntimeHelpers.RegisterName(UserControl_93c97f13a8264c64a2682d363d440bc1, @"StackPanel_sounds", StackPanel_5576d87b0e9f443887641025fd6e0fc6);

    }

    private static global::Overlisten.Controls.ConversationControl CreateComponentImpl()
    {
        return (global::Overlisten.Controls.ConversationControl)global::CSHTML5.Internal.TypeInstantiationHelper.Instantiate(typeof(global::Overlisten.Controls.ConversationControl));
    }

    
}


namespace Overlisten.Controls
{

public partial class ConversationControl : global::System.Windows.Controls.UserControl, global::OpenSilver.Internal.Xaml.IComponentConnector
{

#pragma warning disable 169, 649, 0628 // Prevents warning CS0169 ('field ... is never used'), CS0649 ('field ... is never assigned to, and will always have its default value null'), and CS0628 ('member : new protected member declared in sealed class')
internal global::System.Windows.Controls.TextBlock @TextBlock_Conversation;
internal global::System.Windows.Controls.StackPanel @StackPanel_sounds;
#pragma warning restore 169, 649, 0628


        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        public void InitializeComponent()
        {
            if (_contentLoaded) 
            {
                return;
            }
            _contentLoaded = true;
            
            global::System.Windows.Application.LoadComponent(this, new global::ǀǀOverlistenǀǀComponentǀǀControlsǀǀConversationcontrolǀǀXamlǀǀFactory());
            this.@TextBlock_Conversation = ((global::System.Windows.Controls.TextBlock)(this.FindName("TextBlock_Conversation")));
            this.@StackPanel_sounds = ((global::System.Windows.Controls.StackPanel)(this.FindName("StackPanel_sounds")));
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        void global::OpenSilver.Internal.Xaml.IComponentConnector.Connect(int componentId, object target)
        {
            switch (componentId)
            {
                case 0:
                    ((global::System.Windows.Controls.Image)(target)).MouseLeftButtonDown += this.Image_ToggleSounds_MouseLeftButtonDown;
                    return;
            }
        }




}

}
