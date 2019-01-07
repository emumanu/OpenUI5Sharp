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
			public static partial class codeeditor
			{
				/// <summary>
				/// Allows to visualize source code of various types with syntax highlighting, line numbers in editable and read only mode. Use this controls in scenarios where the user should be able to inspect and edit source code. NOTE: There is a known limitation where CodeEditor won't work within IconTabBar on Internet Explorer. There is a way to achieve the same functionality - an example of IconTabHeader and a CodeEditor can be found in the CodeEditor's samples.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.codeeditor.CodeEditor")]
				public partial class CodeEditor : sap.ui.core.Control
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Control.Settings
					{
						/// <summary>
						/// The value displayed in the code editor
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

						/// <summary>
						/// The type of the code in the editor used for syntax highlighting Possible types are: abap, abc, actionscript, ada, apache_conf, applescript, asciidoc, assembly_x86, autohotkey, batchfile, bro, c9search, c_cpp, cirru, clojure, cobol, coffee, coldfusion, csharp, css, curly, d, dart, diff, django, dockerfile, dot, drools, eiffel, ejs, elixir, elm, erlang, forth, fortran, ftl, gcode, gherkin, gitignore, glsl, gobstones, golang, groovy, haml, handlebars, haskell, haskell_cabal, haxe, hjson, html, html_elixir, html_ruby, ini, io, jack, jade, java, javascript, json, jsoniq, jsp, jsx, julia, kotlin, latex, lean, less, liquid, lisp, live_script, livescript, logiql, lsl, lua, luapage, lucene, makefile, markdown, mask, matlab, mavens_mate_log, maze, mel, mips_assembler, mipsassembler, mushcode, mysql, nix, nsis, objectivec, ocaml, pascal, perl, pgsql, php, plain_text, powershell, praat, prolog, properties, protobuf, python, r, razor, rdoc, rhtml, rst, ruby, rust, sass, scad, scala, scheme, scss, sh, sjs, smarty, snippets, soy_template, space, sql, sqlserver, stylus, svg, swift, swig, tcl, tex, text, textile, toml, tsx, twig, typescript, vala, vbscript, velocity, verilog, vhdl, wollok, xml, xquery, yaml
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

						/// <summary>
						/// The width of the code editor
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// The height of the code editor. A minimal height of 3rem will be applied in case the height is less than 20px.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Sets whether the code in the editor can be changed by the user
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

						/// <summary>
						/// Sets whether line numbers should be shown
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> lineNumbers;

						/// <summary>
						/// Sets whether the code is automatically selected if a value is set
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> valueSelection;

						/// <summary>
						/// Sets whether the editor height should auto expand to a maximum number of lines. After reaching the maximum number of lines specified, the content of the <code>CodeEditor</code> will become scrollable.
						/// 
						/// <b>Note:</b> Keep in mind that the auto expand <code>CodeEditor</code> behavior requires the <code>height</code> property to be set to <code>auto</code>.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxLines;

						/// <summary>
						/// Sets the editors color theme Possible values are: default, hcb, hcb_bright, hcb_blue, theme-ambiance, chaos, chrome, clouds, clouds_midnight, cobalt, crimson_editor, dawn, dreamweaver, eclipse, github, gob, gruvbox, idle_fingers, iplastic, katzenmilch, kr_theme, kuroir, merbivore, merbivore_soft, mono_industrial, monokai, pastel_on_dark, solarized_dark, solarized_light, sqlserver, terminal, textmate, tomorrow, tomorrow_night, tomorrow_night_blue, tomorrow_night_bright, tomorrow_night_eighties, twilight, vibrant_ink, xcode
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> colorTheme;

						/// <summary>
						/// Sets whether to show syntax hints the editor. This flag is only available if line numbers are shown.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> syntaxHints;

						public sap.ui.@base.EventDelegate liveChange;

						public sap.ui.@base.EventDelegate change;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new CodeEditor.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CodeEditor(string sId, sap.ui.codeeditor.CodeEditor.Settings mSettings);

					/// <summary>
					/// Constructor for a new CodeEditor.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern CodeEditor(string sId);

					/// <summary>
					/// Constructor for a new CodeEditor.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern CodeEditor();

					/// <summary>
					/// Constructor for a new CodeEditor.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CodeEditor(sap.ui.codeeditor.CodeEditor.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property value

					/// <summary>
					/// Gets current value of property {@link #getValue value}.
					/// 
					/// The value displayed in the code editor
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>value</code></returns>
					public extern virtual string getValue();

					/// <summary>
					/// Sets the value of the code editor
					/// </summary>
					/// <param name="sValue">the value of the code editor</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor setValue(string sValue);

					#endregion

					#region Methods for Property type

					/// <summary>
					/// Gets current value of property {@link #getType type}.
					/// 
					/// The type of the code in the editor used for syntax highlighting Possible types are: abap, abc, actionscript, ada, apache_conf, applescript, asciidoc, assembly_x86, autohotkey, batchfile, bro, c9search, c_cpp, cirru, clojure, cobol, coffee, coldfusion, csharp, css, curly, d, dart, diff, django, dockerfile, dot, drools, eiffel, ejs, elixir, elm, erlang, forth, fortran, ftl, gcode, gherkin, gitignore, glsl, gobstones, golang, groovy, haml, handlebars, haskell, haskell_cabal, haxe, hjson, html, html_elixir, html_ruby, ini, io, jack, jade, java, javascript, json, jsoniq, jsp, jsx, julia, kotlin, latex, lean, less, liquid, lisp, live_script, livescript, logiql, lsl, lua, luapage, lucene, makefile, markdown, mask, matlab, mavens_mate_log, maze, mel, mips_assembler, mipsassembler, mushcode, mysql, nix, nsis, objectivec, ocaml, pascal, perl, pgsql, php, plain_text, powershell, praat, prolog, properties, protobuf, python, r, razor, rdoc, rhtml, rst, ruby, rust, sass, scad, scala, scheme, scss, sh, sjs, smarty, snippets, soy_template, space, sql, sqlserver, stylus, svg, swift, swig, tcl, tex, text, textile, toml, tsx, twig, typescript, vala, vbscript, velocity, verilog, vhdl, wollok, xml, xquery, yaml
					/// 
					/// Default value is <code>javascript</code>.
					/// </summary>
					/// <returns>Value of property <code>type</code></returns>
					public extern virtual string getType();

					/// <summary>
					/// Sets the type of the code editors value used for syntax highlighting
					/// </summary>
					/// <param name="sType">javascript (default), html, xml, css</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor setType(string sType);

					#endregion

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// The width of the code editor
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// The width of the code editor
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// The height of the code editor. A minimal height of 3rem will be applied in case the height is less than 20px.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// The height of the code editor. A minimal height of 3rem will be applied in case the height is less than 20px.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>100%</code>.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property editable

					/// <summary>
					/// Gets current value of property {@link #getEditable editable}.
					/// 
					/// Sets whether the code in the editor can be changed by the user
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>editable</code></returns>
					public extern virtual bool getEditable();

					/// <summary>
					/// Sets whether the code editor is editable or not
					/// </summary>
					/// <param name="bValue">true to allow editing, otherwise false</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor setEditable(bool bValue);

					#endregion

					#region Methods for Property lineNumbers

					/// <summary>
					/// Gets current value of property {@link #getLineNumbers lineNumbers}.
					/// 
					/// Sets whether line numbers should be shown
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>lineNumbers</code></returns>
					public extern virtual bool getLineNumbers();

					/// <summary>
					/// Sets whether line numbers should be shown or not
					/// </summary>
					/// <param name="bValue">true to show line numbers</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor setLineNumbers(bool bValue);

					#endregion

					#region Methods for Property valueSelection

					/// <summary>
					/// Gets current value of property {@link #getValueSelection valueSelection}.
					/// 
					/// Sets whether the code is automatically selected if a value is set
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>valueSelection</code></returns>
					public extern virtual bool getValueSelection();

					/// <summary>
					/// Sets a new value for property {@link #getValueSelection valueSelection}.
					/// 
					/// Sets whether the code is automatically selected if a value is set
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bValueSelection">New value for property <code>valueSelection</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor setValueSelection(bool bValueSelection);

					#endregion

					#region Methods for Property maxLines

					/// <summary>
					/// Gets current value of property {@link #getMaxLines maxLines}.
					/// 
					/// Sets whether the editor height should auto expand to a maximum number of lines. After reaching the maximum number of lines specified, the content of the <code>CodeEditor</code> will become scrollable.
					/// 
					/// <b>Note:</b> Keep in mind that the auto expand <code>CodeEditor</code> behavior requires the <code>height</code> property to be set to <code>auto</code>.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>maxLines</code></returns>
					public extern virtual int getMaxLines();

					/// <summary>
					/// Sets <code>maxLines</code> property.
					/// </summary>
					/// <param name="iMaxLines">Maximum number of lines the editor should display</param>
					public extern virtual void setMaxLines(int iMaxLines);

					#endregion

					#region Methods for Property colorTheme

					/// <summary>
					/// Gets current value of property {@link #getColorTheme colorTheme}.
					/// 
					/// Sets the editors color theme Possible values are: default, hcb, hcb_bright, hcb_blue, theme-ambiance, chaos, chrome, clouds, clouds_midnight, cobalt, crimson_editor, dawn, dreamweaver, eclipse, github, gob, gruvbox, idle_fingers, iplastic, katzenmilch, kr_theme, kuroir, merbivore, merbivore_soft, mono_industrial, monokai, pastel_on_dark, solarized_dark, solarized_light, sqlserver, terminal, textmate, tomorrow, tomorrow_night, tomorrow_night_blue, tomorrow_night_bright, tomorrow_night_eighties, twilight, vibrant_ink, xcode
					/// 
					/// Default value is <code>default</code>.
					/// </summary>
					/// <returns>Value of property <code>colorTheme</code></returns>
					public extern virtual string getColorTheme();

					/// <summary>
					/// Sets the color theme of the code editor
					/// </summary>
					/// <param name="sTheme">See property documentation for accepted values</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor setColorTheme(string sTheme);

					#endregion

					#region Methods for Property syntaxHints

					/// <summary>
					/// Gets current value of property {@link #getSyntaxHints syntaxHints}.
					/// 
					/// Sets whether to show syntax hints the editor. This flag is only available if line numbers are shown.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>syntaxHints</code></returns>
					public extern virtual bool getSyntaxHints();

					/// <summary>
					/// Sets whether syntax hints should be shown or not Hints are only visible if <code>lineNumbers</code> is set to true.
					/// </summary>
					/// <param name="bShow">true(default) to show the syntax hints</param>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor setSyntaxHints(bool bShow);

					#endregion

					#region Methods for Event liveChange

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.codeeditor.CodeEditor</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.codeeditor.CodeEditor</code> itself.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.codeeditor.CodeEditor</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor attachLiveChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.codeeditor.CodeEditor</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.codeeditor.CodeEditor</code> itself.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor attachLiveChange(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.codeeditor.CodeEditor</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.codeeditor.CodeEditor</code> itself.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor attachLiveChange(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:liveChange liveChange} event of this <code>sap.ui.codeeditor.CodeEditor</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.codeeditor.CodeEditor</code> itself.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.codeeditor.CodeEditor</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor attachLiveChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:liveChange liveChange} event of this <code>sap.ui.codeeditor.CodeEditor</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor detachLiveChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:liveChange liveChange} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor fireLiveChange(object mParameters);

					/// <summary>
					/// Fires event {@link #event:liveChange liveChange} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor fireLiveChange();

					#endregion

					#region Methods for Event change

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.codeeditor.CodeEditor</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.codeeditor.CodeEditor</code> itself.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.codeeditor.CodeEditor</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor attachChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.codeeditor.CodeEditor</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.codeeditor.CodeEditor</code> itself.
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor attachChange(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.codeeditor.CodeEditor</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.codeeditor.CodeEditor</code> itself.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor attachChange(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:change change} event of this <code>sap.ui.codeeditor.CodeEditor</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.codeeditor.CodeEditor</code> itself.
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.codeeditor.CodeEditor</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor attachChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:change change} event of this <code>sap.ui.codeeditor.CodeEditor</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor detachChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor fireChange(object mParameters);

					/// <summary>
					/// Fires event {@link #event:change change} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor fireChange();

					#endregion

					#region Other methods

					/// <summary>
					/// Returns the internal ace editor instance
					/// </summary>
					/// <returns>the internal ace editor instance</returns>
					private extern object _getEditorInstance();

					/// <summary>
					/// Defines custom completer - object implementing a getCompletions method. The method has two parameters - fnCallback method and context object. Context object provides details about oPos and sPrefix as provided by ACE.
					/// </summary>
					/// <param name="oCustomCompleter">Object with getCompletions method</param>
					public extern virtual void addCustomCompleter(object oCustomCompleter);

					/// <summary>
					/// Creates a new subclass of class sap.ui.codeeditor.CodeEditor with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.codeeditor.CodeEditor with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.codeeditor.CodeEditor with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Sets the focus to the code editor
					/// </summary>
					/// <returns>Returns <code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.codeeditor.CodeEditor focus();

					/// <summary>
					/// Returns the current value of the code editor
					/// </summary>
					/// <returns>Returns the current value of the code editor</returns>
					public extern virtual string getCurrentValue();

					/// <summary>
					/// Returns a metadata object for class sap.ui.codeeditor.CodeEditor.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Pretty-prints the content of the editor
					/// </summary>
					public extern virtual void prettyPrint();

					/// <summary>
					/// Sets <code>visible</code> property.
					/// </summary>
					/// <param name="bVisible">Whether the code editor is visible.</param>
					public extern virtual void setVisible(bool bVisible);

					#endregion

					#endregion

				}
			}
		}
	}
}
