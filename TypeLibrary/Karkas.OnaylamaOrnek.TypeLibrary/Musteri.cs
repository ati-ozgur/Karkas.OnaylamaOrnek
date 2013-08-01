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
	[MetadataType(typeof(MusteriValidation))]
	public partial class 	Musteri
	{
	}
	public class 	MusteriValidation
	{
		// Onaylama kodlarının kullanımı için aşağıdaki makaleye bakabilirsiniz
		// http://weblogs.asp.net/scottgu/archive/2010/01/15/asp-net-mvc-2-model-validation.aspx
		// http://weblogs.asp.net/blogs/scottgu/image_5F336E46.png
		// http://msdn.microsoft.com/en-us/library/system.componentmodel.dataannotations.aspx
		// Örnekler)
		// [DataType(DataType.EmailAddress)]
		// public string eposta  { get; set; }
		
		// [DataType(DataType.Url)]
		// public string homePageUrl  { get; set; }
		
		// [Range(18,65,ErrorMessage="18 ve 65 yas aralığındakiler başvurabilir")
		// public int Yasi { get; set; }
		
	}
}
