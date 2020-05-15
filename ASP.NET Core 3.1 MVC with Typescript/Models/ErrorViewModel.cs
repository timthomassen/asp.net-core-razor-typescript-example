using System;

namespace ASP.NET_Core_3._1_MVC_with_Typescript.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
