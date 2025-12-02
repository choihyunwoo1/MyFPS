using UnityEngine;
using System.Collections;

namespace MyFps
{
    /// <summary>
    /// 트리거에 걸리면 액티브 오브젝트를 이용하여 컵을 날린다
    /// </summary>
    public class FFlyObjectTrigger : MonoBehaviour
    {
        #region Variables
        BoxCollider collider;

        public GameObject activateObject;
        public GameObject thePlayer;
        #endregion

        #region Unity Event Method 
        private void Awake()
        {
            collider = GetComponent<BoxCollider>();
        }
        private void OnTriggerEnter(Collider other)
        {
            StartCoroutine(SequencePlay());

            collider.enabled = false;
        }
        #endregion

        #region Custom Method
        IEnumerator SequencePlay()
        { 
            thePlayer.SetActive(false);
            activateObject.SetActive(true);

            yield return new WaitForSeconds(2f);
            activateObject.SetActive(false);
            thePlayer.SetActive(true);
        }
        #endregion
    }
}