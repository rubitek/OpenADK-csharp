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

namespace OpenADK.Library.au.Sif3assessment{

/// <summary>A FormIdentifierList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class FormIdentifierList : SifKeyedList<FormIdentifier>
{
	/// <summary>
	/// Creates an instance of a FormIdentifierList
	/// </summary>
	public FormIdentifierList() : base ( Sif3assessmentDTD.FORMIDENTIFIERLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="formIdentifier">A FormIdentifier</param>
	///
	public FormIdentifierList( FormIdentifier formIdentifier ) : base( Sif3assessmentDTD.FORMIDENTIFIERLIST )
	{
		this.SafeAddChild( Sif3assessmentDTD.FORMIDENTIFIERLIST_FORMIDENTIFIER, formIdentifier );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FormIdentifierList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.FORMIDENTIFIERLIST_FORMIDENTIFIER }; }
	}

	///<summary>Adds the value of the <c>&lt;FormIdentifier&gt;</c> element.</summary>
	/// <param name="FormIdentifierType">A FormIdentifierType</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;FormIdentifier&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setFormIdentifier</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddFormIdentifier</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddFormIdentifier( AssessmentIdType FormIdentifierType, string Value ) {
		AddChild( Sif3assessmentDTD.FORMIDENTIFIERLIST_FORMIDENTIFIER, new FormIdentifier( FormIdentifierType, Value ) );
	}

}}
