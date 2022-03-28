using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WpfCustomControlLibrary
{
    public class CustomControl : ComboBox
    {
        static CustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl), new FrameworkPropertyMetadata(typeof(CustomControl)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var popup = GetTemplateChild("PART_Popup") as Popup;
            Style popupStyle = Application.Current.FindResource("PopupStyle") as Style;
            popup.Style = popupStyle;
        }
    }
}
