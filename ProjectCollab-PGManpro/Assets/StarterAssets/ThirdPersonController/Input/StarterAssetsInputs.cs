using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif

namespace StarterAssets
{
	public class StarterAssetsInputs : MonoBehaviour
	{
		[Header("Character Input Values")]
		public Vector2 move;
		public Vector2 look;
		public bool jump;
		public bool sprint;

		public bool inDialogue = false;

		[Header("Movement Settings")]
		public bool analogMovement;

		[Header("Mouse Cursor Settings")]
		public bool cursorLocked = false;
		public bool cursorInputForLook = true;

#if ENABLE_INPUT_SYSTEM
		public void OnMove(InputValue value)
		{
			if(!inDialogue){
				MoveInput(value.Get<Vector2>());
			}
			else{
				MoveInput(new Vector2(0, 0));
			}
		}

		public void OnLook(InputValue value)
		{	
			if(!inDialogue){
				if(cursorInputForLook && Keyboard.current.leftAltKey.isPressed)
				{
					LookInput(new Vector2(0, 0));
					Cursor.lockState = CursorLockMode.Confined;
				}
				else{
					LookInput(value.Get<Vector2>());
					Cursor.lockState = CursorLockMode.Locked;
				}
			}else{
				LookInput(new Vector2(0, 0));
				Cursor.lockState = CursorLockMode.Confined;
			}
			
		}

		public void OnJump(InputValue value)
		{
			JumpInput(value.isPressed);
		}

		public void OnSprint(InputValue value)
		{
			SprintInput(value.isPressed);
		}
#endif


		public void MoveInput(Vector2 newMoveDirection)
		{
			move = newMoveDirection;
		} 

		public void LookInput(Vector2 newLookDirection)
		{
			look = newLookDirection;
		}

		public void JumpInput(bool newJumpState)
		{
			jump = newJumpState;
		}

		public void SprintInput(bool newSprintState)
		{
			sprint = newSprintState;
		}

		private void OnApplicationFocus(bool hasFocus)
		{
			SetCursorState(cursorLocked);
		}

		private void SetCursorState(bool newState)
		{
			Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
		}
	}
	
}