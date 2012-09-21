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

namespace OpenADK.Library.us.Gradebook{

/// <summary>A StudentSectionMarks</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class StudentSectionMarks : SifDataObject
{
	/// <summary>
	/// Creates an instance of a StudentSectionMarks
	/// </summary>
	public StudentSectionMarks() : base( Adk.SifVersion, GradebookDTD.STUDENTSECTIONMARKS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="studentPersonalRefId">The ID (GUID) that uniquely identifies the StudentPersonal object that this item refers to.</param>
	///<param name="sectionInfoRefId">The ID (GUID) that uniquely identifies the SectionInfo object that this item refers to.</param>
	///<param name="termInfoRefId">The ID (GUID) that identifies the marking period that the following marks are recorded in.</param>
	///<param name="schoolInfoRefId">The ID (GUID) that uniquely identifies the School that these Mark Values apply to.</param>
	///
	public StudentSectionMarks( string studentPersonalRefId, string sectionInfoRefId, string termInfoRefId, string schoolInfoRefId ) : base( Adk.SifVersion, GradebookDTD.STUDENTSECTIONMARKS )
	{
		this.StudentPersonalRefId = studentPersonalRefId;
		this.SectionInfoRefId = sectionInfoRefId;
		this.TermInfoRefId = termInfoRefId;
		this.SchoolInfoRefId = schoolInfoRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentSectionMarks( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { GradebookDTD.STUDENTSECTIONMARKS_STUDENTPERSONALREFID, GradebookDTD.STUDENTSECTIONMARKS_SECTIONINFOREFID, GradebookDTD.STUDENTSECTIONMARKS_TERMINFOREFID, GradebookDTD.STUDENTSECTIONMARKS_SCHOOLINFOREFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>StudentPersonalRefId</c> attribute.
	/// </summary>
	/// <value> The <c>StudentPersonalRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies the StudentPersonal object that this item refers to."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string StudentPersonalRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.STUDENTSECTIONMARKS_STUDENTPERSONALREFID ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.STUDENTSECTIONMARKS_STUDENTPERSONALREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SectionInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SectionInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies the SectionInfo object that this item refers to."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SectionInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.STUDENTSECTIONMARKS_SECTIONINFOREFID ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.STUDENTSECTIONMARKS_SECTIONINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>TermInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>TermInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that identifies the marking period that the following marks are recorded in."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string TermInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.STUDENTSECTIONMARKS_TERMINFOREFID ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.STUDENTSECTIONMARKS_TERMINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies the School that these Mark Values apply to."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.STUDENTSECTIONMARKS_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.STUDENTSECTIONMARKS_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;IsFinal&gt;</c> element.
	/// </summary>
	/// <value> The <c>IsFinal</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates if the grades are "Final" from the perspective of the teacher or school.  Does not mean that change events will not occur for this item."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public bool? IsFinal
	{
		get
		{
			return (bool?) GetSifSimpleFieldValue( GradebookDTD.STUDENTSECTIONMARKS_ISFINAL ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.STUDENTSECTIONMARKS_ISFINAL, new SifBoolean( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MarkList&gt;</c> element.
	/// </summary>
	/// <value> A MarkList </value>
	/// <remarks>
	/// <para>To remove the <c>MarkList</c>, set <c>MarkList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public MarkList MarkList
	{
		get
		{
			return (MarkList)GetChild( GradebookDTD.STUDENTSECTIONMARKS_MARKLIST);
		}
		set
		{
			RemoveChild( GradebookDTD.STUDENTSECTIONMARKS_MARKLIST);
			if( value != null)
			{
				AddChild( GradebookDTD.STUDENTSECTIONMARKS_MARKLIST, value );
			}
		}
	}

}}