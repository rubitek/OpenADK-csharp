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

namespace OpenADK.Library.us.Common{

/// <summary>A StudentParticipationDataElement</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class StudentParticipationDataElement : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a StudentParticipationDataElement
	/// </summary>
	public StudentParticipationDataElement() : base ( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="programType">A ProgramType</param>
	///
	public StudentParticipationDataElement( ProgramType programType ) : base( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT )
	{
		this.ProgramType = programType;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentParticipationDataElement( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMTYPE }; }
	}

	///<summary>Sets the value of the <c>&lt;ProgramType&gt;</c> element.</summary>
	/// <param name="Code">The type of the program. Type identifies the list of values.</param>
	///<remarks>
	/// <para>This form of <c>setProgramType</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ProgramType</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetProgramType( StudentFamilyProgramType Code ) {
		RemoveChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMTYPE);
		AddChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMTYPE, new ProgramType( Code ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ProgramType&gt;</c> element.
	/// </summary>
	/// <value> A ProgramType </value>
	/// <remarks>
	/// <para>To remove the <c>ProgramType</c>, set <c>ProgramType</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public ProgramType ProgramType
	{
		get
		{
			return (ProgramType)GetChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMTYPE);
		}
		set
		{
			RemoveChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMTYPE);
			if( value != null)
			{
				AddChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMTYPE, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ProgramFundingSources&gt;</c> element.
	/// </summary>
	/// <value> A ProgramFundingSources </value>
	/// <remarks>
	/// <para>To remove the <c>ProgramFundingSources</c>, set <c>ProgramFundingSources</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public ProgramFundingSources ProgramFundingSources
	{
		get
		{
			return (ProgramFundingSources)GetChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMFUNDINGSOURCES);
		}
		set
		{
			RemoveChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMFUNDINGSOURCES);
			if( value != null)
			{
				AddChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMFUNDINGSOURCES, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;ManagingPublicAgency&gt;</c> element.</summary>
	/// <param name="SifRefObject">A SIF_RefObject</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;ManagingPublicAgency&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setManagingPublicAgency</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ManagingPublicAgency</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetManagingPublicAgency( string SifRefObject, string Value ) {
		RemoveChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_MANAGINGPUBLICAGENCY);
		AddChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_MANAGINGPUBLICAGENCY, new ManagingPublicAgency( SifRefObject, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ManagingPublicAgency&gt;</c> element.
	/// </summary>
	/// <value> A ManagingPublicAgency </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The GUID of the public agency (a district / LEA) to which the "ManagingSchool" reports / belongs."</para>
	/// <para>To remove the <c>ManagingPublicAgency</c>, set <c>ManagingPublicAgency</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public ManagingPublicAgency ManagingPublicAgency
	{
		get
		{
			return (ManagingPublicAgency)GetChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_MANAGINGPUBLICAGENCY);
		}
		set
		{
			RemoveChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_MANAGINGPUBLICAGENCY);
			if( value != null)
			{
				AddChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_MANAGINGPUBLICAGENCY, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;ManagingSchool&gt;</c> element.</summary>
	/// <param name="SifRefObject">A SIF_RefObject</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;ManagingSchool&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setManagingSchool</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>ManagingSchool</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetManagingSchool( string SifRefObject, string Value ) {
		RemoveChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_MANAGINGSCHOOL);
		AddChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_MANAGINGSCHOOL, new ManagingSchool( SifRefObject, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ManagingSchool&gt;</c> element.
	/// </summary>
	/// <value> A ManagingSchool </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The GUID of the school responsible for coordinating the student's program participation."</para>
	/// <para>To remove the <c>ManagingSchool</c>, set <c>ManagingSchool</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public ManagingSchool ManagingSchool
	{
		get
		{
			return (ManagingSchool)GetChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_MANAGINGSCHOOL);
		}
		set
		{
			RemoveChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_MANAGINGSCHOOL);
			if( value != null)
			{
				AddChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_MANAGINGSCHOOL, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReferralDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ReferralDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? ReferralDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_REFERRALDATE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_REFERRALDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ProgramStatus&gt;</c> element.
	/// </summary>
	/// <value> A ProgramStatus </value>
	/// <remarks>
	/// <para>To remove the <c>ProgramStatus</c>, set <c>ProgramStatus</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public ProgramStatus ProgramStatus
	{
		get
		{
			return (ProgramStatus)GetChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMSTATUS);
		}
		set
		{
			RemoveChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMSTATUS);
			if( value != null)
			{
				AddChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMSTATUS, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;GiftedEligibilityCriteria&gt;</c> element.
	/// </summary>
	/// <value> The <c>GiftedEligibilityCriteria</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "State / local code used to determine eligibility for Gifted / Talented program."</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string GiftedEligibilityCriteria
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_GIFTEDELIGIBILITYCRITERIA ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_GIFTEDELIGIBILITYCRITERIA, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EvaluationDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EvaluationDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? EvaluationDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_EVALUATIONDATE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_EVALUATIONDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ReevaluationDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ReevaluationDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? ReevaluationDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_REEVALUATIONDATE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_REEVALUATIONDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ExceptionalityCategories&gt;</c> element.
	/// </summary>
	/// <value> An ExceptionalityCategories </value>
	/// <remarks>
	/// <para>To remove the <c>ExceptionalityCategories</c>, set <c>ExceptionalityCategories</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public ExceptionalityCategories ExceptionalityCategories
	{
		get
		{
			return (ExceptionalityCategories)GetChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_EXCEPTIONALITYCATEGORIES);
		}
		set
		{
			RemoveChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_EXCEPTIONALITYCATEGORIES);
			if( value != null)
			{
				AddChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_EXCEPTIONALITYCATEGORIES, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ProgramPlanDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ProgramPlanDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? ProgramPlanDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMPLANDATE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMPLANDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ProgramPlanEffectiveDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ProgramPlanEffectiveDate</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public DateTime? ProgramPlanEffectiveDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMPLANEFFECTIVEDATE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PROGRAMPLANEFFECTIVEDATE, new SifDate( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;PlannedAssessmentParticipation&gt;</c> element.</summary>
	/// <param name="Codeset">Identifies source of value provided.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;PlannedAssessmentParticipation&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setPlannedAssessmentParticipation</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PlannedAssessmentParticipation</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetPlannedAssessmentParticipation( Codeset Codeset, string Value ) {
		RemoveChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PLANNEDASSESSMENTPARTICIPATION);
		AddChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PLANNEDASSESSMENTPARTICIPATION, new PlannedAssessmentParticipation( Codeset, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PlannedAssessmentParticipation&gt;</c> element.
	/// </summary>
	/// <value> A PlannedAssessmentParticipation </value>
	/// <remarks>
	/// <para>To remove the <c>PlannedAssessmentParticipation</c>, set <c>PlannedAssessmentParticipation</c> to <c>null</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public PlannedAssessmentParticipation PlannedAssessmentParticipation
	{
		get
		{
			return (PlannedAssessmentParticipation)GetChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PLANNEDASSESSMENTPARTICIPATION);
		}
		set
		{
			RemoveChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PLANNEDASSESSMENTPARTICIPATION);
			if( value != null)
			{
				AddChild( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_PLANNEDASSESSMENTPARTICIPATION, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;DaysInParticipation&gt;</c> element.
	/// </summary>
	/// <value> The <c>DaysInParticipation</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public int? DaysInParticipation
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_DAYSINPARTICIPATION ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.STUDENTPARTICIPATIONDATAELEMENT_DAYSINPARTICIPATION, new SifInt( value ), value );
		}
	}

}}
