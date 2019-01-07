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
			/// Enumeration of all so called "pseudo events", a useful classification of standard browser events as implied by SAP product standards.
			/// 
			/// Whenever a browser event is recognized as one or more pseudo events, then this classification is attached to the original {@link jQuery.Event} object and thereby delivered to any jQuery-style listeners registered for that browser event.
			/// 
			/// Pure JavaScript listeners can evaluate the classification information using the {@link jQuery.Event#isPseudoType} method.
			/// 
			/// Instead of using the procedure as described above, the SAPUI5 controls and elements should simply implement an <code>on<i>pseudo-event</i>(oEvent)</code> method. It will be invoked only when that specific pseudo event has been recognized. This simplifies event dispatching even further.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("jQuery.sap.PseudoEvents")]
			[Obsolete("Deprecated since 1.58. use {@link module:sap/ui/events/PseudoEvents.events} instead")]
			public static partial class PseudoEvents
			{
				#region Fields

				/// <summary>
				/// Pseudo event for keyboard backspace without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapbackspace;

				/// <summary>
				/// Pseudo event for keyboard backspace with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapbackspacemodifiers;

				/// <summary>
				/// Pseudo event for pseudo bottom event
				/// </summary>
				public static object sapbottom;

				/// <summary>
				/// Pseudo event for pseudo collapse event (keyboard numpad -) without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapcollapse;

				/// <summary>
				/// Pseudo event for pseudo collapse event (keyboard numpad *)
				/// </summary>
				public static object sapcollapseall;

				/// <summary>
				/// Pseudo event for pseudo collapse event (keyboard numpad -) with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapcollapsemodifiers;

				/// <summary>
				/// Pseudo event for pseudo 'decrease' event without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapdecrease;

				/// <summary>
				/// Pseudo event for pseudo 'decrease' event with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapdecreasemodifiers;

				/// <summary>
				/// Pseudo event indicating delayed double click (e.g. for inline edit)
				/// </summary>
				public static object sapdelayeddoubleclick;

				/// <summary>
				/// Pseudo event for keyboard delete without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapdelete;

				/// <summary>
				/// Pseudo event for keyboard delete with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapdeletemodifiers;

				/// <summary>
				/// Pseudo event for keyboard arrow down without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapdown;

				/// <summary>
				/// Pseudo event for keyboard arrow down with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapdownmodifiers;

				/// <summary>
				/// Pseudo event for keyboard End without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapend;

				/// <summary>
				/// Pseudo event for keyboard End with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapendmodifiers;

				/// <summary>
				/// Pseudo event for keyboard enter without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapenter;

				/// <summary>
				/// Pseudo event for keyboard enter with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapentermodifiers;

				/// <summary>
				/// Pseudo event for keyboard escape
				/// </summary>
				public static object sapescape;

				/// <summary>
				/// Pseudo event for pseudo expand event (keyboard numpad +) without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapexpand;

				/// <summary>
				/// Pseudo event for pseudo expand event (keyboard numpad +) with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapexpandmodifiers;

				/// <summary>
				/// Pseudo event for pseudo 'hide' event (Alt + up-Arrow)
				/// </summary>
				public static object saphide;

				/// <summary>
				/// Pseudo event for keyboard Home/Pos1 with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object saphome;

				/// <summary>
				/// Pseudo event for keyboard Home/Pos1 without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object saphomemodifiers;

				/// <summary>
				/// Pseudo event for pseudo 'increase' event without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapincrease;

				/// <summary>
				/// Pseudo event for pseudo 'increase' event with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapincreasemodifiers;

				/// <summary>
				/// Pseudo event for keyboard arrow left without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapleft;

				/// <summary>
				/// Pseudo event for keyboard arrow left with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapleftmodifiers;

				/// <summary>
				/// Pseudo event for pressing the '-' (minus) sign.
				/// </summary>
				public static object sapminus;

				/// <summary>
				/// Pseudo event for pseudo 'next' event without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapnext;

				/// <summary>
				/// Pseudo event for pseudo 'next' event with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapnextmodifiers;

				/// <summary>
				/// Pseudo event for keyboard page down without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sappagedown;

				/// <summary>
				/// Pseudo event for keyboard page down with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sappagedownmodifiers;

				/// <summary>
				/// Pseudo event for keyboard page up without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sappageup;

				/// <summary>
				/// Pseudo event for keyboard page up with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sappageupmodifiers;

				/// <summary>
				/// Pseudo event for pressing the '+' (plus) sign.
				/// </summary>
				public static object sapplus;

				/// <summary>
				/// Pseudo event for pseudo 'previous' event without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapprevious;

				/// <summary>
				/// Pseudo event for pseudo 'previous' event with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sappreviousmodifiers;

				/// <summary>
				/// Pseudo event for keyboard arrow right without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapright;

				/// <summary>
				/// Pseudo event for keyboard arrow right with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object saprightmodifiers;

				/// <summary>
				/// Pseudo event for pseudo 'select' event... space, enter, ... without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapselect;

				/// <summary>
				/// Pseudo event for pseudo 'select' event... space, enter, ... with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapselectmodifiers;

				/// <summary>
				/// Pseudo event for pseudo 'show' event (F4, Alt + down-Arrow)
				/// </summary>
				public static object sapshow;

				/// <summary>
				/// Pseudo event for pseudo skip back (F6 + shift modifier)
				/// </summary>
				public static object sapskipback;

				/// <summary>
				/// Pseudo event for pseudo skip forward (F6 + no modifier)
				/// </summary>
				public static object sapskipforward;

				/// <summary>
				/// Pseudo event for keyboard space without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapspace;

				/// <summary>
				/// Pseudo event for keyboard space with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapspacemodifiers;

				/// <summary>
				/// Pseudo event for keyboard tab (TAB + no modifier)
				/// </summary>
				public static object saptabnext;

				/// <summary>
				/// Pseudo event for keyboard tab (TAB + shift modifier)
				/// </summary>
				public static object saptabprevious;

				/// <summary>
				/// Pseudo event for pseudo top event
				/// </summary>
				public static object saptop;

				/// <summary>
				/// Pseudo event for keyboard arrow up without modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapup;

				/// <summary>
				/// Pseudo event for keyboard arrow up with modifiers (Ctrl, Alt or Shift)
				/// </summary>
				public static object sapupmodifiers;

				#endregion

			}
		}
	}
}
