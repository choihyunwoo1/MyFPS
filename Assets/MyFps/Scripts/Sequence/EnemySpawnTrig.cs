using UnityEngine;

namespace MyFps
{
    public class EnemySpawnTrig : MonoBehaviour
    {
        #region Variables
        //참조: 충돌체
        private BoxCollider collider;

        //시퀀스
        public Door door;

        // 새로 추가: Enemy Spawner
        public EnemySpawner spawner;
        #endregion

        #region Unity Event Method
        private void Awake()
        {
            collider = GetComponent<BoxCollider>();
        }

        private void OnTriggerEnter(Collider other)
        {
            SequencePlay();
            collider.enabled = false;  // 트리거 1번만 실행되도록
        }
        #endregion

        #region Custom Method
        private void SequencePlay()
        {
            door.Activate();
            spawner.StartSpawn();
        }
        #endregion
    }
}
