using Cloud.TTS.Api;
using Cloud.TTS.Model;
using SuperSocket.ClientEngine.Proxy;
using System;
using System.IO;
using System.Net;
using WebSocket4Net;

namespace ConcoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var sessionApi = new SessionApi();
            var credentials = new AuthRequestDto("user", 261, "password");
            var sessionId = sessionApi.Login(credentials).SessionId;
            var synthesizeApi = new SynthesizeApi();
            var synthesizeText = new SynthesizeText("text/plain", "Hello world");
            var synthesizeRequest = new SynthesizeRequest(synthesizeText, "Carol", "audio/wav");
            var synthesizedSound = synthesizeApi.Synthesize(Guid.Parse(sessionId), synthesizeRequest).Data;
            var soundBytes = Convert.FromBase64String(synthesizedSound);
            File.WriteAllBytes("F:\\Cloud\\tts\\testWav.wav", soundBytes);
        }
    }
}
