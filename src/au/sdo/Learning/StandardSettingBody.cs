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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Learning{

/// <summary>A StandardSettingBody</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class StandardSettingBody : SifElement
{
	/// <summary>
	/// Creates an instance of a StandardSettingBody
	/// </summary>
	public StandardSettingBody() : base ( LearningDTD.STANDARDSETTINGBODY ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="country">A Country</param>
	///<param name="settingBodyName">A SettingBodyName</param>
	///
	public StandardSettingBody( Country country, string settingBodyName ) : base( LearningDTD.STANDARDSETTINGBODY )
	{
		this.Country = country;
		this.SettingBodyName = settingBodyName;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StandardSettingBody( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { LearningDTD.STANDARDSETTINGBODY_COUNTRY, LearningDTD.STANDARDSETTINGBODY_SETTINGBODYNAME }; }
	}

	///<summary>Sets the value of the <c>&lt;Country&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;Country&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setCountry</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Country</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetCountry( CountryCode Value ) {
		RemoveChild( LearningDTD.STANDARDSETTINGBODY_COUNTRY);
		AddChild( LearningDTD.STANDARDSETTINGBODY_COUNTRY, new Country( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Country&gt;</c> element.
	/// </summary>
	/// <value> A Country </value>
	/// <remarks>
	/// <para>To remove the <c>Country</c>, set <c>Country</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public Country Country
	{
		get
		{
			return (Country)GetChild( LearningDTD.STANDARDSETTINGBODY_COUNTRY);
		}
		set
		{
			RemoveChild( LearningDTD.STANDARDSETTINGBODY_COUNTRY);
			if( value != null)
			{
				AddChild( LearningDTD.STANDARDSETTINGBODY_COUNTRY, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateProvince&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateProvince</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string StateProvince
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.STANDARDSETTINGBODY_STATEPROVINCE ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.STANDARDSETTINGBODY_STATEPROVINCE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SettingBodyName&gt;</c> element.
	/// </summary>
	/// <value> The <c>SettingBodyName</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string SettingBodyName
	{
		get
		{
			return (string) GetSifSimpleFieldValue( LearningDTD.STANDARDSETTINGBODY_SETTINGBODYNAME ) ;
		}
		set
		{
			SetFieldValue( LearningDTD.STANDARDSETTINGBODY_SETTINGBODYNAME, new SifString( value ), value );
		}
	}

}}