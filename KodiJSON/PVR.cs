namespace KodiJSON.PVR
{
    namespace Methods
    {
        public class GetChannelDetails : MethodBase
        {
            public GetChannelDetails() { }
            public GetChannelDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.PVR.GetChannelDetails;
            public Params.GetChannelDetailsParams @params = new Params.GetChannelDetailsParams();

        }
        public class GetChannelGroupDetails : MethodBase
        {
            public GetChannelGroupDetails() { }
            public GetChannelGroupDetails(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.PVR.GetChannelGroupDetails;
            public Params.GetChannelGroupDetailsParams @params = new Params.GetChannelGroupDetailsParams();

        }
        public class GetChannelGroups : MethodBase
        {
            public GetChannelGroups() { }
            public GetChannelGroups(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.PVR.GetChannelGroups;
            public Params.GetChannelGroupsParams @params = new Params.GetChannelGroupsParams();

        }
        public class GetChannels : MethodBase
        {
            public GetChannels() { }
            public GetChannels(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.PVR.GetChannels;
            public Params.GetChannelsParams @params = new Params.GetChannelsParams();

        }
        public class GetProperties : MethodBase
        {
            public GetProperties() { }
            public GetProperties(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.PVR.GetProperties;
            public Params.GetPropertiesParams @params = new Params.GetPropertiesParams();

        }
        public class Record : MethodBase
        {
            public Record() { }
            public Record(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.PVR.Record;
            public Params.RecordParams @params = new Params.RecordParams();

        }
        public class Scan : MethodBase
        {
            public Scan() { }
            public Scan(string window)
            {
                @params.window = window;
            }

            public readonly string method = Global.Methods.PVR.Scan;
            public Params.ScanParams @params = new Params.ScanParams();

        }
    }
    namespace Params
    {
        public class GetChannelDetailsParams
        {
            public string window;
        }
        public class GetChannelGroupDetailsParams
        {
            public string window;
        }
        public class GetChannelGroupsParams
        {
            public string window;
        }
        public class GetChannelsParams
        {
            public string window;
        }
        public class GetPropertiesParams
        {
            public string window;
        }
        public class RecordParams
        {
            public string window;
        }
        public class ScanParams
        {
            public string window;
        }
    }
    namespace Response
    {
        public class GetChannelDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetChannelGroupDetailsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetChannelGroupsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetChannelsResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetPropertiesResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class RecordResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class ScanResponse : ResponseBase
        {
            public string result { get; set; }
        }
    }
}

