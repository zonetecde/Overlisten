// <CSHTML5><XamlHash>4BF19DDF35A895C0C99C7C0EDAB1C743</XamlHash><PassNumber>1</PassNumber><CompilationDate>07/07/2023 00:44:23</CompilationDate></CSHTML5>



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
public sealed class ǀǀOverlistenǀǀComponentǀǀControlsǀǀCharactercardǀǀXamlǀǀFactory : global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.Controls.CharacterCard>, global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.Controls.CharacterCard>
{
    public static object Instantiate()
    {
        return CreateComponentImpl();
    }

    global::Overlisten.Controls.CharacterCard global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.Controls.CharacterCard>.CreateComponent()
    {
        return CreateComponentImpl();
    }

    object global::OpenSilver.Internal.Xaml.IXamlComponentFactory.CreateComponent()
    {
        return CreateComponentImpl();
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.Controls.CharacterCard>.LoadComponent(global::Overlisten.Controls.CharacterCard component)
    {
        LoadComponentImpl(component);
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader.LoadComponent(object component)
    {
        LoadComponentImpl((global::Overlisten.Controls.CharacterCard)component);
    }

    private static void LoadComponentImpl(global::Overlisten.Controls.CharacterCard UserControl_322c9415b0cc4f63aadcb1692c1464fe)
    {
#pragma warning disable 0184 // Prevents warning CS0184 ('The given expression is never of the provided ('type') type')
        if (UserControl_322c9415b0cc4f63aadcb1692c1464fe is global::System.Windows.UIElement)
        {
            ((global::System.Windows.UIElement)(object)UserControl_322c9415b0cc4f63aadcb1692c1464fe).XamlSourcePath = @"Overlisten\Controls\CharacterCard.xaml";
        }
#pragma warning restore 0184

        throw new global::System.NotImplementedException();
    }

    private static global::Overlisten.Controls.CharacterCard CreateComponentImpl()
    {
        throw new global::System.NotImplementedException();
    }

    
}


namespace Overlisten.Controls
{

public partial class CharacterCard : global::System.Windows.Controls.UserControl, global::OpenSilver.Internal.Xaml.IComponentConnector
{

#pragma warning disable 169, 649, 0628 // Prevents warning CS0169 ('field ... is never used'), CS0649 ('field ... is never assigned to, and will always have its default value null'), and CS0628 ('member : new protected member declared in sealed class')
internal global::System.Windows.Controls.Image @Image_heroImg;
internal global::System.Windows.Controls.TextBlock @TextBlock_heroName;
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
            
            global::System.Windows.Application.LoadComponent(this, new global::ǀǀOverlistenǀǀComponentǀǀControlsǀǀCharactercardǀǀXamlǀǀFactory());
            
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        void global::OpenSilver.Internal.Xaml.IComponentConnector.Connect(int componentId, object target)
        {
        }




}

}
