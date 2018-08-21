using Cloud.Client.ASR.Model;
using Cloud.Client.ASR.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SessionApi sessionApi = new SessionApi();
            StartSessionRequest startSession = new StartSessionRequest("user", "password", 290);
            var response = sessionApi.StartSession(startSession);
            Guid? sessionId = response.SessionId;
        }
    }
}
