namespace KodiJSON.Playlist
{
    namespace Methods
    {
        public class Add : MethodBase
        {
            public Add() { }
            public Add(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Playlist.Add;
            public Params.AddParams @params = new Params.AddParams();

        }
        public class Clear : MethodBase
        {
            public Clear() { }
            public Clear(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Playlist.Clear;
            public Params.ClearParams @params = new Params.ClearParams();

        }
        public class GetItems : MethodBase
        {
            public GetItems() { }
            public GetItems(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Playlist.GetItems;
            public Params.GetItemsParams @params = new Params.GetItemsParams();

        }
        public class GetPlaylists : MethodBase
        {
            public GetPlaylists() { }
            public GetPlaylists(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Playlist.GetPlaylists;
            public Params.GetPlaylistsParams @params = new Params.GetPlaylistsParams();

        }
        public class GetProperties : MethodBase
        {
            public GetProperties() { }
            public GetProperties(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Playlist.GetProperties;
            public Params.GetPropertiesParams @params = new Params.GetPropertiesParams();

        }
        public class Insert : MethodBase
        {
            public Insert() { }
            public Insert(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Playlist.Insert;
            public Params.InsertParams @params = new Params.InsertParams();

        }
        public class Remove : MethodBase
        {
            public Remove() { }
            public Remove(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Playlist.Remove;
            public Params.RemoveParams @params = new Params.RemoveParams();

        }
        public class Swap : MethodBase
        {
            public Swap() { }
            public Swap(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Playlist.Swap;
            public Params.SwapParams @params = new Params.SwapParams();

        }
    }
    namespace Params
    {
        public class AddParams
        {
            public string window;
        }
        public class ClearParams
        {
            public string window;
        }
        public class GetItemsParams
        {
            public string window;
        }
        public class GetPlaylistsParams
        {
            public string window;
        }
        public class GetPropertiesParams
        {
            public string window;
        }
        public class InsertParams
        {
            public string window;
        }
        public class RemoveParams
        {
            public string window;
        }
        public class SwapParams
        {
            public string window;
        }
    }
    namespace Response
    {
        public class AddResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ClearResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetItemsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetPlaylistsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetPropertiesResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class InsertResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class RemoveResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SwapResponse : ResponseBase
        {
            public string result { get; set; }
        }
    }
}