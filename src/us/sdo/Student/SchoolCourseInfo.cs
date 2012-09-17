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

/// <summary>This object is for course information. SIF_Events are reported.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SchoolCourseInfo : SifDataObject
{
	/// <summary>
	/// Creates an instance of a SchoolCourseInfo
	/// </summary>
	public SchoolCourseInfo() : base( Adk.SifVersion, StudentDTD.SCHOOLCOURSEINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The ID (GUID) that uniquely identifies the school course.</param>
	///<param name="schoolInfoRefId">The ID (GUID) that identifies the school where the course is offered.</param>
	///<param name="schoolYear">School year for which the information is applicable, expressed as the four-digit year in which the school year ends (e.g. 2007 for the 2006-07 school year).</param>
	///<param name="courseCode">School-defined local code for the course.</param>
	///<param name="courseTitle">Title of the course.</param>
	///
	public SchoolCourseInfo( string refId, string schoolInfoRefId, int? schoolYear, string courseCode, string courseTitle ) : base( Adk.SifVersion, StudentDTD.SCHOOLCOURSEINFO )
	{
		this.RefId = refId;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.SchoolYear = schoolYear;
		this.CourseCode = courseCode;
		this.CourseTitle = courseTitle;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SchoolCourseInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.SCHOOLCOURSEINFO_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies the school course."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLCOURSEINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLCOURSEINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that identifies the school where the course is offered."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLCOURSEINFO_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLCOURSEINFO_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolYear</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolYear</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "School year for which the information is applicable, expressed as the four-digit year in which the school year ends (e.g. 2007 for the 2006-07 school year)."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? SchoolYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.SCHOOLCOURSEINFO_SCHOOLYEAR ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLCOURSEINFO_SCHOOLYEAR, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CourseCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>CourseCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "School-defined local code for the course."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string CourseCode
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLCOURSEINFO_COURSECODE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLCOURSEINFO_COURSECODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateCourseCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateCourseCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "State-defined standard course code used to report information about courses."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string StateCourseCode
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLCOURSEINFO_STATECOURSECODE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLCOURSEINFO_STATECOURSECODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DistrictCourseCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>DistrictCourseCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The corresponding district course code."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string DistrictCourseCode
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLCOURSEINFO_DISTRICTCOURSECODE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLCOURSEINFO_DISTRICTCOURSECODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SubjectAreaList&gt;</c> element.
	/// </summary>
	/// <value> A SubjectAreaList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Subject matter area or department"</para>
	/// <para>To remove the <c>SubjectAreaList</c>, set <c>SubjectAreaList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public SubjectAreaList SubjectAreaList
	{
		get
		{
			return (SubjectAreaList)GetChild( StudentDTD.SCHOOLCOURSEINFO_SUBJECTAREALIST);
		}
		set
		{
			RemoveChild( StudentDTD.SCHOOLCOURSEINFO_SUBJECTAREALIST);
			if( value != null)
			{
				AddChild( StudentDTD.SCHOOLCOURSEINFO_SUBJECTAREALIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CourseTitle&gt;</c> element.
	/// </summary>
	/// <value> The <c>CourseTitle</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Title of the course."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string CourseTitle
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLCOURSEINFO_COURSETITLE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLCOURSEINFO_COURSETITLE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Textual description of the course."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLCOURSEINFO_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLCOURSEINFO_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;InstructionalLevel&gt;</c> element.
	/// </summary>
	/// <value> An InstructionalLevel </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "An indication of the general nature and difficulty of instruction provided."</para>
	/// <para>To remove the <c>InstructionalLevel</c>, set <c>InstructionalLevel</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public InstructionalLevel InstructionalLevel
	{
		get
		{
			return (InstructionalLevel)GetChild( StudentDTD.SCHOOLCOURSEINFO_INSTRUCTIONALLEVEL);
		}
		set
		{
			RemoveChild( StudentDTD.SCHOOLCOURSEINFO_INSTRUCTIONALLEVEL);
			if( value != null)
			{
				AddChild( StudentDTD.SCHOOLCOURSEINFO_INSTRUCTIONALLEVEL, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;CourseCredits&gt;</c> element.</summary>
	/// <param name="Type">The type of credit offered</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;CourseCredits&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setCourseCredits</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>CourseCredits</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetCourseCredits( CreditType Type, decimal? Value ) {
		RemoveChild( StudentDTD.SCHOOLCOURSEINFO_COURSECREDITS);
		AddChild( StudentDTD.SCHOOLCOURSEINFO_COURSECREDITS, new CourseCredits( Type, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CourseCredits&gt;</c> element.
	/// </summary>
	/// <value> A CourseCredits </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The number of credits awarded upon course completion."</para>
	/// <para>To remove the <c>CourseCredits</c>, set <c>CourseCredits</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public CourseCredits CourseCredits
	{
		get
		{
			return (CourseCredits)GetChild( StudentDTD.SCHOOLCOURSEINFO_COURSECREDITS);
		}
		set
		{
			RemoveChild( StudentDTD.SCHOOLCOURSEINFO_COURSECREDITS);
			if( value != null)
			{
				AddChild( StudentDTD.SCHOOLCOURSEINFO_COURSECREDITS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CoreAcademicCourse&gt;</c> element.
	/// </summary>
	/// <value> The <c>CoreAcademicCourse</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the course meet the state definition of a core academic course?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string CoreAcademicCourse
	{
		get
		{ 
			return GetFieldValue( StudentDTD.SCHOOLCOURSEINFO_COREACADEMICCOURSE );
		}
		set
		{
			SetField( StudentDTD.SCHOOLCOURSEINFO_COREACADEMICCOURSE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;CoreAcademicCourse&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the course meet the state definition of a core academic course?"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetCoreAcademicCourse( YesNo val )
	{
		SetField( StudentDTD.SCHOOLCOURSEINFO_COREACADEMICCOURSE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GraduationRequirement&gt;</c> element.
	/// </summary>
	/// <value> The <c>GraduationRequirement</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the state require that the course be completed for graduation?"</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;GraduationRequirement&gt;</description></item>
	/// </list>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string GraduationRequirement
	{
		get
		{ 
			return GetFieldValue( StudentDTD.SCHOOLCOURSEINFO_GRADUATIONREQUIREMENT );
		}
		set
		{
			SetField( StudentDTD.SCHOOLCOURSEINFO_GRADUATIONREQUIREMENT, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;GraduationRequirement&gt;</c> element.
	/// </summary>
	/// <param name="val">A YesNo object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Does the state require that the course be completed for graduation?"</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;GraduationRequirement&gt;</description></item>
	/// </list>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetGraduationRequirement( YesNo val )
	{
		SetField( StudentDTD.SCHOOLCOURSEINFO_GRADUATIONREQUIREMENT, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Department&gt;</c> element.
	/// </summary>
	/// <value> The <c>Department</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Department
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.SCHOOLCOURSEINFO_DEPARTMENT ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.SCHOOLCOURSEINFO_DEPARTMENT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SCEDCode&gt;</c> element.
	/// </summary>
	/// <value> A SCEDCode </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Course code from the School Codes for the Exchange of Data that describes the course content."</para>
	/// <para>To remove the <c>SCEDCode</c>, set <c>SCEDCode</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public SCEDCode SCEDCode
	{
		get
		{
			return (SCEDCode)GetChild( StudentDTD.SCHOOLCOURSEINFO_SCEDCODE);
		}
		set
		{
			RemoveChild( StudentDTD.SCHOOLCOURSEINFO_SCEDCODE);
			if( value != null)
			{
				AddChild( StudentDTD.SCHOOLCOURSEINFO_SCEDCODE, value );
			}
		}
	}

}}
