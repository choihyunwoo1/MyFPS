using UnityEngine;

namespace MySample
{
    public class Retargetting : MonoBehaviour
    {
        #region Variables
        Animator animator; //ÂüÁ¶
        const string JumpTrigger = "JumpTrigger";
        #endregion

        #region Unity event Method
        private void Awake()
        {
            animator = GetComponent<Animator>();
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            { 
                animator.SetTrigger(JumpTrigger);
            }
        }
        #endregion

    }
}