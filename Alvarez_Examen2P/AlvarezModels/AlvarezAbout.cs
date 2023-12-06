using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alvarez_Examen2P.AlvarezModels
{
	internal class AlvarezAbout
	{
		public string Title => AppInfo.Name;
		public string Version => AppInfo.VersionString;
		public string MoreInfoUrl => "https://www.youtube.com/watch?v=xm3YgoEiEDc";
		public string Message => "Esta app fue realizada por Guillermo Alvarez en una computadora prestada por que la de el esta descompuesta";
	}
}
