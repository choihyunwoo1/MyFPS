using UnityEngine;
using UnityEngine.Events;

namespace MyFps
{
    /// <summary>
    /// 등록된 문의 열기, 닫기 구현
    /// 인터렉티브 액션으로 이벤트 구현
    /// </summary>
    public class DoorSwitch : Interactive
    {
        #region Variables
        public Door door;

        public Renderer renderer;

        public Material closeMaterial; //닫을때 스위치 컬러
        Material originMaterial; //기존의 메터리얼
        #endregion

        #region Unity Event Method
        protected void Start()
        {
            //초기화
            originMaterial = renderer.material;
        }
        #endregion

        #region Custom Method
        protected override void DoAction()
        {
            if (door == null)
            {
                Debug.LogWarning("DoorSwitch: door reference missing!");
                return;
            }

            door.Toggle();
            renderer.material = closeMaterial;
        }
        #endregion
    }
}