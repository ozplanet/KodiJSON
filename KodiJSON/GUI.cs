using System.Collections.Generic;
/// <summary>
/// Complete
/// </summary>
namespace KodiJSON.GUI
{
    namespace Methods
    {
        public class ActivateWindow : MethodBase
        {
            public ActivateWindow() { }
            public ActivateWindow(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.GUI.ActivateWindow;
            public Params.ActivateWindowParams @params = new Params.ActivateWindowParams();

        }
        public class GetProperties : MethodBase
        {
            public GetProperties() { }
            public GetProperties(string[] properties)
            {
                @params.properties = properties;
            }

            public readonly string method = Global.Methods.GUI.GetProperties;
            public Params.GetPropertiesParams @params = new Params.GetPropertiesParams();

        }
        public class GetStereoscopicModes : MethodBase
        {
            public GetStereoscopicModes() { }

            public readonly string method = Global.Methods.GUI.GetStereoscopicModes;
            public Params.GetStereoscopicModesParams @params = new Params.GetStereoscopicModesParams();

        }
        public class SetFullscreen : MethodBase
        {

            public readonly string method = Global.Methods.GUI.SetFullscreen;
            public Params.SetFullscreenParams @params = new Params.SetFullscreenParams();

        }
        public class SetStereoscopicMode : MethodBase
        {
            public SetStereoscopicMode() { }
            public SetStereoscopicMode(string mode)
            {
                @params.mode = mode;
            }

            public readonly string method = Global.Methods.GUI.SetStereoscopicMode;
            public Params.SetStereoscopicModeParams @params = new Params.SetStereoscopicModeParams();

        }
        public class ShowNotification : MethodBase
        {
            public ShowNotification() { }
            public ShowNotification(string title, string message, string image)
            {
                @params.title = title;
                @params.message = message;
                @params.image = image;
            }
            public ShowNotification(string title, string message, Params.ShowNotificationParams.images image)
            {
                @params.title = title;
                @params.message = message;
                @params.image = image.ToString();
            }

            public readonly string method = Global.Methods.GUI.ShowNotification;
            public Params.ShowNotificationParams @params = new Params.ShowNotificationParams();

        }
    }
    namespace Params
    {
        public class ActivateWindowParams
        {
            public string window;            
        }
        public class GetPropertiesParams
        {
            public string[] properties = { Global.GUI.Property.Name.currentcontrol,
                                           Global.GUI.Property.Name.currentwindow,
                                           Global.GUI.Property.Name.fullscreen,
                                           Global.GUI.Property.Name.skin,
                                           Global.GUI.Property.Name.stereoscopicmode };
        }
        public class GetStereoscopicModesParams
        {
        }
        public class SetFullscreenParams
        {
            public readonly string fullscreen = "toggle";
        }
        public class SetStereoscopicModeParams
        {
            public string mode;
        }
        public class ShowNotificationParams
        {
            public string title;
            public string message;
            public string image;
            public int displaytime = 5000;
            public struct images
            {
                public static string info = "info";
                public static string error = "error";
                public static string warning = "warning";
            }
        }

    }
    namespace Response
    {
        public class ActivateWindowResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetPropertiesResponse : ResponseBase
        {
            public Result result { get; set; }

            public class Currentcontrol
            {
                public string label { get; set; }
            }

            public class Currentwindow
            {
                public int id { get; set; }
                public string label { get; set; }
            }

            public class Skin
            {
                public string id { get; set; }
                public string name { get; set; }
            }

            public class Stereoscopicmode
            {
                public string label { get; set; }
                public string mode { get; set; }
            }

            public class Result
            {
                public Currentcontrol currentcontrol { get; set; }
                public Currentwindow currentwindow { get; set; }
                public bool fullscreen { get; set; }
                public Skin skin { get; set; }
                public Stereoscopicmode stereoscopicmode { get; set; }
            }

        }
        public class GetStereoscopicModesResponse : ResponseBase
        {
            public Result result { get; set; }
            public class Stereoscopicmode
            {
                public string label { get; set; }
                public string mode { get; set; }
            }
            public class Result
            {
                public List<Stereoscopicmode> stereoscopicmodes { get; set; }
            }
        }
        public class SetFullscreenResponse : ResponseBase
        {
            public bool result { get; set; }
        }
        public class SetStereoscopicModeResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ShowNotificationResponse : ResponseBase
        {
            public string result { get; set; }
        }
    }
}

