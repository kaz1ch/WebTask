namespace WebTask.Services.Interfaces
{
    public interface IQRCodeGenerator
    {
        public byte[] Generate(string message);
    }
}
