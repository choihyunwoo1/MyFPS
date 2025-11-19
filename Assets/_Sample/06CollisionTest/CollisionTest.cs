using UnityEngine;

namespace MySample
{
    /// <summary>
    /// Ãæµ¹Ã¼ÀÇ collision Ãæµ¹ Ã¼Å©
    /// </summary>
    public class CollisionTest : MonoBehaviour
    {
        #region Variables
        MoveObject mv;
        #endregion

        #region Unity Event Method
        private void OnCollisionEnter(Collision collision)
        {
            if (mv == null)
            {
                mv.MoveLeft();
            }
            Debug.Log($"OnCollisionEnter : {collision.gameObject.name}");
            //¿ÞÂÊÀ¸·Î Èû(200f)
        }
        private void OnCollisionStay(Collision collision)
        {
            Debug.Log($"OnCollisionStay : {collision.gameObject.name}");
        }
        private void OnCollisionExit(Collision collision)
        {
            if (mv == null)
            {
                mv.MoveLeft();
            }
            Debug.Log($"OnCollisionExit : {collision.gameObject.name}");
            //¿ÞÂÊÀ¸·Î Èû(200f)
        }
        #endregion

        #region Custom Method

        #endregion

    }
}