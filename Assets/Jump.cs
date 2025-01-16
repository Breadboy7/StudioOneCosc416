using UnityEngine;

public class Jump : MonoBehaviour
{
    private bool canJump;
    [SerializeField]private float deploymentHeight;
    [SerializeField] private float jumpHeight;    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckGroundStatus();
            if (canJump)
            {
                canJump = false;
                gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpHeight, 0));
                Debug.Log("Yay!");
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
                //Debug.Log(canJump);
            }
            else
            {
                canJump = true;
               // Debug.Log(canJump);
            }

        }
    }
}
