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

namespace OpenADK.Library.au.Common{

/// <summary>An OtherCode</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class OtherCode : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of an OtherCode
	/// </summary>
	public OtherCode() : base ( CommonDTD.OTHERCODE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="codeset">Describes the OtherCode element content as either a
	/// state/province code, a local code, other code, or text string.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;OtherCode&amp;gt; element</param>
	///
	public OtherCode( Codeset codeset, string value ) : base( CommonDTD.OTHERCODE )
	{
		this.SetCodeset( codeset );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected OtherCode( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.OTHERCODE_CODESET }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;OtherCode&amp;gt; element"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.OTHERCODE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.OTHERCODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>Codeset</c> attribute.
	/// </summary>
	/// <value> The <c>Codeset</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Describes the OtherCode element content as either a
	/// state/province code, a local code, other code, or text string."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Codeset
	{
		get
		{ 
			return GetFieldValue( CommonDTD.OTHERCODE_CODESET );
		}
		set
		{
			SetField( CommonDTD.OTHERCODE_CODESET, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Codeset</c> attribute.
	/// </summary>
	/// <param name="val">A Codeset object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Describes the OtherCode element content as either a
	/// state/province code, a local code, other code, or text string."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCodeset( Codeset val )
	{
		SetField( CommonDTD.OTHERCODE_CODESET, val );
	}

}}
