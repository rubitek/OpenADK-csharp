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

/// <summary>A MarkInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class MarkInfo : SifDataObject
{
	/// <summary>
	/// Creates an instance of a MarkInfo
	/// </summary>
	public MarkInfo() : base( Adk.SifVersion, GradebookDTD.MARKINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The ID (GUID) that uniquely identifies this Grading Mark entity.</param>
	///<param name="markValueInfoRefId">The ID (GUID) that uniquely identifies the MarkValueInfo.</param>
	///<param name="schoolInfoRefId">The ID (GUID) that uniquely identifies the School that this Mark applies to.</param>
	///
	public MarkInfo( string refId, string markValueInfoRefId, string schoolInfoRefId ) : base( Adk.SifVersion, GradebookDTD.MARKINFO )
	{
		this.RefId = refId;
		this.MarkValueInfoRefId = markValueInfoRefId;
		this.SchoolInfoRefId = schoolInfoRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected MarkInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { GradebookDTD.MARKINFO_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies this Grading Mark entity."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.MARKINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.MARKINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>MarkValueInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>MarkValueInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies the MarkValueInfo."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string MarkValueInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.MARKINFO_MARKVALUEINFOREFID ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.MARKINFO_MARKVALUEINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies the School that this Mark applies to."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.MARKINFO_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.MARKINFO_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SIF_Action</c> attribute.
	/// </summary>
	/// <value> The <c>SIF_Action</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "In a Change event, this flag can be used to indicate an element has been deleted from the parent list container. At a minimum the key for the list must also be present."</para>
	/// <para>Version: 2.0</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SIF_Action
	{
		get
		{ 
			return GetFieldValue( GradebookDTD.MARKINFO_SIF_ACTION );
		}
		set
		{
			SetField( GradebookDTD.MARKINFO_SIF_ACTION, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>SIF_Action</c> attribute.
	/// </summary>
	/// <param name="val">A SIFActionType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "In a Change event, this flag can be used to indicate an element has been deleted from the parent list container. At a minimum the key for the list must also be present."</para>
	/// <para>Version: 2.0</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetSIF_Action( SIFActionType val )
	{
		SetField( GradebookDTD.MARKINFO_SIF_ACTION, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolYear&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolYear</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The year that this  MarkInfo applies to."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? SchoolYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( GradebookDTD.MARKINFO_SCHOOLYEAR ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.MARKINFO_SCHOOLYEAR, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Textual description of the type of Mark (e.g. "Marking Period Grade", "Comment 1", "Comment 2", "Conduct", "Effort", "WorkHabits")."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.MARKINFO_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.MARKINFO_DESCRIPTION, new SifString( value ), value );
		}
	}

}}
