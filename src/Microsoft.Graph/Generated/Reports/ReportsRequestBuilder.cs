using Microsoft.Graph.Models;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Reports.DailyPrintUsageByPrinter;
using Microsoft.Graph.Reports.DailyPrintUsageByUser;
using Microsoft.Graph.Reports.MicrosoftGraphDeviceConfigurationDeviceActivity;
using Microsoft.Graph.Reports.MicrosoftGraphDeviceConfigurationUserActivity;
using Microsoft.Graph.Reports.MicrosoftGraphGetEmailActivityCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetEmailActivityUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetEmailActivityUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetEmailActivityUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetEmailAppUsageAppsUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetEmailAppUsageUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetEmailAppUsageUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetEmailAppUsageUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetEmailAppUsageVersionsUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime;
using Microsoft.Graph.Reports.MicrosoftGraphGetM365AppPlatformUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetM365AppUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetM365AppUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetM365AppUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetMailboxUsageDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetMailboxUsageMailboxCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetMailboxUsageQuotaStatusMailboxCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetMailboxUsageStorageWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365ActivationCounts;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365ActivationsUserCounts;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365ActivationsUserDetail;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365ActiveUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365ActiveUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365ActiveUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365GroupsActivityCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365GroupsActivityDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365GroupsActivityDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365GroupsActivityFileCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365GroupsActivityGroupCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365GroupsActivityStorageWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOffice365ServicesUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOneDriveActivityFileCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOneDriveActivityUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOneDriveActivityUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetOneDriveActivityUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOneDriveUsageAccountCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOneDriveUsageAccountDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetOneDriveUsageAccountDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOneDriveUsageFileCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetOneDriveUsageStorageWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime;
using Microsoft.Graph.Reports.MicrosoftGraphGetSharePointActivityFileCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSharePointActivityPagesWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSharePointActivityUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSharePointActivityUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetSharePointActivityUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSharePointSiteUsageDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetSharePointSiteUsageDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSharePointSiteUsageFileCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSharePointSiteUsagePagesWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSharePointSiteUsageSiteCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSharePointSiteUsageStorageWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessActivityCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessActivityUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessDeviceUsageUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessOrganizerActivityCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessOrganizerActivityUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessParticipantActivityCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessParticipantActivityUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetTeamsDeviceUsageDistributionUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetTeamsDeviceUsageUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetTeamsDeviceUsageUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetTeamsDeviceUsageUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetTeamsUserActivityCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetTeamsUserActivityUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetTeamsUserActivityUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetTeamsUserActivityUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerActivityCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerActivityUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerActivityUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerActivityUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerDeviceUsageDistributionUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerDeviceUsageUserCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerDeviceUsageUserDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerDeviceUsageUserDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerGroupsActivityCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerGroupsActivityDetailWithDate;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerGroupsActivityDetailWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphGetYammerGroupsActivityGroupCountsWithPeriod;
using Microsoft.Graph.Reports.MicrosoftGraphManagedDeviceEnrollmentFailureDetails;
using Microsoft.Graph.Reports.MicrosoftGraphManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken;
using Microsoft.Graph.Reports.MicrosoftGraphManagedDeviceEnrollmentTopFailures;
using Microsoft.Graph.Reports.MicrosoftGraphManagedDeviceEnrollmentTopFailuresWithPeriod;
using Microsoft.Graph.Reports.MonthlyPrintUsageByPrinter;
using Microsoft.Graph.Reports.MonthlyPrintUsageByUser;
using Microsoft.Graph.Reports.Security;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Reports {
    /// <summary>
    /// Provides operations to manage the reportRoot singleton.
    /// </summary>
    public class ReportsRequestBuilder {
        /// <summary>Provides operations to manage the dailyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.</summary>
        public DailyPrintUsageByPrinterRequestBuilder DailyPrintUsageByPrinter { get =>
            new DailyPrintUsageByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dailyPrintUsageByUser property of the microsoft.graph.reportRoot entity.</summary>
        public DailyPrintUsageByUserRequestBuilder DailyPrintUsageByUser { get =>
            new DailyPrintUsageByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deviceConfigurationDeviceActivity method.</summary>
        public MicrosoftGraphDeviceConfigurationDeviceActivityRequestBuilder MicrosoftGraphDeviceConfigurationDeviceActivity { get =>
            new MicrosoftGraphDeviceConfigurationDeviceActivityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the deviceConfigurationUserActivity method.</summary>
        public MicrosoftGraphDeviceConfigurationUserActivityRequestBuilder MicrosoftGraphDeviceConfigurationUserActivity { get =>
            new MicrosoftGraphDeviceConfigurationUserActivityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getOffice365ActivationCounts method.</summary>
        public MicrosoftGraphGetOffice365ActivationCountsRequestBuilder MicrosoftGraphGetOffice365ActivationCounts { get =>
            new MicrosoftGraphGetOffice365ActivationCountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getOffice365ActivationsUserCounts method.</summary>
        public MicrosoftGraphGetOffice365ActivationsUserCountsRequestBuilder MicrosoftGraphGetOffice365ActivationsUserCounts { get =>
            new MicrosoftGraphGetOffice365ActivationsUserCountsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getOffice365ActivationsUserDetail method.</summary>
        public MicrosoftGraphGetOffice365ActivationsUserDetailRequestBuilder MicrosoftGraphGetOffice365ActivationsUserDetail { get =>
            new MicrosoftGraphGetOffice365ActivationsUserDetailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the managedDeviceEnrollmentFailureDetails method.</summary>
        public MicrosoftGraphManagedDeviceEnrollmentFailureDetailsRequestBuilder MicrosoftGraphManagedDeviceEnrollmentFailureDetails { get =>
            new MicrosoftGraphManagedDeviceEnrollmentFailureDetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the managedDeviceEnrollmentTopFailures method.</summary>
        public MicrosoftGraphManagedDeviceEnrollmentTopFailuresRequestBuilder MicrosoftGraphManagedDeviceEnrollmentTopFailures { get =>
            new MicrosoftGraphManagedDeviceEnrollmentTopFailuresRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the monthlyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.</summary>
        public MonthlyPrintUsageByPrinterRequestBuilder MonthlyPrintUsageByPrinter { get =>
            new MonthlyPrintUsageByPrinterRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the monthlyPrintUsageByUser property of the microsoft.graph.reportRoot entity.</summary>
        public MonthlyPrintUsageByUserRequestBuilder MonthlyPrintUsageByUser { get =>
            new MonthlyPrintUsageByUserRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Provides operations to manage the security property of the microsoft.graph.reportRoot entity.</summary>
        public SecurityRequestBuilder Security { get =>
            new SecurityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/reports{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ReportsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/reports{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>();
            if (!string.IsNullOrWhiteSpace(rawUrl)) urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Get reports
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ReportRoot?> GetAsync(Action<ReportsRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ReportRoot> GetAsync(Action<ReportsRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ReportRoot>(requestInfo, ReportRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetEmailActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetEmailActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetEmailActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetEmailActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetEmailActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetEmailActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetEmailActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetEmailActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetEmailActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetEmailActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetEmailActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetEmailActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageAppsUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder MicrosoftGraphGetEmailAppUsageAppsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetEmailAppUsageUserCountsWithPeriodRequestBuilder MicrosoftGraphGetEmailAppUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetEmailAppUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetEmailAppUsageUserDetailWithDateRequestBuilder MicrosoftGraphGetEmailAppUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetEmailAppUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetEmailAppUsageUserDetailWithPeriodRequestBuilder MicrosoftGraphGetEmailAppUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetEmailAppUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageVersionsUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder MicrosoftGraphGetEmailAppUsageVersionsUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getGroupArchivedPrintJobs method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="groupId">Usage: groupId=&apos;{groupId}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        public MicrosoftGraphGetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder MicrosoftGraphGetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, string groupId, DateTimeOffset? startDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(groupId)) throw new ArgumentNullException(nameof(groupId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new MicrosoftGraphGetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, groupId, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getM365AppPlatformUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetM365AppPlatformUserCountsWithPeriodRequestBuilder MicrosoftGraphGetM365AppPlatformUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetM365AppPlatformUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetM365AppUserCountsWithPeriodRequestBuilder MicrosoftGraphGetM365AppUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetM365AppUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetM365AppUserDetailWithDateRequestBuilder MicrosoftGraphGetM365AppUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetM365AppUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetM365AppUserDetailWithPeriodRequestBuilder MicrosoftGraphGetM365AppUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetM365AppUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetMailboxUsageDetailWithPeriodRequestBuilder MicrosoftGraphGetMailboxUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetMailboxUsageDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageMailboxCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetMailboxUsageMailboxCountsWithPeriodRequestBuilder MicrosoftGraphGetMailboxUsageMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetMailboxUsageMailboxCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageQuotaStatusMailboxCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder MicrosoftGraphGetMailboxUsageQuotaStatusMailboxCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetMailboxUsageStorageWithPeriodRequestBuilder MicrosoftGraphGetMailboxUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetMailboxUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOffice365ActiveUserCountsWithPeriodRequestBuilder MicrosoftGraphGetOffice365ActiveUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOffice365ActiveUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetOffice365ActiveUserDetailWithDateRequestBuilder MicrosoftGraphGetOffice365ActiveUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetOffice365ActiveUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOffice365ActiveUserDetailWithPeriodRequestBuilder MicrosoftGraphGetOffice365ActiveUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOffice365ActiveUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOffice365GroupsActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetOffice365GroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOffice365GroupsActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetOffice365GroupsActivityDetailWithDateRequestBuilder MicrosoftGraphGetOffice365GroupsActivityDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetOffice365GroupsActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOffice365GroupsActivityDetailWithPeriodRequestBuilder MicrosoftGraphGetOffice365GroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOffice365GroupsActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder MicrosoftGraphGetOffice365GroupsActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityGroupCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder MicrosoftGraphGetOffice365GroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOffice365GroupsActivityStorageWithPeriodRequestBuilder MicrosoftGraphGetOffice365GroupsActivityStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOffice365GroupsActivityStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOffice365ServicesUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOffice365ServicesUserCountsWithPeriodRequestBuilder MicrosoftGraphGetOffice365ServicesUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOffice365ServicesUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOneDriveActivityFileCountsWithPeriodRequestBuilder MicrosoftGraphGetOneDriveActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOneDriveActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOneDriveActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetOneDriveActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOneDriveActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetOneDriveActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetOneDriveActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetOneDriveActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOneDriveActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetOneDriveActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOneDriveActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOneDriveUsageAccountCountsWithPeriodRequestBuilder MicrosoftGraphGetOneDriveUsageAccountCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOneDriveUsageAccountCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetOneDriveUsageAccountDetailWithDateRequestBuilder MicrosoftGraphGetOneDriveUsageAccountDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetOneDriveUsageAccountDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOneDriveUsageAccountDetailWithPeriodRequestBuilder MicrosoftGraphGetOneDriveUsageAccountDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOneDriveUsageAccountDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOneDriveUsageFileCountsWithPeriodRequestBuilder MicrosoftGraphGetOneDriveUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOneDriveUsageFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetOneDriveUsageStorageWithPeriodRequestBuilder MicrosoftGraphGetOneDriveUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetOneDriveUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getPrinterArchivedPrintJobs method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="printerId">Usage: printerId=&apos;{printerId}&apos;</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        public MicrosoftGraphGetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder MicrosoftGraphGetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, string printerId, DateTimeOffset? startDateTime) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            if(string.IsNullOrEmpty(printerId)) throw new ArgumentNullException(nameof(printerId));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            return new MicrosoftGraphGetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, printerId, startDateTime);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSharePointActivityFileCountsWithPeriodRequestBuilder MicrosoftGraphGetSharePointActivityFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSharePointActivityFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityPages method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSharePointActivityPagesWithPeriodRequestBuilder MicrosoftGraphGetSharePointActivityPagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSharePointActivityPagesWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSharePointActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSharePointActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSharePointActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetSharePointActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetSharePointActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetSharePointActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSharePointActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetSharePointActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSharePointActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetSharePointSiteUsageDetailWithDateRequestBuilder MicrosoftGraphGetSharePointSiteUsageDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetSharePointSiteUsageDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSharePointSiteUsageDetailWithPeriodRequestBuilder MicrosoftGraphGetSharePointSiteUsageDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSharePointSiteUsageDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageFileCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSharePointSiteUsageFileCountsWithPeriodRequestBuilder MicrosoftGraphGetSharePointSiteUsageFileCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSharePointSiteUsageFileCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsagePages method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSharePointSiteUsagePagesWithPeriodRequestBuilder MicrosoftGraphGetSharePointSiteUsagePagesWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSharePointSiteUsagePagesWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageSiteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder MicrosoftGraphGetSharePointSiteUsageSiteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageStorage method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSharePointSiteUsageStorageWithPeriodRequestBuilder MicrosoftGraphGetSharePointSiteUsageStorageWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSharePointSiteUsageStorageWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageDistributionUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessOrganizerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityMinuteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessOrganizerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessParticipantActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityMinuteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessParticipantActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityMinuteCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageDistributionUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder MicrosoftGraphGetTeamsDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder MicrosoftGraphGetTeamsDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetTeamsDeviceUsageUserDetailWithDateRequestBuilder MicrosoftGraphGetTeamsDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetTeamsDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder MicrosoftGraphGetTeamsDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetTeamsUserActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetTeamsUserActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetTeamsUserActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetTeamsUserActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetTeamsUserActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetTeamsUserActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetTeamsUserActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetTeamsUserActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetTeamsUserActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetTeamsUserActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetTeamsUserActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetTeamsUserActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getUserArchivedPrintJobs method.
        /// </summary>
        /// <param name="endDateTime">Usage: endDateTime={endDateTime}</param>
        /// <param name="startDateTime">Usage: startDateTime={startDateTime}</param>
        /// <param name="userId">Usage: userId=&apos;{userId}&apos;</param>
        public MicrosoftGraphGetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder MicrosoftGraphGetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime(DateTimeOffset? endDateTime, DateTimeOffset? startDateTime, string userId) {
            _ = endDateTime ?? throw new ArgumentNullException(nameof(endDateTime));
            _ = startDateTime ?? throw new ArgumentNullException(nameof(startDateTime));
            if(string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));
            return new MicrosoftGraphGetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter, endDateTime, startDateTime, userId);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetYammerActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetYammerActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetYammerActivityUserCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerActivityUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetYammerActivityUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetYammerActivityUserDetailWithDateRequestBuilder MicrosoftGraphGetYammerActivityUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetYammerActivityUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetYammerActivityUserDetailWithPeriodRequestBuilder MicrosoftGraphGetYammerActivityUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetYammerActivityUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageDistributionUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerDeviceUsageDistributionUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetYammerDeviceUsageUserCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerDeviceUsageUserCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetYammerDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetYammerDeviceUsageUserDetailWithDateRequestBuilder MicrosoftGraphGetYammerDeviceUsageUserDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetYammerDeviceUsageUserDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetYammerDeviceUsageUserDetailWithPeriodRequestBuilder MicrosoftGraphGetYammerDeviceUsageUserDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetYammerDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetYammerGroupsActivityCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerGroupsActivityCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetYammerGroupsActivityCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityDetail method.
        /// </summary>
        /// <param name="date">Usage: date={date}</param>
        public MicrosoftGraphGetYammerGroupsActivityDetailWithDateRequestBuilder MicrosoftGraphGetYammerGroupsActivityDetailWithDate(Date? date) {
            _ = date ?? throw new ArgumentNullException(nameof(date));
            return new MicrosoftGraphGetYammerGroupsActivityDetailWithDateRequestBuilder(PathParameters, RequestAdapter, date);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityDetail method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetYammerGroupsActivityDetailWithPeriodRequestBuilder MicrosoftGraphGetYammerGroupsActivityDetailWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetYammerGroupsActivityDetailWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityGroupCounts method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphGetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder MicrosoftGraphGetYammerGroupsActivityGroupCountsWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphGetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentFailureDetails method.
        /// </summary>
        /// <param name="filter">Usage: filter=&apos;{filter}&apos;</param>
        /// <param name="skip">Usage: skip={skip}</param>
        /// <param name="skipToken">Usage: skipToken=&apos;{skipToken}&apos;</param>
        /// <param name="top">Usage: top={top}</param>
        public MicrosoftGraphManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder MicrosoftGraphManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken(string filter, int? skip, string skipToken, int? top) {
            if(string.IsNullOrEmpty(filter)) throw new ArgumentNullException(nameof(filter));
            _ = skip ?? throw new ArgumentNullException(nameof(skip));
            if(string.IsNullOrEmpty(skipToken)) throw new ArgumentNullException(nameof(skipToken));
            _ = top ?? throw new ArgumentNullException(nameof(top));
            return new MicrosoftGraphManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(PathParameters, RequestAdapter, filter, skip, skipToken, top);
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentTopFailures method.
        /// </summary>
        /// <param name="period">Usage: period=&apos;{period}&apos;</param>
        public MicrosoftGraphManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder MicrosoftGraphManagedDeviceEnrollmentTopFailuresWithPeriod(string period) {
            if(string.IsNullOrEmpty(period)) throw new ArgumentNullException(nameof(period));
            return new MicrosoftGraphManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder(PathParameters, RequestAdapter, period);
        }
        /// <summary>
        /// Update reports
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ReportRoot?> PatchAsync(ReportRoot body, Action<ReportsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ReportRoot> PatchAsync(ReportRoot body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ReportRoot>(requestInfo, ReportRoot.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
        }
        /// <summary>
        /// Get reports
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ReportsRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ReportsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update reports
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ReportRoot body, Action<ReportsRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ReportRoot body, Action<ReportsRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ReportsRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get reports
        /// </summary>
        public class ReportsRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReportsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ReportsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ReportsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new reportsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ReportsRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new reportsRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public ReportsRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}