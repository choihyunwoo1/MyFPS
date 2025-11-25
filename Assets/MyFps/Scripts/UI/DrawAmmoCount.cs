using TMPro;
using UnityEngine;

namespace MyFps
{
    /// <summary>
    /// UI - ammocount 갯수 보여주기
    /// </summary>
    public class DrawAmmoCount : MonoBehaviour
    {
        #region Variables
        public TextMeshProUGUI ammoCountText;
        #endregion

        #region Unity Event Method
        private void Update()
        {
            ammoCountText.text = PlayerStat.Instance.AmmoCount.ToString();            
        }
        #endregion

        #region Custom Mehtod
        public void TurnOnAmmoUI()
        {
            
        }
        #endregion
    }
}