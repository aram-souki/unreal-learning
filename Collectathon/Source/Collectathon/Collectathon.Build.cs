// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Collectathon : ModuleRules
{
	public Collectathon(ReadOnlyTargetRules Target) : base(Target)
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
			"Collectathon",
			"Collectathon/Variant_Platforming",
			"Collectathon/Variant_Platforming/Animation",
			"Collectathon/Variant_Combat",
			"Collectathon/Variant_Combat/AI",
			"Collectathon/Variant_Combat/Animation",
			"Collectathon/Variant_Combat/Gameplay",
			"Collectathon/Variant_Combat/Interfaces",
			"Collectathon/Variant_Combat/UI",
			"Collectathon/Variant_SideScrolling",
			"Collectathon/Variant_SideScrolling/AI",
			"Collectathon/Variant_SideScrolling/Gameplay",
			"Collectathon/Variant_SideScrolling/Interfaces",
			"Collectathon/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
