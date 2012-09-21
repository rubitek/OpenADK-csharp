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

namespace OpenADK.Library.us.Instr{

/// <summary>Description of additional curriculum hierarchical level</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class CurriculumHierarchy : SifElement
{
	/// <summary>
	/// Creates an instance of a CurriculumHierarchy
	/// </summary>
	public CurriculumHierarchy() : base ( InstrDTD.CURRICULUMHIERARCHY ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected CurriculumHierarchy( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;Level&gt;</c> element.
	/// </summary>
	/// <value> The <c>Level</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number reference of Curriculum Hierarchy"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Level
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.CURRICULUMHIERARCHY_LEVEL ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CURRICULUMHIERARCHY_LEVEL, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Description of Curriculum Hierarchy level"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.CURRICULUMHIERARCHY_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CURRICULUMHIERARCHY_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ParentLevel&gt;</c> element.
	/// </summary>
	/// <value> The <c>ParentLevel</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Parent Level"</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string ParentLevel
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.CURRICULUMHIERARCHY_PARENTLEVEL ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.CURRICULUMHIERARCHY_PARENTLEVEL, new SifString( value ), value );
		}
	}

}}