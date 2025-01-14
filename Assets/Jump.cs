using UnityEngine;

public class Jump : MonoBehaviour
{
    private bool canJump;
    [SerializeField]private float deploymentHeight;

    // Update is called once per frame
    void Update()
    {
        CheckGroundStatus();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canJump)
            {
                canJump = false;
                //NEED TO ADD FORCE UP
            }
        }

    }
    void CheckGroundStatus()
    {

        RaycastHit hit;
        Ray landingRay = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(transform.position, Vector3.down * deploymentHeight);

        if (Physics.Raycast(landingRay, out hit, deploymentHeight))
        {
            if (hit.collider == null)
            {
                canJump = false;
                Debug.Log(canJump);
            }
            else
            {
                canJump = true;
                Debug.Log(canJump);
            }

        }
    }
}
