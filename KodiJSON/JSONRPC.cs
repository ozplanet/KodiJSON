namespace KodiJSON.JSONRPC
{
    namespace Methods
    {
        public class GetConfiguration : MethodBase
        {
            public GetConfiguration() { }
            public GetConfiguration(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.JSONRPC.GetConfiguration;
            public Params.GetConfigurationParams @params = new Params.GetConfigurationParams();

        }
        public class Introspect : MethodBase
        {
            public Introspect() { }
            public Introspect(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.JSONRPC.Introspect;
            public Params.IntrospectParams @params = new Params.IntrospectParams();

        }
        public class NotifyAll : MethodBase
        {
            public NotifyAll() { }
            public NotifyAll(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.JSONRPC.NotifyAll;
            public Params.NotifyAllParams @params = new Params.NotifyAllParams();

        }
        public class Permission : MethodBase
        {
            public Permission() { }
            public Permission(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.JSONRPC.Permission;
            public Params.PermissionParams @params = new Params.PermissionParams();

        }
        public class Ping : MethodBase
        {
            public Ping() { }
            public Ping(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.JSONRPC.Ping;
            public Params.PingParams @params = new Params.PingParams();

        }
        public class SetConfiguration : MethodBase
        {
            public SetConfiguration() { }
            public SetConfiguration(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.JSONRPC.SetConfiguration;
            public Params.SetConfigurationParams @params = new Params.SetConfigurationParams();

        }
        public class Version : MethodBase
        {
            public Version() { }
            public Version(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.JSONRPC.Version;
            public Params.VersionParams @params = new Params.VersionParams();

        }
    }
    namespace Params
    {
        public class GetConfigurationParams
        {
            public string window;
        }
        public class IntrospectParams
        {
            public string window;
        }
        public class NotifyAllParams
        {
            public string window;
        }
        public class PermissionParams
        {
            public string window;
        }
        public class PingParams
        {
            public string window;
        }
        public class SetConfigurationParams
        {
            public string window;
        }
        public class VersionParams
        {
            public string window;
        }
    }
    namespace Response
    {
        public class GetConfigurationResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class IntrospectResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class NotifyAllResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class PermissionResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class PingResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetConfigurationResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class VersionResponse : ResponseBase
        {
            public string result { get; set; }
        }
    }
}