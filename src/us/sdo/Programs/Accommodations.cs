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

namespace OpenADK.Library.us.Programs{

/// <summary>An Accommodations</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Accommodations : SifElement
{
	/// <summary>
	/// Creates an instance of an Accommodations
	/// </summary>
	public Accommodations() : base ( ProgramsDTD.ACCOMMODATIONS ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Accommodations( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Accommodation&gt;</c> element.
	/// </summary>
	/// <value> An Accommodation </value>
	/// <remarks>
	/// <para>To remove the <c>Accommodation</c>, set <c>Accommodation</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Accommodation Accommodation
	{
		get
		{
			return (Accommodation)GetChild( ProgramsDTD.ACCOMMODATIONS_ACCOMMODATION);
		}
		set
		{
			RemoveChild( ProgramsDTD.ACCOMMODATIONS_ACCOMMODATION);
			if( value != null)
			{
				AddChild( ProgramsDTD.ACCOMMODATIONS_ACCOMMODATION, value );
			}
		}
	}

}}
