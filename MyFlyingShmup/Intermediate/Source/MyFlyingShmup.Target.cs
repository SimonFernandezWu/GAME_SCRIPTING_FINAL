using UnrealBuildTool;

public class MyFlyingShmupTarget : TargetRules
{
	public MyFlyingShmupTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyFlyingShmup");
	}
}
