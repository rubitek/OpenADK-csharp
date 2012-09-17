// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Student{

/// <summary>An AttendanceCodeInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class AttendanceCodeInfo : SifDataObject
{
	/// <summary>
	/// Creates an instance of an AttendanceCodeInfo
	/// </summary>
	public AttendanceCodeInfo() : base( Adk.SifVersion, StudentDTD.ATTENDANCECODEINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The ID (GUID) that uniquely identifies this AttendanceCodeInfo entity.</param>
	///<param name="schoolInfoRefId">The ID (GUID) that identifies the school where the attendance code is used.</param>
	///<param name="attendanceCode">Locally defined code for attendance.</param>
	///<param name="attendanceType">Type of attendance code.</param>
	///<param name="attendanceStatus">Excused status of the attendance code.</param>
	///<param name="usedForDailyAttendance">Is this attendance code used for daily attendance?</param>
	///<param name="usedForPeriodAttendance">Is this attendance code used for period attendance?</param>
	///
	public AttendanceCodeInfo( string refId, string schoolInfoRefId, string attendanceCode, AttendanceType attendanceType, AttendanceStatusType attendanceStatus, AUCodeSetsYesOrNoCategoryType usedForDailyAttendance, AUCodeSetsYesOrNoCategoryType usedForPeriodAttendance ) : base( Adk.SifVersion, StudentDTD.ATTENDANCECODEINFO )
	{
		this.RefId = refId;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.AttendanceCode = attendanceCode;
		this.SetAttendanceType( attendanceType );
		this.SetAttendanceStatus( attendanceStatus );
		this.SetUsedForDailyAttendance( usedForDailyAttendance );
		this.SetUsedForPeriodAttendance( usedForPeriodAttendance );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AttendanceCodeInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.ATTENDANCECODEINFO_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies this AttendanceCodeInfo entity."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.ATTENDANCECODEINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ATTENDANCECODEINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that identifies the school where the attendance code is used."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.ATTENDANCECODEINFO_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ATTENDANCECODEINFO_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AttendanceCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>AttendanceCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Locally defined code for attendance."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string AttendanceCode
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.ATTENDANCECODEINFO_ATTENDANCECODE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ATTENDANCECODEINFO_ATTENDANCECODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AttendanceType&gt;</c> element.
	/// </summary>
	/// <value> The <c>AttendanceType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Type of attendance code."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string AttendanceType
	{
		get
		{ 
			return GetFieldValue( StudentDTD.ATTENDANCECODEINFO_ATTENDANCETYPE );
		}
		set
		{
			SetField( StudentDTD.ATTENDANCECODEINFO_ATTENDANCETYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AttendanceType&gt;</c> element.
	/// </summary>
	/// <param name="val">A AttendanceType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Type of attendance code."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetAttendanceType( AttendanceType val )
	{
		SetField( StudentDTD.ATTENDANCECODEINFO_ATTENDANCETYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AttendanceStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>AttendanceStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Excused status of the attendance code."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string AttendanceStatus
	{
		get
		{ 
			return GetFieldValue( StudentDTD.ATTENDANCECODEINFO_ATTENDANCESTATUS );
		}
		set
		{
			SetField( StudentDTD.ATTENDANCECODEINFO_ATTENDANCESTATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AttendanceStatus&gt;</c> element.
	/// </summary>
	/// <param name="val">A AttendanceStatusType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Excused status of the attendance code."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetAttendanceStatus( AttendanceStatusType val )
	{
		SetField( StudentDTD.ATTENDANCECODEINFO_ATTENDANCESTATUS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The text description of the attendance code."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.ATTENDANCECODEINFO_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ATTENDANCECODEINFO_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AbsenceValue&gt;</c> element.
	/// </summary>
	/// <value> The <c>AbsenceValue</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public decimal? AbsenceValue
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( StudentDTD.ATTENDANCECODEINFO_ABSENCEVALUE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ATTENDANCECODEINFO_ABSENCEVALUE, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;UsedForDailyAttendance&gt;</c> element.
	/// </summary>
	/// <value> The <c>UsedForDailyAttendance</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is this attendance code used for daily attendance?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string UsedForDailyAttendance
	{
		get
		{ 
			return GetFieldValue( StudentDTD.ATTENDANCECODEINFO_USEDFORDAILYATTENDANCE );
		}
		set
		{
			SetField( StudentDTD.ATTENDANCECODEINFO_USEDFORDAILYATTENDANCE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;UsedForDailyAttendance&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is this attendance code used for daily attendance?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetUsedForDailyAttendance( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.ATTENDANCECODEINFO_USEDFORDAILYATTENDANCE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;UsedForPeriodAttendance&gt;</c> element.
	/// </summary>
	/// <value> The <c>UsedForPeriodAttendance</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is this attendance code used for period attendance?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string UsedForPeriodAttendance
	{
		get
		{ 
			return GetFieldValue( StudentDTD.ATTENDANCECODEINFO_USEDFORPERIODATTENDANCE );
		}
		set
		{
			SetField( StudentDTD.ATTENDANCECODEINFO_USEDFORPERIODATTENDANCE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;UsedForPeriodAttendance&gt;</c> element.
	/// </summary>
	/// <param name="val">A AUCodeSetsYesOrNoCategoryType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Is this attendance code used for period attendance?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetUsedForPeriodAttendance( AUCodeSetsYesOrNoCategoryType val )
	{
		SetField( StudentDTD.ATTENDANCECODEINFO_USEDFORPERIODATTENDANCE, val );
	}

}}
