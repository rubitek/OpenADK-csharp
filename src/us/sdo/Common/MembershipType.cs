// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Common
{
	///<summary>
	/// Defines the set of values that can be specified whenever a MembershipType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a MembershipType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	[Serializable]
	public class MembershipType : SifEnum
	{
	/// <summary>A summer school enrollment, not part of the regular school year ("Summer")</summary>
	public static readonly MembershipType SUMMER = new MembershipType("Summer");

	/// <summary>The school is responsible for reporting the student's membership/child accounting information ("Home")</summary>
	public static readonly MembershipType HOME = new MembershipType("Home");

	/// <summary>The school is not the primary reporting unit for the student's membership/child accounting information ("Concurrent")</summary>
	public static readonly MembershipType CONCURRENT = new MembershipType("Concurrent");

	///<summary>Wrap an arbitrary string value in a MembershipType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static MembershipType Wrap( String wrappedValue ) {
		return new MembershipType( wrappedValue );
	}

	private MembershipType( string enumDefValue ) : base( enumDefValue ) {}
	}
}