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

namespace OpenADK.Library.us.Assessment{

/// <summary>An AssessmentForm</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class AssessmentForm : SifDataObject
{
	/// <summary>
	/// Creates an instance of an AssessmentForm
	/// </summary>
	public AssessmentForm() : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTFORM ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The GUID that uniquely identifies an instance of the object.</param>
	///<param name="assessmentRefId">The RefId of the assessment related to this form.</param>
	///
	public AssessmentForm( string refId, string assessmentRefId ) : base( Adk.SifVersion, AssessmentDTD.ASSESSMENTFORM )
	{
		this.RefId = refId;
		this.AssessmentRefId = assessmentRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentForm( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ASSESSMENTFORM_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The GUID that uniquely identifies an instance of the object."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTFORM_REFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTFORM_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>AssessmentRefId</c> attribute.
	/// </summary>
	/// <value> The <c>AssessmentRefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The RefId of the assessment related to this form."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AssessmentRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTFORM_ASSESSMENTREFID ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTFORM_ASSESSMENTREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentType&gt;</c> element.
	/// </summary>
	/// <value> The <c>AssessmentType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates whether this assessment (form) is a standard administration or alternate."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string AssessmentType
	{
		get
		{ 
			return GetFieldValue( AssessmentDTD.ASSESSMENTFORM_ASSESSMENTTYPE );
		}
		set
		{
			SetField( AssessmentDTD.ASSESSMENTFORM_ASSESSMENTTYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;AssessmentType&gt;</c> element.
	/// </summary>
	/// <param name="val">A AssessmentType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates whether this assessment (form) is a standard administration or alternate."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetAssessmentType( AssessmentType val )
	{
		SetField( AssessmentDTD.ASSESSMENTFORM_ASSESSMENTTYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FormName&gt;</c> element.
	/// </summary>
	/// <value> The <c>FormName</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Text description for this particular arrangement of questions, etc."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string FormName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTFORM_FORMNAME ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTFORM_FORMNAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FormNumbers&gt;</c> element.
	/// </summary>
	/// <value> A FormNumbers </value>
	/// <remarks>
	/// <para>To remove the <c>FormNumbers</c>, set <c>FormNumbers</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public FormNumbers FormNumbers
	{
		get
		{
			return (FormNumbers)GetChild( AssessmentDTD.ASSESSMENTFORM_FORMNUMBERS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTFORM_FORMNUMBERS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTFORM_FORMNUMBERS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Level&gt;</c> element.
	/// </summary>
	/// <value> The <c>Level</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Indicates the level of the form."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Level
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTFORM_LEVEL ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTFORM_LEVEL, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Period&gt;</c> element.
	/// </summary>
	/// <value> The <c>Period</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The time period in which the form is intended to be administered."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Period
	{
		get
		{
			return (string) GetSifSimpleFieldValue( AssessmentDTD.ASSESSMENTFORM_PERIOD ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.ASSESSMENTFORM_PERIOD, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevels&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevels </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Grade levels this assessment is designed to evaluate."</para>
	/// <para>To remove the <c>GradeLevels</c>, set <c>GradeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public GradeLevels GradeLevels
	{
		get
		{
			return (GradeLevels)GetChild( AssessmentDTD.ASSESSMENTFORM_GRADELEVELS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTFORM_GRADELEVELS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTFORM_GRADELEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssessmentSubTestRefIds&gt;</c> element.
	/// </summary>
	/// <value> An AssessmentSubTestRefIds </value>
	/// <remarks>
	/// <para>To remove the <c>AssessmentSubTestRefIds</c>, set <c>AssessmentSubTestRefIds</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public AssessmentSubTestRefIds AssessmentSubTestRefIds
	{
		get
		{
			return (AssessmentSubTestRefIds)GetChild( AssessmentDTD.ASSESSMENTFORM_ASSESSMENTSUBTESTREFIDS);
		}
		set
		{
			RemoveChild( AssessmentDTD.ASSESSMENTFORM_ASSESSMENTSUBTESTREFIDS);
			if( value != null)
			{
				AddChild( AssessmentDTD.ASSESSMENTFORM_ASSESSMENTSUBTESTREFIDS, value );
			}
		}
	}

}}
