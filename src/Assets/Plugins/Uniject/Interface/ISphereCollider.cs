using System;
using UnityEngine;

namespace Testable {
    public interface ISphereCollider : ICollider {
        float radius { get; set; }
        Vector3 center { get; set; }
    }
}

