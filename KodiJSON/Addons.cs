using System.Collections.Generic;

/// <summary>
/// Completed
/// </summary>
namespace KodiJSON.Addons
{
    namespace Methods
    {
        public class ExecuteAddon : MethodBase
        {
            public ExecuteAddon() { }
            public ExecuteAddon(string addonid)
            {
                @params.addonid = addonid;
            }
            public ExecuteAddon(string addonid, string[] additionalProperties)
            {
                @params.addonid = addonid;
                //@params.additionalProperties = additionalProperties;
            }
            public ExecuteAddon(string addonid, string[] additionalProperties, bool wait = false)
            {
                @params.addonid = addonid;
                //@params.additionalProperties = additionalProperties;
                @params.wait = wait;
            }
            public readonly string method = Global.Methods.Addons.ExecuteAddon;
            public Params.ExecuteAddonParams @params = new Params.ExecuteAddonParams();
        }
        public class GetAddonDetails : MethodBase
        {
            public GetAddonDetails() { }
            public GetAddonDetails(string addonid)
            {
                @params.addonid = addonid;
            }
            public GetAddonDetails(string addonid, string[] properties)
            {
                @params.addonid = addonid;
                @params.properties = properties;
            }

            public readonly string method = Global.Methods.Addons.GetAddonDetails;
            public Params.GetAddonDetailsParams @params = new Params.GetAddonDetailsParams();

        }
        public class GetAddons : MethodBase
        {
            public GetAddons() { }
            public GetAddons(Global.List.Limits limits,
                            string type = Global.Addons.Types.unknown,
                            string content = Global.Addons.Content.unknown,
                            string enabled = Global.Addons.Boolean.All,
                            string installed = Global.Addons.Boolean.All)
            {
                @params.limits = limits;
                @params.type = type;
                @params.content = content;
                @params.enabled = enabled;
                @params.installed = installed;
            }

            public readonly string method = Global.Methods.Addons.GetAddons;
            public Params.GetAddonsParams @params = new Params.GetAddonsParams();

        }
        public class SetAddonEnabled : MethodBase
        {
            public SetAddonEnabled() { }
            public SetAddonEnabled(string addonid, bool enabled)
            {
                @params.addonid = addonid;
                @params.enabled = enabled;
            }

            public readonly string method = Global.Methods.Addons.SetAddonEnabled;
            public Params.SetAddonEnabledParams @params = new Params.SetAddonEnabledParams();

        }
    }    
    namespace Params
    {
        public class ExecuteAddonParams
        {
            public string addonid;
            //TODO Revisit - Throws an error
            //public string[] additionalProperties = { "" };
            public bool wait = false;
        }
        public class GetAddonDetailsParams
        {
            public string addonid;
            public string[] properties = { Global.Addons.Fields.name,
                                           Global.Addons.Fields.version,
                                           Global.Addons.Fields.summary,
                                           Global.Addons.Fields.description,
                                           Global.Addons.Fields.path,
                                           Global.Addons.Fields.author,
                                           Global.Addons.Fields.thumbnail,
                                           Global.Addons.Fields.disclaimer,
                                           Global.Addons.Fields.fanart,
                                           Global.Addons.Fields.dependencies,
                                           Global.Addons.Fields.broken,
                                           Global.Addons.Fields.extrainfo,
                                           Global.Addons.Fields.rating,
                                           Global.Addons.Fields.enabled,
                                           Global.Addons.Fields.installed };
        }
        public class GetAddonsParams
        {
            public string type = Global.Addons.Types.unknown;
            public string content = Global.Addons.Content.unknown;
            public string enabled = Global.Addons.Boolean.All;
            public Global.List.Limits limits = new Global.List.Limits();
            public string installed = Global.Addons.Boolean.All;
        }
        public class SetAddonEnabledParams
        {
            public string addonid;
            public bool enabled;
        }
    }
    namespace Response
    {
        public class ExecuteAddonResponse : ResponseBase
        {
           public string result { get; set; }
        }
        public class GetAddonDetailsResponse : ResponseBase
        {
            public Result result { get; set; }
            public class Dependency
            {
                public string addonid { get; set; }
                public bool optional { get; set; }
                public string version { get; set; }
            }

            public class Extrainfo
            {
                public string key { get; set; }
                public string value { get; set; }
            }

            public class Addon
            {
                public string addonid { get; set; }
                public string author { get; set; }
                public bool broken { get; set; }
                public List<Dependency> dependencies { get; set; }
                public string description { get; set; }
                public string disclaimer { get; set; }
                public bool enabled { get; set; }
                public List<Extrainfo> extrainfo { get; set; }
                public string fanart { get; set; }
                public bool installed { get; set; }
                public string name { get; set; }
                public string path { get; set; }
                public int rating { get; set; }
                public string summary { get; set; }
                public string thumbnail { get; set; }
                public string type { get; set; }
                public string version { get; set; }
            }

            public class Result
            {
                public Addon addon { get; set; }
            }
        }
        public class GetAddonsResponse : ResponseBase
        {
            public Result result { get; set; }
            public class Addon
            {
                public string addonid { get; set; }
                public string type { get; set; }
            }            

            public class Result
            {
                public List<Addon> addons { get; set; }
                public Global.List.Limits limits { get; set; }
            }
        }
        public class SetAddonEnabledResponse : ResponseBase
        {
            public string result { get; set; }
        }
    }
}