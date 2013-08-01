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

namespace Karkas.OnaylamaOrnek.TypeLibrary.
{
	[Serializable]
	[DebuggerDisplay("MusteriKey = {MusteriKey}")]
	public partial class 	Musteri: BaseTypeLibrary
	{
		private long musteriKey;
		private Unknown adi;
		private Unknown soyadi;
		private Unknown eposta;
		private Nullable<long> yasi;
		private Unknown profilePicture;

		[Key]
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

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Unknown Adi
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

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Unknown Soyadi
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

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Unknown Eposta
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
		public Unknown ProfilePicture
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

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string MusteriKeyAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return musteriKey.ToString(); 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					long _a = Convert.ToInt64(value);
				MusteriKey = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"MusteriKey",string.Format(CEVIRI_YAZISI,"MusteriKey","long")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string AdiAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return adi != null ? adi.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("string'ten degisken tipine cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string SoyadiAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return soyadi != null ? soyadi.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("string'ten degisken tipine cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string EpostaAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return eposta != null ? eposta.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("string'ten degisken tipine cevirim desteklenmemektedir");
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string YasiAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return yasi != null ? yasi.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				try
				{
					long _a = Convert.ToInt64(value);
				Yasi = _a;
				}
				catch(Exception)
				{
					this.Onaylayici.OnaylayiciListesi.Add(new DaimaBasarisiz(this,"Yasi",string.Format(CEVIRI_YAZISI,"Yasi","long")));
				}
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[XmlIgnore, SoapIgnore]
		[ScaffoldColumn(false)]
		public string ProfilePictureAsString
		{
			[DebuggerStepThrough]
			get
			{
				 return profilePicture != null ? profilePicture.ToString() : ""; 
			}
			[DebuggerStepThrough]
			set
			{
				throw new ArgumentException("string'ten degisken tipine cevirim desteklenmemektedir");
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
		
		protected override void OnaylamaListesiniOlusturCodeGeneration()
		{
			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Adi"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Soyadi"));			
			this.Onaylayici.OnaylayiciListesi.Add(new GerekliAlanOnaylayici(this, "Eposta"));		}
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
