using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Firstraid = () => Behav()
            .Init("portly ogre",
                new State(
                    new State("default",
                        new PlayerWithinTransition(8, "basic")
                        ),
                    new State("basic",
                        new Prioritize(
                            new Follow(0.3),
                            new Wander(0.2)
                            ),
                        new Shoot(1, 16, predictive: 0.25, coolDown: 350),
                         new HpLessTransition(270000000, "Real aTTACK")
                        ),
                    new State("Real aTTACK",
                         new Follow(0.3),
                          new Wander(0.02),
                            new Shoot(1, 25, predictive: 0.5, coolDown: 175),
                    new HpLessTransition(250000000, "STOP") 
                        ),
                    new State("STOP",
                         new Follow(0.1),
                          new Wander(0.001),
                          new Shoot(1, 5, predictive: 0.5, coolDown: 175, coolDownOffset: 200),
                        new Shoot(1, 8, predictive: 0.5, coolDown: 175, coolDownOffset: 600),
                        new Shoot(1, 14, predictive: 0.5, coolDown: 175, coolDownOffset: 800),
                        new Shoot(1, 18, predictive: 0.5, coolDown: 175, coolDownOffset: 1200),
                        new Shoot(1, 20, predictive: 0.5, coolDown: 175, coolDownOffset: 1500),
                        new Shoot(1, 24, predictive: 0.5, coolDown: 175, coolDownOffset: 1700),
                        new Shoot(1, 29, predictive: 0.5, coolDown: 175, coolDownOffset: 2100),
                        new HpLessTransition(240000000, "FOR REAL!")
                        ),
                        new State("FOR REAL!",
                         new Follow(0.1),
                          new Wander(0.001),
                         new Shoot(1, 22, predictive: 0.5, coolDown: 175, coolDownOffset: 23200),
                        new Shoot(1, 16, predictive: 0.5, coolDown: 175, coolDownOffset: 14600),
                        new Shoot(1, 27, predictive: 0.5, coolDown: 175, coolDownOffset: 19800),
                        new Shoot(1, 22, predictive: 0.5, coolDown: 175, coolDownOffset: 16200),
                        new Shoot(1, 11, predictive: 0.5, coolDown: 175, coolDownOffset: 11500),
                        new Shoot(1, 9, predictive: 0.5, coolDown: 175, coolDownOffset: 11700),
                        new Shoot(1, 7, predictive: 0.5, coolDown: 175, coolDownOffset: 15100),
                            new HpLessTransition(220000000, "MORE COMMING SOON!!")
                            ),
                              new State("MORE COMMING SOON!!",
                         new Follow(0.1),
                          new Wander(0.001)
                        )
            ))
            ;
    }
}