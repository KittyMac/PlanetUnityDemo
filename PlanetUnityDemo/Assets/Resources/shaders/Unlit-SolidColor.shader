Shader "Custom/Unlit/SolidColor"
{
	Properties
	{
		_Color ("Main Color", Color) = (1, 1, 1, 1)
	}
	SubShader
	{
		Tags { "Queue"="Transparent" "IgnoreProjector"="True" }
		Cull Off
    ZTest Off
		ZWrite Off
    Blend SrcAlpha OneMinusSrcAlpha
		Fog { Mode Off }
	Pass
	{
		CGPROGRAM
		#pragma vertex vert
		#pragma fragment frag
		fixed4 _Color;
		struct appdata
		{
			float4 vertex : POSITION;
			float4 color : COLOR;
		};
		struct v2f
		{
			float4 pos : SV_POSITION;
			fixed4 color : COLOR;
		};
		v2f vert (appdata v)
		{
			v2f o;
			o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
			o.color = v.color*_Color;
			return o;
		}
		half4 frag(v2f i) : COLOR
		{
			return i.color;
		}
		ENDCG
		}
	}
}
