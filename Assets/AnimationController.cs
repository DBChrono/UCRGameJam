using UnityEngine;

namespace Platformer.Mechanics {
    public class AnimationController : MonoBehaviour {
        public float maxSpeed = 7;
        public float jumpTakeOffSpeed = 7;

        public Vector2 move;
        public bool jump;
        public bool stopJump;
        SpriteRenderer spriteRenderer;
        Animator animator;
        //PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        protected virtual void Awake() {
            spriteRenderer = GetComponent<SpriteRenderer>();
            animator = GetComponent<Animator>();
        }
    }
}