// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using OpenADK.Library;

namespace OpenADK.Library.au.Student
{
	///<summary>
	/// Defines the set of values that can be specified whenever an AttendanceType
	/// is used as a parameter to a method or constructor. 
	///</summary>
	/// <remarks>
	/// Alternatively, the static
	///  <see cref="Wrap"/> method can be called to encapsulate any string value in
	///  an AttendanceType object.
	/// <para>Author: Generated by adkgen</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	[Serializable]
	public class AttendanceType : SifEnum
	{
	/// <summary>Refusal ("208")</summary>
	public static readonly AttendanceType C208_REFUSAL = new AttendanceType("208");

	/// <summary>Excursion ("604")</summary>
	public static readonly AttendanceType C604_EXCURSION = new AttendanceType("604");

	/// <summary>Other ("999")</summary>
	public static readonly AttendanceType C999_OTHER = new AttendanceType("999");

	/// <summary>Counselling ("203")</summary>
	public static readonly AttendanceType C203_COUNSELLING = new AttendanceType("203");

	/// <summary>Medical ("200")</summary>
	public static readonly AttendanceType C200_MEDICAL = new AttendanceType("200");

	/// <summary>General Absence ("101")</summary>
	public static readonly AttendanceType C101_Absent_General = new AttendanceType("101");

	/// <summary>Sick Bay ("204")</summary>
	public static readonly AttendanceType C204_SICK_BAY = new AttendanceType("204");

	/// <summary>Parental Arrangement ("801")</summary>
	public static readonly AttendanceType C801_PARENTAL_ARRANGEMENT = new AttendanceType("801");

	/// <summary>Exit ("701")</summary>
	public static readonly AttendanceType C701_EXIT = new AttendanceType("701");

	/// <summary>Exempt ("802")</summary>
	public static readonly AttendanceType C802_EXEMPT = new AttendanceType("802");

	/// <summary>Late arrival at School ("111")</summary>
	public static readonly AttendanceType C111_LATE_ARRIVAL_AT_SCHOOL = new AttendanceType("111");

	/// <summary>Late arrival unexplained ("113")</summary>
	public static readonly AttendanceType C113_LATE_ARRIVAL_UNEXPLAINED = new AttendanceType("113");

	/// <summary>Accident ("202")</summary>
	public static readonly AttendanceType C202_ACCIDENT = new AttendanceType("202");

	/// <summary>Medical/Welfare ("210")</summary>
	public static readonly AttendanceType C210_MEDICAL_WELFARE = new AttendanceType("210");

	/// <summary>Parental Acknowledgement ("803")</summary>
	public static readonly AttendanceType C803_PARENTAL_ACKNOWLEDGEMENT = new AttendanceType("803");

	/// <summary>Unexplained ("500")</summary>
	public static readonly AttendanceType C500_UNEXPLAINED = new AttendanceType("500");

	/// <summary>Camp ("606")</summary>
	public static readonly AttendanceType C606_CAMP = new AttendanceType("606");

	/// <summary>Extended Family Holidays ("804")</summary>
	public static readonly AttendanceType C804_EXTENDED_FAMILY_HOLIDAYS = new AttendanceType("804");

	/// <summary>Truancy ("300")</summary>
	public static readonly AttendanceType C300_TRUANCY = new AttendanceType("300");

	/// <summary>Special Event ("605")</summary>
	public static readonly AttendanceType C605_SPECIAL_EVENT = new AttendanceType("605");

	/// <summary>Bereavement ("211")</summary>
	public static readonly AttendanceType C211_BEREAVEMENT = new AttendanceType("211");

	/// <summary>Suspension ("400")</summary>
	public static readonly AttendanceType C400_SUSPENSION = new AttendanceType("400");

	/// <summary>Medical Appointment ("205")</summary>
	public static readonly AttendanceType C205_MEDICAL_APPOINTMENT = new AttendanceType("205");

	/// <summary>Religious/Cultural Observance ("805")</summary>
	public static readonly AttendanceType C805_RELIGIOUS_CULTURAL = new AttendanceType("805");

	/// <summary>Early departure from School ("112")</summary>
	public static readonly AttendanceType C112_EARLY_DEPARTURE_FROM = new AttendanceType("112");

	/// <summary>Parent Choice ("800")</summary>
	public static readonly AttendanceType C800_PARENT_CHOICE = new AttendanceType("800");

	/// <summary>Duty Student ("603")</summary>
	public static readonly AttendanceType C603_DUTY_STUDENT = new AttendanceType("603");

	/// <summary>Educational ("600")</summary>
	public static readonly AttendanceType C600_EDUCATIONAL = new AttendanceType("600");

	/// <summary>Staff Meeting ("904")</summary>
	public static readonly AttendanceType C904_STAFF_MEETING = new AttendanceType("904");

	/// <summary>Late arrival to Class ("116")</summary>
	public static readonly AttendanceType C116_LATE_ARRIVAL_TO_CLASS = new AttendanceType("116");

	/// <summary>Early departure unexplained ("114")</summary>
	public static readonly AttendanceType C114_EARLY_DEPARTURE_UNEXPLAINED = new AttendanceType("114");

	/// <summary>Other Educational Activity ("607")</summary>
	public static readonly AttendanceType C607_OT_EDUCATIONAL_ACTIVITY = new AttendanceType("607");

	/// <summary>Quarantine ("207")</summary>
	public static readonly AttendanceType C207_QUARANTINE = new AttendanceType("207");

	/// <summary>TAFE ("608")</summary>
	public static readonly AttendanceType C608_TAFE = new AttendanceType("608");

	/// <summary>Present ("100")</summary>
	public static readonly AttendanceType C100_PRESENT = new AttendanceType("100");

	/// <summary>Study Leave ("612")</summary>
	public static readonly AttendanceType C612_STUDY_LEAVE = new AttendanceType("612");

	/// <summary>School Production ("610")</summary>
	public static readonly AttendanceType C610_SCHOOL_PRODUCTION = new AttendanceType("610");

	/// <summary>Not Marked ("0")</summary>
	public static readonly AttendanceType C0_NOT_MARKED = new AttendanceType("0");

	/// <summary>Sports ("611")</summary>
	public static readonly AttendanceType C611_SPORTS = new AttendanceType("611");

	/// <summary>Community Service ("602")</summary>
	public static readonly AttendanceType C602_COMMUNITY_SERVICE = new AttendanceType("602");

	/// <summary>Transferred ("702")</summary>
	public static readonly AttendanceType C702_TRANSFERRED = new AttendanceType("702");

	/// <summary>Illness ("201")</summary>
	public static readonly AttendanceType C201_ILLNESS = new AttendanceType("201");

	/// <summary>Hospitalised ("206")</summary>
	public static readonly AttendanceType C206_HOSPITALISED = new AttendanceType("206");

	/// <summary>Flags ("700")</summary>
	public static readonly AttendanceType C700_FLAGS = new AttendanceType("700");

	/// <summary>Weather ("903")</summary>
	public static readonly AttendanceType C903_WEATHER = new AttendanceType("903");

	/// <summary>Suspension - External ("401")</summary>
	public static readonly AttendanceType C401_SUSPENSION_EXTERNAL = new AttendanceType("401");

	/// <summary>Late Class Unexplained  ("118")</summary>
	public static readonly AttendanceType C118_LATE_CLASS_UNEXPLAINED = new AttendanceType("118");

	/// <summary>Group Activity ("601")</summary>
	public static readonly AttendanceType C601_GROUP_ACTIVITY = new AttendanceType("601");

	/// <summary>Early Class Unexplained ("119")</summary>
	public static readonly AttendanceType C119_EARLY_CLASS_UNEXPLAINED = new AttendanceType("119");

	/// <summary>Industrial Action ("901")</summary>
	public static readonly AttendanceType C901_INDUSTRIAL_ACTION = new AttendanceType("901");

	/// <summary>Work Experience ("609")</summary>
	public static readonly AttendanceType C609_WORK_EXPERIENCE = new AttendanceType("609");

	/// <summary>School Choice ("900")</summary>
	public static readonly AttendanceType C900_SCHOOL_CHOICE = new AttendanceType("900");

	/// <summary>Early leaver from Class ("117")</summary>
	public static readonly AttendanceType C117_EARLY_LEAVER_FROM = new AttendanceType("117");

	/// <summary>Facility Damage ("902")</summary>
	public static readonly AttendanceType C902_FACILITY_DAMAGE = new AttendanceType("902");

	/// <summary>Dentist  ("209")</summary>
	public static readonly AttendanceType C209_DENTIST = new AttendanceType("209");

	///<summary>Wrap an arbitrary string value in an AttendanceType object.</summary>
	///<param name="wrappedValue">The element/attribute value.</param>
	///<remarks>This method does not verify
	///that the value is valid according to the SIF Specification</remarks>
	public static AttendanceType Wrap( String wrappedValue ) {
		return new AttendanceType( wrappedValue );
	}

	private AttendanceType( string enumDefValue ) : base( enumDefValue ) {}
	}
}
