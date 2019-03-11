/// <summary>
/// Complete
/// </summary>
namespace KodiJSON.Application
{
    namespace Methods
    {
        public class GetProperties : MethodBase
        {
            public GetProperties() { }
            public GetProperties(string[] properties)
            {
                @params.properties = properties;
            }

            public readonly string method = Global.Methods.Application.GetProperties;
            public Params.GetPropertiesParams @params = new Params.GetPropertiesParams();

        }
        public class Quit : MethodBase
        {
            public Quit() { }

            public readonly string method = Global.Methods.Application.Quit;

        }
        public class SetMute : MethodBase
        {
            public SetMute() { }
            public SetMute(bool mute)
            {
                @params.mute = mute;
            }

            public readonly string method = Global.Methods.Application.SetMute;
            public Params.SetMuteParams @params = new Params.SetMuteParams();

        }
        public class SetVolume : MethodBase
        {
            public SetVolume() { }
            public SetVolume(int volume)
            {
                @params.volume = volume;
            }

            public readonly string method = Global.Methods.Application.SetVolume;
            public Params.SetVolumeParams @params = new Params.SetVolumeParams();

        }
    }
    namespace Params
    {
        public class GetPropertiesParams
        {
            public string[] properties = { Global.Application.Property.Name.Muted,
                                       Global.Application.Property.Name.Named,
                                       Global.Application.Property.Name.Version,
                                       Global.Application.Property.Name.Volume };
        }
        public class SetMuteParams
        {
            public bool mute;
        }
        public class SetVolumeParams
        {
            public int volume;
        }
        public class QuitParams
        {
        }
    }
    namespace Response
    {
        public class GetPropertiesResponse : ResponseBase
        {
            public Result result { get; set; }

            public class Version
            {
                public int major { get; set; }
                public int minor { get; set; }
                public string revision { get; set; }
                public string tag { get; set; }
            }

            public class Result
            {
                public bool muted { get; set; }
                public string name { get; set; }
                public Version version { get; set; }
                public int volume { get; set; }
            }
        }
        public class QuitResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetMuteResponse : ResponseBase
        {
            public bool result { get; set; }
        }
        public class SetVolumeResponse : ResponseBase
        {
            public int result { get; set; }
        }
    }
}