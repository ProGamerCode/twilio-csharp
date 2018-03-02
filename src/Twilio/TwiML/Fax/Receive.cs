/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;

namespace Twilio.TwiML.Fax 
{

    /// <summary>
    /// Receive TwiML Verb
    /// </summary>
    public class Receive : TwiML 
    {
        /// <summary>
        /// Receive action URL
        /// </summary>
        public Uri Action { get; set; }
        /// <summary>
        /// Receive action URL method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }

        /// <summary>
        /// Create a new Receive
        /// </summary>
        /// <param name="action"> Receive action URL </param>
        /// <param name="method"> Receive action URL method </param>
        public Receive(Uri action = null, Twilio.Http.HttpMethod method = null) : base("Receive")
        {
            this.Action = action;
            this.Method = method;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.Action != null)
            {
                attributes.Add(new XAttribute("action", Serializers.Url(this.Action)));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Receive Append(TwiML childElem)
        {
            return (Receive) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Receive SetOption(string key, object value)
        {
            return (Receive) base.SetOption(key, value);
        }
    }

}