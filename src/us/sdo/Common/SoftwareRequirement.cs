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

namespace OpenADK.Library.us.Common{

/// <summary>Contains information about a specific required piece of software.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class SoftwareRequirement : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SoftwareRequirement
	/// </summary>
	public SoftwareRequirement() : base ( CommonDTD.SOFTWAREREQUIREMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="softwareTitle">This is the title of the specific software. This does not include the vendor. For example, Flash not Adobe.</param>
	///
	public SoftwareRequirement( string softwareTitle ) : base( CommonDTD.SOFTWAREREQUIREMENT )
	{
		this.SoftwareTitle = softwareTitle;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SoftwareRequirement( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.SOFTWAREREQUIREMENT_SOFTWARETITLE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SoftwareTitle&gt;</c> element.
	/// </summary>
	/// <value> The <c>SoftwareTitle</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This is the title of the specific software. This does not include the vendor. For example, Flash not Adobe."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string SoftwareTitle
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.SOFTWAREREQUIREMENT_SOFTWARETITLE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.SOFTWAREREQUIREMENT_SOFTWARETITLE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Version&gt;</c> element.
	/// </summary>
	/// <value> The <c>Version</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This includes the version of the specific software."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Version
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.SOFTWAREREQUIREMENT_VERSION ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.SOFTWAREREQUIREMENT_VERSION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Vendor&gt;</c> element.
	/// </summary>
	/// <value> The <c>Vendor</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This is the vendor of the specific software. For example, Adobe."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Vendor
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.SOFTWAREREQUIREMENT_VENDOR ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.SOFTWAREREQUIREMENT_VENDOR, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OS&gt;</c> element.
	/// </summary>
	/// <value> The <c>OS</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This is the operating system and version. For example, Macintosh OS X 1.4."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string OS
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.SOFTWAREREQUIREMENT_OS ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.SOFTWAREREQUIREMENT_OS, new SifString( value ), value );
		}
	}

}}
