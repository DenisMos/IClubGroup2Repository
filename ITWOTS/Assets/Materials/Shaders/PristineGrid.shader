Shader "Pristine Grid"
{
    Properties
    {
        [Toggle] _WorldUV ("Use World Space UV", Float) = 1.0
        _GridScale ("Grid Scale", Float) = 1.0
        
        _LineWidthX ("Line Width X", Range(0,1.0)) = 0.01
        _LineWidthY ("Line Width Y", Range(0,1.0)) = 0.01

        _LineColor ("Line Color", Color) = (1,1,1,1)
        _BaseColor ("Base Color", Color) = (0,0,0,1)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            bool _WorldUV;
            float _GridScale;

            v2f vert (appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);

                if (_WorldUV)
                {
                    // trick to reduce visual artifacts when far from the world origin
                    float3 worldPos = mul(unity_ObjectToWorld, float4(v.vertex.xyz, 1.0)).xyz;
                    
                    // doesn't work properly for stereo rendering at the moment
                #if defined(UNITY_STEREO_MULTIVIEW_ENABLED) || defined(UNITY_SINGLE_PASS_STEREO) || defined(UNITY_STEREO_INSTANCING_ENABLED)
                    o.uv = worldPos.xz;
                #else
                    float3 cameraCenteringOffset = floor(_WorldSpaceCameraPos * _GridScale);
                    o.uv = (worldPos * _GridScale - cameraCenteringOffset).xz;
                #endif
                }
                else
                    o.uv = v.uv * _GridScale;

                return o;
            }

            // grid function from Best Darn Grid article
            float PristineGrid(float2 uv, float2 lineWidth)
            {
                float4 uvDDXY = float4(ddx(uv), ddy(uv));
                float2 uvDeriv = float2(length(uvDDXY.xz), length(uvDDXY.yw));
                bool2 invertLine = lineWidth > 0.5;
                float2 targetWidth = invertLine ? 1.0 - lineWidth : lineWidth;
                float2 drawWidth = clamp(targetWidth, uvDeriv, 0.5);
                float2 lineAA = uvDeriv * 1.5;
                float2 gridUV = abs(frac(uv) * 2.0 - 1.0);
                gridUV = invertLine ? gridUV : 1.0 - gridUV;
                float2 grid2 = smoothstep(drawWidth + lineAA, drawWidth - lineAA, gridUV);
                grid2 *= saturate(targetWidth / drawWidth);
                grid2 = lerp(grid2, targetWidth, saturate(uvDeriv * 2.0 - 1.0));
                grid2 = invertLine ? 1.0 - grid2 : grid2;
                return lerp(grid2.x, 1.0, grid2.y);
            }

            float _LineWidthX, _LineWidthY;
            half4 _LineColor, _BaseColor;

            fixed4 frag (v2f i) : SV_Target
            {
                float grid = PristineGrid(i.uv, float2(_LineWidthX, _LineWidthY));

                // lerp between base and line color
                return lerp(_BaseColor, _LineColor, grid * _LineColor.a);
            }
            ENDCG
        }
    }
}