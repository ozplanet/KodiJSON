using KodiJSON.Global.List;

namespace KodiJSON.Files
{
    namespace Methods
    {
        public class GetDirectory : MethodBase
        {
            public GetDirectory() { }
            public GetDirectory(string window)
            {
                //@params.window = window;
            }

            public readonly string method = Global.Methods.Files.GetDirectory;
            public Params.GetDirectoryParams @params = new Params.GetDirectoryParams();

        }
        public class GetFileDetails : MethodBase
        {
            public GetFileDetails() { }
            public GetFileDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Files.GetFileDetails;
            public Params.GetFileDetailsParams @params = new Params.GetFileDetailsParams();

        }
        public class GetSources : MethodBase
        {
            public GetSources() { }
            public GetSources(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Files.GetSources;
            public Params.GetSourcesParams @params = new Params.GetSourcesParams();

        }
        public class PrepareDownload : MethodBase
        {
            public PrepareDownload() { }
            public PrepareDownload(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Files.PrepareDownload;
            public Params.PrepareDownloadParams @params = new Params.PrepareDownloadParams();

        }
    }
    namespace Params
    {
        public class GetDirectoryParams
        {
            public string directory = "y";
            public string media = Global.Files.Media.files;
            public string[] properties = { Global.List.Fields.Files.album,
                                           Global.List.Fields.Files.albumartist,
                                           Global.List.Fields.Files.albumartistid,
                                           Global.List.Fields.Files.albumid,
                                           Global.List.Fields.Files.albumlabel,
                                           Global.List.Fields.Files.art,
                                           Global.List.Fields.Files.artist,
                                           Global.List.Fields.Files.artistid,
                                           Global.List.Fields.Files.cast,
                                           Global.List.Fields.Files.comment,
                                           Global.List.Fields.Files.country,
                                           Global.List.Fields.Files.dateadded,
                                           Global.List.Fields.Files.description,
                                           Global.List.Fields.Files.director,
                                           Global.List.Fields.Files.disc,
                                           Global.List.Fields.Files.displayartist,
                                           Global.List.Fields.Files.duration,
                                           Global.List.Fields.Files.episode,
                                           Global.List.Fields.Files.episodeguide,
                                           Global.List.Fields.Files.fanart,
                                           Global.List.Fields.Files.file,
                                           Global.List.Fields.Files.firstaired,
                                           Global.List.Fields.Files.genre,
                                           Global.List.Fields.Files.genreid,
                                           Global.List.Fields.Files.imdbnumber,
                                           Global.List.Fields.Files.lastmodified,
                                           Global.List.Fields.Files.lastplayed,
                                           Global.List.Fields.Files.lyrics,
                                           Global.List.Fields.Files.mimetype,
                                           Global.List.Fields.Files.mood,
                                           Global.List.Fields.Files.mpaa,
                                           Global.List.Fields.Files.musicbrainzalbumartistid,
                                           Global.List.Fields.Files.musicbrainzalbumid,
                                           Global.List.Fields.Files.musicbrainzartistid,
                                           Global.List.Fields.Files.musicbrainztrackid,
                                           Global.List.Fields.Files.originaltitle,
                                           Global.List.Fields.Files.playcount,
                                           Global.List.Fields.Files.plot,
                                           Global.List.Fields.Files.plotoutline,
                                           Global.List.Fields.Files.premiered,
                                           Global.List.Fields.Files.productioncode,
                                           Global.List.Fields.Files.rating,
                                           Global.List.Fields.Files.resume,
                                           Global.List.Fields.Files.runtime,
                                           Global.List.Fields.Files.season,
                                           Global.List.Fields.Files.set,
                                           Global.List.Fields.Files.setid,
                                           Global.List.Fields.Files.showlink,
                                           Global.List.Fields.Files.showtitle,
                                           Global.List.Fields.Files.size,
                                           Global.List.Fields.Files.sorttitle,
                                           Global.List.Fields.Files.specialsortepisode,
                                           Global.List.Fields.Files.specialsortseason,
                                           Global.List.Fields.Files.streamdetails,
                                           Global.List.Fields.Files.studio,
                                           Global.List.Fields.Files.style,
                                           Global.List.Fields.Files.tag,
                                           Global.List.Fields.Files.tagline,
                                           Global.List.Fields.Files.theme,
                                           Global.List.Fields.Files.thumbnail,
                                           Global.List.Fields.Files.title,
                                           Global.List.Fields.Files.top250,
                                           Global.List.Fields.Files.track,
                                           Global.List.Fields.Files.trailer,
                                           Global.List.Fields.Files.tvshowid,
                                           Global.List.Fields.Files.uniqueid,
                                           Global.List.Fields.Files.votes,
                                           Global.List.Fields.Files.watchedepisodes,
                                           Global.List.Fields.Files.writer,
                                           Global.List.Fields.Files.year};
            public string sort;
            public Limits limit = new Limits();
        }
        public class GetFileDetailsParams
        {
            public string window;
        }
        public class GetSourcesParams
        {
            public string window;
        }
        public class PrepareDownloadParams
        {
            public string window;
        }
    }
    namespace Response
    {
        public class DownloadResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetDirectoryResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetFileDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetSourcesResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class PrepareDownloadResponse : ResponseBase
        {
            public string result { get; set; }
        }
    }
}