namespace Base64VS_Extension
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;

    /// <summary>
    /// Interaction logic for Base64WindowControl.
    /// </summary>
    public partial class Base64WindowControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Base64WindowControl"/> class.
        /// </summary>
        public Base64WindowControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Base64-encode the source text.
        /// </summary>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]
        private void ButtonEncode_Click(object sender, RoutedEventArgs e)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(sourceText.Text);
            resultText.Text = System.Convert.ToBase64String(plainTextBytes);
        }

        /// <summary>
        /// Base64-decode the source text.
        /// </summary>
        private void ButtonDecode_Click(object sender, RoutedEventArgs e)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(sourceText.Text);
            resultText.Text = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        /// <summary>
        /// Copy the encoded/decoded results to the Clipboard.
        /// </summary>
        private void ButtonCopy_OnClick(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(resultText.Text);
        }
    }
}