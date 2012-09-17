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

namespace OpenADK.Library.us.Programs{

/// <summary>An AccommodationCategory</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class AccommodationCategory : SifElement
{
	/// <summary>
	/// Creates an instance of an AccommodationCategory
	/// </summary>
	public AccommodationCategory() : base ( ProgramsDTD.ACCOMMODATIONCATEGORY ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AccommodationCategory( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( ProgramsDTD.ACCOMMODATIONCATEGORY_CODE );
		}
		set
		{
			SetField( ProgramsDTD.ACCOMMODATIONCATEGORY_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A AccommodationCategoryCode object</param>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCode( AccommodationCategoryCode val )
	{
		SetField( ProgramsDTD.ACCOMMODATIONCATEGORY_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( ProgramsDTD.ACCOMMODATIONCATEGORY_OTHERCODELIST);
		}
		set
		{
			RemoveChild( ProgramsDTD.ACCOMMODATIONCATEGORY_OTHERCODELIST);
			if( value != null)
			{
				AddChild( ProgramsDTD.ACCOMMODATIONCATEGORY_OTHERCODELIST, value );
			}
		}
	}

}}
