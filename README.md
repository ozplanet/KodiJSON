# KodiJSON
An object oriented way of generating JSON for Kodi JSON calls.

ShowNotification request = new ShowNotification("ShowNotificationTest", "Test ShowNotification", KodiJSON.GUI.Params.ShowNotificationParams.images.warning);

string jsonData = JsonConvert.SerializeObject(request);

using (WebClient client = new WebClient())
{
    JsonConvert.DeserializeObject<KodiJSON.GUI.Response.ShowNotificationResponse>(client.UploadString("http://localhost:8081/jsonrpc", "POST", jsonData));
}
