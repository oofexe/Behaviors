#region

using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;

#endregion

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Oryxdragonminion = () => Behav()
        .Init("Oryx the Mad Dragon Miniboss",
               new State(
                    new State("Cycle1",
                        new Taunt("Hello player"),
                        new Shoot(20, 6, 60, 0, 10, coolDown: 2500, coolDownOffset: 2325),
                        new Shoot(20, 6, 60, 0, 20, coolDown: 2600, coolDownOffset: 2650),
                        new Shoot(20, 6, 60, 0, 30, coolDown: 2700, coolDownOffset: 2875),    //Simply Sprial shooting miniboss made by Oeti
                        new Shoot(20, 6, 60, 0, 40, coolDown: 2800, coolDownOffset: 2900),
                        new Shoot(20, 6, 60, 0, 50, coolDown: 2900, coolDownOffset: 2975),
new HpLessTransition(.938, "Cycle2")
                    ),
                    new State(
                    new State("Cycle2",
                        new Taunt("i hope you are know you will die today <:"),
                        new Shoot(20, 6, -60, 0, -10, coolDown: 2400, coolDownOffset: 2325),
                        new Shoot(20, 6, -60, 0, -20, coolDown: 2500, coolDownOffset: 2650),
                        new Shoot(20, 6, -60, 0, -30, coolDown: 2600, coolDownOffset: 2875), //Simply Sprial shooting miniboss made by Oeti
                        new Shoot(20, 6, -60, 0, -40, coolDown: 2700, coolDownOffset: 2900),
                        new Shoot(20, 6, -60, 0, -50, coolDown: 2800, coolDownOffset: 2975),
new HpLessTransition(.85, "Cycle3")
                        ),
                    new State(
                    new State("Cycle3",
                        new Taunt("huh too esay?"),
                        new Shoot(20, 6, 60, 0, 10, coolDown: 2100, coolDownOffset: 2325),
                        new Shoot(20, 6, 60, 0, 20, coolDown: 1700, coolDownOffset: 2650),
                        new Shoot(20, 6, 60, 0, 30, coolDown: 1400, coolDownOffset: 2875),    //Simply Sprial shooting miniboss made by Oeti
                        new Shoot(20, 6, 60, 0, 40, coolDown: 1300, coolDownOffset: 2900),
                        new Shoot(20, 6, 60, 0, 50, coolDown: 1200, coolDownOffset: 2975),
new HpLessTransition(.668, "Cycle4")
                          ),
                    new State(
                    new State("Cycle4",
                        new Shoot(20, 6, -60, 0, -10, coolDown: 1400, coolDownOffset: 2325),
                        new Shoot(20, 6, -60, 0, -20, coolDown: 1250, coolDownOffset: 2650),
                        new Shoot(20, 6, -60, 0, -30, coolDown: 1200, coolDownOffset: 2875), //Simply Sprial shooting miniboss made by Oeti
                        new Shoot(20, 6, -60, 0, -40, coolDown: 1150, coolDownOffset: 2900),
                        new Shoot(20, 6, -60, 0, -50, coolDown: 1100, coolDownOffset: 2975),
new HpLessTransition(.647, "Cycle5")
                          ),
                    new State(
                    new State("Cycle5",
                        new Taunt("lets get some minions"),
                        new Shoot(20, 6, 60, 0, 10, coolDown: 1500, coolDownOffset: 2325),
                        new Shoot(20, 6, 60, 0, 20, coolDown: 1600, coolDownOffset: 2650),
                        new Shoot(20, 6, 60, 0, 30, coolDown: 1700, coolDownOffset: 2875),    //Simply Sprial shooting miniboss made by Oeti
                        new Shoot(20, 6, 60, 0, 40, coolDown: 1800, coolDownOffset: 2900),
                        new Shoot(20, 6, 60, 0, 50, coolDown: 1900, coolDownOffset: 2975),
                         new Heal(8, "Cycle5", 1000),
                          new Heal(10, "Cycle5", 2000),
                           new Heal(14, "Cycle5", 2000),
                            new Heal(22, "Cycle5", 3000),
                        new TossObject("Graveyardminion", 1, 0, coolDown: 1500, randomToss: true),
new HpLessTransition(.625, "Cycle6")

                        ),
                    new State(
                    new State("Cycle6",
                        new Shoot(20, 6, -60, 0, -10, coolDown: 1500, coolDownOffset: 2325),
                        new Shoot(20, 6, -60, 0, -20, coolDown: 600, coolDownOffset: 2650),
                        new Shoot(20, 6, -60, 0, -30, coolDown: 1700, coolDownOffset: 2875), //Simply Sprial shooting miniboss made by Oeti
                        new Shoot(20, 6, -60, 0, -40, coolDown: 1800, coolDownOffset: 2900),
                        new Shoot(20, 6, -60, 0, -50, coolDown: 900, coolDownOffset: 2975),
new HpLessTransition(.50, "Cycle7")

                        ),
                    new State(
                    new State("Cycle7",
                        new Shoot(20, 6, 60, 0, 10, coolDown: 500, coolDownOffset: 2325),
                        new Shoot(20, 6, 60, 0, 20, coolDown: 600, coolDownOffset: 2650),
                        new Shoot(20, 6, 60, 0, 30, coolDown: 700, coolDownOffset: 2875),    //Simply Sprial shooting miniboss made by Oeti
                        new Shoot(20, 6, 60, 0, 40, coolDown: 1800, coolDownOffset: 2900),
                        new Shoot(20, 6, 60, 0, 50, coolDown: 1900, coolDownOffset: 2975),
new HpLessTransition(.45, "Cycle8")

                        ),
                    new State(
                    new State("Cycle8",
                        new Shoot(20, 6, -60, 0, -10, coolDown: 500, coolDownOffset: 2325),
                        new Shoot(20, 6, -60, 0, -20, coolDown: 600, coolDownOffset: 2650),
                        new Shoot(20, 6, -60, 0, -30, coolDown: 700, coolDownOffset: 2875), //Simply Sprial shooting miniboss made by Oeti
                        new Shoot(20, 6, -60, 0, -40, coolDown: 800, coolDownOffset: 2900),
                        new Shoot(20, 6, -60, 0, -50, coolDown: 1900, coolDownOffset: 2975),
new HpLessTransition(.35, "Cycle9")

                        ),
                    new State(
                    new State("Cycle9",
                        new Shoot(20, 6, 60, 0, 10, coolDown: 500, coolDownOffset: 2325),
                        new Shoot(20, 6, 60, 0, 20, coolDown: 600, coolDownOffset: 2650),
                        new Shoot(20, 6, 60, 0, 30, coolDown: 700, coolDownOffset: 2875),    //Simply Sprial shooting miniboss made by Oeti
                        new Shoot(20, 6, 60, 0, 40, coolDown: 800, coolDownOffset: 2900),
                        new Shoot(20, 6, 60, 0, 50, coolDown: 900, coolDownOffset: 2975),
new HpLessTransition(.25, "Cycle10")

                        ),
                    new State(
                    new State("Cycle10",
new Taunt("sry m8 im done with this stupid shit"),
new Wander(.05),
                        new Shoot(20, 6, -60, 0, -10, coolDown: 1000, coolDownOffset: 1325),
                        new Shoot(20, 6, -60, 0, -20, coolDown: 1100, coolDownOffset: 2650),
                        new Shoot(20, 6, -60, 0, -30, coolDown: 1200, coolDownOffset: 3875), //Simply Sprial shooting miniboss made by Oeti
                        new Shoot(20, 6, -60, 0, -40, coolDown: 1300, coolDownOffset: 4900),
                        new Shoot(20, 6, -60, 0, -50, coolDown: 1400, coolDownOffset: 5975),
new HpLessTransition(.15, "sizechange")
                    ),
                      new State(
                    new State("sizechange",
                        new Wander(0.32),
                        new ChangeSize(25, 225),
                        new Shoot(20, 6, -60, 0, -10, coolDown: -1, coolDownOffset: -1),
                        new HpLessTransition(.10, "RAGEcycle1")
                        ),
                        new State(
                            new Taunt("give me time and YOU DIE!!!!!"),
                            new Wander(.05),
                    new State("RAGEcycle1",
                        new Shoot(20, 6, 60, 0, 10, coolDown: 175, coolDownOffset: 500),
                        new Shoot(20, 6, 60, 0, 20, coolDown: 300, coolDownOffset: 1000),
                        new Shoot(20, 6, 60, 0, 30, coolDown: 350, coolDownOffset: 1500),    //RAGE Sprial shooting miniboss made by oeti
                        new Shoot(20, 6, 60, 0, 40, coolDown: 375, coolDownOffset: 2500),
                        new Shoot(20, 6, 60, 0, 50, coolDown: 400, coolDownOffset: 4500),
                                                 new Heal(8, "RAGEcycle1", 3000),
                          new Heal(10, "RAGEcycle1", 4000),
                           new Heal(14, "RAGEcycle1", 7000),
                            new Heal(22, "RAGEcycle1", 13000),
                        new TossObject("Graveyardminion", 1, 1, coolDown: 600, randomToss: true),
                           new HpLessTransition(.08, "RAGEcycle2")
                        ),
                      new State(
                    new State("RAGEcycle2",
                        new Taunt("WHY YOU DONT DIE!!!!!!!!!!!!"),
                        new Wander(.1),
                         new Shoot(20, 6, -60, 0, -10, coolDown: 250, coolDownOffset: 50),
                        new Shoot(20, 6, -60, 0, -20, coolDown: 220, coolDownOffset: 200),
                        new Shoot(20, 6, -60, 0, -30, coolDown: 270, coolDownOffset: 400),    //RAGE Sprial shooting miniboss made by oeti
                        new Shoot(20, 6, -60, 0, -40, coolDown: 490, coolDownOffset: 1000),
                        new Shoot(20, 6, -60, 0, -50, coolDown: 420, coolDownOffset: 2500),
                        new HpLessTransition(.02, "Death")
                        ),
                        new State("Death",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
new TossObject("Oryx king chest", 1, 0, coolDown: 1000, randomToss: false),
                            new Taunt("HOW YOU SURVIVED?!"),
                            new TossObject("Graveyardminion", 1, 1, coolDown: -1, randomToss: true),
                            new TimedTransition(1000, "Suicide")
                            ),
                        new State("Suicide",
                            new Shoot(5, projectileIndex: 1, count: 73),
                            new TossObject("Graveyardminion", 1, 1, coolDown: -1, randomToss: true),
                            new Suicide()
               )
))))))))))))));
    }
}