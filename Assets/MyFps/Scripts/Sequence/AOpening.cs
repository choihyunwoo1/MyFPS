using System.Collections;
using TMPro;
using UnityEngine;

namespace MyFps
{
    /// <summary>
    /// 플레이씬의 오프닝 연출
    /// </summary>
    public class AOpening : MonoBehaviour
    {
        #region Variables
        public SceneFader fader;

        //플레이어
        public GameObject thePlayer;

        //시퀀스 텍스트
        public TextMeshProUGUI sequenceText;

        //시나리오 텍스트
        [SerializeField]
        string sequence01 = "I need get out of here";
        #endregion

        #region Unity Event Method
        private void Start()
        {
            //시작하자마자 오프닝 연출
            StartCoroutine(SequencePlay());
        }
        #endregion

        #region Custom Method
        //오프닝 시퀀스 연출
        IEnumerator SequencePlay()
        {
            //0.플레이 캐릭터 비활성화
            thePlayer.SetActive(false);

            //1.1초 대기후 페이드인
            fader.FadeStart(2f);

            //2.화면 하단에 시나리오 텍스트 출력 
            sequenceText.text = sequence01;

            //3.3초후 시나리오 텍스트 소멸
            yield return new WaitForSeconds(3f);
            sequenceText.text = ""; //초기화

            //4.플레이 캐릭터 활성화
            thePlayer.SetActive(true);
        }
        #endregion
    }
}