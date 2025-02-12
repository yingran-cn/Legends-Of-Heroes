﻿using System.Net;
using System.Net.Sockets;
using ET.Client;

namespace ET.Server
{
    [Invoke((long)SceneType.BenchmarkServer)]
    public class FiberInit_BenchmarkServer: AInvokeHandler<FiberInit, ETTask>
    {
        public override async ETTask Handle(FiberInit fiberInit)
        {
            Scene root = fiberInit.Fiber.Root;
            //root.AddComponent<MailBoxComponent, MailBoxType>(MailBoxType.UnOrderedMessage);
            //root.AddComponent<TimerComponent>();
            //root.AddComponent<CoroutineLockComponent>();
            //root.AddComponent<ActorInnerComponent>();
            //root.AddComponent<ActorSenderComponent>();
            //root.AddComponent<PlayerComponent>();
            //root.AddComponent<GateSessionKeyComponent>();
            //root.AddComponent<LocationProxyComponent>();
            //root.AddComponent<ActorLocationSenderComponent>();
            root.AddComponent<NetServerComponent, IPEndPoint>(StartSceneConfigCategory.Instance.Benchmark.OuterIPPort);
            root.AddComponent<BenchmarkServerComponent>();
            await ETTask.CompletedTask;
        }
    }
}