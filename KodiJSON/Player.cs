using System.Collections.Generic;

namespace KodiJSON.Player
{
    namespace Methods
    {
        public class GetActivePlayers : MethodBase
        {
            public GetActivePlayers() { }

            public readonly string method = Global.Methods.Player.GetActivePlayers;

        }
        public class GetItem : MethodBase
        {
            public GetItem() { }
            public GetItem(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.GetItem;
            public Params.GetItemParams @params = new Params.GetItemParams();

        }
        public class GetProperties : MethodBase
        {
            public GetProperties() { }
            public GetProperties(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.GetProperties;
            public Params.GetPropertiesParams @params = new Params.GetPropertiesParams();

        }
        public class GoTo : MethodBase
        {
            public GoTo() { }
            public GoTo(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.GoTo;
            public Params.GoToParams @params = new Params.GoToParams();

        }
        public class Move : MethodBase
        {
            public Move() { }
            public Move(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.Move;
            public Params.MoveParams @params = new Params.MoveParams();

        }
        public class Open : MethodBase
        {
            public Open() { }
            public Open(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.Open;
            public Params.OpenParams @params = new Params.OpenParams();

        }
        public class PlayPause : MethodBase
        {
            public PlayPause() { }
            public PlayPause(int playerid, bool play)
            {
                @params.playerid = playerid;
                @params.play = "toggle";
            }

            public readonly string method = Global.Methods.Player.PlayPause;
            public Params.PlayPauseParams @params = new Params.PlayPauseParams();

        }
        public class Rotate : MethodBase
        {
            public Rotate() { }
            public Rotate(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.Rotate;
            public Params.RotateParams @params = new Params.RotateParams();

        }
        public class Seek : MethodBase
        {
            public Seek() { }
            public Seek(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.Seek;
            public Params.SeekParams @params = new Params.SeekParams();

        }
        public class SetAudioStream : MethodBase
        {
            public SetAudioStream() { }
            public SetAudioStream(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.SetAudioStream;
            public Params.SetAudioStreamParams @params = new Params.SetAudioStreamParams();

        }
        public class SetPartymode : MethodBase
        {
            public SetPartymode() { }
            public SetPartymode(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.SetPartymode;
            public Params.SetPartymodeParams @params = new Params.SetPartymodeParams();

        }
        public class SetRepeat : MethodBase
        {
            public SetRepeat() { }
            public SetRepeat(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.SetRepeat;
            public Params.SetRepeatParams @params = new Params.SetRepeatParams();

        }
        public class SetShuffle : MethodBase
        {
            public SetShuffle() { }
            public SetShuffle(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.SetShuffle;
            public Params.SetShuffleParams @params = new Params.SetShuffleParams();

        }
        public class SetSpeed : MethodBase
        {
            public SetSpeed() { }
            public SetSpeed(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.SetSpeed;
            public Params.SetSpeedParams @params = new Params.SetSpeedParams();

        }
        public class SetSubtitle : MethodBase
        {
            public SetSubtitle() { }
            public SetSubtitle(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.SetSubtitle;
            public Params.SetSubtitleParams @params = new Params.SetSubtitleParams();

        }
        public class Stop : MethodBase
        {
            public Stop() { }
            public Stop(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.Stop;
            public Params.StopParams @params = new Params.StopParams();

        }
        public class Zoom : MethodBase
        {
            public Zoom() { }
            public Zoom(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Player.Zoom;
            public Params.ZoomParams @params = new Params.ZoomParams();

        }
    }
    namespace Params
    {
        public class GetActivePlayersParams
        {
            public string window;
        }
        public class GetItemParams
        {
            public string window;
        }
        public class GetPropertiesParams
        {
            public string window;
        }
        public class GoToParams
        {
            public string window;
        }
        public class MoveParams
        {
            public string window;
        }
        public class OpenParams
        {
            public string window;
        }
        public class PlayPauseParams
        {
            public int playerid;
            public string play;
        }
        public class RotateParams
        {
            public string window;
        }
        public class SeekParams
        {
            public string window;
        }
        public class SetAudioStreamParams
        {
            public string window;
        }
        public class SetPartymodeParams
        {
            public string window;
        }
        public class SetRepeatParams
        {
            public string window;
        }
        public class SetShuffleParams
        {
            public string window;
        }
        public class SetSpeedParams
        {
            public string window;
        }
        public class SetSubtitleParams
        {
            public string window;
        }
        public class StopParams
        {
            public string window;
        }
        public class ZoomParams
        {
            public string window;
        }
    }
    namespace Response
    {
        public class GetActivePlayersResponse : ResponseBase
        {
            public List<Result> result { get; set; }
            public class Result
            {
                public int playerid { get; set; }
                public string type { get; set; }
            }
        }
        public class GetItemResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetPropertiesResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GoToResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class MoveResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class OpenResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class PlayPauseResponse : ResponseBase
        {
            public Result result { get; set; }
            public class Result
            {
                public int speed { get; set; }
            }
        }
        public class RotateResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SeekResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetAudioStreamResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetPartymodeResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetRepeatResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetShuffleResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetSpeedResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetSubtitleResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class StopResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ZoomResponse : ResponseBase
        {
            public string result { get; set; }
        }

    }
}