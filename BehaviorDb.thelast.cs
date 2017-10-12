using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ thelast = () => Behav()
.Init("warrior king",
new State(
                    new State("all together",
                         new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 102, fixedAngle: 102, coolDown: 6000),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 114, fixedAngle: 114, coolDown: 7000, coolDownOffset: 1200),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 126, fixedAngle: 126, coolDown: 8000, coolDownOffset: 1400),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 138, fixedAngle: 138, coolDown: 9000, coolDownOffset: 1600),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 150, fixedAngle: 150, coolDown: 10000, coolDownOffset: 1800),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 162, fixedAngle: 162, coolDown: 11000, coolDownOffset: 2000),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 174, fixedAngle: 174, coolDown: 12000, coolDownOffset: 3200),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 186, fixedAngle: 186, coolDown: 13000, coolDownOffset: 4400),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 198, fixedAngle: 198, coolDown: 14000, coolDownOffset: 5600),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 210, fixedAngle: 210, coolDown: 15000, coolDownOffset: 6800),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 222, fixedAngle: 222, coolDown: 16000, coolDownOffset: 4000),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 234, fixedAngle: 234, coolDown: 17000, coolDownOffset: 5200),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 246, fixedAngle: 246, coolDown: 18000, coolDownOffset: 2400),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 258, fixedAngle: 258, coolDown: 19000, coolDownOffset: 3600),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 270, fixedAngle: 270, coolDown: 20000, coolDownOffset: 5800),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 282, fixedAngle: 270, coolDown: 21000, coolDownOffset: 6000),
                            new Shoot(50, projectileIndex: 1, count: 2, shootAngle: 270, fixedAngle: 277, coolDown: 22000, coolDownOffset: 3200),
                              new Shoot(0, projectileIndex: 0, count: 9, shootAngle: 60, fixedAngle: 15, coolDown: 4333),
                            new Shoot(0, projectileIndex: 0, count: 10, shootAngle: 60, fixedAngle: 30, coolDown: 3500),
                            new Shoot(0, projectileIndex: 0, count: 12, shootAngle: 60, fixedAngle: 60, coolDown: 7250),
                            new Shoot(0, projectileIndex: 0, count: 7, shootAngle: 60, fixedAngle: 90, coolDown: 10000),
                                            new Shoot(15, 5, 5, projectileIndex: 1, coolDown: 800),
                    new Shoot(15, 5, 5, projectileIndex: 1, coolDown: 800, coolDownOffset: 200),
                    new Shoot(15, 5, 5, projectileIndex: 1, coolDown: 800, coolDownOffset: 400),
                    new Shoot(15, 5, 5, projectileIndex: 1, coolDown: 800, coolDownOffset: 600),
                    new Shoot(15, 5, 5, projectileIndex: 1, coolDown: 800, coolDownOffset: 800),
                      new Shoot(15, 1, projectileIndex: 1, fixedAngle: 75, coolDown: 100),
                            new Shoot(15, 2, projectileIndex: 1, fixedAngle: 70, coolDown: 100),
                            new Shoot(15, 3, projectileIndex: 1, fixedAngle: 105, coolDown: 250),
                            new Shoot(15, 2, projectileIndex: 1, fixedAngle: 110, coolDown: 350),
                            new Shoot(15, 4, projectileIndex: 1, fixedAngle: 30, coolDown: 450),
                            new Shoot(15, 2, projectileIndex: 1, fixedAngle: 25, coolDown: 550),
                            new Shoot(15, 5, projectileIndex: 1, fixedAngle: 150, coolDown: 600),
                            new Shoot(15, 2, projectileIndex: 1, fixedAngle: 155, coolDown: 750),
                             new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 3, coolDown: 10800),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 4, coolDown: 10800),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 6, coolDown: 10800, coolDownOffset: 200),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 7, coolDown: 10800, coolDownOffset: 200),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 9, coolDown: 10800, coolDownOffset: 400),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 10, coolDown: 10800, coolDownOffset: 400),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 12, coolDown: 10800, coolDownOffset: 600),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 13, coolDown: 10800, coolDownOffset: 600),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 15, coolDown: 10800, coolDownOffset: 800),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 16, coolDown: 10800, coolDownOffset: 800),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 18, coolDown: 10800, coolDownOffset: 1000),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 19, coolDown: 10800, coolDownOffset: 1000),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 21, coolDown: 10800, coolDownOffset: 1200),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 22, coolDown: 10800, coolDownOffset: 1200),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 24, coolDown: 10800, coolDownOffset: 1400),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 25, coolDown: 10800, coolDownOffset: 1400),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 27, coolDown: 10800, coolDownOffset: 1600),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 28, coolDown: 10800, coolDownOffset: 1600),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 30, coolDown: 10800, coolDownOffset: 1800),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 31, coolDown: 10800, coolDownOffset: 1800),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 33, coolDown: 10800, coolDownOffset: 2000),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 34, coolDown: 10800, coolDownOffset: 2000),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 36, coolDown: 10800, coolDownOffset: 2200),
                            new Shoot(50, projectileIndex: 4, count: 6, shootAngle: 60, fixedAngle: 37, coolDown: 10800, coolDownOffset: 2200),
                        new HpLessTransition(0.10, "DEATH!!")
                        ),
                        new State("DEATH!!",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new CopyDamageOnDeath("shtrs Loot Balloon King"),
                            new Order(1, "shtrs Chest Spawner 3", "Open"),
                            new Taunt("Impossible..........IMPOSSIBLE!"),
                            new TimedTransition(2000, "Suicide")
                            ),
                        new State("Suicide",
                            new Shoot(35, projectileIndex: 0, count: 30),
                            new Suicide()
                    )
                )
            );
    }
}