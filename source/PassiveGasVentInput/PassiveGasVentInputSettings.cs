using Newtonsoft.Json;
using PeterHan.PLib.Options;

namespace PassiveGasVentInput
{
    [JsonObject(MemberSerialization.OptIn)]
    [ModInfo("https://github.com/ihoromi4/ONIMods")]
    [RestartRequired]
    class PassiveGasVentInputSettings : SingletonOptions<PassiveGasVentInputSettings>
    {
        [JsonProperty]
        [Option(Format = "F3")]
        public float MinimumPressure { get; set; }

        [JsonProperty]
        [Option(Format = "F3")]
        public float MinimumFlow { get; set; }

        [JsonProperty]
        [Option(Format = "F3")]
        public float MaximumPressure { get; set; }

        [JsonProperty]
        [Option(Format = "F3")]
        public float MaximumFlow { get; set; }

        public PassiveGasVentInputSettings()
        {
            MinimumPressure = 2.0f;
            MinimumFlow = 0.0f;
            MaximumPressure = 602.0f;
            MaximumFlow = 3.0f;
        }
    }
}
