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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Student{

/// <summary>This object defines information related to a school calendar day in a given school calendar year. If both CalendarDate and CalendarSummary objects are supported, there must be an instance of this object for each date between CalendarSummary StartDate and EndDate, inclusive.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class CalendarDate : SifDataObject
{
	/// <summary>
	/// Creates an instance of a CalendarDate
	/// </summary>
	public CalendarDate() : base( Adk.SifVersion, StudentDTD.CALENDARDATE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="date">A specific school day that occurs within the school year.</param>
	///<param name="calendarSummaryRefId">The ID (GUID) of the calendar summary in which this calendar date is.</param>
	///<param name="schoolInfoRefId">The ID (GUID) of the school for which this calendar information is being reported.</param>
	///<param name="schoolYear">School year for which the information is applicable, expressed as the four-digit year in which the school year ends (e.g., "2007" for the 2006-07 school year).</param>
	///<param name="calendarDateType">A CalendarDateType</param>
	///
	public CalendarDate( DateTime? date, string calendarSummaryRefId, string schoolInfoRefId, int? schoolYear, CalendarDateType calendarDateType ) : base( Adk.SifVersion, StudentDTD.CALENDARDATE )
	{
		this.Date = date;
		this.CalendarSummaryRefId = calendarSummaryRefId;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.SchoolYear = schoolYear;
		this.CalendarDateType = calendarDateType;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected CalendarDate( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.CALENDARDATE_DATE, StudentDTD.CALENDARDATE_CALENDARSUMMARYREFID, StudentDTD.CALENDARDATE_SCHOOLINFOREFID, StudentDTD.CALENDARDATE_SCHOOLYEAR }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Date</c> attribute.
	/// </summary>
	/// <value> The <c>Date</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "A specific school day that occurs within the school year."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? Date
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( StudentDTD.CALENDARDATE_DATE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.CALENDARDATE_DATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>CalendarSummaryRefId</c> attribute.
	/// </summary>
	/// <value> The <c>CalendarSummaryRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) of the calendar summary in which this calendar date is."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string CalendarSummaryRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.CALENDARDATE_CALENDARSUMMARYREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.CALENDARDATE_CALENDARSUMMARYREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) of the school for which this calendar information is being reported."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.CALENDARDATE_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.CALENDARDATE_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolYear</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolYear</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "School year for which the information is applicable, expressed as the four-digit year in which the school year ends (e.g., "2007" for the 2006-07 school year)."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? SchoolYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.CALENDARDATE_SCHOOLYEAR ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.CALENDARDATE_SCHOOLYEAR, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CalendarDateType&gt;</c> element.
	/// </summary>
	/// <value> A CalendarDateType </value>
	/// <remarks>
	/// <para>To remove the <c>CalendarDateType</c>, set <c>CalendarDateType</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public CalendarDateType CalendarDateType
	{
		get
		{
			return (CalendarDateType)GetChild( StudentDTD.CALENDARDATE_CALENDARDATETYPE);
		}
		set
		{
			RemoveChild( StudentDTD.CALENDARDATE_CALENDARDATETYPE);
			if( value != null)
			{
				AddChild( StudentDTD.CALENDARDATE_CALENDARDATETYPE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CalendarDateNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>CalendarDateNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? CalendarDateNumber
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.CALENDARDATE_CALENDARDATENUMBER ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.CALENDARDATE_CALENDARDATENUMBER, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentAttendance&gt;</c> element.
	/// </summary>
	/// <value> A StudentAttendance </value>
	/// <remarks>
	/// <para>To remove the <c>StudentAttendance</c>, set <c>StudentAttendance</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public StudentAttendance StudentAttendance
	{
		get
		{
			return (StudentAttendance)GetChild( StudentDTD.CALENDARDATE_STUDENTATTENDANCE);
		}
		set
		{
			RemoveChild( StudentDTD.CALENDARDATE_STUDENTATTENDANCE);
			if( value != null)
			{
				AddChild( StudentDTD.CALENDARDATE_STUDENTATTENDANCE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TeacherAttendance&gt;</c> element.
	/// </summary>
	/// <value> A TeacherAttendance </value>
	/// <remarks>
	/// <para>To remove the <c>TeacherAttendance</c>, set <c>TeacherAttendance</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public TeacherAttendance TeacherAttendance
	{
		get
		{
			return (TeacherAttendance)GetChild( StudentDTD.CALENDARDATE_TEACHERATTENDANCE);
		}
		set
		{
			RemoveChild( StudentDTD.CALENDARDATE_TEACHERATTENDANCE);
			if( value != null)
			{
				AddChild( StudentDTD.CALENDARDATE_TEACHERATTENDANCE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AdministratorAttendance&gt;</c> element.
	/// </summary>
	/// <value> An AdministratorAttendance </value>
	/// <remarks>
	/// <para>To remove the <c>AdministratorAttendance</c>, set <c>AdministratorAttendance</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public AdministratorAttendance AdministratorAttendance
	{
		get
		{
			return (AdministratorAttendance)GetChild( StudentDTD.CALENDARDATE_ADMINISTRATORATTENDANCE);
		}
		set
		{
			RemoveChild( StudentDTD.CALENDARDATE_ADMINISTRATORATTENDANCE);
			if( value != null)
			{
				AddChild( StudentDTD.CALENDARDATE_ADMINISTRATORATTENDANCE, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;BellScheduleDayList&gt;</c> element.</summary>
	/// <param name="BellScheduleDay">A BellScheduleDay</param>
	///<remarks>
	/// <para>This form of <c>setBellScheduleDayList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>BellScheduleDayList</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetBellScheduleDayList( BellScheduleDay BellScheduleDay ) {
		RemoveChild( StudentDTD.CALENDARDATE_BELLSCHEDULEDAYLIST);
		AddChild( StudentDTD.CALENDARDATE_BELLSCHEDULEDAYLIST, new BellScheduleDayList( BellScheduleDay ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;BellScheduleDayList&gt;</c> element.
	/// </summary>
	/// <value> A BellScheduleDayList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "A list of the bell schedules and the timetable day from that bell schedule to be used for the calendar date"</para>
	/// <para>To remove the <c>BellScheduleDayList</c>, set <c>BellScheduleDayList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public BellScheduleDayList BellScheduleDayList
	{
		get
		{
			return (BellScheduleDayList)GetChild( StudentDTD.CALENDARDATE_BELLSCHEDULEDAYLIST);
		}
		set
		{
			RemoveChild( StudentDTD.CALENDARDATE_BELLSCHEDULEDAYLIST);
			if( value != null)
			{
				AddChild( StudentDTD.CALENDARDATE_BELLSCHEDULEDAYLIST, value );
			}
		}
	}

}}