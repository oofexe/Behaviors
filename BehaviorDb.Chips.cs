using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Chips = () => Behav()
            .Init("Chips",
                new State(
                    new State("default",
                        new PlayerWithinTransition(8, "basic")
                        ),
                    new State("basic",
                        new Prioritize(
                            ),
                        new Shoot(4, projectileIndex: 0, count: 4, shootAngle: 4, coolDown: 2500)


                )
            )  
                    
            )
            ;
    }
}