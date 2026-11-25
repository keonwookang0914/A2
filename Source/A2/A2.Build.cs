// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class A2 : ModuleRules
{
	public A2(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"A2",
			"A2/Variant_Platforming",
			"A2/Variant_Platforming/Animation",
			"A2/Variant_Combat",
			"A2/Variant_Combat/AI",
			"A2/Variant_Combat/Animation",
			"A2/Variant_Combat/Gameplay",
			"A2/Variant_Combat/Interfaces",
			"A2/Variant_Combat/UI",
			"A2/Variant_SideScrolling",
			"A2/Variant_SideScrolling/AI",
			"A2/Variant_SideScrolling/Gameplay",
			"A2/Variant_SideScrolling/Interfaces",
			"A2/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
