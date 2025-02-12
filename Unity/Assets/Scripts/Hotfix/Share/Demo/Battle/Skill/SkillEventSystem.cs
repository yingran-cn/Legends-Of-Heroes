﻿using System;
using System.Collections.Generic;

namespace ET
{
    [EntitySystemOf(typeof(SkillEvent))]
    [FriendOf(typeof(SkillEvent))]
    public static class SkillEventSystem
    {
        /*[ObjectSystem]
        public class SkillEntityAwakeSystem : AwakeSystem<SkillEvent, SkillConfig>
        {
            protected override void Awake(SkillEvent self, SkillConfig skillConfig)
            {
                self.EventData = skillConfig.Params;
                //触发时间 = 事件触发百分比 * 技能时长 + 技能触发时间
                self.EventTriggerTime = skillConfig.Params[0] * self.EventData[2] / 100 + TimeHelper.ServerNow();
                self.SkillEventType = (ESkillEventType)skillConfig.Params[1];
            }
        }*/
        
        public static void Awake(this SkillEvent self, SkillConfig skillConfig)
        {
            self.EventData = skillConfig.Params;
            //触发时间 = 事件触发百分比 * 技能时长 + 技能触发时间
            self.EventTriggerTime = skillConfig.Params[0] * self.EventData[2] / 100 + self.Fiber().TimeInfo.ServerNow();
            self.SkillEventType = (ESkillEventType)skillConfig.Params[1];
        }

        public static void Transfer(this SkillEvent self)
        {
            
        }
        public static void Destroy(this SkillEvent self)
        {
            
        }
    }
}