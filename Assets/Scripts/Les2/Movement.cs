using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
 
public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private InputActionAsset input;
    [SerializeField] private string actionMapName = "Player";
    private InputAction moveAction;
    private InputAction jumpAction;
    private InputAction sprintAction;
    private InputActionMap map;
    private Animator animator;
    private Rigidbody rb;
     private bool isGrounded = false;
 
    [SerializeField]private float walkSpeed = 5f;
    [SerializeField]private float turnSpeed = 150f;
    [SerializeField]private float jumpForce = 10f;
 
 
 
 
 
    private void Awake()
    {
        InputActionMap map = input.FindActionMap(actionMapName);
        moveAction = map.FindAction("Move");
        jumpAction = map.FindAction("Jump");
        sprintAction = map.FindAction("Sprint");
        rb = GetComponent<Rigidbody>();
 
        animator = GetComponentInChildren<Animator>();
        Debug.Log("Hallo");
    }    
 
    void OnEnable(){input.FindActionMap(actionMapName).Enable();}
    void OnDisable(){input.FindActionMap(actionMapName).Disable();}
    void Start()
    {
       
    }
 
    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = moveAction.ReadValue<Vector2>();
 
        float speed = walkSpeed * moveInput.y;
        Debug.Log("jumpaction: "+ jumpAction.IsPressed());
        Debug.Log("isGrounded:"+ isGrounded);
        if (jumpAction.IsPressed()&& isGrounded)
        {
            Debug.Log("Jummppp");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            animator.SetTrigger("JumpTrigger");
       
        }
        if (moveAction.WasPressedThisFrame())
        {
            Debug.Log("MOOVVEE");
       
        }
        if (sprintAction.IsPressed())
        {
            Debug.Log("Sprintttt");
            speed *= 3f;
       
        }
        Vector3 movement = transform.forward * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
 
        float angle = moveInput.x * turnSpeed * Time.deltaTime;
        transform.Rotate(0f, angle, 0f, Space.World);
 
        animator.SetFloat("Speed", speed);
        animator.SetBool("Grounded", isGrounded);
 
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide:"+ collision.gameObject.CompareTag("Ground"));
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }
 
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }
}
 
 
