using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ BasicExpstone = () => Behav()
            .Init("Basic expstone",
                new State(
                    new State("default",
                        new PlayerWithinTransition(8, "basic")
                        ),
                    new State("basic",
                        new Prioritize(
                            new Wander(0.005)
                            ),
                        new Shoot(4, 4, predictive: 5, coolDown: 1750)
                        )
                ),
                new Threshold(0.00025,
                    new TierLoot(1, ItemType.Weapon, 0.1),
                    new TierLoot(4, ItemType.Armor, 0.0004),
                    new TierLoot(1, ItemType.Ring, 0.03),
                    new TierLoot(2, ItemType.Armor, 0.02),
                    new TierLoot(3, ItemType.Weapon, 0.004),
                    new TierLoot(2, ItemType.Ring, 0.01),
                    new ItemLoot("Stoned dagger", 0.005),
                    new TierLoot(2, ItemType.Weapon, 0.005),
                    new TierLoot(3, ItemType.Armor, 0.005),
                    new TierLoot(1, ItemType.Armor, 0.1)
                )

                    
            )
            ;
    } }
