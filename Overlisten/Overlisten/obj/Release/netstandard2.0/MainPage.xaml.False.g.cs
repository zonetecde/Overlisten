// <CSHTML5><XamlHash>3CE44AE6BAD409566FDFBE5B7381382F</XamlHash><PassNumber>1</PassNumber><CompilationDate>05/07/2023 22:33:43</CompilationDate></CSHTML5>



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
public sealed class ǀǀOverlistenǀǀComponentǀǀMainpageǀǀXamlǀǀFactory : global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.MainPage>, global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.MainPage>
{
    public static object Instantiate()
    {
        return CreateComponentImpl();
    }

    global::Overlisten.MainPage global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.MainPage>.CreateComponent()
    {
        return CreateComponentImpl();
    }

    object global::OpenSilver.Internal.Xaml.IXamlComponentFactory.CreateComponent()
    {
        return CreateComponentImpl();
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.MainPage>.LoadComponent(global::Overlisten.MainPage component)
    {
        LoadComponentImpl(component);
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader.LoadComponent(object component)
    {
        LoadComponentImpl((global::Overlisten.MainPage)component);
    }

    private static void LoadComponentImpl(global::Overlisten.MainPage Page_a62c2cc63fbd45119cf4084bc4599aa7)
    {
#pragma warning disable 0184 // Prevents warning CS0184 ('The given expression is never of the provided ('type') type')
        if (Page_a62c2cc63fbd45119cf4084bc4599aa7 is global::System.Windows.UIElement)
        {
            ((global::System.Windows.UIElement)(object)Page_a62c2cc63fbd45119cf4084bc4599aa7).XamlSourcePath = @"Overlisten\MainPage.xaml";
        }
#pragma warning restore 0184

        throw new global::System.NotImplementedException();
    }

    private static global::Overlisten.MainPage CreateComponentImpl()
    {
        throw new global::System.NotImplementedException();
    }

    
}


namespace Overlisten
{

public partial class MainPage : global::System.Windows.Controls.Page, global::OpenSilver.Internal.Xaml.IComponentConnector
{

#pragma warning disable 169, 649, 0628 // Prevents warning CS0169 ('field ... is never used'), CS0649 ('field ... is never assigned to, and will always have its default value null'), and CS0628 ('member : new protected member declared in sealed class')
internal global::System.Windows.Controls.Grid @Grid_main;
internal global::System.Windows.Controls.WrapPanel @WrapPanel_Heros;
internal global::System.Windows.Controls.WrapPanel @WrapPanel_Others;
internal global::System.Windows.Controls.Grid @Grid_CharacterPage;
internal global::System.Windows.Controls.TextBlock @TextBlock_characterPageTitle;
internal global::System.Windows.Controls.StackPanel @Grid_Hero;
internal global::System.Windows.Controls.StackPanel @StackPanel_HeaderCategories;
internal global::System.Windows.Controls.StackPanel @StackPanel_Categories;
internal global::System.Windows.Controls.StackPanel @StackPanel_HeaderConversations;
internal global::System.Windows.Controls.StackPanel @StackPanel_Conversations;
internal global::System.Windows.Controls.Grid @Grid_Npc;
internal global::System.Windows.Controls.StackPanel @StackPanel_Sounds;
internal global::Overlisten.Controls.CharacterCard @CharacterCard_Character;
internal global::System.Windows.Controls.Grid @Grid_Loading;
internal global::System.Windows.Controls.StackPanel @StackPanel_Loading;
internal global::System.Windows.Controls.TextBlock @TextBlock_title;
internal global::System.Windows.Controls.TextBlock @TextBlock_LoadingInfo;
internal global::System.Windows.Controls.Image @Img_dropDownOpen;
internal global::System.Windows.Controls.Image @Img_dropDownClosed;
internal global::System.Windows.Controls.MediaElement @mediaElement;
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
            
            global::System.Windows.Application.LoadComponent(this, new global::ǀǀOverlistenǀǀComponentǀǀMainpageǀǀXamlǀǀFactory());
            
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        void global::OpenSilver.Internal.Xaml.IComponentConnector.Connect(int componentId, object target)
        {
        }




}

}
