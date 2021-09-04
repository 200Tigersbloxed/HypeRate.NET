// v2 Code referenced from https://github.com/qe201020335/HRCounter/blob/master/HRCounter/Data/HypeRate.cs
// thank you =3 <3

using Newtonsoft.Json.Linq;
using System;
using WebSocketSharp;
using System.Timers;

namespace HypeRate.NET
{
    public class HeartRate
    {
        private string sessionId;

        private string v2URL = "wss://app.hyperate.io/socket/websocket";
        private string sessionJson;
        private WebSocket v2WebSocket;
        private Timer v2Timer;

        public int HR { get; private set; } = 0;
        public bool isSubscribed { get; private set; } = false;

        public HeartRate(string SessionID)
        {
            sessionId = SessionID;
        }

        public void Subscribe()
        {
            sessionJson = GenerateSessionJson();
            StartWebsocket();
            StartV2Timer();
        }

        public void Unsubscribe()
        {
            StopWebsocket();
            StopV2Timer();
        }

        private string GenerateSessionJson()
        {
            // Assumes HeartRate has been created
            return "{\"topic\": \"hr:" + sessionId + "\",\"event\": \"phx_join\",\"payload\": {},\"ref\": 0}";
        }

        private void StartWebsocket()
        {
            if(v2WebSocket == null)
            {
                v2WebSocket = new WebSocket(v2URL);
                v2WebSocket.OnMessage += V2WebSocket_OnMessage;
                v2WebSocket.OnOpen += V2WebSocket_OnOpen;
                v2WebSocket.OnClose += V2WebSocket_OnClose;
                v2WebSocket.SslConfiguration.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;
                v2WebSocket.Connect();
            }
        }

        private void V2WebSocket_OnOpen(object sender, EventArgs e)
        {
            v2WebSocket.Send(sessionJson);
            isSubscribed = true;
        }
        private void V2WebSocket_OnClose(object sender, CloseEventArgs e) => isSubscribed = false;

        private void StopWebsocket()
        {
            if(v2WebSocket != null)
            {
                v2WebSocket.Close();
                v2WebSocket = null;
            }
        }

        private void V2WebSocket_OnMessage(object sender, MessageEventArgs e)
        {
            try
            {
                JObject json = JObject.Parse(e.Data);
                if (json["event"] != null && json["event"].ToObject<string>() == "hr_update")
                {
                    if (json["payload"] != null && json["payload"]["hr"] != null)
                    {
                        HR = json["payload"]["hr"].ToObject<int>();
                    }
                    else
                    {
                        throw new Exception("json payload/hr is null!");
                    }
                }
                else
                {
                    throw new Exception("json event is null!");
                }
            }
            catch (Exception) { }
        }

        private void StartV2Timer()
        {
            if(v2Timer == null)
            {
                v2Timer = new Timer(15000);
                v2Timer.Elapsed += V2Timer_Elapsed;
                v2Timer.AutoReset = true;
                v2Timer.Enabled = true;
            }
        }

        private void StopV2Timer()
        {
            if(v2Timer != null)
            {
                v2Timer.AutoReset = false;
                v2Timer.Enabled = false;
                v2Timer.Stop();
                v2Timer = null;
            }
        }

        private void V2Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // presuming this is to keep the websocket connection alive
            if (v2WebSocket.IsAlive)
                v2WebSocket.Send("{\"topic\": \"phoenix\",\"event\": \"heartbeat\",\"payload\": {},\"ref\": 123456}");
        }
    }
}