//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Input;

//namespace CustomControlLibrary
//{
//    [TemplatePart(Name = "PART_TextBlock", Type = typeof(TextBlock))]
//    public class CustomControl : Control
//    {
//        private const string PART_TextBlock = "PART_TextBlock";

//        private TextBlock textBlock;
//        protected TextBlock TextBlock
//        {
//            get { return textBlock; }
//            set
//            {
//                if (textBlock != null)
//                    textBlock.TextInput -= new TextCompositionEventHandler(TextBlock_TextInput);

//                textBlock = value;

//                if (textBlock != null)
//                {
//                    textBlock.TextInput += new TextCompositionEventHandler(TextBlock_TextInput);
//                }
//            }
//        }

//        static CustomControl()
//        {
//            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl), new FrameworkPropertyMetadata(typeof(CustomControl)));
//        }

//        public override void OnApplyTemplate()
//        {
//            base.OnApplyTemplate();

//            textBlock = GetTemplateChild(PART_TextBlock) as TextBlock;
//            textBlock.Text = "Set from code";
//            textBlock.TextInput += TextBlock_TextInput;
//        }

//        private void TextBlock_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
//        {

//        }
//    }
//}
