using TMPro;
using UnityEngine;
using System.Collections;

namespace MyFps
{
    public class FullEye : Interactive
    {
        #region Variables
        public GameObject leftEye;
        public GameObject rightEye;
        public GameObject doorSwitch;

        //실패 메세지 UI
        public TextMeshProUGUI sequenceText;
        #endregion

        #region Custom Method

        protected override void DoAction()
        {
            StartCoroutine(PutThePuzzlePices());
        }

        //퍼즐 조각 맞추기
        IEnumerator PutThePuzzlePices()
        {
            bool isLeft = PlayerStats.Instance.HavePuzzleItem(PuzzleItem.LeftEye);
            bool isRight = PlayerStats.Instance.HavePuzzleItem(PuzzleItem.RightEye);

            //퍼즐 조각 맞추기
            if (isLeft)
            {
                leftEye.SetActive(true);
            }
            if (isRight)
            {
                rightEye.SetActive(true);
            }

            //모든 퍼즐조각을 다 맞추었는지 확인
            if (isLeft && isRight) //성공
            {
                doorSwitch.SetActive(true);
            }
            else //실패
            {
                sequenceText.text = "Fill the Blank";
                yield return new WaitForSeconds(2f);
                sequenceText.text = "";

                //충돌체의 콜라이더 복구
                collider.enabled = true;
            }
        }
        #endregion
    }
}