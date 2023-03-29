using System;
using Android.Runtime;
using Com.Google.Android.Exoplayer2.Metadata;
using Com.Google.Android.Exoplayer2.Metadata.Icy;
using Com.Google.Android.Exoplayer2.Util;
using static Android.Icu.Text.CaseMap;

namespace MediaManager.Platforms.Android.Player
{
    public class MetadataOutput : Java.Lang.Object, IMetadataOutput
    {
        public Action<Metadata> OnMetadataImpl { get; set; }

        public MetadataOutput()
        {
        }

        public MetadataOutput(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }

        public void OnMetadata(Metadata p0)
        {
            OnMetadataImpl?.Invoke(p0);
        }
    }
}
