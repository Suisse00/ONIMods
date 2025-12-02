using STRINGS;

namespace PassiveGasVentInput
{
	class STRINGS
	{
		public class BUILDINGS
		{
			public class PREFABS
			{
				public class PASSIVEGASVENTINPUT
				{
					public static LocString NAME = UI.FormatAsLink("Gas Vent Input", "PASSIVEGASVENTINPUT");
					public static LocString DESC = "Passively takes gas from the environment under a high pressure.";
					public static LocString EFFECT = "Pumps <link=\"ELEMENTS_GAS\">gas</link> into <link=\"GASPIPING\">pipes</link> using high external pressure. Use to pump out excess gas.";

					public class DESCRIPTORS
					{
						public static LocString REQ_PRESSURE_DESC = "Pressure over {0}";
						public static LocString REQ_PRESSURE_TOOLTIP = "Building starts working when <style=\"KKeyword\">pressure</style> is greater than {0}";
						public static LocString DEP_PRESSURE_DESC = "Productivity depends on pressure";
						public static LocString DEP_PRESSURE_TOOLTIP = "Productivity of the building increases by {0} every atm kg";
					}
				}
			}
		}

		public class PASSIVEGASVENTINPUT
		{
			public class OPTIONS
			{
				public class MINIMUMPRESSURE
				{
					public static LocString NAME = "Minimum pressure";
					public static LocString TOOLTIP = "Minimum gas pressure to start working.\nDefault = 2 Kg";
				}

				public class MINIMUMFLOW
				{
					public static LocString NAME = "Minimum flow";
					public static LocString TOOLTIP = "Gas flow at minimum pressure.\nDefault = 0.0 Kg";
				}

				public class MAXIMUMPRESSURE
				{
					public static LocString NAME = "Maximum pressure";
					public static LocString TOOLTIP = "Gas pressure which produces maximum flow.\nDefault = 602 Kg";
				}

				public class MAXIMUMFLOW
				{
					public static LocString NAME = "Maximum flow";
					public static LocString TOOLTIP = "Maximum achievable gas flow.\nDefault = 3 Kg";
				}
			}
		}
	}
}