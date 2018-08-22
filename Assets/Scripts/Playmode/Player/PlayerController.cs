using Assets.Scripts.Playmode.Player.Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private KeyCode upKey = KeyCode.W;
        [SerializeField] private KeyCode leftKey = KeyCode.A;
        [SerializeField] private KeyCode downKey = KeyCode.S;
        [SerializeField] private KeyCode rightKey = KeyCode.D;

        private TranslateMover translateMover;

        // Use this for initialization
        void Start()
        {
            var position = transform.position;
            Debug.Log("Ma position initiale est : " + position);
        }

        private void Awake()
        {
            translateMover = GetComponent<TranslateMover>();
        }

        // Update is called once per frame
        private void Update()
        {
           

            if (Input.GetKeyDown(upKey))
                transform.Translate(Vector3.up * Time.deltaTime);
            if (Input.GetKeyDown(leftKey))
                transform.Translate(Vector3.left * Time.deltaTime);
            if (Input.GetKeyDown(rightKey))
                transform.Translate(Vector3.right * Time.deltaTime);
            if (Input.GetKeyDown(downKey))
                transform.Translate(Vector3.down * Time.deltaTime);
        }
    }
}
