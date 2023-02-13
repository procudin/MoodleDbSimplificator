using Microsoft.EntityFrameworkCore;
using MoodleDbSimplificator.MoodleDb.V39.Entities;

namespace MoodleDbSimplificator.MoodleDb.V39;

public partial class Moodle39DbContext : DbContext
{
    public Moodle39DbContext(DbContextOptions<Moodle39DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MdlAnalyticsIndicatorCalc> MdlAnalyticsIndicatorCalcs { get; set; }

    public virtual DbSet<MdlAnalyticsModel> MdlAnalyticsModels { get; set; }

    public virtual DbSet<MdlAnalyticsModelsLog> MdlAnalyticsModelsLogs { get; set; }

    public virtual DbSet<MdlAnalyticsPredictSample> MdlAnalyticsPredictSamples { get; set; }

    public virtual DbSet<MdlAnalyticsPrediction> MdlAnalyticsPredictions { get; set; }

    public virtual DbSet<MdlAnalyticsPredictionAction> MdlAnalyticsPredictionActions { get; set; }

    public virtual DbSet<MdlAnalyticsTrainSample> MdlAnalyticsTrainSamples { get; set; }

    public virtual DbSet<MdlAnalyticsUsedAnalysable> MdlAnalyticsUsedAnalysables { get; set; }

    public virtual DbSet<MdlAnalyticsUsedFile> MdlAnalyticsUsedFiles { get; set; }

    public virtual DbSet<MdlAssign> MdlAssigns { get; set; }

    public virtual DbSet<MdlAssignGrade> MdlAssignGrades { get; set; }

    public virtual DbSet<MdlAssignOverride> MdlAssignOverrides { get; set; }

    public virtual DbSet<MdlAssignPluginConfig> MdlAssignPluginConfigs { get; set; }

    public virtual DbSet<MdlAssignSubmission> MdlAssignSubmissions { get; set; }

    public virtual DbSet<MdlAssignUserFlag> MdlAssignUserFlags { get; set; }

    public virtual DbSet<MdlAssignUserMapping> MdlAssignUserMappings { get; set; }

    public virtual DbSet<MdlAssignfeedbackComment> MdlAssignfeedbackComments { get; set; }

    public virtual DbSet<MdlAssignfeedbackEditpdfAnnot> MdlAssignfeedbackEditpdfAnnots { get; set; }

    public virtual DbSet<MdlAssignfeedbackEditpdfCmnt> MdlAssignfeedbackEditpdfCmnts { get; set; }

    public virtual DbSet<MdlAssignfeedbackEditpdfQueue> MdlAssignfeedbackEditpdfQueues { get; set; }

    public virtual DbSet<MdlAssignfeedbackEditpdfQuick> MdlAssignfeedbackEditpdfQuicks { get; set; }

    public virtual DbSet<MdlAssignfeedbackEditpdfRot> MdlAssignfeedbackEditpdfRots { get; set; }

    public virtual DbSet<MdlAssignfeedbackFile> MdlAssignfeedbackFiles { get; set; }

    public virtual DbSet<MdlAssignment> MdlAssignments { get; set; }

    public virtual DbSet<MdlAssignmentSubmission> MdlAssignmentSubmissions { get; set; }

    public virtual DbSet<MdlAssignmentUpgrade> MdlAssignmentUpgrades { get; set; }

    public virtual DbSet<MdlAssignsubmissionFile> MdlAssignsubmissionFiles { get; set; }

    public virtual DbSet<MdlAssignsubmissionOnlinetext> MdlAssignsubmissionOnlinetexts { get; set; }

    public virtual DbSet<MdlAuditorSyncTask> MdlAuditorSyncTasks { get; set; }

    public virtual DbSet<MdlAuthOauth2LinkedLogin> MdlAuthOauth2LinkedLogins { get; set; }

    public virtual DbSet<MdlBackupController> MdlBackupControllers { get; set; }

    public virtual DbSet<MdlBackupCourse> MdlBackupCourses { get; set; }

    public virtual DbSet<MdlBackupLog> MdlBackupLogs { get; set; }

    public virtual DbSet<MdlBadge> MdlBadges { get; set; }

    public virtual DbSet<MdlBadgeAlignment> MdlBadgeAlignments { get; set; }

    public virtual DbSet<MdlBadgeBackpack> MdlBadgeBackpacks { get; set; }

    public virtual DbSet<MdlBadgeBackpackOauth2> MdlBadgeBackpackOauth2s { get; set; }

    public virtual DbSet<MdlBadgeCriteriaMet> MdlBadgeCriteriaMets { get; set; }

    public virtual DbSet<MdlBadgeCriteriaParam> MdlBadgeCriteriaParams { get; set; }

    public virtual DbSet<MdlBadgeCriterion> MdlBadgeCriteria { get; set; }

    public virtual DbSet<MdlBadgeEndorsement> MdlBadgeEndorsements { get; set; }

    public virtual DbSet<MdlBadgeExternal> MdlBadgeExternals { get; set; }

    public virtual DbSet<MdlBadgeExternalBackpack> MdlBadgeExternalBackpacks { get; set; }

    public virtual DbSet<MdlBadgeExternalIdentifier> MdlBadgeExternalIdentifiers { get; set; }

    public virtual DbSet<MdlBadgeIssued> MdlBadgeIssueds { get; set; }

    public virtual DbSet<MdlBadgeManualAward> MdlBadgeManualAwards { get; set; }

    public virtual DbSet<MdlBadgeRelated> MdlBadgeRelateds { get; set; }

    public virtual DbSet<MdlBlock> MdlBlocks { get; set; }

    public virtual DbSet<MdlBlockFormalLang> MdlBlockFormalLangs { get; set; }

    public virtual DbSet<MdlBlockFormalLangsDscPart> MdlBlockFormalLangsDscParts { get; set; }

    public virtual DbSet<MdlBlockFormalLangsNodeDscr> MdlBlockFormalLangsNodeDscrs { get; set; }

    public virtual DbSet<MdlBlockFormalLangsPerm> MdlBlockFormalLangsPerms { get; set; }

    public virtual DbSet<MdlBlockFormalLangsWordFrm> MdlBlockFormalLangsWordFrms { get; set; }

    public virtual DbSet<MdlBlockInstance> MdlBlockInstances { get; set; }

    public virtual DbSet<MdlBlockPosition> MdlBlockPositions { get; set; }

    public virtual DbSet<MdlBlockRecentActivity> MdlBlockRecentActivities { get; set; }

    public virtual DbSet<MdlBlockRecentlyaccesseditem> MdlBlockRecentlyaccesseditems { get; set; }

    public virtual DbSet<MdlBlockRssClient> MdlBlockRssClients { get; set; }

    public virtual DbSet<MdlBlockSupervisedClassroom> MdlBlockSupervisedClassrooms { get; set; }

    public virtual DbSet<MdlBlockSupervisedLessontype> MdlBlockSupervisedLessontypes { get; set; }

    public virtual DbSet<MdlBlockSupervisedSession> MdlBlockSupervisedSessions { get; set; }

    public virtual DbSet<MdlBlockSupervisedUser> MdlBlockSupervisedUsers { get; set; }

    public virtual DbSet<MdlBlogAssociation> MdlBlogAssociations { get; set; }

    public virtual DbSet<MdlBlogExternal> MdlBlogExternals { get; set; }

    public virtual DbSet<MdlBook> MdlBooks { get; set; }

    public virtual DbSet<MdlBookChapter> MdlBookChapters { get; set; }

    public virtual DbSet<MdlCacheFilter> MdlCacheFilters { get; set; }

    public virtual DbSet<MdlCacheFlag> MdlCacheFlags { get; set; }

    public virtual DbSet<MdlCapability> MdlCapabilities { get; set; }

    public virtual DbSet<MdlChat> MdlChats { get; set; }

    public virtual DbSet<MdlChatMessage> MdlChatMessages { get; set; }

    public virtual DbSet<MdlChatMessagesCurrent> MdlChatMessagesCurrents { get; set; }

    public virtual DbSet<MdlChatUser> MdlChatUsers { get; set; }

    public virtual DbSet<MdlChoice> MdlChoices { get; set; }

    public virtual DbSet<MdlChoiceAnswer> MdlChoiceAnswers { get; set; }

    public virtual DbSet<MdlChoiceOption> MdlChoiceOptions { get; set; }

    public virtual DbSet<MdlCohort> MdlCohorts { get; set; }

    public virtual DbSet<MdlCohortMember> MdlCohortMembers { get; set; }

    public virtual DbSet<MdlComment> MdlComments { get; set; }

    public virtual DbSet<MdlCompetency> MdlCompetencies { get; set; }

    public virtual DbSet<MdlCompetencyCoursecomp> MdlCompetencyCoursecomps { get; set; }

    public virtual DbSet<MdlCompetencyCoursecompsetting> MdlCompetencyCoursecompsettings { get; set; }

    public virtual DbSet<MdlCompetencyEvidence> MdlCompetencyEvidences { get; set; }

    public virtual DbSet<MdlCompetencyFramework> MdlCompetencyFrameworks { get; set; }

    public virtual DbSet<MdlCompetencyModulecomp> MdlCompetencyModulecomps { get; set; }

    public virtual DbSet<MdlCompetencyPlan> MdlCompetencyPlans { get; set; }

    public virtual DbSet<MdlCompetencyPlancomp> MdlCompetencyPlancomps { get; set; }

    public virtual DbSet<MdlCompetencyRelatedcomp> MdlCompetencyRelatedcomps { get; set; }

    public virtual DbSet<MdlCompetencyTemplate> MdlCompetencyTemplates { get; set; }

    public virtual DbSet<MdlCompetencyTemplatecohort> MdlCompetencyTemplatecohorts { get; set; }

    public virtual DbSet<MdlCompetencyTemplatecomp> MdlCompetencyTemplatecomps { get; set; }

    public virtual DbSet<MdlCompetencyUsercomp> MdlCompetencyUsercomps { get; set; }

    public virtual DbSet<MdlCompetencyUsercompcourse> MdlCompetencyUsercompcourses { get; set; }

    public virtual DbSet<MdlCompetencyUsercompplan> MdlCompetencyUsercompplans { get; set; }

    public virtual DbSet<MdlCompetencyUserevidence> MdlCompetencyUserevidences { get; set; }

    public virtual DbSet<MdlCompetencyUserevidencecomp> MdlCompetencyUserevidencecomps { get; set; }

    public virtual DbSet<MdlConfig> MdlConfigs { get; set; }

    public virtual DbSet<MdlConfigLog> MdlConfigLogs { get; set; }

    public virtual DbSet<MdlConfigPlugin> MdlConfigPlugins { get; set; }

    public virtual DbSet<MdlContentbankContent> MdlContentbankContents { get; set; }

    public virtual DbSet<MdlContext> MdlContexts { get; set; }

    public virtual DbSet<MdlContextTemp> MdlContextTemps { get; set; }

    public virtual DbSet<MdlCourse> MdlCourses { get; set; }

    public virtual DbSet<MdlCourseCategory> MdlCourseCategories { get; set; }

    public virtual DbSet<MdlCourseCompletion> MdlCourseCompletions { get; set; }

    public virtual DbSet<MdlCourseCompletionAggrMethd> MdlCourseCompletionAggrMethds { get; set; }

    public virtual DbSet<MdlCourseCompletionCritCompl> MdlCourseCompletionCritCompls { get; set; }

    public virtual DbSet<MdlCourseCompletionCriterion> MdlCourseCompletionCriteria { get; set; }

    public virtual DbSet<MdlCourseCompletionDefault> MdlCourseCompletionDefaults { get; set; }

    public virtual DbSet<MdlCourseFormatOption> MdlCourseFormatOptions { get; set; }

    public virtual DbSet<MdlCourseModule> MdlCourseModules { get; set; }

    public virtual DbSet<MdlCourseModulesCompletion> MdlCourseModulesCompletions { get; set; }

    public virtual DbSet<MdlCoursePublished> MdlCoursePublisheds { get; set; }

    public virtual DbSet<MdlCourseRequest> MdlCourseRequests { get; set; }

    public virtual DbSet<MdlCourseSection> MdlCourseSections { get; set; }

    public virtual DbSet<MdlCustomfieldCategory> MdlCustomfieldCategories { get; set; }

    public virtual DbSet<MdlCustomfieldDatum> MdlCustomfieldData { get; set; }

    public virtual DbSet<MdlCustomfieldField> MdlCustomfieldFields { get; set; }

    public virtual DbSet<MdlDataContent> MdlDataContents { get; set; }

    public virtual DbSet<MdlDataField> MdlDataFields { get; set; }

    public virtual DbSet<MdlDataRecord> MdlDataRecords { get; set; }

    public virtual DbSet<MdlDatum> MdlData { get; set; }

    public virtual DbSet<MdlEditorAttoAutosave> MdlEditorAttoAutosaves { get; set; }

    public virtual DbSet<MdlEnrol> MdlEnrols { get; set; }

    public virtual DbSet<MdlEnrolFlatfile> MdlEnrolFlatfiles { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2Consumer> MdlEnrolLtiLti2Consumers { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2Context> MdlEnrolLtiLti2Contexts { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2Nonce> MdlEnrolLtiLti2Nonces { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2ResourceLink> MdlEnrolLtiLti2ResourceLinks { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2ShareKey> MdlEnrolLtiLti2ShareKeys { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2ToolProxy> MdlEnrolLtiLti2ToolProxies { get; set; }

    public virtual DbSet<MdlEnrolLtiLti2UserResult> MdlEnrolLtiLti2UserResults { get; set; }

    public virtual DbSet<MdlEnrolLtiTool> MdlEnrolLtiTools { get; set; }

    public virtual DbSet<MdlEnrolLtiToolConsumerMap> MdlEnrolLtiToolConsumerMaps { get; set; }

    public virtual DbSet<MdlEnrolLtiUser> MdlEnrolLtiUsers { get; set; }

    public virtual DbSet<MdlEnrolPaypal> MdlEnrolPaypals { get; set; }

    public virtual DbSet<MdlEvent> MdlEvents { get; set; }

    public virtual DbSet<MdlEventSubscription> MdlEventSubscriptions { get; set; }

    public virtual DbSet<MdlEventsHandler> MdlEventsHandlers { get; set; }

    public virtual DbSet<MdlEventsQueue> MdlEventsQueues { get; set; }

    public virtual DbSet<MdlEventsQueueHandler> MdlEventsQueueHandlers { get; set; }

    public virtual DbSet<MdlExternalFunction> MdlExternalFunctions { get; set; }

    public virtual DbSet<MdlExternalService> MdlExternalServices { get; set; }

    public virtual DbSet<MdlExternalServicesFunction> MdlExternalServicesFunctions { get; set; }

    public virtual DbSet<MdlExternalServicesUser> MdlExternalServicesUsers { get; set; }

    public virtual DbSet<MdlExternalToken> MdlExternalTokens { get; set; }

    public virtual DbSet<MdlFavourite> MdlFavourites { get; set; }

    public virtual DbSet<MdlFeedback> MdlFeedbacks { get; set; }

    public virtual DbSet<MdlFeedbackCompleted> MdlFeedbackCompleteds { get; set; }

    public virtual DbSet<MdlFeedbackCompletedtmp> MdlFeedbackCompletedtmps { get; set; }

    public virtual DbSet<MdlFeedbackItem> MdlFeedbackItems { get; set; }

    public virtual DbSet<MdlFeedbackSitecourseMap> MdlFeedbackSitecourseMaps { get; set; }

    public virtual DbSet<MdlFeedbackTemplate> MdlFeedbackTemplates { get; set; }

    public virtual DbSet<MdlFeedbackValue> MdlFeedbackValues { get; set; }

    public virtual DbSet<MdlFeedbackValuetmp> MdlFeedbackValuetmps { get; set; }

    public virtual DbSet<MdlFile> MdlFiles { get; set; }

    public virtual DbSet<MdlFileConversion> MdlFileConversions { get; set; }

    public virtual DbSet<MdlFilesReference> MdlFilesReferences { get; set; }

    public virtual DbSet<MdlFilterActive> MdlFilterActives { get; set; }

    public virtual DbSet<MdlFilterConfig> MdlFilterConfigs { get; set; }

    public virtual DbSet<MdlFolder> MdlFolders { get; set; }

    public virtual DbSet<MdlForum> MdlForums { get; set; }

    public virtual DbSet<MdlForumDigest> MdlForumDigests { get; set; }

    public virtual DbSet<MdlForumDiscussion> MdlForumDiscussions { get; set; }

    public virtual DbSet<MdlForumDiscussionSub> MdlForumDiscussionSubs { get; set; }

    public virtual DbSet<MdlForumGrade> MdlForumGrades { get; set; }

    public virtual DbSet<MdlForumPost> MdlForumPosts { get; set; }

    public virtual DbSet<MdlForumQueue> MdlForumQueues { get; set; }

    public virtual DbSet<MdlForumRead> MdlForumReads { get; set; }

    public virtual DbSet<MdlForumSubscription> MdlForumSubscriptions { get; set; }

    public virtual DbSet<MdlForumTrackPref> MdlForumTrackPrefs { get; set; }

    public virtual DbSet<MdlGlossary> MdlGlossaries { get; set; }

    public virtual DbSet<MdlGlossaryAlias> MdlGlossaryAliases { get; set; }

    public virtual DbSet<MdlGlossaryCategory> MdlGlossaryCategories { get; set; }

    public virtual DbSet<MdlGlossaryEntriesCategory> MdlGlossaryEntriesCategories { get; set; }

    public virtual DbSet<MdlGlossaryEntry> MdlGlossaryEntries { get; set; }

    public virtual DbSet<MdlGlossaryFormat> MdlGlossaryFormats { get; set; }

    public virtual DbSet<MdlGradeCategoriesHistory> MdlGradeCategoriesHistories { get; set; }

    public virtual DbSet<MdlGradeCategory> MdlGradeCategories { get; set; }

    public virtual DbSet<MdlGradeGrade> MdlGradeGrades { get; set; }

    public virtual DbSet<MdlGradeGradesHistory> MdlGradeGradesHistories { get; set; }

    public virtual DbSet<MdlGradeImportNewitem> MdlGradeImportNewitems { get; set; }

    public virtual DbSet<MdlGradeImportValue> MdlGradeImportValues { get; set; }

    public virtual DbSet<MdlGradeItem> MdlGradeItems { get; set; }

    public virtual DbSet<MdlGradeItemsHistory> MdlGradeItemsHistories { get; set; }

    public virtual DbSet<MdlGradeLetter> MdlGradeLetters { get; set; }

    public virtual DbSet<MdlGradeOutcome> MdlGradeOutcomes { get; set; }

    public virtual DbSet<MdlGradeOutcomesCourse> MdlGradeOutcomesCourses { get; set; }

    public virtual DbSet<MdlGradeOutcomesHistory> MdlGradeOutcomesHistories { get; set; }

    public virtual DbSet<MdlGradeSetting> MdlGradeSettings { get; set; }

    public virtual DbSet<MdlGradingArea> MdlGradingAreas { get; set; }

    public virtual DbSet<MdlGradingDefinition> MdlGradingDefinitions { get; set; }

    public virtual DbSet<MdlGradingInstance> MdlGradingInstances { get; set; }

    public virtual DbSet<MdlGradingformGuideComment> MdlGradingformGuideComments { get; set; }

    public virtual DbSet<MdlGradingformGuideCriterion> MdlGradingformGuideCriteria { get; set; }

    public virtual DbSet<MdlGradingformGuideFilling> MdlGradingformGuideFillings { get; set; }

    public virtual DbSet<MdlGradingformRubricCriterion> MdlGradingformRubricCriteria { get; set; }

    public virtual DbSet<MdlGradingformRubricFilling> MdlGradingformRubricFillings { get; set; }

    public virtual DbSet<MdlGradingformRubricLevel> MdlGradingformRubricLevels { get; set; }

    public virtual DbSet<MdlGroup> MdlGroups { get; set; }

    public virtual DbSet<MdlGrouping> MdlGroupings { get; set; }

    public virtual DbSet<MdlGroupingsGroup> MdlGroupingsGroups { get; set; }

    public virtual DbSet<MdlGroupsMember> MdlGroupsMembers { get; set; }

    public virtual DbSet<MdlH5p> MdlH5ps { get; set; }

    public virtual DbSet<MdlH5pContentsLibrary> MdlH5pContentsLibraries { get; set; }

    public virtual DbSet<MdlH5pLibrariesCachedasset> MdlH5pLibrariesCachedassets { get; set; }

    public virtual DbSet<MdlH5pLibrary> MdlH5pLibraries { get; set; }

    public virtual DbSet<MdlH5pLibraryDependency> MdlH5pLibraryDependencies { get; set; }

    public virtual DbSet<MdlH5pactivity> MdlH5pactivities { get; set; }

    public virtual DbSet<MdlH5pactivityAttempt> MdlH5pactivityAttempts { get; set; }

    public virtual DbSet<MdlH5pactivityAttemptsResult> MdlH5pactivityAttemptsResults { get; set; }

    public virtual DbSet<MdlImscp> MdlImscps { get; set; }

    public virtual DbSet<MdlLabel> MdlLabels { get; set; }

    public virtual DbSet<MdlLesson> MdlLessons { get; set; }

    public virtual DbSet<MdlLessonAnswer> MdlLessonAnswers { get; set; }

    public virtual DbSet<MdlLessonAttempt> MdlLessonAttempts { get; set; }

    public virtual DbSet<MdlLessonBranch> MdlLessonBranches { get; set; }

    public virtual DbSet<MdlLessonGrade> MdlLessonGrades { get; set; }

    public virtual DbSet<MdlLessonOverride> MdlLessonOverrides { get; set; }

    public virtual DbSet<MdlLessonPage> MdlLessonPages { get; set; }

    public virtual DbSet<MdlLessonTimer> MdlLessonTimers { get; set; }

    public virtual DbSet<MdlLicense> MdlLicenses { get; set; }

    public virtual DbSet<MdlLockDb> MdlLockDbs { get; set; }

    public virtual DbSet<MdlLog> MdlLogs { get; set; }

    public virtual DbSet<MdlLogDisplay> MdlLogDisplays { get; set; }

    public virtual DbSet<MdlLogQuery> MdlLogQueries { get; set; }

    public virtual DbSet<MdlLogstoreStandardLog> MdlLogstoreStandardLogs { get; set; }

    public virtual DbSet<MdlLti> MdlLtis { get; set; }

    public virtual DbSet<MdlLtiAccessToken> MdlLtiAccessTokens { get; set; }

    public virtual DbSet<MdlLtiSubmission> MdlLtiSubmissions { get; set; }

    public virtual DbSet<MdlLtiToolProxy> MdlLtiToolProxies { get; set; }

    public virtual DbSet<MdlLtiToolSetting> MdlLtiToolSettings { get; set; }

    public virtual DbSet<MdlLtiType> MdlLtiTypes { get; set; }

    public virtual DbSet<MdlLtiTypesConfig> MdlLtiTypesConfigs { get; set; }

    public virtual DbSet<MdlLtiserviceGradebookservice> MdlLtiserviceGradebookservices { get; set; }

    public virtual DbSet<MdlMessage> MdlMessages { get; set; }

    public virtual DbSet<MdlMessage1> MdlMessages1 { get; set; }

    public virtual DbSet<MdlMessageAirnotifierDevice> MdlMessageAirnotifierDevices { get; set; }

    public virtual DbSet<MdlMessageContact> MdlMessageContacts { get; set; }

    public virtual DbSet<MdlMessageContactRequest> MdlMessageContactRequests { get; set; }

    public virtual DbSet<MdlMessageConversation> MdlMessageConversations { get; set; }

    public virtual DbSet<MdlMessageConversationAction> MdlMessageConversationActions { get; set; }

    public virtual DbSet<MdlMessageConversationMember> MdlMessageConversationMembers { get; set; }

    public virtual DbSet<MdlMessageEmailMessage> MdlMessageEmailMessages { get; set; }

    public virtual DbSet<MdlMessagePopup> MdlMessagePopups { get; set; }

    public virtual DbSet<MdlMessagePopupNotification> MdlMessagePopupNotifications { get; set; }

    public virtual DbSet<MdlMessageProcessor> MdlMessageProcessors { get; set; }

    public virtual DbSet<MdlMessageProvider> MdlMessageProviders { get; set; }

    public virtual DbSet<MdlMessageRead> MdlMessageReads { get; set; }

    public virtual DbSet<MdlMessageUserAction> MdlMessageUserActions { get; set; }

    public virtual DbSet<MdlMessageUsersBlocked> MdlMessageUsersBlockeds { get; set; }

    public virtual DbSet<MdlMessageinboundDatakey> MdlMessageinboundDatakeys { get; set; }

    public virtual DbSet<MdlMessageinboundHandler> MdlMessageinboundHandlers { get; set; }

    public virtual DbSet<MdlMessageinboundMessagelist> MdlMessageinboundMessagelists { get; set; }

    public virtual DbSet<MdlMnetApplication> MdlMnetApplications { get; set; }

    public virtual DbSet<MdlMnetHost> MdlMnetHosts { get; set; }

    public virtual DbSet<MdlMnetHost2service> MdlMnetHost2services { get; set; }

    public virtual DbSet<MdlMnetLog> MdlMnetLogs { get; set; }

    public virtual DbSet<MdlMnetRemoteRpc> MdlMnetRemoteRpcs { get; set; }

    public virtual DbSet<MdlMnetRemoteService2rpc> MdlMnetRemoteService2rpcs { get; set; }

    public virtual DbSet<MdlMnetRpc> MdlMnetRpcs { get; set; }

    public virtual DbSet<MdlMnetService> MdlMnetServices { get; set; }

    public virtual DbSet<MdlMnetService2rpc> MdlMnetService2rpcs { get; set; }

    public virtual DbSet<MdlMnetSession> MdlMnetSessions { get; set; }

    public virtual DbSet<MdlMnetSsoAccessControl> MdlMnetSsoAccessControls { get; set; }

    public virtual DbSet<MdlMnetserviceEnrolCourse> MdlMnetserviceEnrolCourses { get; set; }

    public virtual DbSet<MdlMnetserviceEnrolEnrolment> MdlMnetserviceEnrolEnrolments { get; set; }

    public virtual DbSet<MdlModule> MdlModules { get; set; }

    public virtual DbSet<MdlMyPage> MdlMyPages { get; set; }

    public virtual DbSet<MdlNotification> MdlNotifications { get; set; }

    public virtual DbSet<MdlOauth2AccessToken> MdlOauth2AccessTokens { get; set; }

    public virtual DbSet<MdlOauth2Endpoint> MdlOauth2Endpoints { get; set; }

    public virtual DbSet<MdlOauth2Issuer> MdlOauth2Issuers { get; set; }

    public virtual DbSet<MdlOauth2SystemAccount> MdlOauth2SystemAccounts { get; set; }

    public virtual DbSet<MdlOauth2UserFieldMapping> MdlOauth2UserFieldMappings { get; set; }

    public virtual DbSet<MdlPage> MdlPages { get; set; }

    public virtual DbSet<MdlPoasassignment> MdlPoasassignments { get; set; }

    public virtual DbSet<MdlPoasassignmentAnalogych> MdlPoasassignmentAnalogyches { get; set; }

    public virtual DbSet<MdlPoasassignmentAnsStng> MdlPoasassignmentAnsStngs { get; set; }

    public virtual DbSet<MdlPoasassignmentAnswer> MdlPoasassignmentAnswers { get; set; }

    public virtual DbSet<MdlPoasassignmentAssignee> MdlPoasassignmentAssignees { get; set; }

    public virtual DbSet<MdlPoasassignmentAttempt> MdlPoasassignmentAttempts { get; set; }

    public virtual DbSet<MdlPoasassignmentField> MdlPoasassignmentFields { get; set; }

    public virtual DbSet<MdlPoasassignmentGrAtRe> MdlPoasassignmentGrAtRes { get; set; }

    public virtual DbSet<MdlPoasassignmentGrAutotester> MdlPoasassignmentGrAutotesters { get; set; }

    public virtual DbSet<MdlPoasassignmentGrRa> MdlPoasassignmentGrRas { get; set; }

    public virtual DbSet<MdlPoasassignmentGrRaTest> MdlPoasassignmentGrRaTests { get; set; }

    public virtual DbSet<MdlPoasassignmentGrader> MdlPoasassignmentGraders { get; set; }

    public virtual DbSet<MdlPoasassignmentParamch> MdlPoasassignmentParamches { get; set; }

    public virtual DbSet<MdlPoasassignmentSubmission> MdlPoasassignmentSubmissions { get; set; }

    public virtual DbSet<MdlPoasassignmentTask> MdlPoasassignmentTasks { get; set; }

    public virtual DbSet<MdlPoasassignmentTaskValue> MdlPoasassignmentTaskValues { get; set; }

    public virtual DbSet<MdlPoasassignmentTaskgiver> MdlPoasassignmentTaskgivers { get; set; }

    public virtual DbSet<MdlPoasassignmentUsedGrader> MdlPoasassignmentUsedGraders { get; set; }

    public virtual DbSet<MdlPoasassignmentVariant> MdlPoasassignmentVariants { get; set; }

    public virtual DbSet<MdlPortfolioInstance> MdlPortfolioInstances { get; set; }

    public virtual DbSet<MdlPortfolioInstanceConfig> MdlPortfolioInstanceConfigs { get; set; }

    public virtual DbSet<MdlPortfolioInstanceUser> MdlPortfolioInstanceUsers { get; set; }

    public virtual DbSet<MdlPortfolioLog> MdlPortfolioLogs { get; set; }

    public virtual DbSet<MdlPortfolioMaharaQueue> MdlPortfolioMaharaQueues { get; set; }

    public virtual DbSet<MdlPortfolioTempdatum> MdlPortfolioTempdata { get; set; }

    public virtual DbSet<MdlPost> MdlPosts { get; set; }

    public virtual DbSet<MdlProfiling> MdlProfilings { get; set; }

    public virtual DbSet<MdlQtypeCorrectwriting> MdlQtypeCorrectwritings { get; set; }

    public virtual DbSet<MdlQtypeCorrectwritingEnum> MdlQtypeCorrectwritingEnums { get; set; }

    public virtual DbSet<MdlQtypeDdimageortext> MdlQtypeDdimageortexts { get; set; }

    public virtual DbSet<MdlQtypeDdimageortextDrag> MdlQtypeDdimageortextDrags { get; set; }

    public virtual DbSet<MdlQtypeDdimageortextDrop> MdlQtypeDdimageortextDrops { get; set; }

    public virtual DbSet<MdlQtypeDdmarker> MdlQtypeDdmarkers { get; set; }

    public virtual DbSet<MdlQtypeDdmarkerDrag> MdlQtypeDdmarkerDrags { get; set; }

    public virtual DbSet<MdlQtypeDdmarkerDrop> MdlQtypeDdmarkerDrops { get; set; }

    public virtual DbSet<MdlQtypeEssayOption> MdlQtypeEssayOptions { get; set; }

    public virtual DbSet<MdlQtypeMatchOption> MdlQtypeMatchOptions { get; set; }

    public virtual DbSet<MdlQtypeMatchSubquestion> MdlQtypeMatchSubquestions { get; set; }

    public virtual DbSet<MdlQtypeMultichoiceOption> MdlQtypeMultichoiceOptions { get; set; }

    public virtual DbSet<MdlQtypePregOption> MdlQtypePregOptions { get; set; }

    public virtual DbSet<MdlQtypePregRegexTest> MdlQtypePregRegexTests { get; set; }

    public virtual DbSet<MdlQtypeRandomsamatchOption> MdlQtypeRandomsamatchOptions { get; set; }

    public virtual DbSet<MdlQtypeShortanswerOption> MdlQtypeShortanswerOptions { get; set; }

    public virtual DbSet<MdlQuestion> MdlQuestions { get; set; }

    public virtual DbSet<MdlQuestionAnswer> MdlQuestionAnswers { get; set; }

    public virtual DbSet<MdlQuestionAttempt> MdlQuestionAttempts { get; set; }

    public virtual DbSet<MdlQuestionAttemptStep> MdlQuestionAttemptSteps { get; set; }

    public virtual DbSet<MdlQuestionAttemptStepDatum> MdlQuestionAttemptStepData { get; set; }

    public virtual DbSet<MdlQuestionCalculated> MdlQuestionCalculateds { get; set; }

    public virtual DbSet<MdlQuestionCalculatedOption> MdlQuestionCalculatedOptions { get; set; }

    public virtual DbSet<MdlQuestionCategory> MdlQuestionCategories { get; set; }

    public virtual DbSet<MdlQuestionDataset> MdlQuestionDatasets { get; set; }

    public virtual DbSet<MdlQuestionDatasetDefinition> MdlQuestionDatasetDefinitions { get; set; }

    public virtual DbSet<MdlQuestionDatasetItem> MdlQuestionDatasetItems { get; set; }

    public virtual DbSet<MdlQuestionDdwto> MdlQuestionDdwtos { get; set; }

    public virtual DbSet<MdlQuestionGapselect> MdlQuestionGapselects { get; set; }

    public virtual DbSet<MdlQuestionGradertest> MdlQuestionGradertests { get; set; }

    public virtual DbSet<MdlQuestionGradertestTasktest> MdlQuestionGradertestTasktests { get; set; }

    public virtual DbSet<MdlQuestionGradertestTest> MdlQuestionGradertestTests { get; set; }

    public virtual DbSet<MdlQuestionHint> MdlQuestionHints { get; set; }

    public virtual DbSet<MdlQuestionMultianswer> MdlQuestionMultianswers { get; set; }

    public virtual DbSet<MdlQuestionNumerical> MdlQuestionNumericals { get; set; }

    public virtual DbSet<MdlQuestionNumericalOption> MdlQuestionNumericalOptions { get; set; }

    public virtual DbSet<MdlQuestionNumericalUnit> MdlQuestionNumericalUnits { get; set; }

    public virtual DbSet<MdlQuestionResponseAnalysis> MdlQuestionResponseAnalyses { get; set; }

    public virtual DbSet<MdlQuestionResponseCount> MdlQuestionResponseCounts { get; set; }

    public virtual DbSet<MdlQuestionStatistic> MdlQuestionStatistics { get; set; }

    public virtual DbSet<MdlQuestionTruefalse> MdlQuestionTruefalses { get; set; }

    public virtual DbSet<MdlQuestionUsage> MdlQuestionUsages { get; set; }

    public virtual DbSet<MdlQuiz> MdlQuizzes { get; set; }

    public virtual DbSet<MdlQuizAttempt> MdlQuizAttempts { get; set; }

    public virtual DbSet<MdlQuizFeedback> MdlQuizFeedbacks { get; set; }

    public virtual DbSet<MdlQuizGrade> MdlQuizGrades { get; set; }

    public virtual DbSet<MdlQuizOverride> MdlQuizOverrides { get; set; }

    public virtual DbSet<MdlQuizOverviewRegrade> MdlQuizOverviewRegrades { get; set; }

    public virtual DbSet<MdlQuizReport> MdlQuizReports { get; set; }

    public virtual DbSet<MdlQuizSection> MdlQuizSections { get; set; }

    public virtual DbSet<MdlQuizSlot> MdlQuizSlots { get; set; }

    public virtual DbSet<MdlQuizSlotTag> MdlQuizSlotTags { get; set; }

    public virtual DbSet<MdlQuizStatistic> MdlQuizStatistics { get; set; }

    public virtual DbSet<MdlQuizaccessSebQuizsetting> MdlQuizaccessSebQuizsettings { get; set; }

    public virtual DbSet<MdlQuizaccessSebTemplate> MdlQuizaccessSebTemplates { get; set; }

    public virtual DbSet<MdlRating> MdlRatings { get; set; }

    public virtual DbSet<MdlRegistrationHub> MdlRegistrationHubs { get; set; }

    public virtual DbSet<MdlRepository> MdlRepositories { get; set; }

    public virtual DbSet<MdlRepositoryInstance> MdlRepositoryInstances { get; set; }

    public virtual DbSet<MdlRepositoryInstanceConfig> MdlRepositoryInstanceConfigs { get; set; }

    public virtual DbSet<MdlRepositoryOnedriveAccess> MdlRepositoryOnedriveAccesses { get; set; }

    public virtual DbSet<MdlResource> MdlResources { get; set; }

    public virtual DbSet<MdlResourceOld> MdlResourceOlds { get; set; }

    public virtual DbSet<MdlRole> MdlRoles { get; set; }

    public virtual DbSet<MdlRoleAllowAssign> MdlRoleAllowAssigns { get; set; }

    public virtual DbSet<MdlRoleAllowOverride> MdlRoleAllowOverrides { get; set; }

    public virtual DbSet<MdlRoleAllowSwitch> MdlRoleAllowSwitches { get; set; }

    public virtual DbSet<MdlRoleAllowView> MdlRoleAllowViews { get; set; }

    public virtual DbSet<MdlRoleAssignment> MdlRoleAssignments { get; set; }

    public virtual DbSet<MdlRoleCapability> MdlRoleCapabilities { get; set; }

    public virtual DbSet<MdlRoleContextLevel> MdlRoleContextLevels { get; set; }

    public virtual DbSet<MdlRoleName> MdlRoleNames { get; set; }

    public virtual DbSet<MdlScale> MdlScales { get; set; }

    public virtual DbSet<MdlScaleHistory> MdlScaleHistories { get; set; }

    public virtual DbSet<MdlScorm> MdlScorms { get; set; }

    public virtual DbSet<MdlScormAiccSession> MdlScormAiccSessions { get; set; }

    public virtual DbSet<MdlScormSco> MdlScormScoes { get; set; }

    public virtual DbSet<MdlScormScoesDatum> MdlScormScoesData { get; set; }

    public virtual DbSet<MdlScormScoesTrack> MdlScormScoesTracks { get; set; }

    public virtual DbSet<MdlScormSeqMapinfo> MdlScormSeqMapinfos { get; set; }

    public virtual DbSet<MdlScormSeqObjective> MdlScormSeqObjectives { get; set; }

    public virtual DbSet<MdlScormSeqRolluprule> MdlScormSeqRolluprules { get; set; }

    public virtual DbSet<MdlScormSeqRolluprulecond> MdlScormSeqRollupruleconds { get; set; }

    public virtual DbSet<MdlScormSeqRulecond> MdlScormSeqRuleconds { get; set; }

    public virtual DbSet<MdlScormSeqRulecond1> MdlScormSeqRuleconds1 { get; set; }

    public virtual DbSet<MdlSearchIndexRequest> MdlSearchIndexRequests { get; set; }

    public virtual DbSet<MdlSearchSimpledbIndex> MdlSearchSimpledbIndices { get; set; }

    public virtual DbSet<MdlSession> MdlSessions { get; set; }

    public virtual DbSet<MdlStatsDaily> MdlStatsDailies { get; set; }

    public virtual DbSet<MdlStatsMonthly> MdlStatsMonthlies { get; set; }

    public virtual DbSet<MdlStatsUserDaily> MdlStatsUserDailies { get; set; }

    public virtual DbSet<MdlStatsUserMonthly> MdlStatsUserMonthlies { get; set; }

    public virtual DbSet<MdlStatsUserWeekly> MdlStatsUserWeeklies { get; set; }

    public virtual DbSet<MdlStatsWeekly> MdlStatsWeeklies { get; set; }

    public virtual DbSet<MdlSurvey> MdlSurveys { get; set; }

    public virtual DbSet<MdlSurveyAnalysis> MdlSurveyAnalyses { get; set; }

    public virtual DbSet<MdlSurveyAnswer> MdlSurveyAnswers { get; set; }

    public virtual DbSet<MdlSurveyQuestion> MdlSurveyQuestions { get; set; }

    public virtual DbSet<MdlTag> MdlTags { get; set; }

    public virtual DbSet<MdlTagArea> MdlTagAreas { get; set; }

    public virtual DbSet<MdlTagColl> MdlTagColls { get; set; }

    public virtual DbSet<MdlTagCorrelation> MdlTagCorrelations { get; set; }

    public virtual DbSet<MdlTagInstance> MdlTagInstances { get; set; }

    public virtual DbSet<MdlTaskAdhoc> MdlTaskAdhocs { get; set; }

    public virtual DbSet<MdlTaskLog> MdlTaskLogs { get; set; }

    public virtual DbSet<MdlTaskScheduled> MdlTaskScheduleds { get; set; }

    public virtual DbSet<MdlToolCohortrole> MdlToolCohortroles { get; set; }

    public virtual DbSet<MdlToolCustomlang> MdlToolCustomlangs { get; set; }

    public virtual DbSet<MdlToolCustomlangComponent> MdlToolCustomlangComponents { get; set; }

    public virtual DbSet<MdlToolDataprivacyCategory> MdlToolDataprivacyCategories { get; set; }

    public virtual DbSet<MdlToolDataprivacyCtxexpired> MdlToolDataprivacyCtxexpireds { get; set; }

    public virtual DbSet<MdlToolDataprivacyCtxinstance> MdlToolDataprivacyCtxinstances { get; set; }

    public virtual DbSet<MdlToolDataprivacyCtxlevel> MdlToolDataprivacyCtxlevels { get; set; }

    public virtual DbSet<MdlToolDataprivacyPurpose> MdlToolDataprivacyPurposes { get; set; }

    public virtual DbSet<MdlToolDataprivacyPurposerole> MdlToolDataprivacyPurposeroles { get; set; }

    public virtual DbSet<MdlToolDataprivacyRequest> MdlToolDataprivacyRequests { get; set; }

    public virtual DbSet<MdlToolMonitorEvent> MdlToolMonitorEvents { get; set; }

    public virtual DbSet<MdlToolMonitorHistory> MdlToolMonitorHistories { get; set; }

    public virtual DbSet<MdlToolMonitorRule> MdlToolMonitorRules { get; set; }

    public virtual DbSet<MdlToolMonitorSubscription> MdlToolMonitorSubscriptions { get; set; }

    public virtual DbSet<MdlToolPolicy> MdlToolPolicies { get; set; }

    public virtual DbSet<MdlToolPolicyAcceptance> MdlToolPolicyAcceptances { get; set; }

    public virtual DbSet<MdlToolPolicyVersion> MdlToolPolicyVersions { get; set; }

    public virtual DbSet<MdlToolRecyclebinCategory> MdlToolRecyclebinCategories { get; set; }

    public virtual DbSet<MdlToolRecyclebinCourse> MdlToolRecyclebinCourses { get; set; }

    public virtual DbSet<MdlToolUsertoursStep> MdlToolUsertoursSteps { get; set; }

    public virtual DbSet<MdlToolUsertoursTour> MdlToolUsertoursTours { get; set; }

    public virtual DbSet<MdlUpgradeLog> MdlUpgradeLogs { get; set; }

    public virtual DbSet<MdlUrl> MdlUrls { get; set; }

    public virtual DbSet<MdlUser> MdlUsers { get; set; }

    public virtual DbSet<MdlUserDevice> MdlUserDevices { get; set; }

    public virtual DbSet<MdlUserEnrolment> MdlUserEnrolments { get; set; }

    public virtual DbSet<MdlUserInfoCategory> MdlUserInfoCategories { get; set; }

    public virtual DbSet<MdlUserInfoDatum> MdlUserInfoData { get; set; }

    public virtual DbSet<MdlUserInfoField> MdlUserInfoFields { get; set; }

    public virtual DbSet<MdlUserLastaccess> MdlUserLastaccesses { get; set; }

    public virtual DbSet<MdlUserPasswordHistory> MdlUserPasswordHistories { get; set; }

    public virtual DbSet<MdlUserPasswordReset> MdlUserPasswordResets { get; set; }

    public virtual DbSet<MdlUserPreference> MdlUserPreferences { get; set; }

    public virtual DbSet<MdlUserPrivateKey> MdlUserPrivateKeys { get; set; }

    public virtual DbSet<MdlWiki> MdlWikis { get; set; }

    public virtual DbSet<MdlWikiLink> MdlWikiLinks { get; set; }

    public virtual DbSet<MdlWikiLock> MdlWikiLocks { get; set; }

    public virtual DbSet<MdlWikiPage> MdlWikiPages { get; set; }

    public virtual DbSet<MdlWikiSubwiki> MdlWikiSubwikis { get; set; }

    public virtual DbSet<MdlWikiSynonym> MdlWikiSynonyms { get; set; }

    public virtual DbSet<MdlWikiVersion> MdlWikiVersions { get; set; }

    public virtual DbSet<MdlWorkshop> MdlWorkshops { get; set; }

    public virtual DbSet<MdlWorkshopAggregation> MdlWorkshopAggregations { get; set; }

    public virtual DbSet<MdlWorkshopAssessment> MdlWorkshopAssessments { get; set; }

    public virtual DbSet<MdlWorkshopGrade> MdlWorkshopGrades { get; set; }

    public virtual DbSet<MdlWorkshopSubmission> MdlWorkshopSubmissions { get; set; }

    public virtual DbSet<MdlWorkshopallocationScheduled> MdlWorkshopallocationScheduleds { get; set; }

    public virtual DbSet<MdlWorkshopevalBestSetting> MdlWorkshopevalBestSettings { get; set; }

    public virtual DbSet<MdlWorkshopformAccumulative> MdlWorkshopformAccumulatives { get; set; }

    public virtual DbSet<MdlWorkshopformComment> MdlWorkshopformComments { get; set; }

    public virtual DbSet<MdlWorkshopformNumerror> MdlWorkshopformNumerrors { get; set; }

    public virtual DbSet<MdlWorkshopformNumerrorsMap> MdlWorkshopformNumerrorsMaps { get; set; }

    public virtual DbSet<MdlWorkshopformRubric> MdlWorkshopformRubrics { get; set; }

    public virtual DbSet<MdlWorkshopformRubricConfig> MdlWorkshopformRubricConfigs { get; set; }

    public virtual DbSet<MdlWorkshopformRubricLevel> MdlWorkshopformRubricLevels { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_unicode_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<MdlAnalyticsIndicatorCalc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_analytics_indicator_calc", tb => tb.HasComment("Stored indicator calculations"));

            entity.HasIndex(e => e.Contextid, "mdl_analindicalc_con_ix");

            entity.HasIndex(e => new { e.Starttime, e.Endtime, e.Contextid }, "mdl_analindicalc_staendcon_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Endtime)
                .HasColumnType("bigint(10)")
                .HasColumnName("endtime");
            entity.Property(e => e.Indicator)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("indicator");
            entity.Property(e => e.Sampleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("sampleid");
            entity.Property(e => e.Sampleorigin)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("sampleorigin");
            entity.Property(e => e.Starttime)
                .HasColumnType("bigint(10)")
                .HasColumnName("starttime");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Value)
                .HasPrecision(10, 2)
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlAnalyticsModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_analytics_models", tb => tb.HasComment("Analytic models."));

            entity.HasIndex(e => new { e.Enabled, e.Trained }, "mdl_analmode_enatra_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextids).HasColumnName("contextids");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Indicators).HasColumnName("indicators");
            entity.Property(e => e.Name)
                .HasMaxLength(1333)
                .HasColumnName("name");
            entity.Property(e => e.Predictionsprocessor)
                .HasMaxLength(255)
                .HasColumnName("predictionsprocessor");
            entity.Property(e => e.Target)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("target");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timesplitting)
                .HasMaxLength(255)
                .HasColumnName("timesplitting");
            entity.Property(e => e.Trained).HasColumnName("trained");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
            entity.Property(e => e.Version)
                .HasColumnType("bigint(10)")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlAnalyticsModelsLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_analytics_models_log", tb => tb.HasComment("Analytic models changes during evaluation."));

            entity.HasIndex(e => e.Modelid, "mdl_analmodelog_mod_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Dir).HasColumnName("dir");
            entity.Property(e => e.Evaluationmode)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("evaluationmode");
            entity.Property(e => e.Indicators).HasColumnName("indicators");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Modelid)
                .HasColumnType("bigint(10)")
                .HasColumnName("modelid");
            entity.Property(e => e.Score)
                .HasPrecision(10, 5)
                .HasColumnName("score");
            entity.Property(e => e.Target)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("target");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timesplitting)
                .HasMaxLength(255)
                .HasColumnName("timesplitting");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
            entity.Property(e => e.Version)
                .HasColumnType("bigint(10)")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlAnalyticsPredictSample>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_analytics_predict_samples", tb => tb.HasComment("Samples already used for predictions."));

            entity.HasIndex(e => e.Modelid, "mdl_analpredsamp_mod_ix");

            entity.HasIndex(e => new { e.Modelid, e.Analysableid, e.Timesplitting, e.Rangeindex }, "mdl_analpredsamp_modanatimr_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Analysableid)
                .HasColumnType("bigint(10)")
                .HasColumnName("analysableid");
            entity.Property(e => e.Modelid)
                .HasColumnType("bigint(10)")
                .HasColumnName("modelid");
            entity.Property(e => e.Rangeindex)
                .HasColumnType("bigint(10)")
                .HasColumnName("rangeindex");
            entity.Property(e => e.Sampleids).HasColumnName("sampleids");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timesplitting)
                .HasDefaultValueSql("''")
                .HasColumnName("timesplitting");
        });

        modelBuilder.Entity<MdlAnalyticsPrediction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_analytics_predictions", tb => tb.HasComment("Predictions"));

            entity.HasIndex(e => e.Contextid, "mdl_analpred_con_ix");

            entity.HasIndex(e => e.Modelid, "mdl_analpred_mod_ix");

            entity.HasIndex(e => new { e.Modelid, e.Contextid }, "mdl_analpred_modcon_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Calculations).HasColumnName("calculations");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Modelid)
                .HasColumnType("bigint(10)")
                .HasColumnName("modelid");
            entity.Property(e => e.Prediction)
                .HasPrecision(10, 2)
                .HasColumnName("prediction");
            entity.Property(e => e.Predictionscore)
                .HasPrecision(10, 5)
                .HasColumnName("predictionscore");
            entity.Property(e => e.Rangeindex)
                .HasColumnType("mediumint(5)")
                .HasColumnName("rangeindex");
            entity.Property(e => e.Sampleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("sampleid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timeend)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
            entity.Property(e => e.Timestart)
                .HasColumnType("bigint(10)")
                .HasColumnName("timestart");
        });

        modelBuilder.Entity<MdlAnalyticsPredictionAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_analytics_prediction_actions", tb => tb.HasComment("Register of user actions over predictions."));

            entity.HasIndex(e => e.Predictionid, "mdl_analpredacti_pre_ix");

            entity.HasIndex(e => new { e.Predictionid, e.Userid, e.Actionname }, "mdl_analpredacti_preuseact_ix");

            entity.HasIndex(e => e.Userid, "mdl_analpredacti_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Actionname)
                .HasDefaultValueSql("''")
                .HasColumnName("actionname");
            entity.Property(e => e.Predictionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("predictionid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAnalyticsTrainSample>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_analytics_train_samples", tb => tb.HasComment("Samples used for training"));

            entity.HasIndex(e => e.Modelid, "mdl_analtraisamp_mod_ix");

            entity.HasIndex(e => new { e.Modelid, e.Analysableid, e.Timesplitting }, "mdl_analtraisamp_modanatim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Analysableid)
                .HasColumnType("bigint(10)")
                .HasColumnName("analysableid");
            entity.Property(e => e.Modelid)
                .HasColumnType("bigint(10)")
                .HasColumnName("modelid");
            entity.Property(e => e.Sampleids).HasColumnName("sampleids");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timesplitting)
                .HasDefaultValueSql("''")
                .HasColumnName("timesplitting");
        });

        modelBuilder.Entity<MdlAnalyticsUsedAnalysable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_analytics_used_analysables", tb => tb.HasComment("List of analysables used by each model"));

            entity.HasIndex(e => e.Analysableid, "mdl_analusedanal_ana_ix");

            entity.HasIndex(e => e.Modelid, "mdl_analusedanal_mod_ix");

            entity.HasIndex(e => new { e.Modelid, e.Action }, "mdl_analusedanal_modact_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Analysableid)
                .HasColumnType("bigint(10)")
                .HasColumnName("analysableid");
            entity.Property(e => e.Firstanalysis)
                .HasColumnType("bigint(10)")
                .HasColumnName("firstanalysis");
            entity.Property(e => e.Modelid)
                .HasColumnType("bigint(10)")
                .HasColumnName("modelid");
            entity.Property(e => e.Timeanalysed)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeanalysed");
        });

        modelBuilder.Entity<MdlAnalyticsUsedFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_analytics_used_files", tb => tb.HasComment("Files that have already been used for training and predictio"));

            entity.HasIndex(e => e.Fileid, "mdl_analusedfile_fil_ix");

            entity.HasIndex(e => e.Modelid, "mdl_analusedfile_mod_ix");

            entity.HasIndex(e => new { e.Modelid, e.Action, e.Fileid }, "mdl_analusedfile_modactfil_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Fileid)
                .HasColumnType("bigint(10)")
                .HasColumnName("fileid");
            entity.Property(e => e.Modelid)
                .HasColumnType("bigint(10)")
                .HasColumnName("modelid");
            entity.Property(e => e.Time)
                .HasColumnType("bigint(10)")
                .HasColumnName("time");
        });

        modelBuilder.Entity<MdlAssign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assign", tb => tb.HasComment("This table saves information about an instance of mod_assign"));

            entity.HasIndex(e => e.Course, "mdl_assi_cou_ix");

            entity.HasIndex(e => e.Teamsubmissiongroupingid, "mdl_assi_tea_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Allowsubmissionsfromdate)
                .HasColumnType("bigint(10)")
                .HasColumnName("allowsubmissionsfromdate");
            entity.Property(e => e.Alwaysshowdescription)
                .HasColumnType("tinyint(2)")
                .HasColumnName("alwaysshowdescription");
            entity.Property(e => e.Attemptreopenmethod)
                .HasMaxLength(10)
                .HasDefaultValueSql("'none'")
                .HasColumnName("attemptreopenmethod");
            entity.Property(e => e.Blindmarking)
                .HasColumnType("tinyint(2)")
                .HasColumnName("blindmarking");
            entity.Property(e => e.Completionsubmit)
                .HasColumnType("tinyint(2)")
                .HasColumnName("completionsubmit");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Cutoffdate)
                .HasColumnType("bigint(10)")
                .HasColumnName("cutoffdate");
            entity.Property(e => e.Duedate)
                .HasColumnType("bigint(10)")
                .HasColumnName("duedate");
            entity.Property(e => e.Grade)
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Gradingduedate)
                .HasColumnType("bigint(10)")
                .HasColumnName("gradingduedate");
            entity.Property(e => e.Hidegrader)
                .HasColumnType("tinyint(2)")
                .HasColumnName("hidegrader");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Markingallocation)
                .HasColumnType("tinyint(2)")
                .HasColumnName("markingallocation");
            entity.Property(e => e.Markingworkflow)
                .HasColumnType("tinyint(2)")
                .HasColumnName("markingworkflow");
            entity.Property(e => e.Maxattempts)
                .HasDefaultValueSql("-1")
                .HasColumnType("mediumint(6)")
                .HasColumnName("maxattempts");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Nosubmissions)
                .HasColumnType("tinyint(2)")
                .HasColumnName("nosubmissions");
            entity.Property(e => e.Preventsubmissionnotingroup)
                .HasColumnType("tinyint(2)")
                .HasColumnName("preventsubmissionnotingroup");
            entity.Property(e => e.Requireallteammemberssubmit)
                .HasColumnType("tinyint(2)")
                .HasColumnName("requireallteammemberssubmit");
            entity.Property(e => e.Requiresubmissionstatement)
                .HasColumnType("tinyint(2)")
                .HasColumnName("requiresubmissionstatement");
            entity.Property(e => e.Revealidentities)
                .HasColumnType("tinyint(2)")
                .HasColumnName("revealidentities");
            entity.Property(e => e.Sendlatenotifications)
                .HasColumnType("tinyint(2)")
                .HasColumnName("sendlatenotifications");
            entity.Property(e => e.Sendnotifications)
                .HasColumnType("tinyint(2)")
                .HasColumnName("sendnotifications");
            entity.Property(e => e.Sendstudentnotifications)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("sendstudentnotifications");
            entity.Property(e => e.Submissiondrafts)
                .HasColumnType("tinyint(2)")
                .HasColumnName("submissiondrafts");
            entity.Property(e => e.Teamsubmission)
                .HasColumnType("tinyint(2)")
                .HasColumnName("teamsubmission");
            entity.Property(e => e.Teamsubmissiongroupingid)
                .HasColumnType("bigint(10)")
                .HasColumnName("teamsubmissiongroupingid");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlAssignGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assign_grades", tb => tb.HasComment("Grading information about a single assignment submission."));

            entity.HasIndex(e => e.Assignment, "mdl_assigrad_ass_ix");

            entity.HasIndex(e => new { e.Assignment, e.Userid, e.Attemptnumber }, "mdl_assigrad_assuseatt_uix").IsUnique();

            entity.HasIndex(e => e.Attemptnumber, "mdl_assigrad_att_ix");

            entity.HasIndex(e => e.Userid, "mdl_assigrad_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assignment)
                .HasColumnType("bigint(10)")
                .HasColumnName("assignment");
            entity.Property(e => e.Attemptnumber)
                .HasColumnType("bigint(10)")
                .HasColumnName("attemptnumber");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'0.00000'")
                .HasColumnName("grade");
            entity.Property(e => e.Grader)
                .HasColumnType("bigint(10)")
                .HasColumnName("grader");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAssignOverride>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assign_overrides", tb => tb.HasComment("The overrides to assign settings."));

            entity.HasIndex(e => e.Assignid, "mdl_assiover_ass_ix");

            entity.HasIndex(e => e.Groupid, "mdl_assiover_gro_ix");

            entity.HasIndex(e => e.Userid, "mdl_assiover_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Allowsubmissionsfromdate)
                .HasColumnType("bigint(10)")
                .HasColumnName("allowsubmissionsfromdate");
            entity.Property(e => e.Assignid)
                .HasColumnType("bigint(10)")
                .HasColumnName("assignid");
            entity.Property(e => e.Cutoffdate)
                .HasColumnType("bigint(10)")
                .HasColumnName("cutoffdate");
            entity.Property(e => e.Duedate)
                .HasColumnType("bigint(10)")
                .HasColumnName("duedate");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAssignPluginConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assign_plugin_config", tb => tb.HasComment("Config data for an instance of a plugin in an assignment."));

            entity.HasIndex(e => e.Assignment, "mdl_assiplugconf_ass_ix");

            entity.HasIndex(e => e.Name, "mdl_assiplugconf_nam_ix");

            entity.HasIndex(e => e.Plugin, "mdl_assiplugconf_plu_ix");

            entity.HasIndex(e => e.Subtype, "mdl_assiplugconf_sub_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assignment)
                .HasColumnType("bigint(10)")
                .HasColumnName("assignment");
            entity.Property(e => e.Name)
                .HasMaxLength(28)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Plugin)
                .HasMaxLength(28)
                .HasDefaultValueSql("''")
                .HasColumnName("plugin");
            entity.Property(e => e.Subtype)
                .HasMaxLength(28)
                .HasDefaultValueSql("''")
                .HasColumnName("subtype");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlAssignSubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assign_submission", tb => tb.HasComment("This table keeps information about student interactions with"));

            entity.HasIndex(e => e.Assignment, "mdl_assisubm_ass_ix");

            entity.HasIndex(e => new { e.Assignment, e.Userid, e.Groupid, e.Attemptnumber }, "mdl_assisubm_assusegroatt_uix").IsUnique();

            entity.HasIndex(e => new { e.Assignment, e.Userid, e.Groupid, e.Latest }, "mdl_assisubm_assusegrolat_ix");

            entity.HasIndex(e => e.Attemptnumber, "mdl_assisubm_att_ix");

            entity.HasIndex(e => e.Userid, "mdl_assisubm_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assignment)
                .HasColumnType("bigint(10)")
                .HasColumnName("assignment");
            entity.Property(e => e.Attemptnumber)
                .HasColumnType("bigint(10)")
                .HasColumnName("attemptnumber");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Latest)
                .HasColumnType("tinyint(2)")
                .HasColumnName("latest");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasColumnName("status");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAssignUserFlag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assign_user_flags", tb => tb.HasComment("List of flags that can be set for a single user in a single "));

            entity.HasIndex(e => e.Assignment, "mdl_assiuserflag_ass_ix");

            entity.HasIndex(e => e.Mailed, "mdl_assiuserflag_mai_ix");

            entity.HasIndex(e => e.Userid, "mdl_assiuserflag_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Allocatedmarker)
                .HasColumnType("bigint(10)")
                .HasColumnName("allocatedmarker");
            entity.Property(e => e.Assignment)
                .HasColumnType("bigint(10)")
                .HasColumnName("assignment");
            entity.Property(e => e.Extensionduedate)
                .HasColumnType("bigint(10)")
                .HasColumnName("extensionduedate");
            entity.Property(e => e.Locked)
                .HasColumnType("bigint(10)")
                .HasColumnName("locked");
            entity.Property(e => e.Mailed)
                .HasColumnType("smallint(4)")
                .HasColumnName("mailed");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Workflowstate)
                .HasMaxLength(20)
                .HasColumnName("workflowstate");
        });

        modelBuilder.Entity<MdlAssignUserMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assign_user_mapping", tb => tb.HasComment("Map an assignment specific id number to a user"));

            entity.HasIndex(e => e.Assignment, "mdl_assiusermapp_ass_ix");

            entity.HasIndex(e => e.Userid, "mdl_assiusermapp_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assignment)
                .HasColumnType("bigint(10)")
                .HasColumnName("assignment");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAssignfeedbackComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignfeedback_comments", tb => tb.HasComment("Text feedback for submitted assignments"));

            entity.HasIndex(e => e.Assignment, "mdl_assicomm_ass_ix");

            entity.HasIndex(e => e.Grade, "mdl_assicomm_gra_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assignment)
                .HasColumnType("bigint(10)")
                .HasColumnName("assignment");
            entity.Property(e => e.Commentformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("commentformat");
            entity.Property(e => e.Commenttext).HasColumnName("commenttext");
            entity.Property(e => e.Grade)
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
        });

        modelBuilder.Entity<MdlAssignfeedbackEditpdfAnnot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignfeedback_editpdf_annot", tb => tb.HasComment("stores annotations added to pdfs submitted by students"));

            entity.HasIndex(e => e.Gradeid, "mdl_assieditanno_gra_ix");

            entity.HasIndex(e => new { e.Gradeid, e.Pageno }, "mdl_assieditanno_grapag_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Colour)
                .HasMaxLength(10)
                .HasDefaultValueSql("'black'")
                .HasColumnName("colour");
            entity.Property(e => e.Draft)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("draft");
            entity.Property(e => e.Endx)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("endx");
            entity.Property(e => e.Endy)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("endy");
            entity.Property(e => e.Gradeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("gradeid");
            entity.Property(e => e.Pageno)
                .HasColumnType("bigint(10)")
                .HasColumnName("pageno");
            entity.Property(e => e.Path).HasColumnName("path");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasDefaultValueSql("'line'")
                .HasColumnName("type");
            entity.Property(e => e.X)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("x");
            entity.Property(e => e.Y)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("y");
        });

        modelBuilder.Entity<MdlAssignfeedbackEditpdfCmnt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignfeedback_editpdf_cmnt", tb => tb.HasComment("Stores comments added to pdfs"));

            entity.HasIndex(e => e.Gradeid, "mdl_assieditcmnt_gra_ix");

            entity.HasIndex(e => new { e.Gradeid, e.Pageno }, "mdl_assieditcmnt_grapag_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Colour)
                .HasMaxLength(10)
                .HasDefaultValueSql("'black'")
                .HasColumnName("colour");
            entity.Property(e => e.Draft)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("draft");
            entity.Property(e => e.Gradeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("gradeid");
            entity.Property(e => e.Pageno)
                .HasColumnType("bigint(10)")
                .HasColumnName("pageno");
            entity.Property(e => e.Rawtext).HasColumnName("rawtext");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("'120'")
                .HasColumnType("bigint(10)")
                .HasColumnName("width");
            entity.Property(e => e.X)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("x");
            entity.Property(e => e.Y)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("y");
        });

        modelBuilder.Entity<MdlAssignfeedbackEditpdfQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignfeedback_editpdf_queue", tb => tb.HasComment("Queue for processing."));

            entity.HasIndex(e => new { e.Submissionid, e.Submissionattempt }, "mdl_assieditqueu_subsub_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attemptedconversions)
                .HasColumnType("bigint(10)")
                .HasColumnName("attemptedconversions");
            entity.Property(e => e.Submissionattempt)
                .HasColumnType("bigint(10)")
                .HasColumnName("submissionattempt");
            entity.Property(e => e.Submissionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("submissionid");
        });

        modelBuilder.Entity<MdlAssignfeedbackEditpdfQuick>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignfeedback_editpdf_quick", tb => tb.HasComment("Stores teacher specified quicklist comments"));

            entity.HasIndex(e => e.Userid, "mdl_assieditquic_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Colour)
                .HasMaxLength(10)
                .HasDefaultValueSql("'yellow'")
                .HasColumnName("colour");
            entity.Property(e => e.Rawtext).HasColumnName("rawtext");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("'120'")
                .HasColumnType("bigint(10)")
                .HasColumnName("width");
        });

        modelBuilder.Entity<MdlAssignfeedbackEditpdfRot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignfeedback_editpdf_rot", tb => tb.HasComment("Stores rotation information of a page."));

            entity.HasIndex(e => e.Gradeid, "mdl_assieditrot_gra_ix");

            entity.HasIndex(e => new { e.Gradeid, e.Pageno }, "mdl_assieditrot_grapag_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Degree)
                .HasColumnType("bigint(10)")
                .HasColumnName("degree");
            entity.Property(e => e.Gradeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("gradeid");
            entity.Property(e => e.Isrotated).HasColumnName("isrotated");
            entity.Property(e => e.Pageno)
                .HasColumnType("bigint(10)")
                .HasColumnName("pageno");
            entity.Property(e => e.Pathnamehash).HasColumnName("pathnamehash");
        });

        modelBuilder.Entity<MdlAssignfeedbackFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignfeedback_file", tb => tb.HasComment("Stores info about the number of files submitted by a student"));

            entity.HasIndex(e => e.Assignment, "mdl_assifile_ass2_ix");

            entity.HasIndex(e => e.Grade, "mdl_assifile_gra_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assignment)
                .HasColumnType("bigint(10)")
                .HasColumnName("assignment");
            entity.Property(e => e.Grade)
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Numfiles)
                .HasColumnType("bigint(10)")
                .HasColumnName("numfiles");
        });

        modelBuilder.Entity<MdlAssignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignment", tb => tb.HasComment("Defines assignments"));

            entity.HasIndex(e => e.Course, "mdl_assi_cou2_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assignmenttype)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("assignmenttype");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Emailteachers)
                .HasColumnType("tinyint(2)")
                .HasColumnName("emailteachers");
            entity.Property(e => e.Grade)
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Maxbytes)
                .HasDefaultValueSql("'100000'")
                .HasColumnType("bigint(10)")
                .HasColumnName("maxbytes");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Preventlate)
                .HasColumnType("tinyint(2)")
                .HasColumnName("preventlate");
            entity.Property(e => e.Resubmit)
                .HasColumnType("tinyint(2)")
                .HasColumnName("resubmit");
            entity.Property(e => e.Timeavailable)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeavailable");
            entity.Property(e => e.Timedue)
                .HasColumnType("bigint(10)")
                .HasColumnName("timedue");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Var1)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("var1");
            entity.Property(e => e.Var2)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("var2");
            entity.Property(e => e.Var3)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("var3");
            entity.Property(e => e.Var4)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("var4");
            entity.Property(e => e.Var5)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("var5");
        });

        modelBuilder.Entity<MdlAssignmentSubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignment_submissions", tb => tb.HasComment("Info about submitted assignments"));

            entity.HasIndex(e => e.Assignment, "mdl_assisubm_ass2_ix");

            entity.HasIndex(e => e.Mailed, "mdl_assisubm_mai_ix");

            entity.HasIndex(e => e.Timemarked, "mdl_assisubm_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_assisubm_use2_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assignment)
                .HasColumnType("bigint(10)")
                .HasColumnName("assignment");
            entity.Property(e => e.Data1).HasColumnName("data1");
            entity.Property(e => e.Data2).HasColumnName("data2");
            entity.Property(e => e.Format)
                .HasColumnType("smallint(4)")
                .HasColumnName("format");
            entity.Property(e => e.Grade)
                .HasColumnType("bigint(11)")
                .HasColumnName("grade");
            entity.Property(e => e.Mailed).HasColumnName("mailed");
            entity.Property(e => e.Numfiles)
                .HasColumnType("bigint(10)")
                .HasColumnName("numfiles");
            entity.Property(e => e.Submissioncomment).HasColumnName("submissioncomment");
            entity.Property(e => e.Teacher)
                .HasColumnType("bigint(10)")
                .HasColumnName("teacher");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemarked)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemarked");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlAssignmentUpgrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignment_upgrade", tb => tb.HasComment("Info about upgraded assignments"));

            entity.HasIndex(e => e.Oldinstance, "mdl_assiupgr_old2_ix");

            entity.HasIndex(e => e.Oldcmid, "mdl_assiupgr_old_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Newcmid)
                .HasColumnType("bigint(10)")
                .HasColumnName("newcmid");
            entity.Property(e => e.Newinstance)
                .HasColumnType("bigint(10)")
                .HasColumnName("newinstance");
            entity.Property(e => e.Oldcmid)
                .HasColumnType("bigint(10)")
                .HasColumnName("oldcmid");
            entity.Property(e => e.Oldinstance)
                .HasColumnType("bigint(10)")
                .HasColumnName("oldinstance");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlAssignsubmissionFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignsubmission_file", tb => tb.HasComment("Info about file submissions for assignments"));

            entity.HasIndex(e => e.Assignment, "mdl_assifile_ass_ix");

            entity.HasIndex(e => e.Submission, "mdl_assifile_sub_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assignment)
                .HasColumnType("bigint(10)")
                .HasColumnName("assignment");
            entity.Property(e => e.Numfiles)
                .HasColumnType("bigint(10)")
                .HasColumnName("numfiles");
            entity.Property(e => e.Submission)
                .HasColumnType("bigint(10)")
                .HasColumnName("submission");
        });

        modelBuilder.Entity<MdlAssignsubmissionOnlinetext>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_assignsubmission_onlinetext", tb => tb.HasComment("Info about onlinetext submission"));

            entity.HasIndex(e => e.Assignment, "mdl_assionli_ass_ix");

            entity.HasIndex(e => e.Submission, "mdl_assionli_sub_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assignment)
                .HasColumnType("bigint(10)")
                .HasColumnName("assignment");
            entity.Property(e => e.Onlineformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("onlineformat");
            entity.Property(e => e.Onlinetext).HasColumnName("onlinetext");
            entity.Property(e => e.Submission)
                .HasColumnType("bigint(10)")
                .HasColumnName("submission");
        });

        modelBuilder.Entity<MdlAuditorSyncTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_auditor_sync_tasks", tb => tb.HasComment("Default comment for auditor_sync, please edit me"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Auditorvariantid)
                .HasColumnType("bigint(11)")
                .HasColumnName("auditorvariantid");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.Poasassignmenttaskid)
                .HasColumnType("bigint(11)")
                .HasColumnName("poasassignmenttaskid");
        });

        modelBuilder.Entity<MdlAuthOauth2LinkedLogin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_auth_oauth2_linked_login", tb => tb.HasComment("Accounts linked to a users Moodle account."));

            entity.HasIndex(e => e.Issuerid, "mdl_authoautlinklogi_iss_ix");

            entity.HasIndex(e => new { e.Issuerid, e.Username }, "mdl_authoautlinklogi_issuse_ix");

            entity.HasIndex(e => e.Userid, "mdl_authoautlinklogi_use2_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_authoautlinklogi_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Issuerid, e.Username }, "mdl_authoautlinklogi_useis_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Confirmtoken)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("confirmtoken");
            entity.Property(e => e.Confirmtokenexpires)
                .HasColumnType("bigint(10)")
                .HasColumnName("confirmtokenexpires");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Issuerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("issuerid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
            entity.Property(e => e.Username)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<MdlBackupController>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_backup_controllers", tb => tb.HasComment("To store the backup_controllers as they are used"));

            entity.HasIndex(e => e.Backupid, "mdl_backcont_bac_uix").IsUnique();

            entity.HasIndex(e => new { e.Type, e.Itemid }, "mdl_backcont_typite_ix");

            entity.HasIndex(e => e.Userid, "mdl_backcont_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Itemid }, "mdl_backcont_useite_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Backupid)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("backupid");
            entity.Property(e => e.Checksum)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("checksum");
            entity.Property(e => e.Controller).HasColumnName("controller");
            entity.Property(e => e.Execution)
                .HasColumnType("smallint(4)")
                .HasColumnName("execution");
            entity.Property(e => e.Executiontime)
                .HasColumnType("bigint(10)")
                .HasColumnName("executiontime");
            entity.Property(e => e.Format)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("format");
            entity.Property(e => e.Interactive)
                .HasColumnType("smallint(4)")
                .HasColumnName("interactive");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Operation)
                .HasMaxLength(20)
                .HasDefaultValueSql("'backup'")
                .HasColumnName("operation");
            entity.Property(e => e.Progress)
                .HasPrecision(15, 14)
                .HasColumnName("progress");
            entity.Property(e => e.Purpose)
                .HasColumnType("smallint(4)")
                .HasColumnName("purpose");
            entity.Property(e => e.Status)
                .HasColumnType("smallint(4)")
                .HasColumnName("status");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBackupCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_backup_courses", tb => tb.HasComment("To store every course backup status"));

            entity.HasIndex(e => e.Courseid, "mdl_backcour_cou_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Lastendtime)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastendtime");
            entity.Property(e => e.Laststarttime)
                .HasColumnType("bigint(10)")
                .HasColumnName("laststarttime");
            entity.Property(e => e.Laststatus)
                .HasMaxLength(1)
                .HasDefaultValueSql("'5'")
                .HasColumnName("laststatus");
            entity.Property(e => e.Nextstarttime)
                .HasColumnType("bigint(10)")
                .HasColumnName("nextstarttime");
        });

        modelBuilder.Entity<MdlBackupLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_backup_logs", tb => tb.HasComment("To store all the logs from backup and restore operations (by"));

            entity.HasIndex(e => e.Backupid, "mdl_backlogs_bac_ix");

            entity.HasIndex(e => new { e.Backupid, e.Id }, "mdl_backlogs_bacid_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Backupid)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("backupid");
            entity.Property(e => e.Loglevel)
                .HasColumnType("smallint(4)")
                .HasColumnName("loglevel");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlBadge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge", tb => tb.HasComment("Defines badge"));

            entity.HasIndex(e => e.Courseid, "mdl_badg_cou_ix");

            entity.HasIndex(e => e.Type, "mdl_badg_typ_ix");

            entity.HasIndex(e => e.Usercreated, "mdl_badg_use2_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_badg_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attachment)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("attachment");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Expiredate)
                .HasColumnType("bigint(10)")
                .HasColumnName("expiredate");
            entity.Property(e => e.Expireperiod)
                .HasColumnType("bigint(10)")
                .HasColumnName("expireperiod");
            entity.Property(e => e.Imageauthoremail)
                .HasMaxLength(255)
                .HasColumnName("imageauthoremail");
            entity.Property(e => e.Imageauthorname)
                .HasMaxLength(255)
                .HasColumnName("imageauthorname");
            entity.Property(e => e.Imageauthorurl)
                .HasMaxLength(255)
                .HasColumnName("imageauthorurl");
            entity.Property(e => e.Imagecaption).HasColumnName("imagecaption");
            entity.Property(e => e.Issuercontact)
                .HasMaxLength(255)
                .HasColumnName("issuercontact");
            entity.Property(e => e.Issuername)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("issuername");
            entity.Property(e => e.Issuerurl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("issuerurl");
            entity.Property(e => e.Language)
                .HasMaxLength(255)
                .HasColumnName("language");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Messagesubject).HasColumnName("messagesubject");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Nextcron)
                .HasColumnType("bigint(10)")
                .HasColumnName("nextcron");
            entity.Property(e => e.Notification)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("notification");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("type");
            entity.Property(e => e.Usercreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("usercreated");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlBadgeAlignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_alignment", tb => tb.HasComment("Defines alignment for badges"));

            entity.HasIndex(e => e.Badgeid, "mdl_badgalig_bad_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Badgeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("badgeid");
            entity.Property(e => e.Targetcode)
                .HasMaxLength(255)
                .HasColumnName("targetcode");
            entity.Property(e => e.Targetdescription).HasColumnName("targetdescription");
            entity.Property(e => e.Targetframework)
                .HasMaxLength(255)
                .HasColumnName("targetframework");
            entity.Property(e => e.Targetname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("targetname");
            entity.Property(e => e.Targeturl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("targeturl");
        });

        modelBuilder.Entity<MdlBadgeBackpack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_backpack", tb => tb.HasComment("Defines settings for connecting external backpack"));

            entity.HasIndex(e => e.Externalbackpackid, "mdl_badgback_ext_ix");

            entity.HasIndex(e => e.Userid, "mdl_badgback_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Autosync).HasColumnName("autosync");
            entity.Property(e => e.Backpackuid)
                .HasColumnType("bigint(10)")
                .HasColumnName("backpackuid");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.Externalbackpackid)
                .HasColumnType("bigint(10)")
                .HasColumnName("externalbackpackid");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBadgeBackpackOauth2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_backpack_oauth2", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.HasIndex(e => e.Externalbackpackid, "mdl_badgbackoaut_ext_ix");

            entity.HasIndex(e => e.Issuerid, "mdl_badgbackoaut_iss_ix");

            entity.HasIndex(e => e.Userid, "mdl_badgbackoaut_use2_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_badgbackoaut_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Expires)
                .HasColumnType("bigint(10)")
                .HasColumnName("expires");
            entity.Property(e => e.Externalbackpackid)
                .HasColumnType("bigint(10)")
                .HasColumnName("externalbackpackid");
            entity.Property(e => e.Issuerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("issuerid");
            entity.Property(e => e.Refreshtoken).HasColumnName("refreshtoken");
            entity.Property(e => e.Scope).HasColumnName("scope");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlBadgeCriteriaMet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_criteria_met", tb => tb.HasComment("Defines criteria that were met for an issued badge"));

            entity.HasIndex(e => e.Critid, "mdl_badgcritmet_cri_ix");

            entity.HasIndex(e => e.Issuedid, "mdl_badgcritmet_iss_ix");

            entity.HasIndex(e => e.Userid, "mdl_badgcritmet_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Critid)
                .HasColumnType("bigint(10)")
                .HasColumnName("critid");
            entity.Property(e => e.Datemet)
                .HasColumnType("bigint(10)")
                .HasColumnName("datemet");
            entity.Property(e => e.Issuedid)
                .HasColumnType("bigint(10)")
                .HasColumnName("issuedid");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBadgeCriteriaParam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_criteria_param", tb => tb.HasComment("Defines parameters for badges criteria"));

            entity.HasIndex(e => e.Critid, "mdl_badgcritpara_cri_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Critid)
                .HasColumnType("bigint(10)")
                .HasColumnName("critid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlBadgeCriterion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_criteria", tb => tb.HasComment("Defines criteria for issuing badges"));

            entity.HasIndex(e => e.Badgeid, "mdl_badgcrit_bad_ix");

            entity.HasIndex(e => new { e.Badgeid, e.Criteriatype }, "mdl_badgcrit_badcri_uix").IsUnique();

            entity.HasIndex(e => e.Criteriatype, "mdl_badgcrit_cri_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Badgeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("badgeid");
            entity.Property(e => e.Criteriatype)
                .HasColumnType("bigint(10)")
                .HasColumnName("criteriatype");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Method)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("method");
        });

        modelBuilder.Entity<MdlBadgeEndorsement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_endorsement", tb => tb.HasComment("Defines endorsement for badge"));

            entity.HasIndex(e => e.Badgeid, "mdl_badgendo_bad_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Badgeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("badgeid");
            entity.Property(e => e.Claimcomment).HasColumnName("claimcomment");
            entity.Property(e => e.Claimid)
                .HasMaxLength(255)
                .HasColumnName("claimid");
            entity.Property(e => e.Dateissued)
                .HasColumnType("bigint(10)")
                .HasColumnName("dateissued");
            entity.Property(e => e.Issueremail)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("issueremail");
            entity.Property(e => e.Issuername)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("issuername");
            entity.Property(e => e.Issuerurl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("issuerurl");
        });

        modelBuilder.Entity<MdlBadgeExternal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_external", tb => tb.HasComment("Setting for external badges display"));

            entity.HasIndex(e => e.Backpackid, "mdl_badgexte_bac_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assertion).HasColumnName("assertion");
            entity.Property(e => e.Backpackid)
                .HasColumnType("bigint(10)")
                .HasColumnName("backpackid");
            entity.Property(e => e.Collectionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("collectionid");
            entity.Property(e => e.Entityid)
                .HasMaxLength(255)
                .HasColumnName("entityid");
        });

        modelBuilder.Entity<MdlBadgeExternalBackpack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_external_backpack", tb => tb.HasComment("Defines settings for site level backpacks that a user can co"));

            entity.HasIndex(e => e.Backpackweburl, "mdl_badgexteback_bac2_uix").IsUnique();

            entity.HasIndex(e => e.Backpackapiurl, "mdl_badgexteback_bac_uix").IsUnique();

            entity.HasIndex(e => e.Oauth2Issuerid, "mdl_badgexteback_oau_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Apiversion)
                .HasMaxLength(12)
                .HasDefaultValueSql("'1.0'")
                .HasColumnName("apiversion");
            entity.Property(e => e.Backpackapiurl)
                .HasDefaultValueSql("''")
                .HasColumnName("backpackapiurl");
            entity.Property(e => e.Backpackweburl)
                .HasDefaultValueSql("''")
                .HasColumnName("backpackweburl");
            entity.Property(e => e.Oauth2Issuerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("oauth2_issuerid");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlBadgeExternalIdentifier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_external_identifier", tb => tb.HasComment("Setting for external badges mappings"));

            entity.HasIndex(e => e.Sitebackpackid, "mdl_badgexteiden_sit_ix");

            entity.HasIndex(e => new { e.Sitebackpackid, e.Internalid, e.Externalid, e.Type }, "mdl_badgexteiden_sitintext_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Externalid)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("externalid");
            entity.Property(e => e.Internalid)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("internalid");
            entity.Property(e => e.Sitebackpackid)
                .HasColumnType("bigint(10)")
                .HasColumnName("sitebackpackid");
            entity.Property(e => e.Type)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlBadgeIssued>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_issued", tb => tb.HasComment("Defines issued badges"));

            entity.HasIndex(e => e.Badgeid, "mdl_badgissu_bad_ix");

            entity.HasIndex(e => new { e.Badgeid, e.Userid }, "mdl_badgissu_baduse_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_badgissu_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Badgeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("badgeid");
            entity.Property(e => e.Dateexpire)
                .HasColumnType("bigint(10)")
                .HasColumnName("dateexpire");
            entity.Property(e => e.Dateissued)
                .HasColumnType("bigint(10)")
                .HasColumnName("dateissued");
            entity.Property(e => e.Issuernotified)
                .HasColumnType("bigint(10)")
                .HasColumnName("issuernotified");
            entity.Property(e => e.Uniquehash).HasColumnName("uniquehash");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Visible).HasColumnName("visible");
        });

        modelBuilder.Entity<MdlBadgeManualAward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_manual_award", tb => tb.HasComment("Track manual award criteria for badges"));

            entity.HasIndex(e => e.Badgeid, "mdl_badgmanuawar_bad_ix");

            entity.HasIndex(e => e.Issuerrole, "mdl_badgmanuawar_iss2_ix");

            entity.HasIndex(e => e.Issuerid, "mdl_badgmanuawar_iss_ix");

            entity.HasIndex(e => e.Recipientid, "mdl_badgmanuawar_rec_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Badgeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("badgeid");
            entity.Property(e => e.Datemet)
                .HasColumnType("bigint(10)")
                .HasColumnName("datemet");
            entity.Property(e => e.Issuerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("issuerid");
            entity.Property(e => e.Issuerrole)
                .HasColumnType("bigint(10)")
                .HasColumnName("issuerrole");
            entity.Property(e => e.Recipientid)
                .HasColumnType("bigint(10)")
                .HasColumnName("recipientid");
        });

        modelBuilder.Entity<MdlBadgeRelated>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_badge_related", tb => tb.HasComment("Defines badge related for badges"));

            entity.HasIndex(e => e.Badgeid, "mdl_badgrela_bad_ix");

            entity.HasIndex(e => new { e.Badgeid, e.Relatedbadgeid }, "mdl_badgrela_badrel_uix").IsUnique();

            entity.HasIndex(e => e.Relatedbadgeid, "mdl_badgrela_rel_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Badgeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("badgeid");
            entity.Property(e => e.Relatedbadgeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("relatedbadgeid");
        });

        modelBuilder.Entity<MdlBlock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block", tb => tb.HasComment("contains all installed blocks"));

            entity.HasIndex(e => e.Name, "mdl_bloc_nam_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cron)
                .HasColumnType("bigint(10)")
                .HasColumnName("cron");
            entity.Property(e => e.Lastcron)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastcron");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlBlockFormalLang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_formal_langs", tb => tb.HasComment("An language descriptions"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Author)
                .HasColumnType("bigint(10)")
                .HasColumnName("author");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Lexemname).HasColumnName("lexemname");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Parserules).HasColumnName("parserules");
            entity.Property(e => e.Scanrules).HasColumnName("scanrules");
            entity.Property(e => e.Uiname).HasColumnName("uiname");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.Visible)
                .HasColumnType("smallint(4)")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlBlockFormalLangsDscPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_formal_langs_dsc_parts", tb => tb.HasComment("An information about autogenerated parts of symbols, that em"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Number)
                .HasColumnType("bigint(10)")
                .HasColumnName("number");
            entity.Property(e => e.Position)
                .HasColumnType("bigint(10)")
                .HasColumnName("position");
            entity.Property(e => e.Tableid)
                .HasColumnType("bigint(10)")
                .HasColumnName("tableid");
            entity.Property(e => e.Tablename).HasColumnName("tablename");
        });

        modelBuilder.Entity<MdlBlockFormalLangsNodeDscr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_formal_langs_node_dscr", tb => tb.HasComment("An information about symbols, that emerge from lexical and s"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Number)
                .HasColumnType("bigint(10)")
                .HasColumnName("number");
            entity.Property(e => e.Tableid)
                .HasColumnType("bigint(10)")
                .HasColumnName("tableid");
            entity.Property(e => e.Tablename).HasColumnName("tablename");
        });

        modelBuilder.Entity<MdlBlockFormalLangsPerm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_formal_langs_perms", tb => tb.HasComment("A permissions for courses and categories to see languages in"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Languageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("languageid");
            entity.Property(e => e.Visible).HasColumnName("visible");
        });

        modelBuilder.Entity<MdlBlockFormalLangsWordFrm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_formal_langs_word_frms", tb => tb.HasComment("A word forms for producing descriptions"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Form).HasColumnName("form");
            entity.Property(e => e.Formname).HasColumnName("formname");
            entity.Property(e => e.Language).HasColumnName("language");
            entity.Property(e => e.Originalform).HasColumnName("originalform");
        });

        modelBuilder.Entity<MdlBlockInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_instances", tb => tb.HasComment("This table stores block instances. The type of block this is"));

            entity.HasIndex(e => e.Parentcontextid, "mdl_blocinst_par_ix");

            entity.HasIndex(e => new { e.Parentcontextid, e.Showinsubcontexts, e.Pagetypepattern, e.Subpagepattern }, "mdl_blocinst_parshopagsub_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_blocinst_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Blockname)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("blockname");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Defaultregion)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("defaultregion");
            entity.Property(e => e.Defaultweight)
                .HasColumnType("bigint(10)")
                .HasColumnName("defaultweight");
            entity.Property(e => e.Pagetypepattern)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("pagetypepattern");
            entity.Property(e => e.Parentcontextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("parentcontextid");
            entity.Property(e => e.Requiredbytheme)
                .HasColumnType("smallint(4)")
                .HasColumnName("requiredbytheme");
            entity.Property(e => e.Showinsubcontexts)
                .HasColumnType("smallint(4)")
                .HasColumnName("showinsubcontexts");
            entity.Property(e => e.Subpagepattern)
                .HasMaxLength(16)
                .HasColumnName("subpagepattern");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlBlockPosition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_positions", tb => tb.HasComment("Stores the position of a sticky block_instance on a another "));

            entity.HasIndex(e => e.Blockinstanceid, "mdl_blocposi_blo_ix");

            entity.HasIndex(e => new { e.Blockinstanceid, e.Contextid, e.Pagetype, e.Subpage }, "mdl_blocposi_bloconpagsub_uix").IsUnique();

            entity.HasIndex(e => e.Contextid, "mdl_blocposi_con_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Blockinstanceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("blockinstanceid");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Pagetype)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("pagetype");
            entity.Property(e => e.Region)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("region");
            entity.Property(e => e.Subpage)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("subpage");
            entity.Property(e => e.Visible)
                .HasColumnType("smallint(4)")
                .HasColumnName("visible");
            entity.Property(e => e.Weight)
                .HasColumnType("bigint(10)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<MdlBlockRecentActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_recent_activity", tb => tb.HasComment("Recent activity block"));

            entity.HasIndex(e => new { e.Courseid, e.Timecreated }, "mdl_blocreceacti_coutim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Cmid)
                .HasColumnType("bigint(10)")
                .HasColumnName("cmid");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Modname)
                .HasMaxLength(20)
                .HasColumnName("modname");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBlockRecentlyaccesseditem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_recentlyaccesseditems", tb => tb.HasComment("Most recently accessed items accessed by a user"));

            entity.HasIndex(e => e.Cmid, "mdl_blocrece_cmi_ix");

            entity.HasIndex(e => e.Courseid, "mdl_blocrece_cou_ix");

            entity.HasIndex(e => e.Userid, "mdl_blocrece_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Courseid, e.Cmid }, "mdl_blocrece_usecoucmi_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cmid)
                .HasColumnType("bigint(10)")
                .HasColumnName("cmid");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Timeaccess)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeaccess");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBlockRssClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_rss_client", tb => tb.HasComment("Remote news feed information. Contains the news feed id, the"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Preferredtitle)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("preferredtitle");
            entity.Property(e => e.Shared)
                .HasColumnType("tinyint(2)")
                .HasColumnName("shared");
            entity.Property(e => e.Skiptime)
                .HasColumnType("bigint(10)")
                .HasColumnName("skiptime");
            entity.Property(e => e.Skipuntil)
                .HasColumnType("bigint(10)")
                .HasColumnName("skipuntil");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBlockSupervisedClassroom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_supervised_classroom", tb => tb.HasComment("Default comment"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("active");
            entity.Property(e => e.Iplist).HasColumnName("iplist");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<MdlBlockSupervisedLessontype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_supervised_lessontype", tb => tb.HasComment("Default comment"));

            entity.HasIndex(e => e.Courseid, "mdl_blocsupeless_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<MdlBlockSupervisedSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_supervised_session", tb => tb.HasComment("Session events"));

            entity.HasIndex(e => e.Classroomid, "mdl_blocsupesess_cla_ix");

            entity.HasIndex(e => e.Courseid, "mdl_blocsupesess_cou_ix");

            entity.HasIndex(e => e.Groupid, "mdl_blocsupesess_gro_ix");

            entity.HasIndex(e => e.Lessontypeid, "mdl_blocsupesess_les_ix");

            entity.HasIndex(e => e.Teacherid, "mdl_blocsupesess_tea_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Classroomid)
                .HasColumnType("bigint(10)")
                .HasColumnName("classroomid");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Duration)
                .HasColumnType("bigint(10)")
                .HasColumnName("duration");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Iplist).HasColumnName("iplist");
            entity.Property(e => e.Lessontypeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("lessontypeid");
            entity.Property(e => e.Sendemail)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("sendemail");
            entity.Property(e => e.Sessioncomment).HasColumnName("sessioncomment");
            entity.Property(e => e.State)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("state");
            entity.Property(e => e.Teacherid)
                .HasColumnType("bigint(10)")
                .HasColumnName("teacherid");
            entity.Property(e => e.Timeend)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
            entity.Property(e => e.Timestart)
                .HasColumnType("bigint(10)")
                .HasColumnName("timestart");
        });

        modelBuilder.Entity<MdlBlockSupervisedUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_block_supervised_user", tb => tb.HasComment("Users in session"));

            entity.HasIndex(e => e.Sessionid, "mdl_blocsupeuser_ses_ix");

            entity.HasIndex(e => e.Userid, "mdl_blocsupeuser_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Sessionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("sessionid");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBlogAssociation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_blog_association", tb => tb.HasComment("Associations of blog entries with courses and module instanc"));

            entity.HasIndex(e => e.Blogid, "mdl_blogasso_blo_ix");

            entity.HasIndex(e => e.Contextid, "mdl_blogasso_con_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Blogid)
                .HasColumnType("bigint(10)")
                .HasColumnName("blogid");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
        });

        modelBuilder.Entity<MdlBlogExternal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_blog_external", tb => tb.HasComment("External blog links used for RSS copying of blog entries to "));

            entity.HasIndex(e => e.Userid, "mdl_blogexte_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Failedlastsync).HasColumnName("failedlastsync");
            entity.Property(e => e.Filtertags)
                .HasMaxLength(255)
                .HasColumnName("filtertags");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timefetched)
                .HasColumnType("bigint(10)")
                .HasColumnName("timefetched");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Url).HasColumnName("url");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlBook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_book", tb => tb.HasComment("Defines book"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Customtitles)
                .HasColumnType("tinyint(2)")
                .HasColumnName("customtitles");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Navstyle)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("navstyle");
            entity.Property(e => e.Numbering)
                .HasColumnType("smallint(4)")
                .HasColumnName("numbering");
            entity.Property(e => e.Revision)
                .HasColumnType("bigint(10)")
                .HasColumnName("revision");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlBookChapter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_book_chapters", tb => tb.HasComment("Defines book_chapters"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Bookid)
                .HasColumnType("bigint(10)")
                .HasColumnName("bookid");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contentformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("contentformat");
            entity.Property(e => e.Hidden)
                .HasColumnType("tinyint(2)")
                .HasColumnName("hidden");
            entity.Property(e => e.Importsrc)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("importsrc");
            entity.Property(e => e.Pagenum)
                .HasColumnType("bigint(10)")
                .HasColumnName("pagenum");
            entity.Property(e => e.Subchapter)
                .HasColumnType("bigint(10)")
                .HasColumnName("subchapter");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<MdlCacheFilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_cache_filters", tb => tb.HasComment("For keeping information about cached data"));

            entity.HasIndex(e => new { e.Filter, e.Md5key }, "mdl_cachfilt_filmd5_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Filter)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("filter");
            entity.Property(e => e.Md5key)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("md5key");
            entity.Property(e => e.Rawtext).HasColumnName("rawtext");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Version)
                .HasColumnType("bigint(10)")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlCacheFlag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_cache_flags", tb => tb.HasComment("Cache of time-sensitive flags"));

            entity.HasIndex(e => e.Flagtype, "mdl_cachflag_fla_ix");

            entity.HasIndex(e => e.Name, "mdl_cachflag_nam_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Expiry)
                .HasColumnType("bigint(10)")
                .HasColumnName("expiry");
            entity.Property(e => e.Flagtype)
                .HasDefaultValueSql("''")
                .HasColumnName("flagtype");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlCapability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_capabilities", tb => tb.HasComment("this defines all capabilities"));

            entity.HasIndex(e => e.Name, "mdl_capa_nam_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Captype)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("captype");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextlevel)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextlevel");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Riskbitmask)
                .HasColumnType("bigint(10)")
                .HasColumnName("riskbitmask");
        });

        modelBuilder.Entity<MdlChat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_chat", tb => tb.HasComment("Each of these is a chat room"));

            entity.HasIndex(e => e.Course, "mdl_chat_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Chattime)
                .HasColumnType("bigint(10)")
                .HasColumnName("chattime");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Keepdays)
                .HasColumnType("bigint(11)")
                .HasColumnName("keepdays");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Schedule)
                .HasColumnType("smallint(4)")
                .HasColumnName("schedule");
            entity.Property(e => e.Studentlogs)
                .HasColumnType("smallint(4)")
                .HasColumnName("studentlogs");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlChatMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_chat_messages", tb => tb.HasComment("Stores all the actual chat messages"));

            entity.HasIndex(e => e.Chatid, "mdl_chatmess_cha_ix");

            entity.HasIndex(e => e.Groupid, "mdl_chatmess_gro_ix");

            entity.HasIndex(e => new { e.Timestamp, e.Chatid }, "mdl_chatmess_timcha_ix");

            entity.HasIndex(e => e.Userid, "mdl_chatmess_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Chatid)
                .HasColumnType("bigint(10)")
                .HasColumnName("chatid");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Issystem).HasColumnName("issystem");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Timestamp)
                .HasColumnType("bigint(10)")
                .HasColumnName("timestamp");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlChatMessagesCurrent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_chat_messages_current", tb => tb.HasComment("Stores current session"));

            entity.HasIndex(e => e.Chatid, "mdl_chatmesscurr_cha_ix");

            entity.HasIndex(e => e.Groupid, "mdl_chatmesscurr_gro_ix");

            entity.HasIndex(e => new { e.Timestamp, e.Chatid }, "mdl_chatmesscurr_timcha_ix");

            entity.HasIndex(e => e.Userid, "mdl_chatmesscurr_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Chatid)
                .HasColumnType("bigint(10)")
                .HasColumnName("chatid");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Issystem).HasColumnName("issystem");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Timestamp)
                .HasColumnType("bigint(10)")
                .HasColumnName("timestamp");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlChatUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_chat_users", tb => tb.HasComment("Keeps track of which users are in which chat rooms"));

            entity.HasIndex(e => e.Chatid, "mdl_chatuser_cha_ix");

            entity.HasIndex(e => e.Groupid, "mdl_chatuser_gro_ix");

            entity.HasIndex(e => e.Lastping, "mdl_chatuser_las_ix");

            entity.HasIndex(e => e.Userid, "mdl_chatuser_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Chatid)
                .HasColumnType("bigint(11)")
                .HasColumnName("chatid");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Firstping)
                .HasColumnType("bigint(10)")
                .HasColumnName("firstping");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(11)")
                .HasColumnName("groupid");
            entity.Property(e => e.Ip)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ip");
            entity.Property(e => e.Lang)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lang");
            entity.Property(e => e.Lastmessageping)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastmessageping");
            entity.Property(e => e.Lastping)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastping");
            entity.Property(e => e.Sid)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("sid");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(11)")
                .HasColumnName("userid");
            entity.Property(e => e.Version)
                .HasMaxLength(16)
                .HasDefaultValueSql("''")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlChoice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_choice", tb => tb.HasComment("Available choices are stored here"));

            entity.HasIndex(e => e.Course, "mdl_choi_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Allowmultiple)
                .HasColumnType("tinyint(2)")
                .HasColumnName("allowmultiple");
            entity.Property(e => e.Allowupdate)
                .HasColumnType("tinyint(2)")
                .HasColumnName("allowupdate");
            entity.Property(e => e.Completionsubmit).HasColumnName("completionsubmit");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Display)
                .HasColumnType("smallint(4)")
                .HasColumnName("display");
            entity.Property(e => e.Includeinactive)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("includeinactive");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Limitanswers)
                .HasColumnType("tinyint(2)")
                .HasColumnName("limitanswers");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Publish)
                .HasColumnType("tinyint(2)")
                .HasColumnName("publish");
            entity.Property(e => e.Showpreview)
                .HasColumnType("tinyint(2)")
                .HasColumnName("showpreview");
            entity.Property(e => e.Showresults)
                .HasColumnType("tinyint(2)")
                .HasColumnName("showresults");
            entity.Property(e => e.Showunanswered)
                .HasColumnType("tinyint(2)")
                .HasColumnName("showunanswered");
            entity.Property(e => e.Timeclose)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeclose");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timeopen)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeopen");
        });

        modelBuilder.Entity<MdlChoiceAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_choice_answers", tb => tb.HasComment("choices performed by users"));

            entity.HasIndex(e => e.Choiceid, "mdl_choiansw_cho_ix");

            entity.HasIndex(e => e.Optionid, "mdl_choiansw_opt_ix");

            entity.HasIndex(e => e.Userid, "mdl_choiansw_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Choiceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("choiceid");
            entity.Property(e => e.Optionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("optionid");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlChoiceOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_choice_options", tb => tb.HasComment("available options to choice"));

            entity.HasIndex(e => e.Choiceid, "mdl_choiopti_cho_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Choiceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("choiceid");
            entity.Property(e => e.Maxanswers)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("maxanswers");
            entity.Property(e => e.Text).HasColumnName("text");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlCohort>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_cohort", tb => tb.HasComment("Each record represents one cohort (aka site-wide group)."));

            entity.HasIndex(e => e.Contextid, "mdl_coho_con_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Name)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .HasColumnName("theme");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlCohortMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_cohort_members", tb => tb.HasComment("Link a user to a cohort."));

            entity.HasIndex(e => e.Cohortid, "mdl_cohomemb_coh_ix");

            entity.HasIndex(e => new { e.Cohortid, e.Userid }, "mdl_cohomemb_cohuse_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_cohomemb_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cohortid)
                .HasColumnType("bigint(10)")
                .HasColumnName("cohortid");
            entity.Property(e => e.Timeadded)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeadded");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_comments", tb => tb.HasComment("moodle comments module"));

            entity.HasIndex(e => new { e.Contextid, e.Commentarea, e.Itemid }, "mdl_comm_concomite_ix");

            entity.HasIndex(e => e.Userid, "mdl_comm_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Commentarea)
                .HasDefaultValueSql("''")
                .HasColumnName("commentarea");
            entity.Property(e => e.Component)
                .HasMaxLength(255)
                .HasColumnName("component");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Format)
                .HasColumnType("tinyint(2)")
                .HasColumnName("format");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlCompetency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency", tb => tb.HasComment("This table contains the master record of each competency in "));

            entity.HasIndex(e => new { e.Competencyframeworkid, e.Idnumber }, "mdl_comp_comidn_uix").IsUnique();

            entity.HasIndex(e => e.Ruleoutcome, "mdl_comp_rul_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Competencyframeworkid)
                .HasColumnType("bigint(10)")
                .HasColumnName("competencyframeworkid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Parentid)
                .HasColumnType("bigint(10)")
                .HasColumnName("parentid");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("path");
            entity.Property(e => e.Ruleconfig).HasColumnName("ruleconfig");
            entity.Property(e => e.Ruleoutcome)
                .HasColumnType("tinyint(2)")
                .HasColumnName("ruleoutcome");
            entity.Property(e => e.Ruletype)
                .HasMaxLength(100)
                .HasColumnName("ruletype");
            entity.Property(e => e.Scaleconfiguration).HasColumnName("scaleconfiguration");
            entity.Property(e => e.Scaleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scaleid");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyCoursecomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_coursecomp", tb => tb.HasComment("Link a competency to a course."));

            entity.HasIndex(e => e.Competencyid, "mdl_compcour_com_ix");

            entity.HasIndex(e => e.Courseid, "mdl_compcour_cou2_ix");

            entity.HasIndex(e => new { e.Courseid, e.Competencyid }, "mdl_compcour_coucom_uix").IsUnique();

            entity.HasIndex(e => new { e.Courseid, e.Ruleoutcome }, "mdl_compcour_courul_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Competencyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("competencyid");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Ruleoutcome)
                .HasColumnType("tinyint(2)")
                .HasColumnName("ruleoutcome");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyCoursecompsetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_coursecompsetting", tb => tb.HasComment("This table contains the course specific settings for compete"));

            entity.HasIndex(e => e.Courseid, "mdl_compcour_cou_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Pushratingstouserplans)
                .HasColumnType("tinyint(2)")
                .HasColumnName("pushratingstouserplans");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyEvidence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_evidence", tb => tb.HasComment("The evidence linked to a user competency"));

            entity.HasIndex(e => e.Usercompetencyid, "mdl_compevid_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasColumnType("tinyint(2)")
                .HasColumnName("action");
            entity.Property(e => e.Actionuserid)
                .HasColumnType("bigint(10)")
                .HasColumnName("actionuserid");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Desca).HasColumnName("desca");
            entity.Property(e => e.Desccomponent)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("desccomponent");
            entity.Property(e => e.Descidentifier)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("descidentifier");
            entity.Property(e => e.Grade)
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasColumnName("url");
            entity.Property(e => e.Usercompetencyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("usercompetencyid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyFramework>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_framework", tb => tb.HasComment("List of competency frameworks."));

            entity.HasIndex(e => e.Idnumber, "mdl_compfram_idn_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Scaleconfiguration).HasColumnName("scaleconfiguration");
            entity.Property(e => e.Scaleid)
                .HasColumnType("bigint(11)")
                .HasColumnName("scaleid");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasColumnName("shortname");
            entity.Property(e => e.Taxonomies)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("taxonomies");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlCompetencyModulecomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_modulecomp", tb => tb.HasComment("Link a competency to a module."));

            entity.HasIndex(e => e.Cmid, "mdl_compmodu_cmi_ix");

            entity.HasIndex(e => new { e.Cmid, e.Competencyid }, "mdl_compmodu_cmicom_uix").IsUnique();

            entity.HasIndex(e => new { e.Cmid, e.Ruleoutcome }, "mdl_compmodu_cmirul_ix");

            entity.HasIndex(e => e.Competencyid, "mdl_compmodu_com_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cmid)
                .HasColumnType("bigint(10)")
                .HasColumnName("cmid");
            entity.Property(e => e.Competencyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("competencyid");
            entity.Property(e => e.Ruleoutcome)
                .HasColumnType("tinyint(2)")
                .HasColumnName("ruleoutcome");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_plan", tb => tb.HasComment("Learning plans"));

            entity.HasIndex(e => new { e.Status, e.Duedate }, "mdl_compplan_stadue_ix");

            entity.HasIndex(e => e.Templateid, "mdl_compplan_tem_ix");

            entity.HasIndex(e => new { e.Userid, e.Status }, "mdl_compplan_usesta_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Duedate)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("duedate");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Origtemplateid)
                .HasColumnType("bigint(10)")
                .HasColumnName("origtemplateid");
            entity.Property(e => e.Reviewerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("reviewerid");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Templateid)
                .HasColumnType("bigint(10)")
                .HasColumnName("templateid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyPlancomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_plancomp", tb => tb.HasComment("Plan competencies"));

            entity.HasIndex(e => new { e.Planid, e.Competencyid }, "mdl_compplan_placom_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Competencyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("competencyid");
            entity.Property(e => e.Planid)
                .HasColumnType("bigint(10)")
                .HasColumnName("planid");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyRelatedcomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_relatedcomp", tb => tb.HasComment("Related competencies"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Competencyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("competencyid");
            entity.Property(e => e.Relatedcompetencyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("relatedcompetencyid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_template", tb => tb.HasComment("Learning plan templates."));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Duedate)
                .HasColumnType("bigint(10)")
                .HasColumnName("duedate");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasColumnName("shortname");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlCompetencyTemplatecohort>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_templatecohort", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.HasIndex(e => e.Templateid, "mdl_comptemp_tem2_ix");

            entity.HasIndex(e => new { e.Templateid, e.Cohortid }, "mdl_comptemp_temcoh_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cohortid)
                .HasColumnType("bigint(10)")
                .HasColumnName("cohortid");
            entity.Property(e => e.Templateid)
                .HasColumnType("bigint(10)")
                .HasColumnName("templateid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyTemplatecomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_templatecomp", tb => tb.HasComment("Link a competency to a learning plan template."));

            entity.HasIndex(e => e.Competencyid, "mdl_comptemp_com_ix");

            entity.HasIndex(e => e.Templateid, "mdl_comptemp_tem_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Competencyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("competencyid");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Templateid)
                .HasColumnType("bigint(10)")
                .HasColumnName("templateid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyUsercomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_usercomp", tb => tb.HasComment("User competencies"));

            entity.HasIndex(e => new { e.Userid, e.Competencyid }, "mdl_compuser_usecom_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Competencyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("competencyid");
            entity.Property(e => e.Grade)
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Proficiency)
                .HasColumnType("tinyint(2)")
                .HasColumnName("proficiency");
            entity.Property(e => e.Reviewerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("reviewerid");
            entity.Property(e => e.Status)
                .HasColumnType("tinyint(2)")
                .HasColumnName("status");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyUsercompcourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_usercompcourse", tb => tb.HasComment("User competencies in a course"));

            entity.HasIndex(e => new { e.Userid, e.Courseid, e.Competencyid }, "mdl_compuser_usecoucom_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Competencyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("competencyid");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Grade)
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Proficiency)
                .HasColumnType("tinyint(2)")
                .HasColumnName("proficiency");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyUsercompplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_usercompplan", tb => tb.HasComment("User competencies plans"));

            entity.HasIndex(e => new { e.Userid, e.Competencyid, e.Planid }, "mdl_compuser_usecompla_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Competencyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("competencyid");
            entity.Property(e => e.Grade)
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Planid)
                .HasColumnType("bigint(10)")
                .HasColumnName("planid");
            entity.Property(e => e.Proficiency)
                .HasColumnType("tinyint(2)")
                .HasColumnName("proficiency");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyUserevidence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_userevidence", tb => tb.HasComment("The evidence of prior learning"));

            entity.HasIndex(e => e.Userid, "mdl_compuser_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Url).HasColumnName("url");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlCompetencyUserevidencecomp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_competency_userevidencecomp", tb => tb.HasComment("Relationship between user evidence and competencies"));

            entity.HasIndex(e => e.Userevidenceid, "mdl_compuser_use2_ix");

            entity.HasIndex(e => new { e.Userevidenceid, e.Competencyid }, "mdl_compuser_usecom2_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Competencyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("competencyid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userevidenceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userevidenceid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_config", tb => tb.HasComment("Moodle configuration variables"));

            entity.HasIndex(e => e.Name, "mdl_conf_nam_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlConfigLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_config_log", tb => tb.HasComment("Changes done in server configuration through admin UI"));

            entity.HasIndex(e => e.Timemodified, "mdl_conflog_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_conflog_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Oldvalue).HasColumnName("oldvalue");
            entity.Property(e => e.Plugin)
                .HasMaxLength(100)
                .HasColumnName("plugin");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlConfigPlugin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_config_plugins", tb => tb.HasComment("Moodle modules and plugins configuration variables"));

            entity.HasIndex(e => new { e.Plugin, e.Name }, "mdl_confplug_plunam_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Plugin)
                .HasMaxLength(100)
                .HasDefaultValueSql("'core'")
                .HasColumnName("plugin");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlContentbankContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_contentbank_content", tb => tb.HasComment("This table stores content data in the content bank."));

            entity.HasIndex(e => e.Contextid, "mdl_contcont_con_ix");

            entity.HasIndex(e => new { e.Contextid, e.Contenttype, e.Instanceid }, "mdl_contcont_conconins_ix");

            entity.HasIndex(e => e.Name, "mdl_contcont_nam_ix");

            entity.HasIndex(e => e.Usercreated, "mdl_contcont_use2_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_contcont_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Contenttype)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("contenttype");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Instanceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("instanceid");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usercreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("usercreated");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlContext>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_context", tb => tb.HasComment("one of these must be set"));

            entity.HasIndex(e => new { e.Contextlevel, e.Instanceid }, "mdl_cont_conins_uix").IsUnique();

            entity.HasIndex(e => e.Instanceid, "mdl_cont_ins_ix");

            entity.HasIndex(e => e.Path, "mdl_cont_pat_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextlevel)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextlevel");
            entity.Property(e => e.Depth)
                .HasColumnType("tinyint(2)")
                .HasColumnName("depth");
            entity.Property(e => e.Instanceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("instanceid");
            entity.Property(e => e.Locked)
                .HasColumnType("tinyint(2)")
                .HasColumnName("locked");
            entity.Property(e => e.Path).HasColumnName("path");
        });

        modelBuilder.Entity<MdlContextTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_context_temp", tb => tb.HasComment("Used by build_context_path() in upgrade and cron to keep con"));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Depth)
                .HasColumnType("tinyint(2)")
                .HasColumnName("depth");
            entity.Property(e => e.Locked)
                .HasColumnType("tinyint(2)")
                .HasColumnName("locked");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("path");
        });

        modelBuilder.Entity<MdlCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course", tb => tb.HasComment("Central course table"));

            entity.HasIndex(e => e.Category, "mdl_cour_cat_ix");

            entity.HasIndex(e => e.Idnumber, "mdl_cour_idn_ix");

            entity.HasIndex(e => e.Shortname, "mdl_cour_sho_ix");

            entity.HasIndex(e => e.Sortorder, "mdl_cour_sor_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cacherev)
                .HasColumnType("bigint(10)")
                .HasColumnName("cacherev");
            entity.Property(e => e.Calendartype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("calendartype");
            entity.Property(e => e.Category)
                .HasColumnType("bigint(10)")
                .HasColumnName("category");
            entity.Property(e => e.Completionnotify).HasColumnName("completionnotify");
            entity.Property(e => e.Defaultgroupingid)
                .HasColumnType("bigint(10)")
                .HasColumnName("defaultgroupingid");
            entity.Property(e => e.Enablecompletion).HasColumnName("enablecompletion");
            entity.Property(e => e.Enddate)
                .HasColumnType("bigint(10)")
                .HasColumnName("enddate");
            entity.Property(e => e.Format)
                .HasMaxLength(21)
                .HasDefaultValueSql("'topics'")
                .HasColumnName("format");
            entity.Property(e => e.Fullname)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Groupmode)
                .HasColumnType("smallint(4)")
                .HasColumnName("groupmode");
            entity.Property(e => e.Groupmodeforce)
                .HasColumnType("smallint(4)")
                .HasColumnName("groupmodeforce");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("idnumber");
            entity.Property(e => e.Lang)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lang");
            entity.Property(e => e.Legacyfiles)
                .HasColumnType("smallint(4)")
                .HasColumnName("legacyfiles");
            entity.Property(e => e.Marker)
                .HasColumnType("bigint(10)")
                .HasColumnName("marker");
            entity.Property(e => e.Maxbytes)
                .HasColumnType("bigint(10)")
                .HasColumnName("maxbytes");
            entity.Property(e => e.Newsitems)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint(5)")
                .HasColumnName("newsitems");
            entity.Property(e => e.Relativedatesmode).HasColumnName("relativedatesmode");
            entity.Property(e => e.Requested).HasColumnName("requested");
            entity.Property(e => e.Shortname)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Showgrades)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("showgrades");
            entity.Property(e => e.Showreports)
                .HasColumnType("smallint(4)")
                .HasColumnName("showreports");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Startdate)
                .HasColumnType("bigint(10)")
                .HasColumnName("startdate");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("summaryformat");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("theme");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
            entity.Property(e => e.Visibleold)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visibleold");
        });

        modelBuilder.Entity<MdlCourseCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_categories", tb => tb.HasComment("Course categories"));

            entity.HasIndex(e => e.Parent, "mdl_courcate_par_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Coursecount)
                .HasColumnType("bigint(10)")
                .HasColumnName("coursecount");
            entity.Property(e => e.Depth)
                .HasColumnType("bigint(10)")
                .HasColumnName("depth");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Parent)
                .HasColumnType("bigint(10)")
                .HasColumnName("parent");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("path");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .HasColumnName("theme");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
            entity.Property(e => e.Visibleold)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visibleold");
        });

        modelBuilder.Entity<MdlCourseCompletion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_completions", tb => tb.HasComment("Course completion records"));

            entity.HasIndex(e => e.Course, "mdl_courcomp_cou_ix");

            entity.HasIndex(e => e.Timecompleted, "mdl_courcomp_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_courcomp_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Course }, "mdl_courcomp_usecou_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Reaggregate)
                .HasColumnType("bigint(10)")
                .HasColumnName("reaggregate");
            entity.Property(e => e.Timecompleted)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecompleted");
            entity.Property(e => e.Timeenrolled)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeenrolled");
            entity.Property(e => e.Timestarted)
                .HasColumnType("bigint(10)")
                .HasColumnName("timestarted");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlCourseCompletionAggrMethd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_completion_aggr_methd", tb => tb.HasComment("Course completion aggregation methods for criteria"));

            entity.HasIndex(e => e.Course, "mdl_courcompaggrmeth_cou_ix");

            entity.HasIndex(e => new { e.Course, e.Criteriatype }, "mdl_courcompaggrmeth_coucr_uix").IsUnique();

            entity.HasIndex(e => e.Criteriatype, "mdl_courcompaggrmeth_cri_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Criteriatype)
                .HasColumnType("bigint(10)")
                .HasColumnName("criteriatype");
            entity.Property(e => e.Method).HasColumnName("method");
            entity.Property(e => e.Value)
                .HasPrecision(10, 5)
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlCourseCompletionCritCompl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_completion_crit_compl", tb => tb.HasComment("Course completion user records"));

            entity.HasIndex(e => e.Course, "mdl_courcompcritcomp_cou_ix");

            entity.HasIndex(e => e.Criteriaid, "mdl_courcompcritcomp_cri_ix");

            entity.HasIndex(e => e.Timecompleted, "mdl_courcompcritcomp_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_courcompcritcomp_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Course, e.Criteriaid }, "mdl_courcompcritcomp_useco_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Criteriaid)
                .HasColumnType("bigint(10)")
                .HasColumnName("criteriaid");
            entity.Property(e => e.Gradefinal)
                .HasPrecision(10, 5)
                .HasColumnName("gradefinal");
            entity.Property(e => e.Timecompleted)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecompleted");
            entity.Property(e => e.Unenroled)
                .HasColumnType("bigint(10)")
                .HasColumnName("unenroled");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlCourseCompletionCriterion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_completion_criteria", tb => tb.HasComment("Course completion criteria"));

            entity.HasIndex(e => e.Course, "mdl_courcompcrit_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Courseinstance)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseinstance");
            entity.Property(e => e.Criteriatype)
                .HasColumnType("bigint(10)")
                .HasColumnName("criteriatype");
            entity.Property(e => e.Enrolperiod)
                .HasColumnType("bigint(10)")
                .HasColumnName("enrolperiod");
            entity.Property(e => e.Gradepass)
                .HasPrecision(10, 5)
                .HasColumnName("gradepass");
            entity.Property(e => e.Module)
                .HasMaxLength(100)
                .HasColumnName("module");
            entity.Property(e => e.Moduleinstance)
                .HasColumnType("bigint(10)")
                .HasColumnName("moduleinstance");
            entity.Property(e => e.Role)
                .HasColumnType("bigint(10)")
                .HasColumnName("role");
            entity.Property(e => e.Timeend)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
        });

        modelBuilder.Entity<MdlCourseCompletionDefault>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_completion_defaults", tb => tb.HasComment("Default settings for activities completion"));

            entity.HasIndex(e => e.Course, "mdl_courcompdefa_cou_ix");

            entity.HasIndex(e => new { e.Course, e.Module }, "mdl_courcompdefa_coumod_uix").IsUnique();

            entity.HasIndex(e => e.Module, "mdl_courcompdefa_mod_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Completion).HasColumnName("completion");
            entity.Property(e => e.Completionexpected)
                .HasColumnType("bigint(10)")
                .HasColumnName("completionexpected");
            entity.Property(e => e.Completionusegrade).HasColumnName("completionusegrade");
            entity.Property(e => e.Completionview).HasColumnName("completionview");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Customrules).HasColumnName("customrules");
            entity.Property(e => e.Module)
                .HasColumnType("bigint(10)")
                .HasColumnName("module");
        });

        modelBuilder.Entity<MdlCourseFormatOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_format_options", tb => tb.HasComment("Stores format-specific options for the course or course sect"));

            entity.HasIndex(e => e.Courseid, "mdl_courformopti_cou_ix");

            entity.HasIndex(e => new { e.Courseid, e.Format, e.Sectionid, e.Name }, "mdl_courformopti_couforsec_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Format)
                .HasMaxLength(21)
                .HasDefaultValueSql("''")
                .HasColumnName("format");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Sectionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("sectionid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlCourseModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_modules", tb => tb.HasComment("course_modules table retrofitted from MySQL"));

            entity.HasIndex(e => e.Course, "mdl_courmodu_cou_ix");

            entity.HasIndex(e => e.Groupingid, "mdl_courmodu_gro_ix");

            entity.HasIndex(e => new { e.Idnumber, e.Course }, "mdl_courmodu_idncou_ix");

            entity.HasIndex(e => e.Instance, "mdl_courmodu_ins_ix");

            entity.HasIndex(e => e.Module, "mdl_courmodu_mod_ix");

            entity.HasIndex(e => e.Visible, "mdl_courmodu_vis_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Added)
                .HasColumnType("bigint(10)")
                .HasColumnName("added");
            entity.Property(e => e.Availability).HasColumnName("availability");
            entity.Property(e => e.Completion).HasColumnName("completion");
            entity.Property(e => e.Completionexpected)
                .HasColumnType("bigint(10)")
                .HasColumnName("completionexpected");
            entity.Property(e => e.Completiongradeitemnumber)
                .HasColumnType("bigint(10)")
                .HasColumnName("completiongradeitemnumber");
            entity.Property(e => e.Completionview).HasColumnName("completionview");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Deletioninprogress).HasColumnName("deletioninprogress");
            entity.Property(e => e.Groupingid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupingid");
            entity.Property(e => e.Groupmode)
                .HasColumnType("smallint(4)")
                .HasColumnName("groupmode");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Indent)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(5)")
                .HasColumnName("indent");
            entity.Property(e => e.Instance)
                .HasColumnType("bigint(10)")
                .HasColumnName("instance");
            entity.Property(e => e.Module)
                .HasColumnType("bigint(10)")
                .HasColumnName("module");
            entity.Property(e => e.Score)
                .HasColumnType("smallint(4)")
                .HasColumnName("score");
            entity.Property(e => e.Section)
                .HasColumnType("bigint(10)")
                .HasColumnName("section");
            entity.Property(e => e.Showdescription).HasColumnName("showdescription");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
            entity.Property(e => e.Visibleold)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visibleold");
            entity.Property(e => e.Visibleoncoursepage)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visibleoncoursepage");
        });

        modelBuilder.Entity<MdlCourseModulesCompletion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_modules_completion", tb => tb.HasComment("Stores the completion state (completed or not completed, etc"));

            entity.HasIndex(e => e.Coursemoduleid, "mdl_courmoducomp_cou_ix");

            entity.HasIndex(e => new { e.Userid, e.Coursemoduleid }, "mdl_courmoducomp_usecou_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Completionstate).HasColumnName("completionstate");
            entity.Property(e => e.Coursemoduleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("coursemoduleid");
            entity.Property(e => e.Overrideby)
                .HasColumnType("bigint(10)")
                .HasColumnName("overrideby");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Viewed).HasColumnName("viewed");
        });

        modelBuilder.Entity<MdlCoursePublished>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_published", tb => tb.HasComment("Information about how and when an local courses were publish"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Enrollable)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enrollable");
            entity.Property(e => e.Hubcourseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("hubcourseid");
            entity.Property(e => e.Huburl)
                .HasMaxLength(255)
                .HasColumnName("huburl");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnName("status");
            entity.Property(e => e.Timechecked)
                .HasColumnType("bigint(10)")
                .HasColumnName("timechecked");
            entity.Property(e => e.Timepublished)
                .HasColumnType("bigint(10)")
                .HasColumnName("timepublished");
        });

        modelBuilder.Entity<MdlCourseRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_request", tb => tb.HasComment("course requests"));

            entity.HasIndex(e => e.Shortname, "mdl_courrequ_sho_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasColumnType("bigint(10)")
                .HasColumnName("category");
            entity.Property(e => e.Fullname)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
            entity.Property(e => e.Reason).HasColumnName("reason");
            entity.Property(e => e.Requester)
                .HasColumnType("bigint(10)")
                .HasColumnName("requester");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("summaryformat");
        });

        modelBuilder.Entity<MdlCourseSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_course_sections", tb => tb.HasComment("to define the sections for each course"));

            entity.HasIndex(e => new { e.Course, e.Section }, "mdl_coursect_cousec_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Availability).HasColumnName("availability");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Section)
                .HasColumnType("bigint(10)")
                .HasColumnName("section");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("summaryformat");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlCustomfieldCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_customfield_category", tb => tb.HasComment("core_customfield category table"));

            entity.HasIndex(e => new { e.Component, e.Area, e.Itemid, e.Sortorder }, "mdl_custcate_comareitesor_ix");

            entity.HasIndex(e => e.Contextid, "mdl_custcate_con_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("area");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("bigint(10)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlCustomfieldDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_customfield_data", tb => tb.HasComment("core_customfield data table"));

            entity.HasIndex(e => e.Contextid, "mdl_custdata_con_ix");

            entity.HasIndex(e => e.Fieldid, "mdl_custdata_fie_ix");

            entity.HasIndex(e => new { e.Fieldid, e.Decvalue }, "mdl_custdata_fiedec_ix");

            entity.HasIndex(e => new { e.Fieldid, e.Intvalue }, "mdl_custdata_fieint_ix");

            entity.HasIndex(e => new { e.Fieldid, e.Shortcharvalue }, "mdl_custdata_fiesho_ix");

            entity.HasIndex(e => new { e.Instanceid, e.Fieldid }, "mdl_custdata_insfie_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Charvalue)
                .HasMaxLength(1333)
                .HasColumnName("charvalue");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Decvalue)
                .HasPrecision(10, 5)
                .HasColumnName("decvalue");
            entity.Property(e => e.Fieldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("fieldid");
            entity.Property(e => e.Instanceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("instanceid");
            entity.Property(e => e.Intvalue)
                .HasColumnType("bigint(10)")
                .HasColumnName("intvalue");
            entity.Property(e => e.Shortcharvalue).HasColumnName("shortcharvalue");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.Valueformat)
                .HasColumnType("bigint(10)")
                .HasColumnName("valueformat");
        });

        modelBuilder.Entity<MdlCustomfieldField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_customfield_field", tb => tb.HasComment("core_customfield field table"));

            entity.HasIndex(e => e.Categoryid, "mdl_custfiel_cat_ix");

            entity.HasIndex(e => new { e.Categoryid, e.Sortorder }, "mdl_custfiel_catsor_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Categoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("categoryid");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("bigint(10)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Name)
                .HasMaxLength(400)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlDataContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_data_content", tb => tb.HasComment("the content introduced in each record/fields"));

            entity.HasIndex(e => e.Fieldid, "mdl_datacont_fie_ix");

            entity.HasIndex(e => e.Recordid, "mdl_datacont_rec_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Content1).HasColumnName("content1");
            entity.Property(e => e.Content2).HasColumnName("content2");
            entity.Property(e => e.Content3).HasColumnName("content3");
            entity.Property(e => e.Content4).HasColumnName("content4");
            entity.Property(e => e.Fieldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("fieldid");
            entity.Property(e => e.Recordid)
                .HasColumnType("bigint(10)")
                .HasColumnName("recordid");
        });

        modelBuilder.Entity<MdlDataField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_data_fields", tb => tb.HasComment("every field available"));

            entity.HasIndex(e => e.Dataid, "mdl_datafiel_dat_ix");

            entity.HasIndex(e => new { e.Type, e.Dataid }, "mdl_datafiel_typdat_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Dataid)
                .HasColumnType("bigint(10)")
                .HasColumnName("dataid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Param1).HasColumnName("param1");
            entity.Property(e => e.Param10).HasColumnName("param10");
            entity.Property(e => e.Param2).HasColumnName("param2");
            entity.Property(e => e.Param3).HasColumnName("param3");
            entity.Property(e => e.Param4).HasColumnName("param4");
            entity.Property(e => e.Param5).HasColumnName("param5");
            entity.Property(e => e.Param6).HasColumnName("param6");
            entity.Property(e => e.Param7).HasColumnName("param7");
            entity.Property(e => e.Param8).HasColumnName("param8");
            entity.Property(e => e.Param9).HasColumnName("param9");
            entity.Property(e => e.Required).HasColumnName("required");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlDataRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_data_records", tb => tb.HasComment("every record introduced"));

            entity.HasIndex(e => e.Dataid, "mdl_datareco_dat_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Approved)
                .HasColumnType("smallint(4)")
                .HasColumnName("approved");
            entity.Property(e => e.Dataid)
                .HasColumnType("bigint(10)")
                .HasColumnName("dataid");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_data", tb => tb.HasComment("all database activities"));

            entity.HasIndex(e => e.Course, "mdl_data_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Addtemplate).HasColumnName("addtemplate");
            entity.Property(e => e.Approval)
                .HasColumnType("smallint(4)")
                .HasColumnName("approval");
            entity.Property(e => e.Asearchtemplate).HasColumnName("asearchtemplate");
            entity.Property(e => e.Assessed)
                .HasColumnType("bigint(10)")
                .HasColumnName("assessed");
            entity.Property(e => e.Assesstimefinish)
                .HasColumnType("bigint(10)")
                .HasColumnName("assesstimefinish");
            entity.Property(e => e.Assesstimestart)
                .HasColumnType("bigint(10)")
                .HasColumnName("assesstimestart");
            entity.Property(e => e.Comments)
                .HasColumnType("smallint(4)")
                .HasColumnName("comments");
            entity.Property(e => e.Completionentries)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("completionentries");
            entity.Property(e => e.Config).HasColumnName("config");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Csstemplate).HasColumnName("csstemplate");
            entity.Property(e => e.Defaultsort)
                .HasColumnType("bigint(10)")
                .HasColumnName("defaultsort");
            entity.Property(e => e.Defaultsortdir)
                .HasColumnType("smallint(4)")
                .HasColumnName("defaultsortdir");
            entity.Property(e => e.Editany)
                .HasColumnType("smallint(4)")
                .HasColumnName("editany");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Jstemplate).HasColumnName("jstemplate");
            entity.Property(e => e.Listtemplate).HasColumnName("listtemplate");
            entity.Property(e => e.Listtemplatefooter).HasColumnName("listtemplatefooter");
            entity.Property(e => e.Listtemplateheader).HasColumnName("listtemplateheader");
            entity.Property(e => e.Manageapproved)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("manageapproved");
            entity.Property(e => e.Maxentries)
                .HasColumnType("int(8)")
                .HasColumnName("maxentries");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Notification)
                .HasColumnType("bigint(10)")
                .HasColumnName("notification");
            entity.Property(e => e.Requiredentries)
                .HasColumnType("int(8)")
                .HasColumnName("requiredentries");
            entity.Property(e => e.Requiredentriestoview)
                .HasColumnType("int(8)")
                .HasColumnName("requiredentriestoview");
            entity.Property(e => e.Rssarticles)
                .HasColumnType("smallint(4)")
                .HasColumnName("rssarticles");
            entity.Property(e => e.Rsstemplate).HasColumnName("rsstemplate");
            entity.Property(e => e.Rsstitletemplate).HasColumnName("rsstitletemplate");
            entity.Property(e => e.Scale)
                .HasColumnType("bigint(10)")
                .HasColumnName("scale");
            entity.Property(e => e.Singletemplate).HasColumnName("singletemplate");
            entity.Property(e => e.Timeavailablefrom)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeavailablefrom");
            entity.Property(e => e.Timeavailableto)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeavailableto");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timeviewfrom)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeviewfrom");
            entity.Property(e => e.Timeviewto)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeviewto");
        });

        modelBuilder.Entity<MdlEditorAttoAutosave>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_editor_atto_autosave", tb => tb.HasComment("Draft text that is auto-saved every 5 seconds while an edito"));

            entity.HasIndex(e => new { e.Elementid, e.Contextid, e.Userid, e.Pagehash }, "mdl_editattoauto_eleconuse_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Draftid)
                .HasColumnType("bigint(10)")
                .HasColumnName("draftid");
            entity.Property(e => e.Drafttext).HasColumnName("drafttext");
            entity.Property(e => e.Elementid)
                .HasDefaultValueSql("''")
                .HasColumnName("elementid");
            entity.Property(e => e.Pagehash)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("pagehash");
            entity.Property(e => e.Pageinstance)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("pageinstance");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEnrol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol", tb => tb.HasComment("Instances of enrolment plugins used in courses, fields marke"));

            entity.HasIndex(e => e.Courseid, "mdl_enro_cou_ix");

            entity.HasIndex(e => e.Enrol, "mdl_enro_enr_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cost)
                .HasMaxLength(20)
                .HasColumnName("cost");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .HasColumnName("currency");
            entity.Property(e => e.Customchar1)
                .HasMaxLength(255)
                .HasColumnName("customchar1");
            entity.Property(e => e.Customchar2)
                .HasMaxLength(255)
                .HasColumnName("customchar2");
            entity.Property(e => e.Customchar3)
                .HasMaxLength(1333)
                .HasColumnName("customchar3");
            entity.Property(e => e.Customdec1)
                .HasPrecision(12, 7)
                .HasColumnName("customdec1");
            entity.Property(e => e.Customdec2)
                .HasPrecision(12, 7)
                .HasColumnName("customdec2");
            entity.Property(e => e.Customint1)
                .HasColumnType("bigint(10)")
                .HasColumnName("customint1");
            entity.Property(e => e.Customint2)
                .HasColumnType("bigint(10)")
                .HasColumnName("customint2");
            entity.Property(e => e.Customint3)
                .HasColumnType("bigint(10)")
                .HasColumnName("customint3");
            entity.Property(e => e.Customint4)
                .HasColumnType("bigint(10)")
                .HasColumnName("customint4");
            entity.Property(e => e.Customint5)
                .HasColumnType("bigint(10)")
                .HasColumnName("customint5");
            entity.Property(e => e.Customint6)
                .HasColumnType("bigint(10)")
                .HasColumnName("customint6");
            entity.Property(e => e.Customint7)
                .HasColumnType("bigint(10)")
                .HasColumnName("customint7");
            entity.Property(e => e.Customint8)
                .HasColumnType("bigint(10)")
                .HasColumnName("customint8");
            entity.Property(e => e.Customtext1).HasColumnName("customtext1");
            entity.Property(e => e.Customtext2).HasColumnName("customtext2");
            entity.Property(e => e.Customtext3).HasColumnName("customtext3");
            entity.Property(e => e.Customtext4).HasColumnName("customtext4");
            entity.Property(e => e.Enrol)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("enrol");
            entity.Property(e => e.Enrolenddate)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("enrolenddate");
            entity.Property(e => e.Enrolperiod)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("enrolperiod");
            entity.Property(e => e.Enrolstartdate)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("enrolstartdate");
            entity.Property(e => e.Expirynotify)
                .HasDefaultValueSql("'0'")
                .HasColumnName("expirynotify");
            entity.Property(e => e.Expirythreshold)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("expirythreshold");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Notifyall)
                .HasDefaultValueSql("'0'")
                .HasColumnName("notifyall");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Roleid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Status)
                .HasColumnType("bigint(10)")
                .HasColumnName("status");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlEnrolFlatfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_flatfile", tb => tb.HasComment("enrol_flatfile table retrofitted from MySQL"));

            entity.HasIndex(e => e.Courseid, "mdl_enroflat_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_enroflat_rol_ix");

            entity.HasIndex(e => e.Userid, "mdl_enroflat_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Timeend)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timestart)
                .HasColumnType("bigint(10)")
                .HasColumnName("timestart");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2Consumer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_lti_lti2_consumer", tb => tb.HasComment("LTI consumers interacting with moodle"));

            entity.HasIndex(e => e.Consumerkey256, "mdl_enroltilti2cons_con_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(11)")
                .HasColumnName("id");
            entity.Property(e => e.Consumerguid)
                .HasMaxLength(1024)
                .HasColumnName("consumerguid");
            entity.Property(e => e.Consumerkey).HasColumnName("consumerkey");
            entity.Property(e => e.Consumerkey256)
                .HasDefaultValueSql("''")
                .HasColumnName("consumerkey256");
            entity.Property(e => e.Consumername)
                .HasMaxLength(255)
                .HasColumnName("consumername");
            entity.Property(e => e.Consumerversion)
                .HasMaxLength(255)
                .HasColumnName("consumerversion");
            entity.Property(e => e.Created)
                .HasColumnType("bigint(10)")
                .HasColumnName("created");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Enablefrom)
                .HasColumnType("bigint(10)")
                .HasColumnName("enablefrom");
            entity.Property(e => e.Enableuntil)
                .HasColumnType("bigint(10)")
                .HasColumnName("enableuntil");
            entity.Property(e => e.Lastaccess)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastaccess");
            entity.Property(e => e.Ltiversion)
                .HasMaxLength(10)
                .HasColumnName("ltiversion");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Profile).HasColumnName("profile");
            entity.Property(e => e.Protected).HasColumnName("protected");
            entity.Property(e => e.Secret)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''")
                .HasColumnName("secret");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.Toolproxy).HasColumnName("toolproxy");
            entity.Property(e => e.Updated)
                .HasColumnType("bigint(10)")
                .HasColumnName("updated");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2Context>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_lti_lti2_context", tb => tb.HasComment("Information about a specific LTI contexts from the consumers"));

            entity.HasIndex(e => e.Consumerid, "mdl_enroltilti2cont_con_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(11)")
                .HasColumnName("id");
            entity.Property(e => e.Consumerid)
                .HasColumnType("bigint(11)")
                .HasColumnName("consumerid");
            entity.Property(e => e.Created)
                .HasColumnType("bigint(10)")
                .HasColumnName("created");
            entity.Property(e => e.Lticontextkey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("lticontextkey");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .HasColumnName("type");
            entity.Property(e => e.Updated)
                .HasColumnType("bigint(10)")
                .HasColumnName("updated");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2Nonce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_lti_lti2_nonce", tb => tb.HasComment("Nonce used for authentication between moodle and a consumer"));

            entity.HasIndex(e => e.Consumerid, "mdl_enroltilti2nonc_con_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(11)")
                .HasColumnName("id");
            entity.Property(e => e.Consumerid)
                .HasColumnType("bigint(11)")
                .HasColumnName("consumerid");
            entity.Property(e => e.Expires)
                .HasColumnType("bigint(10)")
                .HasColumnName("expires");
            entity.Property(e => e.Value)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2ResourceLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_lti_lti2_resource_link", tb => tb.HasComment("Link from the consumer to the tool"));

            entity.HasIndex(e => e.Consumerid, "mdl_enroltilti2resolink_co2_ix");

            entity.HasIndex(e => e.Contextid, "mdl_enroltilti2resolink_con_ix");

            entity.HasIndex(e => e.Primaryresourcelinkid, "mdl_enroltilti2resolink_pri_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(11)")
                .HasColumnName("id");
            entity.Property(e => e.Consumerid)
                .HasColumnType("bigint(11)")
                .HasColumnName("consumerid");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(11)")
                .HasColumnName("contextid");
            entity.Property(e => e.Created)
                .HasColumnType("bigint(10)")
                .HasColumnName("created");
            entity.Property(e => e.Ltiresourcelinkkey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("ltiresourcelinkkey");
            entity.Property(e => e.Primaryresourcelinkid)
                .HasColumnType("bigint(11)")
                .HasColumnName("primaryresourcelinkid");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.Shareapproved).HasColumnName("shareapproved");
            entity.Property(e => e.Updated)
                .HasColumnType("bigint(10)")
                .HasColumnName("updated");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2ShareKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_lti_lti2_share_key", tb => tb.HasComment("Resource link share key"));

            entity.HasIndex(e => e.Resourcelinkid, "mdl_enroltilti2sharkey_res_uix").IsUnique();

            entity.HasIndex(e => e.Sharekey, "mdl_enroltilti2sharkey_sha_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(11)")
                .HasColumnName("id");
            entity.Property(e => e.Autoapprove).HasColumnName("autoapprove");
            entity.Property(e => e.Expires)
                .HasColumnType("bigint(10)")
                .HasColumnName("expires");
            entity.Property(e => e.Resourcelinkid)
                .HasColumnType("bigint(11)")
                .HasColumnName("resourcelinkid");
            entity.Property(e => e.Sharekey)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("sharekey");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2ToolProxy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_lti_lti2_tool_proxy", tb => tb.HasComment("A tool proxy between moodle and a consumer"));

            entity.HasIndex(e => e.Consumerid, "mdl_enroltilti2toolprox_con_ix");

            entity.HasIndex(e => e.Toolproxykey, "mdl_enroltilti2toolprox_to_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(11)")
                .HasColumnName("id");
            entity.Property(e => e.Consumerid)
                .HasColumnType("bigint(11)")
                .HasColumnName("consumerid");
            entity.Property(e => e.Created)
                .HasColumnType("bigint(10)")
                .HasColumnName("created");
            entity.Property(e => e.Toolproxy).HasColumnName("toolproxy");
            entity.Property(e => e.Toolproxykey)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("toolproxykey");
            entity.Property(e => e.Updated)
                .HasColumnType("bigint(10)")
                .HasColumnName("updated");
        });

        modelBuilder.Entity<MdlEnrolLtiLti2UserResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_lti_lti2_user_result", tb => tb.HasComment("Results for each user for each resource link"));

            entity.HasIndex(e => e.Resourcelinkid, "mdl_enroltilti2userresu_res_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(11)")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasColumnType("bigint(10)")
                .HasColumnName("created");
            entity.Property(e => e.Ltiresultsourcedid)
                .HasMaxLength(1024)
                .HasDefaultValueSql("''")
                .HasColumnName("ltiresultsourcedid");
            entity.Property(e => e.Ltiuserkey)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("ltiuserkey");
            entity.Property(e => e.Resourcelinkid)
                .HasColumnType("bigint(11)")
                .HasColumnName("resourcelinkid");
            entity.Property(e => e.Updated)
                .HasColumnType("bigint(10)")
                .HasColumnName("updated");
        });

        modelBuilder.Entity<MdlEnrolLtiTool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_lti_tools", tb => tb.HasComment("List of tools provided to the remote system"));

            entity.HasIndex(e => e.Contextid, "mdl_enroltitool_con_ix");

            entity.HasIndex(e => e.Enrolid, "mdl_enroltitool_enr_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.City)
                .HasMaxLength(120)
                .HasDefaultValueSql("''")
                .HasColumnName("city");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .HasColumnName("country");
            entity.Property(e => e.Enrolid)
                .HasColumnType("bigint(10)")
                .HasColumnName("enrolid");
            entity.Property(e => e.Gradesync).HasColumnName("gradesync");
            entity.Property(e => e.Gradesynccompletion).HasColumnName("gradesynccompletion");
            entity.Property(e => e.Institution)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("institution");
            entity.Property(e => e.Lang)
                .HasMaxLength(30)
                .HasDefaultValueSql("'en'")
                .HasColumnName("lang");
            entity.Property(e => e.Maildisplay)
                .HasDefaultValueSql("'2'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("maildisplay");
            entity.Property(e => e.Maxenrolled)
                .HasColumnType("bigint(10)")
                .HasColumnName("maxenrolled");
            entity.Property(e => e.Membersync).HasColumnName("membersync");
            entity.Property(e => e.Membersyncmode).HasColumnName("membersyncmode");
            entity.Property(e => e.Roleinstructor)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleinstructor");
            entity.Property(e => e.Rolelearner)
                .HasColumnType("bigint(10)")
                .HasColumnName("rolelearner");
            entity.Property(e => e.Secret).HasColumnName("secret");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timezone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'99'")
                .HasColumnName("timezone");
        });

        modelBuilder.Entity<MdlEnrolLtiToolConsumerMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_lti_tool_consumer_map", tb => tb.HasComment("Table that maps the published tool to tool consumers."));

            entity.HasIndex(e => e.Consumerid, "mdl_enroltitoolconsmap_con_ix");

            entity.HasIndex(e => e.Toolid, "mdl_enroltitoolconsmap_too_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Consumerid)
                .HasColumnType("bigint(11)")
                .HasColumnName("consumerid");
            entity.Property(e => e.Toolid)
                .HasColumnType("bigint(11)")
                .HasColumnName("toolid");
        });

        modelBuilder.Entity<MdlEnrolLtiUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_lti_users", tb => tb.HasComment("User access log and gradeback data"));

            entity.HasIndex(e => e.Toolid, "mdl_enroltiuser_too_ix");

            entity.HasIndex(e => e.Userid, "mdl_enroltiuser_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Consumerkey).HasColumnName("consumerkey");
            entity.Property(e => e.Consumersecret).HasColumnName("consumersecret");
            entity.Property(e => e.Lastaccess)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastaccess");
            entity.Property(e => e.Lastgrade)
                .HasPrecision(10, 5)
                .HasColumnName("lastgrade");
            entity.Property(e => e.Membershipsid).HasColumnName("membershipsid");
            entity.Property(e => e.Membershipsurl).HasColumnName("membershipsurl");
            entity.Property(e => e.Serviceurl).HasColumnName("serviceurl");
            entity.Property(e => e.Sourceid).HasColumnName("sourceid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Toolid)
                .HasColumnType("bigint(10)")
                .HasColumnName("toolid");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEnrolPaypal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_enrol_paypal", tb => tb.HasComment("Holds all known information about PayPal transactions"));

            entity.HasIndex(e => e.Business, "mdl_enropayp_bus_ix");

            entity.HasIndex(e => e.Courseid, "mdl_enropayp_cou_ix");

            entity.HasIndex(e => e.Instanceid, "mdl_enropayp_ins_ix");

            entity.HasIndex(e => e.ReceiverEmail, "mdl_enropayp_rec_ix");

            entity.HasIndex(e => e.Userid, "mdl_enropayp_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Business)
                .HasDefaultValueSql("''")
                .HasColumnName("business");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Instanceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("instanceid");
            entity.Property(e => e.ItemName)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("item_name");
            entity.Property(e => e.Memo)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("memo");
            entity.Property(e => e.OptionName1)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("option_name1");
            entity.Property(e => e.OptionName2)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("option_name2");
            entity.Property(e => e.OptionSelection1X)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("option_selection1_x");
            entity.Property(e => e.OptionSelection2X)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("option_selection2_x");
            entity.Property(e => e.ParentTxnId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("parent_txn_id");
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("payment_status");
            entity.Property(e => e.PaymentType)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("payment_type");
            entity.Property(e => e.PendingReason)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("pending_reason");
            entity.Property(e => e.ReasonCode)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("reason_code");
            entity.Property(e => e.ReceiverEmail)
                .HasDefaultValueSql("''")
                .HasColumnName("receiver_email");
            entity.Property(e => e.ReceiverId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("receiver_id");
            entity.Property(e => e.Tax)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("tax");
            entity.Property(e => e.Timeupdated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeupdated");
            entity.Property(e => e.TxnId)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("txn_id");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_event", tb => tb.HasComment("For everything with a time associated to it"));

            entity.HasIndex(e => e.Categoryid, "mdl_even_cat_ix");

            entity.HasIndex(e => new { e.Component, e.Eventtype, e.Instance }, "mdl_even_comeveins_ix");

            entity.HasIndex(e => e.Courseid, "mdl_even_cou_ix");

            entity.HasIndex(e => e.Eventtype, "mdl_even_eve_ix");

            entity.HasIndex(e => new { e.Groupid, e.Courseid, e.Categoryid, e.Visible, e.Userid }, "mdl_even_grocoucatvisuse_ix");

            entity.HasIndex(e => new { e.Modulename, e.Instance }, "mdl_even_modins_ix");

            entity.HasIndex(e => e.Subscriptionid, "mdl_even_sub_ix");

            entity.HasIndex(e => e.Timeduration, "mdl_even_tim2_ix");

            entity.HasIndex(e => e.Timestart, "mdl_even_tim_ix");

            entity.HasIndex(e => new { e.Type, e.Timesort }, "mdl_even_typtim_ix");

            entity.HasIndex(e => e.Userid, "mdl_even_use_ix");

            entity.HasIndex(e => e.Uuid, "mdl_even_uui_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Categoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("categoryid");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Eventtype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("eventtype");
            entity.Property(e => e.Format)
                .HasColumnType("smallint(4)")
                .HasColumnName("format");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Instance)
                .HasColumnType("bigint(10)")
                .HasColumnName("instance");
            entity.Property(e => e.Location).HasColumnName("location");
            entity.Property(e => e.Modulename)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("modulename");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Priority)
                .HasColumnType("bigint(10)")
                .HasColumnName("priority");
            entity.Property(e => e.Repeatid)
                .HasColumnType("bigint(10)")
                .HasColumnName("repeatid");
            entity.Property(e => e.Sequence)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("sequence");
            entity.Property(e => e.Subscriptionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("subscriptionid");
            entity.Property(e => e.Timeduration)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeduration");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timesort)
                .HasColumnType("bigint(10)")
                .HasColumnName("timesort");
            entity.Property(e => e.Timestart)
                .HasColumnType("bigint(10)")
                .HasColumnName("timestart");
            entity.Property(e => e.Type)
                .HasColumnType("smallint(4)")
                .HasColumnName("type");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Uuid)
                .HasDefaultValueSql("''")
                .HasColumnName("uuid");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlEventSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_event_subscriptions", tb => tb.HasComment("Tracks subscriptions to remote calendars."));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Categoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("categoryid");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Eventtype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("eventtype");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Lastupdated)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastupdated");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Pollinterval)
                .HasColumnType("bigint(10)")
                .HasColumnName("pollinterval");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEventsHandler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_events_handlers", tb => tb.HasComment("This table is for storing which components requests what typ"));

            entity.HasIndex(e => new { e.Eventname, e.Component }, "mdl_evenhand_evecom_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(166)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Eventname)
                .HasMaxLength(166)
                .HasDefaultValueSql("''")
                .HasColumnName("eventname");
            entity.Property(e => e.Handlerfile)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("handlerfile");
            entity.Property(e => e.Handlerfunction).HasColumnName("handlerfunction");
            entity.Property(e => e.Internal)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("internal");
            entity.Property(e => e.Schedule)
                .HasMaxLength(255)
                .HasColumnName("schedule");
            entity.Property(e => e.Status)
                .HasColumnType("bigint(10)")
                .HasColumnName("status");
        });

        modelBuilder.Entity<MdlEventsQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_events_queue", tb => tb.HasComment("This table is for storing queued events. It stores only one "));

            entity.HasIndex(e => e.Userid, "mdl_evenqueu_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Eventdata).HasColumnName("eventdata");
            entity.Property(e => e.Stackdump).HasColumnName("stackdump");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlEventsQueueHandler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_events_queue_handlers", tb => tb.HasComment("This is the list of queued handlers for processing. The even"));

            entity.HasIndex(e => e.Handlerid, "mdl_evenqueuhand_han_ix");

            entity.HasIndex(e => e.Queuedeventid, "mdl_evenqueuhand_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Errormessage).HasColumnName("errormessage");
            entity.Property(e => e.Handlerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("handlerid");
            entity.Property(e => e.Queuedeventid)
                .HasColumnType("bigint(10)")
                .HasColumnName("queuedeventid");
            entity.Property(e => e.Status)
                .HasColumnType("bigint(10)")
                .HasColumnName("status");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlExternalFunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_external_functions", tb => tb.HasComment("list of all external functions"));

            entity.HasIndex(e => e.Name, "mdl_extefunc_nam_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Capabilities)
                .HasMaxLength(255)
                .HasColumnName("capabilities");
            entity.Property(e => e.Classname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("classname");
            entity.Property(e => e.Classpath)
                .HasMaxLength(255)
                .HasColumnName("classpath");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Methodname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("methodname");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Services)
                .HasMaxLength(1333)
                .HasColumnName("services");
        });

        modelBuilder.Entity<MdlExternalService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_external_services", tb => tb.HasComment("built in and custom external services"));

            entity.HasIndex(e => e.Name, "mdl_exteserv_nam_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Downloadfiles).HasColumnName("downloadfiles");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Requiredcapability)
                .HasMaxLength(150)
                .HasColumnName("requiredcapability");
            entity.Property(e => e.Restrictedusers).HasColumnName("restrictedusers");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasColumnName("shortname");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Uploadfiles).HasColumnName("uploadfiles");
        });

        modelBuilder.Entity<MdlExternalServicesFunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_external_services_functions", tb => tb.HasComment("lists functions available in each service group"));

            entity.HasIndex(e => e.Externalserviceid, "mdl_exteservfunc_ext_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Externalserviceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("externalserviceid");
            entity.Property(e => e.Functionname)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("functionname");
        });

        modelBuilder.Entity<MdlExternalServicesUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_external_services_users", tb => tb.HasComment("users allowed to use services with restricted users flag"));

            entity.HasIndex(e => e.Externalserviceid, "mdl_exteservuser_ext_ix");

            entity.HasIndex(e => e.Userid, "mdl_exteservuser_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Externalserviceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("externalserviceid");
            entity.Property(e => e.Iprestriction)
                .HasMaxLength(255)
                .HasColumnName("iprestriction");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Validuntil)
                .HasColumnType("bigint(10)")
                .HasColumnName("validuntil");
        });

        modelBuilder.Entity<MdlExternalToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_external_tokens", tb => tb.HasComment("Security tokens for accessing of external services"));

            entity.HasIndex(e => e.Contextid, "mdl_extetoke_con_ix");

            entity.HasIndex(e => e.Creatorid, "mdl_extetoke_cre_ix");

            entity.HasIndex(e => e.Externalserviceid, "mdl_extetoke_ext_ix");

            entity.HasIndex(e => e.Userid, "mdl_extetoke_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Creatorid)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("creatorid");
            entity.Property(e => e.Externalserviceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("externalserviceid");
            entity.Property(e => e.Iprestriction)
                .HasMaxLength(255)
                .HasColumnName("iprestriction");
            entity.Property(e => e.Lastaccess)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastaccess");
            entity.Property(e => e.Privatetoken)
                .HasMaxLength(64)
                .HasColumnName("privatetoken");
            entity.Property(e => e.Sid)
                .HasMaxLength(128)
                .HasColumnName("sid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Token)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
            entity.Property(e => e.Tokentype)
                .HasColumnType("smallint(4)")
                .HasColumnName("tokentype");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Validuntil)
                .HasColumnType("bigint(10)")
                .HasColumnName("validuntil");
        });

        modelBuilder.Entity<MdlFavourite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_favourite", tb => tb.HasComment("Stores the relationship between an arbitrary item (itemtype,"));

            entity.HasIndex(e => new { e.Component, e.Itemtype, e.Itemid, e.Contextid, e.Userid }, "mdl_favo_comiteiteconuse_uix").IsUnique();

            entity.HasIndex(e => e.Contextid, "mdl_favo_con_ix");

            entity.HasIndex(e => e.Userid, "mdl_favo_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("itemtype");
            entity.Property(e => e.Ordering)
                .HasColumnType("bigint(10)")
                .HasColumnName("ordering");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlFeedback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_feedback", tb => tb.HasComment("all feedbacks"));

            entity.HasIndex(e => e.Course, "mdl_feed_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Anonymous)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("anonymous");
            entity.Property(e => e.Autonumbering)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("autonumbering");
            entity.Property(e => e.Completionsubmit).HasColumnName("completionsubmit");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.EmailNotification)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("email_notification");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.MultipleSubmit)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("multiple_submit");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.PageAfterSubmit).HasColumnName("page_after_submit");
            entity.Property(e => e.PageAfterSubmitformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("page_after_submitformat");
            entity.Property(e => e.PublishStats).HasColumnName("publish_stats");
            entity.Property(e => e.SiteAfterSubmit)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("site_after_submit");
            entity.Property(e => e.Timeclose)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeclose");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timeopen)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeopen");
        });

        modelBuilder.Entity<MdlFeedbackCompleted>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_feedback_completed", tb => tb.HasComment("filled out feedback"));

            entity.HasIndex(e => e.Feedback, "mdl_feedcomp_fee_ix");

            entity.HasIndex(e => e.Userid, "mdl_feedcomp_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.AnonymousResponse).HasColumnName("anonymous_response");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Feedback)
                .HasColumnType("bigint(10)")
                .HasColumnName("feedback");
            entity.Property(e => e.RandomResponse)
                .HasColumnType("bigint(10)")
                .HasColumnName("random_response");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlFeedbackCompletedtmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_feedback_completedtmp", tb => tb.HasComment("filled out feedback"));

            entity.HasIndex(e => e.Feedback, "mdl_feedcomp_fee2_ix");

            entity.HasIndex(e => e.Userid, "mdl_feedcomp_use2_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.AnonymousResponse).HasColumnName("anonymous_response");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Feedback)
                .HasColumnType("bigint(10)")
                .HasColumnName("feedback");
            entity.Property(e => e.Guestid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("guestid");
            entity.Property(e => e.RandomResponse)
                .HasColumnType("bigint(10)")
                .HasColumnName("random_response");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlFeedbackItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_feedback_item", tb => tb.HasComment("feedback_items"));

            entity.HasIndex(e => e.Feedback, "mdl_feeditem_fee_ix");

            entity.HasIndex(e => e.Template, "mdl_feeditem_tem_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Dependitem)
                .HasColumnType("bigint(10)")
                .HasColumnName("dependitem");
            entity.Property(e => e.Dependvalue)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("dependvalue");
            entity.Property(e => e.Feedback)
                .HasColumnType("bigint(10)")
                .HasColumnName("feedback");
            entity.Property(e => e.Hasvalue).HasColumnName("hasvalue");
            entity.Property(e => e.Label)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("label");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Options)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("options");
            entity.Property(e => e.Position)
                .HasColumnType("smallint(3)")
                .HasColumnName("position");
            entity.Property(e => e.Presentation).HasColumnName("presentation");
            entity.Property(e => e.Required).HasColumnName("required");
            entity.Property(e => e.Template)
                .HasColumnType("bigint(10)")
                .HasColumnName("template");
            entity.Property(e => e.Typ)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("typ");
        });

        modelBuilder.Entity<MdlFeedbackSitecourseMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_feedback_sitecourse_map", tb => tb.HasComment("feedback sitecourse map"));

            entity.HasIndex(e => e.Courseid, "mdl_feedsitemap_cou_ix");

            entity.HasIndex(e => e.Feedbackid, "mdl_feedsitemap_fee_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Feedbackid)
                .HasColumnType("bigint(10)")
                .HasColumnName("feedbackid");
        });

        modelBuilder.Entity<MdlFeedbackTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_feedback_template", tb => tb.HasComment("templates of feedbackstructures"));

            entity.HasIndex(e => e.Course, "mdl_feedtemp_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Ispublic).HasColumnName("ispublic");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<MdlFeedbackValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_feedback_value", tb => tb.HasComment("values of the completeds"));

            entity.HasIndex(e => new { e.Completed, e.Item, e.CourseId }, "mdl_feedvalu_comitecou_uix").IsUnique();

            entity.HasIndex(e => e.CourseId, "mdl_feedvalu_cou_ix");

            entity.HasIndex(e => e.Item, "mdl_feedvalu_ite_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Completed)
                .HasColumnType("bigint(10)")
                .HasColumnName("completed");
            entity.Property(e => e.CourseId)
                .HasColumnType("bigint(10)")
                .HasColumnName("course_id");
            entity.Property(e => e.Item)
                .HasColumnType("bigint(10)")
                .HasColumnName("item");
            entity.Property(e => e.TmpCompleted)
                .HasColumnType("bigint(10)")
                .HasColumnName("tmp_completed");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlFeedbackValuetmp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_feedback_valuetmp", tb => tb.HasComment("values of the completedstmp"));

            entity.HasIndex(e => new { e.Completed, e.Item, e.CourseId }, "mdl_feedvalu_comitecou2_uix").IsUnique();

            entity.HasIndex(e => e.CourseId, "mdl_feedvalu_cou2_ix");

            entity.HasIndex(e => e.Item, "mdl_feedvalu_ite2_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Completed)
                .HasColumnType("bigint(10)")
                .HasColumnName("completed");
            entity.Property(e => e.CourseId)
                .HasColumnType("bigint(10)")
                .HasColumnName("course_id");
            entity.Property(e => e.Item)
                .HasColumnType("bigint(10)")
                .HasColumnName("item");
            entity.Property(e => e.TmpCompleted)
                .HasColumnType("bigint(10)")
                .HasColumnName("tmp_completed");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_files", tb => tb.HasComment("description of files, content is stored in sha1 file pool"));

            entity.HasIndex(e => new { e.Component, e.Filearea, e.Contextid, e.Itemid }, "mdl_file_comfilconite_ix");

            entity.HasIndex(e => e.Contextid, "mdl_file_con2_ix");

            entity.HasIndex(e => e.Contenthash, "mdl_file_con_ix");

            entity.HasIndex(e => e.License, "mdl_file_lic_ix");

            entity.HasIndex(e => e.Pathnamehash, "mdl_file_pat_uix").IsUnique();

            entity.HasIndex(e => e.Referencefileid, "mdl_file_ref_ix");

            entity.HasIndex(e => e.Userid, "mdl_file_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Author)
                .HasMaxLength(255)
                .HasColumnName("author");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contenthash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("contenthash");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Filearea)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("filearea");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("filename");
            entity.Property(e => e.Filepath)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("filepath");
            entity.Property(e => e.Filesize)
                .HasColumnType("bigint(10)")
                .HasColumnName("filesize");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.License).HasColumnName("license");
            entity.Property(e => e.Mimetype)
                .HasMaxLength(100)
                .HasColumnName("mimetype");
            entity.Property(e => e.Pathnamehash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("pathnamehash");
            entity.Property(e => e.Referencefileid)
                .HasColumnType("bigint(10)")
                .HasColumnName("referencefileid");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Source).HasColumnName("source");
            entity.Property(e => e.Status)
                .HasColumnType("bigint(10)")
                .HasColumnName("status");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlFileConversion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_file_conversion", tb => tb.HasComment("Table to track file conversions."));

            entity.HasIndex(e => e.Destfileid, "mdl_fileconv_des_ix");

            entity.HasIndex(e => e.Sourcefileid, "mdl_fileconv_sou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Converter)
                .HasMaxLength(255)
                .HasColumnName("converter");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Destfileid)
                .HasColumnType("bigint(10)")
                .HasColumnName("destfileid");
            entity.Property(e => e.Sourcefileid)
                .HasColumnType("bigint(10)")
                .HasColumnName("sourcefileid");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("status");
            entity.Property(e => e.Statusmessage).HasColumnName("statusmessage");
            entity.Property(e => e.Targetformat)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("targetformat");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlFilesReference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_files_reference", tb => tb.HasComment("Store files references"));

            entity.HasIndex(e => new { e.Referencehash, e.Repositoryid }, "mdl_filerefe_refrep_uix").IsUnique();

            entity.HasIndex(e => e.Repositoryid, "mdl_filerefe_rep_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Lastsync)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastsync");
            entity.Property(e => e.Reference).HasColumnName("reference");
            entity.Property(e => e.Referencehash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("referencehash");
            entity.Property(e => e.Repositoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("repositoryid");
        });

        modelBuilder.Entity<MdlFilterActive>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_filter_active", tb => tb.HasComment("Stores information about which filters are active in which c"));

            entity.HasIndex(e => e.Contextid, "mdl_filtacti_con_ix");

            entity.HasIndex(e => new { e.Contextid, e.Filter }, "mdl_filtacti_confil_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Active)
                .HasColumnType("smallint(4)")
                .HasColumnName("active");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Filter)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("filter");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlFilterConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_filter_config", tb => tb.HasComment("Stores per-context configuration settings for filters which "));

            entity.HasIndex(e => e.Contextid, "mdl_filtconf_con_ix");

            entity.HasIndex(e => new { e.Contextid, e.Filter, e.Name }, "mdl_filtconf_confilnam_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Filter)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("filter");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlFolder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_folder", tb => tb.HasComment("each record is one folder resource"));

            entity.HasIndex(e => e.Course, "mdl_fold_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Display)
                .HasColumnType("smallint(4)")
                .HasColumnName("display");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Revision)
                .HasColumnType("bigint(10)")
                .HasColumnName("revision");
            entity.Property(e => e.Showdownloadfolder)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("showdownloadfolder");
            entity.Property(e => e.Showexpanded)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("showexpanded");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlForum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_forum", tb => tb.HasComment("Forums contain and structure discussion"));

            entity.HasIndex(e => e.Course, "mdl_foru_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assessed)
                .HasColumnType("bigint(10)")
                .HasColumnName("assessed");
            entity.Property(e => e.Assesstimefinish)
                .HasColumnType("bigint(10)")
                .HasColumnName("assesstimefinish");
            entity.Property(e => e.Assesstimestart)
                .HasColumnType("bigint(10)")
                .HasColumnName("assesstimestart");
            entity.Property(e => e.Blockafter)
                .HasColumnType("bigint(10)")
                .HasColumnName("blockafter");
            entity.Property(e => e.Blockperiod)
                .HasColumnType("bigint(10)")
                .HasColumnName("blockperiod");
            entity.Property(e => e.Completiondiscussions)
                .HasColumnType("int(9)")
                .HasColumnName("completiondiscussions");
            entity.Property(e => e.Completionposts)
                .HasColumnType("int(9)")
                .HasColumnName("completionposts");
            entity.Property(e => e.Completionreplies)
                .HasColumnType("int(9)")
                .HasColumnName("completionreplies");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Cutoffdate)
                .HasColumnType("bigint(10)")
                .HasColumnName("cutoffdate");
            entity.Property(e => e.Displaywordcount).HasColumnName("displaywordcount");
            entity.Property(e => e.Duedate)
                .HasColumnType("bigint(10)")
                .HasColumnName("duedate");
            entity.Property(e => e.Forcesubscribe).HasColumnName("forcesubscribe");
            entity.Property(e => e.GradeForum)
                .HasColumnType("bigint(10)")
                .HasColumnName("grade_forum");
            entity.Property(e => e.GradeForumNotify)
                .HasColumnType("smallint(4)")
                .HasColumnName("grade_forum_notify");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Lockdiscussionafter)
                .HasColumnType("bigint(10)")
                .HasColumnName("lockdiscussionafter");
            entity.Property(e => e.Maxattachments)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("maxattachments");
            entity.Property(e => e.Maxbytes)
                .HasColumnType("bigint(10)")
                .HasColumnName("maxbytes");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Rssarticles)
                .HasColumnType("tinyint(2)")
                .HasColumnName("rssarticles");
            entity.Property(e => e.Rsstype)
                .HasColumnType("tinyint(2)")
                .HasColumnName("rsstype");
            entity.Property(e => e.Scale)
                .HasColumnType("bigint(10)")
                .HasColumnName("scale");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Trackingtype)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("trackingtype");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .HasDefaultValueSql("'general'")
                .HasColumnName("type");
            entity.Property(e => e.Warnafter)
                .HasColumnType("bigint(10)")
                .HasColumnName("warnafter");
        });

        modelBuilder.Entity<MdlForumDigest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_forum_digests", tb => tb.HasComment("Keeps track of user mail delivery preferences for each forum"));

            entity.HasIndex(e => e.Forum, "mdl_forudige_for_ix");

            entity.HasIndex(e => new { e.Forum, e.Userid, e.Maildigest }, "mdl_forudige_forusemai_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_forudige_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Forum)
                .HasColumnType("bigint(10)")
                .HasColumnName("forum");
            entity.Property(e => e.Maildigest)
                .IsRequired()
                .HasDefaultValueSql("-1")
                .HasColumnName("maildigest");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumDiscussion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_forum_discussions", tb => tb.HasComment("Forums are composed of discussions"));

            entity.HasIndex(e => e.Course, "mdl_forudisc_cou_ix");

            entity.HasIndex(e => e.Forum, "mdl_forudisc_for_ix");

            entity.HasIndex(e => e.Userid, "mdl_forudisc_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assessed)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("assessed");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Firstpost)
                .HasColumnType("bigint(10)")
                .HasColumnName("firstpost");
            entity.Property(e => e.Forum)
                .HasColumnType("bigint(10)")
                .HasColumnName("forum");
            entity.Property(e => e.Groupid)
                .HasDefaultValueSql("-1")
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Pinned).HasColumnName("pinned");
            entity.Property(e => e.Timeend)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
            entity.Property(e => e.Timelocked)
                .HasColumnType("bigint(10)")
                .HasColumnName("timelocked");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timestart)
                .HasColumnType("bigint(10)")
                .HasColumnName("timestart");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlForumDiscussionSub>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_forum_discussion_subs", tb => tb.HasComment("Users may choose to subscribe and unsubscribe from specific "));

            entity.HasIndex(e => e.Discussion, "mdl_forudiscsubs_dis_ix");

            entity.HasIndex(e => e.Forum, "mdl_forudiscsubs_for_ix");

            entity.HasIndex(e => e.Userid, "mdl_forudiscsubs_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Discussion }, "mdl_forudiscsubs_usedis_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Discussion)
                .HasColumnType("bigint(10)")
                .HasColumnName("discussion");
            entity.Property(e => e.Forum)
                .HasColumnType("bigint(10)")
                .HasColumnName("forum");
            entity.Property(e => e.Preference)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("preference");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_forum_grades", tb => tb.HasComment("Grading data for forum instances"));

            entity.HasIndex(e => e.Forum, "mdl_forugrad_for_ix");

            entity.HasIndex(e => new { e.Forum, e.Itemnumber, e.Userid }, "mdl_forugrad_foriteuse_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_forugrad_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Forum)
                .HasColumnType("bigint(10)")
                .HasColumnName("forum");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Itemnumber)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemnumber");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_forum_posts", tb => tb.HasComment("All posts are stored in this table"));

            entity.HasIndex(e => e.Created, "mdl_forupost_cre_ix");

            entity.HasIndex(e => e.Discussion, "mdl_forupost_dis_ix");

            entity.HasIndex(e => e.Mailed, "mdl_forupost_mai_ix");

            entity.HasIndex(e => e.Parent, "mdl_forupost_par_ix");

            entity.HasIndex(e => e.Privatereplyto, "mdl_forupost_pri_ix");

            entity.HasIndex(e => e.Userid, "mdl_forupost_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("attachment");
            entity.Property(e => e.Charcount)
                .HasColumnType("bigint(20)")
                .HasColumnName("charcount");
            entity.Property(e => e.Created)
                .HasColumnType("bigint(10)")
                .HasColumnName("created");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Discussion)
                .HasColumnType("bigint(10)")
                .HasColumnName("discussion");
            entity.Property(e => e.Mailed)
                .HasColumnType("tinyint(2)")
                .HasColumnName("mailed");
            entity.Property(e => e.Mailnow)
                .HasColumnType("bigint(10)")
                .HasColumnName("mailnow");
            entity.Property(e => e.Message).HasColumnName("message");
            entity.Property(e => e.Messageformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("messageformat");
            entity.Property(e => e.Messagetrust)
                .HasColumnType("tinyint(2)")
                .HasColumnName("messagetrust");
            entity.Property(e => e.Modified)
                .HasColumnType("bigint(10)")
                .HasColumnName("modified");
            entity.Property(e => e.Parent)
                .HasColumnType("bigint(10)")
                .HasColumnName("parent");
            entity.Property(e => e.Privatereplyto)
                .HasColumnType("bigint(10)")
                .HasColumnName("privatereplyto");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("subject");
            entity.Property(e => e.Totalscore)
                .HasColumnType("smallint(4)")
                .HasColumnName("totalscore");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Wordcount)
                .HasColumnType("bigint(20)")
                .HasColumnName("wordcount");
        });

        modelBuilder.Entity<MdlForumQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_forum_queue", tb => tb.HasComment("For keeping track of posts that will be mailed in digest for"));

            entity.HasIndex(e => e.Discussionid, "mdl_foruqueu_dis_ix");

            entity.HasIndex(e => e.Postid, "mdl_foruqueu_pos_ix");

            entity.HasIndex(e => e.Userid, "mdl_foruqueu_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Discussionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("discussionid");
            entity.Property(e => e.Postid)
                .HasColumnType("bigint(10)")
                .HasColumnName("postid");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumRead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_forum_read", tb => tb.HasComment("Tracks each users read posts"));

            entity.HasIndex(e => new { e.Postid, e.Userid }, "mdl_foruread_posuse_ix");

            entity.HasIndex(e => new { e.Userid, e.Discussionid }, "mdl_foruread_usedis_ix");

            entity.HasIndex(e => new { e.Userid, e.Forumid }, "mdl_foruread_usefor_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Discussionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("discussionid");
            entity.Property(e => e.Firstread)
                .HasColumnType("bigint(10)")
                .HasColumnName("firstread");
            entity.Property(e => e.Forumid)
                .HasColumnType("bigint(10)")
                .HasColumnName("forumid");
            entity.Property(e => e.Lastread)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastread");
            entity.Property(e => e.Postid)
                .HasColumnType("bigint(10)")
                .HasColumnName("postid");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_forum_subscriptions", tb => tb.HasComment("Keeps track of who is subscribed to what forum"));

            entity.HasIndex(e => e.Forum, "mdl_forusubs_for_ix");

            entity.HasIndex(e => e.Userid, "mdl_forusubs_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Forum }, "mdl_forusubs_usefor_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Forum)
                .HasColumnType("bigint(10)")
                .HasColumnName("forum");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlForumTrackPref>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_forum_track_prefs", tb => tb.HasComment("Tracks each users untracked forums"));

            entity.HasIndex(e => new { e.Userid, e.Forumid }, "mdl_forutracpref_usefor_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Forumid)
                .HasColumnType("bigint(10)")
                .HasColumnName("forumid");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlGlossary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_glossary", tb => tb.HasComment("all glossaries"));

            entity.HasIndex(e => e.Course, "mdl_glos_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Allowcomments)
                .HasColumnType("tinyint(2)")
                .HasColumnName("allowcomments");
            entity.Property(e => e.Allowduplicatedentries)
                .HasColumnType("tinyint(2)")
                .HasColumnName("allowduplicatedentries");
            entity.Property(e => e.Allowprintview)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("allowprintview");
            entity.Property(e => e.Approvaldisplayformat)
                .HasMaxLength(50)
                .HasDefaultValueSql("'default'")
                .HasColumnName("approvaldisplayformat");
            entity.Property(e => e.Assessed)
                .HasColumnType("bigint(10)")
                .HasColumnName("assessed");
            entity.Property(e => e.Assesstimefinish)
                .HasColumnType("bigint(10)")
                .HasColumnName("assesstimefinish");
            entity.Property(e => e.Assesstimestart)
                .HasColumnType("bigint(10)")
                .HasColumnName("assesstimestart");
            entity.Property(e => e.Completionentries)
                .HasColumnType("int(9)")
                .HasColumnName("completionentries");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Defaultapproval)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("defaultapproval");
            entity.Property(e => e.Displayformat)
                .HasMaxLength(50)
                .HasDefaultValueSql("'dictionary'")
                .HasColumnName("displayformat");
            entity.Property(e => e.Editalways)
                .HasColumnType("tinyint(2)")
                .HasColumnName("editalways");
            entity.Property(e => e.Entbypage)
                .HasDefaultValueSql("'10'")
                .HasColumnType("smallint(3)")
                .HasColumnName("entbypage");
            entity.Property(e => e.Globalglossary)
                .HasColumnType("tinyint(2)")
                .HasColumnName("globalglossary");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Mainglossary)
                .HasColumnType("tinyint(2)")
                .HasColumnName("mainglossary");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Rssarticles)
                .HasColumnType("tinyint(2)")
                .HasColumnName("rssarticles");
            entity.Property(e => e.Rsstype)
                .HasColumnType("tinyint(2)")
                .HasColumnName("rsstype");
            entity.Property(e => e.Scale)
                .HasColumnType("bigint(10)")
                .HasColumnName("scale");
            entity.Property(e => e.Showall)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("showall");
            entity.Property(e => e.Showalphabet)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("showalphabet");
            entity.Property(e => e.Showspecial)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("showspecial");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usedynalink)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("usedynalink");
        });

        modelBuilder.Entity<MdlGlossaryAlias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_glossary_alias", tb => tb.HasComment("entries alias"));

            entity.HasIndex(e => e.Entryid, "mdl_glosalia_ent_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Alias)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("alias");
            entity.Property(e => e.Entryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("entryid");
        });

        modelBuilder.Entity<MdlGlossaryCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_glossary_categories", tb => tb.HasComment("all categories for glossary entries"));

            entity.HasIndex(e => e.Glossaryid, "mdl_gloscate_glo_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Glossaryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("glossaryid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Usedynalink)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("usedynalink");
        });

        modelBuilder.Entity<MdlGlossaryEntriesCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_glossary_entries_categories", tb => tb.HasComment("categories of each glossary entry"));

            entity.HasIndex(e => e.Categoryid, "mdl_glosentrcate_cat_ix");

            entity.HasIndex(e => e.Entryid, "mdl_glosentrcate_ent_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Categoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("categoryid");
            entity.Property(e => e.Entryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("entryid");
        });

        modelBuilder.Entity<MdlGlossaryEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_glossary_entries", tb => tb.HasComment("all glossary entries"));

            entity.HasIndex(e => e.Concept, "mdl_glosentr_con_ix");

            entity.HasIndex(e => e.Glossaryid, "mdl_glosentr_glo_ix");

            entity.HasIndex(e => e.Userid, "mdl_glosentr_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Approved)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("approved");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("attachment");
            entity.Property(e => e.Casesensitive)
                .HasColumnType("tinyint(2)")
                .HasColumnName("casesensitive");
            entity.Property(e => e.Concept)
                .HasDefaultValueSql("''")
                .HasColumnName("concept");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Definitionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("definitionformat");
            entity.Property(e => e.Definitiontrust)
                .HasColumnType("tinyint(2)")
                .HasColumnName("definitiontrust");
            entity.Property(e => e.Fullmatch)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("fullmatch");
            entity.Property(e => e.Glossaryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("glossaryid");
            entity.Property(e => e.Sourceglossaryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("sourceglossaryid");
            entity.Property(e => e.Teacherentry)
                .HasColumnType("tinyint(2)")
                .HasColumnName("teacherentry");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usedynalink)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("usedynalink");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlGlossaryFormat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_glossary_formats", tb => tb.HasComment("Setting of the display formats"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Defaulthook)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("defaulthook");
            entity.Property(e => e.Defaultmode)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("defaultmode");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Popupformatname)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("popupformatname");
            entity.Property(e => e.Showgroup)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("showgroup");
            entity.Property(e => e.Showtabs)
                .HasMaxLength(100)
                .HasColumnName("showtabs");
            entity.Property(e => e.Sortkey)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("sortkey");
            entity.Property(e => e.Sortorder)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("sortorder");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlGradeCategoriesHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_categories_history", tb => tb.HasComment("History of grade_categories"));

            entity.HasIndex(e => e.Action, "mdl_gradcatehist_act_ix");

            entity.HasIndex(e => e.Courseid, "mdl_gradcatehist_cou_ix");

            entity.HasIndex(e => e.Loggeduser, "mdl_gradcatehist_log_ix");

            entity.HasIndex(e => e.Oldid, "mdl_gradcatehist_old_ix");

            entity.HasIndex(e => e.Parent, "mdl_gradcatehist_par_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_gradcatehist_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasColumnType("bigint(10)")
                .HasColumnName("action");
            entity.Property(e => e.Aggregateonlygraded).HasColumnName("aggregateonlygraded");
            entity.Property(e => e.Aggregateoutcomes).HasColumnName("aggregateoutcomes");
            entity.Property(e => e.Aggregatesubcats).HasColumnName("aggregatesubcats");
            entity.Property(e => e.Aggregation)
                .HasColumnType("bigint(10)")
                .HasColumnName("aggregation");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Depth)
                .HasColumnType("bigint(10)")
                .HasColumnName("depth");
            entity.Property(e => e.Droplow)
                .HasColumnType("bigint(10)")
                .HasColumnName("droplow");
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Keephigh)
                .HasColumnType("bigint(10)")
                .HasColumnName("keephigh");
            entity.Property(e => e.Loggeduser)
                .HasColumnType("bigint(10)")
                .HasColumnName("loggeduser");
            entity.Property(e => e.Oldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("oldid");
            entity.Property(e => e.Parent)
                .HasColumnType("bigint(10)")
                .HasColumnName("parent");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasColumnName("path");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGradeCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_categories", tb => tb.HasComment("This table keeps information about categories, used for grou"));

            entity.HasIndex(e => e.Courseid, "mdl_gradcate_cou_ix");

            entity.HasIndex(e => e.Parent, "mdl_gradcate_par_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Aggregateonlygraded).HasColumnName("aggregateonlygraded");
            entity.Property(e => e.Aggregateoutcomes).HasColumnName("aggregateoutcomes");
            entity.Property(e => e.Aggregation)
                .HasColumnType("bigint(10)")
                .HasColumnName("aggregation");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Depth)
                .HasColumnType("bigint(10)")
                .HasColumnName("depth");
            entity.Property(e => e.Droplow)
                .HasColumnType("bigint(10)")
                .HasColumnName("droplow");
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Keephigh)
                .HasColumnType("bigint(10)")
                .HasColumnName("keephigh");
            entity.Property(e => e.Parent)
                .HasColumnType("bigint(10)")
                .HasColumnName("parent");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasColumnName("path");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGradeGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_grades", tb => tb.HasComment("grade_grades  This table keeps individual grades for each us"));

            entity.HasIndex(e => e.Itemid, "mdl_gradgrad_ite_ix");

            entity.HasIndex(e => new { e.Locked, e.Locktime }, "mdl_gradgrad_locloc_ix");

            entity.HasIndex(e => e.Rawscaleid, "mdl_gradgrad_raw_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_gradgrad_use2_ix");

            entity.HasIndex(e => e.Userid, "mdl_gradgrad_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Itemid }, "mdl_gradgrad_useite_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Aggregationstatus)
                .HasMaxLength(10)
                .HasDefaultValueSql("'unknown'")
                .HasColumnName("aggregationstatus");
            entity.Property(e => e.Aggregationweight)
                .HasPrecision(10, 5)
                .HasColumnName("aggregationweight");
            entity.Property(e => e.Excluded)
                .HasColumnType("bigint(10)")
                .HasColumnName("excluded");
            entity.Property(e => e.Exported)
                .HasColumnType("bigint(10)")
                .HasColumnName("exported");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Feedbackformat)
                .HasColumnType("bigint(10)")
                .HasColumnName("feedbackformat");
            entity.Property(e => e.Finalgrade)
                .HasPrecision(10, 5)
                .HasColumnName("finalgrade");
            entity.Property(e => e.Hidden)
                .HasColumnType("bigint(10)")
                .HasColumnName("hidden");
            entity.Property(e => e.Information).HasColumnName("information");
            entity.Property(e => e.Informationformat)
                .HasColumnType("bigint(10)")
                .HasColumnName("informationformat");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Locked)
                .HasColumnType("bigint(10)")
                .HasColumnName("locked");
            entity.Property(e => e.Locktime)
                .HasColumnType("bigint(10)")
                .HasColumnName("locktime");
            entity.Property(e => e.Overridden)
                .HasColumnType("bigint(10)")
                .HasColumnName("overridden");
            entity.Property(e => e.Rawgrade)
                .HasPrecision(10, 5)
                .HasColumnName("rawgrade");
            entity.Property(e => e.Rawgrademax)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'100.00000'")
                .HasColumnName("rawgrademax");
            entity.Property(e => e.Rawgrademin)
                .HasPrecision(10, 5)
                .HasColumnName("rawgrademin");
            entity.Property(e => e.Rawscaleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("rawscaleid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlGradeGradesHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_grades_history", tb => tb.HasComment("History table"));

            entity.HasIndex(e => e.Action, "mdl_gradgradhist_act_ix");

            entity.HasIndex(e => e.Itemid, "mdl_gradgradhist_ite_ix");

            entity.HasIndex(e => e.Loggeduser, "mdl_gradgradhist_log_ix");

            entity.HasIndex(e => e.Oldid, "mdl_gradgradhist_old_ix");

            entity.HasIndex(e => e.Rawscaleid, "mdl_gradgradhist_raw_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_gradgradhist_tim_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_gradgradhist_use2_ix");

            entity.HasIndex(e => e.Userid, "mdl_gradgradhist_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Itemid, e.Timemodified }, "mdl_gradgradhist_useitetim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasColumnType("bigint(10)")
                .HasColumnName("action");
            entity.Property(e => e.Excluded)
                .HasColumnType("bigint(10)")
                .HasColumnName("excluded");
            entity.Property(e => e.Exported)
                .HasColumnType("bigint(10)")
                .HasColumnName("exported");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Feedbackformat)
                .HasColumnType("bigint(10)")
                .HasColumnName("feedbackformat");
            entity.Property(e => e.Finalgrade)
                .HasPrecision(10, 5)
                .HasColumnName("finalgrade");
            entity.Property(e => e.Hidden)
                .HasColumnType("bigint(10)")
                .HasColumnName("hidden");
            entity.Property(e => e.Information).HasColumnName("information");
            entity.Property(e => e.Informationformat)
                .HasColumnType("bigint(10)")
                .HasColumnName("informationformat");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Locked)
                .HasColumnType("bigint(10)")
                .HasColumnName("locked");
            entity.Property(e => e.Locktime)
                .HasColumnType("bigint(10)")
                .HasColumnName("locktime");
            entity.Property(e => e.Loggeduser)
                .HasColumnType("bigint(10)")
                .HasColumnName("loggeduser");
            entity.Property(e => e.Oldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("oldid");
            entity.Property(e => e.Overridden)
                .HasColumnType("bigint(10)")
                .HasColumnName("overridden");
            entity.Property(e => e.Rawgrade)
                .HasPrecision(10, 5)
                .HasColumnName("rawgrade");
            entity.Property(e => e.Rawgrademax)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'100.00000'")
                .HasColumnName("rawgrademax");
            entity.Property(e => e.Rawgrademin)
                .HasPrecision(10, 5)
                .HasColumnName("rawgrademin");
            entity.Property(e => e.Rawscaleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("rawscaleid");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlGradeImportNewitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_import_newitem", tb => tb.HasComment("temporary table for storing new grade_item names from grade "));

            entity.HasIndex(e => e.Importer, "mdl_gradimponewi_imp_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Importcode)
                .HasColumnType("bigint(10)")
                .HasColumnName("importcode");
            entity.Property(e => e.Importer)
                .HasColumnType("bigint(10)")
                .HasColumnName("importer");
            entity.Property(e => e.Itemname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("itemname");
        });

        modelBuilder.Entity<MdlGradeImportValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_import_values", tb => tb.HasComment("Temporary table for importing grades"));

            entity.HasIndex(e => e.Importer, "mdl_gradimpovalu_imp_ix");

            entity.HasIndex(e => e.Itemid, "mdl_gradimpovalu_ite_ix");

            entity.HasIndex(e => e.Newgradeitem, "mdl_gradimpovalu_new_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Finalgrade)
                .HasPrecision(10, 5)
                .HasColumnName("finalgrade");
            entity.Property(e => e.Importcode)
                .HasColumnType("bigint(10)")
                .HasColumnName("importcode");
            entity.Property(e => e.Importer)
                .HasColumnType("bigint(10)")
                .HasColumnName("importer");
            entity.Property(e => e.Importonlyfeedback)
                .HasDefaultValueSql("'0'")
                .HasColumnName("importonlyfeedback");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Newgradeitem)
                .HasColumnType("bigint(10)")
                .HasColumnName("newgradeitem");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlGradeItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_items", tb => tb.HasComment("This table keeps information about gradeable items (ie colum"));

            entity.HasIndex(e => e.Categoryid, "mdl_graditem_cat_ix");

            entity.HasIndex(e => e.Courseid, "mdl_graditem_cou_ix");

            entity.HasIndex(e => e.Gradetype, "mdl_graditem_gra_ix");

            entity.HasIndex(e => new { e.Idnumber, e.Courseid }, "mdl_graditem_idncou_ix");

            entity.HasIndex(e => new { e.Itemtype, e.Needsupdate }, "mdl_graditem_itenee_ix");

            entity.HasIndex(e => new { e.Locked, e.Locktime }, "mdl_graditem_locloc_ix");

            entity.HasIndex(e => e.Outcomeid, "mdl_graditem_out_ix");

            entity.HasIndex(e => e.Scaleid, "mdl_graditem_sca_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Aggregationcoef)
                .HasPrecision(10, 5)
                .HasColumnName("aggregationcoef");
            entity.Property(e => e.Aggregationcoef2)
                .HasPrecision(10, 5)
                .HasColumnName("aggregationcoef2");
            entity.Property(e => e.Calculation).HasColumnName("calculation");
            entity.Property(e => e.Categoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("categoryid");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Decimals).HasColumnName("decimals");
            entity.Property(e => e.Display)
                .HasColumnType("bigint(10)")
                .HasColumnName("display");
            entity.Property(e => e.Grademax)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'100.00000'")
                .HasColumnName("grademax");
            entity.Property(e => e.Grademin)
                .HasPrecision(10, 5)
                .HasColumnName("grademin");
            entity.Property(e => e.Gradepass)
                .HasPrecision(10, 5)
                .HasColumnName("gradepass");
            entity.Property(e => e.Gradetype)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("gradetype");
            entity.Property(e => e.Hidden)
                .HasColumnType("bigint(10)")
                .HasColumnName("hidden");
            entity.Property(e => e.Idnumber).HasColumnName("idnumber");
            entity.Property(e => e.Iteminfo).HasColumnName("iteminfo");
            entity.Property(e => e.Iteminstance)
                .HasColumnType("bigint(10)")
                .HasColumnName("iteminstance");
            entity.Property(e => e.Itemmodule)
                .HasMaxLength(30)
                .HasColumnName("itemmodule");
            entity.Property(e => e.Itemname)
                .HasMaxLength(255)
                .HasColumnName("itemname");
            entity.Property(e => e.Itemnumber)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemnumber");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("itemtype");
            entity.Property(e => e.Locked)
                .HasColumnType("bigint(10)")
                .HasColumnName("locked");
            entity.Property(e => e.Locktime)
                .HasColumnType("bigint(10)")
                .HasColumnName("locktime");
            entity.Property(e => e.Multfactor)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'1.00000'")
                .HasColumnName("multfactor");
            entity.Property(e => e.Needsupdate)
                .HasColumnType("bigint(10)")
                .HasColumnName("needsupdate");
            entity.Property(e => e.Outcomeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("outcomeid");
            entity.Property(e => e.Plusfactor)
                .HasPrecision(10, 5)
                .HasColumnName("plusfactor");
            entity.Property(e => e.Scaleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scaleid");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Weightoverride).HasColumnName("weightoverride");
        });

        modelBuilder.Entity<MdlGradeItemsHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_items_history", tb => tb.HasComment("History of grade_items"));

            entity.HasIndex(e => e.Action, "mdl_graditemhist_act_ix");

            entity.HasIndex(e => e.Categoryid, "mdl_graditemhist_cat_ix");

            entity.HasIndex(e => e.Courseid, "mdl_graditemhist_cou_ix");

            entity.HasIndex(e => e.Loggeduser, "mdl_graditemhist_log_ix");

            entity.HasIndex(e => e.Oldid, "mdl_graditemhist_old_ix");

            entity.HasIndex(e => e.Outcomeid, "mdl_graditemhist_out_ix");

            entity.HasIndex(e => e.Scaleid, "mdl_graditemhist_sca_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_graditemhist_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasColumnType("bigint(10)")
                .HasColumnName("action");
            entity.Property(e => e.Aggregationcoef)
                .HasPrecision(10, 5)
                .HasColumnName("aggregationcoef");
            entity.Property(e => e.Aggregationcoef2)
                .HasPrecision(10, 5)
                .HasColumnName("aggregationcoef2");
            entity.Property(e => e.Calculation).HasColumnName("calculation");
            entity.Property(e => e.Categoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("categoryid");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Decimals).HasColumnName("decimals");
            entity.Property(e => e.Display)
                .HasColumnType("bigint(10)")
                .HasColumnName("display");
            entity.Property(e => e.Grademax)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'100.00000'")
                .HasColumnName("grademax");
            entity.Property(e => e.Grademin)
                .HasPrecision(10, 5)
                .HasColumnName("grademin");
            entity.Property(e => e.Gradepass)
                .HasPrecision(10, 5)
                .HasColumnName("gradepass");
            entity.Property(e => e.Gradetype)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("gradetype");
            entity.Property(e => e.Hidden)
                .HasColumnType("bigint(10)")
                .HasColumnName("hidden");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(255)
                .HasColumnName("idnumber");
            entity.Property(e => e.Iteminfo).HasColumnName("iteminfo");
            entity.Property(e => e.Iteminstance)
                .HasColumnType("bigint(10)")
                .HasColumnName("iteminstance");
            entity.Property(e => e.Itemmodule)
                .HasMaxLength(30)
                .HasColumnName("itemmodule");
            entity.Property(e => e.Itemname)
                .HasMaxLength(255)
                .HasColumnName("itemname");
            entity.Property(e => e.Itemnumber)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemnumber");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("itemtype");
            entity.Property(e => e.Locked)
                .HasColumnType("bigint(10)")
                .HasColumnName("locked");
            entity.Property(e => e.Locktime)
                .HasColumnType("bigint(10)")
                .HasColumnName("locktime");
            entity.Property(e => e.Loggeduser)
                .HasColumnType("bigint(10)")
                .HasColumnName("loggeduser");
            entity.Property(e => e.Multfactor)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'1.00000'")
                .HasColumnName("multfactor");
            entity.Property(e => e.Needsupdate)
                .HasColumnType("bigint(10)")
                .HasColumnName("needsupdate");
            entity.Property(e => e.Oldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("oldid");
            entity.Property(e => e.Outcomeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("outcomeid");
            entity.Property(e => e.Plusfactor)
                .HasPrecision(10, 5)
                .HasColumnName("plusfactor");
            entity.Property(e => e.Scaleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scaleid");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Weightoverride).HasColumnName("weightoverride");
        });

        modelBuilder.Entity<MdlGradeLetter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_letters", tb => tb.HasComment("Repository for grade letters, for courses and other moodle e"));

            entity.HasIndex(e => new { e.Contextid, e.Lowerboundary, e.Letter }, "mdl_gradlett_conlowlet_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Letter)
                .HasDefaultValueSql("''")
                .HasColumnName("letter");
            entity.Property(e => e.Lowerboundary)
                .HasPrecision(10, 5)
                .HasColumnName("lowerboundary");
        });

        modelBuilder.Entity<MdlGradeOutcome>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_outcomes", tb => tb.HasComment("This table describes the outcomes used in the system. An out"));

            entity.HasIndex(e => e.Courseid, "mdl_gradoutc_cou_ix");

            entity.HasIndex(e => new { e.Courseid, e.Shortname }, "mdl_gradoutc_cousho_uix").IsUnique();

            entity.HasIndex(e => e.Scaleid, "mdl_gradoutc_sca_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_gradoutc_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Fullname).HasColumnName("fullname");
            entity.Property(e => e.Scaleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scaleid");
            entity.Property(e => e.Shortname)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlGradeOutcomesCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_outcomes_courses", tb => tb.HasComment("stores what outcomes are used in what courses."));

            entity.HasIndex(e => e.Courseid, "mdl_gradoutccour_cou_ix");

            entity.HasIndex(e => new { e.Courseid, e.Outcomeid }, "mdl_gradoutccour_couout_uix").IsUnique();

            entity.HasIndex(e => e.Outcomeid, "mdl_gradoutccour_out_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Outcomeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("outcomeid");
        });

        modelBuilder.Entity<MdlGradeOutcomesHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_outcomes_history", tb => tb.HasComment("History table"));

            entity.HasIndex(e => e.Action, "mdl_gradoutchist_act_ix");

            entity.HasIndex(e => e.Courseid, "mdl_gradoutchist_cou_ix");

            entity.HasIndex(e => e.Loggeduser, "mdl_gradoutchist_log_ix");

            entity.HasIndex(e => e.Oldid, "mdl_gradoutchist_old_ix");

            entity.HasIndex(e => e.Scaleid, "mdl_gradoutchist_sca_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_gradoutchist_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasColumnType("bigint(10)")
                .HasColumnName("action");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Fullname).HasColumnName("fullname");
            entity.Property(e => e.Loggeduser)
                .HasColumnType("bigint(10)")
                .HasColumnName("loggeduser");
            entity.Property(e => e.Oldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("oldid");
            entity.Property(e => e.Scaleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scaleid");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGradeSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grade_settings", tb => tb.HasComment("gradebook settings"));

            entity.HasIndex(e => e.Courseid, "mdl_gradsett_cou_ix");

            entity.HasIndex(e => new { e.Courseid, e.Name }, "mdl_gradsett_counam_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlGradingArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grading_areas", tb => tb.HasComment("Identifies gradable areas where advanced grading can happen."));

            entity.HasIndex(e => e.Contextid, "mdl_gradarea_con_ix");

            entity.HasIndex(e => new { e.Contextid, e.Component, e.Areaname }, "mdl_gradarea_concomare_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Activemethod)
                .HasMaxLength(100)
                .HasColumnName("activemethod");
            entity.Property(e => e.Areaname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("areaname");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
        });

        modelBuilder.Entity<MdlGradingDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grading_definitions", tb => tb.HasComment("Contains the basic information about an advanced grading for"));

            entity.HasIndex(e => e.Areaid, "mdl_graddefi_are_ix");

            entity.HasIndex(e => new { e.Areaid, e.Method }, "mdl_graddefi_aremet_uix").IsUnique();

            entity.HasIndex(e => e.Usercreated, "mdl_graddefi_use2_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_graddefi_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Areaid)
                .HasColumnType("bigint(10)")
                .HasColumnName("areaid");
            entity.Property(e => e.Copiedfromid)
                .HasColumnType("bigint(10)")
                .HasColumnName("copiedfromid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Method)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("method");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Options).HasColumnName("options");
            entity.Property(e => e.Status)
                .HasColumnType("bigint(10)")
                .HasColumnName("status");
            entity.Property(e => e.Timecopied)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("timecopied");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usercreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("usercreated");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlGradingInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_grading_instances", tb => tb.HasComment("Grading form instance is an assessment record for one gradab"));

            entity.HasIndex(e => e.Definitionid, "mdl_gradinst_def_ix");

            entity.HasIndex(e => e.Raterid, "mdl_gradinst_rat_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Definitionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("definitionid");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Feedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("feedbackformat");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Raterid)
                .HasColumnType("bigint(10)")
                .HasColumnName("raterid");
            entity.Property(e => e.Rawgrade)
                .HasPrecision(10, 5)
                .HasColumnName("rawgrade");
            entity.Property(e => e.Status)
                .HasColumnType("bigint(10)")
                .HasColumnName("status");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGradingformGuideComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_gradingform_guide_comments", tb => tb.HasComment("frequently used comments used in marking guide"));

            entity.HasIndex(e => e.Definitionid, "mdl_gradguidcomm_def_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Definitionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("definitionid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlGradingformGuideCriterion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_gradingform_guide_criteria", tb => tb.HasComment("Stores the rows of the criteria grid."));

            entity.HasIndex(e => e.Definitionid, "mdl_gradguidcrit_def_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Definitionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("definitionid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Descriptionmarkers).HasColumnName("descriptionmarkers");
            entity.Property(e => e.Descriptionmarkersformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionmarkersformat");
            entity.Property(e => e.Maxscore)
                .HasPrecision(10, 5)
                .HasColumnName("maxscore");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlGradingformGuideFilling>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_gradingform_guide_fillings", tb => tb.HasComment("Stores the data of how the guide is filled by a particular r"));

            entity.HasIndex(e => e.Criterionid, "mdl_gradguidfill_cri_ix");

            entity.HasIndex(e => e.Instanceid, "mdl_gradguidfill_ins_ix");

            entity.HasIndex(e => new { e.Instanceid, e.Criterionid }, "mdl_gradguidfill_inscri_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Criterionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("criterionid");
            entity.Property(e => e.Instanceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("instanceid");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Remarkformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("remarkformat");
            entity.Property(e => e.Score)
                .HasPrecision(10, 5)
                .HasColumnName("score");
        });

        modelBuilder.Entity<MdlGradingformRubricCriterion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_gradingform_rubric_criteria", tb => tb.HasComment("Stores the rows of the rubric grid."));

            entity.HasIndex(e => e.Definitionid, "mdl_gradrubrcrit_def_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Definitionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("definitionid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlGradingformRubricFilling>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_gradingform_rubric_fillings", tb => tb.HasComment("Stores the data of how the rubric is filled by a particular "));

            entity.HasIndex(e => e.Criterionid, "mdl_gradrubrfill_cri_ix");

            entity.HasIndex(e => e.Instanceid, "mdl_gradrubrfill_ins_ix");

            entity.HasIndex(e => new { e.Instanceid, e.Criterionid }, "mdl_gradrubrfill_inscri_uix").IsUnique();

            entity.HasIndex(e => e.Levelid, "mdl_gradrubrfill_lev_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Criterionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("criterionid");
            entity.Property(e => e.Instanceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("instanceid");
            entity.Property(e => e.Levelid)
                .HasColumnType("bigint(10)")
                .HasColumnName("levelid");
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Remarkformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("remarkformat");
        });

        modelBuilder.Entity<MdlGradingformRubricLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_gradingform_rubric_levels", tb => tb.HasComment("Stores the columns of the rubric grid."));

            entity.HasIndex(e => e.Criterionid, "mdl_gradrubrleve_cri_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Criterionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("criterionid");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Definitionformat)
                .HasColumnType("bigint(10)")
                .HasColumnName("definitionformat");
            entity.Property(e => e.Score)
                .HasPrecision(10, 5)
                .HasColumnName("score");
        });

        modelBuilder.Entity<MdlGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_groups", tb => tb.HasComment("Each record represents a group."));

            entity.HasIndex(e => e.Courseid, "mdl_grou_cou_ix");

            entity.HasIndex(e => e.Idnumber, "mdl_grou_idn_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Enrolmentkey)
                .HasMaxLength(50)
                .HasColumnName("enrolmentkey");
            entity.Property(e => e.Hidepicture).HasColumnName("hidepicture");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("idnumber");
            entity.Property(e => e.Name)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Picture)
                .HasColumnType("bigint(10)")
                .HasColumnName("picture");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGrouping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_groupings", tb => tb.HasComment("A grouping is a collection of groups. WAS: groups_groupings"));

            entity.HasIndex(e => e.Courseid, "mdl_grou_cou2_ix");

            entity.HasIndex(e => e.Idnumber, "mdl_grou_idn2_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("idnumber");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlGroupingsGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_groupings_groups", tb => tb.HasComment("Link a grouping to a group (note, groups can be in multiple "));

            entity.HasIndex(e => e.Groupid, "mdl_grougrou_gro2_ix");

            entity.HasIndex(e => e.Groupingid, "mdl_grougrou_gro_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Groupingid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupingid");
            entity.Property(e => e.Timeadded)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeadded");
        });

        modelBuilder.Entity<MdlGroupsMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_groups_members", tb => tb.HasComment("Link a user to a group."));

            entity.HasIndex(e => e.Groupid, "mdl_groumemb_gro_ix");

            entity.HasIndex(e => e.Userid, "mdl_groumemb_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Groupid }, "mdl_groumemb_usegro_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Timeadded)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeadded");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlH5p>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_h5p", tb => tb.HasComment("Stores H5P content information"));

            entity.HasIndex(e => e.Mainlibraryid, "mdl_h5p_mai_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contenthash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("contenthash");
            entity.Property(e => e.Displayoptions)
                .HasColumnType("smallint(4)")
                .HasColumnName("displayoptions");
            entity.Property(e => e.Filtered).HasColumnName("filtered");
            entity.Property(e => e.Jsoncontent).HasColumnName("jsoncontent");
            entity.Property(e => e.Mainlibraryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("mainlibraryid");
            entity.Property(e => e.Pathnamehash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("pathnamehash");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlH5pContentsLibrary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_h5p_contents_libraries", tb => tb.HasComment("Store which library is used in which content."));

            entity.HasIndex(e => e.H5pid, "mdl_h5pcontlibr_h5p_ix");

            entity.HasIndex(e => e.Libraryid, "mdl_h5pcontlibr_lib_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Dependencytype)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("dependencytype");
            entity.Property(e => e.Dropcss).HasColumnName("dropcss");
            entity.Property(e => e.H5pid)
                .HasColumnType("bigint(10)")
                .HasColumnName("h5pid");
            entity.Property(e => e.Libraryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("libraryid");
            entity.Property(e => e.Weight)
                .HasColumnType("bigint(10)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<MdlH5pLibrariesCachedasset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_h5p_libraries_cachedassets", tb => tb.HasComment("H5P cached library assets"));

            entity.HasIndex(e => e.Libraryid, "mdl_h5plibrcach_lib_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Hash)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("hash");
            entity.Property(e => e.Libraryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("libraryid");
        });

        modelBuilder.Entity<MdlH5pLibrary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_h5p_libraries", tb => tb.HasComment("Stores information about libraries used by H5P content."));

            entity.HasIndex(e => new { e.Machinename, e.Majorversion, e.Minorversion, e.Patchversion, e.Runnable }, "mdl_h5plibr_macmajminpatrun_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Addto).HasColumnName("addto");
            entity.Property(e => e.Coremajor)
                .HasColumnType("smallint(4)")
                .HasColumnName("coremajor");
            entity.Property(e => e.Coreminor)
                .HasColumnType("smallint(4)")
                .HasColumnName("coreminor");
            entity.Property(e => e.Droplibrarycss).HasColumnName("droplibrarycss");
            entity.Property(e => e.Embedtypes)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("embedtypes");
            entity.Property(e => e.Fullscreen).HasColumnName("fullscreen");
            entity.Property(e => e.Machinename)
                .HasDefaultValueSql("''")
                .HasColumnName("machinename");
            entity.Property(e => e.Majorversion)
                .HasColumnType("smallint(4)")
                .HasColumnName("majorversion");
            entity.Property(e => e.Metadatasettings).HasColumnName("metadatasettings");
            entity.Property(e => e.Minorversion)
                .HasColumnType("smallint(4)")
                .HasColumnName("minorversion");
            entity.Property(e => e.Patchversion)
                .HasColumnType("smallint(4)")
                .HasColumnName("patchversion");
            entity.Property(e => e.Preloadedcss).HasColumnName("preloadedcss");
            entity.Property(e => e.Preloadedjs).HasColumnName("preloadedjs");
            entity.Property(e => e.Runnable).HasColumnName("runnable");
            entity.Property(e => e.Semantics).HasColumnName("semantics");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<MdlH5pLibraryDependency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_h5p_library_dependencies", tb => tb.HasComment("Stores H5P library dependencies"));

            entity.HasIndex(e => e.Libraryid, "mdl_h5plibrdepe_lib_ix");

            entity.HasIndex(e => e.Requiredlibraryid, "mdl_h5plibrdepe_req_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Dependencytype)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("dependencytype");
            entity.Property(e => e.Libraryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("libraryid");
            entity.Property(e => e.Requiredlibraryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("requiredlibraryid");
        });

        modelBuilder.Entity<MdlH5pactivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_h5pactivity", tb => tb.HasComment("Stores the h5pactivity activity module instances."));

            entity.HasIndex(e => e.Course, "mdl_h5pa_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Displayoptions)
                .HasColumnType("smallint(4)")
                .HasColumnName("displayoptions");
            entity.Property(e => e.Enabletracking)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabletracking");
            entity.Property(e => e.Grade)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Grademethod)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("grademethod");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Reviewmode)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("reviewmode");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlH5pactivityAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_h5pactivity_attempts", tb => tb.HasComment("Users attempts inside H5P activities"));

            entity.HasIndex(e => e.H5pactivityid, "mdl_h5paatte_h5p_ix");

            entity.HasIndex(e => new { e.H5pactivityid, e.Timecreated }, "mdl_h5paatte_h5ptim_ix");

            entity.HasIndex(e => new { e.H5pactivityid, e.Userid }, "mdl_h5paatte_h5puse_ix");

            entity.HasIndex(e => new { e.H5pactivityid, e.Userid, e.Attempt }, "mdl_h5paatte_h5puseatt_uix").IsUnique();

            entity.HasIndex(e => e.Timecreated, "mdl_h5paatte_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attempt)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("attempt");
            entity.Property(e => e.Completion).HasColumnName("completion");
            entity.Property(e => e.Duration)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("duration");
            entity.Property(e => e.H5pactivityid)
                .HasColumnType("bigint(10)")
                .HasColumnName("h5pactivityid");
            entity.Property(e => e.Maxscore)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("maxscore");
            entity.Property(e => e.Rawscore)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("rawscore");
            entity.Property(e => e.Scaled)
                .HasPrecision(10, 5)
                .HasColumnName("scaled");
            entity.Property(e => e.Success).HasColumnName("success");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(20)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlH5pactivityAttemptsResult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_h5pactivity_attempts_results", tb => tb.HasComment("H5Pactivities_attempts tracking info"));

            entity.HasIndex(e => e.Attemptid, "mdl_h5paatteresu_att_ix");

            entity.HasIndex(e => new { e.Attemptid, e.Timecreated }, "mdl_h5paatteresu_atttim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Additionals).HasColumnName("additionals");
            entity.Property(e => e.Attemptid)
                .HasColumnType("bigint(10)")
                .HasColumnName("attemptid");
            entity.Property(e => e.Completion).HasColumnName("completion");
            entity.Property(e => e.Correctpattern).HasColumnName("correctpattern");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Duration)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("duration");
            entity.Property(e => e.Interactiontype)
                .HasMaxLength(128)
                .HasColumnName("interactiontype");
            entity.Property(e => e.Maxscore)
                .HasColumnType("bigint(10)")
                .HasColumnName("maxscore");
            entity.Property(e => e.Rawscore)
                .HasColumnType("bigint(10)")
                .HasColumnName("rawscore");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.Subcontent)
                .HasMaxLength(128)
                .HasColumnName("subcontent");
            entity.Property(e => e.Success).HasColumnName("success");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlImscp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_imscp", tb => tb.HasComment("each record is one imscp resource"));

            entity.HasIndex(e => e.Course, "mdl_imsc_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Keepold)
                .HasDefaultValueSql("-1")
                .HasColumnType("bigint(10)")
                .HasColumnName("keepold");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Revision)
                .HasColumnType("bigint(10)")
                .HasColumnName("revision");
            entity.Property(e => e.Structure).HasColumnName("structure");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlLabel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_label", tb => tb.HasComment("Defines labels"));

            entity.HasIndex(e => e.Course, "mdl_labe_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlLesson>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lesson", tb => tb.HasComment("Defines lesson"));

            entity.HasIndex(e => e.Course, "mdl_less_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Activitylink)
                .HasColumnType("bigint(10)")
                .HasColumnName("activitylink");
            entity.Property(e => e.Allowofflineattempts)
                .HasDefaultValueSql("'0'")
                .HasColumnName("allowofflineattempts");
            entity.Property(e => e.Available)
                .HasColumnType("bigint(10)")
                .HasColumnName("available");
            entity.Property(e => e.Bgcolor)
                .HasMaxLength(7)
                .HasDefaultValueSql("'#FFFFFF'")
                .HasColumnName("bgcolor");
            entity.Property(e => e.Completionendreached)
                .HasDefaultValueSql("'0'")
                .HasColumnName("completionendreached");
            entity.Property(e => e.Completiontimespent)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(11)")
                .HasColumnName("completiontimespent");
            entity.Property(e => e.Conditions).HasColumnName("conditions");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Custom)
                .HasColumnType("smallint(3)")
                .HasColumnName("custom");
            entity.Property(e => e.Deadline)
                .HasColumnType("bigint(10)")
                .HasColumnName("deadline");
            entity.Property(e => e.Dependency)
                .HasColumnType("bigint(10)")
                .HasColumnName("dependency");
            entity.Property(e => e.Displayleft)
                .HasColumnType("smallint(3)")
                .HasColumnName("displayleft");
            entity.Property(e => e.Displayleftif)
                .HasColumnType("smallint(3)")
                .HasColumnName("displayleftif");
            entity.Property(e => e.Feedback)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(3)")
                .HasColumnName("feedback");
            entity.Property(e => e.Grade)
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Height)
                .HasDefaultValueSql("'480'")
                .HasColumnType("bigint(10)")
                .HasColumnName("height");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Maxanswers)
                .HasDefaultValueSql("'4'")
                .HasColumnType("smallint(3)")
                .HasColumnName("maxanswers");
            entity.Property(e => e.Maxattempts)
                .HasDefaultValueSql("'5'")
                .HasColumnType("smallint(3)")
                .HasColumnName("maxattempts");
            entity.Property(e => e.Maxpages)
                .HasColumnType("smallint(3)")
                .HasColumnName("maxpages");
            entity.Property(e => e.Mediaclose)
                .HasColumnType("smallint(3)")
                .HasColumnName("mediaclose");
            entity.Property(e => e.Mediafile)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("mediafile");
            entity.Property(e => e.Mediaheight)
                .HasDefaultValueSql("'100'")
                .HasColumnType("bigint(10)")
                .HasColumnName("mediaheight");
            entity.Property(e => e.Mediawidth)
                .HasDefaultValueSql("'650'")
                .HasColumnType("bigint(10)")
                .HasColumnName("mediawidth");
            entity.Property(e => e.Minquestions)
                .HasColumnType("smallint(3)")
                .HasColumnName("minquestions");
            entity.Property(e => e.Modattempts)
                .HasColumnType("smallint(3)")
                .HasColumnName("modattempts");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Nextpagedefault)
                .HasColumnType("smallint(3)")
                .HasColumnName("nextpagedefault");
            entity.Property(e => e.Ongoing)
                .HasColumnType("smallint(3)")
                .HasColumnName("ongoing");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
            entity.Property(e => e.Practice)
                .HasColumnType("smallint(3)")
                .HasColumnName("practice");
            entity.Property(e => e.Progressbar)
                .HasColumnType("smallint(3)")
                .HasColumnName("progressbar");
            entity.Property(e => e.Retake)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(3)")
                .HasColumnName("retake");
            entity.Property(e => e.Review)
                .HasColumnType("smallint(3)")
                .HasColumnName("review");
            entity.Property(e => e.Slideshow)
                .HasColumnType("smallint(3)")
                .HasColumnName("slideshow");
            entity.Property(e => e.Timelimit)
                .HasColumnType("bigint(10)")
                .HasColumnName("timelimit");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usemaxgrade)
                .HasColumnType("smallint(3)")
                .HasColumnName("usemaxgrade");
            entity.Property(e => e.Usepassword)
                .HasColumnType("smallint(3)")
                .HasColumnName("usepassword");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("'640'")
                .HasColumnType("bigint(10)")
                .HasColumnName("width");
        });

        modelBuilder.Entity<MdlLessonAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lesson_answers", tb => tb.HasComment("Defines lesson_answers"));

            entity.HasIndex(e => e.Lessonid, "mdl_lessansw_les_ix");

            entity.HasIndex(e => e.Pageid, "mdl_lessansw_pag_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Answerformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("answerformat");
            entity.Property(e => e.Flags)
                .HasColumnType("smallint(3)")
                .HasColumnName("flags");
            entity.Property(e => e.Grade)
                .HasColumnType("smallint(4)")
                .HasColumnName("grade");
            entity.Property(e => e.Jumpto)
                .HasColumnType("bigint(11)")
                .HasColumnName("jumpto");
            entity.Property(e => e.Lessonid)
                .HasColumnType("bigint(10)")
                .HasColumnName("lessonid");
            entity.Property(e => e.Pageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("pageid");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.Responseformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("responseformat");
            entity.Property(e => e.Score)
                .HasColumnType("bigint(10)")
                .HasColumnName("score");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlLessonAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lesson_attempts", tb => tb.HasComment("Defines lesson_attempts"));

            entity.HasIndex(e => e.Answerid, "mdl_lessatte_ans_ix");

            entity.HasIndex(e => e.Lessonid, "mdl_lessatte_les_ix");

            entity.HasIndex(e => e.Pageid, "mdl_lessatte_pag_ix");

            entity.HasIndex(e => e.Userid, "mdl_lessatte_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("answerid");
            entity.Property(e => e.Correct)
                .HasColumnType("bigint(10)")
                .HasColumnName("correct");
            entity.Property(e => e.Lessonid)
                .HasColumnType("bigint(10)")
                .HasColumnName("lessonid");
            entity.Property(e => e.Pageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("pageid");
            entity.Property(e => e.Retry)
                .HasColumnType("smallint(3)")
                .HasColumnName("retry");
            entity.Property(e => e.Timeseen)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeseen");
            entity.Property(e => e.Useranswer).HasColumnName("useranswer");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLessonBranch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lesson_branch", tb => tb.HasComment("branches for each lesson/user"));

            entity.HasIndex(e => e.Lessonid, "mdl_lessbran_les_ix");

            entity.HasIndex(e => e.Pageid, "mdl_lessbran_pag_ix");

            entity.HasIndex(e => e.Userid, "mdl_lessbran_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Flag)
                .HasColumnType("smallint(3)")
                .HasColumnName("flag");
            entity.Property(e => e.Lessonid)
                .HasColumnType("bigint(10)")
                .HasColumnName("lessonid");
            entity.Property(e => e.Nextpageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("nextpageid");
            entity.Property(e => e.Pageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("pageid");
            entity.Property(e => e.Retry)
                .HasColumnType("bigint(10)")
                .HasColumnName("retry");
            entity.Property(e => e.Timeseen)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeseen");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLessonGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lesson_grades", tb => tb.HasComment("Defines lesson_grades"));

            entity.HasIndex(e => e.Lessonid, "mdl_lessgrad_les_ix");

            entity.HasIndex(e => e.Userid, "mdl_lessgrad_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Completed)
                .HasColumnType("bigint(10)")
                .HasColumnName("completed");
            entity.Property(e => e.Grade).HasColumnName("grade");
            entity.Property(e => e.Late)
                .HasColumnType("smallint(3)")
                .HasColumnName("late");
            entity.Property(e => e.Lessonid)
                .HasColumnType("bigint(10)")
                .HasColumnName("lessonid");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLessonOverride>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lesson_overrides", tb => tb.HasComment("The overrides to lesson settings."));

            entity.HasIndex(e => e.Groupid, "mdl_lessover_gro_ix");

            entity.HasIndex(e => e.Lessonid, "mdl_lessover_les_ix");

            entity.HasIndex(e => e.Userid, "mdl_lessover_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Available)
                .HasColumnType("bigint(10)")
                .HasColumnName("available");
            entity.Property(e => e.Deadline)
                .HasColumnType("bigint(10)")
                .HasColumnName("deadline");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Lessonid)
                .HasColumnType("bigint(10)")
                .HasColumnName("lessonid");
            entity.Property(e => e.Maxattempts)
                .HasColumnType("smallint(3)")
                .HasColumnName("maxattempts");
            entity.Property(e => e.Password)
                .HasMaxLength(32)
                .HasColumnName("password");
            entity.Property(e => e.Retake)
                .HasColumnType("smallint(3)")
                .HasColumnName("retake");
            entity.Property(e => e.Review)
                .HasColumnType("smallint(3)")
                .HasColumnName("review");
            entity.Property(e => e.Timelimit)
                .HasColumnType("bigint(10)")
                .HasColumnName("timelimit");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLessonPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lesson_pages", tb => tb.HasComment("Defines lesson_pages"));

            entity.HasIndex(e => e.Lessonid, "mdl_lesspage_les_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contents).HasColumnName("contents");
            entity.Property(e => e.Contentsformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("contentsformat");
            entity.Property(e => e.Display)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(3)")
                .HasColumnName("display");
            entity.Property(e => e.Layout)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(3)")
                .HasColumnName("layout");
            entity.Property(e => e.Lessonid)
                .HasColumnType("bigint(10)")
                .HasColumnName("lessonid");
            entity.Property(e => e.Nextpageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("nextpageid");
            entity.Property(e => e.Prevpageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("prevpageid");
            entity.Property(e => e.Qoption)
                .HasColumnType("smallint(3)")
                .HasColumnName("qoption");
            entity.Property(e => e.Qtype)
                .HasColumnType("smallint(3)")
                .HasColumnName("qtype");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<MdlLessonTimer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lesson_timer", tb => tb.HasComment("lesson timer for each lesson"));

            entity.HasIndex(e => e.Lessonid, "mdl_lesstime_les_ix");

            entity.HasIndex(e => e.Userid, "mdl_lesstime_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Completed)
                .HasDefaultValueSql("'0'")
                .HasColumnName("completed");
            entity.Property(e => e.Lessonid)
                .HasColumnType("bigint(10)")
                .HasColumnName("lessonid");
            entity.Property(e => e.Lessontime)
                .HasColumnType("bigint(10)")
                .HasColumnName("lessontime");
            entity.Property(e => e.Starttime)
                .HasColumnType("bigint(10)")
                .HasColumnName("starttime");
            entity.Property(e => e.Timemodifiedoffline)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodifiedoffline");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLicense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_license", tb => tb.HasComment("store licenses used by moodle"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Custom).HasColumnName("custom");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabled");
            entity.Property(e => e.Fullname).HasColumnName("fullname");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(5)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Version)
                .HasColumnType("bigint(10)")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlLockDb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lock_db", tb => tb.HasComment("Stores active and inactive lock types for db locking method."));

            entity.HasIndex(e => e.Expires, "mdl_lockdb_exp_ix");

            entity.HasIndex(e => e.Owner, "mdl_lockdb_own_ix");

            entity.HasIndex(e => e.Resourcekey, "mdl_lockdb_res_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Expires)
                .HasColumnType("bigint(10)")
                .HasColumnName("expires");
            entity.Property(e => e.Owner)
                .HasMaxLength(36)
                .HasColumnName("owner");
            entity.Property(e => e.Resourcekey)
                .HasDefaultValueSql("''")
                .HasColumnName("resourcekey");
        });

        modelBuilder.Entity<MdlLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_log", tb => tb.HasComment("Every action is logged as far as possible"));

            entity.HasIndex(e => e.Action, "mdl_log_act_ix");

            entity.HasIndex(e => e.Cmid, "mdl_log_cmi_ix");

            entity.HasIndex(e => new { e.Course, e.Module, e.Action }, "mdl_log_coumodact_ix");

            entity.HasIndex(e => e.Time, "mdl_log_tim_ix");

            entity.HasIndex(e => new { e.Userid, e.Course }, "mdl_log_usecou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Cmid)
                .HasColumnType("bigint(10)")
                .HasColumnName("cmid");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Info)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("info");
            entity.Property(e => e.Ip)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ip");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("module");
            entity.Property(e => e.Time)
                .HasColumnType("bigint(10)")
                .HasColumnName("time");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLogDisplay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_log_display", tb => tb.HasComment("For a particular module/action, specifies a moodle table/fie"));

            entity.HasIndex(e => new { e.Module, e.Action }, "mdl_logdisp_modact_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Field)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("field");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("module");
            entity.Property(e => e.Mtable)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("mtable");
        });

        modelBuilder.Entity<MdlLogQuery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_log_queries", tb => tb.HasComment("Logged database queries."));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Backtrace).HasColumnName("backtrace");
            entity.Property(e => e.Error)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(5)")
                .HasColumnName("error");
            entity.Property(e => e.Exectime)
                .HasPrecision(10, 5)
                .HasColumnName("exectime");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Qtype)
                .HasColumnType("mediumint(5)")
                .HasColumnName("qtype");
            entity.Property(e => e.Sqlparams).HasColumnName("sqlparams");
            entity.Property(e => e.Sqltext).HasColumnName("sqltext");
            entity.Property(e => e.Timelogged)
                .HasColumnType("bigint(10)")
                .HasColumnName("timelogged");
        });

        modelBuilder.Entity<MdlLogstoreStandardLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_logstore_standard_log", tb => tb.HasComment("Standard log table"));

            entity.HasIndex(e => e.Contextid, "mdl_logsstanlog_con_ix");

            entity.HasIndex(e => new { e.Courseid, e.Anonymous, e.Timecreated }, "mdl_logsstanlog_couanotim_ix");

            entity.HasIndex(e => e.Timecreated, "mdl_logsstanlog_tim_ix");

            entity.HasIndex(e => new { e.Userid, e.Contextlevel, e.Contextinstanceid, e.Crud, e.Edulevel, e.Timecreated }, "mdl_logsstanlog_useconconcr_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Anonymous).HasColumnName("anonymous");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Contextinstanceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextinstanceid");
            entity.Property(e => e.Contextlevel)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextlevel");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Crud)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .HasColumnName("crud");
            entity.Property(e => e.Edulevel).HasColumnName("edulevel");
            entity.Property(e => e.Eventname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("eventname");
            entity.Property(e => e.Ip)
                .HasMaxLength(45)
                .HasColumnName("ip");
            entity.Property(e => e.Objectid)
                .HasColumnType("bigint(10)")
                .HasColumnName("objectid");
            entity.Property(e => e.Objecttable)
                .HasMaxLength(50)
                .HasColumnName("objecttable");
            entity.Property(e => e.Origin)
                .HasMaxLength(10)
                .HasColumnName("origin");
            entity.Property(e => e.Other).HasColumnName("other");
            entity.Property(e => e.Realuserid)
                .HasColumnType("bigint(10)")
                .HasColumnName("realuserid");
            entity.Property(e => e.Relateduserid)
                .HasColumnType("bigint(10)")
                .HasColumnName("relateduserid");
            entity.Property(e => e.Target)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("target");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLti>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lti", tb => tb.HasComment("This table contains Basic LTI activities instances"));

            entity.HasIndex(e => e.Course, "mdl_lti_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Debuglaunch).HasColumnName("debuglaunch");
            entity.Property(e => e.Grade)
                .HasDefaultValueSql("'100'")
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Icon).HasColumnName("icon");
            entity.Property(e => e.Instructorchoiceacceptgrades).HasColumnName("instructorchoiceacceptgrades");
            entity.Property(e => e.Instructorchoiceallowroster).HasColumnName("instructorchoiceallowroster");
            entity.Property(e => e.Instructorchoiceallowsetting).HasColumnName("instructorchoiceallowsetting");
            entity.Property(e => e.Instructorchoicesendemailaddr).HasColumnName("instructorchoicesendemailaddr");
            entity.Property(e => e.Instructorchoicesendname).HasColumnName("instructorchoicesendname");
            entity.Property(e => e.Instructorcustomparameters).HasColumnName("instructorcustomparameters");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Launchcontainer)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("launchcontainer");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Resourcekey)
                .HasMaxLength(255)
                .HasColumnName("resourcekey");
            entity.Property(e => e.Secureicon).HasColumnName("secureicon");
            entity.Property(e => e.Securetoolurl).HasColumnName("securetoolurl");
            entity.Property(e => e.Servicesalt)
                .HasMaxLength(40)
                .HasColumnName("servicesalt");
            entity.Property(e => e.Showdescriptionlaunch).HasColumnName("showdescriptionlaunch");
            entity.Property(e => e.Showtitlelaunch).HasColumnName("showtitlelaunch");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Toolurl).HasColumnName("toolurl");
            entity.Property(e => e.Typeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("typeid");
        });

        modelBuilder.Entity<MdlLtiAccessToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lti_access_tokens", tb => tb.HasComment("Security tokens for accessing of LTI services"));

            entity.HasIndex(e => e.Token, "mdl_ltiaccetoke_tok_uix").IsUnique();

            entity.HasIndex(e => e.Typeid, "mdl_ltiaccetoke_typ_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Lastaccess)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastaccess");
            entity.Property(e => e.Scope).HasColumnName("scope");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Token)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
            entity.Property(e => e.Typeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("typeid");
            entity.Property(e => e.Validuntil)
                .HasColumnType("bigint(10)")
                .HasColumnName("validuntil");
        });

        modelBuilder.Entity<MdlLtiSubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lti_submission", tb => tb.HasComment("Keeps track of individual submissions for LTI activities."));

            entity.HasIndex(e => e.Ltiid, "mdl_ltisubm_lti_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Datesubmitted)
                .HasColumnType("bigint(10)")
                .HasColumnName("datesubmitted");
            entity.Property(e => e.Dateupdated)
                .HasColumnType("bigint(10)")
                .HasColumnName("dateupdated");
            entity.Property(e => e.Gradepercent)
                .HasPrecision(10, 5)
                .HasColumnName("gradepercent");
            entity.Property(e => e.Launchid)
                .HasColumnType("bigint(10)")
                .HasColumnName("launchid");
            entity.Property(e => e.Ltiid)
                .HasColumnType("bigint(10)")
                .HasColumnName("ltiid");
            entity.Property(e => e.Originalgrade)
                .HasPrecision(10, 5)
                .HasColumnName("originalgrade");
            entity.Property(e => e.State)
                .HasColumnType("tinyint(2)")
                .HasColumnName("state");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlLtiToolProxy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lti_tool_proxies", tb => tb.HasComment("LTI tool proxy registrations"));

            entity.HasIndex(e => e.Guid, "mdl_ltitoolprox_gui_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Capabilityoffered).HasColumnName("capabilityoffered");
            entity.Property(e => e.Createdby)
                .HasColumnType("bigint(10)")
                .HasColumnName("createdby");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Tool Provider'")
                .HasColumnName("name");
            entity.Property(e => e.Regurl).HasColumnName("regurl");
            entity.Property(e => e.Secret)
                .HasMaxLength(255)
                .HasColumnName("secret");
            entity.Property(e => e.Serviceoffered).HasColumnName("serviceoffered");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("state");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Toolproxy).HasColumnName("toolproxy");
            entity.Property(e => e.Vendorcode)
                .HasMaxLength(255)
                .HasColumnName("vendorcode");
        });

        modelBuilder.Entity<MdlLtiToolSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lti_tool_settings", tb => tb.HasComment("LTI tool setting values"));

            entity.HasIndex(e => e.Coursemoduleid, "mdl_ltitoolsett_cou2_ix");

            entity.HasIndex(e => e.Course, "mdl_ltitoolsett_cou_ix");

            entity.HasIndex(e => e.Toolproxyid, "mdl_ltitoolsett_too_ix");

            entity.HasIndex(e => e.Typeid, "mdl_ltitoolsett_typ_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Coursemoduleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("coursemoduleid");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Toolproxyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("toolproxyid");
            entity.Property(e => e.Typeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("typeid");
        });

        modelBuilder.Entity<MdlLtiType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lti_types", tb => tb.HasComment("Basic LTI pre-configured activities"));

            entity.HasIndex(e => e.Clientid, "mdl_ltitype_cli_uix").IsUnique();

            entity.HasIndex(e => e.Course, "mdl_ltitype_cou_ix");

            entity.HasIndex(e => e.Tooldomain, "mdl_ltitype_too_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Baseurl).HasColumnName("baseurl");
            entity.Property(e => e.Clientid).HasColumnName("clientid");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Coursevisible).HasColumnName("coursevisible");
            entity.Property(e => e.Createdby)
                .HasColumnType("bigint(10)")
                .HasColumnName("createdby");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Enabledcapability).HasColumnName("enabledcapability");
            entity.Property(e => e.Icon).HasColumnName("icon");
            entity.Property(e => e.Ltiversion)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("ltiversion");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("'basiclti Activity'")
                .HasColumnName("name");
            entity.Property(e => e.Parameter).HasColumnName("parameter");
            entity.Property(e => e.Secureicon).HasColumnName("secureicon");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'2'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("state");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Tooldomain)
                .HasDefaultValueSql("''")
                .HasColumnName("tooldomain");
            entity.Property(e => e.Toolproxyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("toolproxyid");
        });

        modelBuilder.Entity<MdlLtiTypesConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_lti_types_config", tb => tb.HasComment("Basic LTI types configuration"));

            entity.HasIndex(e => e.Typeid, "mdl_ltitypeconf_typ_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Typeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("typeid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlLtiserviceGradebookservice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_ltiservice_gradebookservices", tb => tb.HasComment("This file records the grade items created by the LTI Gradebo"));

            entity.HasIndex(e => new { e.Gradeitemid, e.Courseid }, "mdl_ltisgrad_gracou_ix");

            entity.HasIndex(e => e.Ltilinkid, "mdl_ltisgrad_lti_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Baseurl).HasColumnName("baseurl");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Gradeitemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("gradeitemid");
            entity.Property(e => e.Ltilinkid)
                .HasColumnType("bigint(10)")
                .HasColumnName("ltilinkid");
            entity.Property(e => e.Resourceid)
                .HasMaxLength(512)
                .HasColumnName("resourceid");
            entity.Property(e => e.Tag)
                .HasMaxLength(255)
                .HasColumnName("tag");
            entity.Property(e => e.Toolproxyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("toolproxyid");
            entity.Property(e => e.Typeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("typeid");
        });

        modelBuilder.Entity<MdlMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message", tb => tb.HasComment("Stores all unread messages"));

            entity.HasIndex(e => new { e.Useridto, e.Timeusertodeleted, e.Notification }, "mdl_mess_usetimnot2_ix");

            entity.HasIndex(e => new { e.Useridfrom, e.Timeuserfromdeleted, e.Notification }, "mdl_mess_usetimnot_ix");

            entity.HasIndex(e => new { e.Useridfrom, e.Useridto, e.Timeuserfromdeleted, e.Timeusertodeleted }, "mdl_mess_useusetimtim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Contexturl).HasColumnName("contexturl");
            entity.Property(e => e.Contexturlname).HasColumnName("contexturlname");
            entity.Property(e => e.Customdata).HasColumnName("customdata");
            entity.Property(e => e.Eventtype)
                .HasMaxLength(100)
                .HasColumnName("eventtype");
            entity.Property(e => e.Fullmessage).HasColumnName("fullmessage");
            entity.Property(e => e.Fullmessageformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(4)")
                .HasColumnName("fullmessageformat");
            entity.Property(e => e.Fullmessagehtml).HasColumnName("fullmessagehtml");
            entity.Property(e => e.Notification)
                .HasDefaultValueSql("'0'")
                .HasColumnName("notification");
            entity.Property(e => e.Smallmessage).HasColumnName("smallmessage");
            entity.Property(e => e.Subject).HasColumnName("subject");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timeuserfromdeleted)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeuserfromdeleted");
            entity.Property(e => e.Timeusertodeleted)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeusertodeleted");
            entity.Property(e => e.Useridfrom)
                .HasColumnType("bigint(10)")
                .HasColumnName("useridfrom");
            entity.Property(e => e.Useridto)
                .HasColumnType("bigint(10)")
                .HasColumnName("useridto");
        });

        modelBuilder.Entity<MdlMessage1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_messages", tb => tb.HasComment("Stores all messages"));

            entity.HasIndex(e => e.Conversationid, "mdl_mess_con_ix");

            entity.HasIndex(e => new { e.Conversationid, e.Timecreated }, "mdl_mess_contim_ix");

            entity.HasIndex(e => e.Useridfrom, "mdl_mess_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Conversationid)
                .HasColumnType("bigint(10)")
                .HasColumnName("conversationid");
            entity.Property(e => e.Customdata).HasColumnName("customdata");
            entity.Property(e => e.Fullmessage).HasColumnName("fullmessage");
            entity.Property(e => e.Fullmessageformat).HasColumnName("fullmessageformat");
            entity.Property(e => e.Fullmessagehtml).HasColumnName("fullmessagehtml");
            entity.Property(e => e.Fullmessagetrust)
                .HasColumnType("tinyint(2)")
                .HasColumnName("fullmessagetrust");
            entity.Property(e => e.Smallmessage).HasColumnName("smallmessage");
            entity.Property(e => e.Subject).HasColumnName("subject");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Useridfrom)
                .HasColumnType("bigint(10)")
                .HasColumnName("useridfrom");
        });

        modelBuilder.Entity<MdlMessageAirnotifierDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_airnotifier_devices", tb => tb.HasComment("Store information about the devices registered in Airnotifie"));

            entity.HasIndex(e => e.Userdeviceid, "mdl_messairndevi_use_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Enable)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enable");
            entity.Property(e => e.Userdeviceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userdeviceid");
        });

        modelBuilder.Entity<MdlMessageContact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_contacts", tb => tb.HasComment("Maintains lists of contacts between users"));

            entity.HasIndex(e => e.Contactid, "mdl_messcont_con_ix");

            entity.HasIndex(e => e.Userid, "mdl_messcont_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Contactid }, "mdl_messcont_usecon_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contactid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contactid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageContactRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_contact_requests", tb => tb.HasComment("Maintains list of contact requests between users"));

            entity.HasIndex(e => e.Requesteduserid, "mdl_messcontrequ_req_ix");

            entity.HasIndex(e => e.Userid, "mdl_messcontrequ_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Requesteduserid }, "mdl_messcontrequ_usereq_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Requesteduserid)
                .HasColumnType("bigint(10)")
                .HasColumnName("requesteduserid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageConversation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_conversations", tb => tb.HasComment("Stores all message conversations"));

            entity.HasIndex(e => new { e.Component, e.Itemtype, e.Itemid, e.Contextid }, "mdl_messconv_comiteitecon_ix");

            entity.HasIndex(e => e.Contextid, "mdl_messconv_con2_ix");

            entity.HasIndex(e => e.Convhash, "mdl_messconv_con_ix");

            entity.HasIndex(e => e.Type, "mdl_messconv_typ_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Convhash)
                .HasMaxLength(40)
                .HasColumnName("convhash");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(100)
                .HasColumnName("itemtype");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlMessageConversationAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_conversation_actions", tb => tb.HasComment("Stores all per-user actions on individual conversations"));

            entity.HasIndex(e => e.Conversationid, "mdl_messconvacti_con_ix");

            entity.HasIndex(e => e.Userid, "mdl_messconvacti_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasColumnType("bigint(10)")
                .HasColumnName("action");
            entity.Property(e => e.Conversationid)
                .HasColumnType("bigint(10)")
                .HasColumnName("conversationid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageConversationMember>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_conversation_members", tb => tb.HasComment("Stores all members in a conversations"));

            entity.HasIndex(e => e.Conversationid, "mdl_messconvmemb_con_ix");

            entity.HasIndex(e => e.Userid, "mdl_messconvmemb_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Conversationid)
                .HasColumnType("bigint(10)")
                .HasColumnName("conversationid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageEmailMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_email_messages", tb => tb.HasComment("Keeps track of what emails to send in an email digest"));

            entity.HasIndex(e => e.Conversationid, "mdl_messemaimess_con_ix");

            entity.HasIndex(e => e.Messageid, "mdl_messemaimess_mes_ix");

            entity.HasIndex(e => e.Useridto, "mdl_messemaimess_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Conversationid)
                .HasColumnType("bigint(10)")
                .HasColumnName("conversationid");
            entity.Property(e => e.Messageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("messageid");
            entity.Property(e => e.Useridto)
                .HasColumnType("bigint(10)")
                .HasColumnName("useridto");
        });

        modelBuilder.Entity<MdlMessagePopup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_popup", tb => tb.HasComment("Keep state of notifications for the popup message processor"));

            entity.HasIndex(e => e.Isread, "mdl_messpopu_isr_ix");

            entity.HasIndex(e => new { e.Messageid, e.Isread }, "mdl_messpopu_mesisr_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Isread).HasColumnName("isread");
            entity.Property(e => e.Messageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("messageid");
        });

        modelBuilder.Entity<MdlMessagePopupNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_popup_notifications", tb => tb.HasComment("List of notifications to display in the message output popup"));

            entity.HasIndex(e => e.Notificationid, "mdl_messpopunoti_not_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Notificationid)
                .HasColumnType("bigint(10)")
                .HasColumnName("notificationid");
        });

        modelBuilder.Entity<MdlMessageProcessor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_processors", tb => tb.HasComment("List of message output plugins"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(166)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<MdlMessageProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_providers", tb => tb.HasComment("This table stores the message providers (modules and core sy"));

            entity.HasIndex(e => new { e.Component, e.Name }, "mdl_messprov_comnam_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Capability)
                .HasMaxLength(255)
                .HasColumnName("capability");
            entity.Property(e => e.Component)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<MdlMessageRead>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_read", tb => tb.HasComment("Stores all messages that have been read"));

            entity.HasIndex(e => new { e.Notification, e.Timeread }, "mdl_messread_nottim_ix");

            entity.HasIndex(e => new { e.Useridto, e.Timeusertodeleted, e.Notification }, "mdl_messread_usetimnot2_ix");

            entity.HasIndex(e => new { e.Useridfrom, e.Timeuserfromdeleted, e.Notification }, "mdl_messread_usetimnot_ix");

            entity.HasIndex(e => new { e.Useridfrom, e.Useridto, e.Timeuserfromdeleted, e.Timeusertodeleted }, "mdl_messread_useusetimtim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Contexturl).HasColumnName("contexturl");
            entity.Property(e => e.Contexturlname).HasColumnName("contexturlname");
            entity.Property(e => e.Eventtype)
                .HasMaxLength(100)
                .HasColumnName("eventtype");
            entity.Property(e => e.Fullmessage).HasColumnName("fullmessage");
            entity.Property(e => e.Fullmessageformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(4)")
                .HasColumnName("fullmessageformat");
            entity.Property(e => e.Fullmessagehtml).HasColumnName("fullmessagehtml");
            entity.Property(e => e.Notification)
                .HasDefaultValueSql("'0'")
                .HasColumnName("notification");
            entity.Property(e => e.Smallmessage).HasColumnName("smallmessage");
            entity.Property(e => e.Subject).HasColumnName("subject");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timeread)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeread");
            entity.Property(e => e.Timeuserfromdeleted)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeuserfromdeleted");
            entity.Property(e => e.Timeusertodeleted)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeusertodeleted");
            entity.Property(e => e.Useridfrom)
                .HasColumnType("bigint(10)")
                .HasColumnName("useridfrom");
            entity.Property(e => e.Useridto)
                .HasColumnType("bigint(10)")
                .HasColumnName("useridto");
        });

        modelBuilder.Entity<MdlMessageUserAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_user_actions", tb => tb.HasComment("Stores all per-user actions on individual messages"));

            entity.HasIndex(e => e.Messageid, "mdl_messuseracti_mes_ix");

            entity.HasIndex(e => e.Userid, "mdl_messuseracti_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Messageid, e.Action }, "mdl_messuseracti_usemesact_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasColumnType("bigint(10)")
                .HasColumnName("action");
            entity.Property(e => e.Messageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("messageid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageUsersBlocked>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_message_users_blocked", tb => tb.HasComment("Maintains lists of blocked users"));

            entity.HasIndex(e => e.Blockeduserid, "mdl_messuserbloc_blo_ix");

            entity.HasIndex(e => e.Userid, "mdl_messuserbloc_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Blockeduserid }, "mdl_messuserbloc_useblo_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Blockeduserid)
                .HasColumnType("bigint(10)")
                .HasColumnName("blockeduserid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMessageinboundDatakey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_messageinbound_datakeys", tb => tb.HasComment("Inbound Message data item secret keys."));

            entity.HasIndex(e => e.Handler, "mdl_messdata_han_ix");

            entity.HasIndex(e => new { e.Handler, e.Datavalue }, "mdl_messdata_handat_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Datakey)
                .HasMaxLength(64)
                .HasColumnName("datakey");
            entity.Property(e => e.Datavalue)
                .HasColumnType("bigint(10)")
                .HasColumnName("datavalue");
            entity.Property(e => e.Expires)
                .HasColumnType("bigint(10)")
                .HasColumnName("expires");
            entity.Property(e => e.Handler)
                .HasColumnType("bigint(10)")
                .HasColumnName("handler");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlMessageinboundHandler>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_messageinbound_handlers", tb => tb.HasComment("Inbound Message Handler definitions."));

            entity.HasIndex(e => e.Classname, "mdl_messhand_cla_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Classname)
                .HasDefaultValueSql("''")
                .HasColumnName("classname");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Defaultexpiration)
                .HasDefaultValueSql("'86400'")
                .HasColumnType("bigint(10)")
                .HasColumnName("defaultexpiration");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Validateaddress)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("validateaddress");
        });

        modelBuilder.Entity<MdlMessageinboundMessagelist>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_messageinbound_messagelist", tb => tb.HasComment("A list of message IDs for existing replies"));

            entity.HasIndex(e => e.Userid, "mdl_messmess_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Messageid).HasColumnName("messageid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMnetApplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnet_application", tb => tb.HasComment("Information about applications on remote hosts"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.DisplayName)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("display_name");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.SsoJumpUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("sso_jump_url");
            entity.Property(e => e.SsoLandUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("sso_land_url");
            entity.Property(e => e.XmlrpcServerUrl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("xmlrpc_server_url");
        });

        modelBuilder.Entity<MdlMnetHost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnet_host", tb => tb.HasComment("Information about the local and remote hosts for RPC"));

            entity.HasIndex(e => e.Applicationid, "mdl_mnethost_app_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Applicationid)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("applicationid");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.ForceTheme).HasColumnName("force_theme");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ip_address");
            entity.Property(e => e.LastConnectTime)
                .HasColumnType("bigint(10)")
                .HasColumnName("last_connect_time");
            entity.Property(e => e.LastLogId)
                .HasColumnType("bigint(10)")
                .HasColumnName("last_log_id");
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Portno)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(5)")
                .HasColumnName("portno");
            entity.Property(e => e.PublicKey).HasColumnName("public_key");
            entity.Property(e => e.PublicKeyExpires)
                .HasColumnType("bigint(10)")
                .HasColumnName("public_key_expires");
            entity.Property(e => e.Sslverification).HasColumnName("sslverification");
            entity.Property(e => e.Theme)
                .HasMaxLength(100)
                .HasColumnName("theme");
            entity.Property(e => e.Transport)
                .HasColumnType("tinyint(2)")
                .HasColumnName("transport");
            entity.Property(e => e.Wwwroot)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("wwwroot");
        });

        modelBuilder.Entity<MdlMnetHost2service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnet_host2service", tb => tb.HasComment("Information about the services for a given host"));

            entity.HasIndex(e => new { e.Hostid, e.Serviceid }, "mdl_mnethost_hosser_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Hostid)
                .HasColumnType("bigint(10)")
                .HasColumnName("hostid");
            entity.Property(e => e.Publish).HasColumnName("publish");
            entity.Property(e => e.Serviceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("serviceid");
            entity.Property(e => e.Subscribe).HasColumnName("subscribe");
        });

        modelBuilder.Entity<MdlMnetLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnet_log", tb => tb.HasComment("Store session data from users migrating to other sites"));

            entity.HasIndex(e => new { e.Hostid, e.Userid, e.Course }, "mdl_mnetlog_hosusecou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Cmid)
                .HasColumnType("bigint(10)")
                .HasColumnName("cmid");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Coursename)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("coursename");
            entity.Property(e => e.Hostid)
                .HasColumnType("bigint(10)")
                .HasColumnName("hostid");
            entity.Property(e => e.Info)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("info");
            entity.Property(e => e.Ip)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("ip");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("module");
            entity.Property(e => e.Remoteid)
                .HasColumnType("bigint(10)")
                .HasColumnName("remoteid");
            entity.Property(e => e.Time)
                .HasColumnType("bigint(10)")
                .HasColumnName("time");
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlMnetRemoteRpc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnet_remote_rpc", tb => tb.HasComment("This table describes functions that might be called remotely"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Functionname)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("functionname");
            entity.Property(e => e.Pluginname)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("pluginname");
            entity.Property(e => e.Plugintype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("plugintype");
            entity.Property(e => e.Xmlrpcpath)
                .HasMaxLength(80)
                .HasDefaultValueSql("''")
                .HasColumnName("xmlrpcpath");
        });

        modelBuilder.Entity<MdlMnetRemoteService2rpc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnet_remote_service2rpc", tb => tb.HasComment("Group functions or methods under a service"));

            entity.HasIndex(e => new { e.Rpcid, e.Serviceid }, "mdl_mnetremoserv_rpcser_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Rpcid)
                .HasColumnType("bigint(10)")
                .HasColumnName("rpcid");
            entity.Property(e => e.Serviceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("serviceid");
        });

        modelBuilder.Entity<MdlMnetRpc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnet_rpc", tb => tb.HasComment("Functions or methods that we may publish or subscribe to"));

            entity.HasIndex(e => new { e.Enabled, e.Xmlrpcpath }, "mdl_mnetrpc_enaxml_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Classname)
                .HasMaxLength(150)
                .HasColumnName("classname");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Filename)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("filename");
            entity.Property(e => e.Functionname)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("functionname");
            entity.Property(e => e.Help).HasColumnName("help");
            entity.Property(e => e.Pluginname)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("pluginname");
            entity.Property(e => e.Plugintype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("plugintype");
            entity.Property(e => e.Profile).HasColumnName("profile");
            entity.Property(e => e.Static).HasColumnName("static");
            entity.Property(e => e.Xmlrpcpath)
                .HasMaxLength(80)
                .HasDefaultValueSql("''")
                .HasColumnName("xmlrpcpath");
        });

        modelBuilder.Entity<MdlMnetService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnet_service", tb => tb.HasComment("A service is a group of functions"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Apiversion)
                .HasMaxLength(10)
                .HasDefaultValueSql("''")
                .HasColumnName("apiversion");
            entity.Property(e => e.Description)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Offer).HasColumnName("offer");
        });

        modelBuilder.Entity<MdlMnetService2rpc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnet_service2rpc", tb => tb.HasComment("Group functions or methods under a service"));

            entity.HasIndex(e => new { e.Rpcid, e.Serviceid }, "mdl_mnetserv_rpcser_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Rpcid)
                .HasColumnType("bigint(10)")
                .HasColumnName("rpcid");
            entity.Property(e => e.Serviceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("serviceid");
        });

        modelBuilder.Entity<MdlMnetSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnet_session", tb => tb.HasComment("Store session data from users migrating to other sites"));

            entity.HasIndex(e => e.Token, "mdl_mnetsess_tok_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.ConfirmTimeout)
                .HasColumnType("bigint(10)")
                .HasColumnName("confirm_timeout");
            entity.Property(e => e.Expires)
                .HasColumnType("bigint(10)")
                .HasColumnName("expires");
            entity.Property(e => e.Mnethostid)
                .HasColumnType("bigint(10)")
                .HasColumnName("mnethostid");
            entity.Property(e => e.SessionId)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("session_id");
            entity.Property(e => e.Token)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
            entity.Property(e => e.Useragent)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("useragent");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<MdlMnetSsoAccessControl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnet_sso_access_control", tb => tb.HasComment("Users by host permitted (or not) to login from a remote prov"));

            entity.HasIndex(e => new { e.MnetHostId, e.Username }, "mdl_mnetssoaccecont_mneuse_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Accessctrl)
                .HasMaxLength(20)
                .HasDefaultValueSql("'allow'")
                .HasColumnName("accessctrl");
            entity.Property(e => e.MnetHostId)
                .HasColumnType("bigint(10)")
                .HasColumnName("mnet_host_id");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
        });

        modelBuilder.Entity<MdlMnetserviceEnrolCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnetservice_enrol_courses", tb => tb.HasComment("Caches the information fetched via XML-RPC about courses on "));

            entity.HasIndex(e => new { e.Hostid, e.Remoteid }, "mdl_mnetenrocour_hosrem_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Categoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("categoryid");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("categoryname");
            entity.Property(e => e.Fullname)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Hostid)
                .HasColumnType("bigint(10)")
                .HasColumnName("hostid");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("idnumber");
            entity.Property(e => e.Remoteid)
                .HasColumnType("bigint(10)")
                .HasColumnName("remoteid");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Rolename)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("rolename");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Startdate)
                .HasColumnType("bigint(10)")
                .HasColumnName("startdate");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("summaryformat");
        });

        modelBuilder.Entity<MdlMnetserviceEnrolEnrolment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_mnetservice_enrol_enrolments", tb => tb.HasComment("Caches the information about enrolments of our local users i"));

            entity.HasIndex(e => e.Hostid, "mdl_mnetenroenro_hos_ix");

            entity.HasIndex(e => e.Userid, "mdl_mnetenroenro_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Enroltime)
                .HasColumnType("bigint(10)")
                .HasColumnName("enroltime");
            entity.Property(e => e.Enroltype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("enroltype");
            entity.Property(e => e.Hostid)
                .HasColumnType("bigint(10)")
                .HasColumnName("hostid");
            entity.Property(e => e.Remotecourseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("remotecourseid");
            entity.Property(e => e.Rolename)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("rolename");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_modules", tb => tb.HasComment("modules available in the site"));

            entity.HasIndex(e => e.Name, "mdl_modu_nam_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cron)
                .HasColumnType("bigint(10)")
                .HasColumnName("cron");
            entity.Property(e => e.Lastcron)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastcron");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Search)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("search");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlMyPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_my_pages", tb => tb.HasComment("Extra user pages for the My Moodle system"));

            entity.HasIndex(e => new { e.Userid, e.Private }, "mdl_mypage_usepri_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Private)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("private");
            entity.Property(e => e.Sortorder)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Userid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_notifications", tb => tb.HasComment("Stores all notifications"));

            entity.HasIndex(e => e.Useridto, "mdl_noti_use2_ix");

            entity.HasIndex(e => e.Useridfrom, "mdl_noti_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Contexturl).HasColumnName("contexturl");
            entity.Property(e => e.Contexturlname).HasColumnName("contexturlname");
            entity.Property(e => e.Customdata).HasColumnName("customdata");
            entity.Property(e => e.Eventtype)
                .HasMaxLength(100)
                .HasColumnName("eventtype");
            entity.Property(e => e.Fullmessage).HasColumnName("fullmessage");
            entity.Property(e => e.Fullmessageformat).HasColumnName("fullmessageformat");
            entity.Property(e => e.Fullmessagehtml).HasColumnName("fullmessagehtml");
            entity.Property(e => e.Smallmessage).HasColumnName("smallmessage");
            entity.Property(e => e.Subject).HasColumnName("subject");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timeread)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeread");
            entity.Property(e => e.Useridfrom)
                .HasColumnType("bigint(10)")
                .HasColumnName("useridfrom");
            entity.Property(e => e.Useridto)
                .HasColumnType("bigint(10)")
                .HasColumnName("useridto");
        });

        modelBuilder.Entity<MdlOauth2AccessToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_oauth2_access_token", tb => tb.HasComment("Stores access tokens for system accounts in order to be able"));

            entity.HasIndex(e => e.Issuerid, "mdl_oautaccetoke_iss_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Expires)
                .HasColumnType("bigint(10)")
                .HasColumnName("expires");
            entity.Property(e => e.Issuerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("issuerid");
            entity.Property(e => e.Scope).HasColumnName("scope");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Token).HasColumnName("token");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlOauth2Endpoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_oauth2_endpoint", tb => tb.HasComment("Describes the named endpoint for an oauth2 service."));

            entity.HasIndex(e => e.Issuerid, "mdl_oautendp_iss_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Issuerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("issuerid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Url).HasColumnName("url");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlOauth2Issuer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_oauth2_issuer", tb => tb.HasComment("Details for an oauth 2 connect identity issuer."));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Alloweddomains).HasColumnName("alloweddomains");
            entity.Property(e => e.Baseurl).HasColumnName("baseurl");
            entity.Property(e => e.Basicauth)
                .HasColumnType("tinyint(2)")
                .HasColumnName("basicauth");
            entity.Property(e => e.Clientid).HasColumnName("clientid");
            entity.Property(e => e.Clientsecret).HasColumnName("clientsecret");
            entity.Property(e => e.Enabled)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("enabled");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Loginparams).HasColumnName("loginparams");
            entity.Property(e => e.Loginparamsoffline).HasColumnName("loginparamsoffline");
            entity.Property(e => e.Loginscopes).HasColumnName("loginscopes");
            entity.Property(e => e.Loginscopesoffline).HasColumnName("loginscopesoffline");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Requireconfirmation)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("requireconfirmation");
            entity.Property(e => e.Scopessupported).HasColumnName("scopessupported");
            entity.Property(e => e.Showonloginpage)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("showonloginpage");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlOauth2SystemAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_oauth2_system_account", tb => tb.HasComment("Stored details used to get an access token as a system user "));

            entity.HasIndex(e => e.Issuerid, "mdl_oautsystacco_iss_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Grantedscopes).HasColumnName("grantedscopes");
            entity.Property(e => e.Issuerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("issuerid");
            entity.Property(e => e.Refreshtoken).HasColumnName("refreshtoken");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
            entity.Property(e => e.Username).HasColumnName("username");
        });

        modelBuilder.Entity<MdlOauth2UserFieldMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_oauth2_user_field_mapping", tb => tb.HasComment("Mapping of oauth user fields to moodle fields."));

            entity.HasIndex(e => e.Issuerid, "mdl_oautuserfielmapp_iss_ix");

            entity.HasIndex(e => new { e.Issuerid, e.Internalfield }, "mdl_oautuserfielmapp_issin_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Externalfield)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("externalfield");
            entity.Property(e => e.Internalfield)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .HasColumnName("internalfield");
            entity.Property(e => e.Issuerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("issuerid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_page", tb => tb.HasComment("Each record is one page and its config data"));

            entity.HasIndex(e => e.Course, "mdl_page_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contentformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("contentformat");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Display)
                .HasColumnType("smallint(4)")
                .HasColumnName("display");
            entity.Property(e => e.Displayoptions).HasColumnName("displayoptions");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Legacyfiles)
                .HasColumnType("smallint(4)")
                .HasColumnName("legacyfiles");
            entity.Property(e => e.Legacyfileslast)
                .HasColumnType("bigint(10)")
                .HasColumnName("legacyfileslast");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Revision)
                .HasColumnType("bigint(10)")
                .HasColumnName("revision");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlPoasassignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment", tb => tb.HasComment("Defines poasassignments"));

            entity.HasIndex(e => e.Course, "mdl_poas_cou_ix");

            entity.HasIndex(e => e.Taskgiverid, "mdl_poas_tas_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Availabledate)
                .HasColumnType("bigint(10)")
                .HasColumnName("availabledate");
            entity.Property(e => e.Choicedate)
                .HasColumnType("bigint(10)")
                .HasColumnName("choicedate");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Deadline)
                .HasColumnType("bigint(10)")
                .HasColumnName("deadline");
            entity.Property(e => e.Flags)
                .HasColumnType("bigint(11)")
                .HasColumnName("flags");
            entity.Property(e => e.Grade)
                .HasDefaultValueSql("'100'")
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Penalty)
                .HasPrecision(10, 2)
                .HasDefaultValueSql("'0.05'")
                .HasColumnName("penalty");
            entity.Property(e => e.Taskgiverid)
                .HasColumnType("bigint(10)")
                .HasColumnName("taskgiverid");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Uniqueness).HasColumnName("uniqueness");
        });

        modelBuilder.Entity<MdlPoasassignmentAnalogych>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_analogych", tb => tb.HasComment("Table for Analogy choice"));

            entity.HasIndex(e => e.Additionalid, "mdl_poasanal_add_ix");

            entity.HasIndex(e => e.Originalid, "mdl_poasanal_ori_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Additionalid)
                .HasColumnType("bigint(11)")
                .HasColumnName("additionalid");
            entity.Property(e => e.Originalid)
                .HasColumnType("bigint(11)")
                .HasColumnName("originalid");
        });

        modelBuilder.Entity<MdlPoasassignmentAnsStng>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_ans_stngs", tb => tb.HasComment("Settings for answer plugins"));

            entity.HasIndex(e => e.Answerid, "mdl_poasansstng_ans_ix");

            entity.HasIndex(e => e.Poasassignmentid, "mdl_poasansstng_poa_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("answerid");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Poasassignmentid)
                .HasColumnType("bigint(10)")
                .HasColumnName("poasassignmentid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlPoasassignmentAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_answers", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasColumnName("path");
        });

        modelBuilder.Entity<MdlPoasassignmentAssignee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_assignee", tb => tb.HasComment("Connects Moodle user with poasassignment task and attempts"));

            entity.HasIndex(e => e.Poasassignmentid, "mdl_poasassi_poa_ix");

            entity.HasIndex(e => e.Taskid, "mdl_poasassi_tas_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cancelled).HasColumnName("cancelled");
            entity.Property(e => e.Finalized)
                .HasColumnType("bigint(10)")
                .HasColumnName("finalized");
            entity.Property(e => e.Poasassignmentid)
                .HasColumnType("bigint(10)")
                .HasColumnName("poasassignmentid");
            entity.Property(e => e.Taskid)
                .HasColumnType("bigint(10)")
                .HasColumnName("taskid");
            entity.Property(e => e.Timetaken)
                .HasColumnType("bigint(10)")
                .HasColumnName("timetaken");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlPoasassignmentAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_attempts", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.HasIndex(e => e.Assigneeid, "mdl_poasatte_ass_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assigneeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("assigneeid");
            entity.Property(e => e.Attemptdate)
                .HasColumnType("bigint(10)")
                .HasColumnName("attemptdate");
            entity.Property(e => e.Attemptnumber)
                .HasColumnType("bigint(10)")
                .HasColumnName("attemptnumber");
            entity.Property(e => e.Disablepenalty).HasColumnName("disablepenalty");
            entity.Property(e => e.Draft).HasColumnName("draft");
            entity.Property(e => e.Final)
                .HasDefaultValueSql("'0'")
                .HasColumnName("final");
            entity.Property(e => e.Rating)
                .HasPrecision(10, 2)
                .HasColumnName("rating");
            entity.Property(e => e.Ratingdate)
                .HasColumnType("bigint(10)")
                .HasColumnName("ratingdate");
        });

        modelBuilder.Entity<MdlPoasassignmentField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_fields", tb => tb.HasComment("Fileds for poasassignment individual tasks"));

            entity.HasIndex(e => e.Poasassignmentid, "mdl_poasfiel_poa_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Ftype)
                .HasColumnType("bigint(10)")
                .HasColumnName("ftype");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Poasassignmentid)
                .HasColumnType("bigint(10)")
                .HasColumnName("poasassignmentid");
            entity.Property(e => e.Random).HasColumnName("random");
            entity.Property(e => e.Secretfield).HasColumnName("secretfield");
            entity.Property(e => e.Showintable).HasColumnName("showintable");
            entity.Property(e => e.Valuemax)
                .HasPrecision(10, 2)
                .HasColumnName("valuemax");
            entity.Property(e => e.Valuemin)
                .HasPrecision(10, 2)
                .HasColumnName("valuemin");
        });

        modelBuilder.Entity<MdlPoasassignmentGrAtRe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_gr_at_res", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attemptid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("attemptid");
            entity.Property(e => e.Studentout).HasColumnName("studentout");
            entity.Property(e => e.Testid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("testid");
            entity.Property(e => e.Testpassed)
                .HasDefaultValueSql("'0'")
                .HasColumnName("testpassed");
        });

        modelBuilder.Entity<MdlPoasassignmentGrAutotester>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_gr_autotester", tb => tb.HasComment("Default comment for autotester, please edit me"));

            entity.HasIndex(e => e.Questionid, "mdl_poasgrauto_que_ix");

            entity.HasIndex(e => e.Taskid, "mdl_poasgrauto_tas_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(20)")
                .HasColumnName("questionid");
            entity.Property(e => e.Taskid)
                .HasColumnType("bigint(20)")
                .HasColumnName("taskid");
        });

        modelBuilder.Entity<MdlPoasassignmentGrRa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_gr_ra", tb => tb.HasComment("Default comment for remote_autotester, please edit me"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attemptid)
                .HasColumnType("bigint(20)")
                .HasColumnName("attemptid");
            entity.Property(e => e.Compiled).HasColumnName("compiled");
            entity.Property(e => e.Compilemessage).HasColumnName("compilemessage");
            entity.Property(e => e.Result).HasColumnName("result");
            entity.Property(e => e.Serverresponse)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("serverresponse");
            entity.Property(e => e.Testsfound)
                .HasColumnType("bigint(10)")
                .HasColumnName("testsfound");
            entity.Property(e => e.Timeclosed)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeclosed");
            entity.Property(e => e.Timecompiled)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecompiled");
            entity.Property(e => e.Timecompilestarted)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecompilestarted");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timeteststart)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeteststart");
        });

        modelBuilder.Entity<MdlPoasassignmentGrRaTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_gr_ra_tests", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.RemoteId)
                .HasColumnType("bigint(10)")
                .HasColumnName("remote_id");
            entity.Property(e => e.Studentout).HasColumnName("studentout");
            entity.Property(e => e.Test)
                .HasMaxLength(255)
                .HasColumnName("test");
            entity.Property(e => e.Testin).HasColumnName("testin");
            entity.Property(e => e.Testout).HasColumnName("testout");
            entity.Property(e => e.Testpassed).HasColumnName("testpassed");
            entity.Property(e => e.Timetested)
                .HasColumnType("bigint(10)")
                .HasColumnName("timetested");
        });

        modelBuilder.Entity<MdlPoasassignmentGrader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_graders", tb => tb.HasComment("Table of installed graders"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasColumnName("path");
        });

        modelBuilder.Entity<MdlPoasassignmentParamch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_paramch", tb => tb.HasComment("Default comment for parameterchoice, please edit me"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Fieldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("fieldid");
        });

        modelBuilder.Entity<MdlPoasassignmentSubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_submissions", tb => tb.HasComment("Saves submission data"));

            entity.HasIndex(e => e.Answerid, "mdl_poassubm_ans_ix");

            entity.HasIndex(e => e.Attemptid, "mdl_poassubm_att_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("answerid");
            entity.Property(e => e.Attemptid)
                .HasColumnType("bigint(10)")
                .HasColumnName("attemptid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlPoasassignmentTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_tasks", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.HasIndex(e => e.Poasassignmentid, "mdl_poastask_poa_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Deadline)
                .HasColumnType("bigint(10)")
                .HasColumnName("deadline");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Poasassignmentid)
                .HasColumnType("bigint(10)")
                .HasColumnName("poasassignmentid");
        });

        modelBuilder.Entity<MdlPoasassignmentTaskValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_task_values", tb => tb.HasComment("Values of poasassignment fields"));

            entity.HasIndex(e => e.Assigneeid, "mdl_poastaskvalu_ass_ix");

            entity.HasIndex(e => e.Fieldid, "mdl_poastaskvalu_fie_ix");

            entity.HasIndex(e => e.Taskid, "mdl_poastaskvalu_tas_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assigneeid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("assigneeid");
            entity.Property(e => e.Fieldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("fieldid");
            entity.Property(e => e.Taskid)
                .HasColumnType("bigint(10)")
                .HasColumnName("taskid");
            entity.Property(e => e.Value).HasColumnName("value");
            entity.Property(e => e.Valueformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("valueformat");
        });

        modelBuilder.Entity<MdlPoasassignmentTaskgiver>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_taskgivers", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("path");
        });

        modelBuilder.Entity<MdlPoasassignmentUsedGrader>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_used_graders", tb => tb.HasComment("Connects grader with poasassignment instances"));

            entity.HasIndex(e => e.Graderid, "mdl_poasusedgrad_gra_ix");

            entity.HasIndex(e => e.Poasassignmentid, "mdl_poasusedgrad_poa_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Graderid)
                .HasColumnType("bigint(10)")
                .HasColumnName("graderid");
            entity.Property(e => e.Poasassignmentid)
                .HasColumnType("bigint(10)")
                .HasColumnName("poasassignmentid");
        });

        modelBuilder.Entity<MdlPoasassignmentVariant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_poasassignment_variants", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.HasIndex(e => e.Fieldid, "mdl_poasvari_fie_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Fieldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("fieldid");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlPortfolioInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_portfolio_instance", tb => tb.HasComment("base table (not including config data) for instances of port"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Plugin)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("plugin");
            entity.Property(e => e.Visible)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlPortfolioInstanceConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_portfolio_instance_config", tb => tb.HasComment("config for portfolio plugin instances"));

            entity.HasIndex(e => e.Instance, "mdl_portinstconf_ins_ix");

            entity.HasIndex(e => e.Name, "mdl_portinstconf_nam_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Instance)
                .HasColumnType("bigint(10)")
                .HasColumnName("instance");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlPortfolioInstanceUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_portfolio_instance_user", tb => tb.HasComment("user data for portfolio instances."));

            entity.HasIndex(e => e.Instance, "mdl_portinstuser_ins_ix");

            entity.HasIndex(e => e.Userid, "mdl_portinstuser_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Instance)
                .HasColumnType("bigint(10)")
                .HasColumnName("instance");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlPortfolioLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_portfolio_log", tb => tb.HasComment("log of portfolio transfers (used to later check for duplicat"));

            entity.HasIndex(e => e.Portfolio, "mdl_portlog_por_ix");

            entity.HasIndex(e => e.Userid, "mdl_portlog_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.CallerClass)
                .HasMaxLength(150)
                .HasDefaultValueSql("''")
                .HasColumnName("caller_class");
            entity.Property(e => e.CallerComponent)
                .HasMaxLength(255)
                .HasColumnName("caller_component");
            entity.Property(e => e.CallerFile)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("caller_file");
            entity.Property(e => e.CallerSha1)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("caller_sha1");
            entity.Property(e => e.Continueurl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("continueurl");
            entity.Property(e => e.Portfolio)
                .HasColumnType("bigint(10)")
                .HasColumnName("portfolio");
            entity.Property(e => e.Returnurl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("returnurl");
            entity.Property(e => e.Tempdataid)
                .HasColumnType("bigint(10)")
                .HasColumnName("tempdataid");
            entity.Property(e => e.Time)
                .HasColumnType("bigint(10)")
                .HasColumnName("time");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlPortfolioMaharaQueue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_portfolio_mahara_queue", tb => tb.HasComment("maps mahara tokens to transfer ids"));

            entity.HasIndex(e => e.Token, "mdl_portmahaqueu_tok_ix");

            entity.HasIndex(e => e.Transferid, "mdl_portmahaqueu_tra_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Token)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
            entity.Property(e => e.Transferid)
                .HasColumnType("bigint(10)")
                .HasColumnName("transferid");
        });

        modelBuilder.Entity<MdlPortfolioTempdatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_portfolio_tempdata", tb => tb.HasComment("stores temporary data for portfolio exports. the id of this "));

            entity.HasIndex(e => e.Instance, "mdl_porttemp_ins_ix");

            entity.HasIndex(e => e.Userid, "mdl_porttemp_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Expirytime)
                .HasColumnType("bigint(10)")
                .HasColumnName("expirytime");
            entity.Property(e => e.Instance)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("instance");
            entity.Property(e => e.Queued).HasColumnName("queued");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlPost>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_post", tb => tb.HasComment("Generic post table to hold data blog entries etc in differen"));

            entity.HasIndex(e => new { e.Id, e.Userid }, "mdl_post_iduse_uix").IsUnique();

            entity.HasIndex(e => e.Lastmodified, "mdl_post_las_ix");

            entity.HasIndex(e => e.Module, "mdl_post_mod_ix");

            entity.HasIndex(e => e.Subject, "mdl_post_sub_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_post_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attachment)
                .HasMaxLength(100)
                .HasColumnName("attachment");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Coursemoduleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("coursemoduleid");
            entity.Property(e => e.Created)
                .HasColumnType("bigint(10)")
                .HasColumnName("created");
            entity.Property(e => e.Format)
                .HasColumnType("bigint(10)")
                .HasColumnName("format");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Lastmodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastmodified");
            entity.Property(e => e.Module)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("module");
            entity.Property(e => e.Moduleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("moduleid");
            entity.Property(e => e.Publishstate)
                .HasMaxLength(20)
                .HasDefaultValueSql("'draft'")
                .HasColumnName("publishstate");
            entity.Property(e => e.Rating)
                .HasColumnType("bigint(10)")
                .HasColumnName("rating");
            entity.Property(e => e.Subject)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("subject");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("summaryformat");
            entity.Property(e => e.Uniquehash)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("uniquehash");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlProfiling>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_profiling", tb => tb.HasComment("Stores the results of all the profiling runs"));

            entity.HasIndex(e => e.Runid, "mdl_prof_run_uix").IsUnique();

            entity.HasIndex(e => new { e.Timecreated, e.Runreference }, "mdl_prof_timrun_ix");

            entity.HasIndex(e => new { e.Url, e.Runreference }, "mdl_prof_urlrun_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Runcomment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("runcomment");
            entity.Property(e => e.Runid)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("runid");
            entity.Property(e => e.Runreference)
                .HasColumnType("tinyint(2)")
                .HasColumnName("runreference");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Totalcalls)
                .HasColumnType("bigint(10)")
                .HasColumnName("totalcalls");
            entity.Property(e => e.Totalcputime)
                .HasColumnType("bigint(10)")
                .HasColumnName("totalcputime");
            entity.Property(e => e.Totalexecutiontime)
                .HasColumnType("bigint(10)")
                .HasColumnName("totalexecutiontime");
            entity.Property(e => e.Totalmemory)
                .HasColumnType("bigint(10)")
                .HasColumnName("totalmemory");
            entity.Property(e => e.Url)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
        });

        modelBuilder.Entity<MdlQtypeCorrectwriting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_correctwriting", tb => tb.HasComment("This table contains main options for CorrectWriting question"));

            entity.HasIndex(e => e.Questionid, "mdl_qtypcorr_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Absenthintpenaltyfactor)
                .HasPrecision(4, 1)
                .HasDefaultValueSql("'1.0'")
                .HasColumnName("absenthintpenaltyfactor");
            entity.Property(e => e.Absentmistakeweight)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'0.3300000'")
                .HasColumnName("absentmistakeweight");
            entity.Property(e => e.Addedmistakeweight)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'0.3300000'")
                .HasColumnName("addedmistakeweight");
            entity.Property(e => e.Allowinvalidsyntaxanswers)
                .HasColumnType("smallint(4)")
                .HasColumnName("allowinvalidsyntaxanswers");
            entity.Property(e => e.Hintgradeborder)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'0.9000000'")
                .HasColumnName("hintgradeborder");
            entity.Property(e => e.Howtofixpichintpenalty)
                .HasPrecision(4, 2)
                .HasDefaultValueSql("'1.10'")
                .HasColumnName("howtofixpichintpenalty");
            entity.Property(e => e.Isenumanalyzerenabled)
                .HasColumnType("smallint(4)")
                .HasColumnName("isenumanalyzerenabled");
            entity.Property(e => e.Islexicalanalyzerenabled)
                .HasColumnType("smallint(4)")
                .HasColumnName("islexicalanalyzerenabled");
            entity.Property(e => e.Issequenceanalyzerenabled)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("issequenceanalyzerenabled");
            entity.Property(e => e.Issyntaxanalyzerenabled)
                .HasColumnType("smallint(4)")
                .HasColumnName("issyntaxanalyzerenabled");
            entity.Property(e => e.Langid)
                .HasColumnType("bigint(10)")
                .HasColumnName("langid");
            entity.Property(e => e.Lexicalerrorthreshold)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'0.5000000'")
                .HasColumnName("lexicalerrorthreshold");
            entity.Property(e => e.Lexicalerrorweight)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'0.0800000'")
                .HasColumnName("lexicalerrorweight");
            entity.Property(e => e.Maxmistakepercentage)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'0.7000000'")
                .HasColumnName("maxmistakepercentage");
            entity.Property(e => e.Movedmistakeweight)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'0.1600000'")
                .HasColumnName("movedmistakeweight");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Usecase)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("usecase");
            entity.Property(e => e.Whatishintpenalty)
                .HasPrecision(4, 2)
                .HasDefaultValueSql("'1.10'")
                .HasColumnName("whatishintpenalty");
            entity.Property(e => e.Wherepichintpenalty)
                .HasPrecision(4, 2)
                .HasDefaultValueSql("'1.10'")
                .HasColumnName("wherepichintpenalty");
            entity.Property(e => e.Wheretxthintpenalty)
                .HasPrecision(4, 2)
                .HasDefaultValueSql("'1.10'")
                .HasColumnName("wheretxthintpenalty");
        });

        modelBuilder.Entity<MdlQtypeCorrectwritingEnum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_correctwriting_enums", tb => tb.HasComment("Options for creating enumerations"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("answerid");
            entity.Property(e => e.Enumerations).HasColumnName("enumerations");
        });

        modelBuilder.Entity<MdlQtypeDdimageortext>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_ddimageortext", tb => tb.HasComment("Defines drag and drop (text or images onto a background imag"));

            entity.HasIndex(e => e.Questionid, "mdl_qtypddim_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect)
                .HasColumnType("tinyint(2)")
                .HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("shuffleanswers");
        });

        modelBuilder.Entity<MdlQtypeDdimageortextDrag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_ddimageortext_drags", tb => tb.HasComment("Images to drag. Actual file names are not stored here we use"));

            entity.HasIndex(e => e.Questionid, "mdl_qtypddimdrag_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Draggroup)
                .HasColumnType("bigint(10)")
                .HasColumnName("draggroup");
            entity.Property(e => e.Infinite)
                .HasColumnType("smallint(4)")
                .HasColumnName("infinite");
            entity.Property(e => e.Label).HasColumnName("label");
            entity.Property(e => e.No)
                .HasColumnType("bigint(10)")
                .HasColumnName("no");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
        });

        modelBuilder.Entity<MdlQtypeDdimageortextDrop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_ddimageortext_drops", tb => tb.HasComment("Drop boxes"));

            entity.HasIndex(e => e.Questionid, "mdl_qtypddimdrop_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Choice)
                .HasColumnType("bigint(10)")
                .HasColumnName("choice");
            entity.Property(e => e.Label).HasColumnName("label");
            entity.Property(e => e.No)
                .HasColumnType("bigint(10)")
                .HasColumnName("no");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Xleft)
                .HasColumnType("bigint(10)")
                .HasColumnName("xleft");
            entity.Property(e => e.Ytop)
                .HasColumnType("bigint(10)")
                .HasColumnName("ytop");
        });

        modelBuilder.Entity<MdlQtypeDdmarker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_ddmarker", tb => tb.HasComment("Defines drag and drop (text or images onto a background imag"));

            entity.HasIndex(e => e.Questionid, "mdl_qtypddma_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Showmisplaced)
                .HasColumnType("smallint(4)")
                .HasColumnName("showmisplaced");
            entity.Property(e => e.Shownumcorrect)
                .HasColumnType("tinyint(2)")
                .HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("shuffleanswers");
        });

        modelBuilder.Entity<MdlQtypeDdmarkerDrag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_ddmarker_drags", tb => tb.HasComment("Labels for markers to drag."));

            entity.HasIndex(e => e.Questionid, "mdl_qtypddmadrag_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Infinite)
                .HasColumnType("smallint(4)")
                .HasColumnName("infinite");
            entity.Property(e => e.Label).HasColumnName("label");
            entity.Property(e => e.No)
                .HasColumnType("bigint(10)")
                .HasColumnName("no");
            entity.Property(e => e.Noofdrags)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("noofdrags");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
        });

        modelBuilder.Entity<MdlQtypeDdmarkerDrop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_ddmarker_drops", tb => tb.HasComment("drop regions"));

            entity.HasIndex(e => e.Questionid, "mdl_qtypddmadrop_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Choice)
                .HasColumnType("bigint(10)")
                .HasColumnName("choice");
            entity.Property(e => e.Coords).HasColumnName("coords");
            entity.Property(e => e.No)
                .HasColumnType("bigint(10)")
                .HasColumnName("no");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Shape)
                .HasMaxLength(255)
                .HasColumnName("shape");
        });

        modelBuilder.Entity<MdlQtypeEssayOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_essay_options", tb => tb.HasComment("Extra options for essay questions."));

            entity.HasIndex(e => e.Questionid, "mdl_qtypessaopti_que_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attachments)
                .HasColumnType("smallint(4)")
                .HasColumnName("attachments");
            entity.Property(e => e.Attachmentsrequired)
                .HasColumnType("smallint(4)")
                .HasColumnName("attachmentsrequired");
            entity.Property(e => e.Filetypeslist).HasColumnName("filetypeslist");
            entity.Property(e => e.Graderinfo).HasColumnName("graderinfo");
            entity.Property(e => e.Graderinfoformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("graderinfoformat");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Responsefieldlines)
                .HasDefaultValueSql("'15'")
                .HasColumnType("smallint(4)")
                .HasColumnName("responsefieldlines");
            entity.Property(e => e.Responseformat)
                .HasMaxLength(16)
                .HasDefaultValueSql("'editor'")
                .HasColumnName("responseformat");
            entity.Property(e => e.Responserequired)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("responserequired");
            entity.Property(e => e.Responsetemplate).HasColumnName("responsetemplate");
            entity.Property(e => e.Responsetemplateformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("responsetemplateformat");
        });

        modelBuilder.Entity<MdlQtypeMatchOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_match_options", tb => tb.HasComment("Defines the question-type specific options for matching ques"));

            entity.HasIndex(e => e.Questionid, "mdl_qtypmatcopti_que_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect)
                .HasColumnType("tinyint(2)")
                .HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("shuffleanswers");
        });

        modelBuilder.Entity<MdlQtypeMatchSubquestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_match_subquestions", tb => tb.HasComment("The subquestions that make up a matching question"));

            entity.HasIndex(e => e.Questionid, "mdl_qtypmatcsubq_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answertext)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("answertext");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Questiontext).HasColumnName("questiontext");
            entity.Property(e => e.Questiontextformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("questiontextformat");
        });

        modelBuilder.Entity<MdlQtypeMultichoiceOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_multichoice_options", tb => tb.HasComment("Options for multiple choice questions"));

            entity.HasIndex(e => e.Questionid, "mdl_qtypmultopti_que_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answernumbering)
                .HasMaxLength(10)
                .HasDefaultValueSql("'abc'")
                .HasColumnName("answernumbering");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Layout)
                .HasColumnType("smallint(4)")
                .HasColumnName("layout");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect)
                .HasColumnType("tinyint(2)")
                .HasColumnName("shownumcorrect");
            entity.Property(e => e.Showstandardinstruction)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("showstandardinstruction");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("shuffleanswers");
            entity.Property(e => e.Single)
                .HasColumnType("smallint(4)")
                .HasColumnName("single");
        });

        modelBuilder.Entity<MdlQtypePregOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_preg_options", tb => tb.HasComment("Options for perl-compatible regular expression questions"));

            entity.HasIndex(e => e.Questionid, "mdl_qtyppregopti_que_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answers)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("answers");
            entity.Property(e => e.Approximatematch)
                .HasColumnType("tinyint(2)")
                .HasColumnName("approximatematch");
            entity.Property(e => e.Charhintpenalty)
                .HasColumnType("float(4,2)")
                .HasColumnName("charhintpenalty");
            entity.Property(e => e.Correctanswer)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("correctanswer");
            entity.Property(e => e.Engine)
                .HasMaxLength(50)
                .HasDefaultValueSql("'preg_php_matcher'")
                .HasColumnName("engine");
            entity.Property(e => e.Exactmatch)
                .HasColumnType("tinyint(2)")
                .HasColumnName("exactmatch");
            entity.Property(e => e.Hintgradeborder)
                .HasDefaultValueSql("'1.00'")
                .HasColumnType("float(4,2)")
                .HasColumnName("hintgradeborder");
            entity.Property(e => e.Howtofixpichintpenalty)
                .HasColumnType("float(4,2)")
                .HasColumnName("howtofixpichintpenalty");
            entity.Property(e => e.Langid)
                .HasColumnType("bigint(10)")
                .HasColumnName("langid");
            entity.Property(e => e.Lexemhintpenalty)
                .HasColumnType("float(4,2)")
                .HasColumnName("lexemhintpenalty");
            entity.Property(e => e.Lexemusername)
                .HasMaxLength(100)
                .HasDefaultValueSql("'word'")
                .HasColumnName("lexemusername");
            entity.Property(e => e.Maxtypos)
                .HasColumnType("bigint(11)")
                .HasColumnName("maxtypos");
            entity.Property(e => e.Notation)
                .HasMaxLength(50)
                .HasDefaultValueSql("'native'")
                .HasColumnName("notation");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Typospenalty)
                .HasDefaultValueSql("'0.07'")
                .HasColumnType("float(4,2)")
                .HasColumnName("typospenalty");
            entity.Property(e => e.Usecase)
                .HasColumnType("tinyint(2)")
                .HasColumnName("usecase");
            entity.Property(e => e.Usecharhint)
                .HasColumnType("tinyint(2)")
                .HasColumnName("usecharhint");
            entity.Property(e => e.Usehowtofixpichint)
                .HasColumnType("tinyint(2)")
                .HasColumnName("usehowtofixpichint");
            entity.Property(e => e.Uselexemhint)
                .HasColumnType("tinyint(2)")
                .HasColumnName("uselexemhint");
        });

        modelBuilder.Entity<MdlQtypePregRegexTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_preg_regex_tests", tb => tb.HasComment("Test for regex"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("answerid");
            entity.Property(e => e.Regextests).HasColumnName("regextests");
        });

        modelBuilder.Entity<MdlQtypeRandomsamatchOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_randomsamatch_options", tb => tb.HasComment("Info about a random short-answer matching question"));

            entity.HasIndex(e => e.Questionid, "mdl_qtyprandopti_que_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Choose)
                .HasDefaultValueSql("'4'")
                .HasColumnType("bigint(10)")
                .HasColumnName("choose");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect)
                .HasColumnType("tinyint(2)")
                .HasColumnName("shownumcorrect");
            entity.Property(e => e.Subcats)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("subcats");
        });

        modelBuilder.Entity<MdlQtypeShortanswerOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_qtype_shortanswer_options", tb => tb.HasComment("Options for short answer questions"));

            entity.HasIndex(e => e.Questionid, "mdl_qtypshoropti_que_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Usecase)
                .HasColumnType("tinyint(2)")
                .HasColumnName("usecase");
        });

        modelBuilder.Entity<MdlQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question", tb => tb.HasComment("The questions themselves"));

            entity.HasIndex(e => e.Category, "mdl_ques_cat_ix");

            entity.HasIndex(e => new { e.Category, e.Idnumber }, "mdl_ques_catidn_uix").IsUnique();

            entity.HasIndex(e => e.Createdby, "mdl_ques_cre_ix");

            entity.HasIndex(e => e.Modifiedby, "mdl_ques_mod_ix");

            entity.HasIndex(e => e.Parent, "mdl_ques_par_ix");

            entity.HasIndex(e => e.Qtype, "mdl_ques_qty_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasColumnType("bigint(10)")
                .HasColumnName("category");
            entity.Property(e => e.Createdby)
                .HasColumnType("bigint(10)")
                .HasColumnName("createdby");
            entity.Property(e => e.Defaultmark)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'1.0000000'")
                .HasColumnName("defaultmark");
            entity.Property(e => e.Generalfeedback).HasColumnName("generalfeedback");
            entity.Property(e => e.Generalfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("generalfeedbackformat");
            entity.Property(e => e.Hidden).HasColumnName("hidden");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Length)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("length");
            entity.Property(e => e.Modifiedby)
                .HasColumnType("bigint(10)")
                .HasColumnName("modifiedby");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Parent)
                .HasColumnType("bigint(10)")
                .HasColumnName("parent");
            entity.Property(e => e.Penalty)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'0.3333333'")
                .HasColumnName("penalty");
            entity.Property(e => e.Qtype)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("qtype");
            entity.Property(e => e.Questiontext).HasColumnName("questiontext");
            entity.Property(e => e.Questiontextformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("questiontextformat");
            entity.Property(e => e.Stamp)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("stamp");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlQuestionAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_answers", tb => tb.HasComment("Answers, with a fractional grade (0-1) and feedback"));

            entity.HasIndex(e => e.Question, "mdl_quesansw_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity.Property(e => e.Answerformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("answerformat");
            entity.Property(e => e.Feedback).HasColumnName("feedback");
            entity.Property(e => e.Feedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("feedbackformat");
            entity.Property(e => e.Fraction)
                .HasPrecision(12, 7)
                .HasColumnName("fraction");
            entity.Property(e => e.Question)
                .HasColumnType("bigint(10)")
                .HasColumnName("question");
        });

        modelBuilder.Entity<MdlQuestionAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_attempts", tb => tb.HasComment("Each row here corresponds to an attempt at one question, as "));

            entity.HasIndex(e => e.Behaviour, "mdl_quesatte_beh_ix");

            entity.HasIndex(e => e.Questionusageid, "mdl_quesatte_que2_ix");

            entity.HasIndex(e => e.Questionid, "mdl_quesatte_que_ix");

            entity.HasIndex(e => new { e.Questionusageid, e.Slot }, "mdl_quesatte_queslo_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Behaviour)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("behaviour");
            entity.Property(e => e.Flagged).HasColumnName("flagged");
            entity.Property(e => e.Maxfraction)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'1.0000000'")
                .HasColumnName("maxfraction");
            entity.Property(e => e.Maxmark)
                .HasPrecision(12, 7)
                .HasColumnName("maxmark");
            entity.Property(e => e.Minfraction)
                .HasPrecision(12, 7)
                .HasColumnName("minfraction");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Questionsummary).HasColumnName("questionsummary");
            entity.Property(e => e.Questionusageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionusageid");
            entity.Property(e => e.Responsesummary).HasColumnName("responsesummary");
            entity.Property(e => e.Rightanswer).HasColumnName("rightanswer");
            entity.Property(e => e.Slot)
                .HasColumnType("bigint(10)")
                .HasColumnName("slot");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Variant)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("variant");
        });

        modelBuilder.Entity<MdlQuestionAttemptStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_attempt_steps", tb => tb.HasComment("Stores one step in in a question attempt. As well as the dat"));

            entity.HasIndex(e => e.Questionattemptid, "mdl_quesattestep_que_ix");

            entity.HasIndex(e => new { e.Questionattemptid, e.Sequencenumber }, "mdl_quesattestep_queseq_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_quesattestep_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Fraction)
                .HasPrecision(12, 7)
                .HasColumnName("fraction");
            entity.Property(e => e.Questionattemptid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionattemptid");
            entity.Property(e => e.Sequencenumber)
                .HasColumnType("bigint(10)")
                .HasColumnName("sequencenumber");
            entity.Property(e => e.State)
                .HasMaxLength(13)
                .HasDefaultValueSql("''")
                .HasColumnName("state");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlQuestionAttemptStepDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_attempt_step_data", tb => tb.HasComment("Each question_attempt_step has an associative array of the d"));

            entity.HasIndex(e => e.Attemptstepid, "mdl_quesattestepdata_att_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attemptstepid)
                .HasColumnType("bigint(10)")
                .HasColumnName("attemptstepid");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlQuestionCalculated>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_calculated", tb => tb.HasComment("Options for questions of type calculated"));

            entity.HasIndex(e => e.Answer, "mdl_quescalc_ans_ix");

            entity.HasIndex(e => e.Question, "mdl_quescalc_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answer)
                .HasColumnType("bigint(10)")
                .HasColumnName("answer");
            entity.Property(e => e.Correctanswerformat)
                .HasDefaultValueSql("'2'")
                .HasColumnType("bigint(10)")
                .HasColumnName("correctanswerformat");
            entity.Property(e => e.Correctanswerlength)
                .HasDefaultValueSql("'2'")
                .HasColumnType("bigint(10)")
                .HasColumnName("correctanswerlength");
            entity.Property(e => e.Question)
                .HasColumnType("bigint(10)")
                .HasColumnName("question");
            entity.Property(e => e.Tolerance)
                .HasMaxLength(20)
                .HasDefaultValueSql("'0.0'")
                .HasColumnName("tolerance");
            entity.Property(e => e.Tolerancetype)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("tolerancetype");
        });

        modelBuilder.Entity<MdlQuestionCalculatedOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_calculated_options", tb => tb.HasComment("Options for questions of type calculated"));

            entity.HasIndex(e => e.Question, "mdl_quescalcopti_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answernumbering)
                .HasMaxLength(10)
                .HasDefaultValueSql("'abc'")
                .HasColumnName("answernumbering");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Question)
                .HasColumnType("bigint(10)")
                .HasColumnName("question");
            entity.Property(e => e.Shownumcorrect)
                .HasColumnType("tinyint(2)")
                .HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers)
                .HasColumnType("smallint(4)")
                .HasColumnName("shuffleanswers");
            entity.Property(e => e.Single)
                .HasColumnType("smallint(4)")
                .HasColumnName("single");
            entity.Property(e => e.Synchronize)
                .HasColumnType("tinyint(2)")
                .HasColumnName("synchronize");
        });

        modelBuilder.Entity<MdlQuestionCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_categories", tb => tb.HasComment("Categories are for grouping questions"));

            entity.HasIndex(e => e.Contextid, "mdl_quescate_con_ix");

            entity.HasIndex(e => new { e.Contextid, e.Idnumber }, "mdl_quescate_conidn_uix").IsUnique();

            entity.HasIndex(e => new { e.Contextid, e.Stamp }, "mdl_quescate_consta_uix").IsUnique();

            entity.HasIndex(e => e.Parent, "mdl_quescate_par_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(100)
                .HasColumnName("idnumber");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Infoformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("infoformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Parent)
                .HasColumnType("bigint(10)")
                .HasColumnName("parent");
            entity.Property(e => e.Sortorder)
                .HasDefaultValueSql("'999'")
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Stamp)
                .HasDefaultValueSql("''")
                .HasColumnName("stamp");
        });

        modelBuilder.Entity<MdlQuestionDataset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_datasets", tb => tb.HasComment("Many-many relation between questions and dataset definitions"));

            entity.HasIndex(e => e.Datasetdefinition, "mdl_quesdata_dat_ix");

            entity.HasIndex(e => e.Question, "mdl_quesdata_que_ix");

            entity.HasIndex(e => new { e.Question, e.Datasetdefinition }, "mdl_quesdata_quedat_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Datasetdefinition)
                .HasColumnType("bigint(10)")
                .HasColumnName("datasetdefinition");
            entity.Property(e => e.Question)
                .HasColumnType("bigint(10)")
                .HasColumnName("question");
        });

        modelBuilder.Entity<MdlQuestionDatasetDefinition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_dataset_definitions", tb => tb.HasComment("Organises and stores properties for dataset items"));

            entity.HasIndex(e => e.Category, "mdl_quesdatadefi_cat_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasColumnType("bigint(10)")
                .HasColumnName("category");
            entity.Property(e => e.Itemcount)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemcount");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Options)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("options");
            entity.Property(e => e.Type)
                .HasColumnType("bigint(10)")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlQuestionDatasetItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_dataset_items", tb => tb.HasComment("Individual dataset items"));

            entity.HasIndex(e => e.Definition, "mdl_quesdataitem_def_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Definition)
                .HasColumnType("bigint(10)")
                .HasColumnName("definition");
            entity.Property(e => e.Itemnumber)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemnumber");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlQuestionDdwto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_ddwtos", tb => tb.HasComment("Defines drag and drop (words into sentences) questions"));

            entity.HasIndex(e => e.Questionid, "mdl_quesddwt_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect)
                .HasColumnType("tinyint(2)")
                .HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("shuffleanswers");
        });

        modelBuilder.Entity<MdlQuestionGapselect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_gapselect", tb => tb.HasComment("Defines select missing words questions"));

            entity.HasIndex(e => e.Questionid, "mdl_quesgaps_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Correctfeedback).HasColumnName("correctfeedback");
            entity.Property(e => e.Correctfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("correctfeedbackformat");
            entity.Property(e => e.Incorrectfeedback).HasColumnName("incorrectfeedback");
            entity.Property(e => e.Incorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("incorrectfeedbackformat");
            entity.Property(e => e.Partiallycorrectfeedback).HasColumnName("partiallycorrectfeedback");
            entity.Property(e => e.Partiallycorrectfeedbackformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("partiallycorrectfeedbackformat");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect)
                .HasColumnType("tinyint(2)")
                .HasColumnName("shownumcorrect");
            entity.Property(e => e.Shuffleanswers)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("shuffleanswers");
        });

        modelBuilder.Entity<MdlQuestionGradertest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_gradertest", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Availablefromhome).HasColumnName("availablefromhome");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
        });

        modelBuilder.Entity<MdlQuestionGradertestTasktest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_gradertest_tasktest", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Poasassignmenttaskid)
                .HasColumnType("bigint(10)")
                .HasColumnName("poasassignmenttaskid");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
        });

        modelBuilder.Entity<MdlQuestionGradertestTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_gradertest_tests", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Testdirpath)
                .HasMaxLength(255)
                .HasColumnName("testdirpath");
            entity.Property(e => e.Testin).HasColumnName("testin");
            entity.Property(e => e.Testout).HasColumnName("testout");
        });

        modelBuilder.Entity<MdlQuestionHint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_hints", tb => tb.HasComment("Stores the the part of the question definition that gives di"));

            entity.HasIndex(e => e.Questionid, "mdl_queshint_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Clearwrong).HasColumnName("clearwrong");
            entity.Property(e => e.Hint).HasColumnName("hint");
            entity.Property(e => e.Hintformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("hintformat");
            entity.Property(e => e.Options)
                .HasMaxLength(255)
                .HasColumnName("options");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Shownumcorrect).HasColumnName("shownumcorrect");
        });

        modelBuilder.Entity<MdlQuestionMultianswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_multianswer", tb => tb.HasComment("Options for multianswer questions"));

            entity.HasIndex(e => e.Question, "mdl_quesmult_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Question)
                .HasColumnType("bigint(10)")
                .HasColumnName("question");
            entity.Property(e => e.Sequence).HasColumnName("sequence");
        });

        modelBuilder.Entity<MdlQuestionNumerical>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_numerical", tb => tb.HasComment("Options for numerical questions."));

            entity.HasIndex(e => e.Answer, "mdl_quesnume_ans_ix");

            entity.HasIndex(e => e.Question, "mdl_quesnume_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answer)
                .HasColumnType("bigint(10)")
                .HasColumnName("answer");
            entity.Property(e => e.Question)
                .HasColumnType("bigint(10)")
                .HasColumnName("question");
            entity.Property(e => e.Tolerance)
                .HasMaxLength(255)
                .HasDefaultValueSql("'0.0'")
                .HasColumnName("tolerance");
        });

        modelBuilder.Entity<MdlQuestionNumericalOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_numerical_options", tb => tb.HasComment("Options for questions of type numerical This table is also u"));

            entity.HasIndex(e => e.Question, "mdl_quesnumeopti_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Question)
                .HasColumnType("bigint(10)")
                .HasColumnName("question");
            entity.Property(e => e.Showunits)
                .HasColumnType("smallint(4)")
                .HasColumnName("showunits");
            entity.Property(e => e.Unitgradingtype)
                .HasColumnType("smallint(4)")
                .HasColumnName("unitgradingtype");
            entity.Property(e => e.Unitpenalty)
                .HasPrecision(12, 7)
                .HasDefaultValueSql("'0.1000000'")
                .HasColumnName("unitpenalty");
            entity.Property(e => e.Unitsleft)
                .HasColumnType("smallint(4)")
                .HasColumnName("unitsleft");
        });

        modelBuilder.Entity<MdlQuestionNumericalUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_numerical_units", tb => tb.HasComment("Optional unit options for numerical questions. This table is"));

            entity.HasIndex(e => e.Question, "mdl_quesnumeunit_que_ix");

            entity.HasIndex(e => new { e.Question, e.Unit }, "mdl_quesnumeunit_queuni_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Multiplier)
                .HasPrecision(38, 19)
                .HasDefaultValueSql("'1.0000000000000000000'")
                .HasColumnName("multiplier");
            entity.Property(e => e.Question)
                .HasColumnType("bigint(10)")
                .HasColumnName("question");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("unit");
        });

        modelBuilder.Entity<MdlQuestionResponseAnalysis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_response_analysis", tb => tb.HasComment("Analysis of student responses given to questions."));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Aid)
                .HasMaxLength(100)
                .HasColumnName("aid");
            entity.Property(e => e.Credit)
                .HasPrecision(15, 5)
                .HasColumnName("credit");
            entity.Property(e => e.Hashcode)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("hashcode");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Response).HasColumnName("response");
            entity.Property(e => e.Subqid)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("subqid");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Variant)
                .HasColumnType("bigint(10)")
                .HasColumnName("variant");
            entity.Property(e => e.Whichtries)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("whichtries");
        });

        modelBuilder.Entity<MdlQuestionResponseCount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_response_count", tb => tb.HasComment("Count for each responses for each try at a question."));

            entity.HasIndex(e => e.Analysisid, "mdl_quesrespcoun_ana_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Analysisid)
                .HasColumnType("bigint(10)")
                .HasColumnName("analysisid");
            entity.Property(e => e.Rcount)
                .HasColumnType("bigint(10)")
                .HasColumnName("rcount");
            entity.Property(e => e.Try)
                .HasColumnType("bigint(10)")
                .HasColumnName("try");
        });

        modelBuilder.Entity<MdlQuestionStatistic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_statistics", tb => tb.HasComment("Statistics for individual questions used in an activity."));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Discriminationindex)
                .HasPrecision(15, 5)
                .HasColumnName("discriminationindex");
            entity.Property(e => e.Discriminativeefficiency)
                .HasPrecision(15, 5)
                .HasColumnName("discriminativeefficiency");
            entity.Property(e => e.Effectiveweight)
                .HasPrecision(15, 5)
                .HasColumnName("effectiveweight");
            entity.Property(e => e.Facility)
                .HasPrecision(15, 10)
                .HasColumnName("facility");
            entity.Property(e => e.Hashcode)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("hashcode");
            entity.Property(e => e.Maxmark)
                .HasPrecision(12, 7)
                .HasColumnName("maxmark");
            entity.Property(e => e.Negcovar)
                .HasColumnType("tinyint(2)")
                .HasColumnName("negcovar");
            entity.Property(e => e.Positions).HasColumnName("positions");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Randomguessscore)
                .HasPrecision(12, 7)
                .HasColumnName("randomguessscore");
            entity.Property(e => e.S)
                .HasColumnType("bigint(10)")
                .HasColumnName("s");
            entity.Property(e => e.Sd)
                .HasPrecision(15, 10)
                .HasColumnName("sd");
            entity.Property(e => e.Slot)
                .HasColumnType("bigint(10)")
                .HasColumnName("slot");
            entity.Property(e => e.Subquestion)
                .HasColumnType("smallint(4)")
                .HasColumnName("subquestion");
            entity.Property(e => e.Subquestions).HasColumnName("subquestions");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Variant)
                .HasColumnType("bigint(10)")
                .HasColumnName("variant");
        });

        modelBuilder.Entity<MdlQuestionTruefalse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_truefalse", tb => tb.HasComment("Options for True-False questions"));

            entity.HasIndex(e => e.Question, "mdl_questrue_que_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Falseanswer)
                .HasColumnType("bigint(10)")
                .HasColumnName("falseanswer");
            entity.Property(e => e.Question)
                .HasColumnType("bigint(10)")
                .HasColumnName("question");
            entity.Property(e => e.Trueanswer)
                .HasColumnType("bigint(10)")
                .HasColumnName("trueanswer");
        });

        modelBuilder.Entity<MdlQuestionUsage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_question_usages", tb => tb.HasComment("This table's main purpose it to assign a unique id to each a"));

            entity.HasIndex(e => e.Contextid, "mdl_quesusag_con_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Preferredbehaviour)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("preferredbehaviour");
        });

        modelBuilder.Entity<MdlQuiz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quiz", tb => tb.HasComment("The settings for each quiz."));

            entity.HasIndex(e => e.Course, "mdl_quiz_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Allowofflineattempts)
                .HasDefaultValueSql("'0'")
                .HasColumnName("allowofflineattempts");
            entity.Property(e => e.Attemptonlast)
                .HasColumnType("smallint(4)")
                .HasColumnName("attemptonlast");
            entity.Property(e => e.Attempts)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("attempts");
            entity.Property(e => e.Browsersecurity)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("browsersecurity");
            entity.Property(e => e.Canredoquestions)
                .HasColumnType("smallint(4)")
                .HasColumnName("canredoquestions");
            entity.Property(e => e.Completionattemptsexhausted)
                .HasDefaultValueSql("'0'")
                .HasColumnName("completionattemptsexhausted");
            entity.Property(e => e.Completionpass)
                .HasDefaultValueSql("'0'")
                .HasColumnName("completionpass");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Decimalpoints)
                .HasDefaultValueSql("'2'")
                .HasColumnType("smallint(4)")
                .HasColumnName("decimalpoints");
            entity.Property(e => e.Delay1)
                .HasColumnType("bigint(10)")
                .HasColumnName("delay1");
            entity.Property(e => e.Delay2)
                .HasColumnType("bigint(10)")
                .HasColumnName("delay2");
            entity.Property(e => e.Graceperiod)
                .HasColumnType("bigint(10)")
                .HasColumnName("graceperiod");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Grademethod)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("grademethod");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Navmethod)
                .HasMaxLength(16)
                .HasDefaultValueSql("'free'")
                .HasColumnName("navmethod");
            entity.Property(e => e.Overduehandling)
                .HasMaxLength(16)
                .HasDefaultValueSql("'autoabandon'")
                .HasColumnName("overduehandling");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
            entity.Property(e => e.Preferredbehaviour)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("preferredbehaviour");
            entity.Property(e => e.Questiondecimalpoints)
                .HasDefaultValueSql("-1")
                .HasColumnType("smallint(4)")
                .HasColumnName("questiondecimalpoints");
            entity.Property(e => e.Questionsperpage)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionsperpage");
            entity.Property(e => e.Reviewattempt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("reviewattempt");
            entity.Property(e => e.Reviewcorrectness)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("reviewcorrectness");
            entity.Property(e => e.Reviewgeneralfeedback)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("reviewgeneralfeedback");
            entity.Property(e => e.Reviewmarks)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("reviewmarks");
            entity.Property(e => e.Reviewoverallfeedback)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("reviewoverallfeedback");
            entity.Property(e => e.Reviewrightanswer)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("reviewrightanswer");
            entity.Property(e => e.Reviewspecificfeedback)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("reviewspecificfeedback");
            entity.Property(e => e.Showblocks)
                .HasColumnType("smallint(4)")
                .HasColumnName("showblocks");
            entity.Property(e => e.Showuserpicture)
                .HasColumnType("smallint(4)")
                .HasColumnName("showuserpicture");
            entity.Property(e => e.Shuffleanswers)
                .HasColumnType("smallint(4)")
                .HasColumnName("shuffleanswers");
            entity.Property(e => e.Subnet)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("subnet");
            entity.Property(e => e.Sumgrades)
                .HasPrecision(10, 5)
                .HasColumnName("sumgrades");
            entity.Property(e => e.Timeclose)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeclose");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timelimit)
                .HasColumnType("bigint(10)")
                .HasColumnName("timelimit");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timeopen)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeopen");
        });

        modelBuilder.Entity<MdlQuizAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quiz_attempts", tb => tb.HasComment("Stores users attempts at quizzes."));

            entity.HasIndex(e => e.Quiz, "mdl_quizatte_qui_ix");

            entity.HasIndex(e => new { e.Quiz, e.Userid, e.Attempt }, "mdl_quizatte_quiuseatt_uix").IsUnique();

            entity.HasIndex(e => new { e.State, e.Timecheckstate }, "mdl_quizatte_statim_ix");

            entity.HasIndex(e => e.Uniqueid, "mdl_quizatte_uni_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_quizatte_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attempt)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("attempt");
            entity.Property(e => e.Currentpage)
                .HasColumnType("bigint(10)")
                .HasColumnName("currentpage");
            entity.Property(e => e.Layout).HasColumnName("layout");
            entity.Property(e => e.Preview)
                .HasColumnType("smallint(3)")
                .HasColumnName("preview");
            entity.Property(e => e.Quiz)
                .HasColumnType("bigint(10)")
                .HasColumnName("quiz");
            entity.Property(e => e.State)
                .HasMaxLength(16)
                .HasDefaultValueSql("'inprogress'")
                .HasColumnName("state");
            entity.Property(e => e.Sumgrades)
                .HasPrecision(10, 5)
                .HasColumnName("sumgrades");
            entity.Property(e => e.Timecheckstate)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("timecheckstate");
            entity.Property(e => e.Timefinish)
                .HasColumnType("bigint(10)")
                .HasColumnName("timefinish");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timemodifiedoffline)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodifiedoffline");
            entity.Property(e => e.Timestart)
                .HasColumnType("bigint(10)")
                .HasColumnName("timestart");
            entity.Property(e => e.Uniqueid)
                .HasColumnType("bigint(10)")
                .HasColumnName("uniqueid");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlQuizFeedback>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quiz_feedback", tb => tb.HasComment("Feedback given to students based on which grade band their o"));

            entity.HasIndex(e => e.Quizid, "mdl_quizfeed_qui_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Feedbacktext).HasColumnName("feedbacktext");
            entity.Property(e => e.Feedbacktextformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("feedbacktextformat");
            entity.Property(e => e.Maxgrade)
                .HasPrecision(10, 5)
                .HasColumnName("maxgrade");
            entity.Property(e => e.Mingrade)
                .HasPrecision(10, 5)
                .HasColumnName("mingrade");
            entity.Property(e => e.Quizid)
                .HasColumnType("bigint(10)")
                .HasColumnName("quizid");
        });

        modelBuilder.Entity<MdlQuizGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quiz_grades", tb => tb.HasComment("Stores the overall grade for each user on the quiz, based on"));

            entity.HasIndex(e => e.Quiz, "mdl_quizgrad_qui_ix");

            entity.HasIndex(e => e.Userid, "mdl_quizgrad_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Quiz)
                .HasColumnType("bigint(10)")
                .HasColumnName("quiz");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlQuizOverride>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quiz_overrides", tb => tb.HasComment("The overrides to quiz settings on a per-user and per-group b"));

            entity.HasIndex(e => e.Groupid, "mdl_quizover_gro_ix");

            entity.HasIndex(e => e.Quiz, "mdl_quizover_qui_ix");

            entity.HasIndex(e => e.Userid, "mdl_quizover_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attempts)
                .HasColumnType("mediumint(6)")
                .HasColumnName("attempts");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Quiz)
                .HasColumnType("bigint(10)")
                .HasColumnName("quiz");
            entity.Property(e => e.Timeclose)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeclose");
            entity.Property(e => e.Timelimit)
                .HasColumnType("bigint(10)")
                .HasColumnName("timelimit");
            entity.Property(e => e.Timeopen)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeopen");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlQuizOverviewRegrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quiz_overview_regrades", tb => tb.HasComment("This table records which question attempts need regrading an"));

            entity.HasIndex(e => new { e.Questionusageid, e.Slot }, "mdl_quizoverregr_queslo_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Newfraction)
                .HasPrecision(12, 7)
                .HasColumnName("newfraction");
            entity.Property(e => e.Oldfraction)
                .HasPrecision(12, 7)
                .HasColumnName("oldfraction");
            entity.Property(e => e.Questionusageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionusageid");
            entity.Property(e => e.Regraded)
                .HasColumnType("smallint(4)")
                .HasColumnName("regraded");
            entity.Property(e => e.Slot)
                .HasColumnType("bigint(10)")
                .HasColumnName("slot");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlQuizReport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quiz_reports", tb => tb.HasComment("Lists all the installed quiz reports and their display order"));

            entity.HasIndex(e => e.Name, "mdl_quizrepo_nam_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Capability)
                .HasMaxLength(255)
                .HasColumnName("capability");
            entity.Property(e => e.Displayorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("displayorder");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<MdlQuizSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quiz_sections", tb => tb.HasComment("Stores sections of a quiz with section name (heading), from "));

            entity.HasIndex(e => e.Quizid, "mdl_quizsect_qui_ix");

            entity.HasIndex(e => new { e.Quizid, e.Firstslot }, "mdl_quizsect_quifir_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Firstslot)
                .HasColumnType("bigint(10)")
                .HasColumnName("firstslot");
            entity.Property(e => e.Heading)
                .HasMaxLength(1333)
                .HasColumnName("heading");
            entity.Property(e => e.Quizid)
                .HasColumnType("bigint(10)")
                .HasColumnName("quizid");
            entity.Property(e => e.Shufflequestions)
                .HasColumnType("smallint(4)")
                .HasColumnName("shufflequestions");
        });

        modelBuilder.Entity<MdlQuizSlot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quiz_slots", tb => tb.HasComment("Stores the question used in a quiz, with the order, and for "));

            entity.HasIndex(e => e.Questioncategoryid, "mdl_quizslot_que2_ix");

            entity.HasIndex(e => e.Questionid, "mdl_quizslot_que_ix");

            entity.HasIndex(e => e.Quizid, "mdl_quizslot_qui_ix");

            entity.HasIndex(e => new { e.Quizid, e.Slot }, "mdl_quizslot_quislo_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Includingsubcategories)
                .HasColumnType("smallint(4)")
                .HasColumnName("includingsubcategories");
            entity.Property(e => e.Maxmark)
                .HasPrecision(12, 7)
                .HasColumnName("maxmark");
            entity.Property(e => e.Page)
                .HasColumnType("bigint(10)")
                .HasColumnName("page");
            entity.Property(e => e.Questioncategoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questioncategoryid");
            entity.Property(e => e.Questionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("questionid");
            entity.Property(e => e.Quizid)
                .HasColumnType("bigint(10)")
                .HasColumnName("quizid");
            entity.Property(e => e.Requireprevious)
                .HasColumnType("smallint(4)")
                .HasColumnName("requireprevious");
            entity.Property(e => e.Slot)
                .HasColumnType("bigint(10)")
                .HasColumnName("slot");
        });

        modelBuilder.Entity<MdlQuizSlotTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quiz_slot_tags", tb => tb.HasComment("Stores data about the tags that a question must have so that"));

            entity.HasIndex(e => e.Slotid, "mdl_quizslottags_slo_ix");

            entity.HasIndex(e => e.Tagid, "mdl_quizslottags_tag_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Slotid)
                .HasColumnType("bigint(10)")
                .HasColumnName("slotid");
            entity.Property(e => e.Tagid)
                .HasColumnType("bigint(10)")
                .HasColumnName("tagid");
            entity.Property(e => e.Tagname)
                .HasMaxLength(255)
                .HasColumnName("tagname");
        });

        modelBuilder.Entity<MdlQuizStatistic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quiz_statistics", tb => tb.HasComment("table to cache results from analysis done in statistics repo"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Allattemptsavg)
                .HasPrecision(15, 5)
                .HasColumnName("allattemptsavg");
            entity.Property(e => e.Allattemptscount)
                .HasColumnType("bigint(10)")
                .HasColumnName("allattemptscount");
            entity.Property(e => e.Cic)
                .HasPrecision(15, 10)
                .HasColumnName("cic");
            entity.Property(e => e.Errorratio)
                .HasPrecision(15, 10)
                .HasColumnName("errorratio");
            entity.Property(e => e.Firstattemptsavg)
                .HasPrecision(15, 5)
                .HasColumnName("firstattemptsavg");
            entity.Property(e => e.Firstattemptscount)
                .HasColumnType("bigint(10)")
                .HasColumnName("firstattemptscount");
            entity.Property(e => e.Hashcode)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .HasColumnName("hashcode");
            entity.Property(e => e.Highestattemptsavg)
                .HasPrecision(15, 5)
                .HasColumnName("highestattemptsavg");
            entity.Property(e => e.Highestattemptscount)
                .HasColumnType("bigint(10)")
                .HasColumnName("highestattemptscount");
            entity.Property(e => e.Kurtosis)
                .HasPrecision(15, 5)
                .HasColumnName("kurtosis");
            entity.Property(e => e.Lastattemptsavg)
                .HasPrecision(15, 5)
                .HasColumnName("lastattemptsavg");
            entity.Property(e => e.Lastattemptscount)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastattemptscount");
            entity.Property(e => e.Median)
                .HasPrecision(15, 5)
                .HasColumnName("median");
            entity.Property(e => e.Skewness)
                .HasPrecision(15, 10)
                .HasColumnName("skewness");
            entity.Property(e => e.Standarddeviation)
                .HasPrecision(15, 5)
                .HasColumnName("standarddeviation");
            entity.Property(e => e.Standarderror)
                .HasPrecision(15, 10)
                .HasColumnName("standarderror");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Whichattempts)
                .HasColumnType("smallint(4)")
                .HasColumnName("whichattempts");
        });

        modelBuilder.Entity<MdlQuizaccessSebQuizsetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quizaccess_seb_quizsettings", tb => tb.HasComment("Stores the quiz level Safe Exam Browser configuration."));

            entity.HasIndex(e => e.Cmid, "mdl_quizsebquiz_cmi_uix").IsUnique();

            entity.HasIndex(e => e.Quizid, "mdl_quizsebquiz_qui_uix").IsUnique();

            entity.HasIndex(e => e.Templateid, "mdl_quizsebquiz_tem_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_quizsebquiz_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Activateurlfiltering).HasColumnName("activateurlfiltering");
            entity.Property(e => e.Allowedbrowserexamkeys).HasColumnName("allowedbrowserexamkeys");
            entity.Property(e => e.Allowreloadinexam).HasColumnName("allowreloadinexam");
            entity.Property(e => e.Allowspellchecking).HasColumnName("allowspellchecking");
            entity.Property(e => e.Allowuserquitseb).HasColumnName("allowuserquitseb");
            entity.Property(e => e.Cmid)
                .HasColumnType("bigint(10)")
                .HasColumnName("cmid");
            entity.Property(e => e.Enableaudiocontrol).HasColumnName("enableaudiocontrol");
            entity.Property(e => e.Expressionsallowed).HasColumnName("expressionsallowed");
            entity.Property(e => e.Expressionsblocked).HasColumnName("expressionsblocked");
            entity.Property(e => e.Filterembeddedcontent).HasColumnName("filterembeddedcontent");
            entity.Property(e => e.Linkquitseb).HasColumnName("linkquitseb");
            entity.Property(e => e.Muteonstartup).HasColumnName("muteonstartup");
            entity.Property(e => e.Quitpassword).HasColumnName("quitpassword");
            entity.Property(e => e.Quizid)
                .HasColumnType("bigint(10)")
                .HasColumnName("quizid");
            entity.Property(e => e.Regexallowed).HasColumnName("regexallowed");
            entity.Property(e => e.Regexblocked).HasColumnName("regexblocked");
            entity.Property(e => e.Requiresafeexambrowser).HasColumnName("requiresafeexambrowser");
            entity.Property(e => e.Showkeyboardlayout).HasColumnName("showkeyboardlayout");
            entity.Property(e => e.Showreloadbutton).HasColumnName("showreloadbutton");
            entity.Property(e => e.Showsebdownloadlink).HasColumnName("showsebdownloadlink");
            entity.Property(e => e.Showsebtaskbar).HasColumnName("showsebtaskbar");
            entity.Property(e => e.Showtime).HasColumnName("showtime");
            entity.Property(e => e.Showwificontrol).HasColumnName("showwificontrol");
            entity.Property(e => e.Templateid)
                .HasColumnType("bigint(10)")
                .HasColumnName("templateid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userconfirmquit).HasColumnName("userconfirmquit");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlQuizaccessSebTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_quizaccess_seb_template", tb => tb.HasComment("Templates for Safe Exam Browser configuration."));

            entity.HasIndex(e => e.Usermodified, "mdl_quizsebtemp_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlRating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_rating", tb => tb.HasComment("moodle ratings"));

            entity.HasIndex(e => new { e.Component, e.Ratingarea, e.Contextid, e.Itemid }, "mdl_rati_comratconite_ix");

            entity.HasIndex(e => e.Contextid, "mdl_rati_con_ix");

            entity.HasIndex(e => e.Userid, "mdl_rati_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Rating)
                .HasColumnType("bigint(10)")
                .HasColumnName("rating");
            entity.Property(e => e.Ratingarea)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("ratingarea");
            entity.Property(e => e.Scaleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scaleid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlRegistrationHub>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_registration_hubs", tb => tb.HasComment("hub where the site is registered on with their associated to"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Confirmed).HasColumnName("confirmed");
            entity.Property(e => e.Hubname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("hubname");
            entity.Property(e => e.Huburl)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("huburl");
            entity.Property(e => e.Secret)
                .HasMaxLength(255)
                .HasColumnName("secret");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
        });

        modelBuilder.Entity<MdlRepository>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_repository", tb => tb.HasComment("This table contains one entry for every configured external "));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
            entity.Property(e => e.Visible)
                .HasDefaultValueSql("'1'")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlRepositoryInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_repository_instances", tb => tb.HasComment("This table contains one entry for every configured external "));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Readonly).HasColumnName("readonly");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Typeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("typeid");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<MdlRepositoryInstanceConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_repository_instance_config", tb => tb.HasComment("The config for intances"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Instanceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("instanceid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlRepositoryOnedriveAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_repository_onedrive_access", tb => tb.HasComment("List of temporary access grants."));

            entity.HasIndex(e => e.Usermodified, "mdl_repoonedacce_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Itemid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("itemid");
            entity.Property(e => e.Permissionid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("permissionid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_resource", tb => tb.HasComment("Each record is one resource and its config data"));

            entity.HasIndex(e => e.Course, "mdl_reso_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Display)
                .HasColumnType("smallint(4)")
                .HasColumnName("display");
            entity.Property(e => e.Displayoptions).HasColumnName("displayoptions");
            entity.Property(e => e.Filterfiles)
                .HasColumnType("smallint(4)")
                .HasColumnName("filterfiles");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Legacyfiles)
                .HasColumnType("smallint(4)")
                .HasColumnName("legacyfiles");
            entity.Property(e => e.Legacyfileslast)
                .HasColumnType("bigint(10)")
                .HasColumnName("legacyfileslast");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Revision)
                .HasColumnType("bigint(10)")
                .HasColumnName("revision");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Tobemigrated)
                .HasColumnType("smallint(4)")
                .HasColumnName("tobemigrated");
        });

        modelBuilder.Entity<MdlResourceOld>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_resource_old", tb => tb.HasComment("backup of all old resource instances from 1.9"));

            entity.HasIndex(e => e.Cmid, "mdl_resoold_cmi_ix");

            entity.HasIndex(e => e.Oldid, "mdl_resoold_old_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Alltext).HasColumnName("alltext");
            entity.Property(e => e.Cmid)
                .HasColumnType("bigint(10)")
                .HasColumnName("cmid");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Migrated)
                .HasColumnType("bigint(10)")
                .HasColumnName("migrated");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Newid)
                .HasColumnType("bigint(10)")
                .HasColumnName("newid");
            entity.Property(e => e.Newmodule)
                .HasMaxLength(50)
                .HasColumnName("newmodule");
            entity.Property(e => e.Oldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("oldid");
            entity.Property(e => e.Options)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("options");
            entity.Property(e => e.Popup).HasColumnName("popup");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("reference");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_role", tb => tb.HasComment("moodle roles"));

            entity.HasIndex(e => e.Shortname, "mdl_role_sho_uix").IsUnique();

            entity.HasIndex(e => e.Sortorder, "mdl_role_sor_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Archetype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("archetype");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Shortname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlRoleAllowAssign>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_role_allow_assign", tb => tb.HasComment("this defines what role can assign what role"));

            entity.HasIndex(e => e.Allowassign, "mdl_rolealloassi_all_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolealloassi_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Allowassign }, "mdl_rolealloassi_rolall_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Allowassign)
                .HasColumnType("bigint(10)")
                .HasColumnName("allowassign");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlRoleAllowOverride>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_role_allow_override", tb => tb.HasComment("this defines what role can override what role"));

            entity.HasIndex(e => e.Allowoverride, "mdl_rolealloover_all_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolealloover_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Allowoverride }, "mdl_rolealloover_rolall_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Allowoverride)
                .HasColumnType("bigint(10)")
                .HasColumnName("allowoverride");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlRoleAllowSwitch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_role_allow_switch", tb => tb.HasComment("This table stores which which other roles a user is allowed "));

            entity.HasIndex(e => e.Allowswitch, "mdl_rolealloswit_all_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolealloswit_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Allowswitch }, "mdl_rolealloswit_rolall_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Allowswitch)
                .HasColumnType("bigint(10)")
                .HasColumnName("allowswitch");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlRoleAllowView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_role_allow_view", tb => tb.HasComment("This table stores which which other roles a user is allowed "));

            entity.HasIndex(e => e.Allowview, "mdl_rolealloview_all_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolealloview_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Allowview }, "mdl_rolealloview_rolall_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Allowview)
                .HasColumnType("bigint(10)")
                .HasColumnName("allowview");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlRoleAssignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_role_assignments", tb => tb.HasComment("assigning roles in different context"));

            entity.HasIndex(e => new { e.Component, e.Itemid, e.Userid }, "mdl_roleassi_comiteuse_ix");

            entity.HasIndex(e => e.Contextid, "mdl_roleassi_con_ix");

            entity.HasIndex(e => e.Roleid, "mdl_roleassi_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Contextid }, "mdl_roleassi_rolcon_ix");

            entity.HasIndex(e => e.Sortorder, "mdl_roleassi_sor_ix");

            entity.HasIndex(e => e.Userid, "mdl_roleassi_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Contextid, e.Roleid }, "mdl_roleassi_useconrol_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Modifierid)
                .HasColumnType("bigint(10)")
                .HasColumnName("modifierid");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlRoleCapability>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_role_capabilities", tb => tb.HasComment("permission has to be signed, overriding a capability for a p"));

            entity.HasIndex(e => e.Capability, "mdl_rolecapa_cap_ix");

            entity.HasIndex(e => e.Contextid, "mdl_rolecapa_con_ix");

            entity.HasIndex(e => e.Modifierid, "mdl_rolecapa_mod_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolecapa_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Contextid, e.Capability }, "mdl_rolecapa_rolconcap_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Capability)
                .HasDefaultValueSql("''")
                .HasColumnName("capability");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Modifierid)
                .HasColumnType("bigint(10)")
                .HasColumnName("modifierid");
            entity.Property(e => e.Permission)
                .HasColumnType("bigint(10)")
                .HasColumnName("permission");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlRoleContextLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_role_context_levels", tb => tb.HasComment("Lists which roles can be assigned at which context levels. T"));

            entity.HasIndex(e => new { e.Contextlevel, e.Roleid }, "mdl_rolecontleve_conrol_uix").IsUnique();

            entity.HasIndex(e => e.Roleid, "mdl_rolecontleve_rol_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextlevel)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextlevel");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlRoleName>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_role_names", tb => tb.HasComment("role names in native strings"));

            entity.HasIndex(e => e.Contextid, "mdl_rolename_con_ix");

            entity.HasIndex(e => e.Roleid, "mdl_rolename_rol_ix");

            entity.HasIndex(e => new { e.Roleid, e.Contextid }, "mdl_rolename_rolcon_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
        });

        modelBuilder.Entity<MdlScale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scale", tb => tb.HasComment("Defines grading scales"));

            entity.HasIndex(e => e.Courseid, "mdl_scal_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Scale).HasColumnName("scale");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlScaleHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scale_history", tb => tb.HasComment("History table"));

            entity.HasIndex(e => e.Action, "mdl_scalhist_act_ix");

            entity.HasIndex(e => e.Courseid, "mdl_scalhist_cou_ix");

            entity.HasIndex(e => e.Loggeduser, "mdl_scalhist_log_ix");

            entity.HasIndex(e => e.Oldid, "mdl_scalhist_old_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_scalhist_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasColumnType("bigint(10)")
                .HasColumnName("action");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Loggeduser)
                .HasColumnType("bigint(10)")
                .HasColumnName("loggeduser");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Oldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("oldid");
            entity.Property(e => e.Scale).HasColumnName("scale");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("source");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlScorm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scorm", tb => tb.HasComment("each table is one SCORM module and its configuration"));

            entity.HasIndex(e => e.Course, "mdl_scor_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Auto).HasColumnName("auto");
            entity.Property(e => e.Autocommit).HasColumnName("autocommit");
            entity.Property(e => e.Completionscorerequired)
                .HasColumnType("bigint(10)")
                .HasColumnName("completionscorerequired");
            entity.Property(e => e.Completionstatusallscos).HasColumnName("completionstatusallscos");
            entity.Property(e => e.Completionstatusrequired).HasColumnName("completionstatusrequired");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Displayactivityname)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(4)")
                .HasColumnName("displayactivityname");
            entity.Property(e => e.Displayattemptstatus)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("displayattemptstatus");
            entity.Property(e => e.Displaycoursestructure).HasColumnName("displaycoursestructure");
            entity.Property(e => e.Forcecompleted).HasColumnName("forcecompleted");
            entity.Property(e => e.Forcenewattempt).HasColumnName("forcenewattempt");
            entity.Property(e => e.Grademethod)
                .HasColumnType("tinyint(2)")
                .HasColumnName("grademethod");
            entity.Property(e => e.Height)
                .HasDefaultValueSql("'600'")
                .HasColumnType("bigint(10)")
                .HasColumnName("height");
            entity.Property(e => e.Hidebrowse).HasColumnName("hidebrowse");
            entity.Property(e => e.Hidetoc).HasColumnName("hidetoc");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Lastattemptlock).HasColumnName("lastattemptlock");
            entity.Property(e => e.Launch)
                .HasColumnType("bigint(10)")
                .HasColumnName("launch");
            entity.Property(e => e.Masteryoverride)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("masteryoverride");
            entity.Property(e => e.Maxattempt)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("maxattempt");
            entity.Property(e => e.Maxgrade).HasColumnName("maxgrade");
            entity.Property(e => e.Md5hash)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("md5hash");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Nav)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("nav");
            entity.Property(e => e.Navpositionleft)
                .HasDefaultValueSql("-100")
                .HasColumnType("bigint(10)")
                .HasColumnName("navpositionleft");
            entity.Property(e => e.Navpositiontop)
                .HasDefaultValueSql("-100")
                .HasColumnType("bigint(10)")
                .HasColumnName("navpositiontop");
            entity.Property(e => e.Options)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("options");
            entity.Property(e => e.Popup).HasColumnName("popup");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("reference");
            entity.Property(e => e.Revision)
                .HasColumnType("bigint(10)")
                .HasColumnName("revision");
            entity.Property(e => e.Scormtype)
                .HasMaxLength(50)
                .HasDefaultValueSql("'local'")
                .HasColumnName("scormtype");
            entity.Property(e => e.Sha1hash)
                .HasMaxLength(40)
                .HasColumnName("sha1hash");
            entity.Property(e => e.Skipview)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("skipview");
            entity.Property(e => e.Timeclose)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeclose");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timeopen)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeopen");
            entity.Property(e => e.Updatefreq).HasColumnName("updatefreq");
            entity.Property(e => e.Version)
                .HasMaxLength(9)
                .HasDefaultValueSql("''")
                .HasColumnName("version");
            entity.Property(e => e.Whatgrade)
                .HasColumnType("bigint(10)")
                .HasColumnName("whatgrade");
            entity.Property(e => e.Width)
                .HasDefaultValueSql("'100'")
                .HasColumnType("bigint(10)")
                .HasColumnName("width");
        });

        modelBuilder.Entity<MdlScormAiccSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scorm_aicc_session", tb => tb.HasComment("Used by AICC HACP to store session information"));

            entity.HasIndex(e => e.Scormid, "mdl_scoraiccsess_sco_ix");

            entity.HasIndex(e => e.Userid, "mdl_scoraiccsess_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attempt)
                .HasColumnType("bigint(10)")
                .HasColumnName("attempt");
            entity.Property(e => e.Hacpsession)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("hacpsession");
            entity.Property(e => e.Lessonstatus)
                .HasMaxLength(255)
                .HasColumnName("lessonstatus");
            entity.Property(e => e.Scoid)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("scoid");
            entity.Property(e => e.Scormid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scormid");
            entity.Property(e => e.Scormmode)
                .HasMaxLength(50)
                .HasColumnName("scormmode");
            entity.Property(e => e.Scormstatus)
                .HasMaxLength(255)
                .HasColumnName("scormstatus");
            entity.Property(e => e.Sessiontime)
                .HasMaxLength(255)
                .HasColumnName("sessiontime");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlScormSco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scorm_scoes", tb => tb.HasComment("each SCO part of the SCORM module"));

            entity.HasIndex(e => e.Scorm, "mdl_scorscoe_sco_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Identifier)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("identifier");
            entity.Property(e => e.Launch).HasColumnName("launch");
            entity.Property(e => e.Manifest)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("manifest");
            entity.Property(e => e.Organization)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("organization");
            entity.Property(e => e.Parent)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("parent");
            entity.Property(e => e.Scorm)
                .HasColumnType("bigint(10)")
                .HasColumnName("scorm");
            entity.Property(e => e.Scormtype)
                .HasMaxLength(5)
                .HasDefaultValueSql("''")
                .HasColumnName("scormtype");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
        });

        modelBuilder.Entity<MdlScormScoesDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scorm_scoes_data", tb => tb.HasComment("Contains variable data get from packages"));

            entity.HasIndex(e => e.Scoid, "mdl_scorscoedata_sco_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Scoid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scoid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlScormScoesTrack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scorm_scoes_track", tb => tb.HasComment("to track SCOes"));

            entity.HasIndex(e => e.Scoid, "mdl_scorscoetrac_sco2_ix");

            entity.HasIndex(e => e.Scormid, "mdl_scorscoetrac_sco_ix");

            entity.HasIndex(e => e.Userid, "mdl_scorscoetrac_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Scormid, e.Scoid, e.Attempt, e.Element }, "mdl_scorscoetrac_usescosco_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attempt)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("attempt");
            entity.Property(e => e.Element)
                .HasDefaultValueSql("''")
                .HasColumnName("element");
            entity.Property(e => e.Scoid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scoid");
            entity.Property(e => e.Scormid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scormid");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<MdlScormSeqMapinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scorm_seq_mapinfo", tb => tb.HasComment("SCORM2004 objective mapinfo description"));

            entity.HasIndex(e => e.Objectiveid, "mdl_scorseqmapi_obj_ix");

            entity.HasIndex(e => e.Scoid, "mdl_scorseqmapi_sco_ix");

            entity.HasIndex(e => new { e.Scoid, e.Id, e.Objectiveid }, "mdl_scorseqmapi_scoidobj_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Objectiveid)
                .HasColumnType("bigint(10)")
                .HasColumnName("objectiveid");
            entity.Property(e => e.Readnormalizedmeasure)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("readnormalizedmeasure");
            entity.Property(e => e.Readsatisfiedstatus)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("readsatisfiedstatus");
            entity.Property(e => e.Scoid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scoid");
            entity.Property(e => e.Targetobjectiveid)
                .HasColumnType("bigint(10)")
                .HasColumnName("targetobjectiveid");
            entity.Property(e => e.Writenormalizedmeasure).HasColumnName("writenormalizedmeasure");
            entity.Property(e => e.Writesatisfiedstatus).HasColumnName("writesatisfiedstatus");
        });

        modelBuilder.Entity<MdlScormSeqObjective>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scorm_seq_objective", tb => tb.HasComment("SCORM2004 objective description"));

            entity.HasIndex(e => e.Scoid, "mdl_scorseqobje_sco_ix");

            entity.HasIndex(e => new { e.Scoid, e.Id }, "mdl_scorseqobje_scoid_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Minnormalizedmeasure)
                .HasColumnType("float(11,4)")
                .HasColumnName("minnormalizedmeasure");
            entity.Property(e => e.Objectiveid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("objectiveid");
            entity.Property(e => e.Primaryobj).HasColumnName("primaryobj");
            entity.Property(e => e.Satisfiedbymeasure)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("satisfiedbymeasure");
            entity.Property(e => e.Scoid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scoid");
        });

        modelBuilder.Entity<MdlScormSeqRolluprule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scorm_seq_rolluprule", tb => tb.HasComment("SCORM2004 sequencing rule"));

            entity.HasIndex(e => e.Scoid, "mdl_scorseqroll_sco_ix");

            entity.HasIndex(e => new { e.Scoid, e.Id }, "mdl_scorseqroll_scoid_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Childactivityset)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("childactivityset");
            entity.Property(e => e.Conditioncombination)
                .HasMaxLength(3)
                .HasDefaultValueSql("'all'")
                .HasColumnName("conditioncombination");
            entity.Property(e => e.Minimumcount)
                .HasColumnType("bigint(10)")
                .HasColumnName("minimumcount");
            entity.Property(e => e.Minimumpercent)
                .HasColumnType("float(11,4)")
                .HasColumnName("minimumpercent");
            entity.Property(e => e.Scoid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scoid");
        });

        modelBuilder.Entity<MdlScormSeqRolluprulecond>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scorm_seq_rolluprulecond", tb => tb.HasComment("SCORM2004 sequencing rule"));

            entity.HasIndex(e => e.Rollupruleid, "mdl_scorseqroll_rol_ix");

            entity.HasIndex(e => e.Scoid, "mdl_scorseqroll_sco2_ix");

            entity.HasIndex(e => new { e.Scoid, e.Rollupruleid, e.Id }, "mdl_scorseqroll_scorolid_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cond)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("cond");
            entity.Property(e => e.Operator)
                .HasMaxLength(5)
                .HasDefaultValueSql("'noOp'")
                .HasColumnName("operator");
            entity.Property(e => e.Rollupruleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("rollupruleid");
            entity.Property(e => e.Scoid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scoid");
        });

        modelBuilder.Entity<MdlScormSeqRulecond>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scorm_seq_rulecond", tb => tb.HasComment("SCORM2004 rule condition"));

            entity.HasIndex(e => new { e.Id, e.Scoid, e.Ruleconditionsid }, "mdl_scorseqrule_idscorul_uix").IsUnique();

            entity.HasIndex(e => e.Ruleconditionsid, "mdl_scorseqrule_rul_ix");

            entity.HasIndex(e => e.Scoid, "mdl_scorseqrule_sco2_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cond)
                .HasMaxLength(30)
                .HasDefaultValueSql("'always'")
                .HasColumnName("cond");
            entity.Property(e => e.Measurethreshold)
                .HasColumnType("float(11,4)")
                .HasColumnName("measurethreshold");
            entity.Property(e => e.Operator)
                .HasMaxLength(5)
                .HasDefaultValueSql("'noOp'")
                .HasColumnName("operator");
            entity.Property(e => e.Refrencedobjective)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("refrencedobjective");
            entity.Property(e => e.Ruleconditionsid)
                .HasColumnType("bigint(10)")
                .HasColumnName("ruleconditionsid");
            entity.Property(e => e.Scoid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scoid");
        });

        modelBuilder.Entity<MdlScormSeqRulecond1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_scorm_seq_ruleconds", tb => tb.HasComment("SCORM2004 rule conditions"));

            entity.HasIndex(e => e.Scoid, "mdl_scorseqrule_sco_ix");

            entity.HasIndex(e => new { e.Scoid, e.Id }, "mdl_scorseqrule_scoid_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("action");
            entity.Property(e => e.Conditioncombination)
                .HasMaxLength(3)
                .HasDefaultValueSql("'all'")
                .HasColumnName("conditioncombination");
            entity.Property(e => e.Ruletype)
                .HasColumnType("tinyint(2)")
                .HasColumnName("ruletype");
            entity.Property(e => e.Scoid)
                .HasColumnType("bigint(10)")
                .HasColumnName("scoid");
        });

        modelBuilder.Entity<MdlSearchIndexRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_search_index_requests", tb => tb.HasComment("Records requests for (re)indexing of specific contexts. Entr"));

            entity.HasIndex(e => e.Contextid, "mdl_searinderequ_con_ix");

            entity.HasIndex(e => new { e.Indexpriority, e.Timerequested }, "mdl_searinderequ_indtim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Indexpriority)
                .HasColumnType("bigint(10)")
                .HasColumnName("indexpriority");
            entity.Property(e => e.Partialarea)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("partialarea");
            entity.Property(e => e.Partialtime)
                .HasColumnType("bigint(10)")
                .HasColumnName("partialtime");
            entity.Property(e => e.Searcharea)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("searcharea");
            entity.Property(e => e.Timerequested)
                .HasColumnType("bigint(10)")
                .HasColumnName("timerequested");
        });

        modelBuilder.Entity<MdlSearchSimpledbIndex>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_search_simpledb_index", tb => tb.HasComment("search_simpledb table containing the index data."));

            entity.HasIndex(e => new { e.Title, e.Content, e.Description1, e.Description2 }, "mdl_search_simpledb_index_index").HasAnnotation("MySql:FullTextIndex", true);

            entity.HasIndex(e => e.Docid, "mdl_searsimpinde_doc_uix").IsUnique();

            entity.HasIndex(e => new { e.Owneruserid, e.Contextid }, "mdl_searsimpinde_owncon_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Areaid)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("areaid");
            entity.Property(e => e.Content)
                .HasColumnType("longtext")
                .HasColumnName("content");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Description1)
                .HasColumnType("longtext")
                .HasColumnName("description1");
            entity.Property(e => e.Description2)
                .HasColumnType("longtext")
                .HasColumnName("description2");
            entity.Property(e => e.Docid)
                .HasDefaultValueSql("''")
                .HasColumnName("docid");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Modified)
                .HasColumnType("bigint(10)")
                .HasColumnName("modified");
            entity.Property(e => e.Owneruserid)
                .HasColumnType("bigint(10)")
                .HasColumnName("owneruserid");
            entity.Property(e => e.Title)
                .HasColumnType("longtext")
                .HasColumnName("title");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_sessions", tb => tb.HasComment("Database based session storage - now recommended"));

            entity.HasIndex(e => e.Sid, "mdl_sess_sid_uix").IsUnique();

            entity.HasIndex(e => e.State, "mdl_sess_sta_ix");

            entity.HasIndex(e => e.Timemodified, "mdl_sess_tim2_ix");

            entity.HasIndex(e => e.Timecreated, "mdl_sess_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_sess_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Firstip)
                .HasMaxLength(45)
                .HasColumnName("firstip");
            entity.Property(e => e.Lastip)
                .HasMaxLength(45)
                .HasColumnName("lastip");
            entity.Property(e => e.Sessdata).HasColumnName("sessdata");
            entity.Property(e => e.Sid)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("sid");
            entity.Property(e => e.State)
                .HasColumnType("bigint(10)")
                .HasColumnName("state");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlStatsDaily>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_stats_daily", tb => tb.HasComment("to accumulate daily stats"));

            entity.HasIndex(e => e.Courseid, "mdl_statdail_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statdail_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statdail_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Stat1)
                .HasColumnType("bigint(10)")
                .HasColumnName("stat1");
            entity.Property(e => e.Stat2)
                .HasColumnType("bigint(10)")
                .HasColumnName("stat2");
            entity.Property(e => e.Stattype)
                .HasMaxLength(20)
                .HasDefaultValueSql("'activity'")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
        });

        modelBuilder.Entity<MdlStatsMonthly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_stats_monthly", tb => tb.HasComment("To accumulate monthly stats"));

            entity.HasIndex(e => e.Courseid, "mdl_statmont_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statmont_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statmont_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Stat1)
                .HasColumnType("bigint(10)")
                .HasColumnName("stat1");
            entity.Property(e => e.Stat2)
                .HasColumnType("bigint(10)")
                .HasColumnName("stat2");
            entity.Property(e => e.Stattype)
                .HasMaxLength(20)
                .HasDefaultValueSql("'activity'")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
        });

        modelBuilder.Entity<MdlStatsUserDaily>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_stats_user_daily", tb => tb.HasComment("To accumulate daily stats per course/user"));

            entity.HasIndex(e => e.Courseid, "mdl_statuserdail_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statuserdail_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statuserdail_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_statuserdail_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Statsreads)
                .HasColumnType("bigint(10)")
                .HasColumnName("statsreads");
            entity.Property(e => e.Statswrites)
                .HasColumnType("bigint(10)")
                .HasColumnName("statswrites");
            entity.Property(e => e.Stattype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlStatsUserMonthly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_stats_user_monthly", tb => tb.HasComment("To accumulate monthly stats per course/user"));

            entity.HasIndex(e => e.Courseid, "mdl_statusermont_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statusermont_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statusermont_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_statusermont_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Statsreads)
                .HasColumnType("bigint(10)")
                .HasColumnName("statsreads");
            entity.Property(e => e.Statswrites)
                .HasColumnType("bigint(10)")
                .HasColumnName("statswrites");
            entity.Property(e => e.Stattype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlStatsUserWeekly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_stats_user_weekly", tb => tb.HasComment("To accumulate weekly stats per course/user"));

            entity.HasIndex(e => e.Courseid, "mdl_statuserweek_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statuserweek_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statuserweek_tim_ix");

            entity.HasIndex(e => e.Userid, "mdl_statuserweek_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Statsreads)
                .HasColumnType("bigint(10)")
                .HasColumnName("statsreads");
            entity.Property(e => e.Statswrites)
                .HasColumnType("bigint(10)")
                .HasColumnName("statswrites");
            entity.Property(e => e.Stattype)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlStatsWeekly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_stats_weekly", tb => tb.HasComment("To accumulate weekly stats"));

            entity.HasIndex(e => e.Courseid, "mdl_statweek_cou_ix");

            entity.HasIndex(e => e.Roleid, "mdl_statweek_rol_ix");

            entity.HasIndex(e => e.Timeend, "mdl_statweek_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Stat1)
                .HasColumnType("bigint(10)")
                .HasColumnName("stat1");
            entity.Property(e => e.Stat2)
                .HasColumnType("bigint(10)")
                .HasColumnName("stat2");
            entity.Property(e => e.Stattype)
                .HasMaxLength(20)
                .HasDefaultValueSql("'activity'")
                .HasColumnName("stattype");
            entity.Property(e => e.Timeend)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
        });

        modelBuilder.Entity<MdlSurvey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_survey", tb => tb.HasComment("Each record is one SURVEY module with its configuration"));

            entity.HasIndex(e => e.Course, "mdl_surv_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Completionsubmit).HasColumnName("completionsubmit");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Days)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(6)")
                .HasColumnName("days");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Questions)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("questions");
            entity.Property(e => e.Template)
                .HasColumnType("bigint(10)")
                .HasColumnName("template");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlSurveyAnalysis>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_survey_analysis", tb => tb.HasComment("text about each survey submission"));

            entity.HasIndex(e => e.Survey, "mdl_survanal_sur_ix");

            entity.HasIndex(e => e.Userid, "mdl_survanal_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Survey)
                .HasColumnType("bigint(10)")
                .HasColumnName("survey");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlSurveyAnswer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_survey_answers", tb => tb.HasComment("the answers to each questions filled by the users"));

            entity.HasIndex(e => e.Question, "mdl_survansw_que_ix");

            entity.HasIndex(e => e.Survey, "mdl_survansw_sur_ix");

            entity.HasIndex(e => e.Userid, "mdl_survansw_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Answer1).HasColumnName("answer1");
            entity.Property(e => e.Answer2).HasColumnName("answer2");
            entity.Property(e => e.Question)
                .HasColumnType("bigint(10)")
                .HasColumnName("question");
            entity.Property(e => e.Survey)
                .HasColumnType("bigint(10)")
                .HasColumnName("survey");
            entity.Property(e => e.Time)
                .HasColumnType("bigint(10)")
                .HasColumnName("time");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlSurveyQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_survey_questions", tb => tb.HasComment("the questions conforming one survey"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Intro)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("intro");
            entity.Property(e => e.Multi)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("multi");
            entity.Property(e => e.Options).HasColumnName("options");
            entity.Property(e => e.Shorttext)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("shorttext");
            entity.Property(e => e.Text)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("text");
            entity.Property(e => e.Type)
                .HasColumnType("smallint(3)")
                .HasColumnName("type");
        });

        modelBuilder.Entity<MdlTag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tag", tb => tb.HasComment("Tag table - this generic table will replace the old \"tags\" t"));

            entity.HasIndex(e => e.Tagcollid, "mdl_tag_tag_ix");

            entity.HasIndex(e => new { e.Tagcollid, e.Isstandard }, "mdl_tag_tagiss_ix");

            entity.HasIndex(e => new { e.Tagcollid, e.Name }, "mdl_tag_tagnam_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_tag_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Flag)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(4)")
                .HasColumnName("flag");
            entity.Property(e => e.Isstandard).HasColumnName("isstandard");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Rawname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("rawname");
            entity.Property(e => e.Tagcollid)
                .HasColumnType("bigint(10)")
                .HasColumnName("tagcollid");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlTagArea>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tag_area", tb => tb.HasComment("Defines various tag areas, one area is identified by compone"));

            entity.HasIndex(e => new { e.Component, e.Itemtype }, "mdl_tagarea_comite_uix").IsUnique();

            entity.HasIndex(e => e.Tagcollid, "mdl_tagarea_tag_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Callback)
                .HasMaxLength(100)
                .HasColumnName("callback");
            entity.Property(e => e.Callbackfile)
                .HasMaxLength(100)
                .HasColumnName("callbackfile");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("enabled");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("itemtype");
            entity.Property(e => e.Multiplecontexts).HasColumnName("multiplecontexts");
            entity.Property(e => e.Showstandard).HasColumnName("showstandard");
            entity.Property(e => e.Tagcollid)
                .HasColumnType("bigint(10)")
                .HasColumnName("tagcollid");
        });

        modelBuilder.Entity<MdlTagColl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tag_coll", tb => tb.HasComment("Defines different set of tags"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasColumnName("component");
            entity.Property(e => e.Customurl)
                .HasMaxLength(255)
                .HasColumnName("customurl");
            entity.Property(e => e.Isdefault)
                .HasColumnType("tinyint(2)")
                .HasColumnName("isdefault");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Searchable)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("searchable");
            entity.Property(e => e.Sortorder)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(5)")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlTagCorrelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tag_correlation", tb => tb.HasComment("The rationale for the 'tag_correlation' table is performance"));

            entity.HasIndex(e => e.Tagid, "mdl_tagcorr_tag_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Correlatedtags).HasColumnName("correlatedtags");
            entity.Property(e => e.Tagid)
                .HasColumnType("bigint(10)")
                .HasColumnName("tagid");
        });

        modelBuilder.Entity<MdlTagInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tag_instance", tb => tb.HasComment("tag_instance table holds the information of associations bet"));

            entity.HasIndex(e => new { e.Component, e.Itemtype, e.Itemid, e.Contextid, e.Tiuserid, e.Tagid }, "mdl_taginst_comiteiteconti_uix").IsUnique();

            entity.HasIndex(e => e.Contextid, "mdl_taginst_con_ix");

            entity.HasIndex(e => new { e.Itemtype, e.Component, e.Tagid, e.Contextid }, "mdl_taginst_itecomtagcon_ix");

            entity.HasIndex(e => e.Tagid, "mdl_taginst_tag_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Component)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Itemid)
                .HasColumnType("bigint(10)")
                .HasColumnName("itemid");
            entity.Property(e => e.Itemtype)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("itemtype");
            entity.Property(e => e.Ordering)
                .HasColumnType("bigint(10)")
                .HasColumnName("ordering");
            entity.Property(e => e.Tagid)
                .HasColumnType("bigint(10)")
                .HasColumnName("tagid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Tiuserid)
                .HasColumnType("bigint(10)")
                .HasColumnName("tiuserid");
        });

        modelBuilder.Entity<MdlTaskAdhoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_task_adhoc", tb => tb.HasComment("List of adhoc tasks waiting to run."));

            entity.HasIndex(e => e.Nextruntime, "mdl_taskadho_nex_ix");

            entity.HasIndex(e => e.Userid, "mdl_taskadho_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Blocking)
                .HasColumnType("tinyint(2)")
                .HasColumnName("blocking");
            entity.Property(e => e.Classname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("classname");
            entity.Property(e => e.Component)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Customdata).HasColumnName("customdata");
            entity.Property(e => e.Faildelay)
                .HasColumnType("bigint(10)")
                .HasColumnName("faildelay");
            entity.Property(e => e.Nextruntime)
                .HasColumnType("bigint(10)")
                .HasColumnName("nextruntime");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlTaskLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_task_log", tb => tb.HasComment("The log table for all tasks"));

            entity.HasIndex(e => e.Classname, "mdl_tasklog_cla_ix");

            entity.HasIndex(e => e.Timestart, "mdl_tasklog_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Classname)
                .HasDefaultValueSql("''")
                .HasColumnName("classname");
            entity.Property(e => e.Component)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Dbreads)
                .HasColumnType("bigint(10)")
                .HasColumnName("dbreads");
            entity.Property(e => e.Dbwrites)
                .HasColumnType("bigint(10)")
                .HasColumnName("dbwrites");
            entity.Property(e => e.Output).HasColumnName("output");
            entity.Property(e => e.Result)
                .HasColumnType("tinyint(2)")
                .HasColumnName("result");
            entity.Property(e => e.Timeend)
                .HasPrecision(20, 10)
                .HasColumnName("timeend");
            entity.Property(e => e.Timestart)
                .HasPrecision(20, 10)
                .HasColumnName("timestart");
            entity.Property(e => e.Type)
                .HasColumnType("smallint(4)")
                .HasColumnName("type");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlTaskScheduled>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_task_scheduled", tb => tb.HasComment("List of scheduled tasks to be run by cron."));

            entity.HasIndex(e => e.Classname, "mdl_tasksche_cla_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Blocking)
                .HasColumnType("tinyint(2)")
                .HasColumnName("blocking");
            entity.Property(e => e.Classname)
                .HasDefaultValueSql("''")
                .HasColumnName("classname");
            entity.Property(e => e.Component)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("component");
            entity.Property(e => e.Customised)
                .HasColumnType("tinyint(2)")
                .HasColumnName("customised");
            entity.Property(e => e.Day)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("day");
            entity.Property(e => e.Dayofweek)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("dayofweek");
            entity.Property(e => e.Disabled).HasColumnName("disabled");
            entity.Property(e => e.Faildelay)
                .HasColumnType("bigint(10)")
                .HasColumnName("faildelay");
            entity.Property(e => e.Hour)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("hour");
            entity.Property(e => e.Lastruntime)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastruntime");
            entity.Property(e => e.Minute)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("minute");
            entity.Property(e => e.Month)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("month");
            entity.Property(e => e.Nextruntime)
                .HasColumnType("bigint(10)")
                .HasColumnName("nextruntime");
        });

        modelBuilder.Entity<MdlToolCohortrole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_cohortroles", tb => tb.HasComment("Mapping of users to cohort role assignments."));

            entity.HasIndex(e => new { e.Cohortid, e.Roleid, e.Userid }, "mdl_toolcoho_cohroluse_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cohortid)
                .HasColumnType("bigint(10)")
                .HasColumnName("cohortid");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolCustomlang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_customlang", tb => tb.HasComment("Contains the working checkout of all strings and their custo"));

            entity.HasIndex(e => e.Componentid, "mdl_toolcust_com_ix");

            entity.HasIndex(e => new { e.Lang, e.Componentid, e.Stringid }, "mdl_toolcust_lancomstr_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Componentid)
                .HasColumnType("bigint(10)")
                .HasColumnName("componentid");
            entity.Property(e => e.Lang)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("lang");
            entity.Property(e => e.Local).HasColumnName("local");
            entity.Property(e => e.Master).HasColumnName("master");
            entity.Property(e => e.Modified)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("modified");
            entity.Property(e => e.Original).HasColumnName("original");
            entity.Property(e => e.Outdated)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("outdated");
            entity.Property(e => e.Stringid)
                .HasDefaultValueSql("''")
                .HasColumnName("stringid");
            entity.Property(e => e.Timecustomized)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecustomized");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlToolCustomlangComponent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_customlang_components", tb => tb.HasComment("Contains the list of all installed plugins that provide thei"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlToolDataprivacyCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_dataprivacy_category", tb => tb.HasComment("Data categories"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyCtxexpired>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_dataprivacy_ctxexpired", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.HasIndex(e => e.Contextid, "mdl_tooldatactxe_con_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Defaultexpired).HasColumnName("defaultexpired");
            entity.Property(e => e.Expiredroles).HasColumnName("expiredroles");
            entity.Property(e => e.Status)
                .HasColumnType("tinyint(2)")
                .HasColumnName("status");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Unexpiredroles).HasColumnName("unexpiredroles");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyCtxinstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_dataprivacy_ctxinstance", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.HasIndex(e => e.Categoryid, "mdl_tooldatactxi_cat_ix");

            entity.HasIndex(e => e.Contextid, "mdl_tooldatactxi_con_uix").IsUnique();

            entity.HasIndex(e => e.Purposeid, "mdl_tooldatactxi_pur_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Categoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("categoryid");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Purposeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("purposeid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyCtxlevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_dataprivacy_ctxlevel", tb => tb.HasComment("Default comment for the table, please edit me"));

            entity.HasIndex(e => e.Categoryid, "mdl_tooldatactxl_cat_ix");

            entity.HasIndex(e => e.Contextlevel, "mdl_tooldatactxl_con_uix").IsUnique();

            entity.HasIndex(e => e.Purposeid, "mdl_tooldatactxl_pur_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Categoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("categoryid");
            entity.Property(e => e.Contextlevel)
                .HasColumnType("smallint(3)")
                .HasColumnName("contextlevel");
            entity.Property(e => e.Purposeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("purposeid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyPurpose>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_dataprivacy_purpose", tb => tb.HasComment("Data purposes"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Lawfulbases).HasColumnName("lawfulbases");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Protected).HasColumnName("protected");
            entity.Property(e => e.Retentionperiod)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("retentionperiod");
            entity.Property(e => e.Sensitivedatareasons).HasColumnName("sensitivedatareasons");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyPurposerole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_dataprivacy_purposerole", tb => tb.HasComment("Data purpose overrides for a specific role"));

            entity.HasIndex(e => e.Purposeid, "mdl_tooldatapurp_pur_ix");

            entity.HasIndex(e => new { e.Purposeid, e.Roleid }, "mdl_tooldatapurp_purrol_uix").IsUnique();

            entity.HasIndex(e => e.Roleid, "mdl_tooldatapurp_rol_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Lawfulbases).HasColumnName("lawfulbases");
            entity.Property(e => e.Protected).HasColumnName("protected");
            entity.Property(e => e.Purposeid)
                .HasColumnType("bigint(10)")
                .HasColumnName("purposeid");
            entity.Property(e => e.Retentionperiod)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("retentionperiod");
            entity.Property(e => e.Roleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("roleid");
            entity.Property(e => e.Sensitivedatareasons).HasColumnName("sensitivedatareasons");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolDataprivacyRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_dataprivacy_request", tb => tb.HasComment("Table for data requests"));

            entity.HasIndex(e => e.Dpo, "mdl_tooldatarequ_dpo_ix");

            entity.HasIndex(e => e.Requestedby, "mdl_tooldatarequ_req_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_tooldatarequ_use2_ix");

            entity.HasIndex(e => e.Userid, "mdl_tooldatarequ_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.Commentsformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("commentsformat");
            entity.Property(e => e.Creationmethod)
                .HasColumnType("bigint(10)")
                .HasColumnName("creationmethod");
            entity.Property(e => e.Dpo)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("dpo");
            entity.Property(e => e.Dpocomment).HasColumnName("dpocomment");
            entity.Property(e => e.Dpocommentformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("dpocommentformat");
            entity.Property(e => e.Requestedby)
                .HasColumnType("bigint(10)")
                .HasColumnName("requestedby");
            entity.Property(e => e.Status)
                .HasColumnType("tinyint(2)")
                .HasColumnName("status");
            entity.Property(e => e.Systemapproved)
                .HasColumnType("smallint(4)")
                .HasColumnName("systemapproved");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .HasColumnType("bigint(10)")
                .HasColumnName("type");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolMonitorEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_monitor_events", tb => tb.HasComment("A table that keeps a log of events related to subscriptions"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Contextid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextid");
            entity.Property(e => e.Contextinstanceid)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextinstanceid");
            entity.Property(e => e.Contextlevel)
                .HasColumnType("bigint(10)")
                .HasColumnName("contextlevel");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Eventname)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("eventname");
            entity.Property(e => e.Link)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("link");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlToolMonitorHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_monitor_history", tb => tb.HasComment("Table to store history of message notifications sent"));

            entity.HasIndex(e => e.Sid, "mdl_toolmonihist_sid_ix");

            entity.HasIndex(e => new { e.Sid, e.Userid, e.Timesent }, "mdl_toolmonihist_sidusetim_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Sid)
                .HasColumnType("bigint(10)")
                .HasColumnName("sid");
            entity.Property(e => e.Timesent)
                .HasColumnType("bigint(10)")
                .HasColumnName("timesent");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlToolMonitorRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_monitor_rules", tb => tb.HasComment("Table to store rules"));

            entity.HasIndex(e => new { e.Courseid, e.Userid }, "mdl_toolmonirule_couuse_ix");

            entity.HasIndex(e => e.Eventname, "mdl_toolmonirule_eve_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat).HasColumnName("descriptionformat");
            entity.Property(e => e.Eventname)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("eventname");
            entity.Property(e => e.Frequency)
                .HasColumnType("smallint(4)")
                .HasColumnName("frequency");
            entity.Property(e => e.Name)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Plugin)
                .HasMaxLength(254)
                .HasDefaultValueSql("''")
                .HasColumnName("plugin");
            entity.Property(e => e.Template).HasColumnName("template");
            entity.Property(e => e.Templateformat).HasColumnName("templateformat");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timewindow)
                .HasColumnType("mediumint(5)")
                .HasColumnName("timewindow");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlToolMonitorSubscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_monitor_subscriptions", tb => tb.HasComment("Table to store user subscriptions to various rules"));

            entity.HasIndex(e => new { e.Courseid, e.Userid }, "mdl_toolmonisubs_couuse_ix");

            entity.HasIndex(e => e.Ruleid, "mdl_toolmonisubs_rul_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cmid)
                .HasColumnType("bigint(10)")
                .HasColumnName("cmid");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Inactivedate)
                .HasColumnType("bigint(10)")
                .HasColumnName("inactivedate");
            entity.Property(e => e.Lastnotificationsent)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastnotificationsent");
            entity.Property(e => e.Ruleid)
                .HasColumnType("bigint(10)")
                .HasColumnName("ruleid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlToolPolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_policy", tb => tb.HasComment("Contains the list of policy documents defined on the site."));

            entity.HasIndex(e => e.Currentversionid, "mdl_toolpoli_cur_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Currentversionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("currentversionid");
            entity.Property(e => e.Sortorder)
                .HasDefaultValueSql("'999'")
                .HasColumnType("mediumint(5)")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlToolPolicyAcceptance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_policy_acceptances", tb => tb.HasComment("Tracks users accepting the policy versions"));

            entity.HasIndex(e => e.Policyversionid, "mdl_toolpoliacce_pol_ix");

            entity.HasIndex(e => new { e.Policyversionid, e.Userid }, "mdl_toolpoliacce_poluse_uix").IsUnique();

            entity.HasIndex(e => e.Usermodified, "mdl_toolpoliacce_use2_ix");

            entity.HasIndex(e => e.Userid, "mdl_toolpoliacce_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Lang)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("lang");
            entity.Property(e => e.Note).HasColumnName("note");
            entity.Property(e => e.Policyversionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("policyversionid");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolPolicyVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_policy_versions", tb => tb.HasComment("Holds versions of the policy documents"));

            entity.HasIndex(e => e.Policyid, "mdl_toolpolivers_pol_ix");

            entity.HasIndex(e => e.Usermodified, "mdl_toolpolivers_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Agreementstyle)
                .HasColumnType("smallint(3)")
                .HasColumnName("agreementstyle");
            entity.Property(e => e.Archived)
                .HasColumnType("smallint(3)")
                .HasColumnName("archived");
            entity.Property(e => e.Audience)
                .HasColumnType("smallint(3)")
                .HasColumnName("audience");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contentformat)
                .HasColumnType("smallint(3)")
                .HasColumnName("contentformat");
            entity.Property(e => e.Name)
                .HasMaxLength(1333)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Optional)
                .HasColumnType("smallint(3)")
                .HasColumnName("optional");
            entity.Property(e => e.Policyid)
                .HasColumnType("bigint(10)")
                .HasColumnName("policyid");
            entity.Property(e => e.Revision)
                .HasMaxLength(1333)
                .HasDefaultValueSql("''")
                .HasColumnName("revision");
            entity.Property(e => e.Summary).HasColumnName("summary");
            entity.Property(e => e.Summaryformat)
                .HasColumnType("smallint(3)")
                .HasColumnName("summaryformat");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .HasColumnType("smallint(3)")
                .HasColumnName("type");
            entity.Property(e => e.Usermodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("usermodified");
        });

        modelBuilder.Entity<MdlToolRecyclebinCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_recyclebin_category", tb => tb.HasComment("A list of items in the category recycle bin"));

            entity.HasIndex(e => e.Categoryid, "mdl_toolrecycate_cat_ix");

            entity.HasIndex(e => e.Timecreated, "mdl_toolrecycate_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Categoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("categoryid");
            entity.Property(e => e.Fullname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("fullname");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("shortname");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlToolRecyclebinCourse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_recyclebin_course", tb => tb.HasComment("A list of items in the course recycle bin"));

            entity.HasIndex(e => e.Courseid, "mdl_toolrecycour_cou_ix");

            entity.HasIndex(e => e.Timecreated, "mdl_toolrecycour_tim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Module)
                .HasColumnType("bigint(10)")
                .HasColumnName("module");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.Section)
                .HasColumnType("bigint(10)")
                .HasColumnName("section");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
        });

        modelBuilder.Entity<MdlToolUsertoursStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_usertours_steps", tb => tb.HasComment("Steps in an tour"));

            entity.HasIndex(e => e.Tourid, "mdl_tooluserstep_tou_ix");

            entity.HasIndex(e => new { e.Tourid, e.Sortorder }, "mdl_tooluserstep_tousor_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Targettype)
                .HasColumnType("tinyint(2)")
                .HasColumnName("targettype");
            entity.Property(e => e.Targetvalue).HasColumnName("targetvalue");
            entity.Property(e => e.Title).HasColumnName("title");
            entity.Property(e => e.Tourid)
                .HasColumnType("bigint(10)")
                .HasColumnName("tourid");
        });

        modelBuilder.Entity<MdlToolUsertoursTour>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_tool_usertours_tours", tb => tb.HasComment("List of tours"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Configdata).HasColumnName("configdata");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Enabled).HasColumnName("enabled");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Pathmatch)
                .HasMaxLength(255)
                .HasColumnName("pathmatch");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlUpgradeLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_upgrade_log", tb => tb.HasComment("Upgrade logging"));

            entity.HasIndex(e => e.Timemodified, "mdl_upgrlog_tim_ix");

            entity.HasIndex(e => new { e.Type, e.Timemodified }, "mdl_upgrlog_typtim_ix");

            entity.HasIndex(e => e.Userid, "mdl_upgrlog_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Backtrace).HasColumnName("backtrace");
            entity.Property(e => e.Details).HasColumnName("details");
            entity.Property(e => e.Info)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("info");
            entity.Property(e => e.Plugin)
                .HasMaxLength(100)
                .HasColumnName("plugin");
            entity.Property(e => e.Targetversion)
                .HasMaxLength(100)
                .HasColumnName("targetversion");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Type)
                .HasColumnType("bigint(10)")
                .HasColumnName("type");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Version)
                .HasMaxLength(100)
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlUrl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_url", tb => tb.HasComment("each record is one url resource"));

            entity.HasIndex(e => e.Course, "mdl_url_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Display)
                .HasColumnType("smallint(4)")
                .HasColumnName("display");
            entity.Property(e => e.Displayoptions).HasColumnName("displayoptions");
            entity.Property(e => e.Externalurl).HasColumnName("externalurl");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Parameters).HasColumnName("parameters");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
        });

        modelBuilder.Entity<MdlUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_user", tb => tb.HasComment("One record for each person"));

            entity.HasIndex(e => e.Alternatename, "mdl_user_alt_ix");

            entity.HasIndex(e => e.Auth, "mdl_user_aut_ix");

            entity.HasIndex(e => e.City, "mdl_user_cit_ix");

            entity.HasIndex(e => e.Confirmed, "mdl_user_con_ix");

            entity.HasIndex(e => e.Country, "mdl_user_cou_ix");

            entity.HasIndex(e => e.Deleted, "mdl_user_del_ix");

            entity.HasIndex(e => e.Email, "mdl_user_ema_ix");

            entity.HasIndex(e => e.Firstnamephonetic, "mdl_user_fir2_ix");

            entity.HasIndex(e => e.Firstname, "mdl_user_fir_ix");

            entity.HasIndex(e => e.Idnumber, "mdl_user_idn_ix");

            entity.HasIndex(e => e.Lastaccess, "mdl_user_las2_ix");

            entity.HasIndex(e => e.Lastnamephonetic, "mdl_user_las3_ix");

            entity.HasIndex(e => e.Lastname, "mdl_user_las_ix");

            entity.HasIndex(e => e.Middlename, "mdl_user_mid_ix");

            entity.HasIndex(e => new { e.Mnethostid, e.Username }, "mdl_user_mneuse_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("address");
            entity.Property(e => e.Aim)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("aim");
            entity.Property(e => e.Alternatename).HasColumnName("alternatename");
            entity.Property(e => e.Auth)
                .HasMaxLength(20)
                .HasDefaultValueSql("'manual'")
                .HasColumnName("auth");
            entity.Property(e => e.Autosubscribe)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("autosubscribe");
            entity.Property(e => e.Calendartype)
                .HasMaxLength(30)
                .HasDefaultValueSql("'gregorian'")
                .HasColumnName("calendartype");
            entity.Property(e => e.City)
                .HasMaxLength(120)
                .HasDefaultValueSql("''")
                .HasColumnName("city");
            entity.Property(e => e.Confirmed).HasColumnName("confirmed");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .HasDefaultValueSql("''")
                .HasColumnName("country");
            entity.Property(e => e.Currentlogin)
                .HasColumnType("bigint(10)")
                .HasColumnName("currentlogin");
            entity.Property(e => e.Deleted).HasColumnName("deleted");
            entity.Property(e => e.Department)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("department");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasDefaultValueSql("'1'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("email");
            entity.Property(e => e.Emailstop).HasColumnName("emailstop");
            entity.Property(e => e.Firstaccess)
                .HasColumnType("bigint(10)")
                .HasColumnName("firstaccess");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("firstname");
            entity.Property(e => e.Firstnamephonetic).HasColumnName("firstnamephonetic");
            entity.Property(e => e.Icq)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("icq");
            entity.Property(e => e.Idnumber)
                .HasDefaultValueSql("''")
                .HasColumnName("idnumber");
            entity.Property(e => e.Imagealt)
                .HasMaxLength(255)
                .HasColumnName("imagealt");
            entity.Property(e => e.Institution)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("institution");
            entity.Property(e => e.Lang)
                .HasMaxLength(30)
                .HasDefaultValueSql("'en'")
                .HasColumnName("lang");
            entity.Property(e => e.Lastaccess)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastaccess");
            entity.Property(e => e.Lastip)
                .HasMaxLength(45)
                .HasDefaultValueSql("''")
                .HasColumnName("lastip");
            entity.Property(e => e.Lastlogin)
                .HasColumnType("bigint(10)")
                .HasColumnName("lastlogin");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("lastname");
            entity.Property(e => e.Lastnamephonetic).HasColumnName("lastnamephonetic");
            entity.Property(e => e.Maildigest).HasColumnName("maildigest");
            entity.Property(e => e.Maildisplay)
                .HasDefaultValueSql("'2'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("maildisplay");
            entity.Property(e => e.Mailformat)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("mailformat");
            entity.Property(e => e.Middlename).HasColumnName("middlename");
            entity.Property(e => e.Mnethostid)
                .HasColumnType("bigint(10)")
                .HasColumnName("mnethostid");
            entity.Property(e => e.Moodlenetprofile)
                .HasMaxLength(255)
                .HasColumnName("moodlenetprofile");
            entity.Property(e => e.Msn)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("msn");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("password");
            entity.Property(e => e.Phone1)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("phone1");
            entity.Property(e => e.Phone2)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("phone2");
            entity.Property(e => e.Picture)
                .HasColumnType("bigint(10)")
                .HasColumnName("picture");
            entity.Property(e => e.Policyagreed).HasColumnName("policyagreed");
            entity.Property(e => e.Secret)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("secret");
            entity.Property(e => e.Skype)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("skype");
            entity.Property(e => e.Suspended).HasColumnName("suspended");
            entity.Property(e => e.Theme)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("theme");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timezone)
                .HasMaxLength(100)
                .HasDefaultValueSql("'99'")
                .HasColumnName("timezone");
            entity.Property(e => e.Trackforums).HasColumnName("trackforums");
            entity.Property(e => e.Trustbitmask)
                .HasColumnType("bigint(10)")
                .HasColumnName("trustbitmask");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("url");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("username");
            entity.Property(e => e.Yahoo)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("yahoo");
        });

        modelBuilder.Entity<MdlUserDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_user_devices", tb => tb.HasComment("This table stores user's mobile devices information in order"));

            entity.HasIndex(e => new { e.Pushid, e.Userid }, "mdl_userdevi_pususe_uix").IsUnique();

            entity.HasIndex(e => e.Userid, "mdl_userdevi_use_ix");

            entity.HasIndex(e => new { e.Uuid, e.Userid }, "mdl_userdevi_uuiuse_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Appid)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("appid");
            entity.Property(e => e.Model)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("model");
            entity.Property(e => e.Name)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Platform)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("platform");
            entity.Property(e => e.Pushid)
                .HasDefaultValueSql("''")
                .HasColumnName("pushid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Uuid)
                .HasDefaultValueSql("''")
                .HasColumnName("uuid");
            entity.Property(e => e.Version)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlUserEnrolment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_user_enrolments", tb => tb.HasComment("Users participating in courses (aka enrolled users) - everyb"));

            entity.HasIndex(e => e.Enrolid, "mdl_userenro_enr_ix");

            entity.HasIndex(e => new { e.Enrolid, e.Userid }, "mdl_userenro_enruse_uix").IsUnique();

            entity.HasIndex(e => e.Modifierid, "mdl_userenro_mod_ix");

            entity.HasIndex(e => e.Userid, "mdl_userenro_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Enrolid)
                .HasColumnType("bigint(10)")
                .HasColumnName("enrolid");
            entity.Property(e => e.Modifierid)
                .HasColumnType("bigint(10)")
                .HasColumnName("modifierid");
            entity.Property(e => e.Status)
                .HasColumnType("bigint(10)")
                .HasColumnName("status");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timeend)
                .HasDefaultValueSql("'2147483647'")
                .HasColumnType("bigint(10)")
                .HasColumnName("timeend");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timestart)
                .HasColumnType("bigint(10)")
                .HasColumnName("timestart");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlUserInfoCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_user_info_category", tb => tb.HasComment("Customisable fields categories"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
        });

        modelBuilder.Entity<MdlUserInfoDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_user_info_data", tb => tb.HasComment("Data for the customisable user fields"));

            entity.HasIndex(e => new { e.Userid, e.Fieldid }, "mdl_userinfodata_usefie_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Dataformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("dataformat");
            entity.Property(e => e.Fieldid)
                .HasColumnType("bigint(10)")
                .HasColumnName("fieldid");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlUserInfoField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_user_info_field", tb => tb.HasComment("Customisable user profile fields"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Categoryid)
                .HasColumnType("bigint(10)")
                .HasColumnName("categoryid");
            entity.Property(e => e.Datatype)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("datatype");
            entity.Property(e => e.Defaultdata).HasColumnName("defaultdata");
            entity.Property(e => e.Defaultdataformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("defaultdataformat");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasColumnType("tinyint(2)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Forceunique)
                .HasColumnType("tinyint(2)")
                .HasColumnName("forceunique");
            entity.Property(e => e.Locked)
                .HasColumnType("tinyint(2)")
                .HasColumnName("locked");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Param1).HasColumnName("param1");
            entity.Property(e => e.Param2).HasColumnName("param2");
            entity.Property(e => e.Param3).HasColumnName("param3");
            entity.Property(e => e.Param4).HasColumnName("param4");
            entity.Property(e => e.Param5).HasColumnName("param5");
            entity.Property(e => e.Required)
                .HasColumnType("tinyint(2)")
                .HasColumnName("required");
            entity.Property(e => e.Shortname)
                .HasMaxLength(255)
                .HasDefaultValueSql("'shortname'")
                .HasColumnName("shortname");
            entity.Property(e => e.Signup)
                .HasColumnType("tinyint(2)")
                .HasColumnName("signup");
            entity.Property(e => e.Sortorder)
                .HasColumnType("bigint(10)")
                .HasColumnName("sortorder");
            entity.Property(e => e.Visible)
                .HasColumnType("smallint(4)")
                .HasColumnName("visible");
        });

        modelBuilder.Entity<MdlUserLastaccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_user_lastaccess", tb => tb.HasComment("To keep track of course page access times, used in online pa"));

            entity.HasIndex(e => e.Courseid, "mdl_userlast_cou_ix");

            entity.HasIndex(e => e.Userid, "mdl_userlast_use_ix");

            entity.HasIndex(e => new { e.Userid, e.Courseid }, "mdl_userlast_usecou_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Courseid)
                .HasColumnType("bigint(10)")
                .HasColumnName("courseid");
            entity.Property(e => e.Timeaccess)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeaccess");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlUserPasswordHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_user_password_history", tb => tb.HasComment("A rotating log of hashes of previously used passwords for ea"));

            entity.HasIndex(e => e.Userid, "mdl_userpasshist_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Hash)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("hash");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlUserPasswordReset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_user_password_resets", tb => tb.HasComment("table tracking password reset confirmation tokens"));

            entity.HasIndex(e => e.Userid, "mdl_userpassrese_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Timerequested)
                .HasColumnType("bigint(10)")
                .HasColumnName("timerequested");
            entity.Property(e => e.Timererequested)
                .HasColumnType("bigint(10)")
                .HasColumnName("timererequested");
            entity.Property(e => e.Token)
                .HasMaxLength(32)
                .HasDefaultValueSql("''")
                .HasColumnName("token");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlUserPreference>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_user_preferences", tb => tb.HasComment("Allows modules to store arbitrary user preferences"));

            entity.HasIndex(e => new { e.Userid, e.Name }, "mdl_userpref_usenam_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Value)
                .HasMaxLength(1333)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlUserPrivateKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_user_private_key", tb => tb.HasComment("access keys used in cookieless scripts - rss, etc."));

            entity.HasIndex(e => new { e.Script, e.Value }, "mdl_userprivkey_scrval_ix");

            entity.HasIndex(e => e.Userid, "mdl_userprivkey_use_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Instance)
                .HasColumnType("bigint(10)")
                .HasColumnName("instance");
            entity.Property(e => e.Iprestriction)
                .HasMaxLength(255)
                .HasColumnName("iprestriction");
            entity.Property(e => e.Script)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("script");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Validuntil)
                .HasColumnType("bigint(10)")
                .HasColumnName("validuntil");
            entity.Property(e => e.Value)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("value");
        });

        modelBuilder.Entity<MdlWiki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_wiki", tb => tb.HasComment("Stores Wiki activity configuration"));

            entity.HasIndex(e => e.Course, "mdl_wiki_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Defaultformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'creole'")
                .HasColumnName("defaultformat");
            entity.Property(e => e.Editbegin)
                .HasColumnType("bigint(10)")
                .HasColumnName("editbegin");
            entity.Property(e => e.Editend)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("editend");
            entity.Property(e => e.Firstpagetitle)
                .HasMaxLength(255)
                .HasDefaultValueSql("'First Page'")
                .HasColumnName("firstpagetitle");
            entity.Property(e => e.Forceformat)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("forceformat");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(4)")
                .HasColumnName("introformat");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("'Wiki'")
                .HasColumnName("name");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Wikimode)
                .HasMaxLength(20)
                .HasDefaultValueSql("'collaborative'")
                .HasColumnName("wikimode");
        });

        modelBuilder.Entity<MdlWikiLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_wiki_links", tb => tb.HasComment("Page wiki links"));

            entity.HasIndex(e => e.Frompageid, "mdl_wikilink_fro_ix");

            entity.HasIndex(e => e.Subwikiid, "mdl_wikilink_sub_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Frompageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("frompageid");
            entity.Property(e => e.Subwikiid)
                .HasColumnType("bigint(10)")
                .HasColumnName("subwikiid");
            entity.Property(e => e.Tomissingpage)
                .HasMaxLength(255)
                .HasColumnName("tomissingpage");
            entity.Property(e => e.Topageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("topageid");
        });

        modelBuilder.Entity<MdlWikiLock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_wiki_locks", tb => tb.HasComment("Manages page locks"));

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Lockedat)
                .HasColumnType("bigint(10)")
                .HasColumnName("lockedat");
            entity.Property(e => e.Pageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("pageid");
            entity.Property(e => e.Sectionname)
                .HasMaxLength(255)
                .HasColumnName("sectionname");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlWikiPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_wiki_pages", tb => tb.HasComment("Stores wiki pages"));

            entity.HasIndex(e => e.Subwikiid, "mdl_wikipage_sub_ix");

            entity.HasIndex(e => new { e.Subwikiid, e.Title, e.Userid }, "mdl_wikipage_subtituse_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Cachedcontent).HasColumnName("cachedcontent");
            entity.Property(e => e.Pageviews)
                .HasColumnType("bigint(10)")
                .HasColumnName("pageviews");
            entity.Property(e => e.Readonly).HasColumnName("readonly");
            entity.Property(e => e.Subwikiid)
                .HasColumnType("bigint(10)")
                .HasColumnName("subwikiid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Timerendered)
                .HasColumnType("bigint(10)")
                .HasColumnName("timerendered");
            entity.Property(e => e.Title)
                .HasDefaultValueSql("'title'")
                .HasColumnName("title");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
        });

        modelBuilder.Entity<MdlWikiSubwiki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_wiki_subwikis", tb => tb.HasComment("Stores subwiki instances"));

            entity.HasIndex(e => e.Wikiid, "mdl_wikisubw_wik_ix");

            entity.HasIndex(e => new { e.Wikiid, e.Groupid, e.Userid }, "mdl_wikisubw_wikgrouse_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Groupid)
                .HasColumnType("bigint(10)")
                .HasColumnName("groupid");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Wikiid)
                .HasColumnType("bigint(10)")
                .HasColumnName("wikiid");
        });

        modelBuilder.Entity<MdlWikiSynonym>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_wiki_synonyms", tb => tb.HasComment("Stores wiki pages synonyms"));

            entity.HasIndex(e => new { e.Pageid, e.Pagesynonym }, "mdl_wikisyno_pagpag_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Pageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("pageid");
            entity.Property(e => e.Pagesynonym)
                .HasDefaultValueSql("'Pagesynonym'")
                .HasColumnName("pagesynonym");
            entity.Property(e => e.Subwikiid)
                .HasColumnType("bigint(10)")
                .HasColumnName("subwikiid");
        });

        modelBuilder.Entity<MdlWikiVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_wiki_versions", tb => tb.HasComment("Stores wiki page history"));

            entity.HasIndex(e => e.Pageid, "mdl_wikivers_pag_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contentformat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'creole'")
                .HasColumnName("contentformat");
            entity.Property(e => e.Pageid)
                .HasColumnType("bigint(10)")
                .HasColumnName("pageid");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Version)
                .HasDefaultValueSql("'0'")
                .HasColumnType("mediumint(5)")
                .HasColumnName("version");
        });

        modelBuilder.Entity<MdlWorkshop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshop", tb => tb.HasComment("This table keeps information about the module instances and "));

            entity.HasIndex(e => e.Course, "mdl_work_cou_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assessmentend)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("assessmentend");
            entity.Property(e => e.Assessmentstart)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("assessmentstart");
            entity.Property(e => e.Conclusion).HasColumnName("conclusion");
            entity.Property(e => e.Conclusionformat)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(3)")
                .HasColumnName("conclusionformat");
            entity.Property(e => e.Course)
                .HasColumnType("bigint(10)")
                .HasColumnName("course");
            entity.Property(e => e.Evaluation)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("evaluation");
            entity.Property(e => e.Examplesmode)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("examplesmode");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'80.00000'")
                .HasColumnName("grade");
            entity.Property(e => e.Gradedecimals)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("gradedecimals");
            entity.Property(e => e.Gradinggrade)
                .HasPrecision(10, 5)
                .HasDefaultValueSql("'20.00000'")
                .HasColumnName("gradinggrade");
            entity.Property(e => e.Instructauthors).HasColumnName("instructauthors");
            entity.Property(e => e.Instructauthorsformat)
                .HasColumnType("smallint(3)")
                .HasColumnName("instructauthorsformat");
            entity.Property(e => e.Instructreviewers).HasColumnName("instructreviewers");
            entity.Property(e => e.Instructreviewersformat)
                .HasColumnType("smallint(3)")
                .HasColumnName("instructreviewersformat");
            entity.Property(e => e.Intro).HasColumnName("intro");
            entity.Property(e => e.Introformat)
                .HasColumnType("smallint(3)")
                .HasColumnName("introformat");
            entity.Property(e => e.Latesubmissions)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("latesubmissions");
            entity.Property(e => e.Maxbytes)
                .HasDefaultValueSql("'100000'")
                .HasColumnType("bigint(10)")
                .HasColumnName("maxbytes");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Nattachments)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(3)")
                .HasColumnName("nattachments");
            entity.Property(e => e.Overallfeedbackfiles)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("overallfeedbackfiles");
            entity.Property(e => e.Overallfeedbackfiletypes)
                .HasMaxLength(255)
                .HasColumnName("overallfeedbackfiletypes");
            entity.Property(e => e.Overallfeedbackmaxbytes)
                .HasDefaultValueSql("'100000'")
                .HasColumnType("bigint(10)")
                .HasColumnName("overallfeedbackmaxbytes");
            entity.Property(e => e.Overallfeedbackmode)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(3)")
                .HasColumnName("overallfeedbackmode");
            entity.Property(e => e.Phase)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("phase");
            entity.Property(e => e.Phaseswitchassessment)
                .HasColumnType("tinyint(2)")
                .HasColumnName("phaseswitchassessment");
            entity.Property(e => e.Strategy)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("strategy");
            entity.Property(e => e.Submissionend)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("submissionend");
            entity.Property(e => e.Submissionfiletypes)
                .HasMaxLength(255)
                .HasColumnName("submissionfiletypes");
            entity.Property(e => e.Submissionstart)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("submissionstart");
            entity.Property(e => e.Submissiontypefile)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("submissiontypefile");
            entity.Property(e => e.Submissiontypetext)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("submissiontypetext");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Useexamples)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("useexamples");
            entity.Property(e => e.Usepeerassessment)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("usepeerassessment");
            entity.Property(e => e.Useselfassessment)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("useselfassessment");
        });

        modelBuilder.Entity<MdlWorkshopAggregation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshop_aggregations", tb => tb.HasComment("Aggregated grades for assessment are stored here. The aggreg"));

            entity.HasIndex(e => e.Userid, "mdl_workaggr_use_ix");

            entity.HasIndex(e => e.Workshopid, "mdl_workaggr_wor_ix");

            entity.HasIndex(e => new { e.Workshopid, e.Userid }, "mdl_workaggr_woruse_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Gradinggrade)
                .HasPrecision(10, 5)
                .HasColumnName("gradinggrade");
            entity.Property(e => e.Timegraded)
                .HasColumnType("bigint(10)")
                .HasColumnName("timegraded");
            entity.Property(e => e.Userid)
                .HasColumnType("bigint(10)")
                .HasColumnName("userid");
            entity.Property(e => e.Workshopid)
                .HasColumnType("bigint(10)")
                .HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopAssessment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshop_assessments", tb => tb.HasComment("Info about the made assessment and automatically calculated "));

            entity.HasIndex(e => e.Gradinggradeoverby, "mdl_workasse_gra_ix");

            entity.HasIndex(e => e.Reviewerid, "mdl_workasse_rev_ix");

            entity.HasIndex(e => e.Submissionid, "mdl_workasse_sub_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Feedbackauthor).HasColumnName("feedbackauthor");
            entity.Property(e => e.Feedbackauthorattachment)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("feedbackauthorattachment");
            entity.Property(e => e.Feedbackauthorformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("feedbackauthorformat");
            entity.Property(e => e.Feedbackreviewer).HasColumnName("feedbackreviewer");
            entity.Property(e => e.Feedbackreviewerformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("feedbackreviewerformat");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Gradinggrade)
                .HasPrecision(10, 5)
                .HasColumnName("gradinggrade");
            entity.Property(e => e.Gradinggradeover)
                .HasPrecision(10, 5)
                .HasColumnName("gradinggradeover");
            entity.Property(e => e.Gradinggradeoverby)
                .HasColumnType("bigint(10)")
                .HasColumnName("gradinggradeoverby");
            entity.Property(e => e.Reviewerid)
                .HasColumnType("bigint(10)")
                .HasColumnName("reviewerid");
            entity.Property(e => e.Submissionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("submissionid");
            entity.Property(e => e.Timecreated)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timemodified)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Weight)
                .HasDefaultValueSql("'1'")
                .HasColumnType("bigint(10)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<MdlWorkshopGrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshop_grades", tb => tb.HasComment("How the reviewers filled-up the grading forms, given grades "));

            entity.HasIndex(e => e.Assessmentid, "mdl_workgrad_ass_ix");

            entity.HasIndex(e => new { e.Assessmentid, e.Strategy, e.Dimensionid }, "mdl_workgrad_assstrdim_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Assessmentid)
                .HasColumnType("bigint(10)")
                .HasColumnName("assessmentid");
            entity.Property(e => e.Dimensionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("dimensionid");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Peercomment).HasColumnName("peercomment");
            entity.Property(e => e.Peercommentformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("peercommentformat");
            entity.Property(e => e.Strategy)
                .HasMaxLength(30)
                .HasDefaultValueSql("''")
                .HasColumnName("strategy");
        });

        modelBuilder.Entity<MdlWorkshopSubmission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshop_submissions", tb => tb.HasComment("Info about the submission and the aggregation of the grade f"));

            entity.HasIndex(e => e.Authorid, "mdl_worksubm_aut_ix");

            entity.HasIndex(e => e.Gradeoverby, "mdl_worksubm_gra_ix");

            entity.HasIndex(e => e.Workshopid, "mdl_worksubm_wor_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Attachment)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("attachment");
            entity.Property(e => e.Authorid)
                .HasColumnType("bigint(10)")
                .HasColumnName("authorid");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Contentformat)
                .HasColumnType("smallint(3)")
                .HasColumnName("contentformat");
            entity.Property(e => e.Contenttrust)
                .HasColumnType("smallint(3)")
                .HasColumnName("contenttrust");
            entity.Property(e => e.Example)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("example");
            entity.Property(e => e.Feedbackauthor).HasColumnName("feedbackauthor");
            entity.Property(e => e.Feedbackauthorformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("feedbackauthorformat");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Gradeover)
                .HasPrecision(10, 5)
                .HasColumnName("gradeover");
            entity.Property(e => e.Gradeoverby)
                .HasColumnType("bigint(10)")
                .HasColumnName("gradeoverby");
            entity.Property(e => e.Late)
                .HasColumnType("tinyint(2)")
                .HasColumnName("late");
            entity.Property(e => e.Published)
                .HasDefaultValueSql("'0'")
                .HasColumnType("tinyint(2)")
                .HasColumnName("published");
            entity.Property(e => e.Timecreated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timecreated");
            entity.Property(e => e.Timegraded)
                .HasColumnType("bigint(10)")
                .HasColumnName("timegraded");
            entity.Property(e => e.Timemodified)
                .HasColumnType("bigint(10)")
                .HasColumnName("timemodified");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.Workshopid)
                .HasColumnType("bigint(10)")
                .HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopallocationScheduled>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshopallocation_scheduled", tb => tb.HasComment("Stores the allocation settings for the scheduled allocator"));

            entity.HasIndex(e => e.Workshopid, "mdl_worksche_wor_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Enabled)
                .HasColumnType("tinyint(2)")
                .HasColumnName("enabled");
            entity.Property(e => e.Resultlog).HasColumnName("resultlog");
            entity.Property(e => e.Resultmessage)
                .HasMaxLength(1333)
                .HasColumnName("resultmessage");
            entity.Property(e => e.Resultstatus)
                .HasColumnType("bigint(10)")
                .HasColumnName("resultstatus");
            entity.Property(e => e.Settings).HasColumnName("settings");
            entity.Property(e => e.Submissionend)
                .HasColumnType("bigint(10)")
                .HasColumnName("submissionend");
            entity.Property(e => e.Timeallocated)
                .HasColumnType("bigint(10)")
                .HasColumnName("timeallocated");
            entity.Property(e => e.Workshopid)
                .HasColumnType("bigint(10)")
                .HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopevalBestSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshopeval_best_settings", tb => tb.HasComment("Settings for the grading evaluation subplugin Comparison wit"));

            entity.HasIndex(e => e.Workshopid, "mdl_workbestsett_wor_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Comparison)
                .HasDefaultValueSql("'5'")
                .HasColumnType("smallint(3)")
                .HasColumnName("comparison");
            entity.Property(e => e.Workshopid)
                .HasColumnType("bigint(10)")
                .HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformAccumulative>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshopform_accumulative", tb => tb.HasComment("The assessment dimensions definitions of Accumulative gradin"));

            entity.HasIndex(e => e.Workshopid, "mdl_workaccu_wor_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Grade)
                .HasColumnType("bigint(10)")
                .HasColumnName("grade");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("sort");
            entity.Property(e => e.Weight)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint(5)")
                .HasColumnName("weight");
            entity.Property(e => e.Workshopid)
                .HasColumnType("bigint(10)")
                .HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformComment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshopform_comments", tb => tb.HasComment("The assessment dimensions definitions of Comments strategy f"));

            entity.HasIndex(e => e.Workshopid, "mdl_workcomm_wor_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("sort");
            entity.Property(e => e.Workshopid)
                .HasColumnType("bigint(10)")
                .HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformNumerror>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshopform_numerrors", tb => tb.HasComment("The assessment dimensions definitions of Number of errors gr"));

            entity.HasIndex(e => e.Workshopid, "mdl_worknume_wor_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Descriptiontrust)
                .HasColumnType("bigint(10)")
                .HasColumnName("descriptiontrust");
            entity.Property(e => e.Grade0)
                .HasMaxLength(50)
                .HasColumnName("grade0");
            entity.Property(e => e.Grade1)
                .HasMaxLength(50)
                .HasColumnName("grade1");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("sort");
            entity.Property(e => e.Weight)
                .HasDefaultValueSql("'1'")
                .HasColumnType("mediumint(5)")
                .HasColumnName("weight");
            entity.Property(e => e.Workshopid)
                .HasColumnType("bigint(10)")
                .HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformNumerrorsMap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshopform_numerrors_map", tb => tb.HasComment("This maps the number of errors to a percentual grade for sub"));

            entity.HasIndex(e => e.Workshopid, "mdl_worknumemap_wor_ix");

            entity.HasIndex(e => new { e.Workshopid, e.Nonegative }, "mdl_worknumemap_wornon_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
            entity.Property(e => e.Nonegative)
                .HasColumnType("bigint(10)")
                .HasColumnName("nonegative");
            entity.Property(e => e.Workshopid)
                .HasColumnType("bigint(10)")
                .HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformRubric>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshopform_rubric", tb => tb.HasComment("The assessment dimensions definitions of Rubric grading stra"));

            entity.HasIndex(e => e.Workshopid, "mdl_workrubr_wor_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Descriptionformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("descriptionformat");
            entity.Property(e => e.Sort)
                .HasDefaultValueSql("'0'")
                .HasColumnType("bigint(10)")
                .HasColumnName("sort");
            entity.Property(e => e.Workshopid)
                .HasColumnType("bigint(10)")
                .HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformRubricConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshopform_rubric_config", tb => tb.HasComment("Configuration table for the Rubric grading strategy"));

            entity.HasIndex(e => e.Workshopid, "mdl_workrubrconf_wor_uix").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Layout)
                .HasMaxLength(30)
                .HasDefaultValueSql("'list'")
                .HasColumnName("layout");
            entity.Property(e => e.Workshopid)
                .HasColumnType("bigint(10)")
                .HasColumnName("workshopid");
        });

        modelBuilder.Entity<MdlWorkshopformRubricLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mdl_workshopform_rubric_levels", tb => tb.HasComment("The definition of rubric rating scales"));

            entity.HasIndex(e => e.Dimensionid, "mdl_workrubrleve_dim_ix");

            entity.Property(e => e.Id)
                .HasColumnType("bigint(10)")
                .HasColumnName("id");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.Definitionformat)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(3)")
                .HasColumnName("definitionformat");
            entity.Property(e => e.Dimensionid)
                .HasColumnType("bigint(10)")
                .HasColumnName("dimensionid");
            entity.Property(e => e.Grade)
                .HasPrecision(10, 5)
                .HasColumnName("grade");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
