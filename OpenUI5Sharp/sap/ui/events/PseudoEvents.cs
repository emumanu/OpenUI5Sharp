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
			public static partial class events
			{
				[External]
				[Namespace(false)]
				[Name("sap.ui.events.PseudoEvents")]
				public partial class PseudoEvents
				{
					#region Fields

					/// <summary>
					/// Ordered array of the {@link module:sap/ui/events/PseudoEvents.events}.
					/// 
					/// Order is significant as some check methods rely on the fact that they are tested before other methods. The array is processed during event analysis (when classifying browser events as pseudo events).
					/// </summary>
					public static object order;

					#endregion

					#region Methods

					/// <summary>
					/// Array containing all basic event types of the available pseudo events.
					/// </summary>
					private extern static void addEvent();

					/// <summary>
					/// Function for initialization of an Array containing all basic event types of the available pseudo events.
					/// </summary>
					private extern static void getBasicTypes();

					#endregion

					/// <summary>
					/// Enumeration of all so called "pseudo events", a useful classification of standard browser events as implied by SAP product standards.
					/// 
					/// Whenever a browser event is recognized as one or more pseudo events, then this classification is attached to the original {@link jQuery.Event} object and thereby delivered to any jQuery-style listeners registered for that browser event.
					/// 
					/// Pure JavaScript listeners can evaluate the classification information using the {@link module:sap/ui/events/jquery/EventExtension#isPseudoType} method.
					/// 
					/// Instead of using the procedure as described above, the SAPUI5 controls and elements should simply implement an <code>on<i>pseudo-event</i>(oEvent)</code> method. It will be invoked only when that specific pseudo event has been recognized. This simplifies event dispatching even further.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.events.PseudoEvents.events")]
					public enum events
					{
						/// <summary>
						/// Pseudo event for keyboard backspace without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapbackspace,
						/// <summary>
						/// Pseudo event for keyboard backspace with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapbackspacemodifiers,
						/// <summary>
						/// Pseudo event for pseudo bottom event
						/// </summary>
						sapbottom,
						/// <summary>
						/// Pseudo event for pseudo collapse event (keyboard numpad -) without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapcollapse,
						/// <summary>
						/// Pseudo event for pseudo collapse event (keyboard numpad *)
						/// </summary>
						sapcollapseall,
						/// <summary>
						/// Pseudo event for pseudo collapse event (keyboard numpad -) with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapcollapsemodifiers,
						/// <summary>
						/// Pseudo event for pseudo 'decrease' event without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapdecrease,
						/// <summary>
						/// Pseudo event for pseudo 'decrease' event with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapdecreasemodifiers,
						/// <summary>
						/// Pseudo event indicating delayed double click (e.g. for inline edit)
						/// </summary>
						sapdelayeddoubleclick,
						/// <summary>
						/// Pseudo event for keyboard delete without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapdelete,
						/// <summary>
						/// Pseudo event for keyboard delete with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapdeletemodifiers,
						/// <summary>
						/// Pseudo event for keyboard arrow down without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapdown,
						/// <summary>
						/// Pseudo event for keyboard arrow down with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapdownmodifiers,
						/// <summary>
						/// Pseudo event for keyboard End without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapend,
						/// <summary>
						/// Pseudo event for keyboard End with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapendmodifiers,
						/// <summary>
						/// Pseudo event for keyboard enter without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapenter,
						/// <summary>
						/// Pseudo event for keyboard enter with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapentermodifiers,
						/// <summary>
						/// Pseudo event for keyboard escape
						/// </summary>
						sapescape,
						/// <summary>
						/// Pseudo event for pseudo expand event (keyboard numpad +) without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapexpand,
						/// <summary>
						/// Pseudo event for pseudo expand event (keyboard numpad +) with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapexpandmodifiers,
						/// <summary>
						/// Pseudo event for pseudo 'hide' event (Alt + up-Arrow)
						/// </summary>
						saphide,
						/// <summary>
						/// Pseudo event for keyboard Home/Pos1 with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						saphome,
						/// <summary>
						/// Pseudo event for keyboard Home/Pos1 without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						saphomemodifiers,
						/// <summary>
						/// Pseudo event for pseudo 'increase' event without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapincrease,
						/// <summary>
						/// Pseudo event for pseudo 'increase' event with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapincreasemodifiers,
						/// <summary>
						/// Pseudo event for keyboard arrow left without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapleft,
						/// <summary>
						/// Pseudo event for keyboard arrow left with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapleftmodifiers,
						/// <summary>
						/// Pseudo event for pressing the '-' (minus) sign.
						/// </summary>
						sapminus,
						/// <summary>
						/// Pseudo event for pseudo 'next' event without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapnext,
						/// <summary>
						/// Pseudo event for pseudo 'next' event with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapnextmodifiers,
						/// <summary>
						/// Pseudo event for keyboard page down without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sappagedown,
						/// <summary>
						/// Pseudo event for keyboard page down with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sappagedownmodifiers,
						/// <summary>
						/// Pseudo event for keyboard page up without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sappageup,
						/// <summary>
						/// Pseudo event for keyboard page up with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sappageupmodifiers,
						/// <summary>
						/// Pseudo event for pressing the '+' (plus) sign.
						/// </summary>
						sapplus,
						/// <summary>
						/// Pseudo event for pseudo 'previous' event without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapprevious,
						/// <summary>
						/// Pseudo event for pseudo 'previous' event with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sappreviousmodifiers,
						/// <summary>
						/// Pseudo event for keyboard arrow right without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapright,
						/// <summary>
						/// Pseudo event for keyboard arrow right with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						saprightmodifiers,
						/// <summary>
						/// Pseudo event for pseudo 'select' event... space, enter, ... without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapselect,
						/// <summary>
						/// Pseudo event for pseudo 'select' event... space, enter, ... with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapselectmodifiers,
						/// <summary>
						/// Pseudo event for pseudo 'show' event (F4, Alt + down-Arrow)
						/// </summary>
						sapshow,
						/// <summary>
						/// Pseudo event for pseudo skip back (F6 + shift modifier)
						/// </summary>
						sapskipback,
						/// <summary>
						/// Pseudo event for pseudo skip forward (F6 + no modifier)
						/// </summary>
						sapskipforward,
						/// <summary>
						/// Pseudo event for keyboard space without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapspace,
						/// <summary>
						/// Pseudo event for keyboard space with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapspacemodifiers,
						/// <summary>
						/// Pseudo event for keyboard tab (TAB + no modifier)
						/// </summary>
						saptabnext,
						/// <summary>
						/// Pseudo event for keyboard tab (TAB + shift modifier)
						/// </summary>
						saptabprevious,
						/// <summary>
						/// Pseudo event for pseudo top event
						/// </summary>
						saptop,
						/// <summary>
						/// Pseudo event for keyboard arrow up without modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapup,
						/// <summary>
						/// Pseudo event for keyboard arrow up with modifiers (Ctrl, Alt or Shift)
						/// </summary>
						sapupmodifiers,
					}
				}
			}
		}
	}
}
