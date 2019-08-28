using Rocket.Core.Plugins;
using SDG.Unturned;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger = Rocket.Core.Logging.Logger;
using UnityEngine;

namespace RichAnnouncer
{
    public class Main : RocketPlugin<Configuration>
    {



        private int index;

        protected override void Load()
        {
            Logger.Log("RichAnnouncer loaded correctly by educatalan02#1236");

            Logger.LogWarning("[RichAnnouncer] Discord Support: discord.gg/Q89FmUk");

            StartCoroutine((IEnumerator)Count());
        }

        protected override void Unload()
        {
            StopCoroutine((IEnumerator)Count());
            Logger.Log("RichAnnouncer Unloaded");
        }



        private IEnumerator<WaitForSeconds> Count()
        {
            PrintMessages();
            yield return new WaitForSeconds((float)Configuration.Instance.IntervalSecs);
        }



        private void PrintMessages()
        {
            
            Message message = Configuration.Instance.Messages[index];

            
            ChatManager.serverSendMessage(message.MessageText.Replace('{', '<').Replace('}', '>'), Color.white, null, null, EChatMode.GLOBAL, message.Img, true);

            index++;
        }
    }
}
