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

namespace OpenADK.Library.us.Library{

/// <summary>A Message</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class Message : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Message
	/// </summary>
	public Message() : base ( LibraryDTD.MESSAGE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="priority">The level of urgency associated with this message.</param>
	///<param name="text">The contents of the message.</param>
	///
	public Message( Priority priority, string text ) : base( LibraryDTD.MESSAGE )
	{
		this.SetPriority( priority );
		this.Text = text;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Message( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { LibraryDTD.MESSAGE_PRIORITY }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Priority</c> attribute.
	/// </summary>
	/// <value> The <c>Priority</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The level of urgency associated with this message."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Priority
	{
		get
		{ 
			return GetFieldValue( LibraryDTD.MESSAGE_PRIORITY );
		}
		set
		{
			SetField( LibraryDTD.MESSAGE_PRIORITY, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Priority</c> attribute.
	/// </summary>
	/// <param name="val">A Priority object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The level of urgency associated with this message."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public void SetPriority( Priority val )
	{
		SetField( LibraryDTD.MESSAGE_PRIORITY, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Sent&gt;</c> element.
	/// </summary>
	/// <value> The <c>Sent</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The date and time that this message was originally sent."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;Sent&gt;</description></item>
	/// </list>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public DateTime? Sent
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( LibraryDTD.MESSAGE_SENT ) ;
		}
		set
		{
			SetFieldValue( LibraryDTD.MESSAGE_SENT, new SifDateTime( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Text&gt;</c> element.
	/// </summary>
	/// <value> The <c>Text</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The contents of the message."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Text
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LibraryDTD.MESSAGE_TEXT ) ;
		}
		set
		{
			SetFieldValue( LibraryDTD.MESSAGE_TEXT, new SifString( value ), value );
		}
	}

}}
