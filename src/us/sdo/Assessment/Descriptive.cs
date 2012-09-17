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

namespace OpenADK.Library.us.Assessment{

/// <summary>A Descriptive</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class Descriptive : SifElement
{
	/// <summary>
	/// Creates an instance of a Descriptive
	/// </summary>
	public Descriptive() : base ( AssessmentDTD.DESCRIPTIVE ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Descriptive( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;PValue&gt;</c> element.
	/// </summary>
	/// <value> The <c>PValue</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The percent of respondents who answered correctly. This number represents the probability of the correct response to a question."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public float? PValue
	{
		get
		{
			return (float?) GetSifSimpleFieldValue( AssessmentDTD.DESCRIPTIVE_PVALUE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.DESCRIPTIVE_PVALUE, new SifFloat( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SampleSize&gt;</c> element.
	/// </summary>
	/// <value> The <c>SampleSize</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The size of the student group that saw the item."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? SampleSize
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( AssessmentDTD.DESCRIPTIVE_SAMPLESIZE ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.DESCRIPTIVE_SAMPLESIZE, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PointBiserial&gt;</c> element.
	/// </summary>
	/// <value> The <c>PointBiserial</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The correlation between correct answers (dichotomous variable) on this item and total correct answers on the test."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public decimal? PointBiserial
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( AssessmentDTD.DESCRIPTIVE_POINTBISERIAL ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.DESCRIPTIVE_POINTBISERIAL, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Biserial&gt;</c> element.
	/// </summary>
	/// <value> The <c>Biserial</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Similar to the Point Biserial Correlation except that answers to the item are assumed to come from an underlying continuous variable."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public decimal? Biserial
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( AssessmentDTD.DESCRIPTIVE_BISERIAL ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.DESCRIPTIVE_BISERIAL, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DiscriminationIndex&gt;</c> element.
	/// </summary>
	/// <value> The <c>DiscriminationIndex</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The Index of Discrimination is the difference between the proportion of an upper group who got an item right and the proportion of a lower group who got the item right."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public decimal? DiscriminationIndex
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( AssessmentDTD.DESCRIPTIVE_DISCRIMINATIONINDEX ) ;
		}
		set
		{
			SetFieldValue( AssessmentDTD.DESCRIPTIVE_DISCRIMINATIONINDEX, new SifDecimal( value ), value );
		}
	}

}}
