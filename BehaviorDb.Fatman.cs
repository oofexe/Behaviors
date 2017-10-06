using wServer.logic.behaviors;
using wServer.logic.transitions;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Fatman = () => Behav()
            .Init("Fat Man",
                new State(

                    new State("default",
                        new PlayerWithinTransition(8, "begin")
                        ),
                     new State(
                    new State("begin",
                        new Wander(.12),
                        new Taunt("where sthole my chips"),
                             new Shoot(4, projectileIndex: 0, count: 4, shootAngle: 4, coolDown: 1250, coolDownOffset: 1700),
                              new Shoot(9, projectileIndex: 0, count: 6, shootAngle: 9, coolDown: 2350, coolDownOffset: 2700),
                              new HpLessTransition(175000, "chips")
                        ),
                    new State(
                    new State("chips",
                        new Wander(.08),
                        new Taunt("k you sthole it I GET IT BACK!!!!"),
                         new TossObject("Chips", 2, 100, 100000),
                        new TossObject("Chips", 1, 145, 100000),
                        new TossObject("Chips", 1, 200, 100000),
                        new TossObject("Chips", 3, 245, 100000),
                             new Shoot(4, projectileIndex: 0, count: 4, shootAngle: 4, coolDown: 753, coolDownOffset: 1263),
                              new Shoot(9, projectileIndex: 1, count: 4, shootAngle: 9, coolDown: 953, coolDownOffset: 1566),
                              new HpLessTransition(145000, "why you killed them")
                        ),
                     new State(
                    new State("why you killed them"),
                        new Taunt("WHY YOU KILLED MY CHIPS!!!!"),
                        new Taunt("CHILLY CHILLY NIBBA!!!!"),
                            new HpLessTransition(140000, "MOAR TOSS")
                        ),
                     // THANKS TO MIKE FOR HELP ME ABIT
                     new State(
                    new State("MOAR TOSS",
                        new Taunt("PILLARS DEFEND ME!!!!"),
                         new TossObject("Polished Silver Pillar", 1, 0, 15000),
                         new TossObject("shadow pillar", 1, 90, 15000),
                         new TossObject("Abyssal Pillar", 1, 180, 15000),
new Shoot(radius: 50, count: 9, fixedAngle: -0, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 50, count: 9, fixedAngle: -90, coolDown: 2000, coolDownOffset: 0),
                        new HpLessTransition(125000, "Back to normal")
                        ),
                     new State(
                    new State("Back to normal",
                        new Taunt("PILLAR COME NEAR!!!!"),
                         new TossObject("Polished Silver Pillar", 1, 0, 15000),
                         new TossObject("shadow pillar", 1, 45, 15000),
                         new TossObject("Abyssal Pillar", 1, 90, 15000),
                         new Shoot(1, projectileIndex: 0, count: 2, shootAngle: 1, coolDown: 653, coolDownOffset: 453),
                         new Shoot(2, projectileIndex: 1, count: 3, shootAngle: 2, coolDown: 787, coolDownOffset: 673),
                         new Shoot(12, projectileIndex: 2, count: 6, shootAngle: 12, coolDown: 1245, coolDownOffset: 1248),
                         new HpLessTransition(45000, "lelxdimfat")
                        ),
                    new State(
                    new State("lelxdimfat",
                        new Taunt("STOP PILLARS YOU ARE USELESS!!!!"),
                         new Shoot(5, projectileIndex: 0, count: 7, shootAngle: 5, coolDown: 1800, coolDownOffset: 0),
                         new Shoot(10, projectileIndex: 1, count: 7, shootAngle: 10, coolDown: 2000, coolDownOffset: 0),
                         new Shoot(15, projectileIndex: 2, count: 7, shootAngle: 15, coolDown: 2200, coolDownOffset: 0),
                         new HpLessTransition(15000, "last phase tbh for real")
                        ),
                         new State(
                    new State("last phase tbh for real",
                        new Taunt("STOP PILLARS YOU ARE USELESS!!!!"),
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new ConditionalEffect(ConditionEffectIndex.Damaging),
                        new ConditionalEffect(ConditionEffectIndex.Bleeding),
new Shoot(radius: 90, count: 4, fixedAngle: -5, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -10, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -15, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -20, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -25, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -30, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -35, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -40, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -45, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -50, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -55, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -60, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -65, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -70, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -75, coolDown: 2000, coolDownOffset: 0),
new Shoot(radius: 90, count: 4, fixedAngle: -80, coolDown: 2000, coolDownOffset: 0),
                         new HpLessTransition(10000, "Death")
                        ),
                         new State("Death",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new TimedTransition(1000, "Suicide")
                            ),
                        new State("Suicide",
                            new Shoot(35, projectileIndex: 1, count: 30),
                            new Suicide()
                            )


))))))));
        
    }
}