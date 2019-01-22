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
            var startSession = new AuthRequestDto("danilov-k@speechpro.com", 261, "!CPa490c71");
            var response = sessionApi.Login(startSession);
            var sessionId = response.SessionId;
            Console.WriteLine(sessionId);
            sessionApi.Logout(new Guid(sessionId));
            Console.ReadLine();
            /*var diarizationApi = new DiarizationApi();
            var sound = File.ReadAllBytes("F:\\Cloud\\3.2\\swagger\\diarization\\ira_8khz.wav");
            var audio = new AudioDto(sound);
            var diarizationResponse = diarizationApi.Diarization(Guid.Parse(sessionId), audio);
            var speakers = diarizationResponse.Speakers;*/
        }
    }
}
