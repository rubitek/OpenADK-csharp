// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Student
{
	///<summary>
	/// Defines the set of values that can be specified whenever a SourceCodeType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a SourceCodeType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class SourceCodeType : SifEnum
	{
	/// <summary>Ascribed by the current school ("S")</summary>
	public static readonly SourceCodeType S_ASCRIBED_BYCURRENT = new SourceCodeType("S");

	/// <summary>Ascribed by a previous school ("T")</summary>
	public static readonly SourceCodeType T_ASCRIBED_BYPREVIOUS = new SourceCodeType("T");

	/// <summary>Provided by the child (ie pupil) ("C")</summary>
	public static readonly SourceCodeType C_PROVIDED_BYCHILD_IE_PUPIL = new SourceCodeType("C");

	/// <summary>Other  ("O")</summary>
	public static readonly SourceCodeType O_OT = new SourceCodeType("O");

	/// <summary>Provided by the parent ("P")</summary>
	public static readonly SourceCodeType P_PROVIDED_BYPARENT = new SourceCodeType("P");

	///<summary>Wrap an arbitrary string value in a SourceCodeType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static SourceCodeType Wrap( String wrappedValue ) {
		return new SourceCodeType( wrappedValue );
	}

	private SourceCodeType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
