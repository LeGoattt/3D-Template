using UnityEngine;

public class playerCam : MonoBehaviour
{
    public Transform cameraPosition;
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    public int target = 120;

    private GameObject gamemanager;
    //public MaskSwitching MaskSwitcher;
    //public bullet_create bullet_Create;
    //public ui ui;
    public Vector3 raycast_point;

    public LayerMask layerMask;

    private void Awake()
    {
        Application.targetFrameRate = target;
    }

    private void Start()
    {
        //ui = FindFirstObjectByType<ui>();
        gamemanager = GameObject.Find("gamemanager");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

        transform.position = cameraPosition.transform.position;
    }
}
