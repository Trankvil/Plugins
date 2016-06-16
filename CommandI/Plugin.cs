using Rocket.API;
using Rocket.API.Collections;
using Rocket.Core.Plugins;
using Rocket.Core.Logging;


namespace CommandI
{
    public class Plugin : RocketPlugin<Configuration>
    {
        public static Plugin Instance;


        protected override void Load() {
            Instance = this;
            Logger.LogWarning("======[GamesBones v2.1.1.0]======");
        }

        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList
                 {
                     { "text_block", "Вы не имеете доступ к выдаче данного предмета." },
                 };
            }
        }

    }

    public class Configuration : IRocketPluginConfiguration
    {
        public int BonesCoolDownSeconds;
        public int AmountCoins;
        public string ColorZero;
        public string ColorLose;
        public string ColorBrake;
        public string ColorWin;
        public string ColorTime;

        public void LoadDefaults()
        {
            BonesCoolDownSeconds = 1800;
            AmountCoins = 100;
            ColorZero = "red";
            ColorLose = "red";
            ColorBrake = "yellow";
            ColorWin = "green";
            ColorTime = "red";
        }
    }
}