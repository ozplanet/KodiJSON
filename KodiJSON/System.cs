namespace KodiJSON.System
{
    namespace Methods
    {
        public class EjectOpticalDrive : MethodBase
        {
            public EjectOpticalDrive() { }
            public EjectOpticalDrive(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.System.EjectOpticalDrive;
            public Params.EjectOpticalDriveParams @params = new Params.EjectOpticalDriveParams();

        }
        public class GetProperties : MethodBase
        {
            public GetProperties() { }
            public GetProperties(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.System.GetProperties;
            public Params.GetPropertiesParams @params = new Params.GetPropertiesParams();

        }
        public class Hibernate : MethodBase
        {
            public Hibernate() { }
            public Hibernate(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.System.Hibernate;
            public Params.HibernateParams @params = new Params.HibernateParams();

        }
        public class Reboot : MethodBase
        {
            public Reboot() { }
            public Reboot(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.System.Reboot;
            public Params.RebootParams @params = new Params.RebootParams();

        }
        public class Shutdown : MethodBase
        {
            public Shutdown() { }
            public Shutdown(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.System.Shutdown;
            public Params.ShutdownParams @params = new Params.ShutdownParams();

        }
        public class Suspend : MethodBase
        {
            public Suspend() { }
            public Suspend(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.System.Suspend;
            public Params.SuspendParams @params = new Params.SuspendParams();

        }
    }
    namespace Params
    {
        public class EjectOpticalDriveParams
        {
            public string window;
        }
        public class GetPropertiesParams
        {
            public string window;
        }
        public class HibernateParams
        {
            public string window;
        }
        public class RebootParams
        {
            public string window;
        }
        public class ShutdownParams
        {
            public string window;
        }
        public class SuspendParams
        {
            public string window;
        }
    }
    namespace Response
    {
        public class EjectOpticalDriveResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetPropertiesResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class HibernateResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class RebootResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ShutdownResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SuspendResponse : ResponseBase
        {
            public string result { get; set; }
        }
    }
}