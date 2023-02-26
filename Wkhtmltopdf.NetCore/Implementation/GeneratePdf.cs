using System;
using System.IO;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore.Implementation.Interfaces;

namespace Wkhtmltopdf.NetCore.Implementation
{
    public class GeneratePdf : IGeneratePdf
    {
        protected IConvertOptions _convertOptions;


        public GeneratePdf()
        {
            _convertOptions = new ConvertOptions();
        }

        public void SetConvertOptions(IConvertOptions convertOptions)
        {
            _convertOptions = convertOptions;
        }

        public byte[] GetPDF(string html)
        {
            return WkhtmlDriver.Convert(WkhtmltopdfConfiguration.RotativaPath, _convertOptions.GetConvertOptions(), html);
        }
    }
}