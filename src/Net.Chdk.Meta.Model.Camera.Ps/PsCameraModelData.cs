using System.Collections.Generic;

namespace Net.Chdk.Meta.Model.Camera
{
    public sealed class PsCameraModelData : CameraModelData
    {
        public IDictionary<string, RevisionData> Revisions { get; set; }
    }
}
