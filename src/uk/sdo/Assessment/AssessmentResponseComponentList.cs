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
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.Assessment{

/// <summary>An AssessmentResponseComponentList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.1</para>
/// </remarks>
[Serializable]
public class AssessmentResponseComponentList : SifKeyedList<AssessmentResponseComponentRefId>
{
	/// <summary>
	/// Creates an instance of an AssessmentResponseComponentList
	/// </summary>
	public AssessmentResponseComponentList() : base ( AssessmentDTD.ASSESSMENTRESPONSECOMPONENTLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="assessmentResponseComponentRefId">A SIF identifier for an assessment result component.</param>
	///
	public AssessmentResponseComponentList( AssessmentResponseComponentRefId assessmentResponseComponentRefId ) : base( AssessmentDTD.ASSESSMENTRESPONSECOMPONENTLIST )
	{
		this.SafeAddChild( AssessmentDTD.ASSESSMENTRESPONSECOMPONENTLIST_ASSESSMENTRESPONSECOMPONENTREFID, assessmentResponseComponentRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentResponseComponentList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ASSESSMENTRESPONSECOMPONENTLIST_ASSESSMENTRESPONSECOMPONENTREFID }; }
	}

	///<summary>Adds the value of the <c>&lt;AssessmentResponseComponentRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;AssessmentResponseComponentRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentResponseComponentRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddAssessmentResponseComponentRefId</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public void AddAssessmentResponseComponentRefId( string Value ) {
		AddChild( AssessmentDTD.ASSESSMENTRESPONSECOMPONENTLIST_ASSESSMENTRESPONSECOMPONENTREFID, new AssessmentResponseComponentRefId( Value ) );
	}

}}
