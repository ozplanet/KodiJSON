namespace KodiJSON.Kodi
{
    namespace Methods
    {
        public class GetInfoBooleans : MethodBase
        {
            public GetInfoBooleans() { }
            public GetInfoBooleans(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.XBMC.GetInfoBooleans;
            public Params.GetInfoBooleansParams @params = new Params.GetInfoBooleansParams();

        }
        public class GetInfoLabels : MethodBase
        {
            public GetInfoLabels() { }
            public GetInfoLabels(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.XBMC.GetInfoLabels;
            public Params.GetInfoLabelsParams @params = new Params.GetInfoLabelsParams();

        }
    }
    namespace Params
    {
        public class GetInfoBooleansParams
        {
            public string window;
        }
        public class GetInfoLabelsParams
        {
            public string window;
        }
    }
    namespace Response
    {
        public class GetInfoBooleansResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetInfoLabelsResponse : ResponseBase
        {
            public string result { get; set; }
        }
    }
}