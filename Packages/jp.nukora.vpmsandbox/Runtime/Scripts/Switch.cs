
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Nukora.VPMSandbox
{
    public class Switch : UdonSharpBehaviour
    {
        public GameObject target;

        public override void Interact()
        {
            target.SetActive(!target.activeSelf);
        }
    }
}
