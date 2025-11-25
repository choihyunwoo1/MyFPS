using UnityEngine;

namespace MyFps
{
    public class PickUpAmmo : Interactive
    {
        #region Variables
        [SerializeField]
        int giveAmmo = 7; //Ammo지급 갯수
        #endregion

        #region Custom Method
        //Interactive Action
        protected override void DoAction()
        {
            /*  Debug.Log("탄환 7발을 획득하였습니다.");*/
            PlayerStat.Instance.AddAmmo(giveAmmo);

            //아이템 킬
            Destroy(gameObject);
        }
        #endregion
    }
}