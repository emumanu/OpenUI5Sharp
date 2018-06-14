using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				public static partial class routing
				{
					[External]
					[Namespace(false)]
					public partial class History
					{
						#region Constructor

						/// <summary>
						/// Used to determine the {@link sap.ui.core.routing.HistoryDirection} of the current or a future navigation, done with a {@link sap.ui.core.routing.Router} or {@link sap.ui.core.routing.HashChanger}.
						/// 
						/// <strong>ATTENTION:</strong> this class will not be accurate if someone does hash-replacement without the named classes above If you are manipulating the hash directly this class is not supported anymore.
						/// </summary>
						/// <param name="oHashChanger">required, without a HashChanger this class cannot work. The class needs to be aware of the hash-changes.</param>
						public extern History(sap.ui.core.routing.HashChanger oHashChanger);

						#endregion

						#region Methods

						/// <summary>
						/// Determines what the navigation direction for a newly given hash would be It will say Unknown if there is a history foo - bar (current history) - foo If you now ask for the direction of the hash "foo" you get Unknown because it might be backwards or forwards. For hash replacements, the history stack will be replaced at this position for the history.
						/// </summary>
						/// <param name="sNewHash">optional, if this parameter is not passed the last hashChange is taken.</param>
						/// <returns>or undefined, if no navigation has taken place yet.</returns>
						public extern virtual sap.ui.core.routing.HistoryDirection getDirection(string sNewHash);

						/// <summary>
						/// Determines what the navigation direction for a newly given hash would be It will say Unknown if there is a history foo - bar (current history) - foo If you now ask for the direction of the hash "foo" you get Unknown because it might be backwards or forwards. For hash replacements, the history stack will be replaced at this position for the history.
						/// </summary>
						/// <returns>or undefined, if no navigation has taken place yet.</returns>
						public extern virtual sap.ui.core.routing.HistoryDirection getDirection();

						/// <returns>a global singleton that gets created as soon as the sap.ui.core.routing.History is required</returns>
						public extern static sap.ui.core.routing.History getInstance();

						/// <summary>
						/// gets the previous hash in the history - if the last direction was Unknown or there was no navigation yet, undefined will be returned
						/// </summary>
						/// <returns>or undefined</returns>
						public extern virtual string getPreviousHash();

						#endregion

					}
				}
			}
		}
	}
}
