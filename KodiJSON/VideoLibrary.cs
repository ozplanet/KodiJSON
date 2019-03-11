namespace KodiJSON.VideoLibrary
{
    namespace Methods
    {
        public class Clean : MethodBase
        {
            public Clean() { }
            public Clean(bool window)
            {
                @params.showdialogs = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.Clean;
            public Params.CleanParams @params = new Params.CleanParams();

        }
        public class Export : MethodBase
        {
            public Export() { }
            public Export(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.Export;
            public Params.ExportParams @params = new Params.ExportParams();

        }
        public class GetEpisodeDetails : MethodBase
        {
            public GetEpisodeDetails() { }
            public GetEpisodeDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetEpisodeDetails;
            public Params.GetEpisodeDetailsParams @params = new Params.GetEpisodeDetailsParams();

        }
        public class GetEpisodes : MethodBase
        {
            public GetEpisodes() { }
            public GetEpisodes(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetEpisodes;
            public Params.GetEpisodesParams @params = new Params.GetEpisodesParams();

        }
        public class GetGenres : MethodBase
        {
            public GetGenres() { }
            public GetGenres(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetGenres;
            public Params.GetGenresParams @params = new Params.GetGenresParams();

        }
        public class GetMovieDetails : MethodBase
        {
            public GetMovieDetails() { }
            public GetMovieDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetMovieDetails;
            public Params.GetMovieDetailsParams @params = new Params.GetMovieDetailsParams();

        }
        public class GetMovieSetDetails : MethodBase
        {
            public GetMovieSetDetails() { }
            public GetMovieSetDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetMovieSetDetails;
            public Params.GetMovieSetDetailsParams @params = new Params.GetMovieSetDetailsParams();

        }
        public class GetMovieSets : MethodBase
        {
            public GetMovieSets() { }
            public GetMovieSets(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetMovieSets;
            public Params.GetMovieSetsParams @params = new Params.GetMovieSetsParams();

        }
        public class GetMovies : MethodBase
        {
            public GetMovies() { }
            public GetMovies(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetMovies;
            public Params.GetMoviesParams @params = new Params.GetMoviesParams();

        }
        public class GetMusicVideoDetails : MethodBase
        {
            public GetMusicVideoDetails() { }
            public GetMusicVideoDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetMusicVideoDetails;
            public Params.GetMusicVideoDetailsParams @params = new Params.GetMusicVideoDetailsParams();

        }
        public class GetMusicVideos : MethodBase
        {
            public GetMusicVideos() { }
            public GetMusicVideos(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetMusicVideos;
            public Params.GetMusicVideosParams @params = new Params.GetMusicVideosParams();

        }
        public class GetRecentlyAddedEpisodes : MethodBase
        {
            public GetRecentlyAddedEpisodes() { }
            public GetRecentlyAddedEpisodes(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetRecentlyAddedEpisodes;
            public Params.GetRecentlyAddedEpisodesParams @params = new Params.GetRecentlyAddedEpisodesParams();

        }
        public class GetRecentlyAddedMovies : MethodBase
        {
            public GetRecentlyAddedMovies() { }
            public GetRecentlyAddedMovies(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetRecentlyAddedMovies;
            public Params.GetRecentlyAddedMoviesParams @params = new Params.GetRecentlyAddedMoviesParams();

        }
        public class GetRecentlyAddedMusicVideos : MethodBase
        {
            public GetRecentlyAddedMusicVideos() { }
            public GetRecentlyAddedMusicVideos(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetRecentlyAddedMusicVideos;
            public Params.GetRecentlyAddedMusicVideosParams @params = new Params.GetRecentlyAddedMusicVideosParams();

        }
        public class GetSeasons : MethodBase
        {
            public GetSeasons() { }
            public GetSeasons(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetSeasons;
            public Params.GetSeasonsParams @params = new Params.GetSeasonsParams();

        }
        public class GetTVShowDetails : MethodBase
        {
            public GetTVShowDetails() { }
            public GetTVShowDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetTVShowDetails;
            public Params.GetTVShowDetailsParams @params = new Params.GetTVShowDetailsParams();

        }
        public class GetTVShows : MethodBase
        {
            public GetTVShows() { }
            public GetTVShows(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.GetTVShows;
            public Params.GetTVShowsParams @params = new Params.GetTVShowsParams();

        }
        public class RemoveEpisode : MethodBase
        {
            public RemoveEpisode() { }
            public RemoveEpisode(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.RemoveEpisode;
            public Params.RemoveEpisodeParams @params = new Params.RemoveEpisodeParams();

        }
        public class RemoveMovie : MethodBase
        {
            public RemoveMovie() { }
            public RemoveMovie(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.RemoveMovie;
            public Params.RemoveMovieParams @params = new Params.RemoveMovieParams();

        }
        public class RemoveMusicVideo : MethodBase
        {
            public RemoveMusicVideo() { }
            public RemoveMusicVideo(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.RemoveMusicVideo;
            public Params.RemoveMusicVideoParams @params = new Params.RemoveMusicVideoParams();

        }
        public class RemoveTVShow : MethodBase
        {
            public RemoveTVShow() { }
            public RemoveTVShow(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.RemoveTVShow;
            public Params.RemoveTVShowParams @params = new Params.RemoveTVShowParams();

        }
        public class Scan : MethodBase
        {
            public Scan() { }
            public Scan(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.Scan;
            public Params.ScanParams @params = new Params.ScanParams();

        }
        public class SetEpisodeDetails : MethodBase
        {
            public SetEpisodeDetails() { }
            public SetEpisodeDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.SetEpisodeDetails;
            public Params.SetEpisodeDetailsParams @params = new Params.SetEpisodeDetailsParams();

        }
        public class SetMovieDetails : MethodBase
        {
            public SetMovieDetails() { }
            public SetMovieDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.SetMovieDetails;
            public Params.SetMovieDetailsParams @params = new Params.SetMovieDetailsParams();

        }
        public class SetMusicVideoDetails : MethodBase
        {
            public SetMusicVideoDetails() { }
            public SetMusicVideoDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.SetMusicVideoDetails;
            public Params.SetMusicVideoDetailsParams @params = new Params.SetMusicVideoDetailsParams();

        }
        public class SetTVShowDetails : MethodBase
        {
            public SetTVShowDetails() { }
            public SetTVShowDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.VideoLibrary.SetTVShowDetails;
            public Params.SetTVShowDetailsParams @params = new Params.SetTVShowDetailsParams();

        }
    }
    namespace Params
    {
        public class CleanParams
        {
            public bool showdialogs;
        }
        public class ExportParams
        {
            public string window;
        }
        public class GetEpisodeDetailsParams
        {
            public string window;
        }
        public class GetEpisodesParams
        {
            public string window;
        }
        public class GetGenresParams
        {
            public string window;
        }
        public class GetMovieDetailsParams
        {
            public string window;
        }
        public class GetMovieSetDetailsParams
        {
            public string window;
        }
        public class GetMovieSetsParams
        {
            public string window;
        }
        public class GetMoviesParams
        {
            public string window;
        }
        public class GetMusicVideoDetailsParams
        {
            public string window;
        }
        public class GetMusicVideosParams
        {
            public string window;
        }
        public class GetRecentlyAddedEpisodesParams
        {
            public string window;
        }
        public class GetRecentlyAddedMoviesParams
        {
            public string window;
        }
        public class GetRecentlyAddedMusicVideosParams
        {
            public string window;
        }
        public class GetSeasonsParams
        {
            public string window;
        }
        public class GetTVShowDetailsParams
        {
            public string window;
        }
        public class GetTVShowsParams
        {
            public string window;
        }
        public class RemoveEpisodeParams
        {
            public string window;
        }
        public class RemoveMovieParams
        {
            public string window;
        }
        public class RemoveMusicVideoParams
        {
            public string window;
        }
        public class RemoveTVShowParams
        {
            public string window;
        }
        public class ScanParams
        {
            public string window;
        }
        public class SetEpisodeDetailsParams
        {
            public string window;
        }
        public class SetMovieDetailsParams
        {
            public string window;
        }
        public class SetMusicVideoDetailsParams
        {
            public string window;
        }
        public class SetTVShowDetailsParams
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
        public class GetEpisodeDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetEpisodesResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetGenresResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetMovieDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetMovieSetDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetMovieSetsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetMoviesResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetMusicVideoDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetMusicVideosResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetRecentlyAddedEpisodesResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetRecentlyAddedMoviesResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetRecentlyAddedMusicVideosResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetSeasonsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetTVShowDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetTVShowsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class RemoveEpisodeResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class RemoveMovieResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class RemoveMusicVideoResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class RemoveTVShowResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ScanResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetEpisodeDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetMovieDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetMusicVideoDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class SetTVShowDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
    }
}