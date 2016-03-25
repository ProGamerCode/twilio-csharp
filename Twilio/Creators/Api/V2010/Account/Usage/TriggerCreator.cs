using System;
using Twilio.Clients;
using Twilio.Creators;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Resources.Api.V2010.Account.Usage;

namespace Twilio.Creators.Api.V2010.Account.Usage {

    public class TriggerCreator : Creator<TriggerResource> {
        private string accountSid;
        private Uri callbackUrl;
        private string triggerValue;
        private TriggerResource.UsageCategory usageCategory;
        private System.Net.Http.HttpMethod callbackMethod;
        private string friendlyName;
        private TriggerResource.Recurring recurring;
        private TriggerResource.TriggerField triggerBy;
    
        /**
         * Construct a new TriggerCreator
         * 
         * @param accountSid The account_sid
         * @param callbackUrl URL Twilio will request when the trigger fires
         * @param triggerValue the value at which the trigger will fire
         * @param usageCategory The usage category the trigger watches
         */
        public TriggerCreator(string accountSid, Uri callbackUrl, string triggerValue, TriggerResource.UsageCategory usageCategory) {
            this.accountSid = accountSid;
            this.callbackUrl = callbackUrl;
            this.triggerValue = triggerValue;
            this.usageCategory = usageCategory;
        }
    
        /**
         * The HTTP method Twilio will use when making a request to the CallbackUrl. 
         * GET or POST.
         * 
         * @param callbackMethod HTTP method to use with callback_url
         * @return this
         */
        public TriggerCreator setCallbackMethod(System.Net.Http.HttpMethod callbackMethod) {
            this.callbackMethod = callbackMethod;
            return this;
        }
    
        /**
         * A user-specified, human-readable name for the trigger.
         * 
         * @param friendlyName A user-specified, human-readable name for the trigger.
         * @return this
         */
        public TriggerCreator setFriendlyName(string friendlyName) {
            this.friendlyName = friendlyName;
            return this;
        }
    
        /**
         * How this trigger recurs. Empty for non-recurring triggers. One of `daily`,
         * `monthly`, or `yearly` for recurring triggers.  A trigger will only fire once
         * during each recurring period.  Recurring periods are in GMT.
         * 
         * @param recurring How this trigger recurs
         * @return this
         */
        public TriggerCreator setRecurring(TriggerResource.Recurring recurring) {
            this.recurring = recurring;
            return this;
        }
    
        /**
         * The field in the UsageRecord that fires the trigger. One of `count`, `usage`,
         * or `price`
         * 
         * @param triggerBy The field in the UsageRecord that fires the trigger
         * @return this
         */
        public TriggerCreator setTriggerBy(TriggerResource.TriggerField triggerBy) {
            this.triggerBy = triggerBy;
            return this;
        }
    
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client TwilioRestClient with which to make the request
         * @return Created TriggerResource
         */
        public override TriggerResource execute(TwilioRestClient client) {
            Request request = new Request(
                System.Net.Http.HttpMethod.Post,
                TwilioRestClient.Domains.API,
                "/2010-04-01/Accounts/" + this.accountSid + "/Usage/Triggers.json"
            );
            
            addPostParams(request);
            Response response = client.request(request);
            
            if (response == null) {
                throw new ApiConnectionException("TriggerResource creation failed: Unable to connect to server");
            } else if (response.GetStatusCode() != TwilioRestClient.HTTP_STATUS_CODE_CREATED) {
                RestException restException = RestException.fromJson(response.GetContent());
                if (restException == null)
                    throw new ApiException("Server Error, no content");
                throw new ApiException(
                    restException.GetMessage(),
                    restException.GetCode(),
                    restException.GetMoreInfo(),
                    restException.GetStatus(),
                    null
                );
            }
            
            return TriggerResource.fromJson(response.GetContent());
        }
    
        /**
         * Add the requested post parameters to the Request
         * 
         * @param request Request to add post params to
         */
        private void addPostParams(Request request) {
            if (callbackUrl != null) {
                request.addPostParam("CallbackUrl", callbackUrl.ToString());
            }
            
            if (triggerValue != null) {
                request.addPostParam("TriggerValue", triggerValue);
            }
            
            if (usageCategory != null) {
                request.addPostParam("UsageCategory", usageCategory.ToString());
            }
            
            if (callbackMethod != null) {
                request.addPostParam("CallbackMethod", callbackMethod.ToString());
            }
            
            if (friendlyName != null) {
                request.addPostParam("FriendlyName", friendlyName);
            }
            
            if (recurring != null) {
                request.addPostParam("Recurring", recurring.ToString());
            }
            
            if (triggerBy != null) {
                request.addPostParam("TriggerBy", triggerBy.ToString());
            }
        }
    }
}