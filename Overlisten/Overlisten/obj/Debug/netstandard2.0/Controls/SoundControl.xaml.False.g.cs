// <CSHTML5><XamlHash>9D7B716FD8BBE3288D804E546B22FADB</XamlHash><PassNumber>1</PassNumber><CompilationDate>06/07/2023 00:26:27</CompilationDate></CSHTML5>



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
public sealed class ǀǀOverlistenǀǀComponentǀǀControlsǀǀSoundcontrolǀǀXamlǀǀFactory : global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.Controls.SoundControl>, global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.Controls.SoundControl>
{
    public static object Instantiate()
    {
        return CreateComponentImpl();
    }

    global::Overlisten.Controls.SoundControl global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.Controls.SoundControl>.CreateComponent()
    {
        return CreateComponentImpl();
    }

    object global::OpenSilver.Internal.Xaml.IXamlComponentFactory.CreateComponent()
    {
        return CreateComponentImpl();
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.Controls.SoundControl>.LoadComponent(global::Overlisten.Controls.SoundControl component)
    {
        LoadComponentImpl(component);
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader.LoadComponent(object component)
    {
        LoadComponentImpl((global::Overlisten.Controls.SoundControl)component);
    }

    private static void LoadComponentImpl(global::Overlisten.Controls.SoundControl UserControl_2afc2094f1dd4c17a56eef2c565bf864)
    {
#pragma warning disable 0184 // Prevents warning CS0184 ('The given expression is never of the provided ('type') type')
        if (UserControl_2afc2094f1dd4c17a56eef2c565bf864 is global::System.Windows.UIElement)
        {
            ((global::System.Windows.UIElement)(object)UserControl_2afc2094f1dd4c17a56eef2c565bf864).XamlSourcePath = @"Overlisten\Controls\SoundControl.xaml";
        }
#pragma warning restore 0184

        throw new global::System.NotImplementedException();
    }

    private static global::Overlisten.Controls.SoundControl CreateComponentImpl()
    {
        throw new global::System.NotImplementedException();
    }

    
}


namespace Overlisten.Controls
{

public partial class SoundControl : global::System.Windows.Controls.UserControl, global::OpenSilver.Internal.Xaml.IComponentConnector
{

#pragma warning disable 169, 649, 0628 // Prevents warning CS0169 ('field ... is never used'), CS0649 ('field ... is never assigned to, and will always have its default value null'), and CS0628 ('member : new protected member declared in sealed class')
internal global::System.Windows.Controls.TextBlock @TextBlock_subtitle;
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
            
            global::System.Windows.Application.LoadComponent(this, new global::ǀǀOverlistenǀǀComponentǀǀControlsǀǀSoundcontrolǀǀXamlǀǀFactory());
            
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        void global::OpenSilver.Internal.Xaml.IComponentConnector.Connect(int componentId, object target)
        {
        }




}

}