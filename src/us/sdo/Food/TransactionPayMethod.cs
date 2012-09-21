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

namespace OpenADK.Library.us.Food{

/// <summary>Transaction method</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class TransactionPayMethod : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a TransactionPayMethod
	/// </summary>
	public TransactionPayMethod() : base ( FoodDTD.TRANSACTIONPAYMETHOD ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="type">This refers to the way the payment was made.</param>
	///<param name="amounts">AmountThis amount is the form of the incoming funds for this transaction. For example; the payment can be made by a credit card.</param>
	///
	public TransactionPayMethod( TransactionPayMethodType type, FSAmounts amounts ) : base( FoodDTD.TRANSACTIONPAYMETHOD )
	{
		this.SetType( type );
		this.AddAmounts( amounts );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected TransactionPayMethod( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { FoodDTD.TRANSACTIONPAYMETHOD_TYPE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <value> The <c>Type</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "This refers to the way the payment was made."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Type
	{
		get
		{ 
			return GetFieldValue( FoodDTD.TRANSACTIONPAYMETHOD_TYPE );
		}
		set
		{
			SetField( FoodDTD.TRANSACTIONPAYMETHOD_TYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>Type</c> attribute.
	/// </summary>
	/// <param name="val">A TransactionPayMethodType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "This refers to the way the payment was made."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetType( TransactionPayMethodType val )
	{
		SetField( FoodDTD.TRANSACTIONPAYMETHOD_TYPE, val );
	}

	/// <summary>Adds a new <c>&lt;Amounts&gt;</c> child element.</summary>
	/// <param name="val">A FSAmounts object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "AmountThis amount is the form of the incoming funds for this transaction. For example; the payment can be made by a credit card."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void AddAmounts( FSAmounts val ) { 
		AddChild( FoodDTD.TRANSACTIONPAYMETHOD_AMOUNTS, val );
	}

	/// <summary>
	/// Gets all FSAmounts object instances. More than once instance can be defined for this object because it is a repeatable field element.
	/// </summary>
	/// <returns>An array of FSAmounts objects</returns>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public FSAmounts[] GetAmountses()
	{
		return GetChildren<FSAmounts>().ToArray();
	}

	/// <summary>
	/// Sets all FSAmounts object instances. All existing 
	/// <c>FSAmounts</c> instances 
	/// are removed and replaced with this list. Calling this method with the 
	/// parameter value set to null removes all <c>FSAmountses</c>.
	/// </summary>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void SetAmountses( FSAmounts[] items)
	{
		SetChildren( FoodDTD.TRANSACTIONPAYMETHOD_AMOUNTS, items );
	}

}}