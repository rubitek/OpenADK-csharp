// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.uk.Assessment
{
	///<summary>
	/// Defines the set of values that can be specified whenever a GroupType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a GroupType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.1</para>
	/// </remarks>
	[Serializable]
	public class GroupType : SifEnum
	{
	/// <summary>Teaching (course) Group ("T")</summary>
	public static readonly GroupType T_TEACHING_COURSE_GROUP = new GroupType("T");

	/// <summary>Registration/Class Group ("R")</summary>
	public static readonly GroupType R_REGISTRATION_CLASS = new GroupType("R");

	/// <summary>Generic Group ("G")</summary>
	public static readonly GroupType G_GENERIC_GROUP = new GroupType("G");

	///<summary>Wrap an arbitrary string value in a GroupType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static GroupType Wrap( String wrappedValue ) {
		return new GroupType( wrappedValue );
	}

	private GroupType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
