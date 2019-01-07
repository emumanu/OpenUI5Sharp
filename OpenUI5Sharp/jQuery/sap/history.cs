using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public abstract partial class jQuery
	{
		public static partial class sap
		{
			/// <summary>
			/// Enables the back and forward buttons in browser to navigate back or forth through the browser history stack.<br/><br/>
			/// 
			/// It also supports adding virtual history which used only to mark some intermediate state in order to navigate back to the previous state. And this state will be skipped from the browser history stack immediately after a new history state is added to the history stack after this state <br/><br/>
			/// 
			/// By providing the hash saved from the return value of calling jQuery.sap.history.addHistory, jQuery.sap.history.backToHash will navigate back directly to the history state with the same hash. <br/><br/>
			/// 
			/// Please use jQuery.sap.history.back() to go one step back in the history stack instead of using window.history.back(), because it handles the empty history stack situation and will call the defaultHandler for this case. <br/><br/>
			/// 
			/// Example for the usage of history handling: <pre>
			/// 	//Initialization
			/// 	jQuery.sap.history({
			/// 		routes: [], //please refer to the jQuery.sap.history function comment for the format.
			/// 		defaultHandler: function(){
			/// 			//code here
			/// 		}
			/// 	});
			/// 
			/// 	//add history
			/// 	var hash = jQuery.sap.history.addHistory("IDENTIFIER", jsonData);
			/// 
			/// 	//add virtual history
			/// 	jQuery.sap.history.addVirtualHistory();
			/// 
			/// 	//back to hash
			/// 	jQuery.sap.history.backToHash(hash);
			/// 
			/// 	//back one step along the history stack
			/// 	jQuery.sap.history.back();
			/// </pre>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("jQuery.sap.history")]
			[Obsolete("Deprecated since 1.19.1. Please use {@link sap.ui.core.routing.Route} instead.")]
			public partial class history
			{
				#region Constructor

				/// <summary>
				/// jQuery.sap.history is deprecated. Please use {@link sap.ui.core.routing.Route} instead.
				/// 
				/// Initialize the history handling and set the routes and default handler. This should be only called once with the mSettings set in the right format. If the mSettings is not an object, you have another chance to call this function again to initialize the history handling. But once the mSettings is set with an object, you can only call the addRoute and setDefaultHandler to set the data.
				/// </summary>
				/// <param name="mSettings">The map that contains data in format: <pre>
				/// {
				/// 	routes: [{
				/// 		path: string //identifier for one kind of hash
				/// 		handler: function	//function what will be called when the changed hash is matched against the path.
				/// 							//first parameter: the json data passed in when calling the addHistory
				/// 							//second parameter: the type of the navigation {@link jQuery.sap.history.NavType}
				/// 		}],
				/// 		defaultHandler: function	//this function will be called when empty hash is matched
				/// 									//first parameter: the type of the navigation {@link jQuery.sap.history.NavType}
				/// }
				/// </pre></param>
				public extern history(object mSettings);

				#endregion

				#region Methods

				/// <summary>
				/// This function adds a history record. It will not trigger the related handler of the routes, the changes have to be done by the developer. Normally, a history record should be added when changes are done already.
				/// </summary>
				/// <param name="sIdf">The identifier defined in the routes which will be matched in order to call the corresponding handler</param>
				/// <param name="oStateData">The object passed to the corresponding handler when the identifier is matched with the url hash</param>
				/// <param name="bBookmarkable">Default value is set to true. If this is set to false, the default handler will be called when this identifier and data are matched</param>
				/// <param name="bVirtual">This states if the history is a virtual history that should be skipped when going forward or backward in the history stack.</param>
				/// <returns>sHash The complete hash string which contains the identifier, stringified data, optional uid, and bookmarkable digit. This hash can be passed into the backToHash function when navigating back to this state is intended.</returns>
				public extern virtual string addHistory(string sIdf, object oStateData, bool bBookmarkable, bool bVirtual);

				/// <summary>
				/// This function adds a history record. It will not trigger the related handler of the routes, the changes have to be done by the developer. Normally, a history record should be added when changes are done already.
				/// </summary>
				/// <param name="sIdf">The identifier defined in the routes which will be matched in order to call the corresponding handler</param>
				/// <param name="oStateData">The object passed to the corresponding handler when the identifier is matched with the url hash</param>
				/// <param name="bBookmarkable">Default value is set to true. If this is set to false, the default handler will be called when this identifier and data are matched</param>
				/// <returns>sHash The complete hash string which contains the identifier, stringified data, optional uid, and bookmarkable digit. This hash can be passed into the backToHash function when navigating back to this state is intended.</returns>
				public extern virtual string addHistory(string sIdf, object oStateData, bool bBookmarkable);

				/// <summary>
				/// Adds a route to the history handling.
				/// </summary>
				/// <param name="sIdf">The identifier that is matched with the hash in the url in order to call the corresponding handler.</param>
				/// <param name="fn">The function that will be called when the identifier is matched with the hash.</param>
				/// <param name="oThis">If oThis is provided, the fn function's this keyword will be bound to this object.</param>
				/// <returns>It returns the this object to enable chaining.</returns>
				public extern virtual object addRoute(string sIdf, object fn, object oThis);

				/// <summary>
				/// Adds a route to the history handling.
				/// </summary>
				/// <param name="sIdf">The identifier that is matched with the hash in the url in order to call the corresponding handler.</param>
				/// <param name="fn">The function that will be called when the identifier is matched with the hash.</param>
				/// <returns>It returns the this object to enable chaining.</returns>
				public extern virtual object addRoute(string sIdf, object fn);

				/// <summary>
				/// This function adds a virtual history record based on the current hash. A virtual record is only for marking the current state of the application, and when the back button clicked it will return to the previous state. It is used when the marked state shouldn't be seen by the user when user click the back or forward button of the browser. For example, when showing a context menu a virtual history record should be added and this record will be skipped when user navigates back and it will return directly to the previous history record. If you avoid adding the virtual history record, it will return to one history record before the one your virtual record is based on. That's why virtual record is necessary.
				/// </summary>
				public extern virtual void addVirtualHistory();

				/// <summary>
				/// This function navigates back through the history stack. The number of steps is set by the parameter iSteps. It also handles the situation when it's called while there's nothing in the history stack. Normally this happens when the application is restored from the bookmark. If there's nothing in the history stack, the default handler will be called with NavType jQuery.sap.history.NavType.Back.
				/// </summary>
				/// <param name="iSteps">how many steps you want to go back, by default the value is 1.</param>
				public extern virtual void back(int iSteps);

				/// <summary>
				/// This function navigates back through the history stack. The number of steps is set by the parameter iSteps. It also handles the situation when it's called while there's nothing in the history stack. Normally this happens when the application is restored from the bookmark. If there's nothing in the history stack, the default handler will be called with NavType jQuery.sap.history.NavType.Back.
				/// </summary>
				public extern virtual void back();

				/// <summary>
				/// This function will navigate back to the recent history state which has the sPath identifier. It is usually used to navigate back along one specific route and jump over the intermediate history state if there are any.
				/// </summary>
				/// <param name="sPath">The route identifier to which the history navigates back.</param>
				public extern virtual void backThroughPath(string sPath);

				/// <summary>
				/// This function calculate the number of back steps to the specific sHash passed as parameter, and then go back to the history state with this hash.
				/// </summary>
				/// <param name="sHash">The hash string needs to be navigated. This is normally returned when you call the addhistory method.</param>
				public extern virtual void backToHash(string sHash);

				/// <summary>
				/// Set the default handler which will be called when there's an empty hash in the url.
				/// </summary>
				/// <param name="fn">The function that will be set as the default handler</param>
				public extern virtual void setDefaultHandler(object fn);

				#endregion

				[External]
				[Namespace(false)]
				[Name("jQuery.sap.history.NavType")]
				[Obsolete("Deprecated since 1.19.1. Please use {@link sap.ui.core.routing.HistoryDirection} instead.")]
				public enum NavType
				{
					/// <summary>
					/// This indicates that the new hash is achieved by pressing the back button.
					/// </summary>
					Back,
					/// <summary>
					/// This indicates that the new hash is restored from the bookmark.
					/// </summary>
					Bookmark,
					/// <summary>
					/// This indicates that the new hash is achieved by pressing the forward button.
					/// </summary>
					Forward,
					/// <summary>
					/// This indicates that the new hash is achieved by some unknown direction. This happens when the user navigates out of the application and then click on the forward button in the browser to navigate back to the application.
					/// </summary>
					Unknown,
				}
			}
		}
	}
}
