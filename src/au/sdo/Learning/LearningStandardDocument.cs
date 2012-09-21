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

namespace OpenADK.Library.au.Learning{

/// <summary>A LearningStandardDocument</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class LearningStandardDocument : SifDataObject
{
	/// <summary>
	/// Creates an instance of a LearningStandardDocument
	/// </summary>
	public LearningStandardDocument() : base( Adk.SifVersion, LearningDTD.LEARNINGSTANDARDDOCUMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">A RefId</param>
	///<param name="language">A Language</param>
	///<param name="title">A Title</param>
	///<param name="source">A Source</param>
	///<param name="organizations">An Organizations</param>
	///<param name="subjectAreas">A SubjectAreas</param>
	///<param name="documentStatus">A DocumentStatus</param>
	///<param name="learningStandardItemRefId">A LearningStandardItemRefId</param>
	///
	public LearningStandardDocument( string refId, string language, string title, LearningStandardSource source, Organization organizations, SubjectAreaList subjectAreas, DocumentStatusType documentStatus, string learningStandardItemRefId ) : base( Adk.SifVersion, LearningDTD.LEARNINGSTANDARDDOCUMENT )
	{
		this.RefId = refId;
		this.Language = language;
		this.Title = title;
		this.SetSource( source );
		this.Organizations =  new Organizations( organizations );
		this.SubjectAreas = subjectAreas;
		this.SetDocumentStatus( documentStatus );
		this.LearningStandardItemRefId = learningStandardItemRefId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected LearningStandardDocument( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { LearningDTD.LEARNINGSTANDARDDOCUMENT_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_REFID ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Language</c> attribute.
	/// </summary>
	/// <value> The <c>Language</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Language
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_LANGUAGE ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_LANGUAGE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Title&gt;</c> element.
	/// </summary>
	/// <value> The <c>Title</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Title
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_TITLE ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_TITLE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RichDescription&gt;</c> element.
	/// </summary>
	/// <value> An AbstractContentElementType </value>
	/// <remarks>
	/// <para>To remove the <c>AbstractContentElementType</c>, set <c>RichDescription</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public AbstractContentElementType RichDescription
	{
		get
		{
			return (AbstractContentElementType)GetChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_RICHDESCRIPTION);
		}
		set
		{
			RemoveChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_RICHDESCRIPTION);
			if( value != null)
			{
				AddChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_RICHDESCRIPTION, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Source&gt;</c> element.
	/// </summary>
	/// <value> The <c>Source</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Source
	{
		get
		{ 
			return GetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_SOURCE );
		}
		set
		{
			SetField( LearningDTD.LEARNINGSTANDARDDOCUMENT_SOURCE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Source&gt;</c> element.
	/// </summary>
	/// <param name="val">A LearningStandardSource object</param>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetSource( LearningStandardSource val )
	{
		SetField( LearningDTD.LEARNINGSTANDARDDOCUMENT_SOURCE, val );
	}

	///<summary>Sets the value of the <c>&lt;Organizations&gt;</c> element.</summary>
	/// <param name="Organization">An Organization</param>
	///<remarks>
	/// <para>This form of <c>setOrganizations</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Organizations</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetOrganizations( Organization Organization ) {
		RemoveChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_ORGANIZATIONS);
		AddChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_ORGANIZATIONS, new Organizations( Organization ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Organizations&gt;</c> element.
	/// </summary>
	/// <value> An Organizations </value>
	/// <remarks>
	/// <para>To remove the <c>Organizations</c>, set <c>Organizations</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public Organizations Organizations
	{
		get
		{
			return (Organizations)GetChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_ORGANIZATIONS);
		}
		set
		{
			RemoveChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_ORGANIZATIONS);
			if( value != null)
			{
				AddChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_ORGANIZATIONS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Authors&gt;</c> element.
	/// </summary>
	/// <value> An Authors </value>
	/// <remarks>
	/// <para>To remove the <c>Authors</c>, set <c>Authors</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public Authors Authors
	{
		get
		{
			return (Authors)GetChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_AUTHORS);
		}
		set
		{
			RemoveChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_AUTHORS);
			if( value != null)
			{
				AddChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_AUTHORS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OrganizationContactPoint&gt;</c> element.
	/// </summary>
	/// <value> The <c>OrganizationContactPoint</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string OrganizationContactPoint
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_ORGANIZATIONCONTACTPOINT ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_ORGANIZATIONCONTACTPOINT, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;SubjectAreas&gt;</c> element.</summary>
	/// <param name="SubjectArea">Subject matter.</param>
	///<remarks>
	/// <para>This form of <c>setSubjectAreas</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>SubjectAreas</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetSubjectAreas( SubjectArea SubjectArea ) {
		RemoveChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_SUBJECTAREAS);
		AddChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_SUBJECTAREAS, new SubjectAreaList( SubjectArea ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SubjectAreas&gt;</c> element.
	/// </summary>
	/// <value> A SubjectAreaList </value>
	/// <remarks>
	/// <para>To remove the <c>SubjectAreaList</c>, set <c>SubjectAreas</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public SubjectAreaList SubjectAreas
	{
		get
		{
			return (SubjectAreaList)GetChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_SUBJECTAREAS);
		}
		set
		{
			RemoveChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_SUBJECTAREAS);
			if( value != null)
			{
				AddChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_SUBJECTAREAS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DocumentStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>DocumentStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string DocumentStatus
	{
		get
		{ 
			return GetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_DOCUMENTSTATUS );
		}
		set
		{
			SetField( LearningDTD.LEARNINGSTANDARDDOCUMENT_DOCUMENTSTATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;DocumentStatus&gt;</c> element.
	/// </summary>
	/// <param name="val">A DocumentStatusType object</param>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetDocumentStatus( DocumentStatusType val )
	{
		SetField( LearningDTD.LEARNINGSTANDARDDOCUMENT_DOCUMENTSTATUS, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DocumentDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>DocumentDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? DocumentDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_DOCUMENTDATE ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_DOCUMENTDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalAdoptionDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalAdoptionDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? LocalAdoptionDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_LOCALADOPTIONDATE ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_LOCALADOPTIONDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalArchiveDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalArchiveDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? LocalArchiveDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_LOCALARCHIVEDATE ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_LOCALARCHIVEDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EndOfLifeDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EndOfLifeDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? EndOfLifeDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_ENDOFLIFEDATE ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_ENDOFLIFEDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Copyright&gt;</c> element.
	/// </summary>
	/// <value> A Copyright </value>
	/// <remarks>
	/// <para>To remove the <c>Copyright</c>, set <c>Copyright</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public Copyright Copyright
	{
		get
		{
			return (Copyright)GetChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_COPYRIGHT);
		}
		set
		{
			RemoveChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_COPYRIGHT);
			if( value != null)
			{
				AddChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_COPYRIGHT, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;YearLevels&gt;</c> element.</summary>
	/// <param name="YearLevel">A YearLevel</param>
	///<remarks>
	/// <para>This form of <c>setYearLevels</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>YearLevels</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetYearLevels( YearLevel YearLevel ) {
		RemoveChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_YEARLEVELS);
		AddChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_YEARLEVELS, new YearLevels( YearLevel ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;YearLevels&gt;</c> element.
	/// </summary>
	/// <value> A YearLevels </value>
	/// <remarks>
	/// <para>To remove the <c>YearLevels</c>, set <c>YearLevels</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public YearLevels YearLevels
	{
		get
		{
			return (YearLevels)GetChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_YEARLEVELS);
		}
		set
		{
			RemoveChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_YEARLEVELS);
			if( value != null)
			{
				AddChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_YEARLEVELS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RepositoryDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>RepositoryDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? RepositoryDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_REPOSITORYDATE ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_REPOSITORYDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LearningStandardItemRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LearningStandardItemRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string LearningStandardItemRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_LEARNINGSTANDARDITEMREFID ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.LEARNINGSTANDARDDOCUMENT_LEARNINGSTANDARDITEMREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RelatedLearningStandards&gt;</c> element.
	/// </summary>
	/// <value> A RelatedLearningStandards </value>
	/// <remarks>
	/// <para>To remove the <c>RelatedLearningStandards</c>, set <c>RelatedLearningStandards</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public RelatedLearningStandards RelatedLearningStandards
	{
		get
		{
			return (RelatedLearningStandards)GetChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_RELATEDLEARNINGSTANDARDS);
		}
		set
		{
			RemoveChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_RELATEDLEARNINGSTANDARDS);
			if( value != null)
			{
				AddChild( LearningDTD.LEARNINGSTANDARDDOCUMENT_RELATEDLEARNINGSTANDARDS, value );
			}
		}
	}

}}