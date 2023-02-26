using System.Threading.Tasks;

namespace Wkhtmltopdf.NetCore.Implementation.Interfaces
{
    public interface IGeneratePdf
    {
        void SetConvertOptions(IConvertOptions options);
        byte[] GetPDF(string html);

    }
}