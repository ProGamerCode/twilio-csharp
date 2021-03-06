/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// RoomResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Video.V1 
{

    public class RoomResource : Resource 
    {
        public sealed class RoomStatusEnum : StringEnum 
        {
            private RoomStatusEnum(string value) : base(value) {}
            public RoomStatusEnum() {}
            public static implicit operator RoomStatusEnum(string value)
            {
                return new RoomStatusEnum(value);
            }

            public static readonly RoomStatusEnum InProgress = new RoomStatusEnum("in-progress");
            public static readonly RoomStatusEnum Completed = new RoomStatusEnum("completed");
            public static readonly RoomStatusEnum Failed = new RoomStatusEnum("failed");
        }

        public sealed class RoomTypeEnum : StringEnum 
        {
            private RoomTypeEnum(string value) : base(value) {}
            public RoomTypeEnum() {}
            public static implicit operator RoomTypeEnum(string value)
            {
                return new RoomTypeEnum(value);
            }

            public static readonly RoomTypeEnum PeerToPeer = new RoomTypeEnum("peer-to-peer");
            public static readonly RoomTypeEnum Group = new RoomTypeEnum("group");
        }

        public sealed class VideoCodecEnum : StringEnum 
        {
            private VideoCodecEnum(string value) : base(value) {}
            public VideoCodecEnum() {}
            public static implicit operator VideoCodecEnum(string value)
            {
                return new VideoCodecEnum(value);
            }

            public static readonly VideoCodecEnum Vp8 = new VideoCodecEnum("VP8");
            public static readonly VideoCodecEnum H264 = new VideoCodecEnum("H264");
        }

        private static Request BuildFetchRequest(FetchRoomOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Rooms/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns> 
        public static RoomResource Fetch(FetchRoomOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns> 
        public static async System.Threading.Tasks.Task<RoomResource> FetchAsync(FetchRoomOptions options, 
                                                                                 ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns> 
        public static RoomResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchRoomOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns> 
        public static async System.Threading.Tasks.Task<RoomResource> FetchAsync(string pathSid, 
                                                                                 ITwilioRestClient client = null)
        {
            var options = new FetchRoomOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateRoomOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Video,
                "/v1/Rooms",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns> 
        public static RoomResource Create(CreateRoomOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns> 
        public static async System.Threading.Tasks.Task<RoomResource> CreateAsync(CreateRoomOptions options, 
                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="enableTurn"> The enable_turn </param>
        /// <param name="type"> The type </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="statusCallbackMethod"> The status_callback_method </param>
        /// <param name="maxParticipants"> The max_participants </param>
        /// <param name="recordParticipantsOnConnect"> The record_participants_on_connect </param>
        /// <param name="videoCodecs"> The video_codecs </param>
        /// <param name="mediaRegion"> The media_region </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns> 
        public static RoomResource Create(bool? enableTurn = null, 
                                          RoomResource.RoomTypeEnum type = null, 
                                          string uniqueName = null, 
                                          Uri statusCallback = null, 
                                          Twilio.Http.HttpMethod statusCallbackMethod = null, 
                                          int? maxParticipants = null, 
                                          bool? recordParticipantsOnConnect = null, 
                                          List<RoomResource.VideoCodecEnum> videoCodecs = null, 
                                          string mediaRegion = null, 
                                          ITwilioRestClient client = null)
        {
            var options = new CreateRoomOptions(){EnableTurn = enableTurn, Type = type, UniqueName = uniqueName, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, MaxParticipants = maxParticipants, RecordParticipantsOnConnect = recordParticipantsOnConnect, VideoCodecs = videoCodecs, MediaRegion = mediaRegion};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="enableTurn"> The enable_turn </param>
        /// <param name="type"> The type </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="statusCallbackMethod"> The status_callback_method </param>
        /// <param name="maxParticipants"> The max_participants </param>
        /// <param name="recordParticipantsOnConnect"> The record_participants_on_connect </param>
        /// <param name="videoCodecs"> The video_codecs </param>
        /// <param name="mediaRegion"> The media_region </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns> 
        public static async System.Threading.Tasks.Task<RoomResource> CreateAsync(bool? enableTurn = null, 
                                                                                  RoomResource.RoomTypeEnum type = null, 
                                                                                  string uniqueName = null, 
                                                                                  Uri statusCallback = null, 
                                                                                  Twilio.Http.HttpMethod statusCallbackMethod = null, 
                                                                                  int? maxParticipants = null, 
                                                                                  bool? recordParticipantsOnConnect = null, 
                                                                                  List<RoomResource.VideoCodecEnum> videoCodecs = null, 
                                                                                  string mediaRegion = null, 
                                                                                  ITwilioRestClient client = null)
        {
            var options = new CreateRoomOptions(){EnableTurn = enableTurn, Type = type, UniqueName = uniqueName, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, MaxParticipants = maxParticipants, RecordParticipantsOnConnect = recordParticipantsOnConnect, VideoCodecs = videoCodecs, MediaRegion = mediaRegion};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadRoomOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Rooms",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns> 
        public static ResourceSet<RoomResource> Read(ReadRoomOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<RoomResource>.FromJson("rooms", response.Content);
            return new ResourceSet<RoomResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<RoomResource>> ReadAsync(ReadRoomOptions options, 
                                                                                             ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<RoomResource>.FromJson("rooms", response.Content);
            return new ResourceSet<RoomResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="status"> The status </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="dateCreatedAfter"> The date_created_after </param>
        /// <param name="dateCreatedBefore"> The date_created_before </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns> 
        public static ResourceSet<RoomResource> Read(RoomResource.RoomStatusEnum status = null, 
                                                     string uniqueName = null, 
                                                     DateTime? dateCreatedAfter = null, 
                                                     DateTime? dateCreatedBefore = null, 
                                                     int? pageSize = null, 
                                                     long? limit = null, 
                                                     ITwilioRestClient client = null)
        {
            var options = new ReadRoomOptions(){Status = status, UniqueName = uniqueName, DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="status"> The status </param>
        /// <param name="uniqueName"> The unique_name </param>
        /// <param name="dateCreatedAfter"> The date_created_after </param>
        /// <param name="dateCreatedBefore"> The date_created_before </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<RoomResource>> ReadAsync(RoomResource.RoomStatusEnum status = null, 
                                                                                             string uniqueName = null, 
                                                                                             DateTime? dateCreatedAfter = null, 
                                                                                             DateTime? dateCreatedBefore = null, 
                                                                                             int? pageSize = null, 
                                                                                             long? limit = null, 
                                                                                             ITwilioRestClient client = null)
        {
            var options = new ReadRoomOptions(){Status = status, UniqueName = uniqueName, DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<RoomResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<RoomResource>.FromJson("rooms", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<RoomResource> NextPage(Page<RoomResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Video,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<RoomResource>.FromJson("rooms", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<RoomResource> PreviousPage(Page<RoomResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Video,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<RoomResource>.FromJson("rooms", response.Content);
        }

        private static Request BuildUpdateRequest(UpdateRoomOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Video,
                "/v1/Rooms/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns> 
        public static RoomResource Update(UpdateRoomOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Room parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns> 
        public static async System.Threading.Tasks.Task<RoomResource> UpdateAsync(UpdateRoomOptions options, 
                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        /// <param name="status"> The status </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Room </returns> 
        public static RoomResource Update(string pathSid, 
                                          RoomResource.RoomStatusEnum status, 
                                          ITwilioRestClient client = null)
        {
            var options = new UpdateRoomOptions(pathSid, status);
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        /// <param name="status"> The status </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Room </returns> 
        public static async System.Threading.Tasks.Task<RoomResource> UpdateAsync(string pathSid, 
                                                                                  RoomResource.RoomStatusEnum status, 
                                                                                  ITwilioRestClient client = null)
        {
            var options = new UpdateRoomOptions(pathSid, status);
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a RoomResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RoomResource object represented by the provided JSON </returns> 
        public static RoomResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<RoomResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomResource.RoomStatusEnum Status { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The enable_turn
        /// </summary>
        [JsonProperty("enable_turn")]
        public bool? EnableTurn { get; private set; }
        /// <summary>
        /// The unique_name
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The status_callback
        /// </summary>
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }
        /// <summary>
        /// The status_callback_method
        /// </summary>
        [JsonProperty("status_callback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; private set; }
        /// <summary>
        /// The end_time
        /// </summary>
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; private set; }
        /// <summary>
        /// The duration
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; private set; }
        /// <summary>
        /// The type
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RoomResource.RoomTypeEnum Type { get; private set; }
        /// <summary>
        /// The max_participants
        /// </summary>
        [JsonProperty("max_participants")]
        public int? MaxParticipants { get; private set; }
        /// <summary>
        /// The record_participants_on_connect
        /// </summary>
        [JsonProperty("record_participants_on_connect")]
        public bool? RecordParticipantsOnConnect { get; private set; }
        /// <summary>
        /// The video_codecs
        /// </summary>
        [JsonProperty("video_codecs")]
        [JsonConverter(typeof(StringEnumConverter))]
        public List<RoomResource.VideoCodecEnum> VideoCodecs { get; private set; }
        /// <summary>
        /// The media_region
        /// </summary>
        [JsonProperty("media_region")]
        public string MediaRegion { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private RoomResource()
        {

        }
    }

}