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

/// <summary>A ParentObjectRefId</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class ParentObjectRefId : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a ParentObjectRefId
	/// </summary>
	public ParentObjectRefId() : base ( CommonDTD.PARENTOBJECTREFID ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifRefObject">The name of the object reference.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;ParentObjectRefId&amp;gt; element</param>
	///
	public ParentObjectRefId( ParentObjectRefIdSIF_RefObject sifRefObject, string value ) : base( CommonDTD.PARENTOBJECTREFID )
	{
		this.SetSIF_RefObject( sifRefObject );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ParentObjectRefId( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.PARENTOBJECTREFID_SIF_REFOBJECT }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ParentObjectRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;ParentObjectRefId&amp;gt; element"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.PARENTOBJECTREFID ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.PARENTOBJECTREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>SIF_RefObject</c> attribute.
	/// </summary>
	/// <value> The <c>SIF_RefObject</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The name of the object reference."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SIF_RefObject
	{
		get
		{ 
			return GetFieldValue( CommonDTD.PARENTOBJECTREFID_SIF_REFOBJECT );
		}
		set
		{
			SetField( CommonDTD.PARENTOBJECTREFID_SIF_REFOBJECT, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>SIF_RefObject</c> attribute.
	/// </summary>
	/// <param name="val">A ParentObjectRefIdSIF_RefObject object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The name of the object reference."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetSIF_RefObject( ParentObjectRefIdSIF_RefObject val )
	{
		SetField( CommonDTD.PARENTOBJECTREFID_SIF_REFOBJECT, val );
	}

}}
