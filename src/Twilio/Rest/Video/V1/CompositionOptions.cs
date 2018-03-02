/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Video.V1 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchCompositionOptions
    /// </summary>
    public class FetchCompositionOptions : IOptions<CompositionResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchCompositionOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public FetchCompositionOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// ReadCompositionOptions
    /// </summary>
    public class ReadCompositionOptions : ReadOptions<CompositionResource> 
    {
        /// <summary>
        /// The status
        /// </summary>
        public CompositionResource.StatusEnum Status { get; set; }
        /// <summary>
        /// The date_created_after
        /// </summary>
        public DateTime? DateCreatedAfter { get; set; }
        /// <summary>
        /// The date_created_before
        /// </summary>
        public DateTime? DateCreatedBefore { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (DateCreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedAfter", Serializers.DateTimeIso8601(DateCreatedAfter)));
            }

            if (DateCreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedBefore", Serializers.DateTimeIso8601(DateCreatedBefore)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// DeleteCompositionOptions
    /// </summary>
    public class DeleteCompositionOptions : IOptions<CompositionResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteCompositionOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public DeleteCompositionOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// CreateCompositionOptions
    /// </summary>
    public class CreateCompositionOptions : IOptions<CompositionResource> 
    {
        /// <summary>
        /// The audio_sources
        /// </summary>
        public List<string> AudioSources { get; set; }
        /// <summary>
        /// The video_sources
        /// </summary>
        public List<string> VideoSources { get; set; }
        /// <summary>
        /// The video_layout
        /// </summary>
        public CompositionResource.VideoLayoutEnum VideoLayout { get; set; }
        /// <summary>
        /// The resolution
        /// </summary>
        public string Resolution { get; set; }
        /// <summary>
        /// The format
        /// </summary>
        public CompositionResource.FormatEnum Format { get; set; }
        /// <summary>
        /// The desired_bitrate
        /// </summary>
        public int? DesiredBitrate { get; set; }
        /// <summary>
        /// The desired_max_duration
        /// </summary>
        public int? DesiredMaxDuration { get; set; }
        /// <summary>
        /// The status_callback
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// The status_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// The trim
        /// </summary>
        public bool? Trim { get; set; }
        /// <summary>
        /// The reuse
        /// </summary>
        public bool? Reuse { get; set; }

        /// <summary>
        /// Construct a new CreateCompositionOptions
        /// </summary>
        public CreateCompositionOptions()
        {
            AudioSources = new List<string>();
            VideoSources = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AudioSources != null)
            {
                p.AddRange(AudioSources.Select(prop => new KeyValuePair<string, string>("AudioSources", prop.ToString())));
            }

            if (VideoSources != null)
            {
                p.AddRange(VideoSources.Select(prop => new KeyValuePair<string, string>("VideoSources", prop.ToString())));
            }

            if (VideoLayout != null)
            {
                p.Add(new KeyValuePair<string, string>("VideoLayout", VideoLayout.ToString()));
            }

            if (Resolution != null)
            {
                p.Add(new KeyValuePair<string, string>("Resolution", Resolution));
            }

            if (Format != null)
            {
                p.Add(new KeyValuePair<string, string>("Format", Format.ToString()));
            }

            if (DesiredBitrate != null)
            {
                p.Add(new KeyValuePair<string, string>("DesiredBitrate", DesiredBitrate.Value.ToString()));
            }

            if (DesiredMaxDuration != null)
            {
                p.Add(new KeyValuePair<string, string>("DesiredMaxDuration", DesiredMaxDuration.Value.ToString()));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (StatusCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallbackMethod", StatusCallbackMethod.ToString()));
            }

            if (Trim != null)
            {
                p.Add(new KeyValuePair<string, string>("Trim", Trim.Value.ToString().ToLower()));
            }

            if (Reuse != null)
            {
                p.Add(new KeyValuePair<string, string>("Reuse", Reuse.Value.ToString().ToLower()));
            }

            return p;
        }
    }

}