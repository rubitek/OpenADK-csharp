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
using OpenADK.Library.Infra;

namespace OpenADK.Library.au.Reporting{

/// <summary>A SIF_QueryGroup</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class SIF_QueryGroup : SifKeyedList<SIF_Query>
{
	/// <summary>
	/// Creates an instance of a SIF_QueryGroup
	/// </summary>
	public SIF_QueryGroup() : base ( ReportingDTD.SIF_QUERYGROUP ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifQuery">A SIF_Query</param>
	///
	public SIF_QueryGroup( SIF_Query sifQuery ) : base( ReportingDTD.SIF_QUERYGROUP )
	{
		this.SafeAddChild( ReportingDTD.SIF_QUERYGROUP_SIF_QUERY, sifQuery );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_QueryGroup( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { ReportingDTD.SIF_QUERYGROUP_SIF_QUERY }; }
	}

	///<summary>Adds the value of the <c>&lt;SIF_Query&gt;</c> element.</summary>
	/// <param name="SifQueryObject">A SIF_QueryObject</param>
	///<remarks>
	/// <para>This form of <c>setSIF_Query</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSIF_Query</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void AddSIF_Query( SIF_QueryObject SifQueryObject ) {
		AddChild( ReportingDTD.SIF_QUERYGROUP_SIF_QUERY, new SIF_Query( SifQueryObject ) );
	}

}}