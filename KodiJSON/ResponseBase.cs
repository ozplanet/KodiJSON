namespace KodiJSON
{
    public class ResponseBase
    {
        public readonly string jsonrpc = Global.Application.jsonrpc;
        public int id = Global.Application.id;
    }
}
