using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QuickVR
{

    public class QuickNetInstantiator : MonoBehaviour
    {

        #region PUBLIC ATTRIBUTES

        public enum InitialPose
        {
            Standing,
            Sitting,
        }
        public InitialPose _initialPose = InitialPose.Standing;

        public RuntimeAnimatorController _initialAnimatorController = null;

        #endregion

        #region GET AND SET

        public virtual bool GetSpotAt(int i, out Vector3 position, out Quaternion rotation)
        {
            position = transform.position;
            rotation = transform.rotation;

            bool isFreeSpot = i < transform.childCount;
            
            if (isFreeSpot)
            {
                Debug.Log("freePosition = " + i);
                //The position is currently free. 
                Transform t = transform.GetChild(i);
                position = t.position;
                rotation = t.rotation;
            }

            return isFreeSpot;
        }

        #endregion

        #region DEBUG

        protected virtual void OnDrawGizmos()
        {
            Gizmos.color = Color.green;
            foreach (Transform t in transform)
            {
                Gizmos.DrawSphere(t.position, 0.25f);
            }
        }

        #endregion

    }

}


