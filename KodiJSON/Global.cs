namespace KodiJSON.Global
{
    public struct Application
    {
        public const int id = 1;
        public const string jsonrpc = "2.0";

        public struct Property
        {
            public struct Name
            {
                public const string Volume = "volume";
                public const string Muted = "muted";
                public const string Named = "name";
                public const string Version = "version";
            }
        }
    }

    namespace Addons
    {
        public struct Content
        {
            public const string unknown = "unknown";
            public const string video = "video";
            public const string audio = "audio";
            public const string image = "image";
            public const string executable = "executable";
        }
        public struct Fields
        {
            public const string name = "name";
            public const string version = "version";
            public const string summary = "summary";
            public const string description = "description";
            public const string path = "path";
            public const string author = "author";
            public const string thumbnail = "thumbnail";
            public const string disclaimer = "disclaimer";
            public const string fanart = "fanart";
            public const string dependencies = "dependencies";
            public const string broken = "broken";
            public const string extrainfo = "extrainfo";
            public const string rating = "rating";
            public const string enabled = "enabled";
            public const string installed = "installed";
        }
        public struct Boolean
        {
            public const string True = "true";
            public const string False = "false";
            public const string All = "all";
        }
        public struct Types
        {
            public const string unknown = "unknown";
            public struct xbmc
            {
                public const string audioencoder = "xbmc.audioencoder";
                public const string pvrclient = "xbmc.pvrclient";
                public const string webinterface = "xbmc.webinterface";
                public struct addon
                {
                    public const string audio = "xbmc.addon.audio";
                    public const string executable = "xbmc.addon.executable";
                    public const string image = "xbmc.addon.image";
                    public const string repository = "xbmc.addon.repository";
                    public const string video = "xbmc.addon.video";
                }
                public struct gui
                {
                    public const string skin = "xbmc.gui.skin";
                }
                public struct metadata
                {
                    public struct scraper
                    {
                        public const string albums = "xbmc.metadata.scraper.albums";
                        public const string artists = "xbmc.metadata.scraper.artists";
                        public const string library = "xbmc.metadata.scraper.library";
                        public const string movies = "xbmc.metadata.scraper.movies";
                        public const string musicvideos = "xbmc.metadata.scraper.musicvideos";
                        public const string tvshows = "xbmc.metadata.scraper.tvshows";
                    }
                }
                public struct player
                {
                    public const string musicviz = "xbmc.player.musicviz";
                }

                public struct python
                {
                    public const string library = "xbmc.python.library";
                    public const string lyrics = "xbmc.python.lyrics";
                    public const string module = "xbmc.python.module";
                    public const string pluginsource = "xbmc.python.pluginsource";
                    public const string script = "xbmc.python.script";
                    public const string weather = "xbmc.python.weather";
                }
                public struct subtitle
                {
                    public const string module = "xbmc.subtitle.module";
                }
                public struct ui
                {
                    public const string service = "xbmc.service";
                    public const string screensaver = "xbmc.ui.screensaver";
                }

            }
            public struct kodi
            {
                public const string adsp = "kodi.adsp";
                public const string audiodecoder = "kodi.audiodecoder";
                public struct context
                {
                    public const string item = "kodi.context.item";
                }
                public struct game
                {
                    public const string controller = "kodi.game.controller";
                }
                public const string inputstream = "kodi.inputstream";
                public const string peripheral = "kodi.peripheral";
                public struct resource
                {
                    public const string images = "kodi.resource.images";
                    public const string language = "kodi.resource.language";
                    public const string uisounds = "kodi.resource.uisounds";
                }
            }
        }
    }

    namespace GUI
    {
        namespace Property{
            public struct Name
            {
                public const string currentwindow = "currentwindow";
                public const string currentcontrol = "currentcontrol";
                public const string skin = "skin";
                public const string fullscreen = "fullscreen";
                public const string stereoscopicmode = "stereoscopicmode";
            }
        }

        public struct Window
        {
            public static string home = "home";
            public static string programs = "programs";
            public static string pictures = "pictures";
            public static string filemanager = "filemanager";
            public static string files = "files";
            public static string settings = "settings";
            public static string music = "music";
            public static string video = "video";
            public static string videos = "videos";
            public static string tv = "tv";
            public static string pvr = "pvr";
            public static string pvrguideinfo = "pvrguideinfo";
            public static string pvrrecordinginfo = "pvrrecordinginfo";
            public static string pvrtimersetting = "pvrtimersetting";
            public static string pvrgroupmanager = "pvrgroupmanager";
            public static string pvrchannelmanager = "pvrchannelmanager";
            public static string pvrguidesearch = "pvrguidesearch";
            public static string pvrchannelscan = "pvrchannelscan";
            public static string pvrupdateprogress = "pvrupdateprogress";
            public static string pvrosdchannels = "pvrosdchannels";
            public static string pvrosdguide = "pvrosdguide";
            public static string pvrosddirector = "pvrosddirector";
            public static string pvrosdcutter = "pvrosdcutter";
            public static string pvrosdteletext = "pvrosdteletext";
            public static string systeminfo = "systeminfo";
            public static string testpattern = "testpattern";
            public static string screencalibration = "screencalibration";
            public static string guicalibration = "guicalibration";
            public static string picturessettings = "picturessettings";
            public static string programssettings = "programssettings";
            public static string weathersettings = "weathersettings";
            public static string musicsettings = "musicsettings";
            public static string systemsettings = "systemsettings";
            public static string videossettings = "videossettings";
            public static string networksettings = "networksettings";
            public static string servicesettings = "servicesettings";
            public static string appearancesettings = "appearancesettings";
            public static string pvrsettings = "pvrsettings";
            public static string tvsettings = "tvsettings";
            public static string scripts = "scripts";
            public static string videofiles = "videofiles";
            public static string videolibrary = "videolibrary";
            public static string videoplaylist = "videoplaylist";
            public static string loginscreen = "loginscreen";
            public static string profiles = "profiles";
            public static string skinsettings = "skinsettings";
            public static string addonbrowser = "addonbrowser";
            public static string yesnodialog = "yesnodialog";
            public static string progressdialog = "progressdialog";
            public static string virtualkeyboard = "virtualkeyboard";
            public static string volumebar = "volumebar";
            public static string submenu = "submenu";
            public static string favourites = "favourites";
            public static string contextmenu = "contextmenu";
            public static string infodialog = "infodialog";
            public static string numericinput = "numericinput";
            public static string gamepadinput = "gamepadinput";
            public static string shutdownmenu = "shutdownmenu";
            public static string mutebug = "mutebug";
            public static string playercontrols = "playercontrols";
            public static string seekbar = "seekbar";
            public static string musicosd = "musicosd";
            public static string addonsettings = "addonsettings";
            public static string visualisationsettings = "visualisationsettings";
            public static string visualisationpresetlist = "visualisationpresetlist";
            public static string osdvideosettings = "osdvideosettings";
            public static string osdaudiosettings = "osdaudiosettings";
            public static string videobookmarks = "videobookmarks";
            public static string filebrowser = "filebrowser";
            public static string networksetup = "networksetup";
            public static string mediasource = "mediasource";
            public static string profilesettings = "profilesettings";
            public static string locksettings = "locksettings";
            public static string contentsettings = "contentsettings";
            public static string songinformation = "songinformation";
            public static string smartplaylisteditor = "smartplaylisteditor";
            public static string smartplaylistrule = "smartplaylistrule";
            public static string busydialog = "busydialog";
            public static string pictureinfo = "pictureinfo";
            public static string accesspoints = "accesspoints";
            public static string fullscreeninfo = "fullscreeninfo";
            public static string karaokeselector = "karaokeselector";
            public static string karaokelargeselector = "karaokelargeselector";
            public static string sliderdialog = "sliderdialog";
            public static string addoninformation = "addoninformation";
            public static string musicplaylist = "musicplaylist";
            public static string musicfiles = "musicfiles";
            public static string musiclibrary = "musiclibrary";
            public static string musicplaylisteditor = "musicplaylisteditor";
            public static string teletext = "teletext";
            public static string selectdialog = "selectdialog";
            public static string musicinformation = "musicinformation";
            public static string okdialog = "okdialog";
            public static string movieinformation = "movieinformation";
            public static string textviewer = "textviewer";
            public static string fullscreenvideo = "fullscreenvideo";
            public static string fullscreenlivetv = "fullscreenlivetv";
            public static string visualisation = "visualisation";
            public static string slideshow = "slideshow";
            public static string filestackingdialog = "filestackingdialog";
            public static string karaoke = "karaoke";
            public static string weather = "weather";
            public static string screensaver = "screensaver";
            public static string videoosd = "videoosd";
            public static string videomenu = "videomenu";
            public static string videotimeseek = "videotimeseek";
            public static string musicoverlay = "musicoverlay";
            public static string videooverlay = "videooverlay";
            public static string startwindow = "startwindow";
            public static string startup = "startup";
            public static string peripherals = "peripherals";
            public static string peripheralsettings = "peripheralsettings";
            public static string extendedprogressdialog = "extendedprogressdialog";
            public static string mediafilter = "mediafilter";
        }
    }

    namespace Favourite
    {
        public struct Type
        {
            public const string media = "media";
            public const string window = "window";
            public const string script = "script";
            public const string unknown = "unknown";
        }

        namespace Fields
        {
            public struct Favourite
            {
                public const string window = "window";
                public const string windowparameter = "windowparameter";
                public const string thumbnail = "thumbnail";
                public const string path = "path";
            }
        }
    }

    namespace Files
    {
        public struct Media
        {
            public const string video = "video";
            public const string music = "music";
            public const string pictures = "pictures";
            public const string files = "files";
            public const string programs = "programs";
        }
    }

    namespace List
    {
        public class Limits
        {
            public int end { get; set; }
            public int start { get; set; }
            public int total { get; set; }
        }

        namespace Fields
        {
            public struct Files
            {
                public const string album = "album";
                public const string albumartist = "albumartist";
                public const string albumartistid = "albumartistid";
                public const string albumid = "albumid";
                public const string albumlabel = "albumlabel";
                public const string art = "art";
                public const string artist = "artist";
                public const string artistid = "artistid";
                public const string cast = "cast";
                public const string comment = "comment";
                public const string country = "country";
                public const string dateadded = "dateadded";
                public const string description = "description";
                public const string director = "director";
                public const string disc = "disc";
                public const string displayartist = "displayartist";
                public const string duration = "duration";
                public const string episode = "episode";
                public const string episodeguide = "episodeguide";
                public const string fanart = "fanart";
                public const string file = "file";
                public const string firstaired = "firstaired";
                public const string genre = "genre";
                public const string genreid = "genreid";
                public const string imdbnumber = "imdbnumber";
                public const string lastmodified = "lastmodified";
                public const string lastplayed = "lastplayed";
                public const string lyrics = "lyrics";
                public const string mimetype = "mimetype";
                public const string mood = "mood";
                public const string mpaa = "mpaa";
                public const string musicbrainzalbumartistid = "musicbrainzalbumartistid";
                public const string musicbrainzalbumid = "musicbrainzalbumid";
                public const string musicbrainzartistid = "musicbrainzartistid";
                public const string musicbrainztrackid = "musicbrainztrackid";
                public const string originaltitle = "originaltitle";
                public const string playcount = "playcount";
                public const string plot = "plot";
                public const string plotoutline = "plotoutline";
                public const string premiered = "premiered";
                public const string productioncode = "productioncode";
                public const string rating = "rating";
                public const string resume = "resume";
                public const string runtime = "runtime";
                public const string season = "season";
                public const string set = "set";
                public const string setid = "setid";
                public const string showlink = "showlink";
                public const string showtitle = "showtitle";
                public const string size = "size";
                public const string sorttitle = "sorttitle";
                public const string specialsortepisode = "specialsortepisode";
                public const string specialsortseason = "specialsortseason";
                public const string streamdetails = "streamdetails";
                public const string studio = "studio";
                public const string style = "style";
                public const string tag = "tag";
                public const string tagline = "tagline";
                public const string theme = "theme";
                public const string thumbnail = "thumbnail";
                public const string title = "title";
                public const string top250 = "top250";
                public const string track = "track";
                public const string trailer = "trailer";
                public const string tvshowid = "tvshowid";
                public const string uniqueid = "uniqueid";
                public const string votes = "votes";
                public const string watchedepisodes = "watchedepisodes";
                public const string writer = "writer";
                public const string year = "year";
            }
        }
    }

    public struct Methods
    {
        public struct Addons
        {
            public const string ExecuteAddon = "Addons.ExecuteAddon";
            public const string GetAddonDetails = "Addons.GetAddonDetails";
            public const string GetAddons = "Addons.GetAddons";
            public const string SetAddonEnabled = "Addons.SetAddonEnabled";
        }
        public struct Application
        {
            public const string GetProperties = "Application.GetProperties";
            public const string Quit = "Application.Quit";
            public const string SetMute = "Application.SetMute";
            public const string SetVolume = "Application.SetVolume";
        }

        public struct AudioLibrary
        {
            public const string Clean = "AudioLibrary.Clean";
            public const string Export = "AudioLibrary.Export";
            public const string GetAlbumDetails = "AudioLibrary.GetAlbumDetails";
            public const string GetAlbums = "AudioLibrary.GetAlbums";
            public const string GetArtistDetails = "AudioLibrary.GetArtistDetails";
            public const string GetArtists = "AudioLibrary.GetArtists";
            public const string GetGenres = "AudioLibrary.GetGenres";
            public const string GetProperties = "AudioLibrary.GetProperties";
            public const string GetRecentlyAddedAlbums = "AudioLibrary.GetRecentlyAddedAlbums";
            public const string GetRecentlyAddedSongs = "AudioLibrary.GetRecentlyAddedSongs";
            public const string GetRecentlyPlayedAlbums = "AudioLibrary.GetRecentlyPlayedAlbums";
            public const string GetRecentlyPlayedSongs = "AudioLibrary.GetRecentlyPlayedSongs";
            public const string GetRoles = "AudioLibrary.GetRoles";
            public const string GetSongDetails = "AudioLibrary.GetSongDetails";
            public const string GetSongs = "AudioLibrary.GetSongs";
            public const string Scan = "AudioLibrary.Scan";
            public const string SetAlbumDetails = "AudioLibrary.SetAlbumDetails";
            public const string SetArtistDetails = "AudioLibrary.SetArtistDetails";
            public const string SetSongDetails = "AudioLibrary.SetSongDetails";
        }
        public struct Files
        {
            public const string Download = "Files.Download";
            public const string GetDirectory = "Files.GetDirectory";
            public const string GetFileDetails = "Files.GetFileDetails";
            public const string GetSources = "Files.GetSources";
            public const string PrepareDownload = "Files.PrepareDownload";
        }

        public struct Favourites
        {
            public const string AddFavourite = "Favourites.AddFavourite";
            public const string GetFavourites = "Favourites.GetFavourites";
        }

        public struct GUI
        {
            public const string ActivateWindow = "GUI.ActivateWindow";
            public const string GetProperties = "GUI.GetProperties";
            public const string GetStereoscopicModes = "GUI.GetStereoscopicModes";
            public const string SetFullscreen = "GUI.SetFullscreen";
            public const string ShowNotification = "GUI.ShowNotification";
            public const string SetStereoscopicMode = "GUI.SetStereoscopicMode";
        }
        public struct Input
        {
            public const string Back = "Input.Back";
            public const string ContextMenu = "Input.ContextMenu";
            public const string Down = "Input.Down";
            public const string ExecuteAction = "Input.ExecuteAction";
            public const string Home = "Input.Home";
            public const string Info = "Input.Info";
            public const string Left = "Input.Left";
            public const string Right = "Input.Right";
            public const string Select = "Input.Select";
            public const string SendText = "Input.SendText";
            public const string ShowCodec = "Input.ShowCodec";
            public const string ShowOSD = "Input.ShowOSD";
            public const string Up = "Input.Up";
        }
        public struct JSONRPC
        {
            public const string GetConfiguration = "JSONRPC.GetConfiguration";
            public const string Introspect = "JSONRPC.Introspect";
            public const string NotifyAll = "JSONRPC.NotifyAll";
            public const string Permission = "JSONRPC.Permission";
            public const string Ping = "JSONRPC.Ping";
            public const string SetConfiguration = "JSONRPC.SetConfiguration";
            public const string Version = "JSONRPC.Version";
        }
        public struct Player
        {
            public const string GetActivePlayers = "Player.GetActivePlayers";
            public const string GetItem = "Player.GetItem";
            public const string GetProperties = "Player.GetProperties";
            public const string GoTo = "Player.GoTo";
            public const string Move = "Player.Move";
            public const string Open = "Player.Open";
            public const string PlayPause = "Player.PlayPause";
            public const string Rotate = "Player.Rotate";
            public const string Seek = "Player.Seek";
            public const string SetAudioStream = "Player.SetAudioStream";
            public const string SetPartymode = "Player.SetPartymode";
            public const string SetRepeat = "Player.SetRepeat";
            public const string SetShuffle = "Player.SetShuffle";
            public const string SetSpeed = "Player.SetSpeed";
            public const string SetSubtitle = "Player.SetSubtitle";
            public const string Stop = "Player.Stop";
            public const string Zoom = "Player.Zoom";
        }
        public struct Playlist
        {
            public const string Add = "Playlist.Add";
            public const string Clear = "Playlist.Clear";
            public const string GetItems = "Playlist.GetItems";
            public const string GetPlaylists = "Playlist.GetPlaylists";
            public const string GetProperties = "Playlist.GetProperties";
            public const string Insert = "Playlist.Insert";
            public const string Remove = "Playlist.Remove";
            public const string Swap = "Playlist.Swap";
        }
        public struct PVR
        {
            public const string GetChannelDetails = "PVR.GetChannelDetails";
            public const string GetChannelGroupDetails = "PVR.GetChannelGroupDetails";
            public const string GetChannelGroups = "PVR.GetChannelGroups";
            public const string GetChannels = "PVR.GetChannels";
            public const string GetProperties = "PVR.GetProperties";
            public const string Record = "PVR.Record";
            public const string Scan = "PVR.Scan";
        }
        public struct System
        {
            public const string EjectOpticalDrive = "System.EjectOpticalDrive";
            public const string GetProperties = "System.GetProperties";
            public const string Hibernate = "System.Hibernate";
            public const string Reboot = "System.Reboot";
            public const string Shutdown = "System.Shutdown";
            public const string Suspend = "System.Suspend";
        }
        public struct VideoLibrary
        {
            public const string Clean = "VideoLibrary.Clean";
            public const string Export = "VideoLibrary.Export";
            public const string GetEpisodeDetails = "VideoLibrary.GetEpisodeDetails";
            public const string GetEpisodes = "VideoLibrary.GetEpisodes";
            public const string GetGenres = "VideoLibrary.GetGenres";
            public const string GetMovieDetails = "VideoLibrary.GetMovieDetails";
            public const string GetMovies = "VideoLibrary.GetMovies";
            public const string GetMovieSetDetails = "VideoLibrary.GetMovieSetDetails";
            public const string GetMovieSets = "VideoLibrary.GetMovieSets";
            public const string GetMusicVideoDetails = "VideoLibrary.GetMusicVideoDetails";
            public const string GetMusicVideos = "VideoLibrary.GetMusicVideos";
            public const string GetRecentlyAddedEpisodes = "VideoLibrary.GetRecentlyAddedEpisodes";
            public const string GetRecentlyAddedMovies = "VideoLibrary.GetRecentlyAddedMovies";
            public const string GetRecentlyAddedMusicVideos = "VideoLibrary.GetRecentlyAddedMusicVideos";
            public const string GetSeasons = "VideoLibrary.GetSeasons";
            public const string GetTVShowDetails = "VideoLibrary.GetTVShowDetails";
            public const string GetTVShows = "VideoLibrary.GetTVShows";
            public const string RemoveEpisode = "VideoLibrary.RemoveEpisode";
            public const string RemoveMovie = "VideoLibrary.RemoveMovie";
            public const string RemoveMusicVideo = "VideoLibrary.RemoveMusicVideo";
            public const string RemoveTVShow = "VideoLibrary.RemoveTVShow";
            public const string Scan = "VideoLibrary.Scan";
            public const string SetEpisodeDetails = "VideoLibrary.SetEpisodeDetails";
            public const string SetMovieDetails = "VideoLibrary.SetMovieDetails";
            public const string SetMusicVideoDetails = "VideoLibrary.SetMusicVideoDetails";
            public const string SetTVShowDetails = "VideoLibrary.SetTVShowDetails";
        }
        public struct XBMC
        {
            public const string GetInfoBooleans = "XBMC.GetInfoBooleans";
            public const string GetInfoLabels = "XBMC.GetInfoLabels";
        }
    }

}
