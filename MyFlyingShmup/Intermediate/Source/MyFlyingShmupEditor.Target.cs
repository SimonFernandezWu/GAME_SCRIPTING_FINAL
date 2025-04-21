using UnrealBuildTool;

public class MyFlyingShmupEditorTarget : TargetRules
{
	public MyFlyingShmupEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("MyFlyingShmup");
	}
}
