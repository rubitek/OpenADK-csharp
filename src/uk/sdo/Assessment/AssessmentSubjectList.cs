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

/// <summary>An AssessmentSubjectList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.1</para>
/// </remarks>
[Serializable]
public class AssessmentSubjectList : SifKeyedList<AssessmentSubject>
{
	/// <summary>
	/// Creates an instance of an AssessmentSubjectList
	/// </summary>
	public AssessmentSubjectList() : base ( AssessmentDTD.ASSESSMENTSUBJECTLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="subject">A subject area associated with this assessment component or aspect.</param>
	///
	public AssessmentSubjectList( AssessmentSubject subject ) : base( AssessmentDTD.ASSESSMENTSUBJECTLIST )
	{
		this.SafeAddChild( AssessmentDTD.ASSESSMENTSUBJECTLIST_SUBJECT, subject );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssessmentSubjectList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { AssessmentDTD.ASSESSMENTSUBJECTLIST_SUBJECT }; }
	}

	///<summary>Adds the value of the <c>&lt;Subject&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;AssessmentSubject&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setSubject</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSubject</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	public void AddSubject( AssessmentSubjectType Value ) {
		AddChild( AssessmentDTD.ASSESSMENTSUBJECTLIST_SUBJECT, new AssessmentSubject( Value ) );
	}

}}
