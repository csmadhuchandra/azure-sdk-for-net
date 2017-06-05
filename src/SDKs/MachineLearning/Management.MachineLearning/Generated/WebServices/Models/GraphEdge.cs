// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.MachineLearning;
    using Microsoft.Azure.Management.MachineLearning.WebServices;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines an edge within the web service's graph.
    /// </summary>
    public partial class GraphEdge
    {
        /// <summary>
        /// Initializes a new instance of the GraphEdge class.
        /// </summary>
        public GraphEdge()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GraphEdge class.
        /// </summary>
        /// <param name="sourceNodeId">The source graph node's
        /// identifier.</param>
        /// <param name="sourcePortId">The identifier of the source node's port
        /// that the edge connects from.</param>
        /// <param name="targetNodeId">The destination graph node's
        /// identifier.</param>
        /// <param name="targetPortId">The identifier of the destination node's
        /// port that the edge connects into.</param>
        public GraphEdge(string sourceNodeId = default(string), string sourcePortId = default(string), string targetNodeId = default(string), string targetPortId = default(string))
        {
            SourceNodeId = sourceNodeId;
            SourcePortId = sourcePortId;
            TargetNodeId = targetNodeId;
            TargetPortId = targetPortId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the source graph node's identifier.
        /// </summary>
        [JsonProperty(PropertyName = "sourceNodeId")]
        public string SourceNodeId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the source node's port that the edge
        /// connects from.
        /// </summary>
        [JsonProperty(PropertyName = "sourcePortId")]
        public string SourcePortId { get; set; }

        /// <summary>
        /// Gets or sets the destination graph node's identifier.
        /// </summary>
        [JsonProperty(PropertyName = "targetNodeId")]
        public string TargetNodeId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the destination node's port that the
        /// edge connects into.
        /// </summary>
        [JsonProperty(PropertyName = "targetPortId")]
        public string TargetPortId { get; set; }

    }
}