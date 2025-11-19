using UnityEngine;

namespace MySample
{
    /// <summary>
    /// 몬스터 타입 정의
    /// </summary>
    public enum MonsterType
    { 
        M_Slime,
        M_Zombie,
        M_Goblin,
        M_Skeleton
        //.....
    }

    /// <summary>
    /// 몬스터의 (기본)부모 클래스
    /// </summary>
    public abstract class Monster //추상 클래스 - 이 클래스를 상속받을 경우, 반드시 정해진 메서드를 구현해야함
    {
        //상속시, 반드시 구현되어야 하는 메서드
        public abstract void Attack();
    }

    /// <summary>
    /// 슬라임 몬스터
    /// </summary>
    public class Slime : Monster
    {
        public override void Attack()
        {
            Debug.Log("Slime Attack");
        }
        //.....그 외 기능들
    }
    /// <summary>
    /// 좀비 몬스터
    /// </summary>
    public class Zombie : Monster
    {
        public override void Attack()
        {
            Debug.Log("Zombie Attack");
        }
        //.....그 외 기능들
    }
    /// <summary>
    /// 고블린 몬스터
    /// </summary>
    public class Goblin : Monster
    {
        public override void Attack()
        {
            Debug.Log("Goblin Attack");
        }
        //.....그 외 기능들
    }
    /// <summary>
    /// 스켈레톤 몬스터
    /// </summary>
    public class Skeleton : Monster
    {
        public override void Attack()
        {
            Debug.Log("Skeleton Attack");
        }
        //.....그 외 기능들
    }
}