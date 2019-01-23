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
                    AutoResetEvent m_MessageReceiveEvent = new AutoResetEvent(false);
        AutoResetEvent m_OpenedEvent = new AutoResetEvent(false);
        AutoResetEvent m_CloseEvent = new AutoResetEvent(false);
        var sessionApi = new SessionApi();
            var startSession = new AuthRequestDto("danilov-k@speechpro.com", 261, "!CPa490c71");
            var response = sessionApi.Login(startSession);
            var sessionId = response.SessionId;
            var recognizeApi = new RecognizeApi();
            var soundBytes = File.ReadAllBytes("F:\\Art\\pcm\\0068_20170407_own_6944_181007-1496930080.wav");
            var audio = new AudioFileDto(soundBytes, "audio/wav");
            var streamRequest = new StreamRequestDto("CommonRus", "audio/l16");
            var websocketConfig = recognizeApi.Start(Guid.Parse(sessionId), streamRequest);
            var websocketURL = websocketConfig.Url;
            WebSocket websocket = new WebSocket(websocketURL);
            var proxy = new HttpConnectProxy(new IPEndPoint(IPAddress.Parse("192.168.8.100"), 3128));
            websocket.Proxy = (SuperSocket.ClientEngine.IProxyConnector)proxy;
            websocket.Opened += new EventHandler(Websocket_Opened);
            websocket.Error += new EventHandler<SuperSocket.ClientEngine.ErrorEventArgs>(Websocket_Error);
            websocket.Closed += new EventHandler(Websocket_Closed);
            websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(Websocket_MessageReceived);
            websocket.DataReceived += new EventHandler<DataReceivedEventArgs>(Websocket_DataReceived);
            websocket.Open();

            /*if (!m_OpenedEvent.WaitOne(5000))
            {
                Console.WriteLine("Failed to Opened session ontime");
            }*/
            

          /*  if (!m_MessageReceiveEvent.WaitOne(5000)) {
                Console.WriteLine("Cannot get response in time!");
            }*/
                // you should implement methods for different events

                void Websocket_MessageReceived(object sender, MessageReceivedEventArgs e)
            {
                Console.WriteLine("Message!");
            }

            void Websocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
            {
                Console.WriteLine("Error!" + e.Exception.Message);
            }

            void Websocket_Closed(object sender, EventArgs e)
            {
                Console.WriteLine("Closed!");
            }

            void Websocket_Opened(object sender, EventArgs e)
            {

                Console.WriteLine("Opened!");
                websocket.Send(soundBytes, 0, soundBytes.Length);
                Console.WriteLine("Data sent!");

            }

            void Websocket_DataReceived(object sender, DataReceivedEventArgs e)
            {
                Console.WriteLine("Data!");
            }

            Console.ReadLine();
        }


    }
}
