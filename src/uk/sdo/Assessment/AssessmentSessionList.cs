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

/// <summary>An AssessmentSessionList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.1</para>
/// </remarks>
[Serializable]
public class AssessmentSessionList : SifKeyedList<AssessmentSessionRefId>
{
	/// <summary>
	/// Creates an instance of an AssessmentSessionList
	/// </summary>
	public AssessmentSessionList() : base ( AssessmentDTD.ASSESSMENTSESSIONLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="assessmentSessionRefId">The ID (GUID) that uniquely identifies the session associated with the result.</param>
	///
	public AssessmentSessionList( AssessmentSessionRefId assessmentSessionRefId ) : base( AssessmentDTD.ASSESSMENTSESSIONLIST )
	{
		this.SafeAddChild( AssessmentDTD.ASSESSMENTSESSIONLIST_ASSESSMENTSESSIONREFID, assessmentSessionRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentSessionList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ASSESSMENTSESSIONLIST_ASSESSMENTSESSIONREFID }; }
	}

	///<summary>Adds the value of the <c>&lt;AssessmentSessionRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;AssessmentSessionRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setAssessmentSessionRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddAssessmentSessionRefId</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public void AddAssessmentSessionRefId( string Value ) {
		AddChild( AssessmentDTD.ASSESSMENTSESSIONLIST_ASSESSMENTSESSIONREFID, new AssessmentSessionRefId( Value ) );
	}

}}
