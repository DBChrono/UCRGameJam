using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Platformer.Mechanics {
    public class EnemyMovements : MonoBehaviour
    {
        public PatrolPath path;
        internal PatrolPath.Mover mover;
        /// <summary>
        internal AnimationController control;
        /// </summary>
        internal Collider2D _collider;
        SpriteRenderer spriteRenderer;
        public Bounds bounds => _collider.bounds;
        // Start is called before the first frame update

        [SerializeField] private Rigidbody2D rb;
        public float speed = 10f;
        private bool facingRight = true;

        private double c = 0;

        void Start()
        {
            control = GetComponent<AnimationController>();
            _collider = GetComponent<Collider2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }


        // Update is called once per frame
        void Update()
        {
            if (facingRight == true) {
                rb.velocity = new Vector2(2, 0);
            } else {
                rb.velocity = new Vector2(-2, 0);
            }
            c+=0.01;
            if (c >= 6) {
                c = 0;
                if (facingRight == true) {
                    facingRight = false;
                } else {
                    facingRight = true;
                }
            }


            if (path != null) {
                if (mover == null) mover = path.CreateMover(7*0.5f);
                control.move.x = Mathf.Clamp(mover.Position.x - transform.position.x, -1, 1);
            }
        }


    }
}