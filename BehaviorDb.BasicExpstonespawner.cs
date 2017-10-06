using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Basicexpstonespawner = () => Behav()
.Init("Basic ExpoRockSpanwer",
                new State(
                    new ConditionalEffect(ConditionEffectIndex.Invincible, true),
                    new State("idle",
                    new PlayerWithinTransition(10, "spawn1")
                    ),
                new State("spawn1",
                    new Spawn("Basic expstone", maxChildren: 6, initialSpawn: 1, coolDown: 3500),
                    new TimedTransition(3600, "check")
                    ),
                new State("check",
                    new EntityNotExistsTransition("Basic expstone", 50, "idle")
                    )
                    )
            )
        ;
    }
}