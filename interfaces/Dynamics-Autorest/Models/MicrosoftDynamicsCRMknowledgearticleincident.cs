// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.knowledgearticleincident
    /// </summary>
    public partial class MicrosoftDynamicsCRMknowledgearticleincident
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMknowledgearticleincident class.
        /// </summary>
        public MicrosoftDynamicsCRMknowledgearticleincident()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMknowledgearticleincident class.
        /// </summary>
        public MicrosoftDynamicsCRMknowledgearticleincident(int? knowledgeusage = default(int?), string _owninguserValue = default(string), string _transactioncurrencyidValue = default(string), decimal? exchangerate = default(decimal?), string _owningbusinessunitValue = default(string), int? utcconversiontimezonecode = default(int?), int? importsequencenumber = default(int?), string _knowledgearticleidValue = default(string), string versionnumber = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), string _modifiedbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? statecode = default(int?), string _createdonbehalfbyValue = default(string), string _owningteamValue = default(string), bool? issenttocustomer = default(bool?), string _owneridValue = default(string), string _incidentidValue = default(string), string _modifiedonbehalfbyValue = default(string), string knowledgearticleincidentid = default(string), int? statuscode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMsyncerror> knowledgeArticleIncidentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> knowledgearticleincidentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> knowledgearticleincidentMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> knowledgearticleincidentProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> knowledgearticleincidentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> knowledgearticleincidentPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMincident incidentid = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMknowledgearticle knowledgearticleid = default(MicrosoftDynamicsCRMknowledgearticle), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency))
        {
            Knowledgeusage = knowledgeusage;
            this._owninguserValue = _owninguserValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Exchangerate = exchangerate;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Importsequencenumber = importsequencenumber;
            this._knowledgearticleidValue = _knowledgearticleidValue;
            Versionnumber = versionnumber;
            Createdon = createdon;
            Overriddencreatedon = overriddencreatedon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            Modifiedon = modifiedon;
            this._createdbyValue = _createdbyValue;
            Statecode = statecode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._owningteamValue = _owningteamValue;
            Issenttocustomer = issenttocustomer;
            this._owneridValue = _owneridValue;
            this._incidentidValue = _incidentidValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Knowledgearticleincidentid = knowledgearticleincidentid;
            Statuscode = statuscode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            KnowledgeArticleIncidentSyncErrors = knowledgeArticleIncidentSyncErrors;
            KnowledgearticleincidentAsyncOperations = knowledgearticleincidentAsyncOperations;
            KnowledgearticleincidentMailboxTrackingFolders = knowledgearticleincidentMailboxTrackingFolders;
            KnowledgearticleincidentProcessSession = knowledgearticleincidentProcessSession;
            KnowledgearticleincidentBulkDeleteFailures = knowledgearticleincidentBulkDeleteFailures;
            KnowledgearticleincidentPrincipalobjectattributeaccess = knowledgearticleincidentPrincipalobjectattributeaccess;
            Incidentid = incidentid;
            Knowledgearticleid = knowledgearticleid;
            Transactioncurrencyid = transactioncurrencyid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgeusage")]
        public int? Knowledgeusage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_knowledgearticleid_value")]
        public string _knowledgearticleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "issenttocustomer")]
        public bool? Issenttocustomer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_incidentid_value")]
        public string _incidentidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleincidentid")]
        public string Knowledgearticleincidentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "KnowledgeArticleIncident_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> KnowledgeArticleIncidentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleincident_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> KnowledgearticleincidentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleincident_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> KnowledgearticleincidentMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleincident_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> KnowledgearticleincidentProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleincident_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> KnowledgearticleincidentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleincident_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> KnowledgearticleincidentPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "incidentid")]
        public MicrosoftDynamicsCRMincident Incidentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledgearticleid")]
        public MicrosoftDynamicsCRMknowledgearticle Knowledgearticleid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

    }
}
