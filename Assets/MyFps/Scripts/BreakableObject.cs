using UnityEngine;

namespace MyFps
{
    /// <summary>
    /// 데미지를 입으면 깨지는 오브젝트
    /// 깨지는 연출: Fake오브젝트가 없어지고 Break오브젝트가 활성화된다.
    /// </summary>
    public class BreakableObject : MonoBehaviour, IDamageable
    {
        #region Variables

        [Header("HP 설정")]
        public float maxHp = 50f;
        private float currentHp;

        [Header("깨지기 연출 오브젝트")]
        public GameObject fakeObject;   // 평소 상태
        public GameObject breakObject;  // 깨진 상태 (비활성화 되어 있어야 함)

        private bool isBroken = false;
        #endregion

        #region Unity Event Method
        private void Awake()
        {
            currentHp = maxHp;

            // breakObject는 처음에 꺼져 있어야 함
            if (breakObject != null)
                breakObject.SetActive(false);
        }
        #endregion

        #region Custom Method
        public void TakeDamage(float damage)
        {
            if (isBroken) return;

            currentHp -= damage;

            if (currentHp <= 0)
            {
                Break();
            }
        }

        private void Break()
        {
            isBroken = true;

            // fakeObject 끄기
            if (fakeObject != null)
                fakeObject.SetActive(false);

            // breakObject 켜기
            if (breakObject != null)
                breakObject.SetActive(true);
        }
        #endregion
    }
}