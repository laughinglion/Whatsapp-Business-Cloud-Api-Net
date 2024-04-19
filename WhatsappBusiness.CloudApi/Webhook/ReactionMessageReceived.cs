using Newtonsoft.Json;
using System.Collections.Generic;

namespace WhatsappBusiness.CloudApi.Webhook
{
    /// <summary>
    /// A reaction message you received from a customer
    /// </summary>
    public class ReactionMessageReceived
    {
        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("entry")]
        public List<ReactionMessageEntry> Entries { get; set; }
    }

    public class ReactionMessageEntry
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("changes")]
        public List<ReactionMessageChange> Changes { get; set; }
    }

    public class ReactionMessageChange
    {
        [JsonProperty("value")]
        public ReactionMessageValue Value { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }
    }

    public class ReactionMessageValue
    {
        [JsonProperty("messaging_product")]
        public string MessagingProduct { get; set; }

        [JsonProperty("metadata")]
        public TextMessageMetadata Metadata { get; set; }

        [JsonProperty("contacts")]
        public List<TextMessageContact> Contacts { get; set; }

        [JsonProperty("messages")]
        public List<ReactionMessage> Messages { get; set; }
    }

    public class ReactionMessage
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("reaction")]
        public ReactionMessageReaction Reaction { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("context")]
        public TextMessageContext? Context { get; set; }
    }

    public class ReactionMessageReaction
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("emoji")]
        public string Emoji { get; set; }
    }
}