Shader "Custom/Unlit/DepthMaskClear" {
    SubShader {
        Tags {"Queue"="Transparent" }
        Lighting Off
        ZTest Always
        ZWrite On
        ColorMask 0
		Offset 0, 1
        Pass {}
    }
}
