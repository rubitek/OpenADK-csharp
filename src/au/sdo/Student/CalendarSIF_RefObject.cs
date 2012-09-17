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
	/// Defines the set of values that can be specified whenever a CalendarSIF_RefObject
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a CalendarSIF_RefObject object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class CalendarSIF_RefObject : SifEnum
	{
	/// <summary>CalendarSummary ("CalendarSummary")</summary>
	public static readonly CalendarSIF_RefObject CALENDARSUMMARY = new CalendarSIF_RefObject("CalendarSummary");

	///<summary>Wrap an arbitrary string value in a CalendarSIF_RefObject object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static CalendarSIF_RefObject Wrap( String wrappedValue ) {
		return new CalendarSIF_RefObject( wrappedValue );
	}

	private CalendarSIF_RefObject( string enumDefValue ) : base( enumDefValue ) {}
	}
}
