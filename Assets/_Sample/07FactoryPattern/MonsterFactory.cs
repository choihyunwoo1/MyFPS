using UnityEngine;

namespace MySample
{
    /// <summary>
    /// 심플 팩토리 : 몬스터를 생성하는 클래스
    /// </summary>
    public class MonsterFactory
    {
        public int count = 0; //슬라임 생성 갯수

        //몬스터 생성 메서드
        public Monster CreateMonster(MonsterType mType)
        {
            switch (mType)
            {
                case MonsterType.M_Slime:
                    return new Slime();
                case MonsterType.M_Zombie:
                    return new Zombie();
                case MonsterType.M_Goblin:
                    return new Goblin();
                case MonsterType.M_Skeleton:
                    return new Skeleton();
            }
            return null;
        }
    }
}