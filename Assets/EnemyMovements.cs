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
        void Start()
        {
            _collider = GetComponent<Collider2D>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
            if (path != null) {
                if (mover == null) mover = path.CreateMover(7*0.5f);
                control.move.x = Mathf.Clamp(mover.Position.x - transform.position.x, -1, 1);
            }
        }
    }
}