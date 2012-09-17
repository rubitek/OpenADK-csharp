// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Hrfin
{
	///<summary>
	/// Defines the set of values that can be specified whenever a LocationInfoType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a LocationInfoType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class LocationInfoType : SifEnum
	{
	/// <summary>School ("School")</summary>
	public static readonly LocationInfoType SCHOOL = new LocationInfoType("School");

	/// <summary>NonSchool ("NonSchool")</summary>
	public static readonly LocationInfoType NONSCHOOL = new LocationInfoType("NonSchool");

	///<summary>Wrap an arbitrary string value in a LocationInfoType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static LocationInfoType Wrap( String wrappedValue ) {
		return new LocationInfoType( wrappedValue );
	}

	private LocationInfoType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
