using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHandler : MonoBehaviour {

        void Update()
        {
            Vector3 vec3 = this.transform.eulerAngles;
            vec3.y += 20 * Time.deltaTime;
            vec3.y %= 360;

            //
            // vec3.x += 20....  //alway = 90
            // vec3.x %= 90
            this.transform.eulerAngles = vec3;
        }

    }
