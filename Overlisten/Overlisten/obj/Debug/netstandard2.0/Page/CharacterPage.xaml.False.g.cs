// <CSHTML5><XamlHash>B821E706603322E8A7692950572EC8AC</XamlHash><PassNumber>1</PassNumber><CompilationDate>05/07/2023 15:44:48</CompilationDate></CSHTML5>



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
public sealed class ǀǀOverlistenǀǀComponentǀǀPageǀǀCharacterpageǀǀXamlǀǀFactory : global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.Page.CharacterPage>, global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.Page.CharacterPage>
{
    public static object Instantiate()
    {
        return CreateComponentImpl();
    }

    global::Overlisten.Page.CharacterPage global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.Page.CharacterPage>.CreateComponent()
    {
        return CreateComponentImpl();
    }

    object global::OpenSilver.Internal.Xaml.IXamlComponentFactory.CreateComponent()
    {
        return CreateComponentImpl();
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.Page.CharacterPage>.LoadComponent(global::Overlisten.Page.CharacterPage component)
    {
        LoadComponentImpl(component);
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader.LoadComponent(object component)
    {
        LoadComponentImpl((global::Overlisten.Page.CharacterPage)component);
    }

    private static void LoadComponentImpl(global::Overlisten.Page.CharacterPage Page_535c98799ae9453191aefc6f16f05387)
    {
#pragma warning disable 0184 // Prevents warning CS0184 ('The given expression is never of the provided ('type') type')
        if (Page_535c98799ae9453191aefc6f16f05387 is global::System.Windows.UIElement)
        {
            ((global::System.Windows.UIElement)(object)Page_535c98799ae9453191aefc6f16f05387).XamlSourcePath = @"Overlisten\Page\CharacterPage.xaml";
        }
#pragma warning restore 0184

        throw new global::System.NotImplementedException();
    }

    private static global::Overlisten.Page.CharacterPage CreateComponentImpl()
    {
        throw new global::System.NotImplementedException();
    }

    
}


namespace Overlisten.Page
{

public partial class CharacterPage : global::System.Windows.Controls.Page, global::OpenSilver.Internal.Xaml.IComponentConnector
{

#pragma warning disable 169, 649, 0628 // Prevents warning CS0169 ('field ... is never used'), CS0649 ('field ... is never assigned to, and will always have its default value null'), and CS0628 ('member : new protected member declared in sealed class')
internal global::Overlisten.Controls.CharacterCard @CharacterCard_Character;
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
            
            global::System.Windows.Application.LoadComponent(this, new global::ǀǀOverlistenǀǀComponentǀǀPageǀǀCharacterpageǀǀXamlǀǀFactory());
            
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        void global::OpenSilver.Internal.Xaml.IComponentConnector.Connect(int componentId, object target)
        {
        }




}

}