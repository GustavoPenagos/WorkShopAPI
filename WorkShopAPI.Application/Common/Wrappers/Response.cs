using Newtonsoft.Json;

namespace WorkShopAPI.Application.Common.Wrappers
{
    public class Response
    {

        [JsonProperty("msgRsHdr")]
        public  MsgRsHdr? MsgRsHdr { get; set; }
        [JsonProperty("body")]
        public   Body? Body { get; set; }
    }

    public class Body
    {
        [JsonProperty("result")]
        public object? Result { get; set; }
    }

    public class MsgRsHdr
    {
        [JsonProperty("error")]
        public Error? Error { get; set; }
    }

    public class Error
    {
        [JsonProperty("status")]
        public  int Status { get; set; }
        [JsonProperty("statusDesc")]
        public string? StatusDesc { get; set; }

    }
}
