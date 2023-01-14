using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

// Physics for hand location + rotation

public class HandPhysics : MonoBehaviour
{

    
    public float smoothingAmount = 15.0f; //smoothing value
    public Transform target = null;   


    private Rigidbody rigidBody = null;
    private Vector3 targetPosition = Vector3.zero;
    private Quarternion targetRotation = Quaternion.identity;

    private void Awake()
    {

        rigidBody = GetComponent<Rigidbody>();

    }

    private void Start()
    {
        TeleportToTarget();
    }

    private void Update()
    {
        SetTargetPosition();
        SetTargetRotation();
    }

    private void SetTargetPosition()
    {
        float time = smoothingAmount * Time.unscaledDeltaTime;
        targetPosition = Vector3.Lerp(targetPosition, target.position, time);

    }

    private void SetTargetRotation()
    {
        float time = smoothingAmount  * Time.unscaledDeltaTime;
        targetRotation = Quaternion.Slerp(targetRotation, target.rotiaon, time;)

    }

    private void FixedUpdate()
    {
        MoveToController();
        RotateToController();

    }

    // move hand to controller's position
    private void MoveToController()
    {
        Vector3 positionDelta = targetPosition - trasform.position;

        rigidBody.velocity = Vector3.zero;
        rigidBody.MovePosition(trasform.position + positionDelta);

    }

    // rotate hand to controller's rotation
    private void RotateToController()
    {
        rigidBody.angularVelocity = Vector3.zero;
        rigidBody.MoveRotation(targetRotation);
    }

    public void TeleportToTarget()
    {
        targetPosition = target.position;
        targetRotation = target.rotation;

        transform.position = targetPosition;
        transform.rotation = targetRotation;
    }
}
