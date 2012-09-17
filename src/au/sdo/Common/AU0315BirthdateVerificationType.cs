// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AU0315BirthdateVerificationType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AU0315BirthdateVerificationType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class AU0315BirthdateVerificationType : SifEnum
	{
	/// <summary>Other ("9999")</summary>
	public static readonly AU0315BirthdateVerificationType C9999_OTHER = new AU0315BirthdateVerificationType("9999");

	/// <summary>Physician's certificate ("1009")</summary>
	public static readonly AU0315BirthdateVerificationType C1009_PHYSICIANS_CERTIFICATE = new AU0315BirthdateVerificationType("1009");

	/// <summary>State-issued ID ("1011")</summary>
	public static readonly AU0315BirthdateVerificationType C1011_STATEISSUED_ID = new AU0315BirthdateVerificationType("1011");

	/// <summary>Previously verified school records ("1010")</summary>
	public static readonly AU0315BirthdateVerificationType C1010_PREVIOUSLY_VERIFIED_SCHOOL = new AU0315BirthdateVerificationType("1010");

	/// <summary>Birthdate NOT Verified ("N")</summary>
	public static readonly AU0315BirthdateVerificationType N_BIRTHDATE_NOT_VERIFIED = new AU0315BirthdateVerificationType("N");

	/// <summary>Immigration document/visa ("1013")</summary>
	public static readonly AU0315BirthdateVerificationType C1013_IMMIGRATION_DOCUMENT = new AU0315BirthdateVerificationType("1013");

	/// <summary>Driver's license ("1012")</summary>
	public static readonly AU0315BirthdateVerificationType C1012_DRIVERS_LICENSE = new AU0315BirthdateVerificationType("1012");

	/// <summary>Hospital certificate ("1006")</summary>
	public static readonly AU0315BirthdateVerificationType C1006_HOSPITAL_CERTIFICATE = new AU0315BirthdateVerificationType("1006");

	/// <summary>Birth certificate ("1004")</summary>
	public static readonly AU0315BirthdateVerificationType C1004_BIRTH_CERTIFICATE = new AU0315BirthdateVerificationType("1004");

	/// <summary>Passport ("1008")</summary>
	public static readonly AU0315BirthdateVerificationType C1008_PASSPORT = new AU0315BirthdateVerificationType("1008");

	/// <summary>Documentation Sighted, type not recorded ("Y")</summary>
	public static readonly AU0315BirthdateVerificationType Y_DOCUMENTATION_SIGHTED_TYPE_NOT = new AU0315BirthdateVerificationType("Y");

	/// <summary>Other non-official document ("3424")</summary>
	public static readonly AU0315BirthdateVerificationType C3424_OT_NONOFFICIAL_DOCUMENT = new AU0315BirthdateVerificationType("3424");

	/// <summary>Other official document ("3423")</summary>
	public static readonly AU0315BirthdateVerificationType C3423_OT_OFFICIAL_DOCUMENT = new AU0315BirthdateVerificationType("3423");

	///<summary>Wrap an arbitrary string value in an AU0315BirthdateVerificationType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AU0315BirthdateVerificationType Wrap( String wrappedValue ) {
		return new AU0315BirthdateVerificationType( wrappedValue );
	}

	private AU0315BirthdateVerificationType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
