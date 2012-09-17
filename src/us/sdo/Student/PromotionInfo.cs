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

namespace OpenADK.Library.us.Student{

/// <summary>Information on a student’s promotion, retention, or demotion related to this enrollment instance.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class PromotionInfo : SifElement
{
	/// <summary>
	/// Creates an instance of a PromotionInfo
	/// </summary>
	public PromotionInfo() : base ( StudentDTD.PROMOTIONINFO ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PromotionInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;PromotionStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>PromotionStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This value should be set if this enrollment instance is closed for an end-of-year closeout or a mid-year promotion or demotion. A value other than NA should be specified when the enrollment instance represents an end-of-year closeout or mid-year promotion/demotion."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string PromotionStatus
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.PROMOTIONINFO_PROMOTIONSTATUS ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.PROMOTIONINFO_PROMOTIONSTATUS, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Promotion&gt;</c> element.</summary>
	/// <param name="Code">The reason the student was promoted. This element should only be populated if the value of PromotionStatus is "Promoted".</param>
	///<remarks>
	/// <para>This form of <c>setPromotion</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Promotion</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetPromotion( NCES0672PromotionType Code ) {
		RemoveChild( StudentDTD.PROMOTIONINFO_PROMOTION);
		AddChild( StudentDTD.PROMOTIONINFO_PROMOTION, new Promotion( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Promotion&gt;</c> element.
	/// </summary>
	/// <value> A Promotion </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This element is mutually exclusive with Nonpromotion, and its child elements should only be populated if the value of PromotionStatus is "Promoted"."</para>
	/// <para>To remove the <c>Promotion</c>, set <c>Promotion</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public Promotion Promotion
	{
		get
		{
			return (Promotion)GetChild( StudentDTD.PROMOTIONINFO_PROMOTION);
		}
		set
		{
			RemoveChild( StudentDTD.PROMOTIONINFO_PROMOTION);
			if( value != null)
			{
				AddChild( StudentDTD.PROMOTIONINFO_PROMOTION, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;Nonpromotion&gt;</c> element.</summary>
	/// <param name="Code">The reason the student was not promoted. This element should only be populated if the value of PromotionStatus is "Promoted".</param>
	///<remarks>
	/// <para>This form of <c>setNonpromotion</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Nonpromotion</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetNonpromotion( NCES0673NonpromotionReason Code ) {
		RemoveChild( StudentDTD.PROMOTIONINFO_NONPROMOTION);
		AddChild( StudentDTD.PROMOTIONINFO_NONPROMOTION, new Nonpromotion( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Nonpromotion&gt;</c> element.
	/// </summary>
	/// <value> A Nonpromotion </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "This element is mutually exclusive with Promotion, and its child elements should only be populated if the value of PromotionStatus is "Retained" or "Demoted"."</para>
	/// <para>To remove the <c>Nonpromotion</c>, set <c>Nonpromotion</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public Nonpromotion Nonpromotion
	{
		get
		{
			return (Nonpromotion)GetChild( StudentDTD.PROMOTIONINFO_NONPROMOTION);
		}
		set
		{
			RemoveChild( StudentDTD.PROMOTIONINFO_NONPROMOTION);
			if( value != null)
			{
				AddChild( StudentDTD.PROMOTIONINFO_NONPROMOTION, value );
			}
		}
	}

}}
