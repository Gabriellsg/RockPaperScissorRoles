using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
	public class Response
	{
		public string Message { get; set; }
		public HttpStatusCode StatusCode { get; set; }
		public Object Data { get; set; }
	}
}
