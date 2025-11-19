using UnityEngine;

namespace MySample
{
    /// <summary>
    /// 몬스터 생성 예제
    /// </summary>
    public class FactoryTest : MonoBehaviour
    {
        #region Variables

        #endregion

        #region Unity Event Method
        private void Start()
        {
            /*//슬라임 생성, 공격
            Slime slime = new Slime();
            slime.Attack();
            //좀비 생성, 공격
            Zombie zombie = new Zombie();
            zombie.Attack();*/

            //슬라임 생성, 공격
            /*  Monster slime = CreateMonster(MonsterType.M_Slime);
              slime.Attack();
              //좀비 생성, 공격
              Monster zombie = CreateMonster(MonsterType.M_Zombie);
              zombie.Attack();
              //고블린 생성, 공격
              Monster goblin = CreateMonster(MonsterType.M_Goblin);
              goblin.Attack();*/

            /*//심플 팩토리f
            MonsterFactory monsterFactory = new MonsterFactory();
            //슬라임 생성, 공격
            Monster slime = monsterFactory.CreateMonster(MonsterType.M_Slime);
            slime.Attack();
            Monster zombie = monsterFactory.CreateMonster(MonsterType.M_Zombie);
            zombie.Attack();
            Monster goblim = monsterFactory.CreateMonster(MonsterType.M_Goblin;
            goblim.Attack();*/

            // 1) 슬라임 팩토리 생성
            IMonsterFactory slimeFactory = new SlimeFactory();
            Monster slime = slimeFactory.CreateMonster();
            ((SlimeFactory)slimeFactory).SlimeCount(); // 캐스팅해서 호출
            slime.Attack();

            // 2) 좀비 팩토리 생성
            IMonsterFactory zombieFactory = new ZombieFactory();
            Monster zombie = zombieFactory.CreateMonster();
            ((ZombieFactory)zombieFactory).AddSomething(); // 캐스팅해서 호출
            zombie.Attack();

            // 3) 고블린 팩토리 생성
            IMonsterFactory goblinFactory = new GoblinFactory();
            Monster goblin = goblinFactory.CreateMonster();
            goblin.Attack();

        }
        #endregion

        #region Custom Method
        //몬스터 생성 메서드
        private Monster CreateMonster(MonsterType mType)
        {
            switch (mType)
            {
                case MonsterType.M_Slime:
                    return new Slime();
                case MonsterType.M_Zombie:
                    return new Zombie();
                case MonsterType.M_Goblin:
                    return new Goblin();
            }
            return null;
        }
        #endregion
    }
}