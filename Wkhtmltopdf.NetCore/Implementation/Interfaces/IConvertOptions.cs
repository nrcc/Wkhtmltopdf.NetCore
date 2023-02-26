using Wkhtmltopdf.NetCore.Options;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Wkhtmltopdf.NetCore.Implementation.Interfaces
{
    public interface IConvertOptions
    {
        public string GetConvertOptions();
    }
}