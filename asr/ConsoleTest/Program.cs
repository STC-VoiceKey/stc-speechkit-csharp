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
            var startSession = new AuthRequestDto("danilov-k@speechpro.com", 261, "!CPa490c71");
            var response = sessionApi.Login(startSession);
            var sessionId = response.SessionId;
            var recognizeApi = new RecognizeApi();
            var streamRequest = new StreamRequestDto("CommonRus", "audio/l16");
            var websocketConfig = recognizeApi.StartWithHttpInfo(Guid.Parse(sessionId), streamRequest);
            var headers = websocketConfig.Headers;
            var transactionId = headers["X-Transaction-Id"];
            Console.WriteLine(transactionId);
            recognizeApi.Close(Guid.Parse(sessionId), Guid.Parse(transactionId));
            Console.ReadLine();
        }
        //var proxy = new HttpConnectProxy(new IPEndPoint(IPAddress.Parse("192.168.8.100"), 3128));
        //websocket.Proxy = (SuperSocket.ClientEngine.IProxyConnector) proxy;

    }
}
