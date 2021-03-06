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

/// <summary>A StudentContactPersonal</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class StudentContactPersonal : SifDataObject
{
	/// <summary>
	/// Creates an instance of a StudentContactPersonal
	/// </summary>
	public StudentContactPersonal() : base( Adk.SifVersion, StudentDTD.STUDENTCONTACTPERSONAL ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The ID (GUID) that uniquely identifies the instance of the object.</param>
	///<param name="personInfo">A PersonInfo</param>
	///
	public StudentContactPersonal( string refId, PersonInfo personInfo ) : base( Adk.SifVersion, StudentDTD.STUDENTCONTACTPERSONAL )
	{
		this.RefId = refId;
		this.PersonInfo = personInfo;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentContactPersonal( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.STUDENTCONTACTPERSONAL_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies the instance of the object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTCONTACTPERSONAL_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTCONTACTPERSONAL_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally-assigned identifier for this person. Note: LocalId may be used as a unique person identifier rather than a unique contact identifier. In this case there may be more than one StudentContactPersonal instance with the same LocalId."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTCONTACTPERSONAL_LOCALID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTCONTACTPERSONAL_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherIdList&gt;</c> element.
	/// </summary>
	/// <value> An OtherIdList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherIdList</c>, set <c>OtherIdList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public OtherIdList OtherIdList
	{
		get
		{
			return (OtherIdList)GetChild( StudentDTD.STUDENTCONTACTPERSONAL_OTHERIDLIST);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTCONTACTPERSONAL_OTHERIDLIST);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTCONTACTPERSONAL_OTHERIDLIST, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;PersonInfo&gt;</c> element.</summary>
	/// <param name="Name">The name of the person. Note: Type attribute value of LGL must be used here.</param>
	///<remarks>
	/// <para>This form of <c>setPersonInfo</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PersonInfo</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPersonInfo( Name Name ) {
		RemoveChild( StudentDTD.STUDENTCONTACTPERSONAL_PERSONINFO);
		AddChild( StudentDTD.STUDENTCONTACTPERSONAL_PERSONINFO, new PersonInfo( Name ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PersonInfo&gt;</c> element.
	/// </summary>
	/// <value> A PersonInfo </value>
	/// <remarks>
	/// <para>To remove the <c>PersonInfo</c>, set <c>PersonInfo</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PersonInfo PersonInfo
	{
		get
		{
			return (PersonInfo)GetChild( StudentDTD.STUDENTCONTACTPERSONAL_PERSONINFO);
		}
		set
		{
			RemoveChild( StudentDTD.STUDENTCONTACTPERSONAL_PERSONINFO);
			if( value != null)
			{
				AddChild( StudentDTD.STUDENTCONTACTPERSONAL_PERSONINFO, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EmploymentType&gt;</c> element.
	/// </summary>
	/// <value> The <c>EmploymentType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Code that defines employment type. This is compulsory for Parents or Guardians of the Student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string EmploymentType
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTCONTACTPERSONAL_EMPLOYMENTTYPE );
		}
		set
		{
			SetField( StudentDTD.STUDENTCONTACTPERSONAL_EMPLOYMENTTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;EmploymentType&gt;</c> element.
	/// </summary>
	/// <param name="val">A EmploymentType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Code that defines employment type. This is compulsory for Parents or Guardians of the Student."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetEmploymentType( EmploymentType val )
	{
		SetField( StudentDTD.STUDENTCONTACTPERSONAL_EMPLOYMENTTYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolEducationalLevel&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolEducationalLevel</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The highest level of education completed by the contact person."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolEducationalLevel
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.STUDENTCONTACTPERSONAL_SCHOOLEDUCATIONALLEVEL ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.STUDENTCONTACTPERSONAL_SCHOOLEDUCATIONALLEVEL, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NonSchoolEducation&gt;</c> element.
	/// </summary>
	/// <value> The <c>NonSchoolEducation</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This reflects the level of the Contact‚Äôs Non-School Education."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string NonSchoolEducation
	{
		get
		{ 
			return GetFieldValue( StudentDTD.STUDENTCONTACTPERSONAL_NONSCHOOLEDUCATION );
		}
		set
		{
			SetField( StudentDTD.STUDENTCONTACTPERSONAL_NONSCHOOLEDUCATION, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;NonSchoolEducation&gt;</c> element.
	/// </summary>
	/// <param name="val">A NonSchoolEducationType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This reflects the level of the Contact‚Äôs Non-School Education."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetNonSchoolEducation( NonSchoolEducationType val )
	{
		SetField( StudentDTD.STUDENTCONTACTPERSONAL_NONSCHOOLEDUCATION, val );
	}

}}
