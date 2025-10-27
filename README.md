For Quasimorph version 0.9.5, 0.9.7.
Can be added or removed without issue.

The game tries to simulate all visible fired projectile until it expires. So projectile will not expire until it hit a wall or a target.
Worse part is that it does so while keeping the projectile speed.
Of course, you can't do anything while projectile is being processed.

So any very slow projectile you shoot - say, disruptor pistol from DayDream - happen to go to the space in one of those open satellite maps. The slow projectile must travel to the edge of the map until you can take next action. Nothing can stop this even if you have a monster PC.

This mod does the following:
1. Limit the range of projectile to 30 for non-ricocheting projectiles. Projectile will despawn after 30 distance. (ricocheting projectiles already have internal range limit)
2. Raise the speed of the projectile that travelled more than 10 tile to fastest projectile speed in the game. (which is beam projectile speed of 60)
...which will attempt to address this issue.
