Shader "Custom/Unlit/Transparent"
{
	Properties
	{
		_Color ("Main Color", Color) = (1, 1, 1, 1)
		_MainTex ("Texture", 2D) = "white" {}
	}
	SubShader
	{
		Tags {
			"Queue"="Transparent"
			"IgnoreProjector"="True"
			"RenderType"="Transparent"
			"PreviewType"="Plane"
		}
		Cull Off
		ZWrite Off
    	Blend SrcAlpha OneMinusSrcAlpha
		Fog { Mode Off }
	Pass
	{
		CGPROGRAM
		#pragma vertex vert
		#pragma fragment frag
		
		struct appdata
		{
			float4 vertex : POSITION;
			float4 color : COLOR;
			float2 texcoord : TEXCOORD0;
		};
		struct v2f
		{
			float4 pos : SV_POSITION;
			fixed4 color : COLOR;
			float2 texcoord : TEXCOORD0;
		};
		
		sampler2D _MainTex;
		uniform float4 _MainTex_ST;
		uniform fixed4 _Color;
		
		v2f vert (appdata v)
		{
			v2f o;
			o.pos = mul(UNITY_MATRIX_MVP, v.vertex);
			o.color = v.color*_Color;
			o.texcoord = v.texcoord;
			return o;
		}
		half4 frag(v2f i) : COLOR
		{
			fixed4 col = i.color;
			return i.color*tex2D(_MainTex, i.texcoord);
		}
		ENDCG
		}
	}
}
