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

/// <summary>A Student</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class Student : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Student
	/// </summary>
	public Student() : base ( StudentDTD.STUDENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="studentSchoolEnrollmentRefId">The ID (GUID) of the StudentSchoolEnrollment object from which the enrollment information is derived.</param>
	///
	public Student( string studentSchoolEnrollmentRefId ) : base( StudentDTD.STUDENT )
	{
		this.StudentSchoolEnrollmentRefId = studentSchoolEnrollmentRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Student( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.STUDENT_STUDENTSCHOOLENROLLMENTREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentSchoolEnrollmentRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StudentSchoolEnrollmentRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The ID (GUID) of the StudentSchoolEnrollment object from which the enrollment information is derived."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string StudentSchoolEnrollmentRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENT_STUDENTSCHOOLENROLLMENTREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENT_STUDENTSCHOOLENROLLMENTREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StudentLocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StudentLocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally-defined identifier for this Student."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string StudentLocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENT_STUDENTLOCALID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENT_STUDENTLOCALID, new SifString( value ), value );
		}
	}

}}
