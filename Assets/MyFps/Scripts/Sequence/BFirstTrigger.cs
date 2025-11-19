using UnityEngine;

namespace MyFps
{
    public class BFirstTrigger : MonoBehaviour
    {
        #region Variables
        public GameObject arrow;
        #endregion

        #region Unity Event Method
        private void OnTriggerEnter(Collider other)
        {
            arrow.SetActive(true);
        }
        private void OnTriggerExit(Collider other)
        { 
            arrow?.SetActive(true);
        }
        #endregion

        #region Custom Method

        #endregion
    }
}