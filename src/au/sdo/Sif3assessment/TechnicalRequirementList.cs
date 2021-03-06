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

/// <summary>A TechnicalRequirementList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class TechnicalRequirementList : SifKeyedList<TechnicalRequirement>
{
	/// <summary>
	/// Creates an instance of a TechnicalRequirementList
	/// </summary>
	public TechnicalRequirementList() : base ( Sif3assessmentDTD.TECHNICALREQUIREMENTLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="technicalRequirement">A TechnicalRequirement</param>
	///
	public TechnicalRequirementList( TechnicalRequirement technicalRequirement ) : base( Sif3assessmentDTD.TECHNICALREQUIREMENTLIST )
	{
		this.SafeAddChild( Sif3assessmentDTD.TECHNICALREQUIREMENTLIST_TECHNICALREQUIREMENT, technicalRequirement );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected TechnicalRequirementList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.TECHNICALREQUIREMENTLIST_TECHNICALREQUIREMENT }; }
	}

	///<summary>Adds the value of the <c>&lt;TechnicalRequirement&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;TechnicalRequirement&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setTechnicalRequirement</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddTechnicalRequirement</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddTechnicalRequirement( string Value ) {
		AddChild( Sif3assessmentDTD.TECHNICALREQUIREMENTLIST_TECHNICALREQUIREMENT, new TechnicalRequirement( Value ) );
	}

}}
