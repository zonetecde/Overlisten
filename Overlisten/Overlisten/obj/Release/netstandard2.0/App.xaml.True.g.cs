// <CSHTML5><XamlHash>653F5C44EF5F9387D1666E8021481858</XamlHash><PassNumber>2</PassNumber><CompilationDate>04/07/2023 17:29:31</CompilationDate></CSHTML5>



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

    private static void LoadComponentImpl(global::Overlisten.App Application_ecc06c953f4548cc899e6140c9d25d96)
    {
#pragma warning disable 0184 // Prevents warning CS0184 ('The given expression is never of the provided ('type') type')
        if (Application_ecc06c953f4548cc899e6140c9d25d96 is global::System.Windows.UIElement)
        {
            ((global::System.Windows.UIElement)(object)Application_ecc06c953f4548cc899e6140c9d25d96).XamlSourcePath = @"Overlisten\App.xaml";
        }
#pragma warning restore 0184

        var xamlContext_439546fbbc6b42c29ccfc3086390bab6 = global::OpenSilver.Internal.Xaml.RuntimeHelpers.Create_XamlContext();
_ = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_439546fbbc6b42c29ccfc3086390bab6, Application_ecc06c953f4548cc899e6140c9d25d96);
var ResourceDictionary_4354376ba19c41a9bb47c215116c3e55 = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_439546fbbc6b42c29ccfc3086390bab6, new global::System.Windows.ResourceDictionary());
global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_439546fbbc6b42c29ccfc3086390bab6);
Application_ecc06c953f4548cc899e6140c9d25d96.Resources = ResourceDictionary_4354376ba19c41a9bb47c215116c3e55;
global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_439546fbbc6b42c29ccfc3086390bab6);

    }

    private static global::Overlisten.App CreateComponentImpl()
    {
        return (global::Overlisten.App)global::CSHTML5.Internal.TypeInstantiationHelper.Instantiate(typeof(global::Overlisten.App));
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
            
global::CSHTML5.Internal.StartupAssemblyInfo.OutputRootPath = @"wwwroot\";
global::CSHTML5.Internal.StartupAssemblyInfo.OutputAppFilesPath = @"app\";
global::CSHTML5.Internal.StartupAssemblyInfo.OutputLibrariesPath = @"libs\";
global::CSHTML5.Internal.StartupAssemblyInfo.OutputResourcesPath = @"resources\";

            global::System.Windows.Application.LoadComponent(this, new global::ǀǀOverlistenǀǀComponentǀǀAppǀǀXamlǀǀFactory());
            
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        void global::OpenSilver.Internal.Xaml.IComponentConnector.Connect(int componentId, object target)
        {
        }




}

}
