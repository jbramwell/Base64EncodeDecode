namespace Base64VS_Extension
{
    using Microsoft.VisualStudio.Shell;
    using System.Runtime.InteropServices;

    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("f583b45c-5dc8-4af4-8275-a1efaa351fa4")]
    public sealed class Base64Window : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Base64Window"/> class.
        /// </summary>
        public Base64Window() : base(null)
        {
            Caption = "Base64 Encode/Decode";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            Content = new Base64WindowControl();
        }
    }
}