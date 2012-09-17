// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AlertMsgType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AlertMsgType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	[Serializable]
	public class AlertMsgType : SifEnum
	{
	/// <summary>Other ("Other")</summary>
	public static readonly AlertMsgType OTHER = new AlertMsgType("Other");

	/// <summary>Educational ("Educational")</summary>
	public static readonly AlertMsgType EDUCATIONAL = new AlertMsgType("Educational");

	/// <summary>Discipline ("Discipline")</summary>
	public static readonly AlertMsgType DISCIPLINE = new AlertMsgType("Discipline");

	/// <summary>Legal ("Legal")</summary>
	public static readonly AlertMsgType LEGAL = new AlertMsgType("Legal");

	///<summary>Wrap an arbitrary string value in an AlertMsgType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AlertMsgType Wrap( String wrappedValue ) {
		return new AlertMsgType( wrappedValue );
	}

	private AlertMsgType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
