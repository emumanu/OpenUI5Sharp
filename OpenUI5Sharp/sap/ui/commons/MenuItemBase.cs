using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class commons
			{
				/// <summary>
				/// Abstract base class for menu item which provides common properties and events for all concrete item implementations.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.MenuItemBase")]
				[Obsolete("Deprecated since 1.21.0. replaced by {@link sap.ui.unified.MenuItemBase}")]
				public abstract partial class MenuItemBase : sap.ui.unified.MenuItemBase
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.unified.MenuItemBase.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Abstract base class <code>MenuItemBase</code> for menu item elements. Please use concrete subclasses.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MenuItemBase(string sId, sap.ui.commons.MenuItemBase.Settings mSettings);

					/// <summary>
					/// Abstract base class <code>MenuItemBase</code> for menu item elements. Please use concrete subclasses.
					/// </summary>
					/// <param name="sId">Id for the new control, generated automatically if no id is given</param>
					public extern MenuItemBase(string sId);

					/// <summary>
					/// Abstract base class <code>MenuItemBase</code> for menu item elements. Please use concrete subclasses.
					/// </summary>
					public extern MenuItemBase();

					/// <summary>
					/// Abstract base class <code>MenuItemBase</code> for menu item elements. Please use concrete subclasses.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MenuItemBase(sap.ui.commons.MenuItemBase.Settings mSettings);

					#endregion

				}
			}
		}
	}
}
