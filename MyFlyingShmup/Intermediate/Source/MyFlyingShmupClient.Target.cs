using UnrealBuildTool;

public class MyFlyingShmupClientTarget : TargetRules
{
	public MyFlyingShmupClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MyFlyingShmup");
	}
}
