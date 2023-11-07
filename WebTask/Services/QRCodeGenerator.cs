using QRCoder;
using WebTask.Services.Interfaces;

namespace WebTask.Services
{
    public class NUGetQRCodeGenerator : IQRCodeGenerator
    {
        public byte[] Generate(string message)
        {
            var q = new QRCodeGenerator();
            var data = q.CreateQrCode(message, QRCodeGenerator.ECCLevel.Q);
            var png_bytes = new PngByteQRCode(data);
            var bytes = png_bytes.GetGraphic(20);
            return bytes;
        }
    }
}
