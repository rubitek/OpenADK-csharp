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

namespace OpenADK.Library.us.Instr{

/// <summary>This object contains information related to learning resources that can be searched for and retrieved from content repositories.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class ContentCatalog : SifDataObject
{
	/// <summary>
	/// Creates an instance of a ContentCatalog
	/// </summary>
	public ContentCatalog() : base( Adk.SifVersion, InstrDTD.CONTENTCATALOG ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="language">The default language used in this ContentCatalog object.</param>
	///<param name="contentObject">The learning object.</param>
	///
	public ContentCatalog( LanguageCode language, ContentObject contentObject ) : base( Adk.SifVersion, InstrDTD.CONTENTCATALOG )
	{
		this.SetLanguage( language );
		this.ContentObject = contentObject;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ContentCatalog( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InstrDTD.CONTENTCATALOG_LANGUAGE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Language</c> attribute.
	/// </summary>
	/// <value> The <c>Language</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The default language used in this ContentCatalog object."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Language
	{
		get
		{ 
			return GetFieldValue( InstrDTD.CONTENTCATALOG_LANGUAGE );
		}
		set
		{
			SetField( InstrDTD.CONTENTCATALOG_LANGUAGE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Language</c> attribute.
	/// </summary>
	/// <param name="val">A LanguageCode object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The default language used in this ContentCatalog object."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetLanguage( LanguageCode val )
	{
		SetField( InstrDTD.CONTENTCATALOG_LANGUAGE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ContentObject&gt;</c> element.
	/// </summary>
	/// <value> A ContentObject </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The learning object."</para>
	/// <para>To remove the <c>ContentObject</c>, set <c>ContentObject</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public ContentObject ContentObject
	{
		get
		{
			return (ContentObject)GetChild( InstrDTD.CONTENTCATALOG_CONTENTOBJECT);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTCATALOG_CONTENTOBJECT);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTCATALOG_CONTENTOBJECT, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Status&gt;</c> element.
	/// </summary>
	/// <value> The <c>Status</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Describes availability status of resource, e.g. "checked out.""</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Status
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.CONTENTCATALOG_STATUS ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CONTENTCATALOG_STATUS, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Title&gt;</c> element.
	/// </summary>
	/// <value> The <c>Title</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Title of the resource, e.g., "The Civil War …""</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Title
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.CONTENTCATALOG_TITLE ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CONTENTCATALOG_TITLE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Description of the resource, e.g., "This textbook is intended for grade 4 social studies students and addresses...""</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.CONTENTCATALOG_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CONTENTCATALOG_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Author&gt;</c> element.
	/// </summary>
	/// <value> The <c>Author</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of individual, organization or company that created the resource"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Author
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.CONTENTCATALOG_AUTHOR ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CONTENTCATALOG_AUTHOR, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LanguageCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>LanguageCode</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The language used by the content to communicate to the Student"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string LanguageCode
	{
		get
		{ 
			return GetFieldValue( InstrDTD.CONTENTCATALOG_LANGUAGECODE );
		}
		set
		{
			SetField( InstrDTD.CONTENTCATALOG_LANGUAGECODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;LanguageCode&gt;</c> element.
	/// </summary>
	/// <param name="val">A NISOZ3953LanguageCodesType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The language used by the content to communicate to the Student"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetLanguageCode( NISOZ3953LanguageCodesType val )
	{
		SetField( InstrDTD.CONTENTCATALOG_LANGUAGECODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GradeLevels&gt;</c> element.
	/// </summary>
	/// <value> A GradeLevels </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "A common element used to specify the collection of grade levels supported."</para>
	/// <para>To remove the <c>GradeLevels</c>, set <c>GradeLevels</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public GradeLevels GradeLevels
	{
		get
		{
			return (GradeLevels)GetChild( InstrDTD.CONTENTCATALOG_GRADELEVELS);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTCATALOG_GRADELEVELS);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTCATALOG_GRADELEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SubjectAreas&gt;</c> element.
	/// </summary>
	/// <value> A SubjectAreas </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "A list of subject areas."</para>
	/// <para>To remove the <c>SubjectAreas</c>, set <c>SubjectAreas</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public SubjectAreas SubjectAreas
	{
		get
		{
			return (SubjectAreas)GetChild( InstrDTD.CONTENTCATALOG_SUBJECTAREAS);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTCATALOG_SUBJECTAREAS);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTCATALOG_SUBJECTAREAS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MediaTypes&gt;</c> element.
	/// </summary>
	/// <value> A MediaTypes </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Resource media types"</para>
	/// <para>To remove the <c>MediaTypes</c>, set <c>MediaTypes</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public MediaTypes MediaTypes
	{
		get
		{
			return (MediaTypes)GetChild( InstrDTD.CONTENTCATALOG_MEDIATYPES);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTCATALOG_MEDIATYPES);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTCATALOG_MEDIATYPES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LearningStandards&gt;</c> element.
	/// </summary>
	/// <value> A CatalogLearningStandards </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This element contains information related to curriculum standards statements "standards" or "benchmarks" or the like within the document."</para>
	/// <para>To remove the <c>CatalogLearningStandards</c>, set <c>LearningStandards</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public CatalogLearningStandards LearningStandards
	{
		get
		{
			return (CatalogLearningStandards)GetChild( InstrDTD.CONTENTCATALOG_LEARNINGSTANDARDS);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTCATALOG_LEARNINGSTANDARDS);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTCATALOG_LEARNINGSTANDARDS, value );
			}
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
	/// <para>Since: 2.4</para>
	/// </remarks>
	public InstructionalLevel InstructionalLevel
	{
		get
		{
			return (InstructionalLevel)GetChild( InstrDTD.CONTENTCATALOG_INSTRUCTIONALLEVEL);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTCATALOG_INSTRUCTIONALLEVEL);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTCATALOG_INSTRUCTIONALLEVEL, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TechnicalRequirements&gt;</c> element.
	/// </summary>
	/// <value> A TechnicalRequirements </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Operating system, network, and other technical requirements for the activity, if applicable."</para>
	/// <para>To remove the <c>TechnicalRequirements</c>, set <c>TechnicalRequirements</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public TechnicalRequirements TechnicalRequirements
	{
		get
		{
			return (TechnicalRequirements)GetChild( InstrDTD.CONTENTCATALOG_TECHNICALREQUIREMENTS);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTCATALOG_TECHNICALREQUIREMENTS);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTCATALOG_TECHNICALREQUIREMENTS, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Duration&gt;</c> element.</summary>
	/// <param name="Units">Unit of time of the Duration value.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Duration&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setDuration</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Duration</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetDuration( DurationUnits Units, string Value ) {
		RemoveChild( InstrDTD.CONTENTCATALOG_DURATION);
		AddChild( InstrDTD.CONTENTCATALOG_DURATION, new Duration( Units, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Duration&gt;</c> element.
	/// </summary>
	/// <value> A Duration </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Time required to complete the activity."</para>
	/// <para>To remove the <c>Duration</c>, set <c>Duration</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public Duration Duration
	{
		get
		{
			return (Duration)GetChild( InstrDTD.CONTENTCATALOG_DURATION);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTCATALOG_DURATION);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTCATALOG_DURATION, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CurriculumHierarchyList&gt;</c> element.
	/// </summary>
	/// <value> A CurriculumHierarchyList </value>
	/// <remarks>
	/// <para>To remove the <c>CurriculumHierarchyList</c>, set <c>CurriculumHierarchyList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public CurriculumHierarchyList CurriculumHierarchyList
	{
		get
		{
			return (CurriculumHierarchyList)GetChild( InstrDTD.CONTENTCATALOG_CURRICULUMHIERARCHYLIST);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTCATALOG_CURRICULUMHIERARCHYLIST);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTCATALOG_CURRICULUMHIERARCHYLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Prerequisites&gt;</c> element.
	/// </summary>
	/// <value> A Prerequisites </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Skills or competencies the student must have to engage in activity."</para>
	/// <para>To remove the <c>Prerequisites</c>, set <c>Prerequisites</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public Prerequisites Prerequisites
	{
		get
		{
			return (Prerequisites)GetChild( InstrDTD.CONTENTCATALOG_PREREQUISITES);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTCATALOG_PREREQUISITES);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTCATALOG_PREREQUISITES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Adaptations&gt;</c> element.
	/// </summary>
	/// <value> The <c>Adaptations</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Adaptations necessary for target students (508)"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Adaptations
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.CONTENTCATALOG_ADAPTATIONS ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CONTENTCATALOG_ADAPTATIONS, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Size&gt;</c> element.
	/// </summary>
	/// <value> The <c>Size</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The size of the learning content objects."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Size
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.CONTENTCATALOG_SIZE ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CONTENTCATALOG_SIZE, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Cost&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;MonetaryAmount&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setCost</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Cost</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetCost( decimal? Value ) {
		RemoveChild( InstrDTD.CONTENTCATALOG_COST);
		AddChild( InstrDTD.CONTENTCATALOG_COST, new MonetaryAmount( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Cost&gt;</c> element.
	/// </summary>
	/// <value> A MonetaryAmount </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The price of the object requested"</para>
	/// <para>To remove the <c>MonetaryAmount</c>, set <c>Cost</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public MonetaryAmount Cost
	{
		get
		{
			return (MonetaryAmount)GetChild( InstrDTD.CONTENTCATALOG_COST);
		}
		set
		{
			RemoveChild( InstrDTD.CONTENTCATALOG_COST);
			if( value != null)
			{
				AddChild( InstrDTD.CONTENTCATALOG_COST, value );
			}
		}
	}

}}
