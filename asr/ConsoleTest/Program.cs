using Cloud.ASR.Api;
using Cloud.ASR.Model;
using SuperSocket.ClientEngine;
using SuperSocket.ClientEngine.Proxy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using WebSocket4Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConcoleTest
{
    class Program
    {

        static void Main(string[] args)
        {
            var sessionApi = new SessionApi();
            var startSession = new AuthRequestDto("user", 261, "password");
            var response = sessionApi.Login(startSession);
            var sessionId = response.SessionId;
            var recognizeApi = new RecognizeApi();
            var soundBytes = File.ReadAllBytes("F:\\Art\\pcm\\0068_20170407_own_6944_181007-1496930080.wav");
            var audio = new AudioFileDto(soundBytes, "audio/x-wav");
            var recognitionRequest = new RecognitionRequestDto(audio, "FarField");
            var recognitionRequestResponse = recognizeApi.RecognizeWords(Guid.Parse(sessionId), recognitionRequest);
            recognitionRequestResponse.ForEach(Console.WriteLine);
        }
    }
}
