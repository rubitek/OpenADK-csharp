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

/// <summary>A MarkValueInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class MarkValueInfo : SifDataObject
{
	/// <summary>
	/// Creates an instance of a MarkValueInfo
	/// </summary>
	public MarkValueInfo() : base( Adk.SifVersion, GradebookDTD.MARKVALUEINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The ID (GUID) that uniquely identifies this MarkValueInfo entity.</param>
	///<param name="schoolInfoRefId">The ID (GUID) that uniquely identifies the School that these Mark Values apply to.</param>
	///
	public MarkValueInfo( string refId, string schoolInfoRefId ) : base( Adk.SifVersion, GradebookDTD.MARKVALUEINFO )
	{
		this.RefId = refId;
		this.SchoolInfoRefId = schoolInfoRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected MarkValueInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { GradebookDTD.MARKVALUEINFO_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies this MarkValueInfo entity."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.MARKVALUEINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.MARKVALUEINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SchoolInfoRefId</c> attribute.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The ID (GUID) that uniquely identifies the School that these Mark Values apply to."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.MARKVALUEINFO_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.MARKVALUEINFO_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolYear&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolYear</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The year that this  MarkValueInfo applies to."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public int? SchoolYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( GradebookDTD.MARKVALUEINFO_SCHOOLYEAR ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.MARKVALUEINFO_SCHOOLYEAR, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The text name of the value list ("Letter Grades", "Letter Grades (+/-)", "ESU", "Pass/Fail", "Override Grades", "Citizenship Comment Codes", etc.)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( GradebookDTD.MARKVALUEINFO_NAME ) ;
		}
		set
		{
			SetFieldValue( GradebookDTD.MARKVALUEINFO_NAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Percentage&gt;</c> element.
	/// </summary>
	/// <value> A Percentage </value>
	/// <remarks>
	/// <para>To remove the <c>Percentage</c>, set <c>Percentage</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Percentage Percentage
	{
		get
		{
			return (Percentage)GetChild( GradebookDTD.MARKVALUEINFO_PERCENTAGE);
		}
		set
		{
			RemoveChild( GradebookDTD.MARKVALUEINFO_PERCENTAGE);
			if( value != null)
			{
				AddChild( GradebookDTD.MARKVALUEINFO_PERCENTAGE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Numeric&gt;</c> element.
	/// </summary>
	/// <value> A Numeric </value>
	/// <remarks>
	/// <para>To remove the <c>Numeric</c>, set <c>Numeric</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Numeric Numeric
	{
		get
		{
			return (Numeric)GetChild( GradebookDTD.MARKVALUEINFO_NUMERIC);
		}
		set
		{
			RemoveChild( GradebookDTD.MARKVALUEINFO_NUMERIC);
			if( value != null)
			{
				AddChild( GradebookDTD.MARKVALUEINFO_NUMERIC, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Letter&gt;</c> element.</summary>
	/// <param name="IsAccepted">Indicates whether a letter Mark is accepted and is used in Change events to unambiguously signal whether support for the Mark has changed, especially ended.</param>
	///<remarks>
	/// <para>This form of <c>setLetter</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Letter</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetLetter( bool? IsAccepted ) {
		RemoveChild( GradebookDTD.MARKVALUEINFO_LETTER);
		AddChild( GradebookDTD.MARKVALUEINFO_LETTER, new Letter( IsAccepted ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Letter&gt;</c> element.
	/// </summary>
	/// <value> A Letter </value>
	/// <remarks>
	/// <para>To remove the <c>Letter</c>, set <c>Letter</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Letter Letter
	{
		get
		{
			return (Letter)GetChild( GradebookDTD.MARKVALUEINFO_LETTER);
		}
		set
		{
			RemoveChild( GradebookDTD.MARKVALUEINFO_LETTER);
			if( value != null)
			{
				AddChild( GradebookDTD.MARKVALUEINFO_LETTER, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Narrative&gt;</c> element.
	/// </summary>
	/// <value> A Narrative </value>
	/// <remarks>
	/// <para>To remove the <c>Narrative</c>, set <c>Narrative</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Narrative Narrative
	{
		get
		{
			return (Narrative)GetChild( GradebookDTD.MARKVALUEINFO_NARRATIVE);
		}
		set
		{
			RemoveChild( GradebookDTD.MARKVALUEINFO_NARRATIVE);
			if( value != null)
			{
				AddChild( GradebookDTD.MARKVALUEINFO_NARRATIVE, value );
			}
		}
	}

}}
