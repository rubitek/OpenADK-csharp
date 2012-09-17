// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Programs
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AUCodeSets0211ProgramAvailabilityType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AUCodeSets0211ProgramAvailabilityType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	[Serializable]
	public class AUCodeSets0211ProgramAvailabilityType : SifEnum
	{
	/// <summary>Other ("9999")</summary>
	public static readonly AUCodeSets0211ProgramAvailabilityType C9999_OTHER = new AUCodeSets0211ProgramAvailabilityType("9999");

	/// <summary>Before school ("0235")</summary>
	public static readonly AUCodeSets0211ProgramAvailabilityType C0235_BEFORE_SCHOOL = new AUCodeSets0211ProgramAvailabilityType("0235");

	/// <summary>Summer Holidays ("0237")</summary>
	public static readonly AUCodeSets0211ProgramAvailabilityType C0237_SUMMER_HOLIDAYS = new AUCodeSets0211ProgramAvailabilityType("0237");

	/// <summary>During school ("0231")</summary>
	public static readonly AUCodeSets0211ProgramAvailabilityType C0231_DURING_SCHOOL = new AUCodeSets0211ProgramAvailabilityType("0231");

	/// <summary>Weekend ("0234")</summary>
	public static readonly AUCodeSets0211ProgramAvailabilityType C0234_WEEKEND = new AUCodeSets0211ProgramAvailabilityType("0234");

	/// <summary>In-school service day ("0238")</summary>
	public static readonly AUCodeSets0211ProgramAvailabilityType C0238_IN_SCHOOL = new AUCodeSets0211ProgramAvailabilityType("0238");

	/// <summary>Other School Holidays ("9998")</summary>
	public static readonly AUCodeSets0211ProgramAvailabilityType C9998_OTHER_SCHOOL_HOLIDAYS = new AUCodeSets0211ProgramAvailabilityType("9998");

	/// <summary>After school ("0236")</summary>
	public static readonly AUCodeSets0211ProgramAvailabilityType C0236_AFTER_SCHOOL = new AUCodeSets0211ProgramAvailabilityType("0236");

	/// <summary>Evenings ("0239")</summary>
	public static readonly AUCodeSets0211ProgramAvailabilityType C0239_EVENINGS = new AUCodeSets0211ProgramAvailabilityType("0239");

	///<summary>Wrap an arbitrary string value in an AUCodeSets0211ProgramAvailabilityType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AUCodeSets0211ProgramAvailabilityType Wrap( String wrappedValue ) {
		return new AUCodeSets0211ProgramAvailabilityType( wrappedValue );
	}

	private AUCodeSets0211ProgramAvailabilityType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
