﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MailChimpManager.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Logic;

// ReSharper disable CommentTypo
// ReSharper disable IdentifierTypo
namespace MailChimp.Net
{
    /// <summary>
    /// The mail chimp manager.
    /// </summary>
    public class MailChimpManager : MailManagerBase, IMailChimpManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailChimpManager"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api key.
        /// </param>
        public MailChimpManager(string apiKey) : base(apiKey)
        {
            this.Activities = new ActivityLogic(ApiKey);
            this.AbuseReports = new AbuseReportLogic(ApiKey);
            this.Api = new ApiLogic(ApiKey);
            this.Apps = new AuthorizedAppLogic(ApiKey);
            this.AutomationEmails = new AutomationEmailLogic(ApiKey);
            this.AutomationEmailQueues = new AutomationEmailQueueLogic(ApiKey);
            this.Automations = new AutomationLogic(ApiKey);
            this.AutomationSubscribers = new AutomationSubscriberLogic(ApiKey);
            this.Batches = new BatchLogic(ApiKey);
            this.Campaigns = new CampaignLogic(ApiKey);
            this.CampaignFolders = new CampaignFolderLogic(ApiKey);
            this.Clients = new ClientLogic(ApiKey);
            this.Content = new ContentLogic(ApiKey);
            this.Conversations = new ConversationLogic(ApiKey);
            this.ECommerceStores = new ECommerceLogic(ApiKey);
            this.Feedback = new FeedBackLogic(ApiKey);
            this.FileManagerFiles = new FileManagerFileLogic(ApiKey);
            this.FileManagerFolders = new FileManagerFolderLogic(ApiKey);
            this.GrowthHistories = new GrowthHistoryLogic(ApiKey);
            this.InterestCategories = new InterestCategoryLogic(ApiKey);
            this.Interests = new InterestLogic(ApiKey);
            this.Lists = new ListLogic(ApiKey);
            this.ListSegments = new ListSegmentLogic(ApiKey);
            this.Members = new MemberLogic(ApiKey);
            this.MergeFields = new MergeFieldLogic(ApiKey);
            this.Messages = new MessageLogic(ApiKey);
            this.Notes = new NoteLogic(ApiKey);
            this.Reports = new ReportLogic(ApiKey);
            this.TemplateFolders = new TemplateFolderLogic(ApiKey);
            this.Templates = new TemplateLogic(ApiKey);
            this.WebHooks = new WebHookLogic(ApiKey);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MailChimpManager"/> class.
        /// </summary>
        public MailChimpManager()
        {
            this.Activities = new ActivityLogic(ApiKey);
            this.AbuseReports = new AbuseReportLogic(ApiKey);
            this.Api = new ApiLogic(ApiKey);
            this.Apps = new AuthorizedAppLogic(ApiKey);
            this.AutomationEmails = new AutomationEmailLogic(ApiKey);
            this.AutomationEmailQueues = new AutomationEmailQueueLogic(ApiKey);
            this.Automations = new AutomationLogic(ApiKey);
            this.AutomationSubscribers = new AutomationSubscriberLogic(ApiKey);
            this.Batches = new BatchLogic(ApiKey);
            this.Campaigns = new CampaignLogic(ApiKey);
            this.CampaignFolders = new CampaignFolderLogic(ApiKey);
            this.Clients = new ClientLogic(ApiKey);
            this.Content = new ContentLogic(ApiKey);
            this.Conversations = new ConversationLogic(ApiKey);
            this.ECommerceStores = new ECommerceLogic(ApiKey);
            this.Feedback = new FeedBackLogic(ApiKey);
            this.FileManagerFiles = new FileManagerFileLogic(ApiKey);
            this.FileManagerFolders = new FileManagerFolderLogic(ApiKey);
            this.GrowthHistories = new GrowthHistoryLogic(ApiKey);
            this.InterestCategories = new InterestCategoryLogic(ApiKey);
            this.Interests = new InterestLogic(ApiKey);
            this.Lists = new ListLogic(ApiKey);
            this.ListSegments = new ListSegmentLogic(ApiKey);
            this.Members = new MemberLogic(ApiKey);
            this.MergeFields = new MergeFieldLogic(ApiKey);
            this.Messages = new MessageLogic(ApiKey);
            this.Notes = new NoteLogic(ApiKey);
            this.Reports = new ReportLogic(ApiKey);
            this.TemplateFolders = new TemplateFolderLogic(ApiKey);
            this.Templates = new TemplateLogic(ApiKey);
            this.WebHooks = new WebHookLogic(ApiKey);
        }

        /// <summary>
        /// Gets the abuse reports.
        /// </summary>
        public IAbuseReportLogic AbuseReports { get; }

        /// <summary>
        /// Gets the activities.
        /// </summary>
        public IActivityLogic Activities { get; }

        /// <summary>
        /// Gets the api.
        /// </summary>
        public IApiLogic Api { get; }

        /// <summary>
        /// Gets the apps.
        /// </summary>
        public IAuthorizedAppLogic Apps { get; }

        /// <summary>
        /// Gets or sets the automation email queues.
        /// </summary>
        public IAutomationEmailQueueLogic AutomationEmailQueues { get; }

        /// <summary>
        /// Gets or sets the automation emails.
        /// </summary>
        public IAutomationEmailLogic AutomationEmails { get; }

        /// <summary>
        /// Gets or sets the automations.
        /// </summary>
        public IAutomationLogic Automations { get; }

        /// <summary>
        /// Gets or sets the automation subscribers.
        /// </summary>
        public IAutomationSubscriberLogic AutomationSubscribers { get; }

        /// <summary>
        /// Gets othe batch logic layer to talk to Mail Chimp
        /// </summary>
        public IBatchLogic Batches { get; }

        /// <summary>
        /// Gets or sets the campaign folders.
        /// </summary>
        public ICampaignFolderLogic CampaignFolders { get; }

        /// <summary>
        /// Gets the campaigns.
        /// </summary>
        public ICampaignLogic Campaigns { get; }

        /// <summary>
        /// Gets the clients.
        /// </summary>
        public IClientLogic Clients { get; }

        /// <summary>
        /// Gets the content.
        /// </summary>
        public IContentLogic Content { get; }

        /// <summary>
        /// Gets the conversations.
        /// </summary>
        public IConversationLogic Conversations { get; }

        /// <summary>
        /// Gets or sets the e commerce stores.
        /// </summary>
        public IECommerceLogic ECommerceStores { get; }

        /// <summary>
        /// Gets the feedback.
        /// </summary>
        public IFeedbackLogic Feedback { get; }

        /// <summary>
        /// Gets the file manager files.
        /// </summary>
        public IFileManagerFileLogic FileManagerFiles { get; }

        /// <summary>
        /// Gets the file manager folders.
        /// </summary>
        public IFileManagerFolderLogic FileManagerFolders { get; }

        /// <summary>
        /// Gets the growth histories.
        /// </summary>
        public IGrowthHistoryLogic GrowthHistories { get; }

        /// <summary>
        /// Gets the interest categories.
        /// </summary>
        public IInterestCategoryLogic InterestCategories { get; }

        /// <summary>
        /// Gets or sets the interests.
        /// </summary>
        public IInterestLogic Interests { get; }

        /// <summary>
        /// Gets the lists.
        /// </summary>
        public IListLogic Lists { get; }

        /// <summary>
        /// Gets the members.
        /// </summary>
        public IMemberLogic Members { get; }

        /// <summary>
        /// Gets the merge fields.
        /// </summary>
        public IMergeFieldLogic MergeFields { get; }

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        public IMessageLogic Messages { get; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        public INoteLogic Notes { get; }

        /// <summary>
        /// Gets or sets the reports.
        /// </summary>
        public IReportLogic Reports { get; }

        /// <summary>
        /// Gets the segments.
        /// </summary>
        public IListSegmentLogic ListSegments { get; }

        /// <summary>
        /// Gets or sets the template folders.
        /// </summary>
        public ITemplateFolderLogic TemplateFolders { get; }

        /// <summary>
        /// Gets or sets the templates.
        /// </summary>
        public ITemplateLogic Templates { get; }

        /// <summary>
        /// Gets the logic to access mail chimp web hooks
        /// </summary>
        public IWebHookLogic WebHooks { get; }

    }
}