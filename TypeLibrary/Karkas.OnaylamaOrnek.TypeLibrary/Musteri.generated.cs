using System;
using System.Data;
using System.Text;
using System.Configuration;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections.Generic;
using Karkas.Core.TypeLibrary;
using Karkas.Core.Onaylama;
using Karkas.Core.Onaylama.ForPonos;
using System.ComponentModel.DataAnnotations;

namespace Karkas.OnaylamaOrnek.TypeLibrary
{
	[Serializable]
	[DebuggerDisplay("MusteriKey = {MusteriKey}")]
	public partial class 	Musteri: BaseTypeLibrary
	{
		private long musteriKey;
		private string adi;
		private string soyadi;
		private string eposta;
		private Nullable<long> yasi;
		private string profilePicture;

		[Key]
		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public long MusteriKey
		{
			[DebuggerStepThrough]
			get
			{
				return musteriKey;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (musteriKey!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				musteriKey = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Adi
		{
			[DebuggerStepThrough]
			get
			{
				return adi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (adi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				adi = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Soyadi
		{
			[DebuggerStepThrough]
			get
			{
				return soyadi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (soyadi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				soyadi = value;
			}
		}

		[Required]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string Eposta
		{
			[DebuggerStepThrough]
			get
			{
				return eposta;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (eposta!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				eposta = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Nullable<long> Yasi
		{
			[DebuggerStepThrough]
			get
			{
				return yasi;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (yasi!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				yasi = value;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public string ProfilePicture
		{
			[DebuggerStepThrough]
			get
			{
				return profilePicture;
			}
			[DebuggerStepThrough]
			set
			{
				if ((this.RowState == DataRowState.Unchanged) && (profilePicture!= value))
				{
					this.RowState = DataRowState.Modified;
				}
				profilePicture = value;
			}
		}

		public Musteri ShallowCopy()
		{
			Musteri obj = new Musteri();
			obj.musteriKey = musteriKey;
			obj.adi = adi;
			obj.soyadi = soyadi;
			obj.eposta = eposta;
			obj.yasi = yasi;
			obj.profilePicture = profilePicture;
			return obj;
		}
		
		public class PropertyIsimleri
		{
			public const string MusteriKey = "MusteriKey";
			public const string Adi = "Adi";
			public const string Soyadi = "Soyadi";
			public const string Eposta = "EPosta";
			public const string Yasi = "Yasi";
			public const string ProfilePicture = "ProfilePicture";
		}

	}
}
