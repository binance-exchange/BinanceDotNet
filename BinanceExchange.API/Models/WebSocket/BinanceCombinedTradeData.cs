using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BinanceExchange.API.Models.WebSocket.Interfaces
{
    [DataContract]
    public class BinanceCombinedTradeData : IWebSocketResponse
    {
        [DataMember(Order = 1)]
        [JsonProperty(PropertyName = "stream")]
        public string Stream { get; set; }

        [DataMember(Order = 2)]
        [JsonProperty(PropertyName = "data")]
        public BinanceTradeOrderData Data { get; set; }

        public string EventType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime EventTime { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
