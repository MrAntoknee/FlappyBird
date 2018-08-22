using UnityEngine;

namespace Assets.Scripts.Playmode.Player
{
    namespace Game
    {
        public class TranslateMover : MonoBehaviour
        {
            [SerializeField] private float speed = 0;

            //Notez que nous n’utilisons aucun message. Ce n'est pas interdit.
            public void Move(Vector3 direction)
            {
                transform.Translate(direction * speed * Time.deltaTime);
            }
        }
    }
}
