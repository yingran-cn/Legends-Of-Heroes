﻿

namespace ET.Server
{
	[ActorMessageLocationHandler(SceneType.Map)]
	public class G2M_SessionDisconnectHandler : ActorMessageLocationHandler<Unit, G2M_SessionDisconnect>
	{
		protected override async ETTask Run(Unit unit, G2M_SessionDisconnect message)
		{
			await ETTask.CompletedTask;
		}
	}
}