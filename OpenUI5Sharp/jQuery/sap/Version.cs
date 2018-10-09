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
			/// Represents a version consisting of major, minor, patch version and suffix, e.g. '1.2.7-SNAPSHOT'.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("jQuery.sap.Version")]
			public partial class Version
			{
				#region Constructor

				/// <summary>
				/// Returns a Version instance created from the given parameters.
				/// 
				/// This function can either be called as a constructor (using <code>new</code>) or as a normal function. It always returns an immutable Version instance.
				/// 
				/// The parts of the version number (major, minor, patch, suffix) can be provided in several ways: <ul> <li>Version("1.2.3-SNAPSHOT") - as a dot-separated string. Any non-numerical char or a dot followed by a non-numerical char starts the suffix portion. Any missing major, minor or patch versions will be set to 0.</li> <li>Version(1,2,3,"-SNAPSHOT") - as individual parameters. Major, minor and patch must be integer numbers or empty, suffix must be a string not starting with digits.</li> <li>Version([1,2,3,"-SNAPSHOT"]) - as an array with the individual parts. The same type restrictions apply as before.</li> <li>Version(otherVersion) - as a Version instance (cast operation). Returns the given instance instead of creating a new one.</li> </ul>
				/// 
				/// To keep the code size small, this implementation mainly validates the single string variant. All other variants are only validated to some degree. It is the responsibility of the caller to provide proper parts.
				/// </summary>
				/// <param name="vMajor">the major part of the version (int) or any of the single parameter variants explained above.</param>
				/// <param name="iMinor">the minor part of the version number</param>
				/// <param name="iPatch">the patch part of the version number</param>
				/// <param name="sSuffix">the suffix part of the version number</param>
				public extern Version(Union<int, string, object[], jQuery.sap.Version> vMajor, int iMinor, int iPatch, string sSuffix);

				#endregion

				#region Methods

				/// <summary>
				/// Compares this version with a given one.
				/// 
				/// The version with which this version should be compared can be given as a <code>sap.base.Version</code> instance, as a string (e.g. <code>v.compareto("1.4.5")</code>). Or major, minor, patch and suffix values can be given as separate parameters (e.g. <code>v.compareTo(1, 4, 5)</code>) or in an array (e.g. <code>v.compareTo([1, 4, 5])</code>).
				/// </summary>
				/// <returns>0, if the given version is equal to this version, a negative value if the given other version is greater and a positive value otherwise</returns>
				public extern virtual int compareTo();

				/// <summary>
				/// Returns the major version part of this version.
				/// </summary>
				/// <returns>the major version part of this version</returns>
				public extern virtual int getMajor();

				/// <summary>
				/// Returns the minor version part of this version.
				/// </summary>
				/// <returns>the minor version part of this version</returns>
				public extern virtual int getMinor();

				/// <summary>
				/// Returns the patch (or micro) version part of this version.
				/// </summary>
				/// <returns>the patch version part of this version</returns>
				public extern virtual int getPatch();

				/// <summary>
				/// Returns the version suffix of this version.
				/// </summary>
				/// <returns>the version suffix of this version</returns>
				public extern virtual string getSuffix();

				/// <summary>
				/// Checks whether this version is in the range of the given interval (start inclusive, end exclusive).
				/// 
				/// The boundaries against which this version should be checked can be given as <code>jQuery.sap.Version</code> instances (e.g. <code>v.inRange(v1, v2)</code>), as strings (e.g. <code>v.inRange("1.4", "2.7")</code>) or as arrays (e.g. <code>v.inRange([1,4], [2,7])</code>).
				/// </summary>
				/// <param name="vMin">the start of the range (inclusive)</param>
				/// <param name="vMax">the end of the range (exclusive)</param>
				/// <returns><code>true</code> if this version is greater or equal to <code>vMin</code> and smaller than <code>vMax</code>, <code>false</code> otherwise.</returns>
				public extern virtual bool inRange(Union<string, object[], jQuery.sap.Version> vMin, Union<string, object[], jQuery.sap.Version> vMax);

				/// <summary>
				/// Returns a string representation of this version.
				/// </summary>
				/// <returns>a string representation of this version.</returns>
				public extern virtual string toString();

				#endregion

			}
		}
	}
}
