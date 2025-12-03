using UnityEngine;

namespace MyFps
{
    /// <summary>
    /// 메인메뉴 씬을 관리하는 클래스
    /// 메인메뉴 버튼기능, 신페이더 기능
    /// </summary>
    public class MainMenu : MonoBehaviour
    {
        #region Variables
        public SceneFader fader;
        [SerializeField]
        private string loadToScene = "PlayScene01";

        //UI
        public GameObject optionUI;
        public GameObject mainMenuUI;
        #endregion

        #region Unity Event Method
        private void Start()
        {
            //페이드인 시작
            fader.FadeStart();

            //배경음 플레이
            AudioManager.Instance.PlayBGM("MenuMusic");

            // 커서 초기화
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        #endregion

        #region Custom Method
        //버튼 대응 함수 구현, Debug.Log("  버튼 클릭")
        public void NewGame()
        {
            //버튼 효과음
            AudioManager.Instance.Play("ButtonHit");

            fader.FadeTo(loadToScene);
        }

        public void LoadGame()
        {
            Debug.Log("Goto Save Scene");
        }

        public void Options()
        {
            ShowOptionUI();
        }

        public void Credits()
        {
            Debug.Log("Goto Credits Menu");
        }

        public void QuitGame()
        {
            //게임종료
            Application.Quit();

            Debug.Log("QuitGame");
        }

        //옵션 보이기
        private void ShowOptionUI()
        { 
            mainMenuUI.SetActive(false);
            optionUI.SetActive(true);
        }
        //옵션 숨기기
        public void HideOptionUI()
        {
            mainMenuUI.SetActive(true);
            optionUI.SetActive(false);
        }
        #endregion
    }
}