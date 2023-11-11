using UnityEngine;

namespace Platformer.Mechanics
{
    public partial class PatrolPath {
        public class Mover {
            PatrolPath path;
            float p = 0;
            float duration;
            float startTime;

            public Mover(PatrolPath path, float speed) {
                this.path = path;
                this.duration = (path.endPosition - path.startPosition).magnitude/speed;
                this.startTime = Time.time;
            }



        }
    }
    



}