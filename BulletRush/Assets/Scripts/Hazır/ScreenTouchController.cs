using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Code
{
	public class ScreenTouchController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
	{
		[SerializeField] private Image pivotImage;
		private Vector2 _touchPosition;
		public Vector2 Direction { get; private set; }

		public void OnPointerDown(PointerEventData eventData) //Dokundu
		{
			_touchPosition = eventData.position; 
			pivotImage.enabled = true;
			pivotImage.transform.position = _touchPosition;
		}

		public void OnPointerUp(PointerEventData eventData)//Parmaðýný kaldýrdý
		{
			Direction = Vector3.zero;
			pivotImage.enabled = false;
		}

		public void OnDrag(PointerEventData eventData)//Parmaðýný sürükledi
		{
			var delta = eventData.position - _touchPosition;
			Direction = delta.normalized;
			
		}
	}
}