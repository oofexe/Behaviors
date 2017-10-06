using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ fakewhite = () => Behav()
                                    .Init("fake-whitebagClone",
                new State(
                    new State("Attack",
                        new Shoot(12, projectileIndex: 0, count: 4, coolDown: 1200)
                    )
            )
            ;
    }
}