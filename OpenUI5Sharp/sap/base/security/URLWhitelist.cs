using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class @base
		{
			public static partial class security
			{
				/// <summary>
				/// Registry to add whitelisted URLs and validate against them.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.base.security.URLWhitelist")]
				public partial class URLWhitelist
				{
					#region Methods

					/// <summary>
					/// Adds a whitelist entry
					/// </summary>
					/// <param name="protocol">The protocol of the URL</param>
					/// <param name="host">The host of the URL</param>
					/// <param name="port">The port of the URL</param>
					/// <param name="path">the path of the URL</param>
					public extern static void add(string protocol, string host, string port, string path);

					/// <summary>
					/// Clears the whitelist for URL validation
					/// </summary>
					public extern static void clear();

					/// <summary>
					/// Deletes an entry from the whitelist entry
					/// </summary>
					/// <param name="oEntry">The entry to be deleted</param>
					public extern static void delete(sap.@base.security.URLWhitelist.Entry oEntry);

					/// <summary>
					/// Gets an array with the whitelist entries
					/// </summary>
					/// <returns>An array with whitelist entries</returns>
					public extern static sap.@base.security.URLWhitelist.Entry[] entries();

					/// <summary>
					/// Validates a URL. Check if it's not a script or other security issue.
					/// 
					/// Split URL into components and check for allowed characters according to RFC 3986:
					/// 
					/// <pre>
					/// authority     = [ userinfo "@" ] host [ ":" port ]
					/// userinfo      = *( unreserved / pct-encoded / sub-delims / ":" )
					/// host          = IP-literal / IPv4address / reg-name
					/// 
					/// IP-literal    = "[" ( IPv6address / IPvFuture  ) "]"
					/// IPvFuture     = "v" 1*HEXDIG "." 1*( unreserved / sub-delims / ":" )
					/// IPv6address   =                            6( h16 ":" ) ls32
					///               /                       "::" 5( h16 ":" ) ls32
					///               / [               h16 ] "::" 4( h16 ":" ) ls32
					///               / [ *1( h16 ":" ) h16 ] "::" 3( h16 ":" ) ls32
					///               / [ *2( h16 ":" ) h16 ] "::" 2( h16 ":" ) ls32
					///               / [ *3( h16 ":" ) h16 ] "::"    h16 ":"   ls32
					///               / [ *4( h16 ":" ) h16 ] "::"              ls32
					///               / [ *5( h16 ":" ) h16 ] "::"              h16
					///               / [ *6( h16 ":" ) h16 ] "::"
					/// ls32          = ( h16 ":" h16 ) / IPv4address
					///               ; least-significant 32 bits of address
					/// h16           = 1*4HEXDIG
					///               ; 16 bits of address represented in hexadecimal
					/// 
					/// IPv4address   = dec-octet "." dec-octet "." dec-octet "." dec-octet
					/// dec-octet     = DIGIT                 ; 0-9
					///               / %x31-39 DIGIT         ; 10-99
					///               / "1" 2DIGIT            ; 100-199
					///               / "2" %x30-34 DIGIT     ; 200-249
					///               / "25" %x30-35          ; 250-255
					/// 
					/// reg-name      = *( unreserved / pct-encoded / sub-delims )
					/// 
					/// pct-encoded   = "%" HEXDIG HEXDIG
					/// reserved      = gen-delims / sub-delims
					/// gen-delims    = ":" / "/" / "?" / "#" / "[" / "]" / "@"
					/// sub-delims    = "!" / "$" / "&" / "'" / "(" / ")"
					///               / "*" / "+" / "," / ";" / "="
					/// unreserved    = ALPHA / DIGIT / "-" / "." / "_" / "~"
					/// pchar         = unreserved / pct-encoded / sub-delims / ":" / "@"
					/// 
					/// path          = path-abempty    ; begins with "/" or is empty
					///               / path-absolute   ; begins with "/" but not "//"
					///               / path-noscheme   ; begins with a non-colon segment
					///               / path-rootless   ; begins with a segment
					///               / path-empty      ; zero characters
					/// 
					/// path-abempty  = *( "/" segment )
					/// path-absolute = "/" [ segment-nz *( "/" segment ) ]
					/// path-noscheme = segment-nz-nc *( "/" segment )
					/// path-rootless = segment-nz *( "/" segment )
					/// path-empty    = 0<pchar>
					/// segment       = *pchar
					/// segment-nz    = 1*pchar
					/// segment-nz-nc = 1*( unreserved / pct-encoded / sub-delims / "@" )
					///               ; non-zero-length segment without any colon ":"
					/// 
					/// query         = *( pchar / "/" / "?" )
					/// 
					/// fragment      = *( pchar / "/" / "?" )
					/// </pre>
					/// 
					/// For the hostname component, we are checking for valid DNS hostnames according to RFC 952 / RFC 1123:
					/// 
					/// <pre>
					/// hname         = name *("." name)
					/// name          = let-or-digit ( *( let-or-digit-or-hyphen ) let-or-digit )
					/// </pre>
					/// 
					/// When the URI uses the protocol 'mailto:', the address part is additionally checked against the most commonly used parts of RFC 6068:
					/// 
					/// <pre>
					/// mailtoURI     = "mailto:" [ to ] [ hfields ]
					/// to            = addr-spec *("," addr-spec )
					/// hfields       = "?" hfield *( "&" hfield )
					/// hfield        = hfname "=" hfvalue
					/// hfname        = *qchar
					/// hfvalue       = *qchar
					/// addr-spec     = local-part "@" domain
					/// local-part    = dot-atom-text              // not accepted: quoted-string
					/// domain        = dot-atom-text              // not accepted: "[" *dtext-no-obs "]"
					/// dtext-no-obs  = %d33-90 / ; Printable US-ASCII
					///                 %d94-126  ; characters not including
					///                           ; "[", "]", or "\"
					/// qchar         = unreserved / pct-encoded / some-delims
					/// some-delims   = "!" / "$" / "'" / "(" / ")" / "*"
					///               / "+" / "," / ";" / ":" / "@"
					/// 
					/// Note:
					/// A number of characters that can appear in &lt;addr-spec> MUST be
					/// percent-encoded.  These are the characters that cannot appear in
					/// a URI according to [STD66] as well as "%" (because it is used for
					/// percent-encoding) and all the characters in gen-delims except "@"
					/// and ":" (i.e., "/", "?", "#", "[", and "]").  Of the characters
					/// in sub-delims, at least the following also have to be percent-
					/// encoded: "&", ";", and "=".  Care has to be taken both when
					/// encoding as well as when decoding to make sure these operations
					/// are applied only once.
					/// 
					/// </pre>
					/// 
					/// When a whitelist has been configured using {@link #.addUrlWhitelist addUrlWhitelist}, any URL that passes the syntactic checks above, additionally will be tested against the content of the whitelist.
					/// </summary>
					/// <param name="sUrl">URL to be validated</param>
					/// <returns>true if valid, false if not valid</returns>
					public extern static bool validate(string sUrl);

					#endregion

				}
			}
		}
	}
}
