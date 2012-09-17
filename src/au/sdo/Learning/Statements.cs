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

/// <summary>A Statements</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class Statements : SifKeyedList<Statement>
{
	/// <summary>
	/// Creates an instance of a Statements
	/// </summary>
	public Statements() : base ( LearningDTD.STATEMENTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="statement">A Statement</param>
	///
	public Statements( Statement statement ) : base( LearningDTD.STATEMENTS )
	{
		this.SafeAddChild( LearningDTD.STATEMENTS_STATEMENT, statement );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Statements( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { LearningDTD.STATEMENTS_STATEMENT }; }
	}

	///<summary>Adds the value of the <c>&lt;Statement&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Statement&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setStatement</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddStatement</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void AddStatement( string Value ) {
		AddChild( LearningDTD.STATEMENTS_STATEMENT, new Statement( Value ) );
	}

}}
