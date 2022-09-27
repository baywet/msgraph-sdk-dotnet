// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type UserFindMeetingTimesRequestBuilder.
    /// </summary>
    public partial class UserFindMeetingTimesRequestBuilder : BaseActionMethodRequestBuilder<IUserFindMeetingTimesRequest>, IUserFindMeetingTimesRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="UserFindMeetingTimesRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="attendees">A attendees parameter for the OData method call.</param>
        /// <param name="locationConstraint">A locationConstraint parameter for the OData method call.</param>
        /// <param name="timeConstraint">A timeConstraint parameter for the OData method call.</param>
        /// <param name="meetingDuration">A meetingDuration parameter for the OData method call.</param>
        /// <param name="maxCandidates">A maxCandidates parameter for the OData method call.</param>
        /// <param name="isOrganizerOptional">A isOrganizerOptional parameter for the OData method call.</param>
        /// <param name="returnSuggestionReasons">A returnSuggestionReasons parameter for the OData method call.</param>
        /// <param name="minimumAttendeePercentage">A minimumAttendeePercentage parameter for the OData method call.</param>
        public UserFindMeetingTimesRequestBuilder(
            string requestUrl,
            IBaseClient client,
            IEnumerable<AttendeeBase> attendees,
            LocationConstraint locationConstraint,
            TimeConstraint timeConstraint,
            Duration meetingDuration,
            Int32? maxCandidates,
            bool? isOrganizerOptional,
            bool? returnSuggestionReasons,
            double? minimumAttendeePercentage)
            : base(requestUrl, client)
        {
            this.SetParameter("attendees", attendees, true);
            this.SetParameter("locationConstraint", locationConstraint, true);
            this.SetParameter("timeConstraint", timeConstraint, true);
            this.SetParameter("meetingDuration", meetingDuration, true);
            this.SetParameter("maxCandidates", maxCandidates, true);
            this.SetParameter("isOrganizerOptional", isOrganizerOptional, true);
            this.SetParameter("returnSuggestionReasons", returnSuggestionReasons, true);
            this.SetParameter("minimumAttendeePercentage", minimumAttendeePercentage, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IUserFindMeetingTimesRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new UserFindMeetingTimesRequest(functionUrl, this.Client, options);

            if (this.HasParameter("attendees"))
            {
                request.RequestBody.Attendees = this.GetParameter<IEnumerable<AttendeeBase>>("attendees");
            }

            if (this.HasParameter("locationConstraint"))
            {
                request.RequestBody.LocationConstraint = this.GetParameter<LocationConstraint>("locationConstraint");
            }

            if (this.HasParameter("timeConstraint"))
            {
                request.RequestBody.TimeConstraint = this.GetParameter<TimeConstraint>("timeConstraint");
            }

            if (this.HasParameter("meetingDuration"))
            {
                request.RequestBody.MeetingDuration = this.GetParameter<Duration>("meetingDuration");
            }

            if (this.HasParameter("maxCandidates"))
            {
                request.RequestBody.MaxCandidates = this.GetParameter<Int32?>("maxCandidates");
            }

            if (this.HasParameter("isOrganizerOptional"))
            {
                request.RequestBody.IsOrganizerOptional = this.GetParameter<bool?>("isOrganizerOptional");
            }

            if (this.HasParameter("returnSuggestionReasons"))
            {
                request.RequestBody.ReturnSuggestionReasons = this.GetParameter<bool?>("returnSuggestionReasons");
            }

            if (this.HasParameter("minimumAttendeePercentage"))
            {
                request.RequestBody.MinimumAttendeePercentage = this.GetParameter<double?>("minimumAttendeePercentage");
            }

            return request;
        }
    }
}