using UnityEngine;

namespace MyFps
{
    /// <summary>
    /// ∆€¡Ò æ∆¿Ã≈€ ¡›±‚
    /// </summary>
    public class PickupPuzzleItem : PickupItem
    {
        #region Variables
        //»πµÊ«“ ∆€¡Ò æ∆¿Ã≈€, None, MaxPuzzleItem
        [SerializeField]
        PuzzleItem puzzleItem = PuzzleItem.None;
        #endregion

        #region Custom Method
        protected override void DoAction()
        {
            //∆€¡Ò æ∆¿Ã≈€ »πµÊ
            bool isGain = PlayerStats.Instance.GainPuzzleItem(puzzleItem);

            if (isGain)
            {
                //æ∆¿Ã≈€ ≈≥
                Destroy(gameObject);
            }
        }
        #endregion

    }
}