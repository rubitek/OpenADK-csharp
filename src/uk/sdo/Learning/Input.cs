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

namespace OpenADK.Library.uk.Learning{

/// <summary>An Input</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class Input : SifElement
{
	/// <summary>
	/// Creates an instance of an Input
	/// </summary>
	public Input() : base ( LearningDTD.INPUT ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Input( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <value> The <c>Type</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Conditional and has only one value: "SC".   "SC" has special meaning – it means this is the top of the "tree" and the input is the whole school."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( LearningDTD.INPUT_TYPE );
		}
		set
		{
			SetField( LearningDTD.INPUT_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Type&gt;</c> element.
	/// </summary>
	/// <param name="val">A InputType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Conditional and has only one value: "SC".   "SC" has special meaning – it means this is the top of the "tree" and the input is the whole school."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetType( InputType val )
	{
		SetField( LearningDTD.INPUT_TYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GroupLocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>GroupLocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string GroupLocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.INPUT_GROUPLOCALID ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.INPUT_GROUPLOCALID, new SifString( value ), value );
		}
	}

}}
