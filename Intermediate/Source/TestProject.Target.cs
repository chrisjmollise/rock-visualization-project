using UnrealBuildTool;

public class TestProjectTarget : TargetRules
{
	public TestProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TestProject");
	}
}
