using UnityEngine;
using Unity.Cinemachine;
using System.Collections;

namespace MyFps
{
    /// <summary>
    /// 카메라 흔들림 연출 구현, Singleton 클래스 상속
    /// 흔들림함수(흔들림 시간, 흔들림 크기, 흔들림 속도)
    /// G키를 누르면 흔들림 함수 호출 (치팅)
    /// </summary>
    public class CinemachineShake : Singleton<CinemachineShake>
    {
        #region Variables
        //참조
        CinemachineBasicMultiChannelPerlin m_ChannelPerlin;

     /*   //카메라 흔들림 효과
        [SerializeField]float amplitude = 1f; //흔들림 세기
        [SerializeField]float frequency = 1f; //흔들림 속도
        [SerializeField] float shakeTime = 1f; //흔들림 시간 */

        bool isShake = false; //흔들림 체크
        #endregion

        #region Unity Event Method 
        private void Start()
        {
            m_ChannelPerlin = GetComponent<CinemachineBasicMultiChannelPerlin>();
        }

        private void Update()
        {
           /* //흔들림 효과 치팅
            if (Input.GetKeyDown(KeyCode.G))
            { 
                ShakeCamera();            
            }*/
        }
        #endregion

        #region Custom Method
        //카메라 흔들기
        public void ShakeCamera(float amplitude=1f, float frequency=1f, float shakeTime = 1f)
        {
            if (isShake)
                return;

            StartCoroutine(StartShake(amplitude, frequency, shakeTime));
        }

        IEnumerator StartShake(float amplitude, float frequency, float shakeTime)
        { 
            isShake = true;

            m_ChannelPerlin.AmplitudeGain = amplitude;
            m_ChannelPerlin.FrequencyGain = frequency;

            yield return new WaitForSeconds(shakeTime);

            m_ChannelPerlin.AmplitudeGain = 0;
            m_ChannelPerlin.FrequencyGain = 0;

            isShake = false;
        }
        #endregion

    }
}