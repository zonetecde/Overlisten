// <CSHTML5><XamlHash>F986D63B920D1B9B8A14BC22F6AFAC8C</XamlHash><PassNumber>1</PassNumber><CompilationDate>07/07/2023 00:44:23</CompilationDate></CSHTML5>



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
public sealed class ǀǀOverlistenǀǀComponentǀǀControlsǀǀCategorycontrolǀǀXamlǀǀFactory : global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.Controls.CategoryControl>, global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.Controls.CategoryControl>
{
    public static object Instantiate()
    {
        return CreateComponentImpl();
    }

    global::Overlisten.Controls.CategoryControl global::OpenSilver.Internal.Xaml.IXamlComponentFactory<global::Overlisten.Controls.CategoryControl>.CreateComponent()
    {
        return CreateComponentImpl();
    }

    object global::OpenSilver.Internal.Xaml.IXamlComponentFactory.CreateComponent()
    {
        return CreateComponentImpl();
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader<global::Overlisten.Controls.CategoryControl>.LoadComponent(global::Overlisten.Controls.CategoryControl component)
    {
        LoadComponentImpl(component);
    }

    void global::OpenSilver.Internal.Xaml.IXamlComponentLoader.LoadComponent(object component)
    {
        LoadComponentImpl((global::Overlisten.Controls.CategoryControl)component);
    }

    private static void LoadComponentImpl(global::Overlisten.Controls.CategoryControl UserControl_6804c5dd2a7e40e897df9c0cf64a662b)
    {
#pragma warning disable 0184 // Prevents warning CS0184 ('The given expression is never of the provided ('type') type')
        if (UserControl_6804c5dd2a7e40e897df9c0cf64a662b is global::System.Windows.UIElement)
        {
            ((global::System.Windows.UIElement)(object)UserControl_6804c5dd2a7e40e897df9c0cf64a662b).XamlSourcePath = @"Overlisten\Controls\CategoryControl.xaml";
        }
#pragma warning restore 0184

        throw new global::System.NotImplementedException();
    }

    private static global::Overlisten.Controls.CategoryControl CreateComponentImpl()
    {
        throw new global::System.NotImplementedException();
    }

    
}


namespace Overlisten.Controls
{

public partial class CategoryControl : global::System.Windows.Controls.UserControl, global::OpenSilver.Internal.Xaml.IComponentConnector
{

#pragma warning disable 169, 649, 0628 // Prevents warning CS0169 ('field ... is never used'), CS0649 ('field ... is never assigned to, and will always have its default value null'), and CS0628 ('member : new protected member declared in sealed class')
internal global::System.Windows.Controls.Image @img_dropDown;
internal global::System.Windows.Controls.TextBlock @TextBlock_CategoryName;
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
            
            global::System.Windows.Application.LoadComponent(this, new global::ǀǀOverlistenǀǀComponentǀǀControlsǀǀCategorycontrolǀǀXamlǀǀFactory());
            
        }


        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        void global::OpenSilver.Internal.Xaml.IComponentConnector.Connect(int componentId, object target)
        {
        }




}

}
