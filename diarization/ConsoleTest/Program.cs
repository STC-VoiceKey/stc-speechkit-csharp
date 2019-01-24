using Cloud.Diarization.Api;
using Cloud.Diarization.Model;
using System;
using System.IO;

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
            var diarizationApi = new DiarizationApi();
            var sound = File.ReadAllBytes("F:\\Cloud\\diarization\\8khz.wav");
            var audio = new AudioDto(sound);
            var diarizationResponse = diarizationApi.Diarization(Guid.Parse(sessionId), audio);
            var speakers = diarizationResponse.Speakers;
            speakers.ForEach(Console.WriteLine);
        }
    }
}
