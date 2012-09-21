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

/// <summary>A SIF_Version</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_Version : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SIF_Version
	/// </summary>
	public SIF_Version() : base ( InfraDTD.SIF_VERSION ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="value">Gets or sets the content value of the &amp;lt;SIF_Version&amp;gt; element</param>
	///
	public SIF_Version( string value ) : base( InfraDTD.SIF_VERSION )
	{
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_Version( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_VERSION }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Version&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;SIF_Version&amp;gt; element"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_VERSION ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_VERSION, new SifString( value ), value );
		}
	}

		#region EXTRA METHODS

// BEGIN EXTRA METHODS (C:/dev/OpenADK-java/adk-generator/datadef/core/sif20/SIF_Version.txt.cs)


	/**
	 * Creates a SIF_Version object with the specified SIFVersion
	 * @param version
	 */
		public SIF_Version( SifVersion version ) : this( version.ToString() ) {}

// END EXTRA METHODS

		#endregion // EXTRA METHODS
}}