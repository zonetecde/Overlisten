// <CSHTML5><XamlHash>653F5C44EF5F9387D1666E8021481858</XamlHash><PassNumber>1</PassNumber><CompilationDate>05/07/2023 20:16:26</CompilationDate></CSHTML5>



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
public sealed class ǀǀOverlistenǀǀComponentǀǀAppǀǀXamlǀǀFactory : global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.App>, global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.App>
{
    public static object Instantiate()
    {
        return CreateComponentImpl();
    }

    global::Overlisten.App global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.App>.CreateComponent()
    {
        return CreateComponentImpl();
    }

    object global::OpenSilver.Internal.Xaml.IXamlComponentFactory.CreateComponent()
    {
        return CreateComponentImpl();
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.App>.LoadComponent(global::Overlisten.App component)
    {
        LoadComponentImpl(component);
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader.LoadComponent(object component)
    {
        LoadComponentImpl((global::Overlisten.App)component);
    }

    private static void LoadComponentImpl(global::Overlisten.App Application_3a1dca84654c4dbe8aaa31c2fa7d298c)
    {
#pragma warning disable 0184 // Prevents warning CS0184 ('The given expression is never of the provided ('type') type')
        if (Application_3a1dca84654c4dbe8aaa31c2fa7d298c is global::System.Windows.UIElement)
        {
            ((global::System.Windows.UIElement)(object)Application_3a1dca84654c4dbe8aaa31c2fa7d298c).XamlSourcePath = @"Overlisten\App.xaml";
        }
#pragma warning restore 0184

        throw new global::System.NotImplementedException();
    }

    private static global::Overlisten.App CreateComponentImpl()
    {
        throw new global::System.NotImplementedException();
    }

    
}


namespace Overlisten
{

public partial class App : global::System.Windows.Application, global::OpenSilver.Internal.Xaml.IComponentConnector
{

#pragma warning disable 169, 649, 0628 // Prevents warning CS0169 ('field ... is never used'), CS0649 ('field ... is never assigned to, and will always have its default value null'), and CS0628 ('member : new protected member declared in sealed class')

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
            
            global::System.Windows.Application.LoadComponent(this, new global::ǀǀOverlistenǀǀComponentǀǀAppǀǀXamlǀǀFactory());
            
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        void global::OpenSilver.Internal.Xaml.IComponentConnector.Connect(int componentId, object target)
        {
        }




}

}
