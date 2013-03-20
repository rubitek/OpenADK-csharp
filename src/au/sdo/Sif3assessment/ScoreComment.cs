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
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Sif3assessment{

/// <summary>A ScoreComment</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class ScoreComment : SifElement
{
	/// <summary>
	/// Creates an instance of a ScoreComment
	/// </summary>
	public ScoreComment() : base ( Sif3assessmentDTD.SCORECOMMENT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="commentCode">A CommentCode</param>
	///<param name="comment">A Comment</param>
	///
	public ScoreComment( string commentCode, AbstractContentElementType comment ) : base( Sif3assessmentDTD.SCORECOMMENT )
	{
		this.CommentCode = commentCode;
		this.Comment = comment;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected ScoreComment( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { Sif3assessmentDTD.SCORECOMMENT_COMMENTCODE, Sif3assessmentDTD.SCORECOMMENT_COMMENT }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CommentCode&gt;</c> element.
	/// </summary>
	/// <value> The <c>CommentCode</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string CommentCode
	{
		get
		{
			return (string) GetSifSimpleFieldValue( Sif3assessmentDTD.SCORECOMMENT_COMMENTCODE ) ;
		}
		set
		{
			SetFieldValue( Sif3assessmentDTD.SCORECOMMENT_COMMENTCODE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Comment&gt;</c> element.
	/// </summary>
	/// <value> An AbstractContentElementType </value>
	/// <remarks>
	/// <para>To remove the <c>AbstractContentElementType</c>, set <c>Comment</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AbstractContentElementType Comment
	{
		get
		{
			return (AbstractContentElementType)GetChild( Sif3assessmentDTD.SCORECOMMENT_COMMENT);
		}
		set
		{
			RemoveChild( Sif3assessmentDTD.SCORECOMMENT_COMMENT);
			if( value != null)
			{
				AddChild( Sif3assessmentDTD.SCORECOMMENT_COMMENT, value );
			}
		}
	}

}}