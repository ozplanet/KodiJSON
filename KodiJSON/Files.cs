namespace KodiJSON.Files
{
    namespace Methods
    {
        public class Download : MethodBase
        {
            public Download() { }
            public Download(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.Files.Download;
            public Params.DownloadParams @params = new Params.DownloadParams();

        }
        public class GetDirectory : MethodBase
        {
            public GetDirectory() { }
            public GetDirectory(string window)
            {
                @params.window = window;
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
        public class DownloadParams
        {
            public string window;
        }
        public class GetDirectoryParams
        {
            public string window;
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