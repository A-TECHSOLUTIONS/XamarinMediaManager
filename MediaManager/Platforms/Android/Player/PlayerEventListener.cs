﻿using Android.Hardware.Lights;
using Android.Runtime;
using Com.Google.Android.Exoplayer2;
using Com.Google.Android.Exoplayer2.Metadata.Icy;
using Com.Google.Android.Exoplayer2.Metadata;
using Com.Google.Android.Exoplayer2.Source;
using Com.Google.Android.Exoplayer2.Trackselection;
using Com.Google.Android.Exoplayer2.Video;
using static Com.Google.Android.Exoplayer2.IPlayer;

namespace MediaManager.Platforms.Android.Player
{
    public class PlayerEventListener : Java.Lang.Object, IEventListener, IPlayer.IListener
    {
        public PlayerEventListener()
        {
        }

        protected PlayerEventListener(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
        {
        }

        public Action<TrackGroupArray, TrackSelectionArray> OnTracksChangedImpl { get; set; }
        public Action<int> OnPositionDiscontinuityImpl { get; set; }
        public Action<bool, int> OnPlayerStateChangedImpl { get; set; }
        public Action<ExoPlaybackException> OnPlayerErrorImpl { get; set; }
        public Action<bool> OnLoadingChangedImpl { get; set; }
        public Action<PlaybackParameters> OnPlaybackParametersChangedImpl { get; set; }
        public Action<int> OnRepeatModeChangedImpl { get; set; }
        public Action OnSeekProcessedImpl { get; set; }
        public Action<bool> OnShuffleModeEnabledChangedImpl { get; set; }
        public Action<Timeline, int> OnTimelineChangedImpl { get; set; }
        public Action<bool> OnIsPlayingChangedImpl { get; set; }
        public Action<int> OnPlaybackSuppressionReasonChangedImpl { get; set; }
        public Action<Metadata> OnMetadataChangedImpl { get; set; }

        public void OnTracksChanged(TrackGroupArray trackGroups, TrackSelectionArray trackSelections)
        {
            /*for (var i = 0; i < trackGroups.Length; i++)
            {
                var trackGroup = trackGroups.Get(i);
                for (var j = 0; j < trackGroup.Length; j++)
                {
                    var trackMetadata = trackGroup.GetFormat(j).Metadata;

                    if (trackMetadata != null)
                    {
                        for (var v = 0; v < trackMetadata.Length(); v++)
                        {
                            var entry = trackMetadata.Get(v);

                            switch (entry)
                            {
                                case ApicFrame apicFrame:
                                    var bitmapData = apicFrame.PictureData.ToArray();
                                    var bitmap = BitmapFactory.DecodeByteArray(bitmapData, 0, bitmapData.Length);
                                    var test1 = apicFrame.MimeType;
                                    break;
                                case BinaryFrame binaryFrame:
                                    var test2 = binaryFrame.Data;
                                    break;
                                case ChapterFrame chapterFrame:
                                    var test3 = chapterFrame.ChapterId;
                                    break;
                                case ChapterTocFrame chapterTocFrame:
                                    var test4 = chapterTocFrame.IsRoot;
                                    break;
                                case CommentFrame commentFrame:
                                    var test5 = commentFrame.Text;
                                    break;
                                case GeobFrame geobFrame:
                                    var test6 = geobFrame.Data;
                                    break;
                                case InternalFrame internalFrame:
                                    var test7 = internalFrame.Text;
                                    break;
                                case PrivFrame privFrame:
                                    var test8 = privFrame.PrivateData;
                                    break;
                                case TextInformationFrame textInformationFrame:
                                    var test9 = textInformationFrame.Value;
                                    break;
                                case UrlLinkFrame urlLinkFrame:
                                    var test10 = urlLinkFrame.Url;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }*/

            OnTracksChangedImpl?.Invoke(trackGroups, trackSelections);
        }

        public void OnPositionDiscontinuity(int reason)
        {
            OnPositionDiscontinuityImpl?.Invoke(reason);
        }

        public void OnPlayerStateChanged(bool playWhenReady, int playbackState)
        {
            OnPlayerStateChangedImpl?.Invoke(playWhenReady, playbackState);
        }

        public void OnPlayerError(ExoPlaybackException error)
        {
            OnPlayerErrorImpl?.Invoke(error);
        }

        public void OnLoadingChanged(bool isLoading)
        {
            OnLoadingChangedImpl?.Invoke(isLoading);
        }

        public void OnPlaybackParametersChanged(PlaybackParameters playbackParameters)
        {
            OnPlaybackParametersChangedImpl?.Invoke(playbackParameters);
        }

        public void OnRepeatModeChanged(int repeatMode)
        {
            OnRepeatModeChangedImpl?.Invoke(repeatMode);
        }

        public void OnSeekProcessed()
        {
            OnSeekProcessedImpl?.Invoke();
        }

        public void OnShuffleModeEnabledChanged(bool shuffleModeEnabled)
        {
            OnShuffleModeEnabledChangedImpl?.Invoke(shuffleModeEnabled);
        }

        public void OnTimelineChanged(Timeline timeline, int reason)
        {
            OnTimelineChangedImpl?.Invoke(timeline, reason);
        }

        public void OnIsPlayingChanged(bool isPlaying)
        {
            OnIsPlayingChangedImpl?.Invoke(isPlaying);
        }

        public void OnPlaybackSuppressionReasonChanged(int playbackSuppressionReason)
        {
            OnPlaybackSuppressionReasonChangedImpl?.Invoke(playbackSuppressionReason);
        }

        // The following methods were added per advice given here:
        // https://github.com/Baseflow/XamarinMediaManager/issues/877#issuecomment-1322624782

        public void OnPositionDiscontinuity(IPlayer.PositionInfo oldPosition, IPlayer.PositionInfo newPosition, int reason)
        {

        }



        //public void OnTracksChanged(Com.Google.Android.Exoplayer2.Tracks tracks)
        //{
        //}


        public void OnMediaItemTransition(MediaItem MediaItem, int reason)
        {
        }

        public void OnPlaybackStateChanged(int state)
        {
        }

        public void OnPlayWhenReadyChanged(bool playWhenReady, int reason)
        {
        }

        public void OnEvents(IPlayer Player, IPlayer.Events Events)
        {
        }

        public void OnIsLoadingChanged(bool changed)
        {
        }

        public void OnStaticMetadataChanged(System.Collections.Generic.IList<Metadata> metadataList)
        {
        }

        public void OnMediaMetadataChanged(MediaMetadata mediaMetadata)
        {
        }

        public void OnMetadata(Metadata metadata)
        {

        }

        public void OnDeviceVolumeChanged(int Volume, bool Muted)
        {
        }

        public void OnAvailableCommandsChanged(global::Com.Google.Android.Exoplayer2.IPlayer.Commands? availableCommands)
        {
        }

        //Video related methods
        public void OnSurfaceSizeChanged(int width, int height)
        {
            Console.WriteLine($"OnSurfaceSizeChanged: {width}, {height}");
        }

        public void OnVideoSizeChanged(VideoSize size)
        {
            Console.WriteLine($"OnVideoSizeChanged: {size}");
        }

        public void OnRenderedFirstFrame()
        {
            Console.WriteLine($"OnRenderedFirstFrame");
        public void OnMetadata(Metadata p0)
        {
            OnMetadataChangedImpl?.Invoke(p0);
        }
    }
}
