using System.Collections.Generic;

namespace KodiJSON.Favourites
{
    namespace Methods
    {
        public class AddFavourite : MethodBase
        {
            public AddFavourite() { }
            public AddFavourite(string title, 
                                string type,
                                string path,
                                string window,
                                string windowparameter,
                                string thumbnail)
            {
                @params.title = title;
                @params.type = type;
                @params.path = path;
                @params.window = window;
                @params.windowparameter = windowparameter;
                @params.thumbnail = thumbnail;
            }

            public readonly string method = Global.Methods.Favourites.AddFavourite;
            public Params.AddFavouriteParams @params = new Params.AddFavouriteParams();

        }
        public class GetFavourites : MethodBase
        {
            public GetFavourites() { }
            public GetFavourites(string type, string[] properties)
            {
                @params.type = type;
                @params.properties = properties;
            }

            public readonly string method = Global.Methods.Favourites.GetFavourites;
            public Params.GetFavouritesParams @params = new Params.GetFavouritesParams();

        }
    }
    namespace Params
    {
        public class AddFavouriteParams
        {
            public string title;
            public string type = Global.Favourite.Type.media;
            public string path;
            public string window;
            public string windowparameter;
            public string thumbnail;
        }
        public class GetFavouritesParams
        {
            public string type = Global.Favourite.Type.media;
            public string[] properties = { Global.Favourite.Fields.Favourite.path,
                                           Global.Favourite.Fields.Favourite.thumbnail,
                                           Global.Favourite.Fields.Favourite.window,
                                           Global.Favourite.Fields.Favourite.windowparameter };
        }
    }
    namespace Response
    {
        public class AddFavouriteResponse : ResponseBase
        {
            public string result { get; set; }
        }
        public class GetFavouritesResponse : ResponseBase
        {
            public Result result { get; set; }
            public class Favourite
            {
                public string path { get; set; }
                public string thumbnail { get; set; }
                public string title { get; set; }
                public string type { get; set; }
            }

            public class Result
            {
                public List<Favourite> favourites { get; set; }
                public Global.List.Limits limits { get; set; }
            }
        }
    }
}