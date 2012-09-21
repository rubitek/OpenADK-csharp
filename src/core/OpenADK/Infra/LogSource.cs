// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.Infra
{
	///<summary>
	/// Defines the set of values that can be specified whenever a LogSource
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a LogSource object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class LogSource : SifEnum
	{
	/// <summary>Agent ("Agent")</summary>
	public static readonly LogSource AGENT = new LogSource("Agent");

	/// <summary>ZIS ("ZIS")</summary>
	public static readonly LogSource ZIS = new LogSource("ZIS");

	///<summary>Wrap an arbitrary string value in a LogSource object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static LogSource Wrap( String wrappedValue ) {
		return new LogSource( wrappedValue );
	}

	private LogSource( string enumDefValue ) : base( enumDefValue ) {}
	}
}