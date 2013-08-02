
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Karkas.Core.DataUtil;
using Karkas.Core.DataUtil.BaseClasses;
using Karkas.OnaylamaOrnek.TypeLibrary;
using Karkas.OnaylamaOrnek.Dal;


namespace Karkas.OnaylamaOrnek.Bs
{
	public partial class MusteriBs : BaseBs<Musteri, MusteriDal>
	{
		public override string DatabaseName
		{
			get
			{
				return "Karkas.Onaylama";
			}
		}
		public void Sil(long pMusteriKey)
		{
			dal.Sil( pMusteriKey);
		}
		public Musteri SorgulaMusteriKeyIle(long p1)
		{
			return dal.SorgulaMusteriKeyIle(p1);
		}
	}
}
