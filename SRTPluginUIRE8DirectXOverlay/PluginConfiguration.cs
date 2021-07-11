namespace SRTPluginUIRE2DirectXOverlay
{
    public class PluginConfiguration
    {
        public bool Debug { get; set; }
        public bool NoInventory { get; set; }
        public bool ShowHPBars { get; set; }
        public bool ShowBossesOnly { get; set; }
        public bool ShowPlayerPosition { get; set; }
        public bool ShowDifficultyAdjustment { get; set; }
        public bool ShowCurrentEvent { get; set; }
        public bool ShowLeiCount { get; set; }
        public float ScalingFactor { get; set; }

        public float PositionX { get; set; }
        public float PositionY { get; set; }

        public float EnemyHPPositionX { get; set; }
        public float EnemyHPPositionY { get; set; }

        public string StringFontName { get; set; }
        public string StringPositionX { get; set; }
        public string StringPositionY { get; set; }
        public string StringPositionZ { get; set; }
        public string RankString { get; set; }
        public string ScoreString { get; set; }
        public string EventString { get; set; }
        public string LeiString { get; set; }
        public string EnemyString { get; set; }

        public PluginConfiguration()
        {
            Debug = false;
            NoInventory = true;
            ShowHPBars = true;
            ShowBossesOnly = false;
            ShowPlayerPosition = true;
            ShowDifficultyAdjustment = true;
            ShowCurrentEvent = true;
            ShowLeiCount = true;
            ScalingFactor = 1f;
            PositionX = 5f;
            PositionY = 300f;
            EnemyHPPositionX = -1;
            EnemyHPPositionY = -1;
            StringFontName = "Courier New";
            StringPositionX = "X:";
            StringPositionY = "Y:";
            StringPositionZ = "Z:";
            RankString = "DA RANK:";
            ScoreString = "DA SCORE:";
            EventString = "EVENT NAME:";
            LeiString = "LEI:";
            EnemyString = "ENEMY HP";
        }
    }
}
