
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Core.DataUtil.BaseClasses;
using Karkas.OnaylamaOrnek.TypeLibrary;


namespace Karkas.OnaylamaOrnek.Dal
{
public partial class MusteriDal : BaseDal<Musteri>
{
	
	public override string DatabaseName
	{
		get
		{
			return "Karkas.Onaylama";
		}
	}
	protected override void identityKolonDegeriniSetle(Musteri pTypeLibrary,long pIdentityKolonValue)
	{
	}
	protected override string SelectCountString
	{
		get
		{
			return @"SELECT COUNT(*) FROM Musteri";
		}
	}
	protected override string SelectString
	{
		get 
		{
			return @"SELECT MusteriKey,Adi,Soyadi,EPosta,Yasi,ProfilePicture FROM Musteri";
		}
	}
	protected override string DeleteString
	{
		get 
		{
			return @"DELETE   FROM Musteri WHERE MusteriKey = @MusteriKey ";
		}
	}
	protected override string UpdateString
	{
		get 
		{
			return @"UPDATE Musteri
			 SET 
			Adi = @Adi
,Soyadi = @Soyadi
,EPosta = @EPosta
,Yasi = @Yasi
,ProfilePicture = @ProfilePicture
			
			WHERE 
			 MusteriKey = @MusteriKey
 ";
		}
	}
	protected override string InsertString
	{
		get 
		{
			return @"INSERT INTO Musteri 
			 (MusteriKey,Adi,Soyadi,EPosta,Yasi,ProfilePicture) 
			 VALUES 
						(@MusteriKey,@Adi,@Soyadi,@EPosta,@Yasi,@ProfilePicture)";
		}
	}
	public Musteri SorgulaMusteriKeyIle(long p1)
	{
		List<Musteri> liste = new List<Musteri>();
		SorguCalistir(liste,String.Format(" MusteriKey = '{0}'", p1));		
		if (liste.Count > 0)
		{
			return liste[0];
		}
		else
		{
			return null;
		}
	}
	
	protected override bool IdentityVarMi
	{
		get
		{
			return false;
		}
	}
	
	protected override bool PkGuidMi
	{
		get
		{
			return false;
		}
	}
	
	
	public override string PrimaryKey
	{
		get
		{
			return "MusteriKey";
		}
	}
	
	public virtual void Sil(long MusteriKey)
	{
		Musteri satir = new Musteri();
		satir.MusteriKey = MusteriKey;
		base.Sil(satir);
	}
	protected override void ProcessRow(IDataReader dr, Musteri satir)
	{
		satir.MusteriKey = dr.GetInt64(0);
		satir.Adi = dr.GetString(1);
		satir.Soyadi = dr.GetString(2);
		satir.Eposta = dr.GetString(3);
		if (!dr.IsDBNull(4))
		{
			satir.Yasi = dr.GetInt64(4);
		}
		if (!dr.IsDBNull(5))
		{
			satir.ProfilePicture = dr.GetString(5);
		}
	}
	protected override void InsertCommandParametersAdd(DbCommand cmd, Musteri satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@MusteriKey",DbType.Int64, satir.MusteriKey);
		builder.parameterEkle("@Adi",DbType.String, satir.Adi);
		builder.parameterEkle("@Soyadi",DbType.String, satir.Soyadi);
		builder.parameterEkle("@EPosta",DbType.String, satir.Eposta);
		builder.parameterEkle("@Yasi",DbType.Int64, satir.Yasi);
		builder.parameterEkle("@ProfilePicture",DbType.String, satir.ProfilePicture);
	}
	protected override void UpdateCommandParametersAdd(DbCommand cmd, 	Musteri	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@MusteriKey",DbType.Int64, satir.MusteriKey);
		builder.parameterEkle("@Adi",DbType.String, satir.Adi);
		builder.parameterEkle("@Soyadi",DbType.String, satir.Soyadi);
		builder.parameterEkle("@EPosta",DbType.String, satir.Eposta);
		builder.parameterEkle("@Yasi",DbType.Int64, satir.Yasi);
		builder.parameterEkle("@ProfilePicture",DbType.String, satir.ProfilePicture);
	}
	protected override void DeleteCommandParametersAdd(DbCommand cmd, 	Musteri	 satir)
	{
		ParameterBuilder builder = Template.getParameterBuilder();
		builder.Command = cmd;
		builder.parameterEkle("@MusteriKey",DbType.Int64, satir.MusteriKey);
	}
	public override string DbProviderName
	{
		get
		{
			return "System.Data.SQLite";
		}
	}
}
}
