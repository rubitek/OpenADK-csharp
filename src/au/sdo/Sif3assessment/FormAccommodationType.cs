// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Sif3assessment
{
	///<summary>
	/// Defines the set of values that can be specified whenever a FormAccommodationType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  a FormAccommodationType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	[Serializable]
	public class FormAccommodationType : SifEnum
	{
	/// <summary>braille ("braille")</summary>
	public static readonly FormAccommodationType BRAILLE = new FormAccommodationType("braille");

	/// <summary>simplifiedLanguage ("simplifiedLanguage")</summary>
	public static readonly FormAccommodationType SIMPLIFIEDLANGUAGE = new FormAccommodationType("simplifiedLanguage");

	/// <summary>signLanguage ("signLanguage")</summary>
	public static readonly FormAccommodationType SIGNLANGUAGE = new FormAccommodationType("signLanguage");

	/// <summary>audio ("audio")</summary>
	public static readonly FormAccommodationType AUDIO = new FormAccommodationType("audio");

	/// <summary>alternateLanguage ("alternateLanguage")</summary>
	public static readonly FormAccommodationType ALTERNATELANGUAGE = new FormAccommodationType("alternateLanguage");

	/// <summary>text-to-speech ("text-to-speech")</summary>
	public static readonly FormAccommodationType TEXTTOSPEECH = new FormAccommodationType("text-to-speech");

	///<summary>Wrap an arbitrary string value in a FormAccommodationType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static FormAccommodationType Wrap( String wrappedValue ) {
		return new FormAccommodationType( wrappedValue );
	}

	private FormAccommodationType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
