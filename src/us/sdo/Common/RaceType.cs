// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a RaceType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a RaceType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class RaceType : SifEnum
	{
	/// <summary>White (Non-Hispanic) ("O")</summary>
	public static readonly RaceType SIF1X_WHITE_NON_HISP = new RaceType("O");

	/// <summary>American Indian or Alaska Native ("0998")</summary>
	public static readonly RaceType AMERICAN_INDIAN = new RaceType("0998");

	/// <summary>Black (Non-Hispanic) ("N")</summary>
	public static readonly RaceType SIF1X_BLACK_NON_HISP = new RaceType("N");

	/// <summary>Asian ("0999")</summary>
	public static readonly RaceType ASIAN = new RaceType("0999");

	/// <summary>Other Race or Ethnicity ("E")</summary>
	public static readonly RaceType SIF1X_OTHER = new RaceType("E");

	/// <summary>American Indian or Alaskan Native ("I")</summary>
	public static readonly RaceType SIF1X_AMER_INDIAN_OR_ALASKAN_NATIVE = new RaceType("I");

	/// <summary>Not provided ("7")</summary>
	public static readonly RaceType SIF1X_NOT_PROVIDED = new RaceType("7");

	/// <summary>Asian or Pacific Islander ("A")</summary>
	public static readonly RaceType SIF1X_ASIAN_OR_PACISLANDER = new RaceType("A");

	/// <summary>Native Hawaiian ("J")</summary>
	public static readonly RaceType SIF1X_HAWAIIAN = new RaceType("J");

	/// <summary>Pacific Islander ("P")</summary>
	public static readonly RaceType SIF1X_PACISLANDER = new RaceType("P");

	/// <summary>Caucasian ("C")</summary>
	public static readonly RaceType SIF1X_CAUCASIAN = new RaceType("C");

	/// <summary>Asian Pacific American ("F")</summary>
	public static readonly RaceType SIF1X_ASIAN_PACISLANDER = new RaceType("F");

	/// <summary>Subcontinent Asian American ("D")</summary>
	public static readonly RaceType SIF1X_SUBCONT_ASIAN_AMER = new RaceType("D");

	/// <summary>Mutually Defined ("Z")</summary>
	public static readonly RaceType SIF1X_ZZ = new RaceType("Z");

	/// <summary>Black ("B")</summary>
	public static readonly RaceType SIF1X_BLACK = new RaceType("B");

	/// <summary>Native Hawaiian or Other Pacific Islander ("1001")</summary>
	public static readonly RaceType PACISLANDER = new RaceType("1001");

	/// <summary>Black or African American ("1000")</summary>
	public static readonly RaceType AFRICAN_AMERICAN = new RaceType("1000");

	/// <summary>Native American ("G")</summary>
	public static readonly RaceType SIF1X_NATIVE_AMER = new RaceType("G");

	/// <summary>Hispanic ("H")</summary>
	public static readonly RaceType SIF1X_HISPANIC = new RaceType("H");

	/// <summary>White ("1002")</summary>
	public static readonly RaceType WHITE = new RaceType("1002");

	///<summary>Wrap an arbitrary string value in a RaceType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static RaceType Wrap( String wrappedValue ) {
		return new RaceType( wrappedValue );
	}

	private RaceType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
