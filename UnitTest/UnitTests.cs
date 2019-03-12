using KodiJSON.Addons.Methods;
using KodiJSON.Application.Methods;
using KodiJSON.AudioLibrary.Methods;
using KodiJSON.Favourites.Methods;
using KodiJSON.Files.Methods;
using KodiJSON.GUI.Methods;
using KodiJSON.Input.Methods;
using KodiJSON.JSONRPC.Methods;
using KodiJSON.Kodi.Methods;
using KodiJSON.PVR.Methods;
using KodiJSON.Player.Methods;
using KodiJSON.Playlist.Methods;
using KodiJSON.System.Methods;
using KodiJSON.VideoLibrary.Methods;
using Newtonsoft.Json;
using UnitTest;

namespace UnitTests
{
    public class Addons
    {
        public void ExecuteAddonTest()
        {
            ExecuteAddon request = new ExecuteAddon("script.module.youtube.dl");
            var result = JsonConvert.DeserializeObject<KodiJSON.Addons.Response.ExecuteAddonResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetAddonDetailsTest()
        {
            GetAddonDetails request = new GetAddonDetails("script.module.youtube.dl");
            var result = JsonConvert.DeserializeObject<KodiJSON.Addons.Response.GetAddonDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetAddonsTest()
        {
            GetAddons request = new GetAddons();
            var result = JsonConvert.DeserializeObject<KodiJSON.Addons.Response.GetAddonsResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetAddonEnabledTest()
        {
            SetAddonEnabled request = new SetAddonEnabled("script.module.youtube.dl", true);
            var result = JsonConvert.DeserializeObject<KodiJSON.Addons.Response.SetAddonEnabledResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class Application
    {
        public void GetPropertiesTest()
        {
            KodiJSON.Application.Methods.GetProperties request = new KodiJSON.Application.Methods.GetProperties();
            var result = JsonConvert.DeserializeObject<KodiJSON.Application.Response.GetPropertiesResponse>(ExecuteTest.GetResponse(request));
        }

        public void QuitTest()
        {
            Quit request = new Quit();
            var result = JsonConvert.DeserializeObject<KodiJSON.Application.Response.QuitResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetMuteTest()
        {
            SetMute request = new SetMute();
            var result = JsonConvert.DeserializeObject<KodiJSON.Application.Response.SetMuteResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetVolumeTest()
        {
            SetVolume request = new SetVolume(80);
            var result = JsonConvert.DeserializeObject<KodiJSON.Application.Response.SetVolumeResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class AudioLibrary
    {
        public void CleanTest()
        {
            KodiJSON.AudioLibrary.Methods.Clean request = new KodiJSON.AudioLibrary.Methods.Clean();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.CleanResponse>(ExecuteTest.GetResponse(request));
        }

        public void ExportTest()
        {
            KodiJSON.AudioLibrary.Methods.Export request = new KodiJSON.AudioLibrary.Methods.Export();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.ExportResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetAlbumDetailsTest()
        {
            GetAlbumDetails request = new GetAlbumDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.GetAlbumDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetAlbumsTest()
        {
            GetAlbums request = new GetAlbums();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.GetAlbumsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetArtistDetailsTest()
        {
            GetArtistDetails request = new GetArtistDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.GetArtistDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetArtistsTest()
        {
            GetArtists request = new GetArtists();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.GetArtistsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetGenresTest()
        {
            KodiJSON.AudioLibrary.Methods.GetGenres request = new KodiJSON.AudioLibrary.Methods.GetGenres();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.GetGenresResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetRecentlyAddedAlbumsTest()
        {
            GetRecentlyAddedAlbums request = new GetRecentlyAddedAlbums();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.GetRecentlyAddedAlbumsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetRecentlyAddedSongsTest()
        {
            GetRecentlyAddedSongs request = new GetRecentlyAddedSongs();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.GetRecentlyAddedSongsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetRecentlyPlayedAlbumsTest()
        {
            GetRecentlyPlayedAlbums request = new GetRecentlyPlayedAlbums();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.GetRecentlyPlayedAlbumsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetRecentlyPlayedSongsTest()
        {
            GetRecentlyPlayedSongs request = new GetRecentlyPlayedSongs();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.GetRecentlyPlayedSongsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetSongDetailsTest()
        {
            GetSongDetails request = new GetSongDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.GetSongDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetSongsTest()
        {
            GetSongs request = new GetSongs();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.GetSongsResponse>(ExecuteTest.GetResponse(request));
        }

        public void ScanTest()
        {
            KodiJSON.AudioLibrary.Methods.Scan request = new KodiJSON.AudioLibrary.Methods.Scan();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.ScanResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetAlbumDetailsTest()
        {
            SetAlbumDetails request = new SetAlbumDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.SetAlbumDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetArtistDetailsTest()
        {
            SetArtistDetails request = new SetArtistDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.SetArtistDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetSongDetailsTest()
        {
            SetSongDetails request = new SetSongDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.AudioLibrary.Response.SetSongDetailsResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class Favourites
    {
        public void GetFavouriteTest()
        {
            GetFavourites request = new GetFavourites();
            var result = JsonConvert.DeserializeObject<KodiJSON.Favourites.Response.GetFavouritesResponse>(ExecuteTest.GetResponse(request));
        }
        public void AddFavouriteTest()
        {
            AddFavourite request = new AddFavourite();
            var result = JsonConvert.DeserializeObject<KodiJSON.Favourites.Response.AddFavouriteResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class Files
    {
        public void GetDirectoryTest()
        {
            GetDirectory request = new GetDirectory();
            var result = JsonConvert.DeserializeObject<KodiJSON.Files.Response.GetDirectoryResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetFileDetailsTest()
        {
            GetFileDetails request = new GetFileDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.Files.Response.GetFileDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetSourcesTest()
        {
            GetSources request = new GetSources();
            var result = JsonConvert.DeserializeObject<KodiJSON.Files.Response.GetSourcesResponse>(ExecuteTest.GetResponse(request));
        }

        public void PrepareDownloadTest()
        {
            PrepareDownload request = new PrepareDownload();
            var result = JsonConvert.DeserializeObject<KodiJSON.Files.Response.PrepareDownloadResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class GUI
    {
        public void ActivateWindowTest()
        {
            ActivateWindow request = new ActivateWindow(KodiJSON.Global.GUI.Window.home);
            var result = JsonConvert.DeserializeObject<KodiJSON.GUI.Response.ActivateWindowResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetPropertiesTest()
        {
            KodiJSON.GUI.Methods.GetProperties request = new KodiJSON.GUI.Methods.GetProperties();
            var result = JsonConvert.DeserializeObject<KodiJSON.GUI.Response.GetPropertiesResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetFullscreenTest()
        {
            SetFullscreen request = new SetFullscreen();
            var result = JsonConvert.DeserializeObject<KodiJSON.GUI.Response.SetFullscreenResponse>(ExecuteTest.GetResponse(request));
        }

        public void ShowNotificationTest()
        {
            ShowNotification request = new ShowNotification("ShowNotificationTest", "Test ShowNotification", KodiJSON.GUI.Params.ShowNotificationParams.images.warning);
            var result = JsonConvert.DeserializeObject<KodiJSON.GUI.Response.ShowNotificationResponse>(ExecuteTest.GetResponse(request));
        }
        public void GetStereoscopicModesTest()
        {
            GetStereoscopicModes request = new GetStereoscopicModes();
            var result = JsonConvert.DeserializeObject<KodiJSON.GUI.Response.GetStereoscopicModesResponse>(ExecuteTest.GetResponse(request));
        }
        public void SetStereoscopicModeTest()
        {
            SetStereoscopicMode request = new SetStereoscopicMode();
            var result = JsonConvert.DeserializeObject<KodiJSON.GUI.Response.SetStereoscopicModeResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class Input
    {
        public void BackTest()
        {
            Back request = new Back();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.BackResponse>(ExecuteTest.GetResponse(request));
        }

        public void ContextMenuTest()
        {
            KodiJSON.Input.Methods.ContextMenu request = new KodiJSON.Input.Methods.ContextMenu();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.ContextMenuResponse>(ExecuteTest.GetResponse(request));
        }

        public void DownTest()
        {
            Down request = new Down();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.DownResponse>(ExecuteTest.GetResponse(request));
        }

        public void ExecuteActionTest()
        {
            ExecuteAction request = new ExecuteAction();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.ExecuteActionResponse>(ExecuteTest.GetResponse(request));
        }

        public void HomeTest()
        {
            Home request = new Home();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.HomeResponse>(ExecuteTest.GetResponse(request));
        }

        public void InfoTest()
        {
            Info request = new Info();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.InfoResponse>(ExecuteTest.GetResponse(request));
        }

        public void LeftTest()
        {
            Left request = new Left();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.LeftResponse>(ExecuteTest.GetResponse(request));
        }

        public void RightTest()
        {
            Right request = new Right();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.RightResponse>(ExecuteTest.GetResponse(request));
        }

        public void SelectTest()
        {
            Select request = new Select();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.SelectResponse>(ExecuteTest.GetResponse(request));
        }

        public void SendTextTest()
        {
            SendText request = new SendText();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.SendTextResponse>(ExecuteTest.GetResponse(request));
        }

        public void ShowCodecTest()
        {
            ShowCodec request = new ShowCodec();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.ShowCodecResponse>(ExecuteTest.GetResponse(request));
        }

        public void ShowOSDTest()
        {
            ShowOSD request = new ShowOSD();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.ShowOSDResponse>(ExecuteTest.GetResponse(request));
        }

        public void UpTest()
        {
            Up request = new Up();
            var result = JsonConvert.DeserializeObject<KodiJSON.Input.Response.UpResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class JSONRPC
    {
        public void GetConfigurationTest()
        {
            GetConfiguration request = new GetConfiguration();
            var result = JsonConvert.DeserializeObject<KodiJSON.JSONRPC.Response.GetConfigurationResponse>(ExecuteTest.GetResponse(request));
        }

        public void IntrospectTest()
        {
            Introspect request = new Introspect();
            var result = JsonConvert.DeserializeObject<KodiJSON.JSONRPC.Response.IntrospectResponse>(ExecuteTest.GetResponse(request));
        }

        public void NotifyAllTest()
        {
            NotifyAll request = new NotifyAll();
            var result = JsonConvert.DeserializeObject<KodiJSON.JSONRPC.Response.NotifyAllResponse>(ExecuteTest.GetResponse(request));
        }

        public void PermissionTest()
        {
            Permission request = new Permission();
            var result = JsonConvert.DeserializeObject<KodiJSON.JSONRPC.Response.PermissionResponse>(ExecuteTest.GetResponse(request));
        }

        public void PingTest()
        {
            Ping request = new Ping();
            var result = JsonConvert.DeserializeObject<KodiJSON.JSONRPC.Response.PingResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetConfigurationTest()
        {
            SetConfiguration request = new SetConfiguration();
            var result = JsonConvert.DeserializeObject<KodiJSON.JSONRPC.Response.SetConfigurationResponse>(ExecuteTest.GetResponse(request));
        }

        public void VersionTest()
        {
            KodiJSON.JSONRPC.Methods.Version request = new KodiJSON.JSONRPC.Methods.Version();
            var result = JsonConvert.DeserializeObject<KodiJSON.JSONRPC.Response.VersionResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class PVR
    {
        public void GetChannelDetailsTest()
        {
            GetChannelDetails request = new GetChannelDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.PVR.Response.GetChannelDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetChannelGroupDetailsTest()
        {
            GetChannelGroupDetails request = new GetChannelGroupDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.PVR.Response.GetChannelGroupDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetChannelGroupsTest()
        {
            GetChannelGroups request = new GetChannelGroups();
            var result = JsonConvert.DeserializeObject<KodiJSON.PVR.Response.GetChannelGroupsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetChannelsTest()
        {
            GetChannels request = new GetChannels();
            var result = JsonConvert.DeserializeObject<KodiJSON.PVR.Response.GetChannelsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetPropertiesTest()
        {
            KodiJSON.PVR.Methods.GetProperties request = new KodiJSON.PVR.Methods.GetProperties();
            var result = JsonConvert.DeserializeObject<KodiJSON.PVR.Response.GetPropertiesResponse>(ExecuteTest.GetResponse(request));
        }

        public void RecordTest()
        {
            Record request = new Record();
            var result = JsonConvert.DeserializeObject<KodiJSON.PVR.Response.RecordResponse>(ExecuteTest.GetResponse(request));
        }

        public void ScanTest()
        {
            KodiJSON.PVR.Methods.Scan request = new KodiJSON.PVR.Methods.Scan();
            var result = JsonConvert.DeserializeObject<KodiJSON.PVR.Response.ScanResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class Player
    {
        public void GetActivePlayersTest()
        {
            GetActivePlayers request = new GetActivePlayers();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.GetActivePlayersResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetItemTest()
        {
            GetItem request = new GetItem();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.GetItemResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetPropertiesTest()
        {
            KodiJSON.Player.Methods.GetProperties request = new KodiJSON.Player.Methods.GetProperties();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.GetPropertiesResponse>(ExecuteTest.GetResponse(request));
        }

        public void GoToTest()
        {
            GoTo request = new GoTo();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.GoToResponse>(ExecuteTest.GetResponse(request));
        }

        public void MoveTest()
        {
            Move request = new Move();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.MoveResponse>(ExecuteTest.GetResponse(request));
        }

        public void OpenTest()
        {
            Open request = new Open();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.OpenResponse>(ExecuteTest.GetResponse(request));
        }

        public void PlayPauseTest()
        {
            PlayPause request = new PlayPause(1, true);
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.PlayPauseResponse>(ExecuteTest.GetResponse(request));
        }

        public void RotateTest()
        {
            Rotate request = new Rotate();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.RotateResponse>(ExecuteTest.GetResponse(request));
        }

        public void SeekTest()
        {
            Seek request = new Seek();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.SeekResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetAudioStreamTest()
        {
            SetAudioStream request = new SetAudioStream();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.SetAudioStreamResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetPartymodeTest()
        {
            SetPartymode request = new SetPartymode();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.SetPartymodeResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetRepeatTest()
        {
            SetRepeat request = new SetRepeat();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.SetRepeatResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetShuffleTest()
        {
            SetShuffle request = new SetShuffle();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.SetShuffleResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetSpeedTest()
        {
            SetSpeed request = new SetSpeed();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.SetSpeedResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetSubtitleTest()
        {
            SetSubtitle request = new SetSubtitle();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.SetSubtitleResponse>(ExecuteTest.GetResponse(request));
        }

        public void StopTest()
        {
            Stop request = new Stop();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.StopResponse>(ExecuteTest.GetResponse(request));
        }

        public void ZoomTest()
        {
            Zoom request = new Zoom();
            var result = JsonConvert.DeserializeObject<KodiJSON.Player.Response.ZoomResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class Playlist
    {
        public void AddTest()
        {
            Add request = new Add();
            var result = JsonConvert.DeserializeObject<KodiJSON.Playlist.Response.AddResponse>(ExecuteTest.GetResponse(request));
        }

        public void ClearTest()
        {
            Clear request = new Clear();
            var result = JsonConvert.DeserializeObject<KodiJSON.Playlist.Response.ClearResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetItemsTest()
        {
            GetItems request = new GetItems();
            var result = JsonConvert.DeserializeObject<KodiJSON.Playlist.Response.GetItemsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetPlaylistsTest()
        {
            GetPlaylists request = new GetPlaylists();
            var result = JsonConvert.DeserializeObject<KodiJSON.Playlist.Response.GetPlaylistsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetPropertiesTest()
        {
            KodiJSON.Playlist.Methods.GetProperties request = new KodiJSON.Playlist.Methods.GetProperties();
            var result = JsonConvert.DeserializeObject<KodiJSON.Playlist.Response.GetPropertiesResponse>(ExecuteTest.GetResponse(request));
        }

        public void InsertTest()
        {
            Insert request = new Insert();
            var result = JsonConvert.DeserializeObject<KodiJSON.Playlist.Response.InsertResponse>(ExecuteTest.GetResponse(request));
        }

        public void RemoveTest()
        {
            Remove request = new Remove();
            var result = JsonConvert.DeserializeObject<KodiJSON.Playlist.Response.RemoveResponse>(ExecuteTest.GetResponse(request));
        }

        public void SwapTest()
        {
            Swap request = new Swap();
            var result = JsonConvert.DeserializeObject<KodiJSON.Playlist.Response.SwapResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class System
    {
        public void EjectOpticalDriveTest()
        {
            EjectOpticalDrive request = new EjectOpticalDrive();
            var result = JsonConvert.DeserializeObject<KodiJSON.System.Response.EjectOpticalDriveResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetPropertiesTest()
        {
            KodiJSON.System.Methods.GetProperties request = new KodiJSON.System.Methods.GetProperties();
            var result = JsonConvert.DeserializeObject<KodiJSON.System.Response.GetPropertiesResponse>(ExecuteTest.GetResponse(request));
        }

        public void HibernateTest()
        {
            Hibernate request = new Hibernate();
            var result = JsonConvert.DeserializeObject<KodiJSON.System.Response.HibernateResponse>(ExecuteTest.GetResponse(request));
        }

        public void RebootTest()
        {
            Reboot request = new Reboot();
            var result = JsonConvert.DeserializeObject<KodiJSON.System.Response.RebootResponse>(ExecuteTest.GetResponse(request));
        }

        public void ShutdownTest()
        {
            Shutdown request = new Shutdown();
            var result = JsonConvert.DeserializeObject<KodiJSON.System.Response.ShutdownResponse>(ExecuteTest.GetResponse(request));
        }

        public void SuspendTest()
        {
            Suspend request = new Suspend();
            var result = JsonConvert.DeserializeObject<KodiJSON.System.Response.SuspendResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class VideoLibrary
    {
        public void CleanTest()
        {
            KodiJSON.VideoLibrary.Methods.Clean request = new KodiJSON.VideoLibrary.Methods.Clean();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.CleanResponse>(ExecuteTest.GetResponse(request));
        }

        public void ExportTest()
        {
            KodiJSON.VideoLibrary.Methods.Export request = new KodiJSON.VideoLibrary.Methods.Export();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.ExportResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetEpisodeDetailsTest()
        {
            GetEpisodeDetails request = new GetEpisodeDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetEpisodeDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetEpisodesTest()
        {
            GetEpisodes request = new GetEpisodes();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetEpisodesResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetGenresTest()
        {
            KodiJSON.VideoLibrary.Methods.GetGenres request = new KodiJSON.VideoLibrary.Methods.GetGenres();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetGenresResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetMovieDetailsTest()
        {
            GetMovieDetails request = new GetMovieDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetMovieDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetMovieSetDetailsTest()
        {
            GetMovieSetDetails request = new GetMovieSetDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetMovieSetDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetMovieSetsTest()
        {
            GetMovieSets request = new GetMovieSets();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetMovieSetsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetMoviesTest()
        {
            GetMovies request = new GetMovies();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetMoviesResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetMusicVideoDetailsTest()
        {
            GetMusicVideoDetails request = new GetMusicVideoDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetMusicVideoDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetMusicVideosTest()
        {
            GetMusicVideos request = new GetMusicVideos();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetMusicVideosResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetRecentlyAddedEpisodesTest()
        {
            GetRecentlyAddedEpisodes request = new GetRecentlyAddedEpisodes();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetRecentlyAddedEpisodesResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetRecentlyAddedMoviesTest()
        {
            GetRecentlyAddedMovies request = new GetRecentlyAddedMovies();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetRecentlyAddedMoviesResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetRecentlyAddedMusicVideosTest()
        {
            GetRecentlyAddedMusicVideos request = new GetRecentlyAddedMusicVideos();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetRecentlyAddedMusicVideosResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetSeasonsTest()
        {
            GetSeasons request = new GetSeasons();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetSeasonsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetTVShowDetailsTest()
        {
            GetTVShowDetails request = new GetTVShowDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetTVShowDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetTVShowsTest()
        {
            GetTVShows request = new GetTVShows();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.GetTVShowsResponse>(ExecuteTest.GetResponse(request));
        }

        public void RemoveEpisodeTest()
        {
            RemoveEpisode request = new RemoveEpisode();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.RemoveEpisodeResponse>(ExecuteTest.GetResponse(request));
        }

        public void RemoveMovieTest()
        {
            RemoveMovie request = new RemoveMovie();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.RemoveMovieResponse>(ExecuteTest.GetResponse(request));
        }

        public void RemoveMusicVideoTest()
        {
            RemoveMusicVideo request = new RemoveMusicVideo();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.RemoveMusicVideoResponse>(ExecuteTest.GetResponse(request));
        }

        public void RemoveTVShowTest()
        {
            RemoveTVShow request = new RemoveTVShow();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.RemoveTVShowResponse>(ExecuteTest.GetResponse(request));
        }

        public void ScanTest()
        {
            KodiJSON.VideoLibrary.Methods.Scan request = new KodiJSON.VideoLibrary.Methods.Scan();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.ScanResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetEpisodeDetailsTest()
        {
            SetEpisodeDetails request = new SetEpisodeDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.SetEpisodeDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetMovieDetailsTest()
        {
            SetMovieDetails request = new SetMovieDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.SetMovieDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetMusicVideoDetailsTest()
        {
            SetMusicVideoDetails request = new SetMusicVideoDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.SetMusicVideoDetailsResponse>(ExecuteTest.GetResponse(request));
        }

        public void SetTVShowDetailsTest()
        {
            SetTVShowDetails request = new SetTVShowDetails();
            var result = JsonConvert.DeserializeObject<KodiJSON.VideoLibrary.Response.SetTVShowDetailsResponse>(ExecuteTest.GetResponse(request));
        }
    }
    public class Kodi
    {
        public void GetInfoBooleansTest()
        {
            GetInfoBooleans request = new GetInfoBooleans();
            var result = JsonConvert.DeserializeObject<KodiJSON.Kodi.Response.GetInfoBooleansResponse>(ExecuteTest.GetResponse(request));
        }

        public void GetInfoLabelsTest()
        {
            GetInfoLabels request = new GetInfoLabels();
            var result = JsonConvert.DeserializeObject<KodiJSON.Kodi.Response.GetInfoLabelsResponse>(ExecuteTest.GetResponse(request));
        }
    }
}
