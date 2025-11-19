using UnityEngine;

namespace MySample
{
    /// <summary>
    /// 충돌체의 trigger 충돌 체크
    /// </summary>
    public class TriggerTest : MonoBehaviour
    {
        #region Variables
        MoveObject mv;
        #endregion

        #region Unity Event Method
        private void OnTriggerEnter(Collider other)
        {
            if (mv == null)
            {
                mv.MoveRight();
                mv.ChangeMoveColor();
            }
            Debug.Log($"OnTriggerEnter : {other.name}");

            //오른쪽으로 힘(200f), 컬러를 빨간색으로
        }
        private void OnTriggerStay(Collider other)
        {
            Debug.Log($"OnTriggerStay : {other.name}");
        }
        private void OnTriggerExit(Collider other)
        {
            if (mv == null)
            {
                mv.MoveRight();
                mv.ResetMoveColor();
            }
            Debug.Log($"OnTriggerExit : {other.name}");
            //오른쪽으로 힘(200f), 컬러를 원래대로
        }
        #endregion

        #region Custom Method

        #endregion

    }
}