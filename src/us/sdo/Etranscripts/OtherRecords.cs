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
using OpenADK.Library.us.Gradebook;
using OpenADK.Library.us.Student;

namespace OpenADK.Library.us.Etranscripts{

/// <summary>An OtherRecords</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class OtherRecords : SifKeyedList<StudentRecordPackageRefId>
{
	/// <summary>
	/// Creates an instance of an OtherRecords
	/// </summary>
	public OtherRecords() : base ( EtranscriptsDTD.OTHERRECORDS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="studentRecordPackageRefId">A StudentRecordPackageRefId</param>
	///
	public OtherRecords( StudentRecordPackageRefId studentRecordPackageRefId ) : base( EtranscriptsDTD.OTHERRECORDS )
	{
		this.SafeAddChild( EtranscriptsDTD.OTHERRECORDS_STUDENTRECORDPACKAGEREFID, studentRecordPackageRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected OtherRecords( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;StudentRecordPackageRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;StudentRecordPackageRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setStudentRecordPackageRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddStudentRecordPackageRefId</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddStudentRecordPackageRefId( string Value ) {
		AddChild( EtranscriptsDTD.OTHERRECORDS_STUDENTRECORDPACKAGEREFID, new StudentRecordPackageRefId( Value ) );
	}

}}
