using OpenSilver;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overlisten.Extension
{
    internal static class Audio
    {
        internal static void DownloadAudio(string path, string fileName)
        {
            Interop.ExecuteJavaScriptAsync(@"
    // Create an anchor element
    var link = document.createElement('a');
    link.href = """ + Config.Server + path + @""";
    link.download = """ + fileName + @""";
    link.target = ""_blank""; // Set the target attribute to _blank to open in a new tab

    // Dispatch a click event on the anchor element
    var clickEvent = new MouseEvent('click', {
        view: window,
        bubbles: true,
        cancelable: true
    });
    link.dispatchEvent(clickEvent);
");

        }

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
