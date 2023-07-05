using OpenSilver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Overlisten.Extension
{
    internal static class Audio
    {
        internal static void PlayAudio(string path)
        {
            Interop.ExecuteJavaScriptAsync(@"
                if (typeof currentAudio !== 'undefined' && currentAudio !== null) {
                    currentAudio.pause(); // Stop the currently playing audio
                }
                var audio = new Audio();
                audio.src = '" + Config.Server + path + @"';
                audio.type = 'audio/ogg';
                audio.volume = 0.2;
                audio.play();
                currentAudio = audio;
            ");
        }
    }
}
