using UnityEngine;

public class FPSController : MonoBehaviour
{
    public Camera Cam;

    public float horizontalKey = 3f;
    public float verticalKey = 2f;

    float currentH;
    float currentV;

    public float moveSpeed = 2;

    float h;
    float v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        currentH = horizontalKey * Input.GetAxis("X");
        currentV = verticalKey * Input.GetAxis("Y");

        transform.Rotate(0, currentH, 0);
        Cam.transform.Rotate(-currentV, 0, 0);

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(h, 0, v);

        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }
}
