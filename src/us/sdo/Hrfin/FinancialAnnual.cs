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

namespace OpenADK.Library.us.Hrfin{

/// <summary>This object contains information about account code annual financial totals, summarized by major and/or minor account code breaks.  SIF_Events are not reported.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class FinancialAnnual : SifDataObject
{
	/// <summary>
	/// Creates an instance of a FinancialAnnual
	/// </summary>
	public FinancialAnnual() : base( Adk.SifVersion, HrfinDTD.FINANCIALANNUAL ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="reportDate">Date on which snapshot was generated.</param>
	///<param name="stateProvinceId">State assigned reporting ID for district or agency</param>
	///<param name="fiscalYear">Fiscal year of summary account</param>
	///<param name="annualItems">Contains information about the item being summarized.</param>
	///
	public FinancialAnnual( DateTime? reportDate, string stateProvinceId, int? fiscalYear, AnnualItems annualItems ) : base( Adk.SifVersion, HrfinDTD.FINANCIALANNUAL )
	{
		this.ReportDate = reportDate;
		this.StateProvinceId = stateProvinceId;
		this.FiscalYear = fiscalYear;
		this.AnnualItems = annualItems;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FinancialAnnual( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { HrfinDTD.FINANCIALANNUAL_REPORTDATE, HrfinDTD.FINANCIALANNUAL_STATEPROVINCEID, HrfinDTD.FINANCIALANNUAL_FISCALYEAR, HrfinDTD.FINANCIALANNUAL_ANNUALITEMS }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReportDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ReportDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Date on which snapshot was generated."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? ReportDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( HrfinDTD.FINANCIALANNUAL_REPORTDATE ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALANNUAL_REPORTDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StateProvinceId&gt;</c> element.
	/// </summary>
	/// <value> The <c>StateProvinceId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "State assigned reporting ID for district or agency"</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;StateProvinceId&gt;</description></item>
	/// </list>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string StateProvinceId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.FINANCIALANNUAL_STATEPROVINCEID ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALANNUAL_STATEPROVINCEID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FiscalYear&gt;</c> element.
	/// </summary>
	/// <value> The <c>FiscalYear</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Fiscal year of summary account"</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;FiscalYear&gt;</description></item>
	/// </list>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public int? FiscalYear
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( HrfinDTD.FINANCIALANNUAL_FISCALYEAR ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALANNUAL_FISCALYEAR, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AnnualItems&gt;</c> element.
	/// </summary>
	/// <value> An AnnualItems </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Contains information about the item being summarized."</para>
	/// <para>To remove the <c>AnnualItems</c>, set <c>AnnualItems</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public AnnualItems AnnualItems
	{
		get
		{
			return (AnnualItems)GetChild( HrfinDTD.FINANCIALANNUAL_ANNUALITEMS);
		}
		set
		{
			RemoveChild( HrfinDTD.FINANCIALANNUAL_ANNUALITEMS);
			if( value != null)
			{
				AddChild( HrfinDTD.FINANCIALANNUAL_ANNUALITEMS, value );
			}
		}
	}

}}
