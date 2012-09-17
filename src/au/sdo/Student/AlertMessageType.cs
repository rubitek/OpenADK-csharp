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
	/// Defines the set of values that can be specified whenever an AlertMessageType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AlertMessageType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class AlertMessageType : SifEnum
	{
	/// <summary>Other ("Other")</summary>
	public static readonly AlertMessageType OTHER = new AlertMessageType("Other");

	/// <summary>Educational ("Educational")</summary>
	public static readonly AlertMessageType EDUCATIONAL = new AlertMessageType("Educational");

	/// <summary>Discipline ("Discipline")</summary>
	public static readonly AlertMessageType DISCIPLINE = new AlertMessageType("Discipline");

	/// <summary>Legal ("Legal")</summary>
	public static readonly AlertMessageType LEGAL = new AlertMessageType("Legal");

	///<summary>Wrap an arbitrary string value in an AlertMessageType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AlertMessageType Wrap( String wrappedValue ) {
		return new AlertMessageType( wrappedValue );
	}

	private AlertMessageType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
