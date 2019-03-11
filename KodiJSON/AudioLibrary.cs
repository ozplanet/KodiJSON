namespace KodiJSON.AudioLibrary
{
    namespace Methods
    {
        public class Clean : MethodBase
        {
            public Clean() { }
            public Clean(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.Clean;
            public Params.CleanParams @params = new Params.CleanParams();

        }
        public class Export : MethodBase
        {
            public Export() { }
            public Export(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.Export;
            public Params.ExportParams @params = new Params.ExportParams();

        }
        public class GetAlbumDetails : MethodBase
        {
            public GetAlbumDetails() { }
            public GetAlbumDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetAlbumDetails;
            public Params.GetAlbumDetailsParams @params = new Params.GetAlbumDetailsParams();

        }
        public class GetAlbums : MethodBase
        {
            public GetAlbums() { }
            public GetAlbums(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetAlbums;
            public Params.GetAlbumsParams @params = new Params.GetAlbumsParams();

        }
        public class GetArtistDetails : MethodBase
        {
            public GetArtistDetails() { }
            public GetArtistDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetArtistDetails;
            public Params.GetArtistDetailsParams @params = new Params.GetArtistDetailsParams();

        }
        public class GetArtists : MethodBase
        {
            public GetArtists() { }
            public GetArtists(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetArtists;
            public Params.GetArtistsParams @params = new Params.GetArtistsParams();

        }
        public class GetGenres : MethodBase
        {
            public GetGenres() { }
            public GetGenres(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetGenres;
            public Params.GetGenresParams @params = new Params.GetGenresParams();

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
        public class GetRecentlyAddedAlbums : MethodBase
        {
            public GetRecentlyAddedAlbums() { }
            public GetRecentlyAddedAlbums(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetRecentlyAddedAlbums;
            public Params.GetRecentlyAddedAlbumsParams @params = new Params.GetRecentlyAddedAlbumsParams();

        }
        public class GetRecentlyAddedSongs : MethodBase
        {
            public GetRecentlyAddedSongs() { }
            public GetRecentlyAddedSongs(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetRecentlyAddedSongs;
            public Params.GetRecentlyAddedSongsParams @params = new Params.GetRecentlyAddedSongsParams();

        }
        public class GetRecentlyPlayedAlbums : MethodBase
        {
            public GetRecentlyPlayedAlbums() { }
            public GetRecentlyPlayedAlbums(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetRecentlyPlayedAlbums;
            public Params.GetRecentlyPlayedAlbumsParams @params = new Params.GetRecentlyPlayedAlbumsParams();

        }
        public class GetRecentlyPlayedSongs : MethodBase
        {
            public GetRecentlyPlayedSongs() { }
            public GetRecentlyPlayedSongs(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetRecentlyPlayedSongs;
            public Params.GetRecentlyPlayedSongsParams @params = new Params.GetRecentlyPlayedSongsParams();

        }
        public class GetRoles : MethodBase
        {
            public GetRoles() { }
            public GetRoles(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetRoles;
            public Params.GetRolesParams @params = new Params.GetRolesParams();

        }
        public class GetSongDetails : MethodBase
        {
            public GetSongDetails() { }
            public GetSongDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetSongDetails;
            public Params.GetSongDetailsParams @params = new Params.GetSongDetailsParams();

        }
        public class GetSongs : MethodBase
        {
            public GetSongs() { }
            public GetSongs(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.GetSongs;
            public Params.GetSongsParams @params = new Params.GetSongsParams();

        }
        public class Scan : MethodBase
        {
            public Scan() { }
            public Scan(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.Scan;
            public Params.ScanParams @params = new Params.ScanParams();

        }
        public class SetAlbumDetails : MethodBase
        {
            public SetAlbumDetails() { }
            public SetAlbumDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.SetAlbumDetails;
            public Params.SetAlbumDetailsParams @params = new Params.SetAlbumDetailsParams();

        }
        public class SetArtistDetails : MethodBase
        {
            public SetArtistDetails() { }
            public SetArtistDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.SetArtistDetails;
            public Params.SetArtistDetailsParams @params = new Params.SetArtistDetailsParams();

        }
        public class SetSongDetails : MethodBase
        {
            public SetSongDetails() { }
            public SetSongDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.AudioLibrary.SetSongDetails;
            public Params.SetSongDetailsParams @params = new Params.SetSongDetailsParams();

        }
    }
    namespace Params
    {
        public class CleanParams
        {
            public string window;
        }
        public class ExportParams
        {
            public string window;
        }
        public class GetAlbumDetailsParams
        {
            public string window;
        }
        public class GetAlbumsParams
        {
            public string window;
        }
        public class GetArtistDetailsParams
        {
            public string window;
        }
        public class GetArtistsParams
        {
            public string window;
        }
        public class GetGenresParams
        {
            public string window;
        }
        public class GetPropertiesParams
        {
            //TODO
            public string[] properties = { Global.GUI.Property.Name.currentcontrol,
                                           Global.GUI.Property.Name.currentwindow,
                                           Global.GUI.Property.Name.fullscreen,
                                           Global.GUI.Property.Name.skin,
                                           Global.GUI.Property.Name.stereoscopicmode };
        }
        public class GetRecentlyAddedAlbumsParams
        {
            public string window;
        }
        public class GetRecentlyAddedSongsParams
        {
            public string window;
        }
        public class GetRecentlyPlayedAlbumsParams
        {
            public string window;
        }
        public class GetRecentlyPlayedSongsParams
        {
            public string window;
        }
        public class GetRolesParams
        {
            public string window;
        }
        public class GetSongDetailsParams
        {
            public string window;
        }
        public class GetSongsParams
        {
            public string window;
        }
        public class ScanParams
        {
            public string window;
        }
        public class SetAlbumDetailsParams
        {
            public string window;
        }
        public class SetArtistDetailsParams
        {
            public string window;
        }
        public class SetSongDetailsParams
        {
            public string window;
        }
    }
    namespace Response
    {
        public class CleanResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ExportResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetAlbumDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetAlbumsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetArtistDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetArtistsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetGenresResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetPropertiesResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetRecentlyAddedAlbumsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetRecentlyAddedSongsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetRecentlyPlayedAlbumsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetRecentlyPlayedSongsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetRolesResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetSongDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetSongsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ScanResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetAlbumDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetArtistDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetSongDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
    }
}