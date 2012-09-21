// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.School
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AUSchoolFocusCodeType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AUSchoolFocusCodeType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class AUSchoolFocusCodeType : SifEnum
	{
	/// <summary>Alternate ("03")</summary>
	public static readonly AUSchoolFocusCodeType C03_ALTERNATE = new AUSchoolFocusCodeType("03");

	/// <summary>Not Provided ("99")</summary>
	public static readonly AUSchoolFocusCodeType C99_NOT_PROVIDED = new AUSchoolFocusCodeType("99");

	/// <summary>Regular ("01")</summary>
	public static readonly AUSchoolFocusCodeType C01_REGULAR = new AUSchoolFocusCodeType("01");

	/// <summary>Vocational ("04")</summary>
	public static readonly AUSchoolFocusCodeType C04_VOCATIONAL = new AUSchoolFocusCodeType("04");

	/// <summary>Special Ed ("02")</summary>
	public static readonly AUSchoolFocusCodeType C02_SPECIAL_ED = new AUSchoolFocusCodeType("02");

	/// <summary>Other ("98")</summary>
	public static readonly AUSchoolFocusCodeType C98_OTHER = new AUSchoolFocusCodeType("98");

	///<summary>Wrap an arbitrary string value in an AUSchoolFocusCodeType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AUSchoolFocusCodeType Wrap( String wrappedValue ) {
		return new AUSchoolFocusCodeType( wrappedValue );
	}

	private AUSchoolFocusCodeType( string enumDefValue ) : base( enumDefValue ) {}
	}
}