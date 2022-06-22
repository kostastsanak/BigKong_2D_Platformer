using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Vector3 startPoint;
    Vector3 endPoint;
    public Rigidbody2D rb;

    Camera cam;
    Vector2 force;
    public Vector2 minPower;
    public Vector2 maxPower;

    [SerializeField] private LayerMask GroundLayerMask ;
    [SerializeField] float launchPower = 200;

    private void Start()
    {
        GetComponent<LineRenderer>().enabled = false;
        cam = Camera.main;
    }

    void Update()
    {
        if (transform.position.y < -5)//reset
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

        //Invoke("Movement", 0.3f);//puts delay on the movements
        Movement();

        GetComponent<LineRenderer>().SetPosition(0, startPoint);
        GetComponent<LineRenderer>().SetPosition(1, endPoint);
    }

    void Movement() {

        if (IsGrounded()) {

            if (Input.GetMouseButtonDown(0))
            {
                startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                startPoint.z = 15;
                GetComponent<LineRenderer>().enabled = true;
            }

            if (Input.GetMouseButton(0))
            {

                endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                endPoint.z = 15;
                
            }

            if (Input.GetMouseButtonUp(0))
            {
                endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                endPoint.z = 15;

                force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
                if (GetComponent<LineRenderer>().enabled == true)
                {
                    rb.AddForce(force * launchPower, ForceMode2D.Impulse);
                }
                GetComponent<LineRenderer>().enabled = false;
            }

        }

    }
 

    private bool IsGrounded() {
        bool isitgroundeafterall;
        isitgroundeafterall = transform.Find("GroundCheck").GetComponent<GroundCheck>().isGrounded; //ελεγχει αν ο παιχτης ακουμπαει στο εδαφος και επιστρεφει true or false 
        //Debug.Log("hi");
        return isitgroundeafterall;
    }
}
