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
				/// <summary>
				/// The IconPool is a static class for retrieving or registering icons. It also provides helping methods for easier consumption of icons. There are already icons registered in IconPool, please use the Demo App named "Icon Explorer" to find the name of the icon.
				/// 
				/// In order to use the icon inside an existing control, please call {@link sap.ui.core.IconPool.getIconURI} and assign the URI to the control's property which supports icons. If you want to support both, icons and standard images in your own control, please use the static method {@link sap.ui.core.IconPool.createControlByURI} to either create an Icon in case the first argument is an icon-URL or another control which you define by providing it as the second argument.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.IconPool")]
				public static partial class IconPool
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class AddIconInfo
					{
						/// <summary>
						/// is the name of the font when importing the font using @font-face in CSS
						/// </summary>
						public string fontFamily;

						/// <summary>
						/// is the special hexadecimal code without the prefix, for example "e000" or several of them
						/// </summary>
						public Union<string, string[]> content;

						/// <summary>
						/// indicates if already registered icons should be overwritten when the same name and collection are given. The built in icons can never be overwritten.
						/// </summary>
						public bool overWrite;

						/// <summary>
						/// indicates whether this icon should NOT be mirrored in RTL (right to left) mode.
						/// </summary>
						public bool suppressMirroring;

						/// <summary>
						/// ResourceBundle to be used for translation. Key format: "Icon.<iconName>".
						/// </summary>
						public jQuery.sap.util.ResourceBundle resourceBundle;

					}

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class RegisterFontConfig
					{
						/// <summary>
						/// the file name of the font face
						/// </summary>
						public string fontFamily;

						/// <summary>
						/// a collection name for the font, if not specified the font face will be used
						/// </summary>
						public string collectionName;

						/// <summary>
						/// the location where the font files are physically located
						/// </summary>
						public sap.ui.core.URI fontURI;

						/// <summary>
						/// a configuration object mapping the icon name to the hexadecimal icon address in the font
						/// </summary>
						public object metadata;

						/// <summary>
						/// an URI to a file containing the configuration object specified with oConfig.metadata
						/// </summary>
						public object metadataURI;

						/// <summary>
						/// load the icon font metadata only when an icon is requested with {@link #.getIconInfo} if not specified a JSON file with the name oConfig.fontFamily will be loaded from the location specified in oConfig.fontURI
						/// </summary>
						public bool lazy;

					}

					#endregion

					#region Methods

					/// <summary>
					/// Register an additional icon to the sap.ui.core.IconPool.
					/// </summary>
					/// <param name="iconName">the name of the icon.</param>
					/// <param name="collectionName">the name of icon collection. The built in icons are with empty collectionName, so if additional icons need to be registered in IconPool, the collectionName can't be empty.</param>
					/// <param name="iconInfo">the icon info which contains the following properties:</param>
					/// <returns>the info object of the registered icon which has the name, collection, uri, fontFamily, content and suppressMirroring properties.</returns>
					public extern static object addIcon(string iconName, string collectionName, sap.ui.core.IconPool.AddIconInfo iconInfo);

					/// <summary>
					/// Creates an instance of {@link sap.ui.core.Icon} if the given URI is an icon URI, otherwise the given constructor is called. The given URI is set to the src property of the control.
					/// </summary>
					/// <param name="setting">contains the properties which will be used to instantiate the returned control. It should contain at least a property named src. If it's given with a string type, it will be taken as the value of src property.</param>
					/// <param name="constructor">the constructor function which is called when the given URI isn't an icon URI</param>
					/// <returns>either an instance of sap.ui.core.Icon or instance created by calling the given constructor</returns>
					public extern static sap.ui.core.Control createControlByURI(Union<string, object> setting, object constructor);

					/// <summary>
					/// Checks if the icon font is loaded
					/// </summary>
					/// <param name="sCollectionName">icon collection name</param>
					/// <returns>a Promise that resolves when the icon font is loaded; or <code>undefined</code> if the icon font has not been registered yet</returns>
					public extern static jquery.JQueryPromise<object> fontLoaded(string sCollectionName);

					/// <summary>
					/// Returns all names of registered collections in IconPool
					/// </summary>
					/// <returns>An array contains all of the registered collections' names.</returns>
					public extern static object[] getIconCollectionNames();

					/// <summary>
					/// Returns the icon url based on the given mime type
					/// </summary>
					/// <param name="sMimeType">the mime type of a file (e.g. "application/zip")</param>
					/// <returns>the icon url (e.g. "sap-icon://attachment-zip-file")</returns>
					public extern static string getIconForMimeType(string sMimeType);

					/// <summary>
					/// Returns an info object for the icon with the given <code>iconName</code> and <code>collectionName</code>.
					/// 
					/// Instead of giving name and collection, a complete icon-URI can be provided as <code>iconName</code>. The method will determine name and collection from the URI, see {@link #.isIconURI IconPool.isIconURI} for details.
					/// 
					/// The returned info object has the following properties: <ul> <li><code>string: name</code> Name of the icon</li> <li><code>string: collection</code> Name of the collection that contains the icon or <code>undefined</code> in case of the default collection</li> <li><code>string: uri</code> Icon URI that identifies the icon</li> <li><code>string: fontFamily</code> CSS font family to use for this icon</li> <li><code>string: content</code> Character sequence that represents the icon in the icon font</li> <li><code>string: text</code> Alternative text describing the icon (optional, might be empty)</li> <li><code>boolean: suppressMirroring</code> Whether the icon needs no mirroring in right-to-left mode</li> </ul>
					/// </summary>
					/// <param name="iconName">Name of the icon, or a complete icon-URI with icon collection and icon name; must not be empty</param>
					/// <param name="collectionName">Name of the icon collection; to access built-in icons, omit the collection name</param>
					/// <param name="loadingMode">The approach for loading the icon info, if it is not already available: sync (default) - font metadata is loaded synchronously and the icon info is returned immediately async - a promise is returned that returns the icon info when the font metadata is loaded mixed - until the font metadata is loaded a promise is returned, afterwards the icon info</param>
					/// <returns>Info object or Promise for the icon depending on the loadingMode or <code>undefined</code> when the icon can't be found or no icon name was given.</returns>
					public extern static Union<object, jquery.JQueryPromise<object>> getIconInfo(string iconName, string collectionName, string loadingMode);

					/// <summary>
					/// Returns an info object for the icon with the given <code>iconName</code> and <code>collectionName</code>.
					/// 
					/// Instead of giving name and collection, a complete icon-URI can be provided as <code>iconName</code>. The method will determine name and collection from the URI, see {@link #.isIconURI IconPool.isIconURI} for details.
					/// 
					/// The returned info object has the following properties: <ul> <li><code>string: name</code> Name of the icon</li> <li><code>string: collection</code> Name of the collection that contains the icon or <code>undefined</code> in case of the default collection</li> <li><code>string: uri</code> Icon URI that identifies the icon</li> <li><code>string: fontFamily</code> CSS font family to use for this icon</li> <li><code>string: content</code> Character sequence that represents the icon in the icon font</li> <li><code>string: text</code> Alternative text describing the icon (optional, might be empty)</li> <li><code>boolean: suppressMirroring</code> Whether the icon needs no mirroring in right-to-left mode</li> </ul>
					/// </summary>
					/// <param name="iconName">Name of the icon, or a complete icon-URI with icon collection and icon name; must not be empty</param>
					/// <param name="collectionName">Name of the icon collection; to access built-in icons, omit the collection name</param>
					/// <returns>Info object or Promise for the icon depending on the loadingMode or <code>undefined</code> when the icon can't be found or no icon name was given.</returns>
					public extern static Union<object, jquery.JQueryPromise<object>> getIconInfo(string iconName, string collectionName);

					/// <summary>
					/// Returns an info object for the icon with the given <code>iconName</code> and <code>collectionName</code>.
					/// 
					/// Instead of giving name and collection, a complete icon-URI can be provided as <code>iconName</code>. The method will determine name and collection from the URI, see {@link #.isIconURI IconPool.isIconURI} for details.
					/// 
					/// The returned info object has the following properties: <ul> <li><code>string: name</code> Name of the icon</li> <li><code>string: collection</code> Name of the collection that contains the icon or <code>undefined</code> in case of the default collection</li> <li><code>string: uri</code> Icon URI that identifies the icon</li> <li><code>string: fontFamily</code> CSS font family to use for this icon</li> <li><code>string: content</code> Character sequence that represents the icon in the icon font</li> <li><code>string: text</code> Alternative text describing the icon (optional, might be empty)</li> <li><code>boolean: suppressMirroring</code> Whether the icon needs no mirroring in right-to-left mode</li> </ul>
					/// </summary>
					/// <param name="iconName">Name of the icon, or a complete icon-URI with icon collection and icon name; must not be empty</param>
					/// <returns>Info object or Promise for the icon depending on the loadingMode or <code>undefined</code> when the icon can't be found or no icon name was given.</returns>
					public extern static Union<object, jquery.JQueryPromise<object>> getIconInfo(string iconName);

					/// <summary>
					/// Returns all name of icons that are registered under the given collection.
					/// </summary>
					/// <param name="collectionName">the name of collection where icon names are retrieved.</param>
					/// <returns>An array contains all of the registered icon names under the given collection.</returns>
					public extern static object[] getIconNames(string collectionName);

					/// <summary>
					/// Returns the URI of the icon in the pool which has the given <code>iconName</code> and <code>collectionName</code>.
					/// </summary>
					/// <param name="iconName">Name of the icon, must not be empty</param>
					/// <param name="collectionName">Name of the icon collection; to access built-in icons, omit the collection name</param>
					/// <returns>URI of the icon or <code>undefined</code> if the icon can't be found in the IconPool</returns>
					public extern static string getIconURI(string iconName, string collectionName);

					/// <summary>
					/// Returns the URI of the icon in the pool which has the given <code>iconName</code> and <code>collectionName</code>.
					/// </summary>
					/// <param name="iconName">Name of the icon, must not be empty</param>
					/// <returns>URI of the icon or <code>undefined</code> if the icon can't be found in the IconPool</returns>
					public extern static string getIconURI(string iconName);

					/// <summary>
					/// Returns whether the given <code>uri</code> is an icon URI.
					/// 
					/// A string is an icon URI when it can be parsed as a URI and when it has one of the two forms <ul> <li>sap-icon://collectionName/iconName</li> <li>sap-icon://iconName</li> </ul> where collectionName and iconName must be non-empty.
					/// </summary>
					/// <param name="uri">The URI to check</param>
					/// <returns>Whether the URI matches the icon URI format</returns>
					public extern static bool isIconURI(string uri);

					/// <summary>
					/// Registers an additional icon font to the icon pool
					/// </summary>
					/// <param name="oConfig">configuration object for registering the font</param>
					public extern static void registerFont(sap.ui.core.IconPool.RegisterFontConfig oConfig);

					#endregion

				}
			}
		}
	}
}
