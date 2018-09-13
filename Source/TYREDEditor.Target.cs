

using UnrealBuildTool;
using System.Collections.Generic;

public class TYREDEditorTarget : TargetRules
{
	public TYREDEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "TYRED" } );
	}
}
