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

namespace OpenADK.Library.us.Instr{

/// <summary>Time structures for the activity.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class ActivityTime : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an ActivityTime
	/// </summary>
	public ActivityTime() : base ( InstrDTD.ACTIVITYTIME ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="creationDate">Creation date of the activity.</param>
	///
	public ActivityTime( DateTime? creationDate ) : base( InstrDTD.ACTIVITYTIME )
	{
		this.CreationDate = creationDate;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ActivityTime( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InstrDTD.ACTIVITYTIME_CREATIONDATE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CreationDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>CreationDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Creation date of the activity."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? CreationDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( InstrDTD.ACTIVITYTIME_CREATIONDATE ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.ACTIVITYTIME_CREATIONDATE, new SifDate( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Duration&gt;</c> element.</summary>
	/// <param name="Units">Unit of time of the Duration value.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Duration&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setDuration</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Duration</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetDuration( DurationUnits Units, string Value ) {
		RemoveChild( InstrDTD.ACTIVITYTIME_DURATION);
		AddChild( InstrDTD.ACTIVITYTIME_DURATION, new Duration( Units, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Duration&gt;</c> element.
	/// </summary>
	/// <value> A Duration </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Time required to complete the activity."</para>
	/// <para>To remove the <c>Duration</c>, set <c>Duration</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public Duration Duration
	{
		get
		{
			return (Duration)GetChild( InstrDTD.ACTIVITYTIME_DURATION);
		}
		set
		{
			RemoveChild( InstrDTD.ACTIVITYTIME_DURATION);
			if( value != null)
			{
				AddChild( InstrDTD.ACTIVITYTIME_DURATION, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StartDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>StartDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date activity is started."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? StartDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( InstrDTD.ACTIVITYTIME_STARTDATE ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.ACTIVITYTIME_STARTDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FinishDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>FinishDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date activity is finished."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? FinishDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( InstrDTD.ACTIVITYTIME_FINISHDATE ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.ACTIVITYTIME_FINISHDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DueDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>DueDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date activity is due."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? DueDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( InstrDTD.ACTIVITYTIME_DUEDATE ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.ACTIVITYTIME_DUEDATE, new SifDate( value ), value );
		}
	}

}}
