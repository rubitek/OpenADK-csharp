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
	/// Defines the set of values that can be specified whenever a FinancialProgram
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a FinancialProgram object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class FinancialProgram : SifEnum
	{
	/// <summary>Code defined by the State Department of Education ("StateDOE")</summary>
	public static readonly FinancialProgram STATEDOE = new FinancialProgram("StateDOE");

	/// <summary>Textual description ("Text")</summary>
	public static readonly FinancialProgram TEXT = new FinancialProgram("Text");

	/// <summary>Code from the NCES Handbook ("NCES")</summary>
	public static readonly FinancialProgram NCES = new FinancialProgram("NCES");

	/// <summary>Locally-defined code ("Local")</summary>
	public static readonly FinancialProgram LOCAL = new FinancialProgram("Local");

	/// <summary>Foodservice ("Foodservice")</summary>
	public static readonly FinancialProgram FOODSERVICE = new FinancialProgram("Foodservice");

	/// <summary>CFDA ("CFDA")</summary>
	public static readonly FinancialProgram CFDA = new FinancialProgram("CFDA");

	///<summary>Wrap an arbitrary string value in a FinancialProgram object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static FinancialProgram Wrap( String wrappedValue ) {
		return new FinancialProgram( wrappedValue );
	}

	private FinancialProgram( string enumDefValue ) : base( enumDefValue ) {}
	}
}
