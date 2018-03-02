/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.Wireless 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchSimOptions
    /// </summary>
    public class FetchSimOptions : IOptions<SimResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchSimOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public FetchSimOptions(string pathSid)
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
    /// ReadSimOptions
    /// </summary>
    public class ReadSimOptions : ReadOptions<SimResource> 
    {
        /// <summary>
        /// The status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// The iccid
        /// </summary>
        public string Iccid { get; set; }
        /// <summary>
        /// The rate_plan
        /// </summary>
        public string RatePlan { get; set; }
        /// <summary>
        /// The e_id
        /// </summary>
        public string EId { get; set; }
        /// <summary>
        /// The sim_registration_code
        /// </summary>
        public string SimRegistrationCode { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status));
            }

            if (Iccid != null)
            {
                p.Add(new KeyValuePair<string, string>("Iccid", Iccid));
            }

            if (RatePlan != null)
            {
                p.Add(new KeyValuePair<string, string>("RatePlan", RatePlan));
            }

            if (EId != null)
            {
                p.Add(new KeyValuePair<string, string>("EId", EId));
            }

            if (SimRegistrationCode != null)
            {
                p.Add(new KeyValuePair<string, string>("SimRegistrationCode", SimRegistrationCode));
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
    /// UpdateSimOptions
    /// </summary>
    public class UpdateSimOptions : IOptions<SimResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The callback_method
        /// </summary>
        public string CallbackMethod { get; set; }
        /// <summary>
        /// The callback_url
        /// </summary>
        public Uri CallbackUrl { get; set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The rate_plan
        /// </summary>
        public string RatePlan { get; set; }
        /// <summary>
        /// The status
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// The commands_callback_method
        /// </summary>
        public Twilio.Http.HttpMethod CommandsCallbackMethod { get; set; }
        /// <summary>
        /// The commands_callback_url
        /// </summary>
        public Uri CommandsCallbackUrl { get; set; }
        /// <summary>
        /// The sms_fallback_method
        /// </summary>
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; set; }
        /// <summary>
        /// The sms_fallback_url
        /// </summary>
        public Uri SmsFallbackUrl { get; set; }
        /// <summary>
        /// The sms_method
        /// </summary>
        public Twilio.Http.HttpMethod SmsMethod { get; set; }
        /// <summary>
        /// The sms_url
        /// </summary>
        public Uri SmsUrl { get; set; }
        /// <summary>
        /// The voice_fallback_method
        /// </summary>
        public Twilio.Http.HttpMethod VoiceFallbackMethod { get; set; }
        /// <summary>
        /// The voice_fallback_url
        /// </summary>
        public Uri VoiceFallbackUrl { get; set; }
        /// <summary>
        /// The voice_method
        /// </summary>
        public Twilio.Http.HttpMethod VoiceMethod { get; set; }
        /// <summary>
        /// The voice_url
        /// </summary>
        public Uri VoiceUrl { get; set; }

        /// <summary>
        /// Construct a new UpdateSimOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public UpdateSimOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (CallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackMethod", CallbackMethod));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (RatePlan != null)
            {
                p.Add(new KeyValuePair<string, string>("RatePlan", RatePlan.ToString()));
            }

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status));
            }

            if (CommandsCallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsCallbackMethod", CommandsCallbackMethod.ToString()));
            }

            if (CommandsCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsCallbackUrl", Serializers.Url(CommandsCallbackUrl)));
            }

            if (SmsFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackMethod", SmsFallbackMethod.ToString()));
            }

            if (SmsFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsFallbackUrl", Serializers.Url(SmsFallbackUrl)));
            }

            if (SmsMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsMethod", SmsMethod.ToString()));
            }

            if (SmsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("SmsUrl", Serializers.Url(SmsUrl)));
            }

            if (VoiceFallbackMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackMethod", VoiceFallbackMethod.ToString()));
            }

            if (VoiceFallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceFallbackUrl", Serializers.Url(VoiceFallbackUrl)));
            }

            if (VoiceMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceMethod", VoiceMethod.ToString()));
            }

            if (VoiceUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceUrl", Serializers.Url(VoiceUrl)));
            }

            return p;
        }
    }

}