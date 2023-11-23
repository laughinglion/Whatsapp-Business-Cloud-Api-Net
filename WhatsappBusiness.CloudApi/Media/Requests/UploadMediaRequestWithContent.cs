using Newtonsoft.Json;

namespace WhatsappBusiness.CloudApi.Media.Requests
{
    public class UploadMediaRequestWithContent
    {
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; private set; } = "whatsapp";

        public byte[] FileContent { get; set; }

        public string FileName { get; set; }

        /// <summary>
        /// Type of media file being uploaded.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}