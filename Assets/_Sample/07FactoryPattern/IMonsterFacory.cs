using UnityEngine;

namespace MySample
{
    /// <summary>
    /// 몬스터 팩토리 공통된 기능 정의
    /// </summary>
    public interface IMonsterFactory
    {
        public Monster CreateMonster();//팩토리 메서드
    }

    /// <summary>
    /// 슬라임만 생성하는 슬라임 전용 공장
    /// </summary>
    public class SlimeFactory : IMonsterFactory
    {
        public int count = 0; //슬라임 전용 생성 갯수
        public Monster CreateMonster() //팩토리 메서드
        { 
            return new Slime();
        }
        public void SlimeCount() { count++; }
    }
    /// <summary>
    /// 좀비만 생성하는 좀비 전용 공장
    /// </summary>
    public class ZombieFactory : IMonsterFactory
    {
        public Monster CreateMonster() //팩토리 메서드
        {
            return new Zombie();
        }

        public void AddSomething()
        {
            Debug.Log("좀비 생성");
        }
    }
    /// <summary>
    /// 고블린만 생성하는 고블린 전용 공장
    /// </summary>
    public class GoblinFactory : IMonsterFactory
    {
        public Monster CreateMonster() //팩토리 메서드
        {
            return new Goblin();
        }
    }
    /// <summary>
    /// 스켈레톤만 생성하는 스켈레톤 전용 공장
    /// </summary>
    public class SkeletonFactory : IMonsterFactory
    {
        public Monster CreateMonster() //팩토리 메서드
        {
            return new Skeleton();
        }
    }




}