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

namespace OpenADK.Library.us.Energymanagement{

/// <summary>A ReadingList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class ReadingList : SifKeyedList<Reading>
{
	/// <summary>
	/// Creates an instance of a ReadingList
	/// </summary>
	public ReadingList() : base ( EnergymanagementDTD.READINGLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="reading">Values for the energy readings for each interval.</param>
	///
	public ReadingList( Reading reading ) : base( EnergymanagementDTD.READINGLIST )
	{
		this.SafeAddChild( EnergymanagementDTD.READINGLIST_READING, reading );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ReadingList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;Reading&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Reading&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setReading</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddReading</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void AddReading( decimal? Value ) {
		AddChild( EnergymanagementDTD.READINGLIST_READING, new Reading( Value ) );
	}

}}
