namespace DefaultNamespace
{
    using UnityEngine;

    public class PlayerMovementController : MonoBehaviour
    {
        #region GeneralVars

        [SerializeField] private GameObject player;
        [SerializeField] private float      movementSpeed;

        #endregion

        #region HelperFunctions

        private Vector3 CalculateMovement(Vector3 direction)
        {
            return direction * Time.deltaTime * movementSpeed;
        }

        #endregion

        #region UnityLifeCycle

        private void Start()
        {
            if (player is { })
            {
                player = gameObject;
            }
        }

        private void Update()
        {
            if (Input.GetKey("w"))
            {
                player.transform.position += CalculateMovement(Vector3.forward);
            }

            if (Input.GetKey("a"))
            {
                player.transform.position += CalculateMovement(Vector3.left);
            }

            if (Input.GetKey("s"))
            {
                player.transform.position += CalculateMovement(Vector3.back);
            }

            if (Input.GetKey("d"))
            {
                player.transform.position += CalculateMovement(Vector3.right);
            }
        }

        #endregion
    }
}