using UnrealBuildTool;

public class MyFlyingShmupServerTarget : TargetRules
{
	public MyFlyingShmupServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MyFlyingShmup");
	}
}
