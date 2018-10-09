using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				public static partial class util
				{
					/// <summary>
					/// Utility class to handle files.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.util.File")]
					public static partial class File
					{
						#region Methods

						/// <summary>
						/// <p>Triggers a download / save action of the given file.</p>
						/// 
						/// <p>There are limitations for this feature in some browsers:<p>
						/// 
						/// <p><b>macOS Safari < 10.1 / iOS Safari</b><br> A new window or tab is opened. In macOS, the user has to save the file manually (by using key combination "CMD + S", choosing the page source format, and specifying a file name). In iOS, the content can be opened in another app (Mail, Notes, ...) or can be copied to the clipboard. If a pop-up blocker prevents this action, an error will be thrown which can be used to notify the user that the pop-up blocker needs to be disabled.</p>
						/// 
						/// <p><b>Android Browser</b><br> Not supported</p>
						/// 
						/// <p><b>Windows Phone 10 Edge</b><br> Not supported</p>
						/// </summary>
						/// <param name="sData">file content</param>
						/// <param name="sFileName">file name</param>
						/// <param name="sFileExtension">file extension</param>
						/// <param name="sMimeType">file mime-type</param>
						/// <param name="sCharset">file charset</param>
						/// <param name="bByteOrderMark">Whether to prepend a unicode byte order mark (only applies for utf-8 charset). Default is <code>false</code> except when <code>sFileExtension</code> = <code>csv</code> it is <code>true</code> (compatibility reasons).</param>
						public extern static void save(string sData, string sFileName, string sFileExtension, string sMimeType, string sCharset, bool bByteOrderMark);

						/// <summary>
						/// <p>Triggers a download / save action of the given file.</p>
						/// 
						/// <p>There are limitations for this feature in some browsers:<p>
						/// 
						/// <p><b>macOS Safari < 10.1 / iOS Safari</b><br> A new window or tab is opened. In macOS, the user has to save the file manually (by using key combination "CMD + S", choosing the page source format, and specifying a file name). In iOS, the content can be opened in another app (Mail, Notes, ...) or can be copied to the clipboard. If a pop-up blocker prevents this action, an error will be thrown which can be used to notify the user that the pop-up blocker needs to be disabled.</p>
						/// 
						/// <p><b>Android Browser</b><br> Not supported</p>
						/// 
						/// <p><b>Windows Phone 10 Edge</b><br> Not supported</p>
						/// </summary>
						/// <param name="sData">file content</param>
						/// <param name="sFileName">file name</param>
						/// <param name="sFileExtension">file extension</param>
						/// <param name="sMimeType">file mime-type</param>
						/// <param name="sCharset">file charset</param>
						public extern static void save(string sData, string sFileName, string sFileExtension, string sMimeType, string sCharset);

						#endregion

					}
				}
			}
		}
	}
}
