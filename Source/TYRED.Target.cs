

using UnrealBuildTool;
using System.Collections.Generic;

public class TYREDTarget : TargetRules
{
	public TYREDTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "TYRED" } );
	}
}
