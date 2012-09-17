// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Gradebook
{
	///<summary>
	/// Defines the set of values that can be specified whenever a StudentPeriodAttendanceAttendanceStatusType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a StudentPeriodAttendanceAttendanceStatusType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class StudentPeriodAttendanceAttendanceStatusType : SifEnum
	{
	/// <summary>Not Applicable ("NA")</summary>
	public static readonly StudentPeriodAttendanceAttendanceStatusType NA_NOT_APPLICABLE = new StudentPeriodAttendanceAttendanceStatusType("NA");

	/// <summary>Unexcused ("02")</summary>
	public static readonly StudentPeriodAttendanceAttendanceStatusType C02_UNEXCUSED = new StudentPeriodAttendanceAttendanceStatusType("02");

	/// <summary>Excused ("01")</summary>
	public static readonly StudentPeriodAttendanceAttendanceStatusType C01_EXCUSED = new StudentPeriodAttendanceAttendanceStatusType("01");

	/// <summary>Unknown ("99")</summary>
	public static readonly StudentPeriodAttendanceAttendanceStatusType C99_UNKNOWN = new StudentPeriodAttendanceAttendanceStatusType("99");

	///<summary>Wrap an arbitrary string value in a StudentPeriodAttendanceAttendanceStatusType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static StudentPeriodAttendanceAttendanceStatusType Wrap( String wrappedValue ) {
		return new StudentPeriodAttendanceAttendanceStatusType( wrappedValue );
	}

	private StudentPeriodAttendanceAttendanceStatusType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
