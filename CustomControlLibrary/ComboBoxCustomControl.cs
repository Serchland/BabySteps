using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace CustomControlLibrary
{
    public class ComboBoxCustomControl : ComboBox
    {
        static ComboBoxCustomControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ComboBoxCustomControl), new FrameworkPropertyMetadata(typeof(ComboBoxCustomControl)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            var popup= GetTemplateChild("PART_Popup") as Popup;

            //Style popupStyle = this.FindResource("PopupStyle") as Style;
            //popup.Style = popupStyle;
        }

    }
}
