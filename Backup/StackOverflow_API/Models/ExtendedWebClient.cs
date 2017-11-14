using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;

namespace StackOverflow_API.Models
{
    public class ExtendedWebClient:WebClient
    {
        protected override WebRequest GetWebRequest(Uri address)
        {
            HttpWebRequest request =
               base.GetWebRequest(address) as HttpWebRequest;
            request.AutomaticDecompression =
               DecompressionMethods.Deflate | DecompressionMethods.GZip;
            return request;
        }
    }
}