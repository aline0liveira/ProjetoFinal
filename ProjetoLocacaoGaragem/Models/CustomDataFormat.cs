using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoLocacaoGaragem.Models
{
    public class CustomDataFormat : IsoDateTimeConverter
    {

        public CustomDataFormat()
        {
            base.DateTimeFormat = "dd/MM/yyyy HH:mm:ss";
        }
    }
}