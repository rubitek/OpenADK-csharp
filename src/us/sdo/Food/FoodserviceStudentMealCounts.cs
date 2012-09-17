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

namespace OpenADK.Library.us.Food{

/// <summary>A FoodserviceStudentMealCounts</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class FoodserviceStudentMealCounts : SifDataObject
{
	/// <summary>
	/// Creates an instance of a FoodserviceStudentMealCounts
	/// </summary>
	public FoodserviceStudentMealCounts() : base( Adk.SifVersion, FoodDTD.FOODSERVICESTUDENTMEALCOUNTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">GUID that identifies the daily meal sales object</param>
	///<param name="schoolInfoRefId">School for which the sales object applies</param>
	///<param name="date">Date on which the sales occurred.</param>
	///<param name="program">A Program</param>
	///<param name="counts">A Counts</param>
	///
	public FoodserviceStudentMealCounts( string refId, string schoolInfoRefId, DateTime? date, Program program, Counts counts ) : base( Adk.SifVersion, FoodDTD.FOODSERVICESTUDENTMEALCOUNTS )
	{
		this.RefId = refId;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.Date = date;
		this.Program = program;
		this.Counts = counts;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FoodserviceStudentMealCounts( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID that identifies the daily meal sales object"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_REFID ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "School for which the sales object applies"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Date&gt;</c> element.
	/// </summary>
	/// <value> The <c>Date</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date on which the sales occurred."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public DateTime? Date
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_DATE ) ;
		}
		set
		{
			SetFieldValue( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_DATE, new SifDate( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Program&gt;</c> element.</summary>
	/// <param name="Type">The type of the program. Type identifies the list of values.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Program&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setProgram</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Program</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetProgram( FinancialProgram Type, string Value ) {
		RemoveChild( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_PROGRAM);
		AddChild( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_PROGRAM, new Program( Type, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Program&gt;</c> element.
	/// </summary>
	/// <value> A Program </value>
	/// <remarks>
	/// <para>To remove the <c>Program</c>, set <c>Program</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Program Program
	{
		get
		{
			return (Program)GetChild( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_PROGRAM);
		}
		set
		{
			RemoveChild( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_PROGRAM);
			if( value != null)
			{
				AddChild( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_PROGRAM, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Counts&gt;</c> element.
	/// </summary>
	/// <value> A Counts </value>
	/// <remarks>
	/// <para>To remove the <c>Counts</c>, set <c>Counts</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public Counts Counts
	{
		get
		{
			return (Counts)GetChild( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_COUNTS);
		}
		set
		{
			RemoveChild( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_COUNTS);
			if( value != null)
			{
				AddChild( FoodDTD.FOODSERVICESTUDENTMEALCOUNTS_COUNTS, value );
			}
		}
	}

}}
