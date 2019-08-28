using Rocket.API;
using System.Collections.Generic;

namespace RichAnnouncer
{
    public class Configuration : IRocketPluginConfiguration
    {

        public float IntervalSecs;



        public List<Message> Messages;


        public void LoadDefaults()
        {
            IntervalSecs = 15;

            Messages = new List<Message>
            {
                new Message
                {
                    MessageText = "{color=red}REDSTONEPLUGINS{/color} {color=yellow}GLOW PLUGINS{/color}",
                    Img = "https://imgur.com/a/vJPuBeM"

                },
                new Message
                {
                    MessageText = "{size=15}{b}SIZE ALLOWED{/b}{/size}",
                    Img = "https://imgur.com/a/vJPuBeM"

                }
            };
            

        }
    }
}