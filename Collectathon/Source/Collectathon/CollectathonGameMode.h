// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "CollectathonGameMode.generated.h"

/**
 *  Simple GameMode for a third person game
 */
UCLASS(abstract)
class ACollectathonGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	
	/** Constructor */
	ACollectathonGameMode();
};



