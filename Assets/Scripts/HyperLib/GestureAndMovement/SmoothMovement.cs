using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Directions
{
    RIGHT,
    LEFT,
    UP,
    DOWN
}
public class SmoothMovement : MonoBehaviour
{
    bool mouseHoldDown = false;
    void SmoothMoveToTarget(GameMaster gameMaster, Transform transform, GameObject target, string hitObjectName, float moveSpeed)
    {
        if (!gameMaster.onAir)
            return;

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            if (hitObjectName != null) // Only if a specific object is tapped
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    //Select stage    
                    if (hit.transform.name == hitObjectName)
                    {
                        mouseHoldDown = true;
                    }
                    else return;
                }
            }
            else
            {
                mouseHoldDown = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            mouseHoldDown = false;
        }
        if (mouseHoldDown)
        {
            //if (Vector3.Distance(transform.position, target.transform.position) <= 0.00000001f)
            if (transform.position == target.transform.position)
            {
                float h = Input.GetAxis("Mouse X");
                float v = Input.GetAxis("Mouse Y");

                int hSign, vSign;
                hSign = h >= 0 ? 1 : -1;
                vSign = v >= 0 ? 1 : -1;

                Vector3 movement = (new Vector3(h, 0, 0) + new Vector3(0, v, 0));
                if (Mathf.Abs(movement.x) >= Mathf.Abs(movement.y) && Mathf.Abs(movement.x) >= 0.5f)
                {
                    //gameMaster.Instance.playBoard.WantToMove(hSign == 1 ? Directions.RIGHT : Directions.LEFT, PositionOnPlayBoard);
                    target.transform.Translate(hSign * 0.25f, 0, 0);
                    return;

                }
                if (Mathf.Abs(movement.y) >= Mathf.Abs(movement.x) && Mathf.Abs(movement.y) >= 0.5f)
                {
                    //gameMaster.Instance.playBoard.WantToMove(vSign == 1 ? Directions.UP : Directions.DOWN, PositionOnPlayBoard);
                    target.transform.Translate(vSign * 0.25f, 0, 0);
                    return;
                }
            }
        }
    }
}
