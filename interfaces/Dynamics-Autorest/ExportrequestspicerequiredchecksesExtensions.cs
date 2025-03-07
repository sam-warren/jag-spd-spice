// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Exportrequestspicerequiredcheckses.
    /// </summary>
    public static partial class ExportrequestspicerequiredchecksesExtensions
    {
            /// <summary>
            /// Get spice_exportrequest_spice_requiredcheckses from spice_exportrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestid'>
            /// key: spice_exportrequestid of spice_exportrequest
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMspiceRequiredchecksCollection Get(this IExportrequestspicerequiredcheckses operations, string spiceExportrequestid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(spiceExportrequestid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get spice_exportrequest_spice_requiredcheckses from spice_exportrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestid'>
            /// key: spice_exportrequestid of spice_exportrequest
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMspiceRequiredchecksCollection> GetAsync(this IExportrequestspicerequiredcheckses operations, string spiceExportrequestid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(spiceExportrequestid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get spice_exportrequest_spice_requiredcheckses from spice_exportrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestid'>
            /// key: spice_exportrequestid of spice_exportrequest
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMspiceRequiredchecksCollection> GetWithHttpMessages(this IExportrequestspicerequiredcheckses operations, string spiceExportrequestid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(spiceExportrequestid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get spice_exportrequest_spice_requiredcheckses from spice_exportrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestid'>
            /// key: spice_exportrequestid of spice_exportrequest
            /// </param>
            /// <param name='activityid'>
            /// key: activityid of spice_requiredchecks
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMspiceRequiredchecks RequiredchecksesByKey(this IExportrequestspicerequiredcheckses operations, string spiceExportrequestid, string activityid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.RequiredchecksesByKeyAsync(spiceExportrequestid, activityid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get spice_exportrequest_spice_requiredcheckses from spice_exportrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestid'>
            /// key: spice_exportrequestid of spice_exportrequest
            /// </param>
            /// <param name='activityid'>
            /// key: activityid of spice_requiredchecks
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMspiceRequiredchecks> RequiredchecksesByKeyAsync(this IExportrequestspicerequiredcheckses operations, string spiceExportrequestid, string activityid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RequiredchecksesByKeyWithHttpMessagesAsync(spiceExportrequestid, activityid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get spice_exportrequest_spice_requiredcheckses from spice_exportrequests
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='spiceExportrequestid'>
            /// key: spice_exportrequestid of spice_exportrequest
            /// </param>
            /// <param name='activityid'>
            /// key: activityid of spice_requiredchecks
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMspiceRequiredchecks> RequiredchecksesByKeyWithHttpMessages(this IExportrequestspicerequiredcheckses operations, string spiceExportrequestid, string activityid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.RequiredchecksesByKeyWithHttpMessagesAsync(spiceExportrequestid, activityid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}
