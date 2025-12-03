using UnityEngine;
using System.Collections;

namespace MyFps
{
    public class GExitTrigger : MonoBehaviour
    {
        #region Variables
        private BoxCollider collider;

        //씬 이동
        public SceneFader fader;
        [SerializeField]
        private string loadToScene = "MainMenu";
        #endregion

        #region Unity Event Method
        private void Awake()
        {
            //참조
            collider = GetComponent<BoxCollider>();
        }

        private void OnTriggerEnter(Collider other)
        {
            StartCoroutine(SequencePlay());

            //충돌체 비활성화(또는 킬)
            collider.enabled = false;
        }
        #endregion

        #region Custom Method
        IEnumerator SequencePlay()
        {
            AudioManager.Instance.StopBGM();

            yield return new WaitForSeconds(0.1f);

            fader.FadeTo(loadToScene);
        }
        #endregion
    }
}