using Rocket.API;
using System.Collections.Generic;

namespace educatalan02.RichAnnouncer
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
                    MessageText = "{size=20}WARNING{/size} {color=red}REDSTONEPLUGINS{/color} {color=cyan}Supports{/color} {i}{b}{color=purple}RichText{/color}{/b}{/i}",
                    Img = "https://i.imgur.com/mTOsvly.png"

                },
                new Message
                {
                    MessageText = "{size=15}{b}SIZE ALLOWED{/b}{/size}",
                    Img = "https://i.imgur.com/mTOsvly.png"

                }
            };
            

        }
    }
}