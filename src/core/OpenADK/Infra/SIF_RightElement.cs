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

namespace OpenADK.Library.Infra{

/// <summary>A SIF_RightElement</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class SIF_RightElement : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SIF_RightElement
	/// </summary>
	public SIF_RightElement() : base ( InfraDTD.SIF_RIGHTELEMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="objectName">An ObjectName</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;SIF_RightElement&amp;gt; element</param>
	///
	public SIF_RightElement( string objectName, string value ) : base( InfraDTD.SIF_RIGHTELEMENT )
	{
		this.ObjectName = objectName;
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_RightElement( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_RIGHTELEMENT_OBJECTNAME }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_RightElement&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;SIF_RightElement&amp;gt; element"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_RIGHTELEMENT ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_RIGHTELEMENT, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>ObjectName</c> attribute.
	/// </summary>
	/// <value> The <c>ObjectName</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string ObjectName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_RIGHTELEMENT_OBJECTNAME ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_RIGHTELEMENT_OBJECTNAME, new SifString( value ), value );
		}
	}

}}
