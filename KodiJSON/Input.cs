namespace KodiJSON.Input
{
    namespace Methods
    {
        public class Back : MethodBase
        {
            public Back() { }
            public Back(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.Back;
            public Params.BackParams @params = new Params.BackParams();

        }
        public class ContextMenu : MethodBase
        {
            public ContextMenu() { }
            public ContextMenu(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.ContextMenu;
            public Params.ContextMenuParams @params = new Params.ContextMenuParams();

        }
        public class Down : MethodBase
        {
            public Down() { }
            public Down(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.Down;
            public Params.DownParams @params = new Params.DownParams();

        }
        public class ExecuteAction : MethodBase
        {
            public ExecuteAction() { }
            public ExecuteAction(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.ExecuteAction;
            public Params.ExecuteActionParams @params = new Params.ExecuteActionParams();

        }
        public class Home : MethodBase
        {
            public Home() { }
            public Home(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.Home;
            public Params.HomeParams @params = new Params.HomeParams();

        }
        public class Info : MethodBase
        {
            public Info() { }
            public Info(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.Info;
            public Params.InfoParams @params = new Params.InfoParams();

        }
        public class Left : MethodBase
        {
            public Left() { }
            public Left(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.Left;
            public Params.LeftParams @params = new Params.LeftParams();

        }
        public class Right : MethodBase
        {
            public Right() { }
            public Right(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.Right;
            public Params.RightParams @params = new Params.RightParams();

        }
        public class Select : MethodBase
        {
            public Select() { }
            public Select(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.Select;
            public Params.SelectParams @params = new Params.SelectParams();

        }
        public class SendText : MethodBase
        {
            public SendText() { }
            public SendText(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.SendText;
            public Params.SendTextParams @params = new Params.SendTextParams();

        }
        public class ShowCodec : MethodBase
        {
            public ShowCodec() { }
            public ShowCodec(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.ShowCodec;
            public Params.ShowCodecParams @params = new Params.ShowCodecParams();

        }
        public class ShowOSD : MethodBase
        {
            public ShowOSD() { }
            public ShowOSD(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.ShowOSD;
            public Params.ShowOSDParams @params = new Params.ShowOSDParams();

        }
        public class Up : MethodBase
        {
            public Up() { }
            public Up(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Input.Up;
            public Params.UpParams @params = new Params.UpParams();

        }
    }
    namespace Params
    {
        public class BackParams
        {
            public string window;
        }
        public class ContextMenuParams
        {
            public string window;
        }
        public class DownParams
        {
            public string window;
        }
        public class ExecuteActionParams
        {
            public string window;
        }
        public class HomeParams
        {
            public string window;
        }
        public class InfoParams
        {
            public string window;
        }
        public class LeftParams
        {
            public string window;
        }
        public class RightParams
        {
            public string window;
        }
        public class SelectParams
        {
            public string window;
        }
        public class SendTextParams
        {
            public string window;
        }
        public class ShowCodecParams
        {
            public string window;
        }
        public class ShowOSDParams
        {
            public string window;
        }
        public class UpParams
        {
            public string window;
        }
    }
    namespace Response
    {
        public class BackResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ContextMenuResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class DownResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ExecuteActionResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class HomeResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class InfoResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class LeftResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class RightResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SelectResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SendTextResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ShowCodecResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ShowOSDResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class UpResponse : ResponseBase
        {
            public string result { get; set; }
        }
    }
}