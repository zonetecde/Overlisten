// <CSHTML5><XamlHash>653F5C44EF5F9387D1666E8021481858</XamlHash><PassNumber>2</PassNumber><CompilationDate>05/07/2023 12:15:28</CompilationDate></CSHTML5>



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
public sealed class ǀǀOverlistenǀǀComponentǀǀExtensionǀǀAppǀǀXamlǀǀFactory : global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.App>, global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.App>
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

    private static void LoadComponentImpl(global::Overlisten.App Application_39902ef9b1364ad38a84d257626cf9ae)
    {
#pragma warning disable 0184 // Prevents warning CS0184 ('The given expression is never of the provided ('type') type')
        if (Application_39902ef9b1364ad38a84d257626cf9ae is global::System.Windows.UIElement)
        {
            ((global::System.Windows.UIElement)(object)Application_39902ef9b1364ad38a84d257626cf9ae).XamlSourcePath = @"Overlisten\Extension\App.xaml";
        }
#pragma warning restore 0184

        var xamlContext_7b8aa17a9ae0455a912538711a3874fd = global::OpenSilver.Internal.Xaml.RuntimeHelpers.Create_XamlContext();
_ = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_7b8aa17a9ae0455a912538711a3874fd, Application_39902ef9b1364ad38a84d257626cf9ae);
var ResourceDictionary_a8498e71f10a4c3d8b0c881706cceccf = global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PushScope(xamlContext_7b8aa17a9ae0455a912538711a3874fd, new global::System.Windows.ResourceDictionary());
global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_7b8aa17a9ae0455a912538711a3874fd);
Application_39902ef9b1364ad38a84d257626cf9ae.Resources = ResourceDictionary_a8498e71f10a4c3d8b0c881706cceccf;
global::OpenSilver.Internal.Xaml.RuntimeHelpers.XamlContext_PopScope(xamlContext_7b8aa17a9ae0455a912538711a3874fd);

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

            global::System.Windows.Application.LoadComponent(this, new global::ǀǀOverlistenǀǀComponentǀǀExtensionǀǀAppǀǀXamlǀǀFactory());
            
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        void global::OpenSilver.Internal.Xaml.IComponentConnector.Connect(int componentId, object target)
        {
        }




}

}