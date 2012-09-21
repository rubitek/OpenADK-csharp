// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.us.Student
{
	///<summary>
	/// Defines the set of values that can be specified whenever an EducationAgencyTypeCode
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an EducationAgencyTypeCode object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	[Serializable]
	public class EducationAgencyTypeCode : SifEnum
	{
	/// <summary>Federal school district ("3491")</summary>
	public static readonly EducationAgencyTypeCode C1151_3491_FEDERAL_SCHOOL_DISTRICT = new EducationAgencyTypeCode("3491");

	/// <summary>Other ("9999")</summary>
	public static readonly EducationAgencyTypeCode C1151_9999_OTHER = new EducationAgencyTypeCode("9999");

	/// <summary>State agency charged with providing elementary and/or secondary level instruction to school-age children in a specified population, e.g., agency responsible for state schools for blind or deaf students, correctional facilities, and state hospitals. ("5")</summary>
	public static readonly EducationAgencyTypeCode STATE_AGENCY = new EducationAgencyTypeCode("5");

	/// <summary>Regional education service agency (RESA) ("3489")</summary>
	public static readonly EducationAgencyTypeCode C1151_3489_RESA = new EducationAgencyTypeCode("3489");

	/// <summary>State school district ("3490")</summary>
	public static readonly EducationAgencyTypeCode C1151_3490_STATE_SCHOOL_DISTRICT = new EducationAgencyTypeCode("3490");

	/// <summary>School district that is a component of a supervisory union ("3487")</summary>
	public static readonly EducationAgencyTypeCode C1151_3487_SCHOOL_DISTRICT_UNION = new EducationAgencyTypeCode("3487");

	/// <summary>Supervisory Union ("3488")</summary>
	public static readonly EducationAgencyTypeCode C1151_3488_SUPERVISORY_UNION = new EducationAgencyTypeCode("3488");

	/// <summary>Federal agency charged with providing elementary and/or secondary level instruction to school-age children in a specified population. ("6")</summary>
	public static readonly EducationAgencyTypeCode FEDERAL_AGENCY = new EducationAgencyTypeCode("6");

	/// <summary>Regular school district ("3486")</summary>
	public static readonly EducationAgencyTypeCode C1151_3486_REGULAR_SCHOOL_DISTRICT = new EducationAgencyTypeCode("3486");

	/// <summary>Other education agencies that do not fit into the first six categories. ("7")</summary>
	public static readonly EducationAgencyTypeCode OTHER_AGENCY = new EducationAgencyTypeCode("7");

	/// <summary>Supervisory union administrative center, or county superintendent’s office serving the same purposes. Each agency given this code should have an entry in the Supervisory Union Identification Number data field. Student and staff data reported elsewhere should NOT be duplicated in records carrying this code. ("3")</summary>
	public static readonly EducationAgencyTypeCode SUPERVISORY_UNION = new EducationAgencyTypeCode("3");

	/// <summary>Local school district that is a component of a supervisory union. A superintendent and administrative services are shared with other local school districts. Each agency given this code should have an entry in the Supervisory Union Identification Number field corresponding to the appropriate type 3 or type 4 agency. Non-ops in supervisory unions should be included in this category. ("2")</summary>
	public static readonly EducationAgencyTypeCode SUPERVISED_DISTRICT = new EducationAgencyTypeCode("2");

	/// <summary>Regional education services agency (RESA). Agencies created for the purposes of providing specialized educational services to other education agencies. Student and staff data reported elsewhere should NOT be duplicated in records carrying this code. ("4")</summary>
	public static readonly EducationAgencyTypeCode REGIONAL_AGENCY = new EducationAgencyTypeCode("4");

	/// <summary>Regular local school district that is not a component of a supervisory union. This category includes both independent school districts and those that are a dependent segment of a local government such as a city or county. INCLUDE agencies that do not operate schools (non-ops) but have primary responsibility to provide free public elementary and/or secondary education to school-age children within their jurisdictions. ("1")</summary>
	public static readonly EducationAgencyTypeCode REG_DISTRICT = new EducationAgencyTypeCode("1");

	///<summary>Wrap an arbitrary string value in an EducationAgencyTypeCode object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static EducationAgencyTypeCode Wrap( String wrappedValue ) {
		return new EducationAgencyTypeCode( wrappedValue );
	}

	private EducationAgencyTypeCode( string enumDefValue ) : base( enumDefValue ) {}
	}
}